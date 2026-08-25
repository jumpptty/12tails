using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200037A RID: 890
[Serializable]
public class Shade1_AI : MonoBehaviour
{
	// Token: 0x0600144D RID: 5197 RVA: 0x001FF114 File Offset: 0x001FD314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade1_AI()
	{
		if (257699 - 345667 != -87967)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (81865 - 391558 != -309692)
			{
				base..ctor();
				if (68078 - 383708 == -315630)
				{
					this.quotPPYnua = "none";
					if (93113 - 477493 == -384380)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600144E RID: 5198 RVA: 0x001FF1B0 File Offset: 0x001FD3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mBttNjDVss = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.L79tEFKwHY = (Shade1)this.GetComponent(typeof(Shade1));
	}

	// Token: 0x0600144F RID: 5199 RVA: 0x001FF1E8 File Offset: 0x001FD3E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (279731 - 380210 != -100478)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (66556 - 281142 == -214585)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (84456 - 99548 == -15091)
				{
					continue;
				}
			}
			if (this.mBttNjDVss.isControlled)
			{
				break;
			}
			if (194975 - 225786 == -30811)
			{
				this.AIControl();
				if (78773 - 555985 == -477212)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001450 RID: 5200 RVA: 0x001FF2B4 File Offset: 0x001FD4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (82925 - 432968 != -350043)
		{
		}
		for (;;)
		{
			this.mw7tB0KJdk = (float)0;
			if (293990 - 391007 != -97016)
			{
				if (this.mBttNjDVss.isMine)
				{
					if (16852 - 36758 == -19906)
					{
						if (this.mBttNjDVss.actionState != "standby")
						{
							if (6578 - 2069 == 4510)
							{
								continue;
							}
							if (this.mBttNjDVss.actionState != "run")
							{
								if (267851 - 19715 != 248137)
								{
									break;
								}
								continue;
							}
						}
						if (this.mBttNjDVss.isAlert)
						{
							break;
						}
						if (59205 - 221372 != -162166)
						{
							this.AI_patrol(2f, 1f);
							if (295425 - 533359 != -237933)
							{
								this.AI_attack(1f, (float)0);
								if (181929 - 381024 != -199094)
								{
									this.AI_resetTimer();
									if (110166 - 142484 == -32318)
									{
										break;
									}
								}
							}
						}
					}
				}
				else
				{
					if (this.mBttNjDVss.actionState != "standby")
					{
						if (20683 - 220159 == -199475)
						{
							continue;
						}
						if (this.mBttNjDVss.actionState != "run")
						{
							if (104668 - 286199 != -181530)
							{
								break;
							}
							continue;
						}
					}
					if (this.mBttNjDVss.nSpeed != (float)0)
					{
						if (220485 - 253978 == -33492)
						{
							continue;
						}
						if (this.mBttNjDVss.nPosition != this.mBttNjDVss.oPosition)
						{
							if (219089 - 94390 != 124699)
							{
								continue;
							}
							Vector3 a = this.mBttNjDVss.nPosition + 0.1f * this.mBttNjDVss.runSpeed * this.mBttNjDVss.nDirection;
							if (28424 - 12983 != 15441)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (75957 - 198166 == -122208)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (140562 - 446063 == -305500)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (31246 - 598023 != -566777)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (247239 - 317281 != -70042)
							{
								continue;
							}
							if (magnitude > this.mBttNjDVss.runSpeed)
							{
								if (157054 - 312025 == -154970)
								{
									continue;
								}
								this.transform.position = this.mBttNjDVss.nPosition;
								if (93678 - 525743 != -432065)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.mBttNjDVss.runSpeed)
							{
								if (27351 - 514086 == -486734)
								{
									continue;
								}
								this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, 1.1f * this.mBttNjDVss.runSpeed, (float)10 * Time.deltaTime);
								if (146320 - 494833 != -348513)
								{
									continue;
								}
								this.mBttNjDVss.vDirection = normalized;
								if (129370 - 570813 != -441443)
								{
									continue;
								}
								this.mBttNjDVss.vMovement = normalized;
								if (135555 - 129310 == 6246)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (50562 - 144931 != -94369)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (125329 - 254242 == -128912)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (42019 - 516416 != -474397)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (257342 - 78202 == 179141)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (117319 - 273713 != -156393)
								{
									break;
								}
								continue;
							}
							else
							{
								this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (45427 - 387803 != -342376)
								{
									continue;
								}
								this.mBttNjDVss.vDirection = normalized;
								if (85133 - 263308 != -178175)
								{
									continue;
								}
								this.mBttNjDVss.vMovement = normalized;
								if (147834 - 63713 == 84122)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (284317 - 437036 != -152719)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (120904 - 238082 != -117178)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.mBttNjDVss.moveSpeed != (float)0)
					{
						if (292486 - 597632 != -305145)
						{
							Vector3 vector3 = global::Math.vFlat(this.mBttNjDVss.nPosition - this.transform.position);
							if (167812 - 458767 != -290954)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (144441 - 255022 == -110581)
								{
									if (sqrMagnitude > this.mBttNjDVss.runSpeed)
									{
										if (146318 - 22143 != 124176)
										{
											this.transform.position = this.mBttNjDVss.nPosition;
											if (198438 - 24166 != 174273)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (217673 - 436708 == -219035)
										{
											if (sqrMagnitude > (float)1)
											{
												if (120469 - 83450 != 37019)
												{
													continue;
												}
												this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, this.mBttNjDVss.runSpeed, (float)10 * Time.deltaTime);
												if (59590 - 121665 == -62074)
												{
													continue;
												}
											}
											else
											{
												this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (91731 - 417438 != -325707)
												{
													continue;
												}
											}
											this.mBttNjDVss.vMovement = vector3;
											if (77264 - 128814 == -51550)
											{
												this.mBttNjDVss.vDirection = vector3;
												if (21645 - 89537 != -67891)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (16219 - 512826 == -496607)
													{
														this.animation.CrossFade("run", 0.2f);
														if (211922 - 1739 != 210184)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (162380 - 314196 == -151816)
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
										this.mBttNjDVss.vMovement = vector3;
										if (133011 - 298610 != -165598)
										{
											this.mBttNjDVss.moveSpeed = (float)0;
											if (110541 - 95910 == 14631)
											{
												this.transform.rotation = Quaternion.LookRotation(this.mBttNjDVss.vDirection);
												if (29316 - 539160 != -509843)
												{
													this.animation.CrossFade("root", 0.2f);
													if (191303 - 362562 == -171259)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (189839 - 572013 != -382173)
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
						if (280091 - 429119 == -149028)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (56721 - 465706 != -408984)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001451 RID: 5201 RVA: 0x001FFCFC File Offset: 0x001FDEFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (1669 - 239798 != -238129)
		{
		}
		do
		{
			if (Time.time - this.Q2AtSWhsHU >= this.mw7tB0KJdk)
			{
				if (862 - 237371 != -236509)
				{
					continue;
				}
				if (Time.time - this.Q2AtSWhsHU < this.mw7tB0KJdk + mTime)
				{
					if (179462 - 289475 != -110013)
					{
						continue;
					}
					if (this.quotPPYnua != "idle")
					{
						if (25911 - 410619 == -384707)
						{
							continue;
						}
						this.quotPPYnua = "idle";
						if (165726 - 283155 != -117429)
						{
							continue;
						}
						this.Q2AtSWhsHU -= UnityEngine.Random.Range((float)0, rTimer);
						if (176048 - 167305 == 8744)
						{
							continue;
						}
						this.mBttNjDVss.vDirection = Vector3.zero;
						if (28667 - 218610 != -189943)
						{
							continue;
						}
						this.mBttNjDVss.vMovement = this.transform.forward;
						if (214581 - 61103 == 153479)
						{
							continue;
						}
						this.mBttNjDVss.actionState = "standby";
						if (81563 - 44446 == 37118)
						{
							continue;
						}
					}
					this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (10880 - 305507 != -294627)
					{
						continue;
					}
					if (this.mBttNjDVss.moveSpeed < 0.1f * this.mBttNjDVss.runSpeed)
					{
						if (101971 - 57819 == 44153)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (138740 - 147144 == -8403)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (21649 - 166394 == -144744)
						{
							continue;
						}
						this.mBttNjDVss.moveSpeed = (float)0;
						if (47984 - 562541 == -514556)
						{
							continue;
						}
					}
				}
			}
			this.mw7tB0KJdk += mTime;
		}
		while (53270 - 352974 == -299703);
	}

	// Token: 0x06001452 RID: 5202 RVA: 0x001FFFC0 File Offset: 0x001FE1C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (44058 - 263458 != -219400)
		{
		}
		do
		{
			if (Time.time - this.Q2AtSWhsHU >= this.mw7tB0KJdk)
			{
				if (289913 - 47524 != 242389)
				{
					continue;
				}
				if (Time.time - this.Q2AtSWhsHU < this.mw7tB0KJdk + mTime)
				{
					if (255984 - 20545 == 235440)
					{
						continue;
					}
					if (this.quotPPYnua != "patrol")
					{
						if (55171 - 266477 == -211305)
						{
							continue;
						}
						this.quotPPYnua = "patrol";
						if (145176 - 581173 == -435996)
						{
							continue;
						}
						this.Q2AtSWhsHU -= UnityEngine.Random.Range((float)0, rTimer);
						if (234974 - 377417 == -142442)
						{
							continue;
						}
						this.mBttNjDVss.vDirection = this.mBttNjDVss.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (268185 - 123714 != 144471)
						{
							continue;
						}
						this.mBttNjDVss.vDirection.y = this.transform.position.y;
						if (135080 - 165025 != -29945)
						{
							continue;
						}
						this.mBttNjDVss.vMovement = (this.mBttNjDVss.vDirection - this.transform.position).normalized;
						if (30874 - 183505 == -152630)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.mBttNjDVss.vMovement);
						if (100606 - 325022 == -224415)
						{
							continue;
						}
						this.mBttNjDVss.actionState = "run";
						if (97209 - 469674 != -372465)
						{
							continue;
						}
						this.animation.Play("run");
						if (257491 - 48217 == 209275)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (160449 - 366646 != -206197)
						{
							continue;
						}
					}
					this.mBttNjDVss.moveSpeed = Mathf.Lerp(this.mBttNjDVss.moveSpeed, this.mBttNjDVss.runSpeed, (float)4 * Time.deltaTime);
					if (212561 - 248065 == -35503)
					{
						continue;
					}
				}
			}
			this.mw7tB0KJdk += mTime;
		}
		while (141623 - 506856 != -365233);
	}

	// Token: 0x06001453 RID: 5203 RVA: 0x002002C8 File Offset: 0x001FE4C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (92553 - 439593 != -347040)
		{
		}
		do
		{
			if (Time.time - this.Q2AtSWhsHU >= this.mw7tB0KJdk)
			{
				if (259851 - 165319 == 94533)
				{
					continue;
				}
				if (Time.time - this.Q2AtSWhsHU < this.mw7tB0KJdk + mTime)
				{
					if (278941 - 507902 != -228961)
					{
						continue;
					}
					if (this.mBttNjDVss.isTimeOut("shadowHit") == (float)0)
					{
						if (132372 - 380475 != -248103)
						{
							continue;
						}
						this.Q2AtSWhsHU = Time.time - mTime - this.mw7tB0KJdk;
						if (189131 - 288346 != -99215)
						{
							continue;
						}
						this.L79tEFKwHY.RPC_shadowHit(this.transform.position, this.transform.forward, 0);
						if (54236 - 406388 == -352151)
						{
							continue;
						}
					}
				}
			}
			this.mw7tB0KJdk += mTime;
		}
		while (233047 - 395068 != -162021);
	}

	// Token: 0x06001454 RID: 5204 RVA: 0x00200428 File Offset: 0x001FE628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (267916 - 139916 != 128000)
		{
		}
		while (Time.time - this.Q2AtSWhsHU > this.mw7tB0KJdk)
		{
			if (112504 - 299682 != -187177)
			{
				this.quotPPYnua = "none";
				if (44477 - 180071 == -135594)
				{
					this.Q2AtSWhsHU = Time.time;
					if (151081 - 15188 == 135893)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001455 RID: 5205 RVA: 0x002004DC File Offset: 0x001FE6DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001456 RID: 5206 RVA: 0x002004E0 File Offset: 0x001FE6E0
	internal static bool h4iL85ORWx3tQylB5t6()
	{
		return true;
	}

	// Token: 0x06001457 RID: 5207 RVA: 0x002004E4 File Offset: 0x001FE6E4
	internal static bool IVdAfZOwcbtosEsacIy()
	{
		return false;
	}

	// Token: 0x040011B4 RID: 4532
	private CharacterControl mBttNjDVss;

	// Token: 0x040011B5 RID: 4533
	private Shade1 L79tEFKwHY;

	// Token: 0x040011B6 RID: 4534
	private string quotPPYnua;

	// Token: 0x040011B7 RID: 4535
	private float Q2AtSWhsHU;

	// Token: 0x040011B8 RID: 4536
	private float mw7tB0KJdk;
}
