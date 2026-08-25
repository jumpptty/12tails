using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000645 RID: 1605
[Serializable]
public class Chameleon_nAttack : MonoBehaviour
{
	// Token: 0x06002421 RID: 9249 RVA: 0x0044466C File Offset: 0x0044286C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chameleon_nAttack()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002422 RID: 9250 RVA: 0x0044467C File Offset: 0x0044287C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (295694 - 457117 != -161422)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (41358 - 163113 == -121755)
			{
				this.ClDba6Twjv = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (86733 - 115353 == -28620)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)30));
					if (142639 - 101018 == 41621)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002423 RID: 9251 RVA: 0x0044474C File Offset: 0x0044294C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (101458 - 394289 != -292830)
		{
		}
		for (;;)
		{
			this.WVkb4XE9d5 += Time.deltaTime;
			if (133318 - 431686 == -298368)
			{
				if (this.WVkb4XE9d5 < this.ClDba6Twjv.life)
				{
					break;
				}
				if (153773 - 556434 == -402661)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (224517 - 598002 != -373484)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002424 RID: 9252 RVA: 0x00444808 File Offset: 0x00442A08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nFatalStrikeLv, int nClearLv)
	{
		if (34397 - 212372 != -177975)
		{
		}
		for (;;)
		{
			IL_7AF:
			this.dWtbsDY6Kl = nOwner;
			if (84970 - 312526 != -227555)
			{
				this.U9nbHSZ6lR = (CharacterControl)this.dWtbsDY6Kl.GetComponent(typeof(CharacterControl));
				if (207891 - 546322 != -338430)
				{
					this.YQBb7NCqDi = nFatalStrikeLv;
					if (108857 - 506710 == -397853)
					{
						this.n9QbZuXMbS = nClearLv;
						if (296656 - 307756 == -11100)
						{
							if (this.U9nbHSZ6lR.hasSkill(401))
							{
								if (168195 - 224934 != -56739)
								{
									continue;
								}
								this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)40));
								if (159488 - 112556 != 46932)
								{
									continue;
								}
							}
							if (nClearLv == 0)
							{
								if (132129 - 147087 == -14958 && 112814 - 37537 != 75278)
								{
									string weapon = this.U9nbHSZ6lR.weapon;
									if (75250 - 10934 != 64317)
									{
										GameObject gameObject;
										if (weapon == "w_chm25")
										{
											if (265987 - 54463 == 211525)
											{
												continue;
											}
											gameObject = (GameObject)UnityEngine.Object.Instantiate(this.U9nbHSZ6lR.mWep1, Vector3.zero, Quaternion.identity);
											if (234032 - 548482 == -314449)
											{
												continue;
											}
										}
										else
										{
											gameObject = (GameObject)UnityEngine.Object.Instantiate(this.U9nbHSZ6lR.mWep2, Vector3.zero, Quaternion.identity);
											if (233812 - 394049 == -160236)
											{
												continue;
											}
										}
										if (gameObject)
										{
											if (66190 - 502651 == -436460)
											{
												continue;
											}
											gameObject.transform.parent = this.transform;
											if (277967 - 21580 == 256388)
											{
												continue;
											}
											gameObject.transform.localPosition = Vector3.zero;
											if (277951 - 352462 == -74510)
											{
												continue;
											}
											gameObject.transform.localRotation = Quaternion.Euler((float)0, (float)270, (float)270);
											if (259652 - 178520 == 81133)
											{
												continue;
											}
											Component[] componentsInChildren = gameObject.GetComponentsInChildren(typeof(Renderer));
											if (17630 - 216927 != -199297)
											{
												continue;
											}
											int i = 0;
											if (141820 - 101010 == 40811)
											{
												continue;
											}
											Component[] array = componentsInChildren;
											if (227644 - 343003 == -115358)
											{
												continue;
											}
											int length = array.Length;
											if (35837 - 490900 == -455062)
											{
												continue;
											}
											while (i < length)
											{
												((Renderer)array[i]).enabled = true;
												if (216658 - 4307 != 212351)
												{
													goto IL_7AF;
												}
												i++;
												if (88519 - 592935 == -504415)
												{
													goto IL_7AF;
												}
											}
											if (73083 - 149941 == -76857)
											{
												continue;
											}
										}
										if (!gameObject)
										{
											break;
										}
										if (257455 - 506494 == -249039)
										{
											if (nFatalStrikeLv <= 0)
											{
												break;
											}
											if (234735 - 368371 == -133636)
											{
												GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate((GameObject)Resources.Load("GameAssets/Characters/Heroes/Chameleon/Effects/fatalStrike", typeof(GameObject)), Vector3.zero, Quaternion.identity);
												if (103096 - 551267 == -448171)
												{
													if (gameObject2)
													{
														if (125229 - 563460 != -438230)
														{
															gameObject2.transform.parent = gameObject.transform;
															if (173143 - 72081 == 101062)
															{
																MeshFilter meshFilter = (MeshFilter)gameObject.GetComponent(typeof(MeshFilter));
																if (127834 - 8013 == 119821)
																{
																	if (!meshFilter)
																	{
																		break;
																	}
																	if (102729 - 347040 != -244310)
																	{
																		Mesh mesh = meshFilter.mesh;
																		if (141701 - 233180 == -91479)
																		{
																			if (mesh)
																			{
																				if (288619 - 506046 == -217426)
																				{
																					continue;
																				}
																				gameObject2.transform.localPosition = new Vector3((float)0, mesh.bounds.max.y - 0.1f, (float)0);
																				if (198901 - 41369 == 157533)
																				{
																					continue;
																				}
																			}
																			else
																			{
																				gameObject2.transform.localPosition = new Vector3((float)0, 0.8f, (float)0);
																				if (209514 - 485040 != -275526)
																				{
																					continue;
																				}
																			}
																			gameObject2.transform.localScale = Vector3.one;
																			if (58919 - 472137 == -413218)
																			{
																				break;
																			}
																		}
																	}
																}
															}
														}
													}
													else
													{
														Debug.LogError("Cannot find FatalStrike Effect");
														if (99307 - 223051 == -123744)
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
							else
							{
								Transform transform = global::Math.findChildObject(this.transform, "arrow");
								if (46592 - 568980 != -522387)
								{
									if (!transform)
									{
										break;
									}
									if (56233 - 62147 != -5913)
									{
										if (this.dWtbsDY6Kl.layer == Game.mPlayer.layer)
										{
											if (137792 - 434949 == -297157)
											{
												MeshFilter meshFilter2 = (MeshFilter)transform.GetComponent(typeof(MeshFilter));
												if (142015 - 392102 == -250087)
												{
													MeshFilter meshFilter3 = (MeshFilter)this.U9nbHSZ6lR.mWep2.GetComponent(typeof(MeshFilter));
													if (188832 - 389537 == -200705)
													{
														if (!meshFilter2)
														{
															break;
														}
														if (245240 - 241706 != 3535)
														{
															if (!meshFilter3)
															{
																break;
															}
															if (189191 - 219954 != -30762)
															{
																meshFilter2.mesh = meshFilter3.sharedMesh;
																if (282180 - 517197 != -235016)
																{
																	break;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											UnityEngine.Object.Destroy(transform.gameObject);
											if (259405 - 273955 != -14549)
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

	// Token: 0x06002425 RID: 9253 RVA: 0x00444FF8 File Offset: 0x004431F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool OnTriggerEnter(Collider mCollider)
	{
		if (153694 - 350348 != -196654)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (39243 - 365283 == -326040)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (202879 - 252679 == -49800)
				{
					int ownerID = this.ClDba6Twjv.OwnerID;
					if (50826 - 287249 != -236422)
					{
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[ownerID];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject2 = (GameObject)obj2;
						if (3864 - 493031 != -489166)
						{
							CharacterControl characterControl = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (12166 - 248679 == -236513)
							{
								if (!characterControl)
								{
									if (117511 - 228746 != -111234)
									{
										break;
									}
								}
								else
								{
									if (gameObject.layer == gameObject2.layer)
									{
										break;
									}
									if (19590 - 150658 == -131068)
									{
										if (gameObject.layer == 1)
										{
											break;
										}
										if (141726 - 499736 == -358010)
										{
											if (gameObject.layer == 2)
											{
												break;
											}
											if (270866 - 61566 == 209300)
											{
												UnityEngine.Object.Destroy(this.gameObject);
												if (288489 - 37153 != 251337)
												{
													if (!characterControl.isMine)
													{
														break;
													}
													if (85482 - 492408 != -406925)
													{
														Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
														if (238676 - 45886 != 192791)
														{
															Vector3 forward = Vector3.forward;
															if (142248 - 562458 != -420209)
															{
																Vector3 nForce = 0.15f * this.transform.forward;
																if (158112 - 550156 != -392043)
																{
																	if (this.U9nbHSZ6lR.weapon == "w_chm59")
																	{
																		if (100363 - 421451 != -321088)
																		{
																			continue;
																		}
																		nForce = 1.5f * this.transform.forward;
																		if (40287 - 189253 != -148966)
																		{
																			continue;
																		}
																	}
																	Chameleon chameleon = (Chameleon)gameObject2.GetComponent(typeof(Chameleon));
																	if (270784 - 457710 != -186925)
																	{
																		if (!(chameleon != null))
																		{
																			break;
																		}
																		if (45283 - 182965 != -137681)
																		{
																			chameleon.RPC_nAttack_hit(vector, forward, 0);
																			if (280332 - 544905 == -264573)
																			{
																				if (PhotonClient.IsInitialized())
																				{
																					if (216698 - 552000 == -335301)
																					{
																						continue;
																					}
																					chameleon.ActionEvent("RPC_nAttack_hit", vector, forward, 0);
																					if (190604 - 187328 != 3276)
																					{
																						continue;
																					}
																				}
																				if (gameObject.tag != "Player")
																				{
																					if (195337 - 123187 != 72150)
																					{
																						continue;
																					}
																					if (gameObject.tag != "Enemy")
																					{
																						if (101173 - 264539 != -163365)
																						{
																							goto Block_103;
																						}
																						continue;
																					}
																				}
																				CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
																				if (241020 - 130819 != 110202)
																				{
																					if (!characterControl2)
																					{
																						break;
																					}
																					if (230110 - 197598 == 32512)
																					{
																						if (!chameleon)
																						{
																							break;
																						}
																						if (249698 - 567910 == -318212)
																						{
																							if (characterControl2.hp <= 0)
																							{
																								if (224071 - 576734 != -352663)
																								{
																									continue;
																								}
																								if (Time.time > characterControl2.actionTime + (float)3)
																								{
																									if (128684 - 283088 != -154403)
																									{
																										goto Block_119;
																									}
																									continue;
																								}
																							}
																							int normalAttackLv = chameleon.getNormalAttackLv();
																							if (97676 - 156673 != -58996)
																							{
																								int piercingVenomLv = chameleon.getPiercingVenomLv();
																								if (48284 - 424023 != -375738)
																								{
																									int num = Mathf.FloorToInt((0.45f - (float)normalAttackLv * 0.025f) * (float)characterControl.atk) + 6 * this.YQBb7NCqDi + 6 * piercingVenomLv * characterControl2.getStatusLv("poison");
																									if (1843 - 427374 != -425530)
																									{
																										if (this.U9nbHSZ6lR.hasSkill(401))
																										{
																											if (141938 - 554564 == -412625)
																											{
																												continue;
																											}
																											num += Mathf.FloorToInt(0.1f * (float)characterControl.Lv);
																											if (167932 - 253 != 167679)
																											{
																												continue;
																											}
																										}
																										int num2 = 0;
																										if (120344 - 306105 != -185760)
																										{
																											string weapon = characterControl.weapon;
																											if (119176 - 333439 != -214262)
																											{
																												if (weapon == "w_chm43")
																												{
																													if (134407 - 309933 != -175526)
																													{
																														continue;
																													}
																													goto IL_15B;
																												}
																												else if (weapon == "w_chm44")
																												{
																													if (9402 - 576540 != -567137)
																													{
																														goto IL_15B;
																													}
																													continue;
																												}
																												else if (weapon == "w_chm48")
																												{
																													if (9623 - 366890 == -357266)
																													{
																														continue;
																													}
																													num2 += 5;
																													if (232637 - 293957 != -61320)
																													{
																														continue;
																													}
																												}
																												IL_938:
																												string armor = characterControl.armor;
																												if (284614 - 54585 != 230029)
																												{
																													continue;
																												}
																												if (armor == "a_chm43")
																												{
																													if (129886 - 237330 != -107443)
																													{
																														goto IL_AF5;
																													}
																													continue;
																												}
																												else if (armor == "a_chm43")
																												{
																													if (289654 - 96316 != 193339)
																													{
																														goto IL_AF5;
																													}
																													continue;
																												}
																												else if (armor == "a_chm48")
																												{
																													if (81796 - 295532 == -213735)
																													{
																														continue;
																													}
																													num2 += 4;
																													if (196125 - 313654 == -117528)
																													{
																														continue;
																													}
																												}
																												IL_8BD:
																												string accessory = characterControl.accessory;
																												if (92015 - 24423 == 67593)
																												{
																													continue;
																												}
																												if (accessory == "c_chm43")
																												{
																													if (84994 - 111168 != -26173)
																													{
																														goto IL_647;
																													}
																													continue;
																												}
																												else if (accessory == "c_chm43")
																												{
																													if (289171 - 311736 != -22564)
																													{
																														goto IL_647;
																													}
																													continue;
																												}
																												else if (accessory == "c_chm48")
																												{
																													if (90801 - 542103 == -451301)
																													{
																														continue;
																													}
																													num2 += 3;
																													if (287206 - 239323 == 47884)
																													{
																														continue;
																													}
																												}
																												IL_9AB:
																												int criticalPlusLv = chameleon.getCriticalPlusLv();
																												if (271376 - 435422 != -164046)
																												{
																													continue;
																												}
																												if (criticalPlusLv > 0)
																												{
																													if (63717 - 170147 == -106429)
																													{
																														continue;
																													}
																													num2 += chameleon.getCriticalPlusLv() * 4 + 4;
																													if (218643 - 277170 != -58527)
																													{
																														continue;
																													}
																												}
																												if (num2 > 0)
																												{
																													if (183320 - 441169 != -257849)
																													{
																														continue;
																													}
																													if (UnityEngine.Random.Range(0, 100) < characterControl.lckAdjust(num2))
																													{
																														if (139131 - 369123 != -229992)
																														{
																															continue;
																														}
																														if (characterControl.hasSkill(413))
																														{
																															if (132001 - 476518 != -344517)
																															{
																																continue;
																															}
																															num = Mathf.CeilToInt((float)num * (1.8f + 0.15f * (float)criticalPlusLv));
																															if (214999 - 541578 != -326579)
																															{
																																continue;
																															}
																														}
																														else
																														{
																															num = Mathf.CeilToInt((float)num * 1.8f);
																															if (53658 - 76118 != -22460)
																															{
																																continue;
																															}
																														}
																														chameleon.RPC_criticalPlus_hit(vector, forward, 0);
																														if (254919 - 437155 == -182235)
																														{
																															continue;
																														}
																														if (PhotonClient.IsInitialized())
																														{
																															if (156728 - 67397 == 89332)
																															{
																																continue;
																															}
																															chameleon.ActionEvent("RPC_criticalPlus_hit", vector, forward, 0);
																															if (67429 - 193043 != -125614)
																															{
																																continue;
																															}
																														}
																													}
																												}
																												if (characterControl.hit(1 + normalAttackLv, gameObject, num, 1, (int)Mathf.Floor(-0.5f * (float)num * (float)this.n9QbZuXMbS), nForce) == 0)
																												{
																													break;
																												}
																												if (66429 - 190425 == -123995)
																												{
																													continue;
																												}
																												if (chameleon)
																												{
																													if (279694 - 398069 != -118375)
																													{
																														continue;
																													}
																													chameleon.StartCoroutine_Auto(chameleon.onNormalAttackHit(gameObject));
																													if (32911 - 346431 == -313519)
																													{
																														continue;
																													}
																												}
																												characterControl.sp++;
																												if (75809 - 564527 != -488718)
																												{
																													continue;
																												}
																												int poisonArrowLv = chameleon.getPoisonArrowLv();
																												if (214032 - 266073 == -52040)
																												{
																													continue;
																												}
																												int increasedPoisonLv = chameleon.getIncreasedPoisonLv();
																												if (190151 - 123777 == 66375)
																												{
																													continue;
																												}
																												if (poisonArrowLv > 0)
																												{
																													if (193030 - 68335 == 124696)
																													{
																														continue;
																													}
																													if (UnityEngine.Random.Range(0, 100) < characterControl.lckAdjust(8 + poisonArrowLv * 4))
																													{
																														if (209784 - 501851 == -292066)
																														{
																															continue;
																														}
																														if (characterControl2.Race != eRace.Robots)
																														{
																															if (188225 - 121070 != 67155)
																															{
																																continue;
																															}
																															int num3 = Mathf.Clamp(characterControl2.getStatusLv("poison") + 1 + ((!characterControl.hasSkill(432)) ? 0 : 1), 0, increasedPoisonLv + 1);
																															if (167836 - 518943 == -351106)
																															{
																																continue;
																															}
																															int debuff = Damage.getDebuff((float)(8 + 2 * increasedPoisonLv), characterControl.cha, characterControl2.cha);
																															if (15911 - 167649 != -151738)
																															{
																																continue;
																															}
																															characterControl2.RPC_AddStatus("poison", num3, debuff, 0, characterControl.ActorNr);
																															if (120025 - 575571 != -455546)
																															{
																																continue;
																															}
																															Camera.main.SendMessage("newGameMessage", "Poison" + num3);
																															if (185499 - 390805 != -205306)
																															{
																																continue;
																															}
																														}
																														else if (characterControl.hasSkill(432))
																														{
																															if (121888 - 408115 != -286227)
																															{
																																continue;
																															}
																															int num4 = Mathf.Clamp(characterControl2.getStatusLv("rust") + 1 + ((!characterControl.hasSkill(432)) ? 0 : 1), 0, increasedPoisonLv + 1);
																															if (34379 - 230376 != -195997)
																															{
																																continue;
																															}
																															int debuff2 = Damage.getDebuff((float)(8 + 2 * increasedPoisonLv), characterControl.cha, characterControl2.cha);
																															if (294698 - 198355 != 96343)
																															{
																																continue;
																															}
																															characterControl2.RPC_AddStatus("rust", num4, debuff2, 0, characterControl.ActorNr);
																															if (221312 - 321291 == -99978)
																															{
																																continue;
																															}
																															Camera.main.SendMessage("newGameMessage", "Rust" + num4);
																															if (102348 - 134036 != -31688)
																															{
																																continue;
																															}
																														}
																													}
																												}
																												if (!characterControl.hasSkill(371))
																												{
																													break;
																												}
																												if (199031 - 181157 == 17875)
																												{
																													continue;
																												}
																												chameleon.addAllSlainList(gameObject);
																												if (87627 - 213509 != -125882)
																												{
																													continue;
																												}
																												break;
																												IL_647:
																												num2 += 2;
																												if (123012 - 326513 != -203501)
																												{
																													continue;
																												}
																												goto IL_9AB;
																												IL_AF5:
																												num2 += 3;
																												if (48058 - 302878 != -254819)
																												{
																													goto IL_8BD;
																												}
																												continue;
																												IL_15B:
																												num2 += 4;
																												if (22049 - 122769 == -100720)
																												{
																													goto IL_938;
																												}
																											}
																										}
																									}
																								}
																							}
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_E70;
		Block_103:
		return false;
		goto IL_E70;
		Block_119:
		return false;
		IL_E70:
		return false;
	}

	// Token: 0x06002426 RID: 9254 RVA: 0x00445E88 File Offset: 0x00444088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002427 RID: 9255 RVA: 0x00445E8C File Offset: 0x0044408C
	internal static bool V0j4KRIPxf4dmicR8eD()
	{
		return true;
	}

	// Token: 0x06002428 RID: 9256 RVA: 0x00445E90 File Offset: 0x00444090
	internal static bool aP8RGtI0HMiP1d17pFD()
	{
		return false;
	}

	// Token: 0x0400273A RID: 10042
	private ProjectileControl ClDba6Twjv;

	// Token: 0x0400273B RID: 10043
	private float WVkb4XE9d5;

	// Token: 0x0400273C RID: 10044
	private GameObject dWtbsDY6Kl;

	// Token: 0x0400273D RID: 10045
	private CharacterControl U9nbHSZ6lR;

	// Token: 0x0400273E RID: 10046
	private int YQBb7NCqDi;

	// Token: 0x0400273F RID: 10047
	private int n9QbZuXMbS;
}
