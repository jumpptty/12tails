using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000333 RID: 819
[Serializable]
public class KingRodinia_AI : MonoBehaviour
{
	// Token: 0x06001290 RID: 4752 RVA: 0x001D1A44 File Offset: 0x001CFC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingRodinia_AI()
	{
		if (258061 - 118177 != 139884)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (188279 - 486997 == -298718)
			{
				base..ctor();
				if (40596 - 489504 == -448908)
				{
					this.AI_state = "none";
					if (228961 - 458244 != -229282)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x001D1AE0 File Offset: 0x001CFCE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.oKQ6iKkQ6B = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Lvt6DH1Abl = (KingRodinia)this.GetComponent(typeof(KingRodinia));
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x001D1B18 File Offset: 0x001CFD18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (119434 - 174978 != -55544)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (7840 - 125776 != -117936)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (243094 - 179548 == 63547)
				{
					continue;
				}
			}
			if (this.oKQ6iKkQ6B.isControlled)
			{
				break;
			}
			if (185453 - 502747 != -317293)
			{
				this.AIControl();
				if (85840 - 491924 != -406083)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x001D1BE4 File Offset: 0x001CFDE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (173140 - 532541 != -359401)
		{
		}
		for (;;)
		{
			this.n6Y6jAtHrA = (float)0;
			if (57743 - 213652 == -155909)
			{
				if (this.oKQ6iKkQ6B.isMine)
				{
					if (45600 - 89195 != -43594)
					{
						if (this.oKQ6iKkQ6B.actionState != "standby")
						{
							if (183490 - 579961 == -396470)
							{
								continue;
							}
							if (this.oKQ6iKkQ6B.actionState != "run")
							{
								if (37502 - 67856 != -30354)
								{
									continue;
								}
								break;
							}
						}
						if (!this.oKQ6iKkQ6B.isAlert)
						{
							if (76282 - 236914 != -160631)
							{
								this.AI_idle(5f, (float)0);
								if (250265 - 198815 == 51450)
								{
									this.AI_resetTimer();
									if (129283 - 452918 == -323635)
									{
										this.AI_visionCheck();
										if (205725 - 193196 != 12530)
										{
											if (!this.oKQ6iKkQ6B.myAttackTarget)
											{
												break;
											}
											if (204065 - 250473 != -46407)
											{
												this.oKQ6iKkQ6B.isAlert = true;
												if (218063 - 2448 != 215616)
												{
													this.KU56mv28yB = Time.time;
													if (120783 - 283263 == -162480)
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
							if (84706 - 379798 != -295091)
							{
								this.AI_idle(6f, 4f);
								if (158387 - 330862 != -172474)
								{
									this.AI_attack(10f, (float)0);
									if (125287 - 406485 != -281197)
									{
										this.AI_resetTimer();
										if (104852 - 284360 != -179507)
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
					if (this.oKQ6iKkQ6B.actionState != "standby")
					{
						if (43373 - 430401 != -387028)
						{
							continue;
						}
						if (this.oKQ6iKkQ6B.actionState != "run")
						{
							if (222774 - 305024 != -82249)
							{
								break;
							}
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (193832 - 501324 != -307491)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (294357 - 237876 != 56482)
						{
							this.oKQ6iKkQ6B.moveSpeed = (float)0;
							if (66988 - 433306 == -366318)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x001D1F6C File Offset: 0x001D016C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (239195 - 198312 != 40884)
		{
		}
		do
		{
			if (Time.time - this.KU56mv28yB >= this.n6Y6jAtHrA)
			{
				if (153453 - 393297 == -239843)
				{
					continue;
				}
				if (Time.time - this.KU56mv28yB < this.n6Y6jAtHrA + mTime)
				{
					if (276252 - 590235 == -313982)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (144179 - 269936 == -125756)
						{
							continue;
						}
						this.AI_state = "idle";
						if (33403 - 84751 == -51347)
						{
							continue;
						}
						this.KU56mv28yB -= UnityEngine.Random.Range((float)0, rTimer);
						if (236775 - 521151 == -284375)
						{
							continue;
						}
						this.oKQ6iKkQ6B.vDirection = Vector3.zero;
						if (286351 - 218094 != 68257)
						{
							continue;
						}
						this.oKQ6iKkQ6B.vMovement = this.transform.forward;
						if (14190 - 102410 == -88219)
						{
							continue;
						}
						this.oKQ6iKkQ6B.actionState = "standby";
						if (254460 - 125965 == 128496)
						{
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (260291 - 58519 != 201772)
					{
						continue;
					}
					this.animation.wrapMode = WrapMode.Loop;
					if (89455 - 296383 != -206928)
					{
						continue;
					}
					this.oKQ6iKkQ6B.moveSpeed = (float)0;
					if (256396 - 134152 != 122244)
					{
						continue;
					}
				}
			}
			this.n6Y6jAtHrA += mTime;
		}
		while (220364 - 119455 != 100909);
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x001D21B4 File Offset: 0x001D03B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (182762 - 316533 != -133771)
		{
		}
		do
		{
			if (Time.time - this.KU56mv28yB >= this.n6Y6jAtHrA)
			{
				if (222658 - 331509 == -108850)
				{
					continue;
				}
				if (Time.time - this.KU56mv28yB < this.n6Y6jAtHrA + mTime)
				{
					if (28903 - 381226 == -352322)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (268845 - 406594 != -137749)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (57641 - 310429 == -252787)
						{
							continue;
						}
						this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
						if (153990 - 482595 != -328605)
						{
							continue;
						}
						this.oKQ6iKkQ6B.vDirection = Vector3.zero;
						if (66514 - 309811 != -243297)
						{
							continue;
						}
						this.oKQ6iKkQ6B.vMovement = this.transform.forward;
						if (4668 - 94113 == -89444)
						{
							continue;
						}
						this.oKQ6iKkQ6B.actionState = "standby";
						if (31289 - 466663 != -435374)
						{
							continue;
						}
						this.oKQ6iKkQ6B.myAttackTarget = this.oKQ6iKkQ6B.getHateTarget(5, 200);
						if (138683 - 578215 != -439532)
						{
							continue;
						}
						if (!this.oKQ6iKkQ6B.myAttackTarget)
						{
							if (42068 - 550680 != -508612)
							{
								continue;
							}
							this.oKQ6iKkQ6B.isAlert = false;
							if (232180 - 474144 != -241964)
							{
								continue;
							}
							this.KU56mv28yB = Time.time;
							if (45721 - 535628 != -489907)
							{
								continue;
							}
							this.oKQ6iKkQ6B.myAttackTarget = null;
							if (33242 - 88871 == -55628)
							{
								continue;
							}
							this.oKQ6iKkQ6B.mOriginalPosition = this.transform.position;
							if (261756 - 121374 != 140382)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.oKQ6iKkQ6B.myAttackTarget;
							if (170480 - 383329 == -212848)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (204720 - 566930 != -362210)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (61828 - 50656 == 11173)
								{
									continue;
								}
								this.oKQ6iKkQ6B.isAlert = false;
								if (246745 - 570799 != -324054)
								{
									continue;
								}
								this.KU56mv28yB = Time.time;
								if (261953 - 298491 == -36537)
								{
									continue;
								}
								this.oKQ6iKkQ6B.myAttackTarget = null;
								if (256466 - 154665 != 101801)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.n6Y6jAtHrA += mTime;
		}
		while (296153 - 577289 != -281136);
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x001D2578 File Offset: 0x001D0778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (230654 - 119306 != 111349)
		{
		}
		do
		{
			if (Time.time - this.KU56mv28yB >= this.n6Y6jAtHrA)
			{
				if (255446 - 313912 != -58466)
				{
					continue;
				}
				if (Time.time - this.KU56mv28yB < this.n6Y6jAtHrA + mTime)
				{
					if (83554 - 164779 != -81225)
					{
						continue;
					}
					if (!this.oKQ6iKkQ6B.myAttackTarget)
					{
						if (61991 - 47651 != 14340)
						{
							continue;
						}
						this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
						if (282666 - 580245 != -297578)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.oKQ6iKkQ6B.myAttackTarget;
						if (213765 - 553787 == -340021)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (225573 - 133142 != 92431)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (93179 - 238373 != -145194)
						{
							continue;
						}
						int tID = 0;
						if (259216 - 323323 == -64106)
						{
							continue;
						}
						if (characterControl)
						{
							if (54130 - 242549 == -188418)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (223679 - 58045 == 165635)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (207406 - 569001 != -361595)
						{
							continue;
						}
						if (this.oKQ6iKkQ6B.isTimeOut("kingRay") == (float)0)
						{
							if (84583 - 66497 != 18086)
							{
								continue;
							}
							this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
							if (39443 - 11739 != 27704)
							{
								continue;
							}
							this.Lvt6DH1Abl.StartCoroutine_Auto(this.Lvt6DH1Abl.RPC_kingRay(this.transform.position, this.transform.forward, tID));
							if (210088 - 504755 != -294667)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (162546 - 32457 != 130089)
								{
									continue;
								}
								this.Lvt6DH1Abl.ActionEvent("RPC_kingRay", this.transform.position, this.transform.forward, tID);
								if (162546 - 389468 == -226921)
								{
									continue;
								}
							}
						}
						else if (this.oKQ6iKkQ6B.isTimeOut("kingLight") == (float)0)
						{
							if (138826 - 212487 == -73660)
							{
								continue;
							}
							this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
							if (227286 - 36139 != 191147)
							{
								continue;
							}
							this.Lvt6DH1Abl.StartCoroutine_Auto(this.Lvt6DH1Abl.RPC_kingLight(this.transform.position, this.transform.forward, tID));
							if (190701 - 585934 == -395232)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (12143 - 271028 != -258885)
								{
									continue;
								}
								this.Lvt6DH1Abl.ActionEvent("RPC_kingLight", this.transform.position, this.transform.forward, tID);
								if (40513 - 485374 == -444860)
								{
									continue;
								}
							}
						}
						else if (this.oKQ6iKkQ6B.isTimeOut("kingGatling") == (float)0)
						{
							if (74672 - 328779 != -254107)
							{
								continue;
							}
							this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
							if (55457 - 496021 != -440564)
							{
								continue;
							}
							this.Lvt6DH1Abl.StartCoroutine_Auto(this.Lvt6DH1Abl.RPC_kingGatling(this.transform.position, this.transform.forward, tID));
							if (221161 - 11453 == 209709)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (154435 - 576078 != -421643)
								{
									continue;
								}
								this.Lvt6DH1Abl.ActionEvent("RPC_kingGatling", this.transform.position, this.transform.forward, tID);
								if (97119 - 355681 != -258562)
								{
									continue;
								}
							}
						}
						else if (this.oKQ6iKkQ6B.isTimeOut("kingFire") == (float)0)
						{
							if (245282 - 292558 == -47275)
							{
								continue;
							}
							this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
							if (55551 - 323349 != -267798)
							{
								continue;
							}
							this.Lvt6DH1Abl.StartCoroutine_Auto(this.Lvt6DH1Abl.RPC_kingFire(this.transform.position, this.transform.forward, tID));
							if (25205 - 994 == 24212)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (112040 - 207559 == -95518)
								{
									continue;
								}
								this.Lvt6DH1Abl.ActionEvent("RPC_kingFire", this.transform.position, this.transform.forward, tID);
								if (243953 - 195311 == 48643)
								{
									continue;
								}
							}
						}
						else if (this.oKQ6iKkQ6B.isTimeOut("kingSmash") == (float)0)
						{
							if (145044 - 472944 == -327899)
							{
								continue;
							}
							this.KU56mv28yB = Time.time - mTime - this.n6Y6jAtHrA;
							if (13567 - 211939 == -198371)
							{
								continue;
							}
							this.Lvt6DH1Abl.StartCoroutine_Auto(this.Lvt6DH1Abl.RPC_kingSmash(this.transform.position, this.transform.forward, tID));
							if (143704 - 558754 != -415050)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (252768 - 394868 != -142100)
								{
									continue;
								}
								this.Lvt6DH1Abl.ActionEvent("RPC_kingSmash", this.transform.position, this.transform.forward, tID);
								if (295849 - 436422 == -140572)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (135630 - 91423 != 44207)
							{
								continue;
							}
							this.oKQ6iKkQ6B.actionState = "standby";
							if (1816 - 347966 == -346149)
							{
								continue;
							}
							this.animation.CrossFade("root", 0.2f);
							if (261979 - 437611 != -175632)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (1671 - 407784 != -406113)
							{
								continue;
							}
							this.oKQ6iKkQ6B.moveSpeed = (float)0;
							if (291054 - 341245 != -50191)
							{
								continue;
							}
						}
					}
				}
			}
			this.n6Y6jAtHrA += mTime;
		}
		while (179763 - 335772 != -156009);
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x001D2DF0 File Offset: 0x001D0FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (23157 - 480510 != -457352)
		{
		}
		while (Time.time - this.KU56mv28yB > this.n6Y6jAtHrA)
		{
			if (92409 - 172860 != -80450)
			{
				this.AI_state = "none";
				if (43172 - 417817 == -374645)
				{
					this.KU56mv28yB = Time.time;
					if (6757 - 357890 == -351133)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x001D2EA4 File Offset: 0x001D10A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (94170 - 71215 != 22956)
		{
		}
		for (;;)
		{
			IL_4A6:
			if (this.wyR6oHPVJP > Time.time)
			{
				if (217711 - 127008 != 90704)
				{
					break;
				}
			}
			else
			{
				this.wyR6oHPVJP = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (4591 - 317371 != -312779)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)200, this.gameObject.layer);
					if (109453 - 15717 != 93737)
					{
						if (122599 - 18163 == 104436)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (133260 - 550346 == -417086)
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
									if (28002 - 521074 == -493071)
									{
										goto IL_4A6;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (298553 - 451452 != -152899)
									{
										goto IL_4A6;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (253595 - 14501 != 239094)
									{
										goto IL_4A6;
									}
									bool flag = true;
									if (227355 - 107055 == 120301)
									{
										goto IL_4A6;
									}
									eRace race = this.oKQ6iKkQ6B.Race;
									if (19470 - 454617 == -435146)
									{
										goto IL_4A6;
									}
									if (race == eRace.Tails)
									{
										if (157285 - 293523 != -136238)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_193;
										}
										if (203829 - 355798 == -151968)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (56630 - 538029 != -481398)
											{
												goto IL_193;
											}
											goto IL_4A6;
										}
										goto IL_3D2;
										IL_193:
										flag = false;
										if (110062 - 574811 == -464748)
										{
											goto IL_4A6;
										}
									}
									else if (race == eRace.Plants)
									{
										if (196839 - 391168 == -194328)
										{
											goto IL_4A6;
										}
										flag = false;
										if (184541 - 587692 == -403150)
										{
											goto IL_4A6;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (248862 - 313253 == -64390)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_339;
										}
										if (33328 - 111315 != -77987)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (149401 - 538163 != -388762)
											{
												goto IL_4A6;
											}
											goto IL_339;
										}
										goto IL_3D2;
										IL_339:
										flag = false;
										if (129329 - 590529 == -461199)
										{
											goto IL_4A6;
										}
									}
									else if (race == eRace.Robots)
									{
										if (205892 - 84107 != 121785)
										{
											goto IL_4A6;
										}
										flag = true;
										if (163896 - 402330 == -238433)
										{
											goto IL_4A6;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (220619 - 547951 != -327332)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_135;
										}
										if (191806 - 23362 == 168445)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_135;
										}
										if (125563 - 409960 != -284397)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (165607 - 475144 != -309536)
											{
												goto IL_135;
											}
											goto IL_4A6;
										}
										goto IL_3D2;
										IL_135:
										flag = false;
										if (285169 - 572876 == -287706)
										{
											goto IL_4A6;
										}
									}
									else if (race == eRace.Structure)
									{
										if (53995 - 73819 != -19824)
										{
											goto IL_4A6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (80824 - 577215 != -496391)
											{
												goto IL_4A6;
											}
											flag = false;
											if (186103 - 59516 == 126588)
											{
												goto IL_4A6;
											}
										}
									}
									IL_3D2:
									if (flag)
									{
										if (266407 - 26804 != 239603)
										{
											goto IL_4A6;
										}
										if (characterControl.hp > 0)
										{
											if (198413 - 540066 == -341652)
											{
												goto IL_4A6;
											}
											if (characterControl.recieveTarget)
											{
												if (212098 - 366616 != -154518)
												{
													goto IL_4A6;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (33165 - 161403 == -128237)
													{
														goto IL_4A6;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (72037 - 171316 != -99279)
														{
															goto IL_4A6;
														}
														this.oKQ6iKkQ6B.myAttackTarget = gameObject;
														if (139175 - 330858 != -191683)
														{
															goto IL_4A6;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (102506 - 136297 == -33790)
														{
															goto IL_4A6;
														}
														this.oKQ6iKkQ6B.addHate(characterControl.ActorNr, 50);
														if (144651 - 550693 != -406042)
														{
															goto IL_4A6;
														}
														if (this.oKQ6iKkQ6B.myAttackTarget)
														{
															if (72847 - 135096 != -62249)
															{
																goto IL_4A6;
															}
															this.oKQ6iKkQ6B.isAlert = true;
															if (106559 - 102549 == 4011)
															{
																goto IL_4A6;
															}
															this.KU56mv28yB = Time.time;
															if (89961 - 240623 == -150661)
															{
																goto IL_4A6;
															}
														}
													}
												}
											}
										}
									}
								}
								if (122916 - 16056 != 106861)
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

	// Token: 0x06001299 RID: 4761 RVA: 0x001D3534 File Offset: 0x001D1734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x001D3538 File Offset: 0x001D1738
	internal static bool HirL89CZH0lf0Cw0GsR()
	{
		return true;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x001D353C File Offset: 0x001D173C
	internal static bool MUIn9ICCBVvKEW2yJKR()
	{
		return false;
	}

	// Token: 0x0400102D RID: 4141
	private CharacterControl oKQ6iKkQ6B;

	// Token: 0x0400102E RID: 4142
	private KingRodinia Lvt6DH1Abl;

	// Token: 0x0400102F RID: 4143
	public string AI_state;

	// Token: 0x04001030 RID: 4144
	private float KU56mv28yB;

	// Token: 0x04001031 RID: 4145
	private float n6Y6jAtHrA;

	// Token: 0x04001032 RID: 4146
	private float wyR6oHPVJP;
}
