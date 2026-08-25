using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000334 RID: 820
[Serializable]
public class Lavu : MonoBehaviour
{
	// Token: 0x0600129C RID: 4764 RVA: 0x001D3540 File Offset: 0x001D1740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lavu()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x001D3550 File Offset: 0x001D1750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (83825 - 370286 != -286460)
		{
		}
		for (;;)
		{
			this.pDn6kgPou8 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (52822 - 200905 != -148082)
			{
				this.pDn6kgPou8.mImmuneList = new UnityScript.Lang.Array("petrify");
				if (50224 - 366114 != -315889)
				{
					this.pDn6kgPou8.hp = (this.pDn6kgPou8.mhp = 3500);
					if (201833 - 212236 != -10402)
					{
						this.pDn6kgPou8.ko = (this.pDn6kgPou8.mko = 100);
						if (246190 - 392859 != -146668)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x001D365C File Offset: 0x001D185C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (27904 - 226633 != -198729)
		{
		}
		for (;;)
		{
			IL_61:
			if (Game.mGameType == 99)
			{
				if (237423 - 379195 == -141771)
				{
					continue;
				}
				this.pDn6kgPou8.isMine = true;
				if (233473 - 458745 == -225271)
				{
					continue;
				}
			}
			this.UEH6AC2bFs = new Transform[6];
			if (225809 - 490838 != -265028)
			{
				this.UEH6AC2bFs[0] = this.transform.Find("body1");
				if (165790 - 475294 == -309504)
				{
					this.UEH6AC2bFs[1] = this.transform.Find("body2");
					if (198544 - 560272 != -361727)
					{
						this.UEH6AC2bFs[2] = this.transform.Find("body3");
						if (46918 - 535398 != -488479)
						{
							this.UEH6AC2bFs[3] = this.transform.Find("body4");
							if (54697 - 178774 != -124076)
							{
								this.UEH6AC2bFs[4] = this.transform.Find("body5");
								if (287082 - 443059 == -155977)
								{
									this.UEH6AC2bFs[5] = this.transform.Find("tail");
									if (138835 - 195462 == -56627)
									{
										this.CEp6910ebN = new Vector3[8];
										if (114583 - 523057 == -408474)
										{
											this.CEp6910ebN[0] = this.transform.position;
											if (49729 - 268442 == -218713)
											{
												int i = 0;
												if (5598 - 197030 == -191432)
												{
													while (i < 6)
													{
														this.CEp6910ebN[i + 1] = this.UEH6AC2bFs[i].position;
														if (218874 - 322960 == -104085)
														{
															goto IL_61;
														}
														i++;
														if (4416 - 353711 == -349294)
														{
															goto IL_61;
														}
													}
													if (15909 - 96452 != -80542)
													{
														this.CEp6910ebN[7] = this.UEH6AC2bFs[5].position;
														if (205973 - 146376 == 59597)
														{
															this.fhi6VotNMM = Time.time + 0.25f;
															if (78130 - 565536 != -487405)
															{
																this.cQ36yhjrTr = this.transform.forward;
																if (145096 - 243000 != -97903)
																{
																	GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
																	if (95312 - 403539 == -308227)
																	{
																		int j = 0;
																		if (44421 - 522464 == -478043)
																		{
																			GameObject[] array2 = array;
																			if (180845 - 300035 != -119189)
																			{
																				int length = array2.Length;
																				if (2051 - 20109 != -18057)
																				{
																					while (j < length)
																					{
																						if (this.gameObject != array2[j])
																						{
																							if (136859 - 273908 != -137049)
																							{
																								goto IL_61;
																							}
																							Physics.IgnoreCollision(this.gameObject.collider, array2[j].collider, true);
																							if (71644 - 8606 != 63038)
																							{
																								goto IL_61;
																							}
																						}
																						j++;
																						if (176554 - 443056 != -266502)
																						{
																							goto IL_61;
																						}
																					}
																					if (280029 - 147544 == 132485)
																					{
																						this.FL76WvmPLG = true;
																						if (104283 - 69929 == 34354)
																						{
																							if (Game.mGameState <= eGameState.Start)
																							{
																								if (258306 - 254046 == 4260)
																								{
																									this.pDn6kgPou8.actionState = "standby";
																									if (178771 - 87367 == 91404)
																									{
																										this.pDn6kgPou8.actionTime = Time.time;
																										if (283705 - 2563 != 281143)
																										{
																											this.pDn6kgPou8.myCommand = "none";
																											if (59846 - 6931 != 52916)
																											{
																												break;
																											}
																										}
																									}
																								}
																							}
																							else
																							{
																								this.StartCoroutine_Auto(this.RPC_create(this.transform.position, this.transform.forward, 0));
																								if (199377 - 47479 == 151898)
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
			}
		}
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x001D3C04 File Offset: 0x001D1E04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (122187 - 355966 != -233779)
		{
		}
		for (;;)
		{
			IL_1AF:
			if (this.pDn6kgPou8.isControlled)
			{
				if (24465 - 215766 != -191301)
				{
					continue;
				}
				this.PlayerControl();
				if (236826 - 514055 != -277229)
				{
					continue;
				}
			}
			else
			{
				this.AIControl();
				if (102047 - 76119 != 25928)
				{
					continue;
				}
			}
			if (this.pDn6kgPou8.hp <= 0)
			{
				if (294819 - 22720 == 272100)
				{
					continue;
				}
				if (this.pDn6kgPou8.actionState != "dead")
				{
					if (83468 - 70580 != 12888)
					{
						continue;
					}
					if (this.pDn6kgPou8.isMine)
					{
						if (84957 - 454395 != -369438)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (205558 - 72791 == 132768)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (248934 - 143981 != 104953)
						{
							continue;
						}
						this.pDn6kgPou8.DeadEvent();
						if (88023 - 590283 != -502259)
						{
							break;
						}
						continue;
					}
					else
					{
						this.pDn6kgPou8.hp = 1;
						if (145467 - 487681 != -342214)
						{
							continue;
						}
						break;
					}
				}
			}
			if (!this.FL76WvmPLG)
			{
				break;
			}
			if (136269 - 16335 == 119934)
			{
				this.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.transform.forward, this.cQ36yhjrTr, Time.deltaTime, 1f));
				if (185186 - 410226 != -225039)
				{
					this.transform.Translate((float)8 * Vector3.forward * Time.deltaTime);
					if (88921 - 527870 != -438948)
					{
						if (Time.time > this.fhi6VotNMM)
						{
							if (68952 - 283698 == -214745)
							{
								continue;
							}
							this.fhi6VotNMM = Time.time + 0.25f;
							if (173402 - 73193 == 100210)
							{
								continue;
							}
							int i = 7;
							if (119610 - 128746 == -9135)
							{
								continue;
							}
							while (i > 0)
							{
								this.CEp6910ebN[i] = this.CEp6910ebN[i - 1];
								if (141113 - 349451 != -208338)
								{
									goto IL_1AF;
								}
								i--;
								if (247564 - 597811 != -350247)
								{
									goto IL_1AF;
								}
							}
							if (219134 - 228522 != -9388)
							{
								continue;
							}
							this.CEp6910ebN[0] = this.transform.position;
							if (246786 - 367165 == -120378)
							{
								continue;
							}
						}
						int j = 0;
						if (153069 - 551365 == -398296)
						{
							while (j < 6)
							{
								if (this.UEH6AC2bFs[j])
								{
									if (13479 - 294791 == -281311)
									{
										goto IL_1AF;
									}
									this.UEH6AC2bFs[j].position = Vector3.Lerp(this.CEp6910ebN[j], this.CEp6910ebN[j + 1], (float)4 * (this.fhi6VotNMM - Time.time));
									if (30419 - 51967 == -21547)
									{
										goto IL_1AF;
									}
									this.UEH6AC2bFs[j].rotation = Quaternion.LookRotation(Vector3.Slerp(this.CEp6910ebN[j] - this.CEp6910ebN[j + 1], this.CEp6910ebN[j + 1] - this.CEp6910ebN[j + 2], (float)4 * (this.fhi6VotNMM - Time.time)));
									if (267509 - 201446 == 66064)
									{
										goto IL_1AF;
									}
								}
								j++;
								if (287749 - 79878 == 207872)
								{
									goto IL_1AF;
								}
							}
							if (161486 - 83906 == 77580)
							{
								if (!this.pDn6kgPou8.isMine)
								{
									break;
								}
								if (175060 - 273376 == -98316)
								{
									this.NetworkUpdate();
									if (218824 - 144376 != 74449)
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

	// Token: 0x060012A0 RID: 4768 RVA: 0x001D41A4 File Offset: 0x001D23A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void NetworkUpdate()
	{
		if (152510 - 248454 != -95944)
		{
		}
		while (Time.time > this.mZh6hP3Fpd)
		{
			if (267099 - 156594 != 110506)
			{
				this.mZh6hP3Fpd = Time.time + 0.1f;
				if (62727 - 420600 != -357872)
				{
					Vector3 vector = this.transform.position + 0.2f * this.cQ36yhjrTr;
					if (143055 - 282327 != -139271)
					{
						Hashtable hashtable = new Hashtable();
						if (59258 - 490833 != -431574)
						{
							hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(vector.x * (float)50)));
							if (191402 - 63834 != 127569)
							{
								hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(vector.y * (float)50)));
								if (94005 - 187915 == -93910)
								{
									hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(vector.z * (float)50)));
									if (43769 - 471808 == -428039)
									{
										hashtable.Add(125, PhotonClient.cInt16(0));
										if (78403 - 399575 == -321172)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (13191 - 267580 != -254388)
											{
												PhotonClient.SendEvent(this.pDn6kgPou8.ActorNr, 73, hashtable, false, false);
												if (286525 - 566288 != -279762)
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

	// Token: 0x060012A1 RID: 4769 RVA: 0x001D43D4 File Offset: 0x001D25D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (32458 - 154813 != -122354)
		{
		}
		for (;;)
		{
			if (this.pDn6kgPou8.actionState != "standby")
			{
				if (129146 - 526149 == -397002)
				{
					continue;
				}
				if (this.pDn6kgPou8.actionState != "run")
				{
					if (173250 - 223788 != -50538)
					{
						continue;
					}
					break;
				}
			}
			if (this.pDn6kgPou8.isMine)
			{
				if (49116 - 8676 == 40441)
				{
					continue;
				}
				this.Oyg6unJbnp = this.transform.position + this.transform.forward + Input.GetAxisRaw("Vertical") * this.transform.up + Input.GetAxisRaw("Horizontal") * this.transform.right;
				if (66730 - 217298 != -150568)
				{
					continue;
				}
				this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
				if (114110 - 495428 != -381318)
				{
					continue;
				}
			}
			else
			{
				this.Oyg6unJbnp = this.pDn6kgPou8.nPosition;
				if (22239 - 332373 == -310133)
				{
					continue;
				}
				this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
				if (10421 - 472867 == -462445)
				{
					continue;
				}
			}
			this.pDn6kgPou8.vMovement = this.cQ36yhjrTr;
			if (62938 - 59863 == 3075)
			{
				this.pDn6kgPou8.moveSpeed = (float)0;
				if (220895 - 79562 == 141333)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x001D461C File Offset: 0x001D281C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (29916 - 229476 != -199560)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (260811 - 593875 == -333064)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (107323 - 591331 == -484008)
				{
					if (91323 - 449123 != -357799)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (263766 - 457617 == -193850)
							{
								continue;
							}
							v = 1;
							if (17117 - 176946 == -159828)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack1_hit")
						{
							if (64990 - 531891 != -466901)
							{
								continue;
							}
							v = -1;
							if (298108 - 232990 == 65119)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2_hit")
						{
							if (83644 - 411988 == -328343)
							{
								continue;
							}
							v = -2;
							if (198623 - 555002 != -356379)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_create")
						{
							if (286690 - 419297 == -132606)
							{
								continue;
							}
							v = 11;
							if (265097 - 119460 == 145638)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Unknown Action Command: " + ActionName);
							if (247448 - 327022 != -79574)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (211345 - 209946 != 1400)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (170969 - 556606 == -385637)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (24153 - 384182 != -360028)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (64641 - 451391 == -386750)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (78745 - 140746 != -62000)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (75596 - 344677 != -269080)
											{
												Hashtable hashtable = new Hashtable();
												if (247565 - 303905 == -56340)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (167113 - 205981 == -38868)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (22170 - 169323 == -147153)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (139366 - 148382 != -9015)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (167565 - 339872 == -172307)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (260052 - 438630 == -178578)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (254112 - 183637 != 70476)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (110897 - 138364 == -27467)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (71119 - 255019 == -183900)
																				{
																					PhotonClient.SendEvent(this.pDn6kgPou8.ActorNr, 74, hashtable, true, true);
																					if (286938 - 173882 != 113057)
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

	// Token: 0x060012A3 RID: 4771 RVA: 0x001D4B34 File Offset: 0x001D2D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (31377 - 67117 != -35740)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (193244 - 327846 == -134602)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (47411 - 438122 == -390711)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (293442 - 290004 != 3439)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (211958 - 270660 == -58702)
						{
							int num3 = num;
							if (247952 - 370455 == -122503)
							{
								if (num3 == 1)
								{
									if (10628 - 275305 != -264676)
									{
										if (this.pDn6kgPou8.isMine)
										{
											break;
										}
										if (7989 - 304409 == -296420)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (89707 - 451888 != -362180)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (117450 - 186259 != -68808)
									{
										this.RPC_nAttack1_hit(vector, vector2, num2);
										if (164934 - 84148 == 80786)
										{
											break;
										}
									}
								}
								else if (num3 == -2)
								{
									if (7538 - 297123 == -289585)
									{
										this.RPC_nAttack2_hit(vector, vector2, num2);
										if (268091 - 349738 != -81646)
										{
											break;
										}
									}
								}
								else if (num3 == 11)
								{
									if (166912 - 152957 == 13955)
									{
										if (this.pDn6kgPou8.isMine)
										{
											break;
										}
										if (16504 - 574999 != -558494)
										{
											this.StartCoroutine_Auto(this.RPC_create(vector, vector2, num2));
											if (216409 - 69037 == 147372)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (275938 - 18871 != 257068)
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

	// Token: 0x060012A4 RID: 4772 RVA: 0x001D4E64 File Offset: 0x001D3064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Lavu.$RPC_nAttack$18472(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x001D4E74 File Offset: 0x001D3074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLavuHeadHit(GameObject hitObject)
	{
		if (81842 - 556653 != -474811)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)hitObject.GetComponent(typeof(CharacterControl));
			if (172886 - 234252 == -61366)
			{
				if (!characterControl)
				{
					break;
				}
				if (30865 - 422304 == -391439)
				{
					if (!characterControl.isMine)
					{
						break;
					}
					if (285906 - 217701 != 68206)
					{
						if (this.pDn6kgPou8.hp <= 0)
						{
							break;
						}
						if (116159 - 215483 == -99324)
						{
							if (this.pDn6kgPou8.hit(1, hitObject, this.pDn6kgPou8.atk, 10, 0, this.transform.forward) == 0)
							{
								break;
							}
							if (30609 - 305102 != -274492)
							{
								Vector3 vector = hitObject.collider.ClosestPointOnBounds(this.transform.position);
								if (133921 - 365835 != -231913)
								{
									this.RPC_nAttack1_hit(vector, Vector3.forward, 0);
									if (131363 - 146235 != -14871)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (95023 - 542827 != -447803)
										{
											this.ActionEvent("RPC_nAttack1_hit", vector, 0.5f * Vector3.forward, 0);
											if (188002 - 152171 == 35831)
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

	// Token: 0x060012A6 RID: 4774 RVA: 0x001D5048 File Offset: 0x001D3248
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onLavuPartHit(GameObject hitObject)
	{
		if (101466 - 122301 != -20834)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)hitObject.GetComponent(typeof(CharacterControl));
			if (57477 - 475212 != -417734)
			{
				if (!characterControl)
				{
					break;
				}
				if (179384 - 471890 == -292506)
				{
					if (!characterControl.isMine)
					{
						break;
					}
					if (160772 - 323109 != -162336)
					{
						if (this.pDn6kgPou8.hp <= 0)
						{
							break;
						}
						if (165776 - 330203 == -164427)
						{
							if (this.pDn6kgPou8.hit(1, hitObject, (int)(0.5f * (float)this.pDn6kgPou8.atk), 5, 0, this.transform.forward) == 0)
							{
								break;
							}
							if (67130 - 17905 == 49225)
							{
								Vector3 vector = hitObject.collider.ClosestPointOnBounds(this.transform.position);
								if (115672 - 70010 == 45662)
								{
									this.RPC_nAttack2_hit(vector, Vector3.forward, 0);
									if (29412 - 517862 != -488449)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (23552 - 459968 != -436415)
										{
											this.ActionEvent("RPC_nAttack2_hit", vector, 0.3f * Vector3.forward, 0);
											if (183314 - 152997 == 30317)
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

	// Token: 0x060012A7 RID: 4775 RVA: 0x001D5224 File Offset: 0x001D3424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack1_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack1_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x001D5250 File Offset: 0x001D3450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack2_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack2_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack2_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x001D527C File Offset: 0x001D347C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_create(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Lavu.$RPC_create$18479(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x001D528C File Offset: 0x001D348C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Lavu.$RPC_dead$18487(nArray, this).GetEnumerator();
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x001D529C File Offset: 0x001D349C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (205813 - 52442 != 153372)
		{
		}
		for (;;)
		{
			if (this.pDn6kgPou8.actionState != "standby")
			{
				if (243138 - 237928 != 5210)
				{
					continue;
				}
				if (this.pDn6kgPou8.actionState != "run")
				{
					if (133086 - 252705 != -119618)
					{
						break;
					}
					continue;
				}
			}
			if (this.pDn6kgPou8.isMine)
			{
				if (295760 - 9848 == 285913)
				{
					continue;
				}
				if (!this.pDn6kgPou8.isAlert)
				{
					if (292939 - 28117 != 264822)
					{
						continue;
					}
					this.AI_visionCheck();
					if (269527 - 491501 != -221974)
					{
						continue;
					}
					this.Oyg6unJbnp = this.pDn6kgPou8.mOriginalPosition;
					if (73664 - 84288 == -10623)
					{
						continue;
					}
					this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
					if (211875 - 250641 == -38765)
					{
						continue;
					}
				}
				else
				{
					this.AI_selectTarget();
					if (287903 - 89584 != 198319)
					{
						continue;
					}
					if (!this.pDn6kgPou8.myAttackTarget)
					{
						if (97970 - 482655 != -384685)
						{
							continue;
						}
						this.pDn6kgPou8.isAlert = false;
						if (64300 - 400457 == -336156)
						{
							continue;
						}
						this.pDn6kgPou8.myAttackTarget = null;
						if (279902 - 107524 == 172379)
						{
							continue;
						}
						this.Oyg6unJbnp = this.pDn6kgPou8.mOriginalPosition;
						if (239630 - 561936 == -322305)
						{
							continue;
						}
						this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
						if (59484 - 71668 != -12184)
						{
							continue;
						}
					}
					else
					{
						this.Oyg6unJbnp = this.pDn6kgPou8.myAttackTarget.collider.bounds.center;
						if (216606 - 373139 != -156533)
						{
							continue;
						}
						this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
						if (169961 - 361121 == -191159)
						{
							continue;
						}
						Vector3 vector = this.Oyg6unJbnp - this.transform.position;
						if (104213 - 335559 != -231346)
						{
							continue;
						}
						if (vector.sqrMagnitude <= (float)100)
						{
							if (147987 - 176883 != -28896)
							{
								continue;
							}
							if (this.pDn6kgPou8.isTimeOut("nAttack") == (float)0)
							{
								if (242800 - 570764 != -327964)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.cQ36yhjrTr, 0));
								if (248574 - 370374 == -121799)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (133888 - 169600 == -35711)
									{
										continue;
									}
									this.ActionEvent("RPC_nAttack", this.transform.position, this.cQ36yhjrTr, 0);
									if (1101 - 264816 != -263715)
									{
										continue;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				this.Oyg6unJbnp = this.pDn6kgPou8.nPosition;
				if (234897 - 181264 != 53633)
				{
					continue;
				}
				this.cQ36yhjrTr = (this.Oyg6unJbnp - this.transform.position).normalized;
				if (56848 - 245228 != -188380)
				{
					continue;
				}
			}
			this.pDn6kgPou8.vMovement = this.cQ36yhjrTr;
			if (234164 - 530085 == -295921)
			{
				this.pDn6kgPou8.moveSpeed = (float)0;
				if (200111 - 593782 == -393671)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x001D5788 File Offset: 0x001D3988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (132941 - 194779 != -61837)
		{
		}
		for (;;)
		{
			IL_382:
			if (this.Fxt6KTIsq0 + (float)1 > Time.time)
			{
				if (138072 - 322135 == -184063)
				{
					break;
				}
			}
			else
			{
				this.Fxt6KTIsq0 = Time.time;
				if (299957 - 72120 != 227838)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (163505 - 450847 != -287341)
					{
						if (37560 - 360922 == -323362)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (118729 - 108759 == 9970)
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
									GameObject gameObject = (GameObject)obj4;
									if (243774 - 121671 == 122104)
									{
										goto IL_382;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (160460 - 270627 == -110166)
									{
										goto IL_382;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (249669 - 124489 == 125181)
									{
										goto IL_382;
									}
									bool flag = true;
									if (103609 - 534835 != -431226)
									{
										goto IL_382;
									}
									if (Game.mGameCode == 911)
									{
										if (29316 - 35781 == -6464)
										{
											goto IL_382;
										}
										if (characterControl.tag == "Player")
										{
											goto IL_3AF;
										}
										if (223174 - 310506 == -87331)
										{
											goto IL_382;
										}
										if (characterControl.Type == "EnlagearBox")
										{
											if (120666 - 196003 != -75337)
											{
												goto IL_382;
											}
											goto IL_3AF;
										}
										goto IL_10B;
										IL_3AF:
										flag = true;
										if (144186 - 381915 == -237728)
										{
											goto IL_382;
										}
									}
									else
									{
										if (characterControl.Race != eRace.Plants)
										{
											if (97339 - 282424 != -185085)
											{
												goto IL_382;
											}
											if (characterControl.Race != eRace.Bugs)
											{
												if (75198 - 345987 == -270788)
												{
													goto IL_382;
												}
												if (characterControl.Race != eRace.Structure)
												{
													goto IL_10B;
												}
												if (3935 - 59362 != -55427)
												{
													goto IL_382;
												}
											}
										}
										flag = false;
										if (277251 - 115949 == 161303)
										{
											goto IL_382;
										}
									}
									IL_10B:
									if (flag)
									{
										if (17742 - 203458 != -185716)
										{
											goto IL_382;
										}
										if (characterControl.hp > 0)
										{
											if (55782 - 145577 != -89795)
											{
												goto IL_382;
											}
											if (characterControl.recieveTarget)
											{
												if (94379 - 415958 == -321578)
												{
													goto IL_382;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (109547 - 164959 == -55411)
													{
														goto IL_382;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (101953 - 493843 == -391889)
														{
															goto IL_382;
														}
														this.pDn6kgPou8.isAlert = true;
														if (134097 - 87539 != 46558)
														{
															goto IL_382;
														}
														this.pDn6kgPou8.myAttackTarget = gameObject;
														if (188254 - 382168 == -193913)
														{
															goto IL_382;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (84602 - 485634 == -401031)
														{
															goto IL_382;
														}
														if (Game.mGameCode == 911)
														{
															if (143036 - 444999 == -301962)
															{
																goto IL_382;
															}
															if (characterControl.Type == "EnlagearBox")
															{
																if (180202 - 354673 != -174471)
																{
																	goto IL_382;
																}
																this.pDn6kgPou8.addHate(characterControl.ActorNr, 100);
																if (198274 - 72125 != 126149)
																{
																	goto IL_382;
																}
																continue;
															}
														}
														this.pDn6kgPou8.addHate(characterControl.ActorNr, 5);
														if (41096 - 14411 == 26686)
														{
															goto IL_382;
														}
													}
												}
											}
										}
									}
								}
								if (275549 - 163554 != 111996)
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

	// Token: 0x060012AD RID: 4781 RVA: 0x001D5C88 File Offset: 0x001D3E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget()
	{
		if (261386 - 58496 != 202890)
		{
		}
		for (;;)
		{
			if (this.wux6z9Uqnx + (float)1 > Time.time)
			{
				if (196519 - 69172 != 127348)
				{
					break;
				}
			}
			else
			{
				this.wux6z9Uqnx = Time.time;
				if (86160 - 293621 == -207461)
				{
					this.pDn6kgPou8.myAttackTarget = this.pDn6kgPou8.getHateTarget(5, 50);
					if (258039 - 438448 != -180408)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x001D5D4C File Offset: 0x001D3F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x001D5D50 File Offset: 0x001D3F50
	internal static bool lxT54oCLMgJxvw7Z4Ux()
	{
		return true;
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x001D5D54 File Offset: 0x001D3F54
	internal static bool wfF402COBYqTLt1f1SW()
	{
		return false;
	}

	// Token: 0x04001033 RID: 4147
	private CharacterControl pDn6kgPou8;

	// Token: 0x04001034 RID: 4148
	private int jJX6FUtLZr;

	// Token: 0x04001035 RID: 4149
	private Transform[] UEH6AC2bFs;

	// Token: 0x04001036 RID: 4150
	private Vector3[] CEp6910ebN;

	// Token: 0x04001037 RID: 4151
	private bool FL76WvmPLG;

	// Token: 0x04001038 RID: 4152
	private Vector3 Oyg6unJbnp;

	// Token: 0x04001039 RID: 4153
	private Vector3 cQ36yhjrTr;

	// Token: 0x0400103A RID: 4154
	private float fhi6VotNMM;

	// Token: 0x0400103B RID: 4155
	private float mZh6hP3Fpd;

	// Token: 0x0400103C RID: 4156
	public GameObject nAttack1_hit;

	// Token: 0x0400103D RID: 4157
	public GameObject nAttack2_hit;

	// Token: 0x0400103E RID: 4158
	public GameObject create_ring;

	// Token: 0x0400103F RID: 4159
	private float Fxt6KTIsq0;

	// Token: 0x04001040 RID: 4160
	private float wux6z9Uqnx;

	// Token: 0x02000335 RID: 821
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18472 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012B1 RID: 4785 RVA: 0x001D5D58 File Offset: 0x001D3F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18472(Vector3 mPos, Vector3 tDir, Lavu self_)
		{
			if (292079 - 37145 != 254934)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201460 - 447605 == -246145)
				{
					base..ctor();
					if (169819 - 279324 != -109504)
					{
						this.$mPos$18476 = mPos;
						if (247240 - 35770 != 211471)
						{
							this.$tDir$18477 = tDir;
							if (297232 - 595167 != -297934)
							{
								this.$self_$18478 = self_;
								if (118361 - 312842 == -194481)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012B2 RID: 4786 RVA: 0x001D5E34 File Offset: 0x001D4034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lavu.$RPC_nAttack$18472.$(this.$mPos$18476, this.$tDir$18477, this.$self_$18478);
		}

		// Token: 0x060012B3 RID: 4787 RVA: 0x001D5E50 File Offset: 0x001D4050
		internal static bool HfjinCCmyLVty2NaEtv()
		{
			return true;
		}

		// Token: 0x060012B4 RID: 4788 RVA: 0x001D5E54 File Offset: 0x001D4054
		internal static bool VPTqqNCF2B9NIQxQ4Lh()
		{
			return false;
		}

		// Token: 0x04001041 RID: 4161
		internal Vector3 $mPos$18476;

		// Token: 0x04001042 RID: 4162
		internal Vector3 $tDir$18477;

		// Token: 0x04001043 RID: 4163
		internal Lavu $self_$18478;

		// Token: 0x02000336 RID: 822
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012B5 RID: 4789 RVA: 0x001D5E58 File Offset: 0x001D4058
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Lavu self_)
			{
				if (225627 - 523258 != -297630)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37753 - 393498 == -355745)
					{
						base..ctor();
						if (292634 - 230457 != 62178)
						{
							this.$mPos$18473 = mPos;
							if (13756 - 161819 == -148063)
							{
								this.$tDir$18474 = tDir;
								if (92668 - 408482 == -315814)
								{
									this.$self_$18475 = self_;
									if (147435 - 411809 == -264374)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060012B6 RID: 4790 RVA: 0x001D5F34 File Offset: 0x001D4134
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233275 - 405480 != -172204)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F2;
					case 2:
						if (this.$self_$18475.pDn6kgPou8.actionState == "attack")
						{
							if (103646 - 197977 != -94331)
							{
								continue;
							}
							if (this.$self_$18475.pDn6kgPou8.myCommand == "nAttack")
							{
								if (266379 - 122165 != 144214)
								{
									continue;
								}
								this.$self_$18475.pDn6kgPou8.actionState = "standby";
								if (186047 - 1583 != 184464)
								{
									continue;
								}
								this.$self_$18475.pDn6kgPou8.actionTime = Time.time;
								if (299839 - 274954 != 24885)
								{
									continue;
								}
								this.$self_$18475.pDn6kgPou8.myCommand = "none";
								if (206975 - 397689 == -190713)
								{
									continue;
								}
								if (!this.$self_$18475.pDn6kgPou8.isMine)
								{
									if (258164 - 360042 == -101877)
									{
										continue;
									}
									this.$self_$18475.pDn6kgPou8.nPosition = this.$self_$18475.transform.position;
									if (226586 - 290302 == -63715)
									{
										continue;
									}
									this.$self_$18475.pDn6kgPou8.oPosition = this.$self_$18475.transform.position;
									if (106303 - 186595 == -80291)
									{
										continue;
									}
									this.$self_$18475.pDn6kgPou8.nDirection = this.$self_$18475.transform.forward;
									if (50063 - 458971 != -408908)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (278531 - 5154 != 273378)
						{
							goto Block_5;
						}
						continue;
					default:
						if (191931 - 65194 != 126737)
						{
							continue;
						}
						break;
					}
					this.$self_$18475.pDn6kgPou8.actionState = "attack";
					if (137692 - 353520 == -215828)
					{
						this.$self_$18475.pDn6kgPou8.actionTime = Time.time;
						if (93116 - 452726 != -359609)
						{
							this.$self_$18475.pDn6kgPou8.myCommand = "nAttack";
							if (9305 - 536986 == -527681)
							{
								this.$self_$18475.pDn6kgPou8.addTimeOut("nAttack", (float)18);
								if (13819 - 327341 != -313521)
								{
									this.$self_$18475.transform.position = this.$mPos$18473;
									if (95068 - 6085 == 88983)
									{
										this.$self_$18475.transform.LookAt(this.$mPos$18473 + this.$tDir$18474);
										if (21588 - 441554 == -419966)
										{
											this.$self_$18475.Oyg6unJbnp = this.$mPos$18473 + (float)12 * this.$tDir$18474;
											if (285411 - 448486 != -163074)
											{
												this.$self_$18475.cQ36yhjrTr = this.$tDir$18474;
												if (54805 - 438683 != -383877)
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
				Block_5:
				goto IL_3F2;
				Block_9:
				return this.Yield(2, new WaitForSeconds(0.8f));
				IL_3F2:
				return false;
			}

			// Token: 0x060012B7 RID: 4791 RVA: 0x001D6348 File Offset: 0x001D4548
			internal static bool PIipVZCMyloOewrbAXR()
			{
				return true;
			}

			// Token: 0x060012B8 RID: 4792 RVA: 0x001D634C File Offset: 0x001D454C
			internal static bool LSH0EICxLoK3vIvaVfd()
			{
				return false;
			}

			// Token: 0x04001044 RID: 4164
			internal Vector3 $mPos$18473;

			// Token: 0x04001045 RID: 4165
			internal Vector3 $tDir$18474;

			// Token: 0x04001046 RID: 4166
			internal Lavu $self_$18475;
		}
	}

	// Token: 0x02000337 RID: 823
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_create$18479 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012B9 RID: 4793 RVA: 0x001D6350 File Offset: 0x001D4550
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_create$18479(Vector3 mPos, Vector3 tDir, Lavu self_)
		{
			if (257984 - 130703 != 127281)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213442 - 168703 != 44740)
				{
					base..ctor();
					if (185167 - 121391 != 63777)
					{
						this.$mPos$18484 = mPos;
						if (70781 - 415405 == -344624)
						{
							this.$tDir$18485 = tDir;
							if (289410 - 582320 == -292910)
							{
								this.$self_$18486 = self_;
								if (216638 - 589560 == -372922)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060012BA RID: 4794 RVA: 0x001D642C File Offset: 0x001D462C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lavu.$RPC_create$18479.$(this.$mPos$18484, this.$tDir$18485, this.$self_$18486);
		}

		// Token: 0x060012BB RID: 4795 RVA: 0x001D6448 File Offset: 0x001D4648
		internal static bool a09Sq5CgKG11rsukfDx()
		{
			return true;
		}

		// Token: 0x060012BC RID: 4796 RVA: 0x001D644C File Offset: 0x001D464C
		internal static bool moKLXnCfMiT8sXF9upw()
		{
			return false;
		}

		// Token: 0x04001047 RID: 4167
		internal Vector3 $mPos$18484;

		// Token: 0x04001048 RID: 4168
		internal Vector3 $tDir$18485;

		// Token: 0x04001049 RID: 4169
		internal Lavu $self_$18486;

		// Token: 0x02000338 RID: 824
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012BD RID: 4797 RVA: 0x001D6450 File Offset: 0x001D4650
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Lavu self_)
			{
				if (4259 - 417518 != -413259)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (63347 - 76468 != -13120)
					{
						base..ctor();
						if (121741 - 83546 == 38195)
						{
							this.$mPos$18481 = mPos;
							if (20204 - 229479 != -209274)
							{
								this.$tDir$18482 = tDir;
								if (60905 - 487057 != -426151)
								{
									this.$self_$18483 = self_;
									if (117147 - 352270 == -235123)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060012BE RID: 4798 RVA: 0x001D652C File Offset: 0x001D472C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (164003 - 486250 != -322246)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_35A;
					case 1:
						goto IL_5B7;
					case 2:
						this.$i$18480++;
						if (75983 - 129415 == -53431)
						{
							continue;
						}
						break;
					case 3:
						if (this.$self_$18483.pDn6kgPou8.actionState == "attack")
						{
							if (97641 - 149354 != -51713)
							{
								continue;
							}
							if (this.$self_$18483.pDn6kgPou8.myCommand == "create")
							{
								if (30441 - 512265 == -481823)
								{
									continue;
								}
								this.$self_$18483.pDn6kgPou8.actionState = "standby";
								if (73889 - 546087 == -472197)
								{
									continue;
								}
								this.$self_$18483.pDn6kgPou8.actionTime = Time.time;
								if (94040 - 10759 != 83281)
								{
									continue;
								}
								this.$self_$18483.pDn6kgPou8.myCommand = "none";
								if (136489 - 522936 == -386446)
								{
									continue;
								}
								if (!this.$self_$18483.pDn6kgPou8.isMine)
								{
									if (72006 - 330071 == -258064)
									{
										continue;
									}
									this.$self_$18483.pDn6kgPou8.nPosition = this.$self_$18483.transform.position;
									if (261221 - 269968 != -8747)
									{
										continue;
									}
									this.$self_$18483.pDn6kgPou8.oPosition = this.$self_$18483.transform.position;
									if (226027 - 212836 == 13192)
									{
										continue;
									}
									this.$self_$18483.pDn6kgPou8.nDirection = this.$self_$18483.transform.forward;
									if (128512 - 395522 == -267009)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (204211 - 331353 != -127142)
						{
							continue;
						}
						goto IL_5B7;
					default:
						if (140287 - 238794 != -98506)
						{
							goto IL_35A;
						}
						continue;
					}
					IL_78:
					if (this.$i$18480 >= 4)
					{
						if (258938 - 101466 != 157472)
						{
							continue;
						}
						break;
					}
					else
					{
						Vector3 vector = Camera.main.transform.position - this.$mPos$18481;
						if (153224 - 145618 != 7606)
						{
							continue;
						}
						if (vector.sqrMagnitude >= (float)900)
						{
							goto IL_4B1;
						}
						if (298949 - 296085 == 2865)
						{
							continue;
						}
						Camera.main.SendMessage("AddCamereShake", 0.3f);
						if (251752 - 593294 != -341541)
						{
							goto Block_36;
						}
						continue;
					}
					IL_35A:
					this.$self_$18483.pDn6kgPou8.actionState = "attack";
					if (277260 - 99664 != 177597)
					{
						this.$self_$18483.pDn6kgPou8.actionTime = Time.time;
						if (236758 - 532255 != -295496)
						{
							this.$self_$18483.pDn6kgPou8.myCommand = "create";
							if (166788 - 728 == 166060)
							{
								this.$self_$18483.pDn6kgPou8.addTimeOut("nAttack", (float)24);
								if (271890 - 589255 != -317364)
								{
									this.$self_$18483.transform.position = this.$mPos$18481;
									if (195662 - 198016 == -2354)
									{
										this.$self_$18483.transform.LookAt(this.$mPos$18481 + this.$tDir$18482);
										if (210564 - 404458 == -193894)
										{
											this.$self_$18483.Oyg6unJbnp = this.$mPos$18481 + (float)12 * this.$tDir$18482;
											if (25057 - 494326 != -469268)
											{
												this.$self_$18483.cQ36yhjrTr = this.$tDir$18482;
												if (40673 - 90989 == -50316)
												{
													if (this.$self_$18483.create_ring)
													{
														if (219839 - 119115 != 100724)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.$self_$18483.create_ring, this.$self_$18483.transform.position, this.$self_$18483.transform.rotation);
														if (179747 - 539102 != -359355)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Missing create_ring effect");
														if (95439 - 519903 == -424463)
														{
															continue;
														}
													}
													this.$i$18480 = 0;
													if (13287 - 493911 != -480623)
													{
														goto IL_78;
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_4B1:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_36:
				goto IL_4B1;
				IL_5B7:
				return false;
			}

			// Token: 0x060012BF RID: 4799 RVA: 0x001D6B04 File Offset: 0x001D4D04
			internal static bool yti4BCCnn0eJr3AI39g()
			{
				return true;
			}

			// Token: 0x060012C0 RID: 4800 RVA: 0x001D6B08 File Offset: 0x001D4D08
			internal static bool xakchrC6MmvpHPAo09h()
			{
				return false;
			}

			// Token: 0x0400104A RID: 4170
			internal int $i$18480;

			// Token: 0x0400104B RID: 4171
			internal Vector3 $mPos$18481;

			// Token: 0x0400104C RID: 4172
			internal Vector3 $tDir$18482;

			// Token: 0x0400104D RID: 4173
			internal Lavu $self_$18483;
		}
	}

	// Token: 0x02000339 RID: 825
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18487 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060012C1 RID: 4801 RVA: 0x001D6B0C File Offset: 0x001D4D0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18487(UnityScript.Lang.Array nArray, Lavu self_)
		{
			if (289043 - 569185 != -280142)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (32007 - 508238 == -476231)
				{
					base..ctor();
					if (254833 - 155569 == 99264)
					{
						this.$nArray$18492 = nArray;
						if (250167 - 388585 != -138417)
						{
							this.$self_$18493 = self_;
							if (126991 - 280747 == -153756)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x001D6BC8 File Offset: 0x001D4DC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Lavu.$RPC_dead$18487.$(this.$nArray$18492, this.$self_$18493);
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x001D6BDC File Offset: 0x001D4DDC
		internal static bool XaBPqbCiv2yCHCOu6Ia()
		{
			return true;
		}

		// Token: 0x060012C4 RID: 4804 RVA: 0x001D6BE0 File Offset: 0x001D4DE0
		internal static bool cqnvcjCKJmKfvBjkbj3()
		{
			return false;
		}

		// Token: 0x0400104E RID: 4174
		internal UnityScript.Lang.Array $nArray$18492;

		// Token: 0x0400104F RID: 4175
		internal Lavu $self_$18493;

		// Token: 0x0200033A RID: 826
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060012C5 RID: 4805 RVA: 0x001D6BE4 File Offset: 0x001D4DE4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Lavu self_)
			{
				if (143570 - 190768 != -47197)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181019 - 586618 != -405598)
					{
						base..ctor();
						if (174647 - 478280 == -303633)
						{
							this.$nArray$18490 = nArray;
							if (127474 - 437435 != -309960)
							{
								this.$self_$18491 = self_;
								if (6357 - 192186 == -185829)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060012C6 RID: 4806 RVA: 0x001D6CA0 File Offset: 0x001D4EA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (273795 - 460344 != -186549)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3AA;
					case 2:
						if (this.$self_$18491.pDn6kgPou8.actionState != "dead")
						{
							if (123462 - 98426 != 25037)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18491.pDn6kgPou8.isPlayer)
							{
								if (144101 - 459767 == -315665)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18491.gameObject);
								if (98846 - 349976 == -251129)
								{
									continue;
								}
							}
							else if (this.$self_$18491.pDn6kgPou8.isMine)
							{
								if (191116 - 144524 == 46593)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18491.gameObject);
								if (117188 - 276923 == -159734)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (269318 - 304477 != -35158)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					default:
						if (252936 - 79933 != 173003)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18491.pDn6kgPou8.actionState == "dead")
					{
						if (196690 - 461318 == -264628)
						{
							goto IL_2AA;
						}
					}
					else
					{
						this.$myPosition$18488 = (Vector3)this.$nArray$18490[0];
						if (152095 - 364001 != -211905)
						{
							this.$myDirection$18489 = (Vector3)this.$nArray$18490[1];
							if (177804 - 207004 == -29200)
							{
								this.$self_$18491.transform.position = this.$myPosition$18488;
								if (30711 - 155947 == -125236)
								{
									this.$self_$18491.transform.LookAt(this.$myPosition$18488 + this.$myDirection$18489);
									if (264764 - 217805 == 46959)
									{
										this.$self_$18491.pDn6kgPou8.hp = 0;
										if (89212 - 511967 != -422754)
										{
											this.$self_$18491.pDn6kgPou8.actionState = "dead";
											if (299245 - 424589 == -125344)
											{
												this.$self_$18491.pDn6kgPou8.actionTime = Time.time;
												if (254259 - 598762 == -344503)
												{
													this.$self_$18491.pDn6kgPou8.myCommand = "none";
													if (260092 - 437515 != -177422)
													{
														this.$self_$18491.pDn6kgPou8.vMovement = Vector3.zero;
														if (79457 - 38990 == 40467)
														{
															this.$self_$18491.pDn6kgPou8.moveSpeed = (float)0;
															if (63495 - 63634 == -139)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_14:
				IL_2AA:
				Block_21:
				IL_3AA:
				return false;
			}

			// Token: 0x060012C7 RID: 4807 RVA: 0x001D706C File Offset: 0x001D526C
			internal static bool tX3DUFCdUEvAjQuZgRr()
			{
				return true;
			}

			// Token: 0x060012C8 RID: 4808 RVA: 0x001D7070 File Offset: 0x001D5270
			internal static bool plVCSVCJ0gieirwQe4t()
			{
				return false;
			}

			// Token: 0x04001050 RID: 4176
			internal Vector3 $myPosition$18488;

			// Token: 0x04001051 RID: 4177
			internal Vector3 $myDirection$18489;

			// Token: 0x04001052 RID: 4178
			internal UnityScript.Lang.Array $nArray$18490;

			// Token: 0x04001053 RID: 4179
			internal Lavu $self_$18491;
		}
	}
}
