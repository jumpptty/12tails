using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A9F RID: 2719
[Serializable]
public class SnowMupo_AI : MonoBehaviour
{
	// Token: 0x06003BF1 RID: 15345 RVA: 0x007C5278 File Offset: 0x007C3478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SnowMupo_AI()
	{
		if (33517 - 214930 != -181412)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (65620 - 538749 != -473128)
			{
				base..ctor();
				if (260335 - 41858 != 218478)
				{
					this.RluWAEfkmy = "none";
					if (298064 - 57295 != 240770)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003BF2 RID: 15346 RVA: 0x007C5314 File Offset: 0x007C3514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ABmWks5OLm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.z56WF6qX7i = (SnowMupo)this.GetComponent(typeof(SnowMupo));
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x007C534C File Offset: 0x007C354C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (296378 - 189336 != 107043)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (58986 - 320225 != -261239)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (178844 - 11036 != 167808)
				{
					continue;
				}
			}
			if (this.ABmWks5OLm.isControlled)
			{
				break;
			}
			if (115819 - 45957 == 69862)
			{
				this.AIControl();
				if (171345 - 210496 == -39151)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x007C5418 File Offset: 0x007C3618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (47661 - 234706 != -187044)
		{
		}
		for (;;)
		{
			this.oEGWWkhseN = (float)0;
			if (215232 - 456170 == -240938)
			{
				if (this.ABmWks5OLm.isMine)
				{
					if (294196 - 69094 == 225102)
					{
						if (this.ABmWks5OLm.actionState != "standby")
						{
							if (219950 - 79229 != 140721)
							{
								continue;
							}
							if (this.ABmWks5OLm.actionState != "run")
							{
								if (286999 - 467309 != -180310)
								{
									continue;
								}
								break;
							}
						}
						if (!this.ABmWks5OLm.isAlert)
						{
							if (243090 - 12077 == 231013)
							{
								this.AI_idle(5f, 3f);
								if (42609 - 351215 == -308606)
								{
									this.AI_patrol(5f, 3f);
									if (229904 - 885 == 229019)
									{
										this.AI_resetTimer();
										if (188330 - 71715 != 116616)
										{
											if (!this.ABmWks5OLm.myAttackTarget)
											{
												break;
											}
											if (142273 - 276014 != -133740)
											{
												this.ABmWks5OLm.isAlert = true;
												if (290129 - 487429 == -197300)
												{
													this.WI1W9CwI2t = Time.time;
													if (266809 - 322767 == -55958)
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
							this.AI_escape(3f, (float)0);
							if (233313 - 186826 == 46487)
							{
								this.AI_resetTimer();
								if (133192 - 279107 != -145914)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (this.ABmWks5OLm.actionState != "standby")
					{
						if (39936 - 37606 != 2330)
						{
							continue;
						}
						if (this.ABmWks5OLm.actionState != "run")
						{
							if (29500 - 357914 != -328414)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ABmWks5OLm.moveSpeed;
					if (36865 - 235405 == -198540)
					{
						float runSpeed = this.ABmWks5OLm.runSpeed;
						if (62719 - 302795 != -240075)
						{
							Vector3 vector = default(Vector3);
							if (291016 - 537165 != -246148)
							{
								Vector3 vector2 = Vector3.zero;
								if (191311 - 566940 == -375629)
								{
									if ((this.ABmWks5OLm.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (258901 - 286392 != -27491)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ABmWks5OLm.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (233111 - 274953 != -41842)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (5880 - 365851 != -359971)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (151629 - 376237 == -224607)
											{
												continue;
											}
											num = (float)0;
											if (128254 - 568854 != -440600)
											{
												continue;
											}
											this.transform.position = this.ABmWks5OLm.nPosition;
											if (183244 - 294287 == -111042)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (153170 - 553589 == -400418)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (232541 - 528494 != -295953)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (284242 - 184652 != 99590)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (295118 - 235250 == 59869)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (101430 - 2167 == 99264)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (227396 - 589422 != -362026)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (26265 - 319533 != -293268)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (154649 - 513582 != -358933)
											{
												continue;
											}
										}
									}
									this.ABmWks5OLm.vMovement = vector2;
									if (81046 - 284919 == -203873)
									{
										this.ABmWks5OLm.moveSpeed = num;
										if (205368 - 404889 == -199521)
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

	// Token: 0x06003BF5 RID: 15349 RVA: 0x007C5A20 File Offset: 0x007C3C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (161705 - 554956 != -393251)
		{
		}
		do
		{
			if (Time.time - this.WI1W9CwI2t >= this.oEGWWkhseN)
			{
				if (279665 - 332824 == -53158)
				{
					continue;
				}
				if (Time.time - this.WI1W9CwI2t < this.oEGWWkhseN + mTime)
				{
					if (162356 - 174288 == -11931)
					{
						continue;
					}
					if (this.RluWAEfkmy != "idle")
					{
						if (246151 - 6882 != 239269)
						{
							continue;
						}
						this.RluWAEfkmy = "idle";
						if (246103 - 238887 != 7216)
						{
							continue;
						}
						this.WI1W9CwI2t -= UnityEngine.Random.Range((float)0, rTimer);
						if (202570 - 261448 == -58877)
						{
							continue;
						}
						this.ABmWks5OLm.vDirection = Vector3.zero;
						if (198620 - 543133 == -344512)
						{
							continue;
						}
						this.ABmWks5OLm.vMovement = this.transform.forward;
						if (17167 - 185894 != -168727)
						{
							continue;
						}
						this.ABmWks5OLm.actionState = "standby";
						if (182813 - 376191 == -193377)
						{
							continue;
						}
					}
					this.ABmWks5OLm.moveSpeed = Mathf.Lerp(this.ABmWks5OLm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (29764 - 312815 == -283050)
					{
						continue;
					}
					if (this.ABmWks5OLm.moveSpeed < 0.1f * this.ABmWks5OLm.runSpeed)
					{
						if (267587 - 481408 == -213820)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (87228 - 48969 != 38259)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (6469 - 123174 != -116705)
						{
							continue;
						}
						this.ABmWks5OLm.moveSpeed = (float)0;
						if (154389 - 406367 == -251977)
						{
							continue;
						}
					}
				}
			}
			this.oEGWWkhseN += mTime;
		}
		while (242746 - 439140 != -196394);
	}

	// Token: 0x06003BF6 RID: 15350 RVA: 0x007C5CE4 File Offset: 0x007C3EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (83672 - 120261 != -36588)
		{
		}
		do
		{
			if (Time.time - this.WI1W9CwI2t >= this.oEGWWkhseN)
			{
				if (156890 - 565109 == -408218)
				{
					continue;
				}
				if (Time.time - this.WI1W9CwI2t < this.oEGWWkhseN + mTime)
				{
					if (174453 - 59276 != 115177)
					{
						continue;
					}
					if (this.RluWAEfkmy != "patrol")
					{
						if (192782 - 524575 == -331792)
						{
							continue;
						}
						this.RluWAEfkmy = "patrol";
						if (80418 - 563865 != -483447)
						{
							continue;
						}
						this.WI1W9CwI2t -= UnityEngine.Random.Range((float)0, rTimer);
						if (161030 - 114931 != 46099)
						{
							continue;
						}
						if (Game.mGameCode == 972)
						{
							if (141501 - 441551 == -300049)
							{
								continue;
							}
							this.ABmWks5OLm.vDirection = new Vector3((float)UnityEngine.Random.Range(-25, 15), this.transform.position.y, this.transform.position.z);
							if (281902 - 275914 != 5988)
							{
								continue;
							}
							this.ABmWks5OLm.vMovement = global::Math.vFlat(this.ABmWks5OLm.vDirection - this.transform.position).normalized;
							if (35045 - 360814 != -325769)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ABmWks5OLm.vMovement);
							if (69503 - 59528 == 9976)
							{
								continue;
							}
						}
						else
						{
							this.ABmWks5OLm.vDirection = this.ABmWks5OLm.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
							if (104447 - 57611 == 46837)
							{
								continue;
							}
							this.ABmWks5OLm.vMovement = global::Math.vFlat(this.ABmWks5OLm.vDirection - this.transform.position).normalized;
							if (202252 - 570903 == -368650)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ABmWks5OLm.vMovement);
							if (101535 - 183151 == -81615)
							{
								continue;
							}
						}
						this.ABmWks5OLm.actionState = "run";
						if (55273 - 218446 == -163172)
						{
							continue;
						}
						this.animation.Play("walk");
						if (216827 - 456601 == -239773)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (59646 - 447881 == -388234)
						{
							continue;
						}
					}
					this.ABmWks5OLm.moveSpeed = Mathf.Lerp(this.ABmWks5OLm.moveSpeed, this.ABmWks5OLm.runSpeed, (float)4 * Time.deltaTime);
					if (133646 - 266842 != -133196)
					{
						continue;
					}
				}
			}
			this.oEGWWkhseN += mTime;
		}
		while (298124 - 489879 == -191754);
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x007C60BC File Offset: 0x007C42BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_escape(float mTime, float rTimer)
	{
		if (196677 - 292547 != -95870)
		{
		}
		do
		{
			if (Time.time - this.WI1W9CwI2t >= this.oEGWWkhseN)
			{
				if (35988 - 71248 == -35259)
				{
					continue;
				}
				if (Time.time - this.WI1W9CwI2t < this.oEGWWkhseN + mTime)
				{
					if (264230 - 187617 != 76613)
					{
						continue;
					}
					if (!this.ABmWks5OLm.myAttackTarget)
					{
						if (61357 - 12169 == 49189)
						{
							continue;
						}
						this.ABmWks5OLm.isAlert = false;
						if (294701 - 44742 == 249960)
						{
							continue;
						}
						this.WI1W9CwI2t = Time.time;
						if (268541 - 476879 != -208338)
						{
							continue;
						}
						this.ABmWks5OLm.myAttackTarget = null;
						if (4889 - 515847 == -510957)
						{
							continue;
						}
						if (Game.mGameCode == 972)
						{
							break;
						}
						if (171211 - 580580 != -409369)
						{
							continue;
						}
						this.ABmWks5OLm.mOriginalPosition = this.transform.position;
						if (91080 - 39266 != 51814)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.ABmWks5OLm.myAttackTarget;
						if (102966 - 518402 == -415435)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(this.transform.position - myAttackTarget.transform.position);
						if (178180 - 89019 != 89161)
						{
							continue;
						}
						if (Game.mGameCode == 972)
						{
							if (2187 - 585370 != -583183)
							{
								continue;
							}
							vector = Vector3.Dot(Vector3.right, vector) * Vector3.right;
							if (81422 - 402061 == -320638)
							{
								continue;
							}
						}
						if (this.ABmWks5OLm.isTimeOut("escape") == (float)0)
						{
							if (181601 - 17802 == 163800)
							{
								continue;
							}
							this.WI1W9CwI2t = Time.time - mTime - this.oEGWWkhseN;
							if (67065 - 59610 != 7455)
							{
								continue;
							}
							this.ABmWks5OLm.myAttackTarget = null;
							if (258165 - 121035 != 137130)
							{
								continue;
							}
							this.z56WF6qX7i.StartCoroutine_Auto(this.z56WF6qX7i.RPC_escape(this.transform.position, vector, 0));
							if (52412 - 357333 == -304920)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (184135 - 294600 != -110465)
								{
									continue;
								}
								this.z56WF6qX7i.ActionEvent("RPC_escape", this.transform.position, vector, 0);
								if (279495 - 274945 == 4551)
								{
									continue;
								}
							}
						}
						else
						{
							this.RluWAEfkmy = "escape";
							if (184069 - 274489 != -90420)
							{
								continue;
							}
							this.ABmWks5OLm.vMovement = vector.normalized;
							if (259159 - 496433 == -237273)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.ABmWks5OLm.vMovement);
							if (93183 - 381057 == -287873)
							{
								continue;
							}
							this.ABmWks5OLm.actionState = "run";
							if (188776 - 483645 == -294868)
							{
								continue;
							}
							this.animation.Play("walk");
							if (50218 - 144311 != -94093)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (50060 - 493723 == -443662)
							{
								continue;
							}
							this.ABmWks5OLm.moveSpeed = Mathf.Lerp(this.ABmWks5OLm.moveSpeed, this.ABmWks5OLm.runSpeed, (float)4 * Time.deltaTime);
							if (43877 - 414875 == -370997)
							{
								continue;
							}
						}
					}
				}
			}
			this.oEGWWkhseN += mTime;
		}
		while (280112 - 157679 == 122434);
	}

	// Token: 0x06003BF8 RID: 15352 RVA: 0x007C65A4 File Offset: 0x007C47A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (22504 - 453001 != -430496)
		{
		}
		while (Time.time - this.WI1W9CwI2t > this.oEGWWkhseN)
		{
			if (25470 - 390144 == -364674)
			{
				this.RluWAEfkmy = "none";
				if (269934 - 43105 != 226830)
				{
					this.WI1W9CwI2t = Time.time;
					if (159926 - 489039 != -329112)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x007C6658 File Offset: 0x007C4858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x007C665C File Offset: 0x007C485C
	internal static bool qSaxdo5ZRHoDpNj2PYYK()
	{
		return true;
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x007C6660 File Offset: 0x007C4860
	internal static bool MaLxDN5ZwBYYQ9eY2hSv()
	{
		return false;
	}

	// Token: 0x0400498F RID: 18831
	private CharacterControl ABmWks5OLm;

	// Token: 0x04004990 RID: 18832
	private SnowMupo z56WF6qX7i;

	// Token: 0x04004991 RID: 18833
	private string RluWAEfkmy;

	// Token: 0x04004992 RID: 18834
	private float WI1W9CwI2t;

	// Token: 0x04004993 RID: 18835
	private float oEGWWkhseN;
}
