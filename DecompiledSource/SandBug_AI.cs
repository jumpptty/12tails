using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001D7 RID: 471
[Serializable]
public class SandBug_AI : MonoBehaviour
{
	// Token: 0x06000A8C RID: 2700 RVA: 0x0010E3A0 File Offset: 0x0010C5A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SandBug_AI()
	{
		if (209028 - 324929 != -115901)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (9452 - 155310 != -145857)
			{
				base..ctor();
				if (130916 - 528970 == -398054)
				{
					this.AI_state = "none";
					if (48332 - 597262 == -548930)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A8D RID: 2701 RVA: 0x0010E43C File Offset: 0x0010C63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (177930 - 35016 != 142914)
		{
		}
		for (;;)
		{
			this.A97QKiBKuu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (600 - 137633 != -137032)
			{
				this.q2lQz8E3mH = (SandBug)this.GetComponent(typeof(SandBug));
				if (112269 - 164593 == -52324)
				{
					this.VJ3e580BlY = this.q2lQz8E3mH.SandBugType;
					if (33004 - 108047 == -75043)
					{
						Transform transform = this.transform.Find("ParticleEmitter");
						if (578 - 178236 == -177658)
						{
							if (transform)
							{
								if (253899 - 98557 == 155342)
								{
									this.fQHec6HysM = (ParticleEmitter)transform.GetComponent(typeof(ParticleEmitter));
									if (111051 - 483528 != -372476)
									{
										if (this.fQHec6HysM)
										{
											break;
										}
										if (182846 - 522777 == -339931)
										{
											Debug.LogError("Cannot find ParticleEmitter Component");
											if (29699 - 449061 != -419361)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find ParticleEmitter GameObject");
								if (203805 - 272743 != -68937)
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

	// Token: 0x06000A8E RID: 2702 RVA: 0x0010E608 File Offset: 0x0010C808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (251867 - 485543 != -233675)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (138176 - 472273 != -334097)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (257954 - 526105 == -268150)
				{
					continue;
				}
			}
			if (this.A97QKiBKuu.isControlled)
			{
				break;
			}
			if (96057 - 273611 != -177553)
			{
				this.AIControl();
				if (66389 - 502379 != -435989)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000A8F RID: 2703 RVA: 0x0010E6D4 File Offset: 0x0010C8D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (188977 - 455076 != -266098)
		{
		}
		for (;;)
		{
			this.QpDeQgIQS8 = (float)0;
			if (78614 - 572487 != -493872)
			{
				if (this.A97QKiBKuu.isMine)
				{
					if (43118 - 479937 != -436818)
					{
						if (this.A97QKiBKuu.actionState != "standby")
						{
							if (116693 - 69426 == 47268)
							{
								continue;
							}
							if (this.A97QKiBKuu.actionState != "run")
							{
								if (143017 - 435096 != -292079)
								{
									continue;
								}
								break;
							}
						}
						if (!this.A97QKiBKuu.isAlert)
						{
							if (216084 - 355058 != -138973)
							{
								this.AI_idle(3f, 1f);
								if (174585 - 36337 != 138249)
								{
									this.AI_patrol(1f, 0.25f);
									if (288231 - 427120 != -138888)
									{
										this.AI_resetTimer();
										if (75057 - 65949 == 9108)
										{
											this.AI_visionCheck();
											if (131062 - 175600 != -44537)
											{
												if (!this.A97QKiBKuu.myAttackTarget)
												{
													break;
												}
												if (219446 - 253252 != -33805)
												{
													this.A97QKiBKuu.isAlert = true;
													if (6272 - 394696 != -388423)
													{
														this.io6enITlyy = Time.time;
														if (196450 - 263104 == -66654)
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
							if (35140 - 382672 == -347532)
							{
								this.AI_idle(2f, 1f);
								if (119271 - 361236 == -241965)
								{
									this.AI_attack(6f, (float)0);
									if (297 - 219071 != -218773)
									{
										this.AI_resetTimer();
										if (152040 - 316039 == -163999)
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
					if (this.A97QKiBKuu.actionState != "standby")
					{
						if (173275 - 597196 == -423920)
						{
							continue;
						}
						if (this.A97QKiBKuu.actionState != "run")
						{
							if (31356 - 254928 != -223572)
							{
								continue;
							}
							break;
						}
					}
					float num = this.A97QKiBKuu.moveSpeed;
					if (11899 - 73227 == -61328)
					{
						float runSpeed = this.A97QKiBKuu.runSpeed;
						if (239759 - 588823 != -349063)
						{
							Vector3 vector = default(Vector3);
							if (182485 - 351270 != -168784)
							{
								Vector3 vector2 = Vector3.zero;
								if (146795 - 80390 == 66405)
								{
									if ((this.A97QKiBKuu.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (62598 - 244269 != -181671)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.A97QKiBKuu.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (71856 - 222858 == -151001)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (131339 - 465977 != -334638)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (179024 - 273007 == -93982)
											{
												continue;
											}
											num = (float)0;
											if (290992 - 162297 == 128696)
											{
												continue;
											}
											this.transform.position = this.A97QKiBKuu.nPosition;
											if (42046 - 210436 != -168390)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (158469 - 404235 != -245766)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (162877 - 517577 != -354700)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (262129 - 441634 != -179505)
											{
												continue;
											}
											this.animation.CrossFade("run", (float)1);
											if (61508 - 342564 != -281056)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (294617 - 98795 == 195823)
											{
												continue;
											}
											if (!this.audio.isPlaying)
											{
												if (208205 - 25909 != 182296)
												{
													continue;
												}
												this.audio.Play();
												if (162706 - 231033 == -68326)
												{
													continue;
												}
											}
											if (this.fQHec6HysM)
											{
												if (26559 - 75189 == -48629)
												{
													continue;
												}
												this.fQHec6HysM.emit = true;
												if (51995 - 252892 != -200897)
												{
													continue;
												}
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (80263 - 366601 != -286338)
											{
												continue;
											}
											this.animation.CrossFade("root", (float)1);
											if (69429 - 339130 != -269701)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (284416 - 116746 == 167671)
											{
												continue;
											}
											if (this.audio.isPlaying)
											{
												if (131764 - 67807 == 63958)
												{
													continue;
												}
												this.audio.Stop();
												if (82538 - 425303 == -342764)
												{
													continue;
												}
											}
											if (this.fQHec6HysM)
											{
												if (151008 - 413839 != -262831)
												{
													continue;
												}
												this.fQHec6HysM.emit = false;
												if (69996 - 212854 != -142858)
												{
													continue;
												}
											}
										}
									}
									this.A97QKiBKuu.vMovement = vector2;
									if (48785 - 475274 != -426488)
									{
										this.A97QKiBKuu.moveSpeed = num;
										if (178789 - 438972 != -260182)
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

	// Token: 0x06000A90 RID: 2704 RVA: 0x0010EE84 File Offset: 0x0010D084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (127431 - 322747 != -195315)
		{
		}
		do
		{
			if (Time.time - this.io6enITlyy >= this.QpDeQgIQS8)
			{
				if (294386 - 290190 != 4196)
				{
					continue;
				}
				if (Time.time - this.io6enITlyy < this.QpDeQgIQS8 + mTime)
				{
					if (242859 - 363874 == -121014)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (230162 - 529247 == -299084)
						{
							continue;
						}
						this.AI_state = "idle";
						if (175772 - 261753 == -85980)
						{
							continue;
						}
						this.io6enITlyy -= UnityEngine.Random.Range((float)0, rTimer);
						if (40309 - 168516 != -128207)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection = Vector3.zero;
						if (208239 - 442072 == -233832)
						{
							continue;
						}
						this.A97QKiBKuu.vMovement = this.transform.forward;
						if (156055 - 377042 != -220987)
						{
							continue;
						}
						this.A97QKiBKuu.actionState = "standby";
						if (119645 - 423663 != -304018)
						{
							continue;
						}
					}
					this.A97QKiBKuu.moveSpeed = Mathf.Lerp(this.A97QKiBKuu.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (290703 - 209699 != 81004)
					{
						continue;
					}
					if (this.A97QKiBKuu.moveSpeed < 0.1f * this.A97QKiBKuu.runSpeed)
					{
						if (20297 - 228684 != -208387)
						{
							continue;
						}
						this.animation.CrossFade("root", (float)1);
						if (47424 - 398371 != -350947)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (87418 - 384331 == -296912)
						{
							continue;
						}
						this.A97QKiBKuu.moveSpeed = (float)0;
						if (69535 - 427794 != -358259)
						{
							continue;
						}
					}
				}
			}
			this.QpDeQgIQS8 += mTime;
		}
		while (30047 - 343723 != -313676);
	}

	// Token: 0x06000A91 RID: 2705 RVA: 0x0010F144 File Offset: 0x0010D344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (68955 - 271132 != -202177)
		{
		}
		do
		{
			if (Time.time - this.io6enITlyy >= this.QpDeQgIQS8)
			{
				if (81342 - 459181 == -377838)
				{
					continue;
				}
				if (Time.time - this.io6enITlyy < this.QpDeQgIQS8 + mTime)
				{
					if (65048 - 148932 != -83884)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (293272 - 455562 != -162290)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (22428 - 589570 != -567142)
						{
							continue;
						}
						this.io6enITlyy -= UnityEngine.Random.Range((float)0, rTimer);
						if (235996 - 465745 != -229749)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection = this.A97QKiBKuu.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (104165 - 300056 == -195890)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection.y = this.transform.position.y;
						if (130259 - 103431 != 26828)
						{
							continue;
						}
						this.A97QKiBKuu.vMovement = (this.A97QKiBKuu.vDirection - this.transform.position).normalized;
						if (244129 - 307976 != -63847)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.A97QKiBKuu.vMovement);
						if (260462 - 360394 != -99932)
						{
							continue;
						}
						this.A97QKiBKuu.actionState = "run";
						if (277036 - 87264 == 189773)
						{
							continue;
						}
						this.animation.CrossFade("run", (float)1);
						if (157121 - 203412 != -46291)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (181387 - 300517 != -119130)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (202878 - 270613 != -67735)
							{
								continue;
							}
							this.audio.Play();
							if (290684 - 409919 == -119234)
							{
								continue;
							}
						}
						if (this.fQHec6HysM)
						{
							if (109641 - 479223 == -369581)
							{
								continue;
							}
							this.fQHec6HysM.emit = true;
							if (183105 - 437015 == -253909)
							{
								continue;
							}
						}
					}
					this.A97QKiBKuu.moveSpeed = Mathf.Lerp(this.A97QKiBKuu.moveSpeed, this.A97QKiBKuu.runSpeed, (float)4 * Time.deltaTime);
					if (141426 - 61694 != 79732)
					{
						continue;
					}
				}
			}
			this.QpDeQgIQS8 += mTime;
		}
		while (200393 - 401045 == -200651);
	}

	// Token: 0x06000A92 RID: 2706 RVA: 0x0010F4EC File Offset: 0x0010D6EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (141231 - 551082 != -409851)
		{
		}
		do
		{
			if (Time.time - this.io6enITlyy >= this.QpDeQgIQS8)
			{
				if (169563 - 474905 == -305341)
				{
					continue;
				}
				if (Time.time - this.io6enITlyy < this.QpDeQgIQS8 + mTime)
				{
					if (107682 - 168052 == -60369)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (21360 - 199295 != -177935)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (118564 - 385026 != -266462)
						{
							continue;
						}
						this.io6enITlyy = Time.time - mTime - this.QpDeQgIQS8;
						if (270625 - 539078 != -268453)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection = Vector3.zero;
						if (215121 - 97550 == 117572)
						{
							continue;
						}
						this.A97QKiBKuu.vMovement = this.transform.forward;
						if (23849 - 106952 != -83103)
						{
							continue;
						}
						this.A97QKiBKuu.actionState = "standby";
						if (252354 - 46251 != 206103)
						{
							continue;
						}
						this.A97QKiBKuu.myAttackTarget = this.A97QKiBKuu.getHateTarget(5, 40);
						if (124867 - 956 == 123912)
						{
							continue;
						}
						if (!this.A97QKiBKuu.myAttackTarget)
						{
							if (88720 - 181266 != -92546)
							{
								continue;
							}
							this.A97QKiBKuu.isAlert = false;
							if (241426 - 108329 == 133098)
							{
								continue;
							}
							this.io6enITlyy = Time.time;
							if (71494 - 489508 != -418014)
							{
								continue;
							}
							this.A97QKiBKuu.myAttackTarget = null;
							if (8272 - 102577 == -94304)
							{
								continue;
							}
							this.A97QKiBKuu.mOriginalPosition = this.transform.position;
							if (198960 - 502198 != -303237)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.A97QKiBKuu.myAttackTarget;
							if (16283 - 359095 != -342812)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (258922 - 588820 == -329897)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (100233 - 61096 != 39137)
								{
									continue;
								}
								this.A97QKiBKuu.isAlert = false;
								if (73411 - 94758 == -21346)
								{
									continue;
								}
								this.io6enITlyy = Time.time;
								if (287907 - 529960 != -242053)
								{
									continue;
								}
								this.A97QKiBKuu.myAttackTarget = null;
								if (272663 - 260027 != 12636)
								{
									continue;
								}
							}
							else
							{
								this.A97QKiBKuu.vDirection = myAttackTarget.transform.position;
								if (266850 - 246317 == 20534)
								{
									continue;
								}
								this.A97QKiBKuu.vDirection.y = this.transform.position.y;
								if (191673 - 567197 != -375524)
								{
									continue;
								}
								this.A97QKiBKuu.vMovement = (this.A97QKiBKuu.vDirection - this.transform.position).normalized;
								if (273141 - 126625 == 146517)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.A97QKiBKuu.vMovement);
								if (34832 - 187692 != -152860)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.QpDeQgIQS8 += mTime;
		}
		while (196216 - 270657 == -74440);
	}

	// Token: 0x06000A93 RID: 2707 RVA: 0x0010F99C File Offset: 0x0010DB9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (13527 - 508914 != -495386)
		{
		}
		do
		{
			if (Time.time - this.io6enITlyy >= this.QpDeQgIQS8)
			{
				if (141471 - 99061 != 42410)
				{
					continue;
				}
				if (Time.time - this.io6enITlyy < this.QpDeQgIQS8 + mTime)
				{
					if (12177 - 439164 != -426987)
					{
						continue;
					}
					if (!this.A97QKiBKuu.myAttackTarget)
					{
						if (74274 - 51697 != 22577)
						{
							continue;
						}
						this.io6enITlyy = Time.time - mTime - this.QpDeQgIQS8;
						if (78708 - 266275 != -187567)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.A97QKiBKuu.myAttackTarget;
						if (11336 - 62055 == -50718)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (9402 - 235731 != -226329)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (212738 - 331720 != -118982)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (69495 - 463209 == -393713)
							{
								continue;
							}
							if (this.A97QKiBKuu.isTimeOut("nAttack") == (float)0)
							{
								if (110240 - 23056 == 87185)
								{
									continue;
								}
								this.io6enITlyy = Time.time - mTime - this.QpDeQgIQS8;
								if (53146 - 525118 != -471972)
								{
									continue;
								}
								this.q2lQz8E3mH.StartCoroutine_Auto(this.q2lQz8E3mH.RPC_screwDive(this.transform.position, vector, 0));
								if (1453 - 530101 != -528647)
								{
									if (PhotonClient.IsInitialized())
									{
										if (152105 - 253677 == -101571)
										{
											continue;
										}
										this.q2lQz8E3mH.ActionEvent("RPC_screwDive", this.transform.position, vector, 0);
										if (214932 - 202068 != 12864)
										{
											continue;
										}
									}
									goto IL_39B;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (40622 - 491580 != -450958)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection = myAttackTarget.transform.position;
						if (7773 - 273825 == -266051)
						{
							continue;
						}
						this.A97QKiBKuu.vDirection.y = this.transform.position.y;
						if (171476 - 313264 == -141787)
						{
							continue;
						}
						this.A97QKiBKuu.vMovement = (this.A97QKiBKuu.vDirection - this.transform.position).normalized;
						if (270136 - 547603 == -277466)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.A97QKiBKuu.vMovement);
						if (75098 - 312509 == -237410)
						{
							continue;
						}
						this.A97QKiBKuu.actionState = "run";
						if (148302 - 345180 == -196877)
						{
							continue;
						}
						this.animation.CrossFade("run", (float)1);
						if (121418 - 263734 != -142316)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (36853 - 362057 != -325204)
						{
							continue;
						}
						if (!this.audio.isPlaying)
						{
							if (214308 - 142394 != 71914)
							{
								continue;
							}
							this.audio.Play();
							if (197958 - 67608 == 130351)
							{
								continue;
							}
						}
						if (this.fQHec6HysM)
						{
							if (49055 - 535089 == -486033)
							{
								continue;
							}
							this.fQHec6HysM.emit = true;
							if (291478 - 118053 == 173426)
							{
								continue;
							}
						}
						this.A97QKiBKuu.moveSpeed = Mathf.Lerp(this.A97QKiBKuu.moveSpeed, this.A97QKiBKuu.runSpeed, (float)4 * Time.deltaTime);
						if (99179 - 297535 != -198356)
						{
							continue;
						}
					}
				}
			}
			IL_39B:
			this.QpDeQgIQS8 += mTime;
		}
		while (289071 - 420325 != -131254);
	}

	// Token: 0x06000A94 RID: 2708 RVA: 0x0010FEF0 File Offset: 0x0010E0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (167600 - 440779 != -273178)
		{
		}
		while (Time.time - this.io6enITlyy > this.QpDeQgIQS8)
		{
			if (65818 - 338757 == -272939)
			{
				this.AI_state = "none";
				if (206682 - 510064 == -303382)
				{
					this.io6enITlyy = Time.time;
					if (299980 - 445136 != -145155)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A95 RID: 2709 RVA: 0x0010FFA4 File Offset: 0x0010E1A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (21651 - 333630 != -311978)
		{
		}
		for (;;)
		{
			IL_DC:
			if (this.aseeefOPTI + (float)1 > Time.time)
			{
				if (60316 - 558668 == -498352)
				{
					break;
				}
			}
			else
			{
				this.aseeefOPTI = Time.time;
				if (159905 - 288582 == -128677)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (218783 - 405995 != -187211)
					{
						if (96737 - 240980 == -144243)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (140907 - 186082 != -45174)
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
									if (37721 - 428496 != -390775)
									{
										goto IL_DC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (260331 - 293541 != -33210)
									{
										goto IL_DC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (73075 - 490705 == -417629)
									{
										goto IL_DC;
									}
									bool flag = true;
									if (83884 - 387771 == -303886)
									{
										goto IL_DC;
									}
									eRace race = this.A97QKiBKuu.Race;
									if (176163 - 278609 != -102446)
									{
										goto IL_DC;
									}
									if (race == eRace.Tails)
									{
										if (95692 - 213057 == -117364)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_17F;
										}
										if (53866 - 145757 != -91891)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (158089 - 42774 != 115316)
											{
												goto IL_17F;
											}
											goto IL_DC;
										}
										goto IL_31B;
										IL_17F:
										flag = false;
										if (238670 - 281148 != -42478)
										{
											goto IL_DC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (45774 - 449824 == -404049)
										{
											goto IL_DC;
										}
										flag = false;
										if (247625 - 322903 == -75277)
										{
											goto IL_DC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (36951 - 435838 == -398886)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7C7;
										}
										if (10390 - 203661 == -193270)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (15502 - 551954 != -536451)
											{
												goto IL_7C7;
											}
											goto IL_DC;
										}
										goto IL_31B;
										IL_7C7:
										flag = false;
										if (92749 - 353530 != -260781)
										{
											goto IL_DC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (189411 - 456379 == -266967)
										{
											goto IL_DC;
										}
										flag = true;
										if (202687 - 16993 != 185694)
										{
											goto IL_DC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (410 - 2878 == -2467)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_70A;
										}
										if (95075 - 365693 == -270617)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_70A;
										}
										if (130056 - 117302 == 12755)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (45977 - 346567 != -300590)
											{
												goto IL_DC;
											}
											goto IL_70A;
										}
										goto IL_31B;
										IL_70A:
										flag = false;
										if (214355 - 183889 != 30466)
										{
											goto IL_DC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (43210 - 461289 == -418078)
										{
											goto IL_DC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (192522 - 294068 == -101545)
											{
												goto IL_DC;
											}
											flag = false;
											if (170934 - 293279 == -122344)
											{
												goto IL_DC;
											}
										}
									}
									IL_31B:
									if (flag)
									{
										if (296983 - 315839 != -18856)
										{
											goto IL_DC;
										}
										if (characterControl.hp > 0)
										{
											if (65790 - 405405 != -339615)
											{
												goto IL_DC;
											}
											if (characterControl.recieveTarget)
											{
												if (55428 - 128099 == -72670)
												{
													goto IL_DC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (207392 - 588172 == -380779)
													{
														goto IL_DC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (144837 - 17947 != 126890)
														{
															goto IL_DC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (16071 - 430620 == -414548)
														{
															goto IL_DC;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (22956 - 397708 != -374752)
															{
																goto IL_DC;
															}
															this.A97QKiBKuu.isAlert = true;
															if (150050 - 84545 != 65505)
															{
																goto IL_DC;
															}
															this.io6enITlyy = Time.time;
															if (145242 - 380549 == -235306)
															{
																goto IL_DC;
															}
															this.A97QKiBKuu.myAttackTarget = gameObject;
															if (155352 - 287670 == -132317)
															{
																goto IL_DC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (55709 - 83140 == -27430)
															{
																goto IL_DC;
															}
															this.A97QKiBKuu.addHate(characterControl.ActorNr, 5);
															if (165559 - 557450 != -391891)
															{
																goto IL_DC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (268655 - 221387 == 47269)
															{
																goto IL_DC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (227625 - 79390 == 148236)
															{
																goto IL_DC;
															}
															if (num < (float)60)
															{
																if (214073 - 358007 != -143934)
																{
																	goto IL_DC;
																}
																if (characterControl.hp > 0)
																{
																	if (236451 - 55534 == 180918)
																	{
																		goto IL_DC;
																	}
																	this.A97QKiBKuu.isAlert = true;
																	if (153058 - 241002 == -87943)
																	{
																		goto IL_DC;
																	}
																	this.io6enITlyy = Time.time;
																	if (141529 - 65188 != 76341)
																	{
																		goto IL_DC;
																	}
																	this.A97QKiBKuu.myAttackTarget = gameObject;
																	if (142715 - 103864 != 38851)
																	{
																		goto IL_DC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (40832 - 71584 != -30752)
																	{
																		goto IL_DC;
																	}
																	this.A97QKiBKuu.addHate(characterControl.ActorNr, 5);
																	if (214145 - 198997 != 15148)
																	{
																		goto IL_DC;
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
								if (217946 - 549978 != -332031)
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

	// Token: 0x06000A96 RID: 2710 RVA: 0x001107CC File Offset: 0x0010E9CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000A97 RID: 2711 RVA: 0x001107D0 File Offset: 0x0010E9D0
	internal static bool iCA9P5HXLs2ThyR5t13()
	{
		return true;
	}

	// Token: 0x06000A98 RID: 2712 RVA: 0x001107D4 File Offset: 0x0010E9D4
	internal static bool qPjqS6HQq27eiU3JkXH()
	{
		return false;
	}

	// Token: 0x0400096B RID: 2411
	private CharacterControl A97QKiBKuu;

	// Token: 0x0400096C RID: 2412
	private SandBug q2lQz8E3mH;

	// Token: 0x0400096D RID: 2413
	private eSandBugType VJ3e580BlY;

	// Token: 0x0400096E RID: 2414
	private ParticleEmitter fQHec6HysM;

	// Token: 0x0400096F RID: 2415
	public string AI_state;

	// Token: 0x04000970 RID: 2416
	private float io6enITlyy;

	// Token: 0x04000971 RID: 2417
	private float QpDeQgIQS8;

	// Token: 0x04000972 RID: 2418
	private float aseeefOPTI;
}
