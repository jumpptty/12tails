using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A75 RID: 2677
[Serializable]
public class Mellon_AI : MonoBehaviour
{
	// Token: 0x06003ACE RID: 15054 RVA: 0x007AACD0 File Offset: 0x007A8ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mellon_AI()
	{
		if (257811 - 256356 != 1456)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (6717 - 83657 == -76940)
			{
				base..ctor();
				if (70603 - 531152 != -460548)
				{
					this.SG0WxLN9YO = "none";
					if (299750 - 149356 != 150395)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003ACF RID: 15055 RVA: 0x007AAD6C File Offset: 0x007A8F6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.w3dWrPRnYH = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003AD0 RID: 15056 RVA: 0x007AAD8C File Offset: 0x007A8F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (!this.w3dWrPRnYH.isControlled)
		{
			this.AIControl();
		}
	}

	// Token: 0x06003AD1 RID: 15057 RVA: 0x007AADA4 File Offset: 0x007A8FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (68845 - 301875 != -233029)
		{
		}
		for (;;)
		{
			this.cHRWYmVY2v = (float)0;
			if (21921 - 501200 != -479278)
			{
				if (this.w3dWrPRnYH.isMine)
				{
					if (287636 - 153211 != 134426)
					{
						if (this.w3dWrPRnYH.actionState != "standby")
						{
							if (74955 - 193603 == -118647)
							{
								continue;
							}
							if (this.w3dWrPRnYH.actionState != "run")
							{
								if (269178 - 248517 != 20661)
								{
									continue;
								}
								break;
							}
						}
						if (this.w3dWrPRnYH.isAlert)
						{
							break;
						}
						if (256795 - 393850 == -137055)
						{
							this.AI_idle(6f, 3f);
							if (170833 - 159487 == 11346)
							{
								this.AI_patrol(2f, 1f);
								if (39634 - 321287 == -281653)
								{
									this.AI_resetTimer();
									if (218721 - 24325 == 194396)
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
					if (this.w3dWrPRnYH.actionState != "standby")
					{
						if (246435 - 177350 == 69086)
						{
							continue;
						}
						if (this.w3dWrPRnYH.actionState != "run")
						{
							if (121537 - 526212 != -404674)
							{
								break;
							}
							continue;
						}
					}
					if (this.w3dWrPRnYH.nSpeed != (float)0)
					{
						if (219449 - 253722 != -34273)
						{
							continue;
						}
						if (this.w3dWrPRnYH.nPosition != this.w3dWrPRnYH.oPosition)
						{
							if (86785 - 552716 != -465931)
							{
								continue;
							}
							Vector3 a = this.w3dWrPRnYH.nPosition + 0.1f * this.w3dWrPRnYH.runSpeed * this.w3dWrPRnYH.nDirection;
							if (217553 - 316893 != -99340)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (244565 - 157760 != 86805)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (273121 - 397402 == -124280)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (138354 - 66871 != 71483)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (188803 - 203049 != -14246)
							{
								continue;
							}
							if (magnitude > this.w3dWrPRnYH.runSpeed)
							{
								if (266896 - 386806 == -119909)
								{
									continue;
								}
								this.transform.position = this.w3dWrPRnYH.nPosition;
								if (228175 - 82619 != 145556)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.w3dWrPRnYH.runSpeed)
							{
								if (56762 - 217127 != -160365)
								{
									continue;
								}
								this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, 1.1f * this.w3dWrPRnYH.runSpeed, (float)10 * Time.deltaTime);
								if (16135 - 155192 == -139056)
								{
									continue;
								}
								this.w3dWrPRnYH.vDirection = normalized;
								if (119228 - 184450 == -65221)
								{
									continue;
								}
								this.w3dWrPRnYH.vMovement = normalized;
								if (200663 - 76567 != 124096)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (25823 - 227740 != -201917)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (297607 - 380616 == -83008)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (292265 - 411501 != -119236)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (197202 - 231411 == -34208)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (29909 - 332674 != -302764)
								{
									break;
								}
								continue;
							}
							else
							{
								this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (279800 - 509144 == -229343)
								{
									continue;
								}
								this.w3dWrPRnYH.vDirection = normalized;
								if (82084 - 420301 != -338217)
								{
									continue;
								}
								this.w3dWrPRnYH.vMovement = normalized;
								if (157197 - 368512 != -211315)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (220831 - 60530 != 160301)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (215089 - 300939 != -85849)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.w3dWrPRnYH.moveSpeed != (float)0)
					{
						if (142318 - 351950 != -209631)
						{
							Vector3 vector3 = global::Math.vFlat(this.w3dWrPRnYH.nPosition - this.transform.position);
							if (214266 - 151764 != 62503)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (194045 - 399351 == -205306)
								{
									if (sqrMagnitude > this.w3dWrPRnYH.runSpeed)
									{
										if (188246 - 402964 == -214718)
										{
											this.transform.position = this.w3dWrPRnYH.nPosition;
											if (258029 - 236463 != 21567)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (259037 - 288650 == -29613)
										{
											if (sqrMagnitude > (float)1)
											{
												if (234232 - 164467 == 69766)
												{
													continue;
												}
												this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, this.w3dWrPRnYH.runSpeed, (float)10 * Time.deltaTime);
												if (293691 - 136124 == 157568)
												{
													continue;
												}
											}
											else
											{
												this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (33647 - 22771 == 10877)
												{
													continue;
												}
											}
											this.w3dWrPRnYH.vMovement = vector3;
											if (104435 - 562718 == -458283)
											{
												this.w3dWrPRnYH.vDirection = vector3;
												if (193096 - 36822 != 156275)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (222591 - 104662 != 117930)
													{
														this.animation.CrossFade("run", 0.2f);
														if (221225 - 334096 == -112871)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (200290 - 103619 == 96671)
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
										this.w3dWrPRnYH.vMovement = vector3;
										if (165851 - 279042 == -113191)
										{
											this.w3dWrPRnYH.moveSpeed = (float)0;
											if (152092 - 140092 == 12000)
											{
												this.transform.rotation = Quaternion.LookRotation(this.w3dWrPRnYH.vDirection);
												if (98905 - 367839 != -268933)
												{
													this.animation.CrossFade("root", 0.2f);
													if (30199 - 294510 == -264311)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (3927 - 114559 != -110631)
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
						if (293539 - 95469 != 198071)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (139859 - 245175 != -105315)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003AD2 RID: 15058 RVA: 0x007AB7F0 File Offset: 0x007A99F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (96003 - 403832 != -307829)
		{
		}
		do
		{
			if (Time.time - this.zCcWTnLwgb >= this.cHRWYmVY2v)
			{
				if (62139 - 15511 != 46628)
				{
					continue;
				}
				if (Time.time - this.zCcWTnLwgb < this.cHRWYmVY2v + mTime)
				{
					if (283772 - 570624 != -286852)
					{
						continue;
					}
					if (this.SG0WxLN9YO != "idle")
					{
						if (244384 - 63590 == 180795)
						{
							continue;
						}
						this.SG0WxLN9YO = "idle";
						if (83750 - 455484 == -371733)
						{
							continue;
						}
						this.zCcWTnLwgb -= UnityEngine.Random.Range((float)0, rTimer);
						if (130639 - 348741 != -218102)
						{
							continue;
						}
						this.w3dWrPRnYH.vDirection = Vector3.zero;
						if (196875 - 43252 != 153623)
						{
							continue;
						}
						this.w3dWrPRnYH.vMovement = this.transform.forward;
						if (265902 - 176374 != 89528)
						{
							continue;
						}
						this.w3dWrPRnYH.actionState = "standby";
						if (145071 - 378449 != -233378)
						{
							continue;
						}
					}
					this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (85290 - 252807 != -167517)
					{
						continue;
					}
					if (this.w3dWrPRnYH.moveSpeed < 0.1f * this.w3dWrPRnYH.runSpeed)
					{
						if (195500 - 490163 == -294662)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (107264 - 233154 == -125889)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (282406 - 552754 != -270348)
						{
							continue;
						}
						this.w3dWrPRnYH.moveSpeed = (float)0;
						if (101540 - 158181 == -56640)
						{
							continue;
						}
					}
				}
			}
			this.cHRWYmVY2v += mTime;
		}
		while (251193 - 412175 == -160981);
	}

	// Token: 0x06003AD3 RID: 15059 RVA: 0x007ABAB4 File Offset: 0x007A9CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (88792 - 56499 != 32293)
		{
		}
		do
		{
			if (Time.time - this.zCcWTnLwgb >= this.cHRWYmVY2v)
			{
				if (258598 - 416672 != -158074)
				{
					continue;
				}
				if (Time.time - this.zCcWTnLwgb < this.cHRWYmVY2v + mTime)
				{
					if (100268 - 498887 == -398618)
					{
						continue;
					}
					if (this.SG0WxLN9YO != "patrol")
					{
						if (11573 - 83039 == -71465)
						{
							continue;
						}
						this.SG0WxLN9YO = "patrol";
						if (237306 - 456634 == -219327)
						{
							continue;
						}
						this.zCcWTnLwgb -= UnityEngine.Random.Range((float)0, rTimer);
						if (68530 - 568611 != -500081)
						{
							continue;
						}
						this.w3dWrPRnYH.vDirection = this.w3dWrPRnYH.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (177728 - 281892 != -104164)
						{
							continue;
						}
						this.w3dWrPRnYH.vDirection.y = this.transform.position.y;
						if (96528 - 332820 == -236291)
						{
							continue;
						}
						this.w3dWrPRnYH.vMovement = (this.w3dWrPRnYH.vDirection - this.transform.position).normalized;
						if (18267 - 402340 != -384073)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.w3dWrPRnYH.vMovement);
						if (206463 - 24185 == 182279)
						{
							continue;
						}
						this.w3dWrPRnYH.actionState = "run";
						if (169572 - 197223 != -27651)
						{
							continue;
						}
						this.animation.Play("run");
						if (213030 - 433932 != -220902)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (26511 - 552941 != -526430)
						{
							continue;
						}
					}
					this.w3dWrPRnYH.moveSpeed = Mathf.Lerp(this.w3dWrPRnYH.moveSpeed, this.w3dWrPRnYH.runSpeed, (float)4 * Time.deltaTime);
					if (92966 - 384900 == -291933)
					{
						continue;
					}
				}
			}
			this.cHRWYmVY2v += mTime;
		}
		while (251967 - 149069 == 102899);
	}

	// Token: 0x06003AD4 RID: 15060 RVA: 0x007ABDBC File Offset: 0x007A9FBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (249697 - 576838 != -327140)
		{
		}
		while (Time.time - this.zCcWTnLwgb > this.cHRWYmVY2v)
		{
			if (57918 - 297368 == -239450)
			{
				this.SG0WxLN9YO = "none";
				if (79501 - 39917 != 39585)
				{
					this.zCcWTnLwgb = Time.time;
					if (145101 - 306350 != -161248)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003AD5 RID: 15061 RVA: 0x007ABE70 File Offset: 0x007AA070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003AD6 RID: 15062 RVA: 0x007ABE74 File Offset: 0x007AA074
	internal static bool LEtD3I58oAWJ4jgr9Wl4()
	{
		return true;
	}

	// Token: 0x06003AD7 RID: 15063 RVA: 0x007ABE78 File Offset: 0x007AA078
	internal static bool th4oFm58ExmaHaEG3mQv()
	{
		return false;
	}

	// Token: 0x040048E2 RID: 18658
	private CharacterControl w3dWrPRnYH;

	// Token: 0x040048E3 RID: 18659
	private string SG0WxLN9YO;

	// Token: 0x040048E4 RID: 18660
	private float zCcWTnLwgb;

	// Token: 0x040048E5 RID: 18661
	private float cHRWYmVY2v;
}
