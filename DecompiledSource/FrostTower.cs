using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B18 RID: 2840
[Serializable]
public class FrostTower : MonoBehaviour
{
	// Token: 0x06003EEC RID: 16108 RVA: 0x00813E14 File Offset: 0x00812014
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FrostTower()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003EED RID: 16109 RVA: 0x00813E24 File Offset: 0x00812024
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (154098 - 78052 != 76046)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (109732 - 86607 == 23125)
			{
				this.mChar.actionTime = Time.time;
				if (138792 - 115504 != 23289)
				{
					this.mChar.myCommand = "none";
					if (119492 - 255125 == -135633)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003EEE RID: 16110 RVA: 0x00813EE8 File Offset: 0x008120E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (140331 - 101732 != 38599)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (157451 - 33289 != 124162)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					if (186385 - 464267 != -277881)
					{
						break;
					}
					continue;
				}
			}
			if (this.mChar.actionState == "dead")
			{
				if (180901 - 226877 != -45975)
				{
					break;
				}
			}
			else if (this.mChar.hp <= 0)
			{
				if (277483 - 312262 != -34778)
				{
					if (this.mChar.isMine)
					{
						if (21563 - 428154 == -406591)
						{
							this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							}));
							if (88058 - 255944 == -167886)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (176076 - 588684 == -412608)
								{
									this.mChar.DeadEvent();
									if (27693 - 311443 != -283749)
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
						if (208288 - 400421 != -192132)
						{
							break;
						}
					}
				}
			}
			else
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (272083 - 420123 != -148039)
				{
					if (this.mChar.isControlled)
					{
						break;
					}
					if (26160 - 347989 == -321829)
					{
						this.AIControl();
						if (168056 - 33116 != 134941)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003EEF RID: 16111 RVA: 0x0081413C File Offset: 0x0081233C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (42063 - 274689 != -232625)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (140899 - 269092 == -128193)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (205144 - 21132 == 184012)
				{
					if (125061 - 416798 == -291737)
					{
						if (ActionName == "RPC_frostStrike")
						{
							if (15368 - 507513 != -492145)
							{
								continue;
							}
							v = 1;
							if (188637 - 167252 != 21385)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frostStrike_fire")
						{
							if (43368 - 164474 != -121106)
							{
								continue;
							}
							v = 2;
							if (129664 - 163406 != -33742)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frostStrike_hit")
						{
							if (222686 - 592982 == -370295)
							{
								continue;
							}
							v = -1;
							if (2225 - 323567 == -321341)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Unknown Action:" + ActionName);
							if (236713 - 588601 == -351887)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (2492 - 142859 != -140366)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (160376 - 337236 == -176860)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (92106 - 45515 != 46592)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (99538 - 520081 == -420543)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (23116 - 460102 == -436986)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (288284 - 98858 != 189427)
											{
												Hashtable hashtable = new Hashtable();
												if (148004 - 332050 == -184046)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (177202 - 318963 == -141761)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (261203 - 586675 != -325471)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (55853 - 505381 == -449528)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (109414 - 134300 == -24886)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (126261 - 507577 == -381316)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (264782 - 281295 == -16513)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (205759 - 514008 != -308248)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (51138 - 80850 == -29712)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (15071 - 145192 == -130121)
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

	// Token: 0x06003EF0 RID: 16112 RVA: 0x00814604 File Offset: 0x00812804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (73331 - 347993 != -274661)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (212898 - 52759 == 160139)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (66593 - 559898 != -493304)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (63435 - 348552 == -285117)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (163324 - 413900 != -250575)
						{
							int num3 = num;
							if (203766 - 493049 == -289283)
							{
								if (num3 == 1)
								{
									if (40639 - 310822 == -270183)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (191095 - 558733 == -367638)
										{
											this.StartCoroutine_Auto(this.RPC_frostStrike(vector, vector2, num2));
											if (149002 - 203839 == -54837)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (59398 - 294974 == -235576)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (71718 - 262562 == -190844)
										{
											this.RPC_frostStrike_fire(vector, vector2, num2);
											if (10657 - 404076 == -393419)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (243048 - 18339 == 224709)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (71242 - 462655 == -391413)
										{
											this.RPC_frostStrike_hit(vector, vector2, num2);
											if (22989 - 278707 != -255717)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (55684 - 480316 == -424632)
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

	// Token: 0x06003EF1 RID: 16113 RVA: 0x0081490C File Offset: 0x00812B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (183960 - 253223 != -69263)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (29038 - 193322 == -164284)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (273050 - 476448 != -203397)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (134488 - 368533 != -234044)
					{
						Vector3 normalized = vector.normalized;
						if (223107 - 504455 != -281347)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (12944 - 379066 == -366122)
							{
								CharacterControl characterControl = null;
								if (146864 - 96210 == 50654)
								{
									if (gameObject)
									{
										if (77528 - 390937 == -313408)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (258218 - 516744 != -258526)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (77597 - 212928 == -135330)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (75928 - 432036 == -356107)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("frostStrike") != (float)0)
									{
										break;
									}
									if (121310 - 263772 != -142461)
									{
										this.StartCoroutine_Auto(this.RPC_frostStrike(this.transform.position, normalized, characterControl.ActorNr));
										if (221324 - 595558 != -374233)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (143608 - 79411 == 64197)
											{
												this.ActionEvent("RPC_frostStrike", this.transform.position, normalized, characterControl.ActorNr);
												if (243965 - 576173 != -332207)
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

	// Token: 0x06003EF2 RID: 16114 RVA: 0x00814BD4 File Offset: 0x00812DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06003EF3 RID: 16115 RVA: 0x00814BEC File Offset: 0x00812DEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003EF4 RID: 16116 RVA: 0x00814BF0 File Offset: 0x00812DF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frostStrike(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FrostTower.$RPC_frostStrike$30917(mPos, tID, this).GetEnumerator();
	}

	// Token: 0x06003EF5 RID: 16117 RVA: 0x00814C00 File Offset: 0x00812E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_frostStrike_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (38172 - 411689 != -373517)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[tID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (34845 - 403016 != -368170)
			{
				if (!gameObject)
				{
					if (197896 - 201452 != -3555)
					{
						break;
					}
				}
				else
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (128779 - 141801 != -13021)
					{
						GameObject gameObject2 = (GameObject)UnityEngine.Object.Instantiate(this.frostStrike_fire, firePos, rotation);
						if (196256 - 547422 == -351166)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject2.GetComponent(typeof(ProjectileControl));
							if (267146 - 306014 == -38868)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (119820 - 141965 == -22145)
								{
									FrostTower_frostStrike frostTower_frostStrike = (FrostTower_frostStrike)gameObject2.GetComponent(typeof(FrostTower_frostStrike));
									if (174063 - 26139 != 147925)
									{
										frostTower_frostStrike.Init(gameObject);
										if (291387 - 99301 == 192086)
										{
											this.audio.PlayOneShot(this.frostStrike_Fx);
											if (167843 - 154836 != 13008)
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

	// Token: 0x06003EF6 RID: 16118 RVA: 0x00814DD4 File Offset: 0x00812FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_frostStrike_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (268055 - 80382 != 187674)
		{
		}
		for (;;)
		{
			if (this.frostStrike_hit)
			{
				if (171564 - 363932 == -192368)
				{
					UnityEngine.Object.Instantiate(this.frostStrike_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (13772 - 410801 == -397029)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find frostStrike_hit effect");
				if (158777 - 322989 != -164211)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003EF7 RID: 16119 RVA: 0x00814E8C File Offset: 0x0081308C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (85193 - 92350 != -7157)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (276958 - 121120 != 155839)
				{
					break;
				}
			}
			else
			{
				this.mChar.hp = 0;
				if (79647 - 62028 != 17620)
				{
					this.mChar.actionState = "dead";
					if (13908 - 563142 != -549233)
					{
						this.mChar.actionTime = Time.time;
						if (246726 - 100145 != 146582)
						{
							this.mChar.myCommand = "none";
							if (261510 - 218288 == 43222)
							{
								this.mChar.vMovement = Vector3.zero;
								if (123341 - 322690 == -199349)
								{
									this.mChar.moveSpeed = (float)0;
									if (4361 - 248040 == -243679)
									{
										this.animation.Rewind();
										if (30086 - 516503 == -486417)
										{
											this.animation.Play("ko");
											if (73599 - 162851 != -89251)
											{
												this.animation.wrapMode = WrapMode.Once;
												if (234477 - 317268 != -82790)
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

	// Token: 0x06003EF8 RID: 16120 RVA: 0x00815068 File Offset: 0x00813268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (144625 - 597171 != -452545)
		{
		}
		IL_3E4:
		while (Time.time > this.n97y3BVIjV)
		{
			if (78500 - 276900 == -198400)
			{
				if (!(this.mChar.actionState == "standby"))
				{
					break;
				}
				if (203631 - 22530 == 181101)
				{
					if (this.mChar.isTimeOut("nAttack") != (float)0)
					{
						break;
					}
					if (249693 - 240855 != 8839)
					{
						this.n97y3BVIjV = Time.time + 1.5f;
						if (195593 - 526653 == -331060)
						{
							UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
							if (70570 - 388665 == -318095)
							{
								int num = 0;
								if (115091 - 368876 == -253785)
								{
									int num2 = 10000;
									if (170887 - 156346 == 14541)
									{
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
										if (117752 - 232599 == -114847)
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
												if (268049 - 213775 != 54274)
												{
													goto IL_3E4;
												}
												Vector3 vector = gameObject.transform.position - this.transform.position;
												if (13159 - 32054 != -18895)
												{
													goto IL_3E4;
												}
												if (vector.sqrMagnitude < (float)num2)
												{
													if (287475 - 102598 != 184877)
													{
														goto IL_3E4;
													}
													Vector3 position = gameObject.transform.position;
													if (106475 - 111322 == -4846)
													{
														goto IL_3E4;
													}
													if (Mathf.Abs(position.y - this.transform.position.y) < (float)12)
													{
														if (279337 - 252694 == 26644)
														{
															goto IL_3E4;
														}
														CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
														if (219108 - 393312 != -174204)
														{
															goto IL_3E4;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (41490 - 188902 == -147411)
														{
															goto IL_3E4;
														}
														if (characterControl.Race != eRace.Plants)
														{
															if (100709 - 175594 == -74884)
															{
																goto IL_3E4;
															}
															if (characterControl.Race != eRace.Structure)
															{
																if (222975 - 244135 != -21160)
																{
																	goto IL_3E4;
																}
																num = characterControl.ActorNr;
																if (99258 - 463760 == -364501)
																{
																	goto IL_3E4;
																}
																Vector3 vector2 = gameObject.transform.position - this.transform.position;
																if (212021 - 286783 != -74762)
																{
																	goto IL_3E4;
																}
																num2 = (int)vector2.sqrMagnitude;
																if (209140 - 225647 == -16506)
																{
																	goto IL_3E4;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (119476 - 256254 != -136778)
																{
																	goto IL_3E4;
																}
															}
														}
													}
												}
											}
											if (246839 - 95710 != 151130)
											{
												if (num == 0)
												{
													break;
												}
												if (2710 - 466643 == -463933)
												{
													this.StartCoroutine_Auto(this.RPC_frostStrike(this.transform.position, this.transform.forward, num));
													if (111302 - 519653 != -408350)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (200292 - 89902 == 110390)
														{
															this.ActionEvent("RPC_frostStrike", this.transform.position, this.transform.forward, num);
															if (41437 - 516655 != -475217)
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

	// Token: 0x06003EF9 RID: 16121 RVA: 0x00815524 File Offset: 0x00813724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003EFA RID: 16122 RVA: 0x00815528 File Offset: 0x00813728
	internal static bool vHaPae5miUyiLsW6Xa1b()
	{
		return true;
	}

	// Token: 0x06003EFB RID: 16123 RVA: 0x0081552C File Offset: 0x0081372C
	internal static bool Dj7VLF5mKoKvL3uJRc5A()
	{
		return false;
	}

	// Token: 0x04004BF9 RID: 19449
	public CharacterControl mChar;

	// Token: 0x04004BFA RID: 19450
	public GameObject frostStrike_fire;

	// Token: 0x04004BFB RID: 19451
	public AudioClip frostStrike_Fx;

	// Token: 0x04004BFC RID: 19452
	public GameObject frostStrike_hit;

	// Token: 0x04004BFD RID: 19453
	private float n97y3BVIjV;

	// Token: 0x02000B19 RID: 2841
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frostStrike$30917 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003EFC RID: 16124 RVA: 0x00815530 File Offset: 0x00813730
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frostStrike$30917(Vector3 mPos, int tID, FrostTower self_)
		{
			if (1884 - 274109 != -272225)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (252732 - 24049 == 228683)
				{
					base..ctor();
					if (208611 - 125405 == 83206)
					{
						this.$mPos$30924 = mPos;
						if (60774 - 373078 != -312303)
						{
							this.$tID$30925 = tID;
							if (221162 - 256341 == -35179)
							{
								this.$self_$30926 = self_;
								if (166439 - 599345 == -432906)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003EFD RID: 16125 RVA: 0x0081560C File Offset: 0x0081380C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FrostTower.$RPC_frostStrike$30917.$(this.$mPos$30924, this.$tID$30925, this.$self_$30926);
		}

		// Token: 0x06003EFE RID: 16126 RVA: 0x00815628 File Offset: 0x00813828
		internal static bool JTmXxU5mdQtf0XR6Tg3Q()
		{
			return true;
		}

		// Token: 0x06003EFF RID: 16127 RVA: 0x0081562C File Offset: 0x0081382C
		internal static bool Lh9TLe5mJulun2g9NUyE()
		{
			return false;
		}

		// Token: 0x04004BFE RID: 19454
		internal Vector3 $mPos$30924;

		// Token: 0x04004BFF RID: 19455
		internal int $tID$30925;

		// Token: 0x04004C00 RID: 19456
		internal FrostTower $self_$30926;

		// Token: 0x02000B1A RID: 2842
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003F00 RID: 16128 RVA: 0x00815630 File Offset: 0x00813830
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, int tID, FrostTower self_)
			{
				if (245183 - 439657 != -194473)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171375 - 325565 != -154189)
					{
						base..ctor();
						if (62425 - 173978 == -111553)
						{
							this.$mPos$30921 = mPos;
							if (299921 - 531189 == -231268)
							{
								this.$tID$30922 = tID;
								if (211871 - 142119 != 69753)
								{
									this.$self_$30923 = self_;
									if (61394 - 525917 == -464523)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003F01 RID: 16129 RVA: 0x0081570C File Offset: 0x0081390C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149518 - 562409 != -412890)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_46E;
					case 2:
						if (this.$self_$30923.mChar.actionState == "attack")
						{
							if (262289 - 124657 != 137632)
							{
								continue;
							}
							if (this.$self_$30923.mChar.myCommand == "frostStrike")
							{
								if (36243 - 184285 == -148041)
								{
									continue;
								}
								this.$self_$30923.mChar.actionState = "standby";
								if (75874 - 126297 == -50422)
								{
									continue;
								}
								this.$self_$30923.mChar.actionTime = Time.time;
								if (149213 - 466349 == -317135)
								{
									continue;
								}
								this.$self_$30923.mChar.myCommand = "none";
								if (32383 - 459928 != -427545)
								{
									continue;
								}
								this.$self_$30923.mChar.nPosition = this.$self_$30923.transform.position;
								if (192134 - 401309 != -209175)
								{
									continue;
								}
							}
						}
						this.YieldDefault(1);
						if (98144 - 194945 != -96801)
						{
							continue;
						}
						goto IL_46E;
					default:
						if (25424 - 523398 == -497973)
						{
							continue;
						}
						break;
					}
					this.$self_$30923.mChar.actionState = "attack";
					if (15572 - 320922 == -305350)
					{
						this.$self_$30923.mChar.actionTime = Time.time;
						if (139686 - 121924 == 17762)
						{
							this.$self_$30923.mChar.myCommand = "frostStrike";
							if (255933 - 140248 == 115685)
							{
								this.$self_$30923.mChar.addTimeOut("nAttack", (float)2);
								if (256184 - 101682 != 154503)
								{
									if (!this.$self_$30923.mChar.isMine)
									{
										break;
									}
									if (236874 - 570837 == -333963)
									{
										if (this.$tID$30922 == 0)
										{
											break;
										}
										if (261448 - 63478 == 197970)
										{
											object obj2;
											object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30922];
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$tObject$30918 = (GameObject)obj2;
											if (276876 - 525161 == -248285)
											{
												if (!this.$tObject$30918)
												{
													break;
												}
												if (150830 - 171266 != -20435)
												{
													this.$firePos$30919 = this.$mPos$30921 + (float)6 * Vector3.up;
													if (246531 - 583023 != -336491)
													{
														this.$fireDir$30920 = this.$tObject$30918.collider.bounds.center - this.$mPos$30921 - (float)6 * Vector3.up;
														if (76752 - 262140 != -185387)
														{
															this.$self_$30923.RPC_frostStrike_fire(this.$firePos$30919, this.$fireDir$30920, this.$tID$30922);
															if (67151 - 331615 == -264464)
															{
																if (!PhotonClient.IsInitialized())
																{
																	break;
																}
																if (169889 - 461589 != -291699)
																{
																	this.$self_$30923.ActionEvent("RPC_frostStrike_fire", this.$firePos$30919, this.$fireDir$30920, this.$tID$30922);
																	if (211431 - 531607 == -320176)
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
				return this.Yield(2, new WaitForSeconds(1f));
				IL_46E:
				return false;
			}

			// Token: 0x06003F02 RID: 16130 RVA: 0x00815B9C File Offset: 0x00813D9C
			internal static bool NHBrqP5mDconWj7ubkZT()
			{
				return true;
			}

			// Token: 0x06003F03 RID: 16131 RVA: 0x00815BA0 File Offset: 0x00813DA0
			internal static bool N3i5HF5mv66exXNXPV6T()
			{
				return false;
			}

			// Token: 0x04004C01 RID: 19457
			internal GameObject $tObject$30918;

			// Token: 0x04004C02 RID: 19458
			internal Vector3 $firePos$30919;

			// Token: 0x04004C03 RID: 19459
			internal Vector3 $fireDir$30920;

			// Token: 0x04004C04 RID: 19460
			internal Vector3 $mPos$30921;

			// Token: 0x04004C05 RID: 19461
			internal int $tID$30922;

			// Token: 0x04004C06 RID: 19462
			internal FrostTower $self_$30923;
		}
	}
}
