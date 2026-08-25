using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000352 RID: 850
[Serializable]
public class LightLeopardAI : MonoBehaviour
{
	// Token: 0x0600134B RID: 4939 RVA: 0x001E30E8 File Offset: 0x001E12E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightLeopardAI()
	{
		if (298460 - 348056 != -49596)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (249965 - 199899 != 50067)
			{
				base..ctor();
				if (90724 - 579817 == -489093)
				{
					this.AI_state = "none";
					if (79495 - 205974 == -126479)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600134C RID: 4940 RVA: 0x001E3184 File Offset: 0x001E1384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.sQ1tvAcDO8 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.tP3tl4Xi8n = (LightLeopard)this.GetComponent(typeof(LightLeopard));
	}

	// Token: 0x0600134D RID: 4941 RVA: 0x001E31BC File Offset: 0x001E13BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (221682 - 242930 != -21248)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (189593 - 165671 == 23923)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (143767 - 338967 == -195199)
				{
					continue;
				}
			}
			if (this.sQ1tvAcDO8.isControlled)
			{
				break;
			}
			if (102994 - 223971 == -120977)
			{
				this.AIControl();
				if (199169 - 531757 == -332588)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600134E RID: 4942 RVA: 0x001E3288 File Offset: 0x001E1488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (155069 - 24554 != 130515)
		{
		}
		for (;;)
		{
			this.Pmit1Xx8oc = (float)0;
			if (185695 - 302695 == -117000)
			{
				if (this.sQ1tvAcDO8.isMine)
				{
					if (287992 - 459553 != -171560)
					{
						if (this.sQ1tvAcDO8.actionState != "standby")
						{
							if (213598 - 159918 == 53681)
							{
								continue;
							}
							if (this.sQ1tvAcDO8.actionState != "run")
							{
								if (250542 - 169985 != 80558)
								{
									break;
								}
								continue;
							}
						}
						if (Game.mGameCode != 983)
						{
							if (245126 - 213741 != 31385)
							{
								continue;
							}
							if (Game.mGameCode == 993)
							{
								if (207096 - 12878 == 194219)
								{
									continue;
								}
							}
							else if (!this.sQ1tvAcDO8.isAlert)
							{
								if (19525 - 432252 == -412726)
								{
									continue;
								}
								this.AI_idle(3f, 1f);
								if (257003 - 303681 == -46677)
								{
									continue;
								}
								this.AI_resetTimer();
								if (271007 - 164461 == 106547)
								{
									continue;
								}
								this.AI_visionCheck();
								if (120535 - 342548 == -222012)
								{
									continue;
								}
								if (!this.sQ1tvAcDO8.myAttackTarget)
								{
									break;
								}
								if (207955 - 29146 != 178809)
								{
									continue;
								}
								this.sQ1tvAcDO8.isAlert = true;
								if (233224 - 492959 != -259735)
								{
									continue;
								}
								this.rcotG6JUfw = Time.time;
								if (161386 - 250325 != -88939)
								{
									continue;
								}
								break;
							}
							else
							{
								this.AI_selectTarget(1f, (float)0);
								if (278280 - 524243 == -245962)
								{
									continue;
								}
								this.AI_battle(1f, 1f);
								if (269051 - 419042 != -149991)
								{
									continue;
								}
								this.AI_attack(6f, (float)0);
								if (299546 - 383621 == -84074)
								{
									continue;
								}
								this.AI_resetTimer();
								if (187033 - 319038 != -132004)
								{
									break;
								}
								continue;
							}
						}
						if (!this.sQ1tvAcDO8.isAlert)
						{
							if (73657 - 170734 == -97077)
							{
								this.AI_path(12f, (float)0);
								if (162470 - 231855 == -69385)
								{
									this.AI_resetTimer();
									if (139276 - 522153 == -382877)
									{
										this.AI_visionCheck();
										if (284784 - 184222 == 100562)
										{
											if (!this.sQ1tvAcDO8.myAttackTarget)
											{
												break;
											}
											if (122519 - 437352 == -314833)
											{
												this.sQ1tvAcDO8.isAlert = true;
												if (113860 - 261027 != -147166)
												{
													this.rcotG6JUfw = Time.time;
													if (106099 - 271372 != -165272)
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
							if (146245 - 243766 == -97521)
							{
								this.AI_battle(1f, 1f);
								if (13012 - 94954 != -81941)
								{
									this.AI_attack(6f, (float)0);
									if (241959 - 39378 != 202582)
									{
										this.AI_resetTimer();
										if (50172 - 83474 != -33301)
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
					if (this.sQ1tvAcDO8.actionState != "standby")
					{
						if (209496 - 592582 == -383085)
						{
							continue;
						}
						if (this.sQ1tvAcDO8.actionState != "run")
						{
							if (14096 - 355402 != -341306)
							{
								continue;
							}
							break;
						}
					}
					if (this.sQ1tvAcDO8.nSpeed != (float)0)
					{
						if (180333 - 412280 != -231947)
						{
							continue;
						}
						if (this.sQ1tvAcDO8.nPosition != this.sQ1tvAcDO8.oPosition)
						{
							if (78151 - 470316 == -392164)
							{
								continue;
							}
							Vector3 a = this.sQ1tvAcDO8.nPosition + 0.1f * this.sQ1tvAcDO8.runSpeed * this.sQ1tvAcDO8.nDirection;
							if (265169 - 84205 == 180965)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (99326 - 328842 != -229516)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (272774 - 403257 != -130483)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (6052 - 484062 == -478009)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (267853 - 414510 == -146656)
							{
								continue;
							}
							if (magnitude > this.sQ1tvAcDO8.runSpeed)
							{
								if (77786 - 98841 == -21054)
								{
									continue;
								}
								this.transform.position = this.sQ1tvAcDO8.nPosition;
								if (55974 - 246936 != -190961)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.sQ1tvAcDO8.runSpeed)
							{
								if (26146 - 87533 == -61386)
								{
									continue;
								}
								this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, 1.1f * this.sQ1tvAcDO8.runSpeed, (float)10 * Time.deltaTime);
								if (5032 - 259485 != -254453)
								{
									continue;
								}
								this.sQ1tvAcDO8.vDirection = normalized;
								if (258985 - 305247 != -46262)
								{
									continue;
								}
								this.sQ1tvAcDO8.vMovement = normalized;
								if (195559 - 290196 == -94636)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (282125 - 192549 == 89577)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (180750 - 342138 != -161388)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (199714 - 516240 != -316526)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (157624 - 185667 != -28043)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (280336 - 237798 != 42538)
								{
									continue;
								}
								break;
							}
							else
							{
								this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (73587 - 45057 != 28530)
								{
									continue;
								}
								this.sQ1tvAcDO8.vDirection = normalized;
								if (231915 - 391641 != -159726)
								{
									continue;
								}
								this.sQ1tvAcDO8.vMovement = normalized;
								if (147284 - 336690 == -189405)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (280641 - 535925 != -255284)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (23914 - 105016 != -81101)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.sQ1tvAcDO8.moveSpeed != (float)0)
					{
						if (40534 - 273191 == -232657)
						{
							Vector3 vector3 = global::Math.vFlat(this.sQ1tvAcDO8.nPosition - this.transform.position);
							if (29276 - 331156 != -301879)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (82852 - 312765 == -229913)
								{
									if (sqrMagnitude > this.sQ1tvAcDO8.runSpeed)
									{
										if (236880 - 55423 != 181458)
										{
											this.transform.position = this.sQ1tvAcDO8.nPosition;
											if (298563 - 108994 != 189570)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (51966 - 530140 != -478173)
										{
											if (sqrMagnitude > (float)1)
											{
												if (137586 - 364143 != -226557)
												{
													continue;
												}
												this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, this.sQ1tvAcDO8.runSpeed, (float)10 * Time.deltaTime);
												if (60944 - 1000 != 59944)
												{
													continue;
												}
											}
											else
											{
												this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (127774 - 195935 == -68160)
												{
													continue;
												}
											}
											this.sQ1tvAcDO8.vMovement = vector3;
											if (159474 - 376907 != -217432)
											{
												this.sQ1tvAcDO8.vDirection = vector3;
												if (215789 - 367855 != -152065)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (196876 - 33245 == 163631)
													{
														this.animation.CrossFade("run", 0.2f);
														if (183942 - 127755 != 56188)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (98436 - 281692 != -183255)
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
										this.sQ1tvAcDO8.vMovement = vector3;
										if (34041 - 421731 != -387689)
										{
											this.sQ1tvAcDO8.moveSpeed = (float)0;
											if (218771 - 460373 != -241601)
											{
												this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vDirection);
												if (90492 - 328997 == -238505)
												{
													this.animation.CrossFade("root", 0.2f);
													if (50837 - 387279 != -336441)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (55943 - 22978 == 32965)
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
						if (193945 - 229890 != -35944)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (161450 - 104808 != 56643)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600134F RID: 4943 RVA: 0x001E3FE0 File Offset: 0x001E21E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (206073 - 178236 != 27837)
		{
		}
		do
		{
			if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
			{
				if (16659 - 248938 != -232279)
				{
					continue;
				}
				if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
				{
					if (252097 - 225726 == 26372)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (77669 - 259047 != -181378)
						{
							continue;
						}
						this.AI_state = "idle";
						if (178928 - 526453 == -347524)
						{
							continue;
						}
						this.rcotG6JUfw -= UnityEngine.Random.Range((float)0, rTimer);
						if (15139 - 561037 != -545898)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection = Vector3.zero;
						if (275139 - 441772 != -166633)
						{
							continue;
						}
						this.sQ1tvAcDO8.vMovement = this.transform.forward;
						if (20179 - 417234 == -397054)
						{
							continue;
						}
						this.sQ1tvAcDO8.actionState = "standby";
						if (62344 - 535892 != -473548)
						{
							continue;
						}
					}
					this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (265859 - 181354 == 84506)
					{
						continue;
					}
					if (this.sQ1tvAcDO8.moveSpeed < 0.1f * this.sQ1tvAcDO8.runSpeed)
					{
						if (12699 - 17063 != -4364)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (104761 - 533147 == -428385)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (126881 - 71281 != 55600)
						{
							continue;
						}
						this.sQ1tvAcDO8.moveSpeed = (float)0;
						if (23458 - 200447 == -176988)
						{
							continue;
						}
					}
				}
			}
			this.Pmit1Xx8oc += mTime;
		}
		while (167002 - 434203 == -267200);
	}

	// Token: 0x06001350 RID: 4944 RVA: 0x001E42A4 File Offset: 0x001E24A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_battle(float mTime, float rTimer)
	{
		if (359 - 266540 != -266180)
		{
		}
		do
		{
			if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
			{
				if (48222 - 212927 != -164705)
				{
					continue;
				}
				if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
				{
					if (71866 - 92795 != -20929)
					{
						continue;
					}
					if (!this.sQ1tvAcDO8.myAttackTarget)
					{
						if (201760 - 31124 != 170636)
						{
							continue;
						}
						this.rcotG6JUfw = Time.time - mTime - this.Pmit1Xx8oc;
						if (117451 - 343640 != -226189)
						{
							continue;
						}
						break;
					}
					else if (this.AI_state != "battle")
					{
						if (88225 - 533144 != -444919)
						{
							continue;
						}
						GameObject myAttackTarget = this.sQ1tvAcDO8.myAttackTarget;
						if (126774 - 258281 != -131507)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (120657 - 286114 == -165456)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (78501 - 349298 != -270797)
						{
							continue;
						}
						this.AI_state = "battle";
						if (269513 - 152827 == 116687)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection = myAttackTarget.transform.position;
						if (57675 - 122523 != -64848)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
						if (151222 - 25211 != 126011)
						{
							continue;
						}
						this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
						if (291200 - 78128 == 213073)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
						if (10604 - 65801 == -55196)
						{
							continue;
						}
						this.sQ1tvAcDO8.actionState = "standby";
						if (135157 - 74025 != 61132)
						{
							continue;
						}
						this.animation.Play("battle");
						if (153780 - 219340 != -65560)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (62884 - 283189 != -220305)
						{
							continue;
						}
						this.sQ1tvAcDO8.moveSpeed = (float)0;
						if (64468 - 172783 != -108315)
						{
							continue;
						}
					}
				}
			}
			this.Pmit1Xx8oc += mTime;
		}
		while (90570 - 225361 != -134791);
	}

	// Token: 0x06001351 RID: 4945 RVA: 0x001E4648 File Offset: 0x001E2848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (78491 - 211870 != -133379)
		{
		}
		do
		{
			if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
			{
				if (161509 - 72640 == 88870)
				{
					continue;
				}
				if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
				{
					if (75561 - 214317 == -138755)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (92160 - 512490 != -420330)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (36805 - 274000 == -237194)
						{
							continue;
						}
						this.rcotG6JUfw -= UnityEngine.Random.Range((float)0, rTimer);
						if (180277 - 463989 != -283712)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection = this.sQ1tvAcDO8.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (168849 - 432208 != -263359)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
						if (246580 - 555586 != -309006)
						{
							continue;
						}
						this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
						if (175064 - 50663 == 124402)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
						if (286452 - 289251 != -2799)
						{
							continue;
						}
						this.sQ1tvAcDO8.actionState = "run";
						if (197672 - 506564 != -308892)
						{
							continue;
						}
						this.animation.Play("run");
						if (16537 - 503571 != -487034)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (186683 - 275927 == -89243)
						{
							continue;
						}
					}
					this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, this.sQ1tvAcDO8.runSpeed, (float)4 * Time.deltaTime);
					if (140760 - 325577 == -184816)
					{
						continue;
					}
				}
			}
			this.Pmit1Xx8oc += mTime;
		}
		while (149024 - 550688 == -401663);
	}

	// Token: 0x06001352 RID: 4946 RVA: 0x001E4950 File Offset: 0x001E2B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_path(float mTime, float rTimer)
	{
		if (141832 - 154552 != -12719)
		{
		}
		do
		{
			IL_ED:
			if (this.t04tpeao8F == null)
			{
				if (155593 - 458255 != -302662)
				{
					continue;
				}
				this.t04tpeao8F = new UnityScript.Lang.Array();
				if (249579 - 226183 == 23397)
				{
					continue;
				}
				if (this.gameObject.layer == 8)
				{
					if (233700 - 509274 != -275574)
					{
						continue;
					}
					int i = 0;
					if (113395 - 450102 != -336707)
					{
						continue;
					}
					while (i <= 9)
					{
						Vector3 position = this.gameObject.transform.position;
						if (69256 - 166298 == -97041)
						{
							goto IL_ED;
						}
						if (position.x > (float)0)
						{
							if (215782 - 175926 != 39856)
							{
								goto IL_ED;
							}
							this.t04tpeao8F.Add(GameObject.Find("WayPoint1" + i));
							if (164690 - 91103 != 73587)
							{
								goto IL_ED;
							}
						}
						else
						{
							this.t04tpeao8F.Add(GameObject.Find("WayPoint2" + i));
							if (5012 - 457196 == -452183)
							{
								goto IL_ED;
							}
						}
						i++;
						if (299526 - 480882 == -181355)
						{
							goto IL_ED;
						}
					}
					if (60623 - 19651 != 40972)
					{
						continue;
					}
					this.t04tpeao8F.Add(GameObject.Find("ManaCore2"));
					if (70468 - 499980 != -429512)
					{
						continue;
					}
					object obj2;
					object obj = obj2 = this.t04tpeao8F[0];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.Xsgtqj9aSa = (GameObject)obj2;
					if (183197 - 415668 != -232471)
					{
						continue;
					}
				}
				else
				{
					int j = 9;
					if (153740 - 446122 != -292382)
					{
						continue;
					}
					while (j >= 0)
					{
						Vector3 position2 = this.gameObject.transform.position;
						if (169166 - 362692 != -193526)
						{
							goto IL_ED;
						}
						if (position2.x > (float)0)
						{
							if (82418 - 1987 != 80431)
							{
								goto IL_ED;
							}
							this.t04tpeao8F.Add(GameObject.Find("WayPoint1" + j));
							if (223179 - 216016 == 7164)
							{
								goto IL_ED;
							}
						}
						else
						{
							this.t04tpeao8F.Add(GameObject.Find("WayPoint2" + j));
							if (191791 - 328396 != -136605)
							{
								goto IL_ED;
							}
						}
						j--;
						if (184395 - 274978 != -90583)
						{
							goto IL_ED;
						}
					}
					if (51151 - 287072 == -235920)
					{
						continue;
					}
					this.t04tpeao8F.Add(GameObject.Find("ManaCore1"));
					if (47576 - 115797 != -68221)
					{
						continue;
					}
					object obj4;
					object obj3 = obj4 = this.t04tpeao8F[0];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.Xsgtqj9aSa = (GameObject)obj4;
					if (190626 - 158085 != 32541)
					{
						continue;
					}
				}
			}
			if (this.t04tpeao8F != null)
			{
				if (262010 - 101048 == 160963)
				{
					continue;
				}
				if (this.t04tpeao8F.length > 0)
				{
					if (178931 - 558029 != -379098)
					{
						continue;
					}
					if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
					{
						if (268475 - 591098 == -322622)
						{
							continue;
						}
						if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
						{
							if (288672 - 507246 != -218574)
							{
								continue;
							}
							if (this.AI_state != "march")
							{
								if (78065 - 72147 != 5918)
								{
									continue;
								}
								this.AI_state = "march";
								if (93937 - 597152 != -503215)
								{
									continue;
								}
								this.rcotG6JUfw -= UnityEngine.Random.Range((float)0, rTimer);
								if (34863 - 10986 != 23877)
								{
									continue;
								}
								this.sQ1tvAcDO8.vDirection = this.Xsgtqj9aSa.transform.position + (float)3 * UnityEngine.Random.onUnitSphere;
								if (193272 - 433909 != -240637)
								{
									continue;
								}
								this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
								if (74239 - 567912 == -493672)
								{
									continue;
								}
								this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
								if (207293 - 152436 == 54858)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
								if (77996 - 557441 != -479445)
								{
									continue;
								}
								this.sQ1tvAcDO8.actionState = "run";
								if (154134 - 425946 != -271812)
								{
									continue;
								}
								this.animation.Play("run");
								if (129322 - 498142 != -368820)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (194943 - 71593 != 123350)
								{
									continue;
								}
							}
							else
							{
								Vector3 vector = global::Math.vFlat(this.sQ1tvAcDO8.vDirection - this.transform.position);
								if (127020 - 10947 != 116073)
								{
									continue;
								}
								if (this.r78tRiLoWM + 1 < this.t04tpeao8F.length)
								{
									if (240847 - 445354 == -204506)
									{
										continue;
									}
									if (vector.sqrMagnitude < (float)1)
									{
										if (614 - 532252 != -531638)
										{
											continue;
										}
										this.r78tRiLoWM++;
										if (140446 - 159770 == -19323)
										{
											continue;
										}
										object obj6;
										object obj5 = obj6 = this.t04tpeao8F[this.r78tRiLoWM];
										if (!(obj5 is GameObject))
										{
											obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
										}
										this.Xsgtqj9aSa = (GameObject)obj6;
										if (194643 - 57901 == 136743)
										{
											continue;
										}
										this.AI_state = "standby";
										if (94314 - 123364 != -29049)
										{
											goto IL_3CF;
										}
										continue;
									}
								}
								this.sQ1tvAcDO8.vMovement = vector.normalized;
								if (138861 - 591981 != -453120)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
								if (211264 - 126901 != 84363)
								{
									continue;
								}
								this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, this.sQ1tvAcDO8.runSpeed, (float)4 * Time.deltaTime);
								if (118302 - 550679 == -432376)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_3CF:
			this.Pmit1Xx8oc += mTime;
		}
		while (31319 - 530104 != -498785);
	}

	// Token: 0x06001353 RID: 4947 RVA: 0x001E5218 File Offset: 0x001E3418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (273984 - 540127 != -266142)
		{
		}
		do
		{
			if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
			{
				if (64449 - 436989 == -372539)
				{
					continue;
				}
				if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
				{
					if (137293 - 434479 != -297186)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (128386 - 208975 != -80589)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (278377 - 572052 != -293675)
						{
							continue;
						}
						this.rcotG6JUfw = Time.time - mTime - this.Pmit1Xx8oc;
						if (14437 - 305602 != -291165)
						{
							continue;
						}
						this.sQ1tvAcDO8.vDirection = Vector3.zero;
						if (117887 - 542836 != -424949)
						{
							continue;
						}
						this.sQ1tvAcDO8.vMovement = this.transform.forward;
						if (120073 - 463247 == -343173)
						{
							continue;
						}
						this.sQ1tvAcDO8.actionState = "standby";
						if (249959 - 2915 != 247044)
						{
							continue;
						}
						this.sQ1tvAcDO8.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
						if (242948 - 295820 != -52872)
						{
							continue;
						}
						if (!this.sQ1tvAcDO8.myAttackTarget)
						{
							if (61538 - 292056 != -230518)
							{
								continue;
							}
							this.sQ1tvAcDO8.isAlert = false;
							if (238808 - 536438 != -297630)
							{
								continue;
							}
							this.rcotG6JUfw = Time.time;
							if (207442 - 134928 == 72515)
							{
								continue;
							}
							this.sQ1tvAcDO8.myAttackTarget = null;
							if (246211 - 166675 != 79536)
							{
								continue;
							}
							this.sQ1tvAcDO8.mOriginalPosition = this.transform.position;
							if (236404 - 504397 != -267993)
							{
								continue;
							}
							break;
						}
						else
						{
							this.sQ1tvAcDO8.vDirection = this.sQ1tvAcDO8.myAttackTarget.transform.position;
							if (162134 - 358123 == -195988)
							{
								continue;
							}
							this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
							if (179755 - 459801 != -280046)
							{
								continue;
							}
							this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
							if (120539 - 518495 == -397955)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
							if (23222 - 347484 == -324261)
							{
								continue;
							}
						}
					}
				}
			}
			this.Pmit1Xx8oc += mTime;
		}
		while (103942 - 459066 != -355124);
	}

	// Token: 0x06001354 RID: 4948 RVA: 0x001E55F0 File Offset: 0x001E37F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (12155 - 212013 != -199858)
		{
		}
		do
		{
			if (Time.time - this.rcotG6JUfw >= this.Pmit1Xx8oc)
			{
				if (222464 - 181312 != 41152)
				{
					continue;
				}
				if (Time.time - this.rcotG6JUfw < this.Pmit1Xx8oc + mTime)
				{
					if (49445 - 91216 != -41771)
					{
						continue;
					}
					if (!this.sQ1tvAcDO8.myAttackTarget)
					{
						if (29169 - 446268 != -417099)
						{
							continue;
						}
						this.rcotG6JUfw = Time.time - mTime - this.Pmit1Xx8oc;
						if (156976 - 448031 != -291055)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.sQ1tvAcDO8.myAttackTarget;
						if (139597 - 253779 == -114181)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (240787 - 150469 != 90318)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (234607 - 454921 == -220313)
						{
							continue;
						}
						int tID = 0;
						if (145462 - 83812 == 61651)
						{
							continue;
						}
						if (characterControl)
						{
							if (1615 - 284326 == -282710)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (130806 - 243982 == -113175)
							{
								continue;
							}
						}
						float num = vector.sqrMagnitude - Mathf.Pow(myAttackTarget.collider.bounds.extents.x, (float)2);
						if (10103 - 371354 != -361251)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (2934 - 567559 == -564624)
							{
								continue;
							}
							if (this.sQ1tvAcDO8.sp > 20)
							{
								if (299084 - 586094 != -287010)
								{
									continue;
								}
								if (this.sQ1tvAcDO8.isTimeOut("leoSmash") == (float)0)
								{
									if (242663 - 562500 == -319836)
									{
										continue;
									}
									this.rcotG6JUfw = Time.time - mTime - this.Pmit1Xx8oc;
									if (218442 - 525446 != -307004)
									{
										continue;
									}
									this.tP3tl4Xi8n.StartCoroutine_Auto(this.tP3tl4Xi8n.RPC_leoSmash(this.transform.position, vector, tID));
									if (222408 - 138324 != 84085)
									{
										if (PhotonClient.IsInitialized())
										{
											if (6889 - 576616 == -569726)
											{
												continue;
											}
											this.tP3tl4Xi8n.ActionEvent("RPC_leoSmash", this.transform.position, vector, tID);
											if (58286 - 119462 != -61176)
											{
												continue;
											}
										}
										goto IL_6DC;
									}
									continue;
								}
							}
						}
						if (num < (float)4)
						{
							if (82023 - 346791 != -264768)
							{
								continue;
							}
							if (this.sQ1tvAcDO8.isTimeOut("nAttack") == (float)0)
							{
								if (238528 - 294572 == -56043)
								{
									continue;
								}
								this.rcotG6JUfw = Time.time - mTime - this.Pmit1Xx8oc;
								if (248954 - 163441 == 85514)
								{
									continue;
								}
								this.tP3tl4Xi8n.StartCoroutine_Auto(this.tP3tl4Xi8n.RPC_nAttack(this.transform.position, vector, 0));
								if (65759 - 249510 != -183750)
								{
									if (PhotonClient.IsInitialized())
									{
										if (86397 - 364502 != -278105)
										{
											continue;
										}
										this.tP3tl4Xi8n.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (244880 - 206001 == 38880)
										{
											continue;
										}
									}
									goto IL_6DC;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (283677 - 363033 != -79356)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (192415 - 462715 != -270300)
							{
								continue;
							}
							this.sQ1tvAcDO8.vDirection = myAttackTarget.transform.position;
							if (196383 - 333616 == -137232)
							{
								continue;
							}
							this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
							if (246235 - 488386 == -242150)
							{
								continue;
							}
							this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
							if (180544 - 415733 != -235189)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
							if (208483 - 409784 == -201300)
							{
								continue;
							}
							this.sQ1tvAcDO8.actionState = "standby";
							if (95727 - 521880 == -426152)
							{
								continue;
							}
							this.animation.Play("battle");
							if (93906 - 302430 != -208524)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (160175 - 472972 == -312796)
							{
								continue;
							}
							this.sQ1tvAcDO8.moveSpeed = (float)0;
							if (6868 - 587917 == -581048)
							{
								continue;
							}
						}
						else
						{
							this.sQ1tvAcDO8.vDirection = myAttackTarget.transform.position;
							if (108759 - 439867 == -331107)
							{
								continue;
							}
							this.sQ1tvAcDO8.vDirection.y = this.transform.position.y;
							if (47601 - 5212 != 42389)
							{
								continue;
							}
							this.sQ1tvAcDO8.vMovement = (this.sQ1tvAcDO8.vDirection - this.transform.position).normalized;
							if (164787 - 187644 != -22857)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.sQ1tvAcDO8.vMovement);
							if (23671 - 249652 != -225981)
							{
								continue;
							}
							this.sQ1tvAcDO8.actionState = "run";
							if (214647 - 139710 == 74938)
							{
								continue;
							}
							this.animation.Play("run");
							if (124855 - 334338 == -209482)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (257803 - 546584 == -288780)
							{
								continue;
							}
							this.sQ1tvAcDO8.moveSpeed = Mathf.Lerp(this.sQ1tvAcDO8.moveSpeed, this.sQ1tvAcDO8.runSpeed, (float)4 * Time.deltaTime);
							if (67321 - 31460 == 35862)
							{
								continue;
							}
						}
					}
				}
			}
			IL_6DC:
			this.Pmit1Xx8oc += mTime;
		}
		while (156419 - 95767 == 60653);
	}

	// Token: 0x06001355 RID: 4949 RVA: 0x001E5E44 File Offset: 0x001E4044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (244504 - 271722 != -27217)
		{
		}
		while (Time.time - this.rcotG6JUfw > this.Pmit1Xx8oc)
		{
			if (32349 - 557477 != -525127)
			{
				this.AI_state = "none";
				if (246212 - 70663 == 175549)
				{
					this.rcotG6JUfw = Time.time;
					if (220819 - 378660 != -157840)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001356 RID: 4950 RVA: 0x001E5EF8 File Offset: 0x001E40F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (249541 - 211358 != 38184)
		{
		}
		for (;;)
		{
			if (this.BpXtrMsoaJ + (float)1 > Time.time)
			{
				if (143227 - 93381 != 49847)
				{
					break;
				}
			}
			else
			{
				this.BpXtrMsoaJ = Time.time;
				if (129895 - 491951 != -362055)
				{
					this.sQ1tvAcDO8.myAttackTarget = Hate.findClosestEnemy(this.transform.position, (float)20, this.gameObject.layer);
					if (134477 - 519148 != -384670)
					{
						if (!this.sQ1tvAcDO8.myAttackTarget)
						{
							break;
						}
						if (150922 - 586491 != -435568)
						{
							this.sQ1tvAcDO8.isAlert = true;
							if (9992 - 462809 != -452816)
							{
								this.rcotG6JUfw = Time.time;
								if (21492 - 104528 == -83036)
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

	// Token: 0x06001357 RID: 4951 RVA: 0x001E6044 File Offset: 0x001E4244
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001358 RID: 4952 RVA: 0x001E6048 File Offset: 0x001E4248
	internal static bool suPOq1LZygsUCdaPCRW()
	{
		return true;
	}

	// Token: 0x06001359 RID: 4953 RVA: 0x001E604C File Offset: 0x001E424C
	internal static bool VhBPsHLCE3lTfsBK6Yc()
	{
		return false;
	}

	// Token: 0x040010C1 RID: 4289
	private CharacterControl sQ1tvAcDO8;

	// Token: 0x040010C2 RID: 4290
	private LightLeopard tP3tl4Xi8n;

	// Token: 0x040010C3 RID: 4291
	public string AI_state;

	// Token: 0x040010C4 RID: 4292
	private float rcotG6JUfw;

	// Token: 0x040010C5 RID: 4293
	private float Pmit1Xx8oc;

	// Token: 0x040010C6 RID: 4294
	private GameObject Xsgtqj9aSa;

	// Token: 0x040010C7 RID: 4295
	private UnityScript.Lang.Array t04tpeao8F;

	// Token: 0x040010C8 RID: 4296
	private int r78tRiLoWM;

	// Token: 0x040010C9 RID: 4297
	private float BpXtrMsoaJ;
}
