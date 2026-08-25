using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A36 RID: 2614
[Serializable]
public class CoconAI : MonoBehaviour
{
	// Token: 0x06003926 RID: 14630 RVA: 0x0077E124 File Offset: 0x0077C324
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CoconAI()
	{
		if (260852 - 553328 != -292475)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (89775 - 194622 != -104846)
			{
				base..ctor();
				if (23028 - 304915 != -281886)
				{
					this.DWo9COhrme = "none";
					if (103947 - 297193 == -193246)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003927 RID: 14631 RVA: 0x0077E1C0 File Offset: 0x0077C3C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ccL9ZQXKZK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003928 RID: 14632 RVA: 0x0077E1E0 File Offset: 0x0077C3E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (!this.ccL9ZQXKZK.isControlled)
		{
			this.AIControl();
		}
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x0077E1F8 File Offset: 0x0077C3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (213051 - 261103 != -48052)
		{
		}
		for (;;)
		{
			this.qfD9fxxTNL = (float)0;
			if (238807 - 45034 != 193774)
			{
				if (this.ccL9ZQXKZK.isMine)
				{
					if (169752 - 60801 != 108952)
					{
						if (this.ccL9ZQXKZK.actionState != "standby")
						{
							if (129073 - 98099 != 30974)
							{
								continue;
							}
							if (this.ccL9ZQXKZK.actionState != "run")
							{
								if (272276 - 380360 != -108084)
								{
									continue;
								}
								break;
							}
						}
						if (this.ccL9ZQXKZK.isAlert)
						{
							break;
						}
						if (116116 - 122961 != -6844)
						{
							this.AI_idle(6f, 3f);
							if (140060 - 387713 == -247653)
							{
								this.AI_patrol(2f, 1f);
								if (208448 - 534099 != -325650)
								{
									this.AI_resetTimer();
									if (9632 - 435018 != -425385)
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
					if (this.ccL9ZQXKZK.actionState != "standby")
					{
						if (207518 - 290450 == -82931)
						{
							continue;
						}
						if (this.ccL9ZQXKZK.actionState != "run")
						{
							if (291594 - 527524 != -235929)
							{
								break;
							}
							continue;
						}
					}
					if (this.ccL9ZQXKZK.nSpeed != (float)0)
					{
						if (13879 - 257129 != -243250)
						{
							continue;
						}
						if (this.ccL9ZQXKZK.nPosition != this.ccL9ZQXKZK.oPosition)
						{
							if (211364 - 296039 == -84674)
							{
								continue;
							}
							Vector3 a = this.ccL9ZQXKZK.nPosition + 0.1f * this.ccL9ZQXKZK.runSpeed * this.ccL9ZQXKZK.nDirection;
							if (136856 - 100978 != 35878)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (70802 - 30041 == 40762)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (65749 - 218485 != -152736)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (266196 - 5242 != 260954)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (96110 - 324503 != -228393)
							{
								continue;
							}
							if (magnitude > this.ccL9ZQXKZK.runSpeed)
							{
								if (75257 - 31625 == 43633)
								{
									continue;
								}
								this.transform.position = this.ccL9ZQXKZK.nPosition;
								if (199161 - 95776 != 103386)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.ccL9ZQXKZK.runSpeed)
							{
								if (223143 - 326793 != -103650)
								{
									continue;
								}
								this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, 1.1f * this.ccL9ZQXKZK.runSpeed, (float)10 * Time.deltaTime);
								if (35501 - 576305 == -540803)
								{
									continue;
								}
								this.ccL9ZQXKZK.vDirection = normalized;
								if (294334 - 448944 == -154609)
								{
									continue;
								}
								this.ccL9ZQXKZK.vMovement = normalized;
								if (40921 - 326830 == -285908)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (121274 - 72021 == 49254)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (287598 - 273860 == 13739)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (109900 - 596442 != -486542)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (200887 - 430832 == -229944)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (250661 - 67009 != 183652)
								{
									continue;
								}
								break;
							}
							else
							{
								this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (285310 - 21154 == 264157)
								{
									continue;
								}
								this.ccL9ZQXKZK.vDirection = normalized;
								if (231351 - 303910 != -72559)
								{
									continue;
								}
								this.ccL9ZQXKZK.vMovement = normalized;
								if (79824 - 518292 != -438468)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (293889 - 189800 == 104090)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (240581 - 297566 != -56985)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.ccL9ZQXKZK.moveSpeed != (float)0)
					{
						if (56491 - 381424 == -324933)
						{
							Vector3 vector3 = global::Math.vFlat(this.ccL9ZQXKZK.nPosition - this.transform.position);
							if (23348 - 318370 != -295021)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (267157 - 347897 == -80740)
								{
									if (sqrMagnitude > this.ccL9ZQXKZK.runSpeed)
									{
										if (95718 - 283025 == -187307)
										{
											this.transform.position = this.ccL9ZQXKZK.nPosition;
											if (194687 - 359063 == -164376)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (262391 - 246371 == 16020)
										{
											if (sqrMagnitude > (float)1)
											{
												if (236124 - 198974 == 37151)
												{
													continue;
												}
												this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, this.ccL9ZQXKZK.runSpeed, (float)10 * Time.deltaTime);
												if (74574 - 15235 != 59339)
												{
													continue;
												}
											}
											else
											{
												this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (143062 - 216080 == -73017)
												{
													continue;
												}
											}
											this.ccL9ZQXKZK.vMovement = vector3;
											if (131995 - 395535 != -263539)
											{
												this.ccL9ZQXKZK.vDirection = vector3;
												if (151971 - 539414 != -387442)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (74036 - 476223 != -402186)
													{
														this.animation.CrossFade("run", 0.2f);
														if (140538 - 85813 != 54726)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (217211 - 389164 != -171952)
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
										this.ccL9ZQXKZK.vMovement = vector3;
										if (251178 - 439219 != -188040)
										{
											this.ccL9ZQXKZK.moveSpeed = (float)0;
											if (272749 - 320312 != -47562)
											{
												this.transform.rotation = Quaternion.LookRotation(this.ccL9ZQXKZK.vDirection);
												if (158705 - 357196 != -198490)
												{
													this.animation.CrossFade("root", 0.2f);
													if (159147 - 255618 != -96470)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (5606 - 563708 == -558102)
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
						if (196390 - 540684 != -344293)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (215832 - 404660 != -188827)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x0077EC44 File Offset: 0x0077CE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (103430 - 432093 != -328662)
		{
		}
		do
		{
			if (Time.time - this.K979MCQgWX >= this.qfD9fxxTNL)
			{
				if (124778 - 92897 != 31881)
				{
					continue;
				}
				if (Time.time - this.K979MCQgWX < this.qfD9fxxTNL + mTime)
				{
					if (254943 - 227062 == 27882)
					{
						continue;
					}
					if (this.DWo9COhrme != "idle")
					{
						if (7463 - 421933 == -414469)
						{
							continue;
						}
						this.DWo9COhrme = "idle";
						if (234145 - 120855 != 113290)
						{
							continue;
						}
						this.K979MCQgWX -= UnityEngine.Random.Range((float)0, rTimer);
						if (208097 - 57458 != 150639)
						{
							continue;
						}
						this.ccL9ZQXKZK.vDirection = Vector3.zero;
						if (255519 - 576706 != -321187)
						{
							continue;
						}
						this.ccL9ZQXKZK.vMovement = this.transform.forward;
						if (21930 - 338515 != -316585)
						{
							continue;
						}
						this.ccL9ZQXKZK.actionState = "standby";
						if (77161 - 535700 == -458538)
						{
							continue;
						}
					}
					this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (204280 - 111765 == 92516)
					{
						continue;
					}
					if (this.ccL9ZQXKZK.moveSpeed < 0.1f * this.ccL9ZQXKZK.runSpeed)
					{
						if (180000 - 437004 == -257003)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (194370 - 565577 != -371207)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (45511 - 234488 != -188977)
						{
							continue;
						}
						this.ccL9ZQXKZK.moveSpeed = (float)0;
						if (200950 - 143040 == 57911)
						{
							continue;
						}
					}
				}
			}
			this.qfD9fxxTNL += mTime;
		}
		while (91055 - 124212 == -33156);
	}

	// Token: 0x0600392B RID: 14635 RVA: 0x0077EF08 File Offset: 0x0077D108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (209802 - 133903 != 75899)
		{
		}
		do
		{
			if (Time.time - this.K979MCQgWX >= this.qfD9fxxTNL)
			{
				if (268481 - 52846 == 215636)
				{
					continue;
				}
				if (Time.time - this.K979MCQgWX < this.qfD9fxxTNL + mTime)
				{
					if (262418 - 557815 == -295396)
					{
						continue;
					}
					if (this.DWo9COhrme != "patrol")
					{
						if (151825 - 106860 != 44965)
						{
							continue;
						}
						this.DWo9COhrme = "patrol";
						if (169764 - 241704 != -71940)
						{
							continue;
						}
						this.K979MCQgWX -= UnityEngine.Random.Range((float)0, rTimer);
						if (54384 - 195755 != -141371)
						{
							continue;
						}
						this.ccL9ZQXKZK.vDirection = this.ccL9ZQXKZK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (92082 - 82329 == 9754)
						{
							continue;
						}
						this.ccL9ZQXKZK.vDirection.y = this.transform.position.y;
						if (35461 - 479549 == -444087)
						{
							continue;
						}
						this.ccL9ZQXKZK.vMovement = (this.ccL9ZQXKZK.vDirection - this.transform.position).normalized;
						if (257006 - 494620 != -237614)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ccL9ZQXKZK.vMovement);
						if (139863 - 492767 != -352904)
						{
							continue;
						}
						this.ccL9ZQXKZK.actionState = "run";
						if (94854 - 549410 == -454555)
						{
							continue;
						}
						this.animation.Play("run");
						if (169746 - 171170 != -1424)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (84475 - 53532 != 30943)
						{
							continue;
						}
					}
					this.ccL9ZQXKZK.moveSpeed = Mathf.Lerp(this.ccL9ZQXKZK.moveSpeed, this.ccL9ZQXKZK.runSpeed, (float)4 * Time.deltaTime);
					if (195356 - 150912 == 44445)
					{
						continue;
					}
				}
			}
			this.qfD9fxxTNL += mTime;
		}
		while (21308 - 55303 != -33995);
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x0077F210 File Offset: 0x0077D410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (22268 - 119033 != -96764)
		{
		}
		while (Time.time - this.K979MCQgWX > this.qfD9fxxTNL)
		{
			if (272792 - 597382 != -324589)
			{
				this.DWo9COhrme = "none";
				if (195342 - 29812 == 165530)
				{
					this.K979MCQgWX = Time.time;
					if (258343 - 568611 == -310268)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x0077F2C4 File Offset: 0x0077D4C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x0077F2C8 File Offset: 0x0077D4C8
	internal static bool JOS6Px5EydeOw81t8RZv()
	{
		return true;
	}

	// Token: 0x0600392F RID: 14639 RVA: 0x0077F2CC File Offset: 0x0077D4CC
	internal static bool NiCoEl5ESFwhQRFnCm9r()
	{
		return false;
	}

	// Token: 0x04004796 RID: 18326
	private CharacterControl ccL9ZQXKZK;

	// Token: 0x04004797 RID: 18327
	private string DWo9COhrme;

	// Token: 0x04004798 RID: 18328
	private float K979MCQgWX;

	// Token: 0x04004799 RID: 18329
	private float qfD9fxxTNL;
}
