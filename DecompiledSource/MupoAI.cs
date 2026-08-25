using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A79 RID: 2681
[Serializable]
public class MupoAI : MonoBehaviour
{
	// Token: 0x06003AED RID: 15085 RVA: 0x007AD1DC File Offset: 0x007AB3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MupoAI()
	{
		if (36005 - 316388 != -280382)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (22356 - 454191 == -431835)
			{
				base..ctor();
				if (165407 - 1252 == 164155)
				{
					this.XOXWgx55pv = "none";
					if (217418 - 61301 == 156117)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003AEE RID: 15086 RVA: 0x007AD278 File Offset: 0x007AB478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.a3hWde5Ap7 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003AEF RID: 15087 RVA: 0x007AD298 File Offset: 0x007AB498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (39956 - 140930 != -100974)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (24769 - 568894 == -544124)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (108904 - 221539 != -112635)
				{
					continue;
				}
			}
			if (this.a3hWde5Ap7.isControlled)
			{
				break;
			}
			if (200255 - 306496 != -106240)
			{
				this.AIControl();
				if (105688 - 530135 == -424447)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003AF0 RID: 15088 RVA: 0x007AD364 File Offset: 0x007AB564
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (231766 - 485246 != -253480)
		{
		}
		for (;;)
		{
			this.xjXW4YD8xR = (float)0;
			if (29781 - 556727 == -526946)
			{
				if (this.a3hWde5Ap7.isMine)
				{
					if (236203 - 374800 != -138596)
					{
						if (this.a3hWde5Ap7.actionState != "standby")
						{
							if (289471 - 160462 == 129010)
							{
								continue;
							}
							if (this.a3hWde5Ap7.actionState != "run")
							{
								if (67756 - 488192 != -420436)
								{
									continue;
								}
								break;
							}
						}
						if (!this.a3hWde5Ap7.isAlert)
						{
							if (62201 - 300758 != -238556)
							{
								this.AI_idle(6f, 3f);
								if (247143 - 168544 != 78600)
								{
									this.AI_patrol(2f, 1f);
									if (64195 - 487275 != -423079)
									{
										this.AI_resetTimer();
										if (190749 - 398848 == -208099)
										{
											if (!this.a3hWde5Ap7.myAttackTarget)
											{
												break;
											}
											if (224217 - 119586 != 104632)
											{
												this.a3hWde5Ap7.isAlert = true;
												if (49724 - 142995 == -93271)
												{
													this.HXVWab0AkW = Time.time;
													if (138226 - 104287 != 33940)
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
							if (273477 - 142154 != 131324)
							{
								this.AI_escape(3f, (float)0);
								if (44365 - 140649 == -96284)
								{
									this.AI_resetTimer();
									if (166550 - 274552 != -108001)
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
					if (this.a3hWde5Ap7.actionState != "standby")
					{
						if (32341 - 245233 == -212891)
						{
							continue;
						}
						if (this.a3hWde5Ap7.actionState != "run")
						{
							if (58144 - 532313 != -474168)
							{
								break;
							}
							continue;
						}
					}
					float num = this.a3hWde5Ap7.moveSpeed;
					if (67827 - 541179 == -473352)
					{
						float runSpeed = this.a3hWde5Ap7.runSpeed;
						if (64900 - 14699 == 50201)
						{
							Vector3 vector = default(Vector3);
							if (222150 - 311542 == -89392)
							{
								Vector3 vector2 = Vector3.zero;
								if (199170 - 374845 == -175675)
								{
									if ((this.a3hWde5Ap7.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (280640 - 554984 == -274343)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.a3hWde5Ap7.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (125601 - 194103 == -68501)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (131713 - 249148 != -117435)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (112479 - 11902 != 100577)
											{
												continue;
											}
											num = (float)0;
											if (129981 - 553182 == -423200)
											{
												continue;
											}
											this.transform.position = this.a3hWde5Ap7.nPosition;
											if (265359 - 514143 == -248783)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (116649 - 17835 == 98815)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (245159 - 526056 == -280896)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (74987 - 264164 == -189176)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (23955 - 450387 == -426431)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (148785 - 530781 == -381995)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (15767 - 467704 == -451936)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (148617 - 489982 != -341365)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (134693 - 369999 == -235305)
											{
												continue;
											}
										}
									}
									this.a3hWde5Ap7.vMovement = vector2;
									if (225928 - 116480 != 109449)
									{
										this.a3hWde5Ap7.moveSpeed = num;
										if (69647 - 404267 != -334619)
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

	// Token: 0x06003AF1 RID: 15089 RVA: 0x007AD990 File Offset: 0x007ABB90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (224134 - 413106 != -188972)
		{
		}
		do
		{
			if (Time.time - this.HXVWab0AkW >= this.xjXW4YD8xR)
			{
				if (18471 - 393395 == -374923)
				{
					continue;
				}
				if (Time.time - this.HXVWab0AkW < this.xjXW4YD8xR + mTime)
				{
					if (246481 - 462357 == -215875)
					{
						continue;
					}
					if (this.XOXWgx55pv != "idle")
					{
						if (198283 - 521716 != -323433)
						{
							continue;
						}
						this.XOXWgx55pv = "idle";
						if (57912 - 11040 == 46873)
						{
							continue;
						}
						this.HXVWab0AkW -= UnityEngine.Random.Range((float)0, rTimer);
						if (287643 - 366528 == -78884)
						{
							continue;
						}
						this.a3hWde5Ap7.vDirection = Vector3.zero;
						if (126352 - 135848 == -9495)
						{
							continue;
						}
						this.a3hWde5Ap7.vMovement = this.transform.forward;
						if (89095 - 431210 != -342115)
						{
							continue;
						}
						this.a3hWde5Ap7.actionState = "standby";
						if (297559 - 324732 == -27172)
						{
							continue;
						}
					}
					this.a3hWde5Ap7.moveSpeed = Mathf.Lerp(this.a3hWde5Ap7.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (238560 - 225240 != 13320)
					{
						continue;
					}
					if (this.a3hWde5Ap7.moveSpeed < 0.1f * this.a3hWde5Ap7.runSpeed)
					{
						if (13755 - 193207 != -179452)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (205735 - 157576 != 48159)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (269397 - 129085 == 140313)
						{
							continue;
						}
						this.a3hWde5Ap7.moveSpeed = (float)0;
						if (21042 - 531491 != -510449)
						{
							continue;
						}
					}
				}
			}
			this.xjXW4YD8xR += mTime;
		}
		while (66432 - 335694 == -269261);
	}

	// Token: 0x06003AF2 RID: 15090 RVA: 0x007ADC54 File Offset: 0x007ABE54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (97049 - 242635 != -145585)
		{
		}
		do
		{
			if (Time.time - this.HXVWab0AkW >= this.xjXW4YD8xR)
			{
				if (18688 - 509390 != -490702)
				{
					continue;
				}
				if (Time.time - this.HXVWab0AkW < this.xjXW4YD8xR + mTime)
				{
					if (89711 - 502347 != -412636)
					{
						continue;
					}
					if (this.XOXWgx55pv != "patrol")
					{
						if (38928 - 9069 != 29859)
						{
							continue;
						}
						this.XOXWgx55pv = "patrol";
						if (162092 - 252412 == -90319)
						{
							continue;
						}
						this.HXVWab0AkW -= UnityEngine.Random.Range((float)0, rTimer);
						if (10723 - 33856 != -23133)
						{
							continue;
						}
						this.a3hWde5Ap7.vDirection = this.a3hWde5Ap7.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (60296 - 36322 != 23974)
						{
							continue;
						}
						this.a3hWde5Ap7.vDirection.y = this.transform.position.y;
						if (235066 - 236019 != -953)
						{
							continue;
						}
						this.a3hWde5Ap7.vMovement = (this.a3hWde5Ap7.vDirection - this.transform.position).normalized;
						if (167843 - 598040 != -430197)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.a3hWde5Ap7.vMovement);
						if (231531 - 309575 == -78043)
						{
							continue;
						}
						this.a3hWde5Ap7.actionState = "run";
						if (92108 - 69009 == 23100)
						{
							continue;
						}
						this.animation.Play("walk");
						if (77746 - 453294 == -375547)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (61778 - 426678 == -364899)
						{
							continue;
						}
					}
					this.a3hWde5Ap7.moveSpeed = Mathf.Lerp(this.a3hWde5Ap7.moveSpeed, 0.5f * this.a3hWde5Ap7.runSpeed, (float)4 * Time.deltaTime);
					if (173726 - 73543 == 100184)
					{
						continue;
					}
				}
			}
			this.xjXW4YD8xR += mTime;
		}
		while (80626 - 97176 != -16550);
	}

	// Token: 0x06003AF3 RID: 15091 RVA: 0x007ADF60 File Offset: 0x007AC160
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (280848 - 145977 != 134871)
		{
		}
		do
		{
			if (Time.time - this.HXVWab0AkW >= this.xjXW4YD8xR)
			{
				if (58425 - 374125 != -315700)
				{
					continue;
				}
				if (Time.time - this.HXVWab0AkW < this.xjXW4YD8xR + mTime)
				{
					if (202601 - 168599 != 34002)
					{
						continue;
					}
					if (this.XOXWgx55pv != "selectTarget")
					{
						if (173296 - 98410 != 74886)
						{
							continue;
						}
						this.XOXWgx55pv = "selectTarget";
						if (189809 - 137438 == 52372)
						{
							continue;
						}
						this.HXVWab0AkW = Time.time - mTime - this.xjXW4YD8xR;
						if (194814 - 458999 != -264185)
						{
							continue;
						}
						this.a3hWde5Ap7.vDirection = Vector3.zero;
						if (208118 - 582280 != -374162)
						{
							continue;
						}
						this.a3hWde5Ap7.vMovement = this.transform.forward;
						if (60642 - 155696 != -95054)
						{
							continue;
						}
						this.a3hWde5Ap7.actionState = "standby";
						if (265884 - 103510 == 162375)
						{
							continue;
						}
						this.a3hWde5Ap7.myAttackTarget = this.a3hWde5Ap7.getHateTarget(5, 12);
						if (169335 - 248427 == -79091)
						{
							continue;
						}
						if (!this.a3hWde5Ap7.myAttackTarget)
						{
							if (130235 - 4129 == 126107)
							{
								continue;
							}
							this.a3hWde5Ap7.isAlert = false;
							if (112381 - 81109 != 31272)
							{
								continue;
							}
							this.HXVWab0AkW = Time.time;
							if (144812 - 50995 == 93818)
							{
								continue;
							}
							this.a3hWde5Ap7.myAttackTarget = null;
							if (229004 - 111747 != 117257)
							{
								continue;
							}
							this.a3hWde5Ap7.mOriginalPosition = this.transform.position;
							if (213148 - 81032 != 132117)
							{
								break;
							}
							continue;
						}
					}
				}
			}
			this.xjXW4YD8xR += mTime;
		}
		while (73056 - 342270 == -269213);
	}

	// Token: 0x06003AF4 RID: 15092 RVA: 0x007AE234 File Offset: 0x007AC434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_escape(float mTime, float rTimer)
	{
		if (105451 - 129241 != -23789)
		{
		}
		do
		{
			if (Time.time - this.HXVWab0AkW >= this.xjXW4YD8xR)
			{
				if (293688 - 153309 == 140380)
				{
					continue;
				}
				if (Time.time - this.HXVWab0AkW < this.xjXW4YD8xR + mTime)
				{
					if (123384 - 289579 == -166194)
					{
						continue;
					}
					if (!this.a3hWde5Ap7.myAttackTarget)
					{
						if (74380 - 58760 == 15621)
						{
							continue;
						}
						this.a3hWde5Ap7.isAlert = false;
						if (258783 - 90165 == 168619)
						{
							continue;
						}
						this.HXVWab0AkW = Time.time;
						if (59495 - 185161 != -125666)
						{
							continue;
						}
						this.a3hWde5Ap7.myAttackTarget = null;
						if (230214 - 490834 != -260620)
						{
							continue;
						}
						this.a3hWde5Ap7.mOriginalPosition = this.transform.position;
						if (194863 - 586017 != -391154)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.a3hWde5Ap7.myAttackTarget;
						if (22879 - 564080 == -541200)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(this.transform.position - myAttackTarget.transform.position);
						if (11412 - 101482 == -90069)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (116935 - 305610 != -188675)
						{
							continue;
						}
						this.XOXWgx55pv = "escape";
						if (289818 - 493858 != -204040)
						{
							continue;
						}
						this.a3hWde5Ap7.vMovement = vector.normalized;
						if (136550 - 591678 == -455127)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.a3hWde5Ap7.vMovement);
						if (68414 - 299206 != -230792)
						{
							continue;
						}
						this.a3hWde5Ap7.actionState = "run";
						if (145707 - 181893 == -36185)
						{
							continue;
						}
						this.animation.Play("run");
						if (276200 - 87771 == 188430)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (220570 - 490590 != -270020)
						{
							continue;
						}
						this.a3hWde5Ap7.moveSpeed = Mathf.Lerp(this.a3hWde5Ap7.moveSpeed, this.a3hWde5Ap7.runSpeed, (float)4 * Time.deltaTime);
						if (230153 - 436546 == -206392)
						{
							continue;
						}
					}
				}
			}
			this.xjXW4YD8xR += mTime;
		}
		while (51507 - 453412 != -401905);
	}

	// Token: 0x06003AF5 RID: 15093 RVA: 0x007AE5B8 File Offset: 0x007AC7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (53023 - 303223 != -250200)
		{
		}
		while (Time.time - this.HXVWab0AkW > this.xjXW4YD8xR)
		{
			if (229893 - 37808 != 192086)
			{
				this.XOXWgx55pv = "none";
				if (145685 - 491228 == -345543)
				{
					this.HXVWab0AkW = Time.time;
					if (211396 - 160373 == 51023)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003AF6 RID: 15094 RVA: 0x007AE66C File Offset: 0x007AC86C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003AF7 RID: 15095 RVA: 0x007AE670 File Offset: 0x007AC870
	internal static bool TSNVfY58mJmsBnKD1b3S()
	{
		return true;
	}

	// Token: 0x06003AF8 RID: 15096 RVA: 0x007AE674 File Offset: 0x007AC874
	internal static bool zRKOaI58FCegUmSJh7tL()
	{
		return false;
	}

	// Token: 0x040048F1 RID: 18673
	private CharacterControl a3hWde5Ap7;

	// Token: 0x040048F2 RID: 18674
	private string XOXWgx55pv;

	// Token: 0x040048F3 RID: 18675
	private float HXVWab0AkW;

	// Token: 0x040048F4 RID: 18676
	private float xjXW4YD8xR;
}
