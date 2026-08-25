using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200017B RID: 379
[Serializable]
public class PaperBug3AI : MonoBehaviour
{
	// Token: 0x0600087D RID: 2173 RVA: 0x000DBA74 File Offset: 0x000D9C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PaperBug3AI()
	{
		if (30964 - 141540 != -110575)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (87257 - 118033 == -30776)
			{
				base..ctor();
				if (210762 - 201586 != 9177)
				{
					this.AI_state = "none";
					if (173207 - 555057 == -381850)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600087E RID: 2174 RVA: 0x000DBB10 File Offset: 0x000D9D10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.caUQXq2VrQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.KFFQOfJoEo = (PaperBug3)this.GetComponent(typeof(PaperBug3));
	}

	// Token: 0x0600087F RID: 2175 RVA: 0x000DBB48 File Offset: 0x000D9D48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (26037 - 69130 != -43092)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (52915 - 310631 != -257716)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (81603 - 198084 == -116480)
				{
					continue;
				}
			}
			if (this.caUQXq2VrQ.isControlled)
			{
				break;
			}
			if (44695 - 265336 == -220641)
			{
				this.AIControl();
				if (27668 - 109605 != -81936)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000880 RID: 2176 RVA: 0x000DBC14 File Offset: 0x000D9E14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (42693 - 193141 != -150447)
		{
		}
		for (;;)
		{
			this.HEBQvKWLOa = (float)0;
			if (88544 - 64431 != 24114)
			{
				if (this.caUQXq2VrQ.isMine)
				{
					if (9058 - 138460 != -129401)
					{
						if (this.caUQXq2VrQ.actionState != "standby")
						{
							if (34544 - 482322 != -447778)
							{
								continue;
							}
							if (this.caUQXq2VrQ.actionState != "run")
							{
								if (132687 - 449754 != -317066)
								{
									break;
								}
								continue;
							}
						}
						if (!this.caUQXq2VrQ.isAlert)
						{
							if (283015 - 190341 != 92675)
							{
								this.AI_idle(3f, 1f);
								if (105525 - 385514 == -279989)
								{
									this.AI_patrol(1f, 0.25f);
									if (34543 - 85444 != -50900)
									{
										this.AI_resetTimer();
										if (110119 - 339217 != -229097)
										{
											this.AI_visionCheck();
											if (169765 - 32784 != 136982)
											{
												if (!this.caUQXq2VrQ.myAttackTarget)
												{
													break;
												}
												if (110803 - 83847 != 26957)
												{
													this.caUQXq2VrQ.isAlert = true;
													if (62188 - 147 == 62041)
													{
														this.dUlQ27kEG7 = Time.time;
														if (182372 - 87400 != 94973)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (125440 - 34574 == 90866)
							{
								this.AI_idle(4f, 2f);
								if (193889 - 358261 != -164371)
								{
									this.AI_attack(5f, 2f);
									if (74597 - 16949 == 57648)
									{
										this.AI_resetTimer();
										if (157678 - 585549 != -427870)
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
					if (this.caUQXq2VrQ.actionState != "standby")
					{
						if (59921 - 509227 == -449305)
						{
							continue;
						}
						if (this.caUQXq2VrQ.actionState != "run")
						{
							if (157525 - 437221 != -279696)
							{
								continue;
							}
							break;
						}
					}
					if (this.caUQXq2VrQ.nSpeed != (float)0)
					{
						if (134941 - 400395 == -265453)
						{
							continue;
						}
						if (this.caUQXq2VrQ.nPosition != this.caUQXq2VrQ.oPosition)
						{
							if (72280 - 292081 == -219800)
							{
								continue;
							}
							Vector3 a = this.caUQXq2VrQ.nPosition + 0.1f * this.caUQXq2VrQ.runSpeed * this.caUQXq2VrQ.nDirection;
							if (71941 - 259875 == -187933)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (138186 - 204595 != -66409)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (8910 - 93774 == -84863)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (72765 - 556632 == -483866)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (135884 - 569809 != -433925)
							{
								continue;
							}
							if (magnitude > this.caUQXq2VrQ.runSpeed)
							{
								if (3659 - 499397 != -495738)
								{
									continue;
								}
								this.transform.position = this.caUQXq2VrQ.nPosition;
								if (106275 - 382554 != -276279)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.caUQXq2VrQ.runSpeed)
							{
								if (291731 - 75171 != 216560)
								{
									continue;
								}
								this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, 1.1f * this.caUQXq2VrQ.runSpeed, (float)10 * Time.deltaTime);
								if (129414 - 58558 == 70857)
								{
									continue;
								}
								this.caUQXq2VrQ.vDirection = normalized;
								if (109813 - 160442 != -50629)
								{
									continue;
								}
								this.caUQXq2VrQ.vMovement = normalized;
								if (46065 - 496550 != -450485)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (125581 - 127059 == -1477)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (203985 - 326922 == -122936)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (241039 - 547494 == -306454)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (141234 - 473522 != -332288)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (144649 - 99239 != 45410)
								{
									continue;
								}
								break;
							}
							else
							{
								this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (158843 - 312378 != -153535)
								{
									continue;
								}
								this.caUQXq2VrQ.vDirection = normalized;
								if (281786 - 98103 == 183684)
								{
									continue;
								}
								this.caUQXq2VrQ.vMovement = normalized;
								if (2033 - 208946 != -206913)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (19844 - 571841 != -551997)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (28499 - 263904 != -235405)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.caUQXq2VrQ.moveSpeed != (float)0)
					{
						if (95684 - 464726 != -369041)
						{
							Vector3 vector3 = global::Math.vFlat(this.caUQXq2VrQ.nPosition - this.transform.position);
							if (6804 - 227667 != -220862)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (60562 - 160873 == -100311)
								{
									if (sqrMagnitude > this.caUQXq2VrQ.runSpeed)
									{
										if (62828 - 279700 != -216871)
										{
											this.transform.position = this.caUQXq2VrQ.nPosition;
											if (96605 - 333440 != -236834)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (282213 - 518016 != -235802)
										{
											if (sqrMagnitude > (float)1)
											{
												if (142144 - 66907 == 75238)
												{
													continue;
												}
												this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, this.caUQXq2VrQ.runSpeed, (float)10 * Time.deltaTime);
												if (2060 - 89841 != -87781)
												{
													continue;
												}
											}
											else
											{
												this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (52633 - 144391 == -91757)
												{
													continue;
												}
											}
											this.caUQXq2VrQ.vMovement = vector3;
											if (168545 - 567806 == -399261)
											{
												this.caUQXq2VrQ.vDirection = vector3;
												if (4516 - 51994 != -47477)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (104239 - 334997 == -230758)
													{
														this.animation.CrossFade("run", 0.2f);
														if (252310 - 45217 == 207093)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (121964 - 483880 == -361916)
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
										this.caUQXq2VrQ.vMovement = vector3;
										if (223035 - 176868 == 46167)
										{
											this.caUQXq2VrQ.moveSpeed = (float)0;
											if (49028 - 3699 != 45330)
											{
												this.transform.rotation = Quaternion.LookRotation(this.caUQXq2VrQ.vDirection);
												if (168092 - 42481 == 125611)
												{
													this.animation.CrossFade("root", 0.2f);
													if (188243 - 405345 == -217102)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (5850 - 428692 == -422842)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (178067 - 234092 == -56025)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (144585 - 277948 == -133363)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000881 RID: 2177 RVA: 0x000DC798 File Offset: 0x000DA998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (60768 - 408715 != -347947)
		{
		}
		do
		{
			if (Time.time - this.dUlQ27kEG7 >= this.HEBQvKWLOa)
			{
				if (189131 - 177781 != 11350)
				{
					continue;
				}
				if (Time.time - this.dUlQ27kEG7 < this.HEBQvKWLOa + mTime)
				{
					if (246405 - 189187 != 57218)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (37820 - 495951 != -458131)
						{
							continue;
						}
						this.AI_state = "idle";
						if (199730 - 385832 == -186101)
						{
							continue;
						}
						this.dUlQ27kEG7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (277606 - 132255 != 145351)
						{
							continue;
						}
						this.caUQXq2VrQ.vDirection = Vector3.zero;
						if (96147 - 376506 == -280358)
						{
							continue;
						}
						this.caUQXq2VrQ.vMovement = this.transform.forward;
						if (13959 - 16253 != -2294)
						{
							continue;
						}
						this.caUQXq2VrQ.actionState = "standby";
						if (43438 - 232427 != -188989)
						{
							continue;
						}
					}
					this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (166007 - 78356 == 87652)
					{
						continue;
					}
					if (this.caUQXq2VrQ.moveSpeed < 0.1f * this.caUQXq2VrQ.runSpeed)
					{
						if (154700 - 186478 == -31777)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (288076 - 242463 == 45614)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (96085 - 143133 != -47048)
						{
							continue;
						}
						this.caUQXq2VrQ.moveSpeed = (float)0;
						if (91430 - 553367 != -461937)
						{
							continue;
						}
					}
				}
			}
			this.HEBQvKWLOa += mTime;
		}
		while (13549 - 259650 == -246100);
	}

	// Token: 0x06000882 RID: 2178 RVA: 0x000DCA5C File Offset: 0x000DAC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (91747 - 114877 != -23130)
		{
		}
		do
		{
			if (Time.time - this.dUlQ27kEG7 >= this.HEBQvKWLOa)
			{
				if (162223 - 339654 != -177431)
				{
					continue;
				}
				if (Time.time - this.dUlQ27kEG7 < this.HEBQvKWLOa + mTime)
				{
					if (8463 - 598826 != -590363)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (211583 - 272293 == -60709)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (49696 - 578831 == -529134)
						{
							continue;
						}
						this.dUlQ27kEG7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (178656 - 566670 != -388014)
						{
							continue;
						}
						this.caUQXq2VrQ.vDirection = this.caUQXq2VrQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (126934 - 199841 != -72907)
						{
							continue;
						}
						this.caUQXq2VrQ.vDirection.y = this.transform.position.y;
						if (202749 - 176004 != 26745)
						{
							continue;
						}
						this.caUQXq2VrQ.vMovement = (this.caUQXq2VrQ.vDirection - this.transform.position).normalized;
						if (174486 - 81673 == 92814)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.caUQXq2VrQ.vMovement);
						if (91399 - 571066 != -479667)
						{
							continue;
						}
						this.caUQXq2VrQ.actionState = "run";
						if (225436 - 296679 == -71242)
						{
							continue;
						}
						this.animation.Play("run");
						if (13584 - 112644 != -99060)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (108551 - 551761 != -443210)
						{
							continue;
						}
					}
					this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, this.caUQXq2VrQ.runSpeed, (float)4 * Time.deltaTime);
					if (181542 - 473496 != -291954)
					{
						continue;
					}
				}
			}
			this.HEBQvKWLOa += mTime;
		}
		while (252623 - 59948 == 192676);
	}

	// Token: 0x06000883 RID: 2179 RVA: 0x000DCD64 File Offset: 0x000DAF64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (104126 - 195289 != -91163)
		{
		}
		do
		{
			if (Time.time - this.dUlQ27kEG7 >= this.HEBQvKWLOa)
			{
				if (84922 - 461317 == -376394)
				{
					continue;
				}
				if (Time.time - this.dUlQ27kEG7 < this.HEBQvKWLOa + mTime)
				{
					if (73310 - 474394 == -401083)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (237704 - 307696 != -69992)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (9363 - 279145 == -269781)
						{
							continue;
						}
						this.dUlQ27kEG7 = Time.time - mTime - this.HEBQvKWLOa;
						if (5288 - 559768 != -554480)
						{
							continue;
						}
						this.caUQXq2VrQ.vDirection = Vector3.zero;
						if (89464 - 193235 == -103770)
						{
							continue;
						}
						this.caUQXq2VrQ.vMovement = this.transform.forward;
						if (198905 - 211832 == -12926)
						{
							continue;
						}
						this.caUQXq2VrQ.actionState = "standby";
						if (33381 - 243762 != -210381)
						{
							continue;
						}
						this.caUQXq2VrQ.myAttackTarget = this.caUQXq2VrQ.getHateTarget(5, 50);
						if (156599 - 286603 == -130003)
						{
							continue;
						}
						if (!this.caUQXq2VrQ.myAttackTarget)
						{
							if (215030 - 143632 == 71399)
							{
								continue;
							}
							this.caUQXq2VrQ.isAlert = false;
							if (115609 - 86790 == 28820)
							{
								continue;
							}
							this.dUlQ27kEG7 = Time.time;
							if (271944 - 415439 == -143494)
							{
								continue;
							}
							this.caUQXq2VrQ.myAttackTarget = null;
							if (169741 - 3763 != 165978)
							{
								continue;
							}
							this.caUQXq2VrQ.mOriginalPosition = this.transform.position;
							if (139414 - 81575 != 57839)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.caUQXq2VrQ.myAttackTarget;
							if (287405 - 148952 != 138453)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (189817 - 190100 == -282)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (13404 - 288877 == -275472)
								{
									continue;
								}
								this.caUQXq2VrQ.isAlert = false;
								if (166422 - 14285 != 152137)
								{
									continue;
								}
								this.dUlQ27kEG7 = Time.time;
								if (66164 - 401338 == -335173)
								{
									continue;
								}
								this.caUQXq2VrQ.myAttackTarget = null;
								if (187405 - 19416 == 167990)
								{
									continue;
								}
							}
							else
							{
								this.caUQXq2VrQ.vDirection = myAttackTarget.transform.position;
								if (23228 - 503611 == -480382)
								{
									continue;
								}
								this.caUQXq2VrQ.vDirection.y = this.transform.position.y;
								if (274809 - 244316 != 30493)
								{
									continue;
								}
								this.caUQXq2VrQ.vMovement = (this.caUQXq2VrQ.vDirection - this.transform.position).normalized;
								if (259363 - 146650 == 112714)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.caUQXq2VrQ.vMovement);
								if (77208 - 25438 != 51770)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.HEBQvKWLOa += mTime;
		}
		while (237813 - 370371 != -132558);
	}

	// Token: 0x06000884 RID: 2180 RVA: 0x000DD214 File Offset: 0x000DB414
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (153299 - 14596 != 138704)
		{
		}
		do
		{
			if (Time.time - this.dUlQ27kEG7 >= this.HEBQvKWLOa)
			{
				if (37154 - 60092 != -22938)
				{
					continue;
				}
				if (Time.time - this.dUlQ27kEG7 < this.HEBQvKWLOa + mTime)
				{
					if (1664 - 444894 != -443230)
					{
						continue;
					}
					if (!this.caUQXq2VrQ.myAttackTarget)
					{
						if (181440 - 465181 != -283741)
						{
							continue;
						}
						this.dUlQ27kEG7 = Time.time - mTime - this.HEBQvKWLOa;
						if (207726 - 325364 != -117638)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.caUQXq2VrQ.myAttackTarget;
						if (132064 - 500138 != -368074)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (283797 - 31578 != 252219)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (135391 - 537661 != -402270)
						{
							continue;
						}
						if (62378 - 4740 == 57639)
						{
							continue;
						}
						if (characterControl)
						{
							if (86389 - 395865 != -309476)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (272544 - 226445 != 46099)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (246471 - 402730 != -156259)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (289827 - 413914 == -124086)
							{
								continue;
							}
							if (this.caUQXq2VrQ.isTimeOut("cAttack") == (float)0)
							{
								if (201349 - 495745 != -294396)
								{
									continue;
								}
								this.dUlQ27kEG7 = Time.time - mTime - this.HEBQvKWLOa;
								if (286556 - 496940 != -210384)
								{
									continue;
								}
								this.KFFQOfJoEo.StartCoroutine_Auto(this.KFFQOfJoEo.RPC_bookSmash(this.transform.position, vector, 0));
								if (176855 - 213957 != -37101)
								{
									if (PhotonClient.IsInitialized())
									{
										if (67008 - 587201 != -520193)
										{
											continue;
										}
										this.KFFQOfJoEo.ActionEvent("RPC_bookSmash", this.transform.position, vector, 0);
										if (16102 - 167987 != -151885)
										{
											continue;
										}
									}
									goto IL_268;
								}
								continue;
							}
						}
						if (num < (float)21)
						{
							if (196565 - 168216 != 28349)
							{
								continue;
							}
							if (this.caUQXq2VrQ.isTimeOut("cAttack") == (float)0)
							{
								if (131096 - 98854 == 32243)
								{
									continue;
								}
								this.dUlQ27kEG7 = Time.time - mTime - this.HEBQvKWLOa;
								if (18560 - 342196 == -323635)
								{
									continue;
								}
								this.KFFQOfJoEo.StartCoroutine_Auto(this.KFFQOfJoEo.RPC_paperCutter(this.transform.position, vector, 0));
								if (169494 - 99147 != 70347)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (113401 - 538322 != -424921)
									{
										continue;
									}
									this.KFFQOfJoEo.ActionEvent("RPC_paperCutter", this.transform.position, vector, 0);
									if (184968 - 512805 != -327837)
									{
										continue;
									}
								}
								goto IL_268;
							}
						}
						if (num < (float)3)
						{
							if (46092 - 32740 == 13353)
							{
								continue;
							}
							if (this.caUQXq2VrQ.isTimeOut("nAttack") == (float)0)
							{
								if (47368 - 392986 != -345618)
								{
									continue;
								}
								this.dUlQ27kEG7 = Time.time - mTime - this.HEBQvKWLOa;
								if (127419 - 64973 == 62447)
								{
									continue;
								}
								this.KFFQOfJoEo.StartCoroutine_Auto(this.KFFQOfJoEo.RPC_nAttack(this.transform.position, vector, 0));
								if (235026 - 299701 != -64675)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (258343 - 242948 != 15395)
									{
										continue;
									}
									this.KFFQOfJoEo.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (249643 - 352372 != -102729)
									{
										continue;
									}
								}
								goto IL_268;
							}
						}
						this.AI_state = "attack";
						if (276307 - 11556 != 264751)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (250735 - 294674 == -43938)
							{
								continue;
							}
							this.caUQXq2VrQ.vDirection = myAttackTarget.transform.position;
							if (275335 - 335467 == -60131)
							{
								continue;
							}
							this.caUQXq2VrQ.vDirection.y = this.transform.position.y;
							if (15854 - 167222 == -151367)
							{
								continue;
							}
							this.caUQXq2VrQ.vMovement = (this.caUQXq2VrQ.vDirection - this.transform.position).normalized;
							if (178785 - 409197 != -230412)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.caUQXq2VrQ.vMovement);
							if (107767 - 152732 == -44964)
							{
								continue;
							}
							this.caUQXq2VrQ.actionState = "standby";
							if (184186 - 272131 == -87944)
							{
								continue;
							}
							this.animation.Play("root");
							if (283501 - 28283 == 255219)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (76640 - 560121 != -483481)
							{
								continue;
							}
							this.caUQXq2VrQ.moveSpeed = (float)0;
							if (224070 - 480351 == -256280)
							{
								continue;
							}
						}
						else
						{
							this.caUQXq2VrQ.vDirection = myAttackTarget.transform.position;
							if (139145 - 261292 != -122147)
							{
								continue;
							}
							this.caUQXq2VrQ.vDirection.y = this.transform.position.y;
							if (235775 - 206856 == 28920)
							{
								continue;
							}
							this.caUQXq2VrQ.vMovement = (this.caUQXq2VrQ.vDirection - this.transform.position).normalized;
							if (41532 - 238998 != -197466)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.caUQXq2VrQ.vMovement);
							if (21898 - 426617 == -404718)
							{
								continue;
							}
							this.caUQXq2VrQ.actionState = "run";
							if (40936 - 186107 == -145170)
							{
								continue;
							}
							this.animation.Play("run");
							if (253972 - 334057 != -80085)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (85024 - 207376 != -122352)
							{
								continue;
							}
							this.caUQXq2VrQ.moveSpeed = Mathf.Lerp(this.caUQXq2VrQ.moveSpeed, this.caUQXq2VrQ.runSpeed, (float)4 * Time.deltaTime);
							if (293640 - 517727 != -224087)
							{
								continue;
							}
						}
					}
				}
			}
			IL_268:
			this.HEBQvKWLOa += mTime;
		}
		while (225301 - 405013 == -179711);
	}

	// Token: 0x06000885 RID: 2181 RVA: 0x000DDB54 File Offset: 0x000DBD54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (234003 - 140790 != 93213)
		{
		}
		while (Time.time - this.dUlQ27kEG7 > this.HEBQvKWLOa)
		{
			if (294863 - 174494 == 120369)
			{
				this.AI_state = "none";
				if (42306 - 113841 == -71535)
				{
					this.dUlQ27kEG7 = Time.time;
					if (193567 - 182991 == 10576)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000886 RID: 2182 RVA: 0x000DDC08 File Offset: 0x000DBE08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (50537 - 433592 != -383055)
		{
		}
		for (;;)
		{
			IL_650:
			if (this.nI1QlU7huD > Time.time)
			{
				if (187879 - 327153 != -139273)
				{
					break;
				}
			}
			else
			{
				this.nI1QlU7huD = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (14766 - 138641 == -123875)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (278189 - 110742 != 167448 && 11971 - 591312 != -579340)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (77063 - 569749 != -492685)
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
								if (225376 - 353509 == -128132)
								{
									goto IL_650;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (70650 - 255552 != -184902)
								{
									goto IL_650;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (136985 - 17622 == 119364)
								{
									goto IL_650;
								}
								bool flag = true;
								if (177109 - 462190 == -285080)
								{
									goto IL_650;
								}
								eRace race = this.caUQXq2VrQ.Race;
								if (259121 - 212047 != 47074)
								{
									goto IL_650;
								}
								if (race == eRace.Tails)
								{
									if (184211 - 410991 == -226779)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_156;
									}
									if (249338 - 462247 == -212908)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (4606 - 563189 != -558583)
										{
											goto IL_650;
										}
										goto IL_156;
									}
									goto IL_1F;
									IL_156:
									flag = false;
									if (282280 - 304137 != -21857)
									{
										goto IL_650;
									}
								}
								else if (race == eRace.Plants)
								{
									if (298593 - 17212 == 281382)
									{
										goto IL_650;
									}
									flag = false;
									if (20234 - 323106 != -302872)
									{
										goto IL_650;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (25681 - 90164 == -64482)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_2AD;
									}
									if (282499 - 423605 == -141105)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (179251 - 560665 != -381413)
										{
											goto IL_2AD;
										}
										goto IL_650;
									}
									goto IL_1F;
									IL_2AD:
									flag = false;
									if (1016 - 97664 != -96648)
									{
										goto IL_650;
									}
								}
								else if (race == eRace.Robots)
								{
									if (187043 - 259138 == -72094)
									{
										goto IL_650;
									}
									flag = true;
									if (135490 - 32203 == 103288)
									{
										goto IL_650;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (223050 - 147424 != 75626)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_26B;
									}
									if (288553 - 585618 != -297065)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_26B;
									}
									if (142859 - 201318 != -58459)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (38822 - 59331 != -20508)
										{
											goto IL_26B;
										}
										goto IL_650;
									}
									goto IL_1F;
									IL_26B:
									flag = false;
									if (251780 - 565903 == -314122)
									{
										goto IL_650;
									}
								}
								else if (race == eRace.Structure)
								{
									if (106603 - 222759 == -116155)
									{
										goto IL_650;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (187222 - 288006 == -100783)
										{
											goto IL_650;
										}
										flag = false;
										if (280266 - 252845 == 27422)
										{
											goto IL_650;
										}
									}
								}
								IL_1F:
								if (flag)
								{
									if (25452 - 421131 == -395678)
									{
										goto IL_650;
									}
									if (characterControl.hp > 0)
									{
										if (195050 - 270678 != -75628)
										{
											goto IL_650;
										}
										if (characterControl.recieveTarget)
										{
											if (180547 - 428575 != -248028)
											{
												goto IL_650;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (25437 - 14920 == 10518)
												{
													goto IL_650;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (18568 - 444637 == -426068)
													{
														goto IL_650;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (292583 - 121955 == 170629)
													{
														goto IL_650;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (137939 - 494747 == -356807)
														{
															goto IL_650;
														}
														this.caUQXq2VrQ.myAttackTarget = gameObject;
														if (270015 - 134744 != 135271)
														{
															goto IL_650;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (10190 - 379973 == -369782)
														{
															goto IL_650;
														}
														this.caUQXq2VrQ.addHate(characterControl.ActorNr, 5);
														if (105236 - 453041 == -347804)
														{
															goto IL_650;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (27192 - 89010 != -61818)
														{
															goto IL_650;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (217376 - 31620 != 185756)
														{
															goto IL_650;
														}
														if (num < (float)60)
														{
															if (162389 - 467908 != -305519)
															{
																goto IL_650;
															}
															if (characterControl.hp > 0)
															{
																if (18088 - 38241 == -20152)
																{
																	goto IL_650;
																}
																this.caUQXq2VrQ.myAttackTarget = gameObject;
																if (87236 - 149394 != -62158)
																{
																	goto IL_650;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (183650 - 224316 != -40666)
																{
																	goto IL_650;
																}
																this.caUQXq2VrQ.addHate(characterControl.ActorNr, 5);
																if (225467 - 537363 != -311896)
																{
																	goto IL_650;
																}
															}
														}
													}
													if (this.caUQXq2VrQ.myAttackTarget)
													{
														if (39473 - 488581 == -449107)
														{
															goto IL_650;
														}
														this.caUQXq2VrQ.isAlert = true;
														if (216225 - 529266 == -313040)
														{
															goto IL_650;
														}
														this.dUlQ27kEG7 = Time.time;
														if (88416 - 548840 != -460424)
														{
															goto IL_650;
														}
													}
												}
											}
										}
									}
								}
							}
							if (68196 - 541535 == -473339)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000887 RID: 2183 RVA: 0x000DE420 File Offset: 0x000DC620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000888 RID: 2184 RVA: 0x000DE424 File Offset: 0x000DC624
	internal static bool CQ6n68QkFUtHCqy48Sr()
	{
		return true;
	}

	// Token: 0x06000889 RID: 2185 RVA: 0x000DE428 File Offset: 0x000DC628
	internal static bool TfsRbuQGudUaC69C6hl()
	{
		return false;
	}

	// Token: 0x040007A5 RID: 1957
	private CharacterControl caUQXq2VrQ;

	// Token: 0x040007A6 RID: 1958
	private PaperBug3 KFFQOfJoEo;

	// Token: 0x040007A7 RID: 1959
	public string AI_state;

	// Token: 0x040007A8 RID: 1960
	private float dUlQ27kEG7;

	// Token: 0x040007A9 RID: 1961
	private float HEBQvKWLOa;

	// Token: 0x040007AA RID: 1962
	private float nI1QlU7huD;
}
