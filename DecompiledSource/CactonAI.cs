using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A28 RID: 2600
[Serializable]
public class CactonAI : MonoBehaviour
{
	// Token: 0x060038C2 RID: 14530 RVA: 0x00776D70 File Offset: 0x00774F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CactonAI()
	{
		if (232714 - 72567 != 160148)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (260501 - 413270 != -152768)
			{
				base..ctor();
				if (18968 - 347938 != -328969)
				{
					this.xkf9rQnOoG = "none";
					if (100004 - 139247 == -39243)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038C3 RID: 14531 RVA: 0x00776E0C File Offset: 0x0077500C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.dsC9Re0Vej = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060038C4 RID: 14532 RVA: 0x00776E2C File Offset: 0x0077502C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (!this.dsC9Re0Vej.isControlled)
		{
			this.AIControl();
		}
	}

	// Token: 0x060038C5 RID: 14533 RVA: 0x00776E44 File Offset: 0x00775044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (54398 - 441931 != -387533)
		{
		}
		for (;;)
		{
			this.J1X9TtUDB8 = (float)0;
			if (196171 - 496983 != -300811)
			{
				if (this.dsC9Re0Vej.isMine)
				{
					if (162261 - 73832 != 88430)
					{
						if (this.dsC9Re0Vej.actionState != "standby")
						{
							if (296582 - 455845 != -159263)
							{
								continue;
							}
							if (this.dsC9Re0Vej.actionState != "run")
							{
								if (27188 - 153623 != -126435)
								{
									continue;
								}
								break;
							}
						}
						if (this.dsC9Re0Vej.isAlert)
						{
							break;
						}
						if (136621 - 585425 != -448803)
						{
							this.AI_idle(6f, 3f);
							if (232932 - 58878 == 174054)
							{
								this.AI_patrol(2f, 1f);
								if (15305 - 555111 == -539806)
								{
									this.AI_resetTimer();
									if (157339 - 563223 != -405883)
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
					if (this.dsC9Re0Vej.actionState != "standby")
					{
						if (208234 - 107095 != 101139)
						{
							continue;
						}
						if (this.dsC9Re0Vej.actionState != "run")
						{
							if (47185 - 42503 != 4682)
							{
								continue;
							}
							break;
						}
					}
					if (this.dsC9Re0Vej.nSpeed != (float)0)
					{
						if (90235 - 282691 != -192456)
						{
							continue;
						}
						if (this.dsC9Re0Vej.nPosition != this.dsC9Re0Vej.oPosition)
						{
							if (122721 - 86782 == 35940)
							{
								continue;
							}
							Vector3 a = this.dsC9Re0Vej.nPosition + 0.1f * this.dsC9Re0Vej.runSpeed * this.dsC9Re0Vej.nDirection;
							if (176285 - 134861 != 41424)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (93359 - 395090 == -301730)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (272748 - 563512 != -290764)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (208139 - 408627 != -200488)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (187962 - 580071 == -392108)
							{
								continue;
							}
							if (magnitude > this.dsC9Re0Vej.runSpeed)
							{
								if (68668 - 417859 != -349191)
								{
									continue;
								}
								this.transform.position = this.dsC9Re0Vej.nPosition;
								if (167975 - 270262 != -102287)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.dsC9Re0Vej.runSpeed)
							{
								if (238387 - 571718 != -333331)
								{
									continue;
								}
								this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, 1.1f * this.dsC9Re0Vej.runSpeed, (float)10 * Time.deltaTime);
								if (52289 - 308264 != -255975)
								{
									continue;
								}
								this.dsC9Re0Vej.vDirection = normalized;
								if (23257 - 474362 == -451104)
								{
									continue;
								}
								this.dsC9Re0Vej.vMovement = normalized;
								if (13673 - 516455 == -502781)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (130844 - 142817 == -11972)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (120430 - 124509 == -4078)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (40084 - 242279 == -202194)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (22277 - 349068 != -326791)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (266973 - 534558 != -267584)
								{
									break;
								}
								continue;
							}
							else
							{
								this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (50034 - 152299 == -102264)
								{
									continue;
								}
								this.dsC9Re0Vej.vDirection = normalized;
								if (115063 - 510043 == -394979)
								{
									continue;
								}
								this.dsC9Re0Vej.vMovement = normalized;
								if (49132 - 474419 == -425286)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (147699 - 148948 != -1249)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (117250 - 188777 != -71527)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.dsC9Re0Vej.moveSpeed != (float)0)
					{
						if (219575 - 414961 != -195385)
						{
							Vector3 vector3 = global::Math.vFlat(this.dsC9Re0Vej.nPosition - this.transform.position);
							if (145780 - 146379 == -599)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (189470 - 560558 == -371088)
								{
									if (sqrMagnitude > this.dsC9Re0Vej.runSpeed)
									{
										if (150172 - 196138 != -45965)
										{
											this.transform.position = this.dsC9Re0Vej.nPosition;
											if (49682 - 314734 == -265052)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (267996 - 535335 == -267339)
										{
											if (sqrMagnitude > (float)1)
											{
												if (4948 - 234410 == -229461)
												{
													continue;
												}
												this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, this.dsC9Re0Vej.runSpeed, (float)10 * Time.deltaTime);
												if (67108 - 572248 != -505140)
												{
													continue;
												}
											}
											else
											{
												this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (223462 - 392832 != -169370)
												{
													continue;
												}
											}
											this.dsC9Re0Vej.vMovement = vector3;
											if (78189 - 291574 != -213384)
											{
												this.dsC9Re0Vej.vDirection = vector3;
												if (221463 - 135577 != 85887)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (128282 - 26702 != 101581)
													{
														this.animation.CrossFade("run", 0.2f);
														if (56435 - 532284 == -475849)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (154907 - 562939 == -408032)
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
										this.dsC9Re0Vej.vMovement = vector3;
										if (50733 - 487884 == -437151)
										{
											this.dsC9Re0Vej.moveSpeed = (float)0;
											if (255169 - 384721 == -129552)
											{
												this.transform.rotation = Quaternion.LookRotation(this.dsC9Re0Vej.vDirection);
												if (190748 - 337402 != -146653)
												{
													this.animation.CrossFade("root", 0.2f);
													if (19891 - 371236 != -351344)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (147202 - 392083 == -244881)
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
						if (242010 - 196917 != 45094)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (120759 - 319375 == -198616)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060038C6 RID: 14534 RVA: 0x00777890 File Offset: 0x00775A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (146510 - 521806 != -375296)
		{
		}
		do
		{
			if (Time.time - this.OCt9xVYStg >= this.J1X9TtUDB8)
			{
				if (111275 - 32302 != 78973)
				{
					continue;
				}
				if (Time.time - this.OCt9xVYStg < this.J1X9TtUDB8 + mTime)
				{
					if (67131 - 455144 != -388013)
					{
						continue;
					}
					if (this.xkf9rQnOoG != "idle")
					{
						if (78097 - 121147 != -43050)
						{
							continue;
						}
						this.xkf9rQnOoG = "idle";
						if (216522 - 524183 == -307660)
						{
							continue;
						}
						this.OCt9xVYStg -= UnityEngine.Random.Range((float)0, rTimer);
						if (286829 - 256664 == 30166)
						{
							continue;
						}
						this.dsC9Re0Vej.vDirection = Vector3.zero;
						if (241912 - 106389 != 135523)
						{
							continue;
						}
						this.dsC9Re0Vej.vMovement = this.transform.forward;
						if (190885 - 58731 == 132155)
						{
							continue;
						}
						this.dsC9Re0Vej.actionState = "standby";
						if (162765 - 120618 == 42148)
						{
							continue;
						}
					}
					this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (242310 - 225436 == 16875)
					{
						continue;
					}
					if (this.dsC9Re0Vej.moveSpeed < 0.1f * this.dsC9Re0Vej.runSpeed)
					{
						if (54018 - 478557 != -424539)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (24678 - 595541 != -570863)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (186996 - 571606 == -384609)
						{
							continue;
						}
						this.dsC9Re0Vej.moveSpeed = (float)0;
						if (19469 - 2065 != 17404)
						{
							continue;
						}
					}
				}
			}
			this.J1X9TtUDB8 += mTime;
		}
		while (142082 - 302216 != -160134);
	}

	// Token: 0x060038C7 RID: 14535 RVA: 0x00777B54 File Offset: 0x00775D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (280789 - 246510 != 34280)
		{
		}
		do
		{
			if (Time.time - this.OCt9xVYStg >= this.J1X9TtUDB8)
			{
				if (185784 - 405801 == -220016)
				{
					continue;
				}
				if (Time.time - this.OCt9xVYStg < this.J1X9TtUDB8 + mTime)
				{
					if (41194 - 578985 != -537791)
					{
						continue;
					}
					if (this.xkf9rQnOoG != "patrol")
					{
						if (225748 - 514629 == -288880)
						{
							continue;
						}
						this.xkf9rQnOoG = "patrol";
						if (265125 - 149681 == 115445)
						{
							continue;
						}
						this.OCt9xVYStg -= UnityEngine.Random.Range((float)0, rTimer);
						if (123774 - 242668 == -118893)
						{
							continue;
						}
						this.dsC9Re0Vej.vDirection = this.dsC9Re0Vej.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (246280 - 155443 != 90837)
						{
							continue;
						}
						this.dsC9Re0Vej.vDirection.y = this.transform.position.y;
						if (48461 - 441032 == -392570)
						{
							continue;
						}
						this.dsC9Re0Vej.vMovement = (this.dsC9Re0Vej.vDirection - this.transform.position).normalized;
						if (41224 - 524680 == -483455)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dsC9Re0Vej.vMovement);
						if (188094 - 559384 == -371289)
						{
							continue;
						}
						this.dsC9Re0Vej.actionState = "run";
						if (153628 - 105967 != 47661)
						{
							continue;
						}
						this.animation.Play("run");
						if (234652 - 334885 != -100233)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (294699 - 505042 == -210342)
						{
							continue;
						}
					}
					this.dsC9Re0Vej.moveSpeed = Mathf.Lerp(this.dsC9Re0Vej.moveSpeed, this.dsC9Re0Vej.runSpeed, (float)4 * Time.deltaTime);
					if (93226 - 236732 == -143505)
					{
						continue;
					}
				}
			}
			this.J1X9TtUDB8 += mTime;
		}
		while (196720 - 311752 == -115031);
	}

	// Token: 0x060038C8 RID: 14536 RVA: 0x00777E5C File Offset: 0x0077605C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (151262 - 379733 != -228470)
		{
		}
		while (Time.time - this.OCt9xVYStg > this.J1X9TtUDB8)
		{
			if (35993 - 2038 != 33956)
			{
				this.xkf9rQnOoG = "none";
				if (74623 - 355458 == -280835)
				{
					this.OCt9xVYStg = Time.time;
					if (298811 - 403856 != -105044)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060038C9 RID: 14537 RVA: 0x00777F10 File Offset: 0x00776110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038CA RID: 14538 RVA: 0x00777F14 File Offset: 0x00776114
	internal static bool kaNOi35oecdrtvaGkcoY()
	{
		return true;
	}

	// Token: 0x060038CB RID: 14539 RVA: 0x00777F18 File Offset: 0x00776118
	internal static bool y5Rtq65orhlqCJg26men()
	{
		return false;
	}

	// Token: 0x04004763 RID: 18275
	private CharacterControl dsC9Re0Vej;

	// Token: 0x04004764 RID: 18276
	private string xkf9rQnOoG;

	// Token: 0x04004765 RID: 18277
	private float OCt9xVYStg;

	// Token: 0x04004766 RID: 18278
	private float J1X9TtUDB8;
}
