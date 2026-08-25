using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000420 RID: 1056
[Serializable]
public class FakeShadowGod_AI : MonoBehaviour
{
	// Token: 0x0600189B RID: 6299 RVA: 0x00283364 File Offset: 0x00281564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FakeShadowGod_AI()
	{
		if (252815 - 539916 != -287101)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (138824 - 158849 == -20025)
			{
				base..ctor();
				if (82551 - 309516 != -226964)
				{
					this.AI_state = "none";
					if (165169 - 166461 == -1292)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x00283400 File Offset: 0x00281600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.TUo2G6upd9 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.KLJ21HH6cA = (FakeShadowGod)this.GetComponent(typeof(FakeShadowGod));
	}

	// Token: 0x0600189D RID: 6301 RVA: 0x00283438 File Offset: 0x00281638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (24175 - 258906 != -234730)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (249195 - 473050 != -223855)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (125786 - 344948 == -219161)
				{
					continue;
				}
			}
			if (this.TUo2G6upd9.isControlled)
			{
				break;
			}
			if (295002 - 81035 == 213967)
			{
				this.AIControl();
				if (122996 - 269285 == -146289)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x00283504 File Offset: 0x00281704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (111021 - 372409 != -261387)
		{
		}
		for (;;)
		{
			this.WAD2p11IsI = (float)0;
			if (200030 - 66753 == 133277)
			{
				if (this.TUo2G6upd9.isMine)
				{
					if (278656 - 486422 == -207766)
					{
						if (this.TUo2G6upd9.actionState != "standby")
						{
							if (84114 - 540602 == -456487)
							{
								continue;
							}
							if (this.TUo2G6upd9.actionState != "run")
							{
								if (37141 - 228711 != -191569)
								{
									break;
								}
								continue;
							}
						}
						if (!this.TUo2G6upd9.isAlert)
						{
							if (211016 - 90235 == 120781)
							{
								this.AI_idle(3f, 1f);
								if (188014 - 372504 == -184490)
								{
									this.AI_resetTimer();
									if (166437 - 407455 == -241018)
									{
										this.AI_visionCheck();
										if (176908 - 108981 != 67928)
										{
											if (!this.TUo2G6upd9.myAttackTarget)
											{
												break;
											}
											if (29986 - 143638 != -113651)
											{
												this.TUo2G6upd9.isAlert = true;
												if (37002 - 418042 == -381040)
												{
													this.hLp2qVp2r1 = Time.time;
													if (28128 - 368283 == -340155)
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
							this.AI_selectTarget(1f, (float)0);
							if (244895 - 479584 == -234689)
							{
								this.AI_turn(4f, 2f);
								if (260866 - 520055 != -259188)
								{
									this.AI_attack(10f, (float)0);
									if (80850 - 150900 == -70050)
									{
										this.AI_resetTimer();
										if (112589 - 499227 == -386638)
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
					if (this.TUo2G6upd9.actionState != "standby")
					{
						if (79341 - 448455 != -369114)
						{
							continue;
						}
						if (this.TUo2G6upd9.actionState != "run")
						{
							if (197997 - 170847 != 27151)
							{
								break;
							}
							continue;
						}
					}
					Vector3 vector = this.transform.forward;
					if (21324 - 41184 != -19859)
					{
						if (this.TUo2G6upd9.myAttackTarget)
						{
							if (34156 - 365909 == -331752)
							{
								continue;
							}
							vector = Vector3.RotateTowards(this.transform.forward, global::Math.vFlat(this.TUo2G6upd9.myAttackTarget.transform.position - this.transform.position), 0.01f, 1f);
							if (46184 - 51602 == -5417)
							{
								continue;
							}
						}
						this.transform.rotation = Quaternion.LookRotation(vector);
						if (256189 - 424779 != -168589)
						{
							this.animation.CrossFade("root", 0.5f);
							if (274901 - 513241 == -238340)
							{
								this.TUo2G6upd9.vMovement = vector;
								if (205584 - 554967 == -349383)
								{
									this.TUo2G6upd9.moveSpeed = (float)0;
									if (278127 - 129783 == 148344)
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

	// Token: 0x0600189F RID: 6303 RVA: 0x00283970 File Offset: 0x00281B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (90471 - 58798 != 31673)
		{
		}
		do
		{
			if (Time.time - this.hLp2qVp2r1 >= this.WAD2p11IsI)
			{
				if (148271 - 406227 == -257955)
				{
					continue;
				}
				if (Time.time - this.hLp2qVp2r1 < this.WAD2p11IsI + mTime)
				{
					if (176661 - 514079 == -337417)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (147886 - 549166 != -401280)
						{
							continue;
						}
						this.AI_state = "idle";
						if (156543 - 244647 != -88104)
						{
							continue;
						}
						this.hLp2qVp2r1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (94100 - 297648 != -203548)
						{
							continue;
						}
						this.TUo2G6upd9.vDirection = Vector3.zero;
						if (260025 - 545690 == -285664)
						{
							continue;
						}
						this.TUo2G6upd9.vMovement = this.transform.forward;
						if (288933 - 130129 == 158805)
						{
							continue;
						}
						this.TUo2G6upd9.actionState = "standby";
						if (224570 - 140710 == 83861)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.5f);
					if (252938 - 284437 == -31498)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (275082 - 315007 == -39924)
					{
						continue;
					}
					this.TUo2G6upd9.moveSpeed = (float)0;
					if (189407 - 403522 == -214114)
					{
						continue;
					}
				}
			}
			this.WAD2p11IsI += mTime;
		}
		while (167808 - 94677 == 73132);
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x00283BB8 File Offset: 0x00281DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_turn(float mTime, float rTimer)
	{
		if (55515 - 197356 != -141841)
		{
		}
		do
		{
			if (Time.time - this.hLp2qVp2r1 >= this.WAD2p11IsI)
			{
				if (16059 - 524778 == -508718)
				{
					continue;
				}
				if (Time.time - this.hLp2qVp2r1 < this.WAD2p11IsI + mTime)
				{
					if (174745 - 132051 == 42695)
					{
						continue;
					}
					if (this.AI_state != "turn")
					{
						if (94610 - 97767 != -3157)
						{
							continue;
						}
						this.AI_state = "turn";
						if (271172 - 244209 != 26963)
						{
							continue;
						}
						this.hLp2qVp2r1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (212031 - 242040 != -30009)
						{
							continue;
						}
					}
					Vector3 vector;
					if (this.TUo2G6upd9.myAttackTarget)
					{
						if (49073 - 551636 != -502563)
						{
							continue;
						}
						vector = Vector3.RotateTowards(this.transform.forward, global::Math.vFlat(this.TUo2G6upd9.myAttackTarget.transform.position - this.transform.position), 0.01f, 1f);
						if (111634 - 276303 != -164669)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(vector);
						if (251534 - 341466 == -89931)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.5f);
					if (145451 - 334086 != -188635)
					{
						continue;
					}
					this.TUo2G6upd9.vMovement = vector;
					if (103967 - 502703 != -398736)
					{
						continue;
					}
				}
			}
			this.WAD2p11IsI += mTime;
		}
		while (21239 - 327575 == -306335);
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x00283E10 File Offset: 0x00282010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (42337 - 521857 != -479519)
		{
		}
		do
		{
			if (Time.time - this.hLp2qVp2r1 >= this.WAD2p11IsI)
			{
				if (280046 - 479231 != -199185)
				{
					continue;
				}
				if (Time.time - this.hLp2qVp2r1 < this.WAD2p11IsI + mTime)
				{
					if (279850 - 472130 == -192279)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (182588 - 17368 != 165220)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (50990 - 467380 == -416389)
						{
							continue;
						}
						this.hLp2qVp2r1 = Time.time - mTime - this.WAD2p11IsI;
						if (203348 - 371728 != -168380)
						{
							continue;
						}
						this.TUo2G6upd9.vDirection = Vector3.zero;
						if (67153 - 387401 == -320247)
						{
							continue;
						}
						this.TUo2G6upd9.vMovement = this.transform.forward;
						if (291298 - 410975 != -119677)
						{
							continue;
						}
						this.TUo2G6upd9.actionState = "standby";
						if (118617 - 9661 == 108957)
						{
							continue;
						}
						this.TUo2G6upd9.myAttackTarget = this.TUo2G6upd9.getRandomHateTarget(120);
						if (132356 - 503421 == -371064)
						{
							continue;
						}
						if (!this.TUo2G6upd9.myAttackTarget)
						{
							if (165297 - 269727 == -104429)
							{
								continue;
							}
							this.TUo2G6upd9.isAlert = false;
							if (219328 - 206838 != 12490)
							{
								continue;
							}
							this.hLp2qVp2r1 = Time.time;
							if (215093 - 163829 != 51264)
							{
								continue;
							}
							this.TUo2G6upd9.myAttackTarget = null;
							if (161622 - 229483 == -67860)
							{
								continue;
							}
							this.TUo2G6upd9.mOriginalPosition = this.transform.position;
							if (4837 - 512009 != -507171)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.TUo2G6upd9.myAttackTarget;
							if (188053 - 377304 != -189251)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (86334 - 109590 != -23256)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (174084 - 443563 == -269478)
								{
									continue;
								}
								this.TUo2G6upd9.isAlert = false;
								if (247252 - 103148 != 144104)
								{
									continue;
								}
								this.hLp2qVp2r1 = Time.time;
								if (73277 - 10958 != 62319)
								{
									continue;
								}
								this.TUo2G6upd9.myAttackTarget = null;
								if (294218 - 584690 == -290471)
								{
									continue;
								}
							}
							else
							{
								this.TUo2G6upd9.vDirection = myAttackTarget.transform.position;
								if (269769 - 350418 != -80649)
								{
									continue;
								}
								this.TUo2G6upd9.vDirection.y = this.transform.position.y;
								if (28485 - 220336 != -191851)
								{
									continue;
								}
								this.TUo2G6upd9.vMovement = this.transform.forward;
								if (172090 - 593382 != -421292)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.WAD2p11IsI += mTime;
		}
		while (101503 - 20589 != 80914);
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x00284270 File Offset: 0x00282470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (176556 - 364601 != -188044)
		{
		}
		do
		{
			if (Time.time - this.hLp2qVp2r1 >= this.WAD2p11IsI)
			{
				if (166411 - 192934 != -26523)
				{
					continue;
				}
				if (Time.time - this.hLp2qVp2r1 < this.WAD2p11IsI + mTime)
				{
					if (76914 - 468271 == -391356)
					{
						continue;
					}
					if (!this.TUo2G6upd9.myAttackTarget)
					{
						if (240647 - 371971 == -131323)
						{
							continue;
						}
						this.hLp2qVp2r1 = Time.time - mTime - this.WAD2p11IsI;
						if (34377 - 5105 != 29273)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.TUo2G6upd9.myAttackTarget;
						if (31828 - 393830 == -362001)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (242024 - 345598 != -103574)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (34018 - 551925 == -517906)
						{
							continue;
						}
						int tID = 0;
						if (17090 - 94640 != -77550)
						{
							continue;
						}
						if (characterControl)
						{
							if (262212 - 288615 == -26402)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (266710 - 124324 == 142387)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (151181 - 519795 == -368613)
						{
							continue;
						}
						if (this.TUo2G6upd9.isTimeOut("nAttack") == (float)0)
						{
							if (129123 - 596151 != -467028)
							{
								continue;
							}
							this.hLp2qVp2r1 = Time.time - mTime - this.WAD2p11IsI;
							if (72389 - 96729 == -24339)
							{
								continue;
							}
							this.KLJ21HH6cA.StartCoroutine_Auto(this.KLJ21HH6cA.RPC_nAttack(this.transform.position, vector.normalized, tID));
							if (283536 - 526749 == -243212)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (247077 - 449511 != -202434)
								{
									continue;
								}
								this.KLJ21HH6cA.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
								if (48597 - 178420 != -129823)
								{
									continue;
								}
							}
						}
						else if (this.TUo2G6upd9.isTimeOut("randomCast") == (float)0)
						{
							if (5130 - 553424 != -548294)
							{
								continue;
							}
							this.hLp2qVp2r1 = Time.time - mTime - this.WAD2p11IsI;
							if (175124 - 356028 != -180904)
							{
								continue;
							}
							this.KLJ21HH6cA.StartCoroutine_Auto(this.KLJ21HH6cA.RPC_randomCast(this.transform.position, vector.normalized, tID));
							if (114571 - 281226 == -166654)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (267193 - 376321 != -109128)
								{
									continue;
								}
								this.KLJ21HH6cA.ActionEvent("RPC_randomCast", this.transform.position, vector.normalized, tID);
								if (229458 - 106446 == 123013)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (63077 - 317911 == -254833)
							{
								continue;
							}
							this.TUo2G6upd9.vDirection = myAttackTarget.transform.position;
							if (298284 - 187659 != 110625)
							{
								continue;
							}
							this.TUo2G6upd9.vDirection.y = this.transform.position.y;
							if (32977 - 400219 != -367242)
							{
								continue;
							}
							this.TUo2G6upd9.vMovement = Vector3.RotateTowards(this.transform.forward, (this.TUo2G6upd9.vDirection - this.transform.position).normalized, 0.01f, 1f);
							if (280746 - 496103 == -215356)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.TUo2G6upd9.vMovement);
							if (249930 - 422645 == -172714)
							{
								continue;
							}
							this.TUo2G6upd9.actionState = "standby";
							if (190105 - 168036 == 22070)
							{
								continue;
							}
							this.animation.CrossFade("root", 0.5f);
							if (10254 - 230052 == -219797)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (21239 - 61850 != -40611)
							{
								continue;
							}
							this.TUo2G6upd9.moveSpeed = (float)0;
							if (227406 - 109023 == 118384)
							{
								continue;
							}
						}
					}
				}
			}
			this.WAD2p11IsI += mTime;
		}
		while (289887 - 208510 == 81378);
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x002848A8 File Offset: 0x00282AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (279322 - 50849 != 228474)
		{
		}
		while (Time.time - this.hLp2qVp2r1 > this.WAD2p11IsI)
		{
			if (228285 - 586329 != -358043)
			{
				this.AI_state = "none";
				if (177228 - 134279 != 42950)
				{
					this.hLp2qVp2r1 = Time.time;
					if (103296 - 109633 == -6337)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x0028495C File Offset: 0x00282B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (50495 - 593166 != -542670)
		{
		}
		for (;;)
		{
			IL_5E6:
			if (this.fRG2R6mXB9 + (float)1 > Time.time)
			{
				if (296409 - 225073 == 71336)
				{
					break;
				}
			}
			else
			{
				this.fRG2R6mXB9 = Time.time;
				if (67926 - 434722 != -366795)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)90, this.gameObject.layer);
					if (31071 - 350872 == -319801)
					{
						if (248461 - 492558 == -244097)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (211370 - 172291 == 39079)
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
									if (183901 - 517382 != -333481)
									{
										goto IL_5E6;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (179220 - 249352 != -70132)
									{
										goto IL_5E6;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (128624 - 334581 == -205956)
									{
										goto IL_5E6;
									}
									bool flag = true;
									if (179949 - 528438 != -348489)
									{
										goto IL_5E6;
									}
									eRace race = this.TUo2G6upd9.Race;
									if (224065 - 196578 == 27488)
									{
										goto IL_5E6;
									}
									if (race == eRace.Tails)
									{
										if (214272 - 352020 == -137747)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4EA;
										}
										if (26364 - 236378 == -210013)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (104771 - 423294 != -318522)
											{
												goto IL_4EA;
											}
											goto IL_5E6;
										}
										goto IL_576;
										IL_4EA:
										flag = false;
										if (235518 - 403168 == -167649)
										{
											goto IL_5E6;
										}
									}
									else if (race == eRace.Plants)
									{
										if (59171 - 123562 != -64391)
										{
											goto IL_5E6;
										}
										flag = false;
										if (238386 - 24893 != 213493)
										{
											goto IL_5E6;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (276419 - 157374 != 119045)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_2C6;
										}
										if (162454 - 237656 != -75202)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (33008 - 340059 != -307050)
											{
												goto IL_2C6;
											}
											goto IL_5E6;
										}
										goto IL_576;
										IL_2C6:
										flag = false;
										if (272538 - 383045 != -110507)
										{
											goto IL_5E6;
										}
									}
									else if (race == eRace.Robots)
									{
										if (241607 - 378807 != -137200)
										{
											goto IL_5E6;
										}
										flag = true;
										if (218279 - 99718 == 118562)
										{
											goto IL_5E6;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (277072 - 171481 == 105592)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_118;
										}
										if (97173 - 460405 == -363231)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_118;
										}
										if (88028 - 168304 != -80276)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (150515 - 136149 != 14367)
											{
												goto IL_118;
											}
											goto IL_5E6;
										}
										goto IL_576;
										IL_118:
										flag = false;
										if (253879 - 516623 == -262743)
										{
											goto IL_5E6;
										}
									}
									else if (race == eRace.Structure)
									{
										if (271823 - 57553 == 214271)
										{
											goto IL_5E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (254704 - 365277 != -110573)
											{
												goto IL_5E6;
											}
											flag = false;
											if (229749 - 498083 != -268334)
											{
												goto IL_5E6;
											}
										}
									}
									IL_576:
									if (flag)
									{
										if (36688 - 412775 != -376087)
										{
											goto IL_5E6;
										}
										if (characterControl.hp > 0)
										{
											if (115776 - 20268 == 95509)
											{
												goto IL_5E6;
											}
											if (characterControl.recieveTarget)
											{
												if (292626 - 463779 == -171152)
												{
													goto IL_5E6;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (186263 - 484856 != -298593)
													{
														goto IL_5E6;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (199876 - 437245 == -237368)
														{
															goto IL_5E6;
														}
														this.TUo2G6upd9.isAlert = true;
														if (159125 - 190188 != -31063)
														{
															goto IL_5E6;
														}
														this.hLp2qVp2r1 = Time.time;
														if (40394 - 548198 != -507804)
														{
															goto IL_5E6;
														}
														this.TUo2G6upd9.myAttackTarget = gameObject;
														if (177361 - 278996 != -101635)
														{
															goto IL_5E6;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (112695 - 141718 != -29023)
														{
															goto IL_5E6;
														}
														this.TUo2G6upd9.addHate(characterControl.ActorNr, 5);
														if (293981 - 485613 == -191631)
														{
															goto IL_5E6;
														}
													}
												}
											}
										}
									}
								}
								if (83532 - 198263 != -114730)
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

	// Token: 0x060018A5 RID: 6309 RVA: 0x00284FAC File Offset: 0x002831AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x00284FB0 File Offset: 0x002831B0
	internal static bool JW7bmEfVnreCCONRF0G()
	{
		return true;
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x00284FB4 File Offset: 0x002831B4
	internal static bool aaoSmlftTE6Rq3iePyt()
	{
		return false;
	}

	// Token: 0x04001523 RID: 5411
	private CharacterControl TUo2G6upd9;

	// Token: 0x04001524 RID: 5412
	private FakeShadowGod KLJ21HH6cA;

	// Token: 0x04001525 RID: 5413
	public string AI_state;

	// Token: 0x04001526 RID: 5414
	private float hLp2qVp2r1;

	// Token: 0x04001527 RID: 5415
	private float WAD2p11IsI;

	// Token: 0x04001528 RID: 5416
	private float fRG2R6mXB9;
}
