using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A32 RID: 2610
[Serializable]
public class CarronAI : MonoBehaviour
{
	// Token: 0x06003909 RID: 14601 RVA: 0x0077BD44 File Offset: 0x00779F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarronAI()
	{
		if (239607 - 208897 != 30711)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (119398 - 73335 == 46063)
			{
				base..ctor();
				if (266748 - 338291 != -71542)
				{
					this.KF39scZHS5 = "none";
					if (259477 - 145407 == 114070)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x0077BDE0 File Offset: 0x00779FE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.udc94X5qrM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x0077BE00 File Offset: 0x0077A000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (!this.udc94X5qrM.isControlled)
		{
			this.AIControl();
		}
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x0077BE18 File Offset: 0x0077A018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (61738 - 591088 != -529350)
		{
		}
		for (;;)
		{
			this.NSy97Ga2Hc = (float)0;
			if (73107 - 291098 == -217991)
			{
				if (this.udc94X5qrM.isMine)
				{
					if (89872 - 240323 != -150450)
					{
						if (this.udc94X5qrM.actionState != "standby")
						{
							if (128384 - 389338 != -260954)
							{
								continue;
							}
							if (this.udc94X5qrM.actionState != "run")
							{
								if (243476 - 495402 != -251926)
								{
									continue;
								}
								break;
							}
						}
						if (this.udc94X5qrM.isAlert)
						{
							break;
						}
						if (167775 - 225967 == -58192)
						{
							this.AI_idle(6f, 3f);
							if (186412 - 169088 != 17325)
							{
								this.AI_patrol(2f, 1f);
								if (102290 - 214549 != -112258)
								{
									this.AI_resetTimer();
									if (69467 - 76671 != -7203)
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
					if (this.udc94X5qrM.actionState != "standby")
					{
						if (81104 - 160595 == -79490)
						{
							continue;
						}
						if (this.udc94X5qrM.actionState != "run")
						{
							if (248806 - 144472 != 104334)
							{
								continue;
							}
							break;
						}
					}
					if (this.udc94X5qrM.nSpeed != (float)0)
					{
						if (3474 - 192853 == -189378)
						{
							continue;
						}
						if (this.udc94X5qrM.nPosition != this.udc94X5qrM.oPosition)
						{
							if (202738 - 59981 == 142758)
							{
								continue;
							}
							Vector3 a = this.udc94X5qrM.nPosition + 0.1f * this.udc94X5qrM.runSpeed * this.udc94X5qrM.nDirection;
							if (288874 - 219880 == 68995)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (105754 - 378317 != -272563)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (19943 - 433902 == -413958)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (154742 - 420338 == -265595)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (31168 - 595910 == -564741)
							{
								continue;
							}
							if (magnitude > this.udc94X5qrM.runSpeed)
							{
								if (212596 - 248144 != -35548)
								{
									continue;
								}
								this.transform.position = this.udc94X5qrM.nPosition;
								if (16321 - 556578 != -540257)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.udc94X5qrM.runSpeed)
							{
								if (16930 - 261527 == -244596)
								{
									continue;
								}
								this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, 1.1f * this.udc94X5qrM.runSpeed, (float)10 * Time.deltaTime);
								if (48730 - 417381 == -368650)
								{
									continue;
								}
								this.udc94X5qrM.vDirection = normalized;
								if (239225 - 182813 == 56413)
								{
									continue;
								}
								this.udc94X5qrM.vMovement = normalized;
								if (282036 - 75475 == 206562)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (137933 - 513111 == -375177)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (61770 - 527325 == -465554)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (111219 - 460835 == -349615)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (70425 - 77484 != -7059)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (296252 - 11228 != 285025)
								{
									break;
								}
								continue;
							}
							else
							{
								this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (54735 - 432535 == -377799)
								{
									continue;
								}
								this.udc94X5qrM.vDirection = normalized;
								if (143380 - 593857 != -450477)
								{
									continue;
								}
								this.udc94X5qrM.vMovement = normalized;
								if (61711 - 302892 == -241180)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (42289 - 210932 == -168642)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (197111 - 149212 != 47900)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.udc94X5qrM.moveSpeed != (float)0)
					{
						if (9051 - 118251 == -109200)
						{
							Vector3 vector3 = global::Math.vFlat(this.udc94X5qrM.nPosition - this.transform.position);
							if (81036 - 319070 != -238033)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (266278 - 345966 != -79687)
								{
									if (sqrMagnitude > this.udc94X5qrM.runSpeed)
									{
										if (293538 - 492862 != -199323)
										{
											this.transform.position = this.udc94X5qrM.nPosition;
											if (294108 - 538522 == -244414)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (118535 - 203009 != -84473)
										{
											if (sqrMagnitude > (float)1)
											{
												if (74771 - 262313 != -187542)
												{
													continue;
												}
												this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, this.udc94X5qrM.runSpeed, (float)10 * Time.deltaTime);
												if (258879 - 346818 != -87939)
												{
													continue;
												}
											}
											else
											{
												this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (95180 - 462376 != -367196)
												{
													continue;
												}
											}
											this.udc94X5qrM.vMovement = vector3;
											if (276757 - 281723 == -4966)
											{
												this.udc94X5qrM.vDirection = vector3;
												if (180935 - 80844 == 100091)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (193504 - 38789 == 154715)
													{
														this.animation.CrossFade("run", 0.2f);
														if (278548 - 425489 == -146941)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (104156 - 138124 == -33968)
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
										this.udc94X5qrM.vMovement = vector3;
										if (256523 - 321498 == -64975)
										{
											this.udc94X5qrM.moveSpeed = (float)0;
											if (181650 - 268475 == -86825)
											{
												this.transform.rotation = Quaternion.LookRotation(this.udc94X5qrM.vDirection);
												if (298851 - 274871 == 23980)
												{
													this.animation.CrossFade("root", 0.2f);
													if (251195 - 283 != 250913)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (288121 - 565071 != -276949)
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
						if (162481 - 351770 != -189288)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (141521 - 464611 == -323090)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x0077C864 File Offset: 0x0077AA64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (231862 - 293609 != -61746)
		{
		}
		do
		{
			if (Time.time - this.dMw9H2FaKF >= this.NSy97Ga2Hc)
			{
				if (78824 - 221203 != -142379)
				{
					continue;
				}
				if (Time.time - this.dMw9H2FaKF < this.NSy97Ga2Hc + mTime)
				{
					if (169380 - 485135 == -315754)
					{
						continue;
					}
					if (this.KF39scZHS5 != "idle")
					{
						if (54429 - 563073 != -508644)
						{
							continue;
						}
						this.KF39scZHS5 = "idle";
						if (237539 - 278517 != -40978)
						{
							continue;
						}
						this.dMw9H2FaKF -= UnityEngine.Random.Range((float)0, rTimer);
						if (127586 - 140863 == -13276)
						{
							continue;
						}
						this.udc94X5qrM.vDirection = Vector3.zero;
						if (178709 - 19621 != 159088)
						{
							continue;
						}
						this.udc94X5qrM.vMovement = this.transform.forward;
						if (14503 - 245679 != -231176)
						{
							continue;
						}
						this.udc94X5qrM.actionState = "standby";
						if (29466 - 52833 != -23367)
						{
							continue;
						}
					}
					this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (40658 - 66336 != -25678)
					{
						continue;
					}
					if (this.udc94X5qrM.moveSpeed < 0.1f * this.udc94X5qrM.runSpeed)
					{
						if (67242 - 347439 == -280196)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (100414 - 241631 != -141217)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (144497 - 191275 == -46777)
						{
							continue;
						}
						this.udc94X5qrM.moveSpeed = (float)0;
						if (205127 - 386187 != -181060)
						{
							continue;
						}
					}
				}
			}
			this.NSy97Ga2Hc += mTime;
		}
		while (245640 - 100439 == 145202);
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x0077CB28 File Offset: 0x0077AD28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (271003 - 247863 != 23140)
		{
		}
		do
		{
			if (Time.time - this.dMw9H2FaKF >= this.NSy97Ga2Hc)
			{
				if (139670 - 370117 == -230446)
				{
					continue;
				}
				if (Time.time - this.dMw9H2FaKF < this.NSy97Ga2Hc + mTime)
				{
					if (232758 - 482444 != -249686)
					{
						continue;
					}
					if (this.KF39scZHS5 != "patrol")
					{
						if (35833 - 108127 == -72293)
						{
							continue;
						}
						this.KF39scZHS5 = "patrol";
						if (251193 - 246670 == 4524)
						{
							continue;
						}
						this.dMw9H2FaKF -= UnityEngine.Random.Range((float)0, rTimer);
						if (74836 - 135100 == -60263)
						{
							continue;
						}
						this.udc94X5qrM.vDirection = this.udc94X5qrM.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (91429 - 339380 != -247951)
						{
							continue;
						}
						this.udc94X5qrM.vDirection.y = this.transform.position.y;
						if (125691 - 30699 != 94992)
						{
							continue;
						}
						this.udc94X5qrM.vMovement = (this.udc94X5qrM.vDirection - this.transform.position).normalized;
						if (266917 - 313966 != -47049)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.udc94X5qrM.vMovement);
						if (200884 - 258033 == -57148)
						{
							continue;
						}
						this.udc94X5qrM.actionState = "run";
						if (255637 - 111954 == 143684)
						{
							continue;
						}
						this.animation.Play("run");
						if (23639 - 547066 != -523427)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (30052 - 257602 != -227550)
						{
							continue;
						}
					}
					this.udc94X5qrM.moveSpeed = Mathf.Lerp(this.udc94X5qrM.moveSpeed, this.udc94X5qrM.runSpeed, (float)4 * Time.deltaTime);
					if (245096 - 526396 != -281300)
					{
						continue;
					}
				}
			}
			this.NSy97Ga2Hc += mTime;
		}
		while (183719 - 295049 != -111330);
	}

	// Token: 0x0600390F RID: 14607 RVA: 0x0077CE30 File Offset: 0x0077B030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (207739 - 202986 != 4753)
		{
		}
		while (Time.time - this.dMw9H2FaKF > this.NSy97Ga2Hc)
		{
			if (280258 - 272042 == 8216)
			{
				this.KF39scZHS5 = "none";
				if (262613 - 124009 == 138604)
				{
					this.dMw9H2FaKF = Time.time;
					if (103508 - 294425 == -190917)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003910 RID: 14608 RVA: 0x0077CEE4 File Offset: 0x0077B0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003911 RID: 14609 RVA: 0x0077CEE8 File Offset: 0x0077B0E8
	internal static bool qeGOIi5EX9hQrQoi30vs()
	{
		return true;
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x0077CEEC File Offset: 0x0077B0EC
	internal static bool WScnYK5EQQDg1RBDNDge()
	{
		return false;
	}

	// Token: 0x0400478A RID: 18314
	private CharacterControl udc94X5qrM;

	// Token: 0x0400478B RID: 18315
	private string KF39scZHS5;

	// Token: 0x0400478C RID: 18316
	private float dMw9H2FaKF;

	// Token: 0x0400478D RID: 18317
	private float NSy97Ga2Hc;
}
