using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B61 RID: 2913
[Serializable]
public class Anubi : MonoBehaviour
{
	// Token: 0x060040DD RID: 16605 RVA: 0x008395C4 File Offset: 0x008377C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Anubi()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060040DE RID: 16606 RVA: 0x008395D4 File Offset: 0x008377D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (218462 - 99751 != 118711)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (10723 - 553871 == -543148)
			{
				this.mChar.actionState = "standby";
				if (101742 - 249901 == -148159)
				{
					this.mChar.actionTime = Time.time;
					if (235303 - 35769 != 199535)
					{
						this.mChar.myCommand = "none";
						if (62669 - 398519 == -335850)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060040DF RID: 16607 RVA: 0x008396C0 File Offset: 0x008378C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060040E0 RID: 16608 RVA: 0x008396DC File Offset: 0x008378DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (247116 - 539147 != -292030)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (927 - 108286 != -107359)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (165281 - 509233 != -343952)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2F9;
					}
					if (132455 - 408830 == -276374)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (53349 - 243444 == -190094)
				{
					continue;
				}
			}
			IL_2F9:
			if (this.mChar.hp <= 0)
			{
				if (279540 - 564535 != -284995)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (246603 - 245720 == 884)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (165091 - 85719 == 79373)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (64087 - 442461 != -378374)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (207071 - 16460 == 190612)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (107485 - 276983 != -169498)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (138430 - 545650 != -407219)
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
			if (206218 - 519180 == -312962)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (254367 - 448244 != -193876)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (121218 - 462777 != -341558)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (289736 - 51265 != 238472)
						{
							if (this.mChar.isMine)
							{
								if (137909 - 256171 != -118261)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (236031 - 471957 == -235926)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (242164 - 170580 == 71584)
										{
											this.mChar.KoEvent();
											if (160080 - 251650 != -91569)
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
								if (138363 - 112018 != 26346)
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

	// Token: 0x060040E1 RID: 16609 RVA: 0x00839AD4 File Offset: 0x00837CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (211096 - 515737 != -304640)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (288041 - 200642 == 87399)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (90136 - 538572 == -448436)
				{
					if (60222 - 102336 != -42113)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (114369 - 178266 != -63897)
							{
								continue;
							}
							v = 1;
							if (211939 - 52220 == 159720)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (65668 - 215245 == -149576)
							{
								continue;
							}
							v = -1;
							if (294679 - 320748 == -26068)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_livingDead")
						{
							if (212751 - 533339 == -320587)
							{
								continue;
							}
							v = 11;
							if (162507 - 220722 != -58215)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_deathCast")
						{
							if (143396 - 339661 != -196265)
							{
								continue;
							}
							v = 21;
							if (170631 - 804 != 169827)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (170133 - 506611 != -336478)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (45475 - 466134 != -420658)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (4208 - 202628 != -198419)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (256094 - 231787 == 24307)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (248969 - 177270 == 71699)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (170040 - 538903 != -368862)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (593 - 151874 == -151281)
											{
												Hashtable hashtable = new Hashtable();
												if (240816 - 453186 == -212370)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (71444 - 22094 == 49350)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (200196 - 105795 != 94402)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (214450 - 415787 != -201336)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (111587 - 42864 == 68723)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (170328 - 26170 == 144158)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (206340 - 536236 != -329895)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (115300 - 181451 == -66151)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (127019 - 40989 == 86030)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (152984 - 563696 != -410711)
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

	// Token: 0x060040E2 RID: 16610 RVA: 0x00839FEC File Offset: 0x008381EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (145641 - 463204 != -317563)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (221711 - 596460 == -374749)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (135547 - 158646 != -23098)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (210154 - 353745 != -143590)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (91386 - 209424 != -118037)
						{
							int num3 = num;
							if (99009 - 459503 == -360494)
							{
								if (num3 == 1)
								{
									if (230362 - 276863 != -46500)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (236444 - 353335 == -116891)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (298370 - 53186 == 245184)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (86779 - 200706 == -113927)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (274410 - 470239 == -195829)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (231027 - 228265 == 2762)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (117775 - 314694 == -196919)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (165126 - 551338 == -386212)
										{
											this.StartCoroutine_Auto(this.RPC_livingDead(vector, vector2, num2));
											if (254281 - 55914 != 198368)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (255487 - 541748 != -286260)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (98357 - 395811 != -297453)
										{
											this.StartCoroutine_Auto(this.RPC_deathCast(vector, vector2, num2));
											if (18971 - 127740 != -108768)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (210265 - 75477 == 134788)
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

	// Token: 0x060040E3 RID: 16611 RVA: 0x0083A378 File Offset: 0x00838578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (213659 - 411732 != -198073)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (11429 - 98903 == -87474)
			{
				float runSpeed = this.mChar.runSpeed;
				if (9017 - 19539 == -10522)
				{
					Vector3 a = default(Vector3);
					if (127322 - 536178 == -408856)
					{
						Vector3 vector = Vector3.zero;
						if (10063 - 200181 != -190117)
						{
							float num2 = (float)0;
							if (135451 - 471228 == -335777)
							{
								if (this.mChar.isMine)
								{
									if (120734 - 440491 != -319757)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (116252 - 120670 == -4417)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (181855 - 235166 == -53310)
										{
											continue;
										}
										a.y = (float)0;
										if (294229 - 55543 != 238686)
										{
											continue;
										}
										a = a.normalized;
										if (49993 - 173873 != -123880)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (138665 - 51058 != 87607)
										{
											continue;
										}
										vector = vector.normalized;
										if (33075 - 574315 == -541239)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (270137 - 113080 != 157057)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (292470 - 143651 != 148819)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (88459 - 99182 != -10723)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (9417 - 379064 == -369646)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (9484 - 172781 == -163296)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (206024 - 59217 == 146808)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (295043 - 81839 != 213204)
														{
															continue;
														}
														this.animation.Play("run");
														if (158294 - 200970 == -42675)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (30560 - 6630 != 23931)
														{
															goto IL_582;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (235249 - 268400 != -33151)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (95276 - 258072 != -162796)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (113825 - 216477 == -102651)
											{
												continue;
											}
											num = (float)0;
											if (239346 - 377362 != -138016)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (127903 - 188725 == -60821)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (69573 - 266697 != -197124)
										{
											continue;
										}
									}
									IL_582:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (287204 - 139748 == 147457)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (111505 - 34358 == 77148)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (228857 - 395384 == -166526)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (47836 - 443577 != -395741)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (99027 - 557157 != -458130)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (246472 - 300969 == -54496)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (207478 - 575487 != -368009)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (29007 - 475348 == -446340)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (65871 - 84842 == -18970)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (56220 - 432455 == -376234)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (254376 - 136502 == 117875)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (258181 - 334992 != -76811)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (40425 - 286062 == -245636)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (196312 - 294317 != -98005)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (160492 - 18218 == 142275)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (62751 - 68273 != -5522)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (11187 - 215763 == -204575)
												{
													continue;
												}
												num = (float)0;
												if (252050 - 303950 == -51899)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (260057 - 382954 != -122897)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (76528 - 487353 == -410824)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (35227 - 111129 == -75901)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (97768 - 113047 != -15279)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (143529 - 165771 == -22241)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (111393 - 563909 != -452516)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (61025 - 61776 == -750)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (298878 - 190246 == 108633)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (155641 - 81555 != 74086)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (201554 - 404311 == -202756)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (162295 - 493524 != -331229)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (288752 - 342712 == -53959)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (88950 - 309993 != -221043)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (289244 - 318692 != -29448)
											{
												continue;
											}
											num = (float)0;
											if (271305 - 307908 == -36602)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (211935 - 186416 != 25519)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (141374 - 6813 == 134562)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (56331 - 197337 == -141005)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (95123 - 559299 == -464175)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (147690 - 186275 != -38584)
								{
									this.mChar.moveSpeed = num;
									if (70424 - 299430 == -229006)
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

	// Token: 0x060040E4 RID: 16612 RVA: 0x0083AEDC File Offset: 0x008390DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (218691 - 105916 != 112776)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (280930 - 436859 == -155929)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (216161 - 315505 != -99343)
				{
					Vector3 vector = a - this.transform.position;
					if (55981 - 142567 != -86585)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (29660 - 67329 != -37668)
						{
							CharacterControl characterControl = null;
							if (110478 - 140630 == -30152)
							{
								if (100967 - 138210 == -37243)
								{
									if (gameObject)
									{
										if (109667 - 186084 == -76416)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (290741 - 35460 != 255281)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (182594 - 396284 == -213689)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (35591 - 16502 != 19089)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (214654 - 188780 == 25875)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (27425 - 596174 == -568748)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (167136 - 375828 == -208692)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (288119 - 315875 == -27756)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (139177 - 236776 == -97599)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (40985 - 172283 == -131298)
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

	// Token: 0x060040E5 RID: 16613 RVA: 0x0083B1D4 File Offset: 0x008393D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (267312 - 328773 != -61460)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (114439 - 218597 == -104158)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (162962 - 501658 == -338696)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (92894 - 435127 == -342233)
					{
						Vector3 normalized = vector.normalized;
						if (76127 - 90910 != -14782)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (238383 - 140506 == 97877)
							{
								CharacterControl characterControl = null;
								if (235407 - 220339 != 15069)
								{
									if (3222 - 450753 == -447531)
									{
										if (gameObject)
										{
											if (243022 - 121857 != 121165)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (172194 - 197975 == -25780)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (43983 - 117642 != -73659)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (113090 - 17236 != 95854)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (30757 - 294338 != -263581)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (22686 - 562515 != -539829)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (176028 - 214068 != -38039)
										{
											this.StartCoroutine_Auto(this.RPC_livingDead(this.transform.position, normalized, 0));
											if (147894 - 207379 == -59485)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (142127 - 390291 == -248164)
												{
													this.ActionEvent("RPC_livingDead", this.transform.position, normalized, 0);
													if (44746 - 73145 != -28398)
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

	// Token: 0x060040E6 RID: 16614 RVA: 0x0083B4F4 File Offset: 0x008396F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060040E7 RID: 16615 RVA: 0x0083B4F8 File Offset: 0x008396F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Anubi.$RPC_nAttack$31115(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060040E8 RID: 16616 RVA: 0x0083B508 File Offset: 0x00839708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (21616 - 283632 != -262016)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (157678 - 16696 != 140983)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (82834 - 400812 != -317977)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (104033 - 230570 != -126536)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060040E9 RID: 16617 RVA: 0x0083B5C8 File Offset: 0x008397C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_livingDead(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Anubi.$RPC_livingDead$31128(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060040EA RID: 16618 RVA: 0x0083B5D8 File Offset: 0x008397D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_deathCast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Anubi.$RPC_deathCast$31141(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060040EB RID: 16619 RVA: 0x0083B5E8 File Offset: 0x008397E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Anubi.$RPC_ko$31154(nArray, this).GetEnumerator();
	}

	// Token: 0x060040EC RID: 16620 RVA: 0x0083B5F8 File Offset: 0x008397F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Anubi.$RPC_dead$31161(nArray, this).GetEnumerator();
	}

	// Token: 0x060040ED RID: 16621 RVA: 0x0083B608 File Offset: 0x00839808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060040EE RID: 16622 RVA: 0x0083B60C File Offset: 0x0083980C
	internal static bool flb5k45M1OgEjD75Wm20()
	{
		return true;
	}

	// Token: 0x060040EF RID: 16623 RVA: 0x0083B610 File Offset: 0x00839810
	internal static bool CGMCIa5M4OwF7tokoZxc()
	{
		return false;
	}

	// Token: 0x04004D12 RID: 19730
	public CharacterControl mChar;

	// Token: 0x04004D13 RID: 19731
	public GameObject nAttack_hit;

	// Token: 0x04004D14 RID: 19732
	public GameObject cast_ring;

	// Token: 0x04004D15 RID: 19733
	public GameObject livingDead;

	// Token: 0x04004D16 RID: 19734
	public GameObject deathCast;

	// Token: 0x02000B62 RID: 2914
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31115 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060040F0 RID: 16624 RVA: 0x0083B614 File Offset: 0x00839814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31115(Vector3 mPos, Vector3 tDir, Anubi self_)
		{
			if (224427 - 160024 != 64404)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130006 - 468245 != -338238)
				{
					base..ctor();
					if (167571 - 234130 == -66559)
					{
						this.$mPos$31125 = mPos;
						if (109556 - 93022 == 16534)
						{
							this.$tDir$31126 = tDir;
							if (59852 - 318635 != -258782)
							{
								this.$self_$31127 = self_;
								if (113657 - 463443 != -349785)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060040F1 RID: 16625 RVA: 0x0083B6F0 File Offset: 0x008398F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Anubi.$RPC_nAttack$31115.$(this.$mPos$31125, this.$tDir$31126, this.$self_$31127);
		}

		// Token: 0x060040F2 RID: 16626 RVA: 0x0083B70C File Offset: 0x0083990C
		internal static bool X492nu5MzN6iiRJxRP6n()
		{
			return true;
		}

		// Token: 0x060040F3 RID: 16627 RVA: 0x0083B710 File Offset: 0x00839910
		internal static bool kq8aSa5xaljAt9uUjkOV()
		{
			return false;
		}

		// Token: 0x04004D17 RID: 19735
		internal Vector3 $mPos$31125;

		// Token: 0x04004D18 RID: 19736
		internal Vector3 $tDir$31126;

		// Token: 0x04004D19 RID: 19737
		internal Anubi $self_$31127;

		// Token: 0x02000B63 RID: 2915
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060040F4 RID: 16628 RVA: 0x0083B714 File Offset: 0x00839914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Anubi self_)
			{
				if (259899 - 386036 != -126136)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257556 - 134008 == 123548)
					{
						base..ctor();
						if (216858 - 219999 != -3140)
						{
							this.$mPos$31122 = mPos;
							if (232126 - 50588 != 181539)
							{
								this.$tDir$31123 = tDir;
								if (189831 - 454834 == -265003)
								{
									this.$self_$31124 = self_;
									if (160270 - 457532 != -297261)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060040F5 RID: 16629 RVA: 0x0083B7F0 File Offset: 0x008399F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218031 - 381890 != -163859)
				{
				}
				for (;;)
				{
					IL_1D9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_913;
					case 2:
						if (this.$self_$31124.mChar.actionState != "attack")
						{
							if (149123 - 159139 == -10015)
							{
								continue;
							}
							if (this.$self_$31124.mChar.myCommand != "nAttack")
							{
								if (289500 - 327280 != -37780)
								{
									continue;
								}
								goto IL_C1;
							}
						}
						this.$self_$31124.mChar.moveSpeed = (float)2;
						if (7899 - 382601 != -374702)
						{
							continue;
						}
						goto IL_121;
					case 3:
						if (this.$self_$31124.mChar.actionState != "attack")
						{
							if (64761 - 519773 == -455011)
							{
								continue;
							}
							if (this.$self_$31124.mChar.myCommand != "nAttack")
							{
								if (260059 - 562923 != -302864)
								{
									continue;
								}
								goto IL_246;
							}
						}
						this.$hitLayer$31116 = 130816 - (1 << this.$self_$31124.gameObject.layer);
						if (215952 - 118008 == 97945)
						{
							continue;
						}
						this.$hitList$31117 = null;
						if (125150 - 560689 != -435539)
						{
							continue;
						}
						this.$hitPos$31118 = default(Vector3);
						if (102139 - 227463 == -125323)
						{
							continue;
						}
						this.$hitDir$31119 = default(Vector3);
						if (41930 - 121227 == -79296)
						{
							continue;
						}
						if (!this.$self_$31124.mChar.isMine)
						{
							goto IL_4C6;
						}
						if (22374 - 34141 == -11766)
						{
							continue;
						}
						this.$hitList$31117 = Damage.FindAreaTarget(this.$self_$31124.transform.position, (float)2, (float)2, this.$hitLayer$31116);
						if (170385 - 142502 != 27883)
						{
							continue;
						}
						this.$$iterator$10671$31121 = UnityRuntimeServices.GetEnumerator(this.$hitList$31117);
						if (281496 - 178091 != 103405)
						{
							continue;
						}
						while (this.$$iterator$10671$31121.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10671$31121.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$31120 = (GameObject)obj2;
							if (9292 - 206567 == -197274)
							{
								goto IL_1D9;
							}
							this.$hitDir$31119 = global::Math.vFlat(this.$hitObject$31120.transform.position - this.$self_$31124.transform.position).normalized;
							if (71516 - 200699 != -129183)
							{
								goto IL_1D9;
							}
							UnityRuntimeServices.Update(this.$$iterator$10671$31121, this.$hitObject$31120);
							if (284515 - 581369 == -296853)
							{
								goto IL_1D9;
							}
							this.$self_$31124.mChar.hit(1, this.$hitObject$31120, (int)(0.5f * (float)this.$self_$31124.mChar.atk), 3, 0, 0.5f * this.$hitDir$31119);
							if (215708 - 2891 != 212817)
							{
								goto IL_1D9;
							}
							UnityRuntimeServices.Update(this.$$iterator$10671$31121, this.$hitObject$31120);
							if (240978 - 539241 != -298263)
							{
								goto IL_1D9;
							}
						}
						if (46429 - 595787 != -549357)
						{
							goto Block_53;
						}
						continue;
					case 4:
						if (this.$self_$31124.mChar.actionState != "attack")
						{
							if (8284 - 504797 != -496513)
							{
								continue;
							}
							if (this.$self_$31124.mChar.myCommand != "nAttack")
							{
								if (180906 - 45355 != 135551)
								{
									continue;
								}
								goto IL_638;
							}
						}
						this.$self_$31124.mChar.moveSpeed = (float)0;
						if (166068 - 548439 != -382371)
						{
							continue;
						}
						goto IL_5E9;
					case 5:
						if (this.$self_$31124.mChar.actionState == "attack")
						{
							if (203451 - 339745 == -136293)
							{
								continue;
							}
							if (this.$self_$31124.mChar.myCommand == "nAttack")
							{
								if (228675 - 326580 == -97904)
								{
									continue;
								}
								this.$self_$31124.mChar.actionState = "standby";
								if (80386 - 340017 != -259631)
								{
									continue;
								}
								this.$self_$31124.mChar.actionTime = Time.time;
								if (150259 - 5662 != 144597)
								{
									continue;
								}
								this.$self_$31124.mChar.myCommand = "none";
								if (260419 - 364602 == -104182)
								{
									continue;
								}
								if (!this.$self_$31124.mChar.isMine)
								{
									if (42427 - 113424 != -70997)
									{
										continue;
									}
									this.$self_$31124.mChar.nPosition = this.$self_$31124.transform.position;
									if (99200 - 494672 == -395471)
									{
										continue;
									}
									this.$self_$31124.mChar.oPosition = this.$self_$31124.transform.position;
									if (5160 - 237696 != -232536)
									{
										continue;
									}
									this.$self_$31124.mChar.nDirection = this.$self_$31124.transform.forward;
									if (158650 - 434830 != -276180)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (224624 - 123707 != 100917)
						{
							continue;
						}
						goto IL_913;
					default:
						if (201615 - 286535 == -84919)
						{
							continue;
						}
						break;
					}
					this.$self_$31124.mChar.actionState = "attack";
					if (272504 - 56253 != 216252)
					{
						this.$self_$31124.mChar.actionTime = Time.time;
						if (180149 - 144403 != 35747)
						{
							this.$self_$31124.mChar.myCommand = "nAttack";
							if (265757 - 394741 != -128983)
							{
								this.$self_$31124.mChar.addTimeOut("nAttack", (float)2);
								if (153548 - 218868 != -65319)
								{
									this.$self_$31124.transform.position = this.$mPos$31122;
									if (144803 - 455181 == -310378)
									{
										this.$self_$31124.transform.LookAt(this.$mPos$31122 + global::Math.vFlat(this.$tDir$31123));
										if (29089 - 538328 == -509239)
										{
											this.$self_$31124.animation.CrossFade("nAttack");
											if (108346 - 495119 == -386773)
											{
												this.$self_$31124.animation.wrapMode = WrapMode.Once;
												if (269544 - 73807 != 195738)
												{
													this.$self_$31124.mChar.vMovement = this.$self_$31124.transform.forward;
													if (84205 - 430430 == -346225)
													{
														this.$self_$31124.mChar.moveSpeed = (float)0;
														if (85467 - 502749 != -417281)
														{
															goto Block_34;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_C1:
				goto IL_913;
				IL_121:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_246:
				goto IL_913;
				IL_4C6:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_5E9:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_638:
				goto IL_913;
				Block_53:
				goto IL_4C6;
				IL_913:
				return false;
			}

			// Token: 0x060040F6 RID: 16630 RVA: 0x0083C124 File Offset: 0x0083A324
			internal static bool CejhRk5x5AI5A9jjXwLE()
			{
				return true;
			}

			// Token: 0x060040F7 RID: 16631 RVA: 0x0083C128 File Offset: 0x0083A328
			internal static bool MnFrRs5xpA6jswVoPHhT()
			{
				return false;
			}

			// Token: 0x04004D1A RID: 19738
			internal int $hitLayer$31116;

			// Token: 0x04004D1B RID: 19739
			internal UnityScript.Lang.Array $hitList$31117;

			// Token: 0x04004D1C RID: 19740
			internal Vector3 $hitPos$31118;

			// Token: 0x04004D1D RID: 19741
			internal Vector3 $hitDir$31119;

			// Token: 0x04004D1E RID: 19742
			internal GameObject $hitObject$31120;

			// Token: 0x04004D1F RID: 19743
			internal IEnumerator $$iterator$10671$31121;

			// Token: 0x04004D20 RID: 19744
			internal Vector3 $mPos$31122;

			// Token: 0x04004D21 RID: 19745
			internal Vector3 $tDir$31123;

			// Token: 0x04004D22 RID: 19746
			internal Anubi $self_$31124;
		}
	}

	// Token: 0x02000B64 RID: 2916
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_livingDead$31128 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060040F8 RID: 16632 RVA: 0x0083C12C File Offset: 0x0083A32C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_livingDead$31128(Vector3 mPos, Vector3 tDir, int tID, Anubi self_)
		{
			if (156722 - 545504 != -388782)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (197465 - 472364 == -274899)
				{
					base..ctor();
					if (243171 - 259489 == -16318)
					{
						this.$mPos$31137 = mPos;
						if (82531 - 313797 == -231266)
						{
							this.$tDir$31138 = tDir;
							if (106631 - 279905 != -173273)
							{
								this.$tID$31139 = tID;
								if (160433 - 83578 == 76855)
								{
									this.$self_$31140 = self_;
									if (243561 - 297446 != -53884)
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

		// Token: 0x060040F9 RID: 16633 RVA: 0x0083C22C File Offset: 0x0083A42C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Anubi.$RPC_livingDead$31128.$(this.$mPos$31137, this.$tDir$31138, this.$tID$31139, this.$self_$31140);
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x0083C24C File Offset: 0x0083A44C
		internal static bool Ty38J35xV3YIRHx2wSjr()
		{
			return true;
		}

		// Token: 0x060040FB RID: 16635 RVA: 0x0083C250 File Offset: 0x0083A450
		internal static bool PgiBL25xtq4MhutiQGps()
		{
			return false;
		}

		// Token: 0x04004D23 RID: 19747
		internal Vector3 $mPos$31137;

		// Token: 0x04004D24 RID: 19748
		internal Vector3 $tDir$31138;

		// Token: 0x04004D25 RID: 19749
		internal int $tID$31139;

		// Token: 0x04004D26 RID: 19750
		internal Anubi $self_$31140;

		// Token: 0x02000B65 RID: 2917
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060040FC RID: 16636 RVA: 0x0083C254 File Offset: 0x0083A454
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Anubi self_)
			{
				if (213054 - 253017 != -39963)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197867 - 247824 == -49957)
					{
						base..ctor();
						if (113151 - 33305 == 79846)
						{
							this.$mPos$31133 = mPos;
							if (291763 - 551246 == -259483)
							{
								this.$tDir$31134 = tDir;
								if (280731 - 495383 != -214651)
								{
									this.$tID$31135 = tID;
									if (102574 - 487208 == -384634)
									{
										this.$self_$31136 = self_;
										if (124119 - 5051 == 119068)
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

			// Token: 0x060040FD RID: 16637 RVA: 0x0083C354 File Offset: 0x0083A554
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (136026 - 108057 != 27970)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_711;
					case 1:
						goto IL_8E4;
					case 2:
						if (this.$self_$31136.mChar.actionState != "attack")
						{
							if (56126 - 558709 == -502582)
							{
								continue;
							}
							if (this.$self_$31136.mChar.myCommand != "livingDead")
							{
								if (242244 - 473174 != -230929)
								{
									goto Block_23;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31136.mChar.actionState == "attack")
						{
							if (106991 - 507880 != -400889)
							{
								continue;
							}
							if (this.$self_$31136.mChar.myCommand == "livingDead")
							{
								if (115404 - 217521 != -102117)
								{
									continue;
								}
								this.$self_$31136.mChar.actionState = "standby";
								if (127369 - 514105 == -386735)
								{
									continue;
								}
								this.$self_$31136.mChar.actionTime = Time.time;
								if (89032 - 385965 != -296933)
								{
									continue;
								}
								this.$self_$31136.mChar.myCommand = "none";
								if (90353 - 481842 != -391489)
								{
									continue;
								}
								if (!this.$self_$31136.mChar.isMine)
								{
									if (85212 - 474167 == -388954)
									{
										continue;
									}
									this.$self_$31136.mChar.nPosition = this.$self_$31136.transform.position;
									if (13919 - 574739 != -560820)
									{
										continue;
									}
									this.$self_$31136.mChar.oPosition = this.$self_$31136.transform.position;
									if (267250 - 547057 == -279806)
									{
										continue;
									}
									this.$self_$31136.mChar.nDirection = this.$self_$31136.transform.forward;
									if (166327 - 11112 != 155215)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (63798 - 479917 != -416119)
						{
							continue;
						}
						goto IL_8E4;
					default:
						if (150059 - 247801 != -97742)
						{
							continue;
						}
						goto IL_711;
					}
					IL_3AB:
					if (Time.time >= this.$tempTime$31131)
					{
						if (115696 - 47997 == 67700)
						{
							continue;
						}
						if (!this.$tObject$31130)
						{
							goto IL_895;
						}
						if (203173 - 69960 != 133213)
						{
							continue;
						}
						this.$tChar$31132 = (CharacterControl)this.$tObject$31130.GetComponent(typeof(CharacterControl));
						if (81075 - 53229 != 27846)
						{
							continue;
						}
						if (!this.$tChar$31132)
						{
							goto IL_895;
						}
						if (194338 - 358665 != -164327)
						{
							continue;
						}
						if (this.$self_$31136.livingDead)
						{
							if (61266 - 149285 == -88018)
							{
								continue;
							}
							this.$tChar$31132.createEffect(this.$self_$31136.livingDead, this.$tObject$31130.transform.position, Quaternion.identity);
							if (42390 - 108841 != -66451)
							{
								continue;
							}
						}
						if (!this.$self_$31136.mChar.isMine)
						{
							goto IL_895;
						}
						if (104829 - 71943 != 32886)
						{
							continue;
						}
						this.$tChar$31132.RPC_AddStatus("livingDead", 1, 30, 0, this.$self_$31136.mChar.ActorNr);
						if (297289 - 17077 != 280212)
						{
							continue;
						}
						goto IL_895;
					}
					else
					{
						if (this.$tObject$31130)
						{
							if (169386 - 446258 != -276872)
							{
								continue;
							}
							this.$tPos$31129 = this.$tObject$31130.transform.position;
							if (159785 - 152922 == 6864)
							{
								continue;
							}
							this.$tPos$31129.y = this.$self_$31136.transform.position.y;
							if (297157 - 433775 != -136618)
							{
								continue;
							}
						}
						if (!(this.$tObject$31130 != this.$self_$31136.gameObject))
						{
							break;
						}
						if (292482 - 368772 == -76289)
						{
							continue;
						}
						this.$self_$31136.transform.LookAt(this.$tPos$31129);
						if (95005 - 10153 != 84852)
						{
							continue;
						}
						break;
					}
					IL_711:
					this.$self_$31136.mChar.actionState = "attack";
					if (240712 - 86918 == 153794)
					{
						this.$self_$31136.mChar.actionTime = Time.time;
						if (68720 - 423334 == -354614)
						{
							this.$self_$31136.mChar.myCommand = "livingDead";
							if (118253 - 296592 != -178338)
							{
								this.$self_$31136.mChar.addTimeOut("cAttack", (float)6);
								if (9897 - 99807 != -89909)
								{
									this.$self_$31136.transform.position = this.$mPos$31133;
									if (12342 - 345049 != -332706)
									{
										this.$self_$31136.transform.LookAt(this.$mPos$31133 + global::Math.vFlat(this.$tDir$31134));
										if (107936 - 47324 != 60613)
										{
											this.$self_$31136.animation.CrossFade("cast");
											if (273659 - 256820 != 16840)
											{
												this.$self_$31136.animation.wrapMode = WrapMode.Once;
												if (198653 - 258984 == -60331)
												{
													this.$self_$31136.mChar.vMovement = this.$self_$31136.transform.forward;
													if (283916 - 285443 == -1527)
													{
														this.$self_$31136.mChar.moveSpeed = (float)0;
														if (205947 - 261782 == -55835)
														{
															if (this.$self_$31136.cast_ring)
															{
																if (69996 - 286097 == -216100)
																{
																	continue;
																}
																this.$self_$31136.mChar.createEffect(this.$self_$31136.cast_ring, this.$self_$31136.transform.position, Quaternion.identity);
																if (3485 - 528868 != -525383)
																{
																	continue;
																}
															}
															this.$tPos$31129 = this.$mPos$31133 + global::Math.vFlat(this.$tDir$31134);
															if (114207 - 397693 != -283485)
															{
																this.$tObject$31130 = null;
																if (201484 - 257018 != -55533)
																{
																	if (this.$tID$31135 != 0)
																	{
																		if (81491 - 359893 != -278402)
																		{
																			continue;
																		}
																		object obj2;
																		object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31135];
																		if (!(obj is GameObject))
																		{
																			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																		}
																		this.$tObject$31130 = (GameObject)obj2;
																		if (209387 - 392967 != -183580)
																		{
																			continue;
																		}
																	}
																	this.$tempTime$31131 = Time.time + 1.3f;
																	if (280335 - 129061 != 151275)
																	{
																		goto IL_3AB;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.YieldDefault(2);
				Block_23:
				goto IL_8E4;
				IL_895:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_8E4:
				return false;
			}

			// Token: 0x060040FE RID: 16638 RVA: 0x0083CC58 File Offset: 0x0083AE58
			internal static bool IvvgdC5xNvjPMc2GuvOi()
			{
				return true;
			}

			// Token: 0x060040FF RID: 16639 RVA: 0x0083CC5C File Offset: 0x0083AE5C
			internal static bool sJeYm45xY8KxcWx1B9do()
			{
				return false;
			}

			// Token: 0x04004D27 RID: 19751
			internal Vector3 $tPos$31129;

			// Token: 0x04004D28 RID: 19752
			internal GameObject $tObject$31130;

			// Token: 0x04004D29 RID: 19753
			internal float $tempTime$31131;

			// Token: 0x04004D2A RID: 19754
			internal CharacterControl $tChar$31132;

			// Token: 0x04004D2B RID: 19755
			internal Vector3 $mPos$31133;

			// Token: 0x04004D2C RID: 19756
			internal Vector3 $tDir$31134;

			// Token: 0x04004D2D RID: 19757
			internal int $tID$31135;

			// Token: 0x04004D2E RID: 19758
			internal Anubi $self_$31136;
		}
	}

	// Token: 0x02000B66 RID: 2918
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_deathCast$31141 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004100 RID: 16640 RVA: 0x0083CC60 File Offset: 0x0083AE60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_deathCast$31141(Vector3 mPos, Vector3 tDir, int tID, Anubi self_)
		{
			if (118787 - 384887 != -266099)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (293034 - 275421 == 17613)
				{
					base..ctor();
					if (179067 - 38767 != 140301)
					{
						this.$mPos$31150 = mPos;
						if (56719 - 467632 != -410912)
						{
							this.$tDir$31151 = tDir;
							if (52059 - 94552 == -42493)
							{
								this.$tID$31152 = tID;
								if (224419 - 578814 == -354395)
								{
									this.$self_$31153 = self_;
									if (262610 - 204921 != 57690)
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

		// Token: 0x06004101 RID: 16641 RVA: 0x0083CD60 File Offset: 0x0083AF60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Anubi.$RPC_deathCast$31141.$(this.$mPos$31150, this.$tDir$31151, this.$tID$31152, this.$self_$31153);
		}

		// Token: 0x06004102 RID: 16642 RVA: 0x0083CD80 File Offset: 0x0083AF80
		internal static bool vuTqsP5xculmT1qBZk6r()
		{
			return true;
		}

		// Token: 0x06004103 RID: 16643 RVA: 0x0083CD84 File Offset: 0x0083AF84
		internal static bool cpvDo65xU2l91R68pD05()
		{
			return false;
		}

		// Token: 0x04004D2F RID: 19759
		internal Vector3 $mPos$31150;

		// Token: 0x04004D30 RID: 19760
		internal Vector3 $tDir$31151;

		// Token: 0x04004D31 RID: 19761
		internal int $tID$31152;

		// Token: 0x04004D32 RID: 19762
		internal Anubi $self_$31153;

		// Token: 0x02000B67 RID: 2919
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004104 RID: 16644 RVA: 0x0083CD88 File Offset: 0x0083AF88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Anubi self_)
			{
				if (40104 - 402939 != -362835)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193338 - 151376 == 41962)
					{
						base..ctor();
						if (229888 - 439371 == -209483)
						{
							this.$mPos$31146 = mPos;
							if (146427 - 542825 != -396397)
							{
								this.$tDir$31147 = tDir;
								if (143150 - 369786 == -226636)
								{
									this.$tID$31148 = tID;
									if (200737 - 553458 == -352721)
									{
										this.$self_$31149 = self_;
										if (170931 - 238323 != -67391)
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

			// Token: 0x06004105 RID: 16645 RVA: 0x0083CE88 File Offset: 0x0083B088
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90305 - 502775 != -412470)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_85E;
					case 1:
						goto IL_8C7;
					case 2:
						if (this.$self_$31149.mChar.actionState != "attack")
						{
							if (223426 - 360816 != -137390)
							{
								continue;
							}
							if (this.$self_$31149.mChar.myCommand != "deathCast")
							{
								if (124467 - 351840 != -227372)
								{
									goto Block_15;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31149.mChar.actionState == "attack")
						{
							if (159887 - 375094 == -215206)
							{
								continue;
							}
							if (this.$self_$31149.mChar.myCommand == "deathCast")
							{
								if (56155 - 509010 == -452854)
								{
									continue;
								}
								this.$self_$31149.mChar.actionState = "standby";
								if (292163 - 332438 == -40274)
								{
									continue;
								}
								this.$self_$31149.mChar.actionTime = Time.time;
								if (46383 - 221545 == -175161)
								{
									continue;
								}
								this.$self_$31149.mChar.myCommand = "none";
								if (18807 - 343451 == -324643)
								{
									continue;
								}
								if (!this.$self_$31149.mChar.isMine)
								{
									if (260935 - 400012 != -139077)
									{
										continue;
									}
									this.$self_$31149.mChar.nPosition = this.$self_$31149.transform.position;
									if (104768 - 503576 == -398807)
									{
										continue;
									}
									this.$self_$31149.mChar.oPosition = this.$self_$31149.transform.position;
									if (156338 - 535071 == -378732)
									{
										continue;
									}
									this.$self_$31149.mChar.nDirection = this.$self_$31149.transform.forward;
									if (85436 - 322404 != -236968)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (295886 - 326603 != -30716)
						{
							goto Block_49;
						}
						continue;
					default:
						if (240359 - 587164 != -346804)
						{
							goto IL_85E;
						}
						continue;
					}
					IL_242:
					if (Time.time >= this.$tempTime$31144)
					{
						if (117524 - 444375 != -326851)
						{
							continue;
						}
						if (!this.$tObject$31143)
						{
							goto IL_3C2;
						}
						if (175913 - 447589 != -271676)
						{
							continue;
						}
						this.$tChar$31145 = (CharacterControl)this.$tObject$31143.GetComponent(typeof(CharacterControl));
						if (132358 - 147 != 132211)
						{
							continue;
						}
						if (!this.$tChar$31145)
						{
							goto IL_3C2;
						}
						if (155529 - 237296 == -81766)
						{
							continue;
						}
						if (this.$self_$31149.deathCast)
						{
							if (230982 - 598453 != -367471)
							{
								continue;
							}
							this.$tChar$31145.createEffect(this.$self_$31149.deathCast, this.$tObject$31143.transform.position, Quaternion.identity);
							if (146072 - 262230 == -116157)
							{
								continue;
							}
						}
						if (!this.$self_$31149.mChar.isMine)
						{
							goto IL_3C2;
						}
						if (56609 - 232687 == -176077)
						{
							continue;
						}
						this.$self_$31149.mChar.hit(21, this.$tObject$31143, this.$self_$31149.mChar.talAdjust(50), 1, 0, 0.5f * Vector3.up);
						if (21419 - 205547 != -184127)
						{
							goto Block_50;
						}
						continue;
					}
					else
					{
						if (this.$tObject$31143)
						{
							if (273880 - 229639 == 44242)
							{
								continue;
							}
							this.$tPos$31142 = this.$tObject$31143.transform.position;
							if (272861 - 415586 != -142725)
							{
								continue;
							}
							this.$tPos$31142.y = this.$self_$31149.transform.position.y;
							if (239956 - 360828 == -120871)
							{
								continue;
							}
						}
						this.$self_$31149.transform.LookAt(this.$tPos$31142);
						if (55083 - 581549 != -526466)
						{
							continue;
						}
						goto IL_697;
					}
					IL_85E:
					this.$self_$31149.mChar.actionState = "attack";
					if (26265 - 4084 != 22182)
					{
						this.$self_$31149.mChar.actionTime = Time.time;
						if (64345 - 253899 == -189554)
						{
							this.$self_$31149.mChar.myCommand = "deathCast";
							if (201588 - 523855 == -322267)
							{
								this.$self_$31149.mChar.addTimeOut("cAttack", (float)6);
								if (102366 - 503996 != -401629)
								{
									this.$self_$31149.transform.position = this.$mPos$31146;
									if (40766 - 388522 != -347755)
									{
										this.$self_$31149.transform.LookAt(this.$mPos$31146 + global::Math.vFlat(this.$tDir$31147));
										if (116230 - 31926 != 84305)
										{
											this.$self_$31149.animation.CrossFade("cast");
											if (30987 - 34326 == -3339)
											{
												this.$self_$31149.animation.wrapMode = WrapMode.Once;
												if (115422 - 570879 == -455457)
												{
													this.$self_$31149.mChar.vMovement = this.$self_$31149.transform.forward;
													if (14798 - 367258 == -352460)
													{
														this.$self_$31149.mChar.moveSpeed = (float)0;
														if (6184 - 31930 == -25746)
														{
															if (this.$self_$31149.cast_ring)
															{
																if (70160 - 21424 == 48737)
																{
																	continue;
																}
																this.$self_$31149.mChar.createEffect(this.$self_$31149.cast_ring, this.$self_$31149.transform.position, Quaternion.identity);
																if (148127 - 414338 != -266211)
																{
																	continue;
																}
															}
															this.$tPos$31142 = this.$mPos$31146 + global::Math.vFlat(this.$tDir$31147);
															if (233590 - 337412 == -103822)
															{
																this.$tObject$31143 = null;
																if (164265 - 560914 != -396648)
																{
																	if (this.$tID$31148 != 0)
																	{
																		if (174176 - 287304 != -113128)
																		{
																			continue;
																		}
																		object obj2;
																		object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31148];
																		if (!(obj is GameObject))
																		{
																			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																		}
																		this.$tObject$31143 = (GameObject)obj2;
																		if (227255 - 209840 == 17416)
																		{
																			continue;
																		}
																	}
																	this.$tempTime$31144 = Time.time + 1.3f;
																	if (227825 - 235516 == -7691)
																	{
																		goto IL_242;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_8C7;
				IL_3C2:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_697:
				return this.YieldDefault(2);
				Block_49:
				goto IL_8C7;
				Block_50:
				goto IL_3C2;
				IL_8C7:
				return false;
			}

			// Token: 0x06004106 RID: 16646 RVA: 0x0083D770 File Offset: 0x0083B970
			internal static bool FluMia5xTOGN4kkgSxWo()
			{
				return true;
			}

			// Token: 0x06004107 RID: 16647 RVA: 0x0083D774 File Offset: 0x0083B974
			internal static bool En7ZcQ5x3ZlcUMKf4Adj()
			{
				return false;
			}

			// Token: 0x04004D33 RID: 19763
			internal Vector3 $tPos$31142;

			// Token: 0x04004D34 RID: 19764
			internal GameObject $tObject$31143;

			// Token: 0x04004D35 RID: 19765
			internal float $tempTime$31144;

			// Token: 0x04004D36 RID: 19766
			internal CharacterControl $tChar$31145;

			// Token: 0x04004D37 RID: 19767
			internal Vector3 $mPos$31146;

			// Token: 0x04004D38 RID: 19768
			internal Vector3 $tDir$31147;

			// Token: 0x04004D39 RID: 19769
			internal int $tID$31148;

			// Token: 0x04004D3A RID: 19770
			internal Anubi $self_$31149;
		}
	}

	// Token: 0x02000B68 RID: 2920
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31154 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004108 RID: 16648 RVA: 0x0083D778 File Offset: 0x0083B978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31154(UnityScript.Lang.Array nArray, Anubi self_)
		{
			if (91234 - 241178 != -149944)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (258640 - 163423 == 95217)
				{
					base..ctor();
					if (263128 - 361882 != -98753)
					{
						this.$nArray$31159 = nArray;
						if (89894 - 541547 != -451652)
						{
							this.$self_$31160 = self_;
							if (101438 - 426054 != -324615)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004109 RID: 16649 RVA: 0x0083D834 File Offset: 0x0083BA34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Anubi.$RPC_ko$31154.$(this.$nArray$31159, this.$self_$31160);
		}

		// Token: 0x0600410A RID: 16650 RVA: 0x0083D848 File Offset: 0x0083BA48
		internal static bool SuV9gp5xXS7bnIZHkOry()
		{
			return true;
		}

		// Token: 0x0600410B RID: 16651 RVA: 0x0083D84C File Offset: 0x0083BA4C
		internal static bool DXOQVp5xQmEhB8E2j6fX()
		{
			return false;
		}

		// Token: 0x04004D3B RID: 19771
		internal UnityScript.Lang.Array $nArray$31159;

		// Token: 0x04004D3C RID: 19772
		internal Anubi $self_$31160;

		// Token: 0x02000B69 RID: 2921
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600410C RID: 16652 RVA: 0x0083D850 File Offset: 0x0083BA50
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Anubi self_)
			{
				if (264136 - 172036 != 92100)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197138 - 238782 != -41643)
					{
						base..ctor();
						if (66922 - 214704 != -147781)
						{
							this.$nArray$31157 = nArray;
							if (162213 - 244556 != -82342)
							{
								this.$self_$31158 = self_;
								if (52246 - 464111 == -411865)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600410D RID: 16653 RVA: 0x0083D90C File Offset: 0x0083BB0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (15378 - 254298 != -238920)
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
						if (this.$self_$31158.mChar.actionState != "ko")
						{
							if (149309 - 554760 != -405450)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$31158.animation.Play("getUp");
							if (177642 - 375963 == -198320)
							{
								continue;
							}
							this.$self_$31158.animation.wrapMode = WrapMode.Once;
							if (94854 - 270242 != -175388)
							{
								continue;
							}
							goto IL_1F3;
						}
						break;
					case 3:
						if (this.$self_$31158.mChar.actionState != "ko")
						{
							if (81518 - 371121 != -289603)
							{
								continue;
							}
							goto IL_277;
						}
						else
						{
							this.$self_$31158.mChar.actionState = "standby";
							if (181105 - 223664 != -42559)
							{
								continue;
							}
							this.$self_$31158.mChar.actionTime = Time.time;
							if (183752 - 221500 == -37747)
							{
								continue;
							}
							this.$self_$31158.mChar.myCommand = "none";
							if (6890 - 571544 == -564653)
							{
								continue;
							}
							this.$self_$31158.mChar.ko = this.$self_$31158.mChar.mko;
							if (192302 - 400482 != -208180)
							{
								continue;
							}
							this.YieldDefault(1);
							if (68220 - 202800 != -134580)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (187143 - 243979 != -56836)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31158.mChar.actionState == "ko")
					{
						break;
					}
					if (296039 - 567831 != -271791)
					{
						if (this.$self_$31158.mChar.actionState == "dead")
						{
							if (231186 - 479097 != -247910)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31155 = (Vector3)this.$nArray$31157[0];
							if (56851 - 483731 != -426879)
							{
								this.$mDir$31156 = (Vector3)this.$nArray$31157[1];
								if (275855 - 450824 != -174968)
								{
									this.$self_$31158.mChar.ko = 0;
									if (286012 - 118445 != 167568)
									{
										this.$self_$31158.mChar.actionState = "ko";
										if (33140 - 249208 != -216067)
										{
											this.$self_$31158.mChar.actionTime = Time.time;
											if (67663 - 62875 != 4789)
											{
												this.$self_$31158.mChar.myCommand = "none";
												if (279491 - 142771 == 136720)
												{
													this.$self_$31158.mChar.vMovement = Vector3.zero;
													if (70284 - 102771 == -32487)
													{
														this.$self_$31158.mChar.moveSpeed = (float)0;
														if (123689 - 368001 != -244311)
														{
															this.$self_$31158.animation.Play("ko");
															if (223531 - 426442 != -202910)
															{
																this.$self_$31158.animation.wrapMode = WrapMode.Once;
																if (7263 - 156599 != -149335)
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
				goto IL_3BC;
				IL_1F3:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_277:
				goto IL_48C;
				Block_17:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_3BC:
				IL_48C:
				return false;
			}

			// Token: 0x0600410E RID: 16654 RVA: 0x0083DDB8 File Offset: 0x0083BFB8
			internal static bool gRABj95xkfvwb5GrZtmH()
			{
				return true;
			}

			// Token: 0x0600410F RID: 16655 RVA: 0x0083DDBC File Offset: 0x0083BFBC
			internal static bool F22RuI5xGQcU7Leyl4U9()
			{
				return false;
			}

			// Token: 0x04004D3D RID: 19773
			internal Vector3 $mPos$31155;

			// Token: 0x04004D3E RID: 19774
			internal Vector3 $mDir$31156;

			// Token: 0x04004D3F RID: 19775
			internal UnityScript.Lang.Array $nArray$31157;

			// Token: 0x04004D40 RID: 19776
			internal Anubi $self_$31158;
		}
	}

	// Token: 0x02000B6A RID: 2922
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31161 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004110 RID: 16656 RVA: 0x0083DDC0 File Offset: 0x0083BFC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31161(UnityScript.Lang.Array nArray, Anubi self_)
		{
			if (96158 - 424784 != -328625)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268494 - 464172 != -195677)
				{
					base..ctor();
					if (120977 - 245765 == -124788)
					{
						this.$nArray$31166 = nArray;
						if (230127 - 292134 == -62007)
						{
							this.$self_$31167 = self_;
							if (149928 - 440344 == -290416)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004111 RID: 16657 RVA: 0x0083DE7C File Offset: 0x0083C07C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Anubi.$RPC_dead$31161.$(this.$nArray$31166, this.$self_$31167);
		}

		// Token: 0x06004112 RID: 16658 RVA: 0x0083DE90 File Offset: 0x0083C090
		internal static bool tdJjnF5xH5LujOok17Dh()
		{
			return true;
		}

		// Token: 0x06004113 RID: 16659 RVA: 0x0083DE94 File Offset: 0x0083C094
		internal static bool k1vuK05xWuDyUbGdkjV2()
		{
			return false;
		}

		// Token: 0x04004D41 RID: 19777
		internal UnityScript.Lang.Array $nArray$31166;

		// Token: 0x04004D42 RID: 19778
		internal Anubi $self_$31167;

		// Token: 0x02000B6B RID: 2923
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004114 RID: 16660 RVA: 0x0083DE98 File Offset: 0x0083C098
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Anubi self_)
			{
				if (94310 - 572558 != -478248)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237784 - 171082 != 66703)
					{
						base..ctor();
						if (155121 - 22826 == 132295)
						{
							this.$nArray$31164 = nArray;
							if (17825 - 292356 == -274531)
							{
								this.$self_$31165 = self_;
								if (298517 - 151526 == 146991)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004115 RID: 16661 RVA: 0x0083DF54 File Offset: 0x0083C154
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6318 - 40301 != -33982)
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
						if (this.$self_$31165.mChar.actionState != "dead")
						{
							if (50658 - 299373 != -248714)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31165.mChar.isPlayer)
							{
								if (3578 - 586277 == -582698)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31165.gameObject);
								if (92321 - 75401 == 16921)
								{
									continue;
								}
							}
							else if (this.$self_$31165.mChar.isMine)
							{
								if (151104 - 563881 != -412777)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31165.gameObject);
								if (208613 - 436645 != -228032)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (85468 - 512276 != -426808)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (83484 - 231450 == -147965)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31165.mChar.actionState == "dead")
					{
						if (159290 - 101965 == 57325)
						{
							goto IL_14D;
						}
					}
					else
					{
						this.$myPosition$31162 = (Vector3)this.$nArray$31164[0];
						if (70147 - 489262 != -419114)
						{
							this.$myDirection$31163 = (Vector3)this.$nArray$31164[1];
							if (296624 - 57262 == 239362)
							{
								this.$self_$31165.transform.position = this.$myPosition$31162;
								if (17233 - 14963 == 2270)
								{
									this.$self_$31165.transform.LookAt(this.$myPosition$31162 + this.$myDirection$31163);
									if (21821 - 440404 != -418582)
									{
										this.$self_$31165.mChar.hp = 0;
										if (141113 - 343281 == -202168)
										{
											this.$self_$31165.mChar.actionState = "dead";
											if (289488 - 514758 != -225269)
											{
												this.$self_$31165.mChar.actionTime = Time.time;
												if (218491 - 266964 == -48473)
												{
													this.$self_$31165.mChar.myCommand = "none";
													if (268979 - 483354 == -214375)
													{
														this.$self_$31165.mChar.vMovement = Vector3.zero;
														if (135277 - 403984 == -268707)
														{
															this.$self_$31165.mChar.moveSpeed = (float)0;
															if (131378 - 294541 == -163163)
															{
																this.$self_$31165.animation.Rewind();
																if (268369 - 275608 != -7238)
																{
																	this.$self_$31165.animation.Play("ko");
																	if (175397 - 230203 != -54805)
																	{
																		this.$self_$31165.animation.wrapMode = WrapMode.Once;
																		if (146360 - 320097 == -173737)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				IL_14D:
				IL_42F:
				return false;
			}

			// Token: 0x06004116 RID: 16662 RVA: 0x0083E3A4 File Offset: 0x0083C5A4
			internal static bool hcrhKN5xAIRf4LOsfAoR()
			{
				return true;
			}

			// Token: 0x06004117 RID: 16663 RVA: 0x0083E3A8 File Offset: 0x0083C5A8
			internal static bool mdViSi5xlcTGQC3NWwQb()
			{
				return false;
			}

			// Token: 0x04004D43 RID: 19779
			internal Vector3 $myPosition$31162;

			// Token: 0x04004D44 RID: 19780
			internal Vector3 $myDirection$31163;

			// Token: 0x04004D45 RID: 19781
			internal UnityScript.Lang.Array $nArray$31164;

			// Token: 0x04004D46 RID: 19782
			internal Anubi $self_$31165;
		}
	}
}
