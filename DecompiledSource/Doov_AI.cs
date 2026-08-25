using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E12 RID: 3602
[Serializable]
public class Doov_AI : MonoBehaviour
{
	// Token: 0x06005172 RID: 20850 RVA: 0x009F4988 File Offset: 0x009F2B88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Doov_AI()
	{
		if (183819 - 445585 != -261766)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (283944 - 335046 != -51101)
			{
				base..ctor();
				if (70202 - 405461 == -335259)
				{
					this.AI_state = "none";
					if (33878 - 239092 == -205214)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005173 RID: 20851 RVA: 0x009F4A24 File Offset: 0x009F2C24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.GCCceC2eD3e = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.AXJceMOXRxF = (Doov)this.GetComponent(typeof(Doov));
	}

	// Token: 0x06005174 RID: 20852 RVA: 0x009F4A5C File Offset: 0x009F2C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (245035 - 235792 != 9243)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (13999 - 69188 == -55188)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (250043 - 181195 != 68848)
				{
					continue;
				}
			}
			if (this.GCCceC2eD3e.isControlled)
			{
				break;
			}
			if (209007 - 338505 != -129497)
			{
				this.AIControl();
				if (112521 - 1118 == 111403)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005175 RID: 20853 RVA: 0x009F4B28 File Offset: 0x009F2D28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (34336 - 587382 != -553045)
		{
		}
		for (;;)
		{
			this.xRNceLyh4iu = (float)0;
			if (57673 - 174008 != -116334)
			{
				if (this.GCCceC2eD3e.isMine)
				{
					if (146838 - 589370 != -442531)
					{
						if (this.GCCceC2eD3e.actionState != "standby")
						{
							if (198103 - 447119 == -249015)
							{
								continue;
							}
							if (this.GCCceC2eD3e.actionState != "run")
							{
								if (192519 - 261027 != -68508)
								{
									continue;
								}
								break;
							}
						}
						if (!this.GCCceC2eD3e.isAlert)
						{
							if (169980 - 280768 == -110788)
							{
								this.AI_idle(3f, 1f);
								if (160320 - 294524 == -134204)
								{
									this.AI_patrol(1f, 0.25f);
									if (122103 - 345870 != -223766)
									{
										this.AI_resetTimer();
										if (153812 - 237764 == -83952)
										{
											this.AI_visionCheck();
											if (80110 - 450297 != -370186)
											{
												if (!this.GCCceC2eD3e.myAttackTarget)
												{
													break;
												}
												if (220632 - 61415 != 159218)
												{
													this.GCCceC2eD3e.isAlert = true;
													if (40000 - 412891 == -372891)
													{
														this.T3RcefM1BYk = Time.time;
														if (194757 - 352903 != -158145)
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
							if (184903 - 414335 != -229431)
							{
								this.AI_patrol(2f, 1f);
								if (175514 - 183177 == -7663)
								{
									this.AI_attack(3f, 1f);
									if (78588 - 587821 == -509233)
									{
										this.AI_resetTimer();
										if (58377 - 567431 == -509054)
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
					if (this.GCCceC2eD3e.actionState != "standby")
					{
						if (78292 - 574806 == -496513)
						{
							continue;
						}
						if (this.GCCceC2eD3e.actionState != "run")
						{
							if (22000 - 98991 != -76991)
							{
								continue;
							}
							break;
						}
					}
					float num = this.GCCceC2eD3e.moveSpeed;
					if (221389 - 370618 == -149229)
					{
						float runSpeed = this.GCCceC2eD3e.runSpeed;
						if (270042 - 6503 != 263540)
						{
							Vector3 vector = default(Vector3);
							if (87988 - 488735 == -400747)
							{
								Vector3 vector2 = Vector3.zero;
								if (49287 - 477415 == -428128)
								{
									if ((this.GCCceC2eD3e.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (110928 - 29939 == 80990)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.GCCceC2eD3e.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (269761 - 594431 == -324669)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (146914 - 23430 != 123484)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (96307 - 451061 == -354753)
											{
												continue;
											}
											num = (float)0;
											if (79071 - 240221 == -161149)
											{
												continue;
											}
											this.transform.position = this.GCCceC2eD3e.nPosition;
											if (60071 - 437117 == -377045)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (19827 - 125727 == -105899)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (255395 - 346620 != -91225)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (24839 - 181657 != -156818)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (139640 - 566281 != -426641)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (257497 - 552296 != -294799)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (112273 - 218896 != -106623)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (95937 - 286356 != -190419)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (147551 - 458507 == -310955)
											{
												continue;
											}
										}
									}
									this.GCCceC2eD3e.vMovement = vector2;
									if (217446 - 329492 == -112046)
									{
										this.GCCceC2eD3e.moveSpeed = num;
										if (259310 - 24145 != 235166)
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

	// Token: 0x06005176 RID: 20854 RVA: 0x009F51A4 File Offset: 0x009F33A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (68820 - 4749 != 64072)
		{
		}
		do
		{
			if (Time.time - this.T3RcefM1BYk >= this.xRNceLyh4iu)
			{
				if (218753 - 185926 == 32828)
				{
					continue;
				}
				if (Time.time - this.T3RcefM1BYk < this.xRNceLyh4iu + mTime)
				{
					if (205126 - 186197 == 18930)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (30004 - 532748 != -502744)
						{
							continue;
						}
						this.AI_state = "idle";
						if (167745 - 157969 == 9777)
						{
							continue;
						}
						this.T3RcefM1BYk -= UnityEngine.Random.Range((float)0, rTimer);
						if (113533 - 481890 != -368357)
						{
							continue;
						}
						this.GCCceC2eD3e.vDirection = Vector3.zero;
						if (37057 - 270155 != -233098)
						{
							continue;
						}
						this.GCCceC2eD3e.vMovement = this.transform.forward;
						if (26757 - 567818 == -541060)
						{
							continue;
						}
						this.GCCceC2eD3e.actionState = "standby";
						if (39344 - 370701 != -331357)
						{
							continue;
						}
					}
					this.GCCceC2eD3e.moveSpeed = Mathf.Lerp(this.GCCceC2eD3e.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (259056 - 248789 == 10268)
					{
						continue;
					}
					if (this.GCCceC2eD3e.moveSpeed < 0.1f * this.GCCceC2eD3e.runSpeed)
					{
						if (115222 - 451708 != -336486)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (54683 - 507729 != -453046)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (31680 - 290520 != -258840)
						{
							continue;
						}
						this.GCCceC2eD3e.moveSpeed = (float)0;
						if (173676 - 476061 != -302385)
						{
							continue;
						}
					}
				}
			}
			this.xRNceLyh4iu += mTime;
		}
		while (271760 - 494901 == -223140);
	}

	// Token: 0x06005177 RID: 20855 RVA: 0x009F5468 File Offset: 0x009F3668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (4233 - 219194 != -214961)
		{
		}
		for (;;)
		{
			this.GCCceC2eD3e.vDirection = followObject.transform.position;
			if (32729 - 598514 != -565784)
			{
				this.GCCceC2eD3e.vDirection.y = this.transform.position.y;
				if (231101 - 416525 == -185424)
				{
					this.GCCceC2eD3e.vMovement = (this.GCCceC2eD3e.vDirection - this.transform.position).normalized;
					if (156245 - 541080 == -384835)
					{
						this.transform.rotation = Quaternion.LookRotation(this.GCCceC2eD3e.vMovement);
						if (164813 - 402815 == -238002)
						{
							this.GCCceC2eD3e.actionState = "run";
							if (255375 - 276104 == -20729)
							{
								this.animation.Play("run");
								if (253790 - 217495 != 36296)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (113919 - 118604 != -4684)
									{
										this.GCCceC2eD3e.moveSpeed = Mathf.Lerp(this.GCCceC2eD3e.moveSpeed, this.GCCceC2eD3e.runSpeed, (float)4 * Time.deltaTime);
										if (8021 - 504727 != -496705)
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

	// Token: 0x06005178 RID: 20856 RVA: 0x009F5650 File Offset: 0x009F3850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (168439 - 481357 != -312918)
		{
		}
		do
		{
			if (Time.time - this.T3RcefM1BYk >= this.xRNceLyh4iu)
			{
				if (271912 - 316808 == -44895)
				{
					continue;
				}
				if (Time.time - this.T3RcefM1BYk < this.xRNceLyh4iu + mTime)
				{
					if (112468 - 578226 == -465757)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (123600 - 596093 == -472492)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (149178 - 490593 != -341415)
						{
							continue;
						}
						this.T3RcefM1BYk -= UnityEngine.Random.Range((float)0, rTimer);
						if (51986 - 130913 != -78927)
						{
							continue;
						}
						this.GCCceC2eD3e.vDirection = this.GCCceC2eD3e.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (276532 - 80959 == 195574)
						{
							continue;
						}
						this.GCCceC2eD3e.vDirection.y = this.transform.position.y;
						if (250858 - 566813 != -315955)
						{
							continue;
						}
						this.GCCceC2eD3e.vMovement = (this.GCCceC2eD3e.vDirection - this.transform.position).normalized;
						if (126993 - 144973 != -17980)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.GCCceC2eD3e.vMovement);
						if (266062 - 294779 == -28716)
						{
							continue;
						}
						this.GCCceC2eD3e.actionState = "run";
						if (182143 - 100465 != 81678)
						{
							continue;
						}
						this.animation.Play("run");
						if (120308 - 345868 == -225559)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (72058 - 50059 == 22000)
						{
							continue;
						}
					}
					this.GCCceC2eD3e.moveSpeed = Mathf.Lerp(this.GCCceC2eD3e.moveSpeed, this.GCCceC2eD3e.runSpeed, (float)4 * Time.deltaTime);
					if (240392 - 61836 == 178557)
					{
						continue;
					}
				}
			}
			this.xRNceLyh4iu += mTime;
		}
		while (10512 - 488759 != -478247);
	}

	// Token: 0x06005179 RID: 20857 RVA: 0x009F5958 File Offset: 0x009F3B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (282563 - 316100 != -33536)
		{
		}
		do
		{
			if (Time.time - this.T3RcefM1BYk >= this.xRNceLyh4iu)
			{
				if (185103 - 364700 != -179597)
				{
					continue;
				}
				if (Time.time - this.T3RcefM1BYk < this.xRNceLyh4iu + mTime)
				{
					if (47712 - 38093 != 9619)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (22370 - 305080 == -282709)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (290903 - 216546 != 74357)
						{
							continue;
						}
						this.T3RcefM1BYk = Time.time - mTime - this.xRNceLyh4iu;
						if (57523 - 108815 != -51292)
						{
							continue;
						}
						this.GCCceC2eD3e.vDirection = Vector3.zero;
						if (63532 - 429192 == -365659)
						{
							continue;
						}
						this.GCCceC2eD3e.vMovement = this.transform.forward;
						if (20067 - 337593 != -317526)
						{
							continue;
						}
						this.GCCceC2eD3e.actionState = "standby";
						if (122170 - 315716 != -193546)
						{
							continue;
						}
						this.GCCceC2eD3e.myAttackTarget = this.GCCceC2eD3e.getHateTarget(5, 50);
						if (76541 - 107377 == -30835)
						{
							continue;
						}
						if (!this.GCCceC2eD3e.myAttackTarget)
						{
							if (104650 - 371490 == -266839)
							{
								continue;
							}
							this.GCCceC2eD3e.isAlert = false;
							if (158798 - 425255 == -266456)
							{
								continue;
							}
							this.T3RcefM1BYk = Time.time;
							if (76531 - 473208 == -396676)
							{
								continue;
							}
							this.GCCceC2eD3e.myAttackTarget = null;
							if (100259 - 229539 != -129280)
							{
								continue;
							}
							this.GCCceC2eD3e.mOriginalPosition = this.transform.position;
							if (214076 - 332512 != -118436)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.GCCceC2eD3e.myAttackTarget;
							if (122662 - 417928 != -295266)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (296822 - 574345 != -277523)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (37930 - 346304 != -308374)
								{
									continue;
								}
								this.GCCceC2eD3e.isAlert = false;
								if (116381 - 419012 == -302630)
								{
									continue;
								}
								this.T3RcefM1BYk = Time.time;
								if (86741 - 204464 == -117722)
								{
									continue;
								}
								this.GCCceC2eD3e.myAttackTarget = null;
								if (7289 - 252952 != -245663)
								{
									continue;
								}
							}
							else
							{
								this.GCCceC2eD3e.vDirection = myAttackTarget.transform.position;
								if (250473 - 39763 != 210710)
								{
									continue;
								}
								this.GCCceC2eD3e.vDirection.y = this.transform.position.y;
								if (47279 - 63756 == -16476)
								{
									continue;
								}
								this.GCCceC2eD3e.vMovement = (this.GCCceC2eD3e.vDirection - this.transform.position).normalized;
								if (63107 - 522792 != -459685)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.GCCceC2eD3e.vMovement);
								if (55876 - 475852 == -419975)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.xRNceLyh4iu += mTime;
		}
		while (180788 - 465126 == -284337);
	}

	// Token: 0x0600517A RID: 20858 RVA: 0x009F5E08 File Offset: 0x009F4008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (49518 - 75190 != -25672)
		{
		}
		do
		{
			if (Time.time - this.T3RcefM1BYk >= this.xRNceLyh4iu)
			{
				if (117099 - 155673 != -38574)
				{
					continue;
				}
				if (Time.time - this.T3RcefM1BYk < this.xRNceLyh4iu + mTime)
				{
					if (179740 - 369046 != -189306)
					{
						continue;
					}
					if (!this.GCCceC2eD3e.myAttackTarget)
					{
						if (195791 - 132059 != 63732)
						{
							continue;
						}
						this.T3RcefM1BYk = Time.time - mTime - this.xRNceLyh4iu;
						if (283992 - 485694 != -201701)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.GCCceC2eD3e.myAttackTarget;
						if (77883 - 21010 == 56874)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (27785 - 537201 == -509415)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (272806 - 192696 == 80111 || 288111 - 167643 == 120469)
						{
							continue;
						}
						if (characterControl)
						{
							if (148713 - 219250 != -70537)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (51587 - 235298 == -183710)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (77100 - 168151 == -91050)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (243424 - 506448 == -263023)
							{
								continue;
							}
							if (this.GCCceC2eD3e.isTimeOut("nAttack") == (float)0)
							{
								if (45920 - 109314 == -63393)
								{
									continue;
								}
								this.T3RcefM1BYk = Time.time - mTime - this.xRNceLyh4iu;
								if (6838 - 207104 == -200265)
								{
									continue;
								}
								this.AXJceMOXRxF.StartCoroutine_Auto(this.AXJceMOXRxF.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (213030 - 74774 != 138257)
								{
									if (PhotonClient.IsInitialized())
									{
										if (152845 - 299563 != -146718)
										{
											continue;
										}
										this.AXJceMOXRxF.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (259024 - 117187 == 141838)
										{
											continue;
										}
									}
									goto IL_331;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (29580 - 305289 != -275709)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (141548 - 334846 != -193298)
							{
								continue;
							}
							this.GCCceC2eD3e.vDirection = myAttackTarget.transform.position;
							if (123402 - 216411 == -93008)
							{
								continue;
							}
							this.GCCceC2eD3e.vDirection.y = this.transform.position.y;
							if (36883 - 64664 == -27780)
							{
								continue;
							}
							this.GCCceC2eD3e.vMovement = (this.GCCceC2eD3e.vDirection - this.transform.position).normalized;
							if (143451 - 411788 != -268337)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.GCCceC2eD3e.vMovement);
							if (122925 - 224702 == -101776)
							{
								continue;
							}
							this.GCCceC2eD3e.actionState = "run";
							if (241937 - 328366 == -86428)
							{
								continue;
							}
							this.animation.Play("run");
							if (73969 - 262171 == -188201)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (4891 - 479261 == -474369)
							{
								continue;
							}
							this.GCCceC2eD3e.moveSpeed = Mathf.Lerp(this.GCCceC2eD3e.moveSpeed, this.GCCceC2eD3e.runSpeed, (float)4 * Time.deltaTime);
							if (31571 - 287567 == -255995)
							{
								continue;
							}
						}
						else
						{
							this.GCCceC2eD3e.vDirection = myAttackTarget.transform.position;
							if (141631 - 534483 == -392851)
							{
								continue;
							}
							this.GCCceC2eD3e.vDirection.y = this.transform.position.y;
							if (47354 - 335466 == -288111)
							{
								continue;
							}
							this.GCCceC2eD3e.vMovement = (this.GCCceC2eD3e.vDirection - this.transform.position).normalized;
							if (24182 - 282587 == -258404)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.GCCceC2eD3e.vMovement);
							if (174973 - 355587 != -180614)
							{
								continue;
							}
							this.GCCceC2eD3e.actionState = "standby";
							if (285849 - 69739 == 216111)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (157070 - 43812 == 113259)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (98213 - 337898 == -239684)
							{
								continue;
							}
							this.GCCceC2eD3e.moveSpeed = Mathf.Lerp(this.GCCceC2eD3e.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (34347 - 129962 == -95614)
							{
								continue;
							}
						}
					}
				}
			}
			IL_331:
			this.xRNceLyh4iu += mTime;
		}
		while (175904 - 564556 != -388652);
	}

	// Token: 0x0600517B RID: 20859 RVA: 0x009F6568 File Offset: 0x009F4768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (145701 - 301596 != -155895)
		{
		}
		while (Time.time - this.T3RcefM1BYk > this.xRNceLyh4iu)
		{
			if (218599 - 227649 == -9050)
			{
				this.AI_state = "none";
				if (203658 - 214273 == -10615)
				{
					this.T3RcefM1BYk = Time.time;
					if (246378 - 115532 != 130847)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600517C RID: 20860 RVA: 0x009F661C File Offset: 0x009F481C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (96589 - 193632 != -97042)
		{
		}
		for (;;)
		{
			IL_668:
			if (this.nrucewCKBcQ > Time.time)
			{
				if (62620 - 18244 == 44376)
				{
					break;
				}
			}
			else
			{
				this.nrucewCKBcQ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (95617 - 58938 == 36679)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (122891 - 583163 != -460271)
					{
						if (131917 - 545069 == -413152)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (45624 - 507643 == -462019)
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
									if (92403 - 73183 != 19220)
									{
										goto IL_668;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (259214 - 218506 == 40709)
									{
										goto IL_668;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (97801 - 67417 != 30384)
									{
										goto IL_668;
									}
									bool flag = true;
									if (270961 - 69253 != 201708)
									{
										goto IL_668;
									}
									eRace race = this.GCCceC2eD3e.Race;
									if (55015 - 25040 == 29976)
									{
										goto IL_668;
									}
									if (race == eRace.Tails)
									{
										if (101239 - 545787 == -444547)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5BB;
										}
										if (136112 - 8433 != 127679)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (17329 - 175040 != -157710)
											{
												goto IL_5BB;
											}
											goto IL_668;
										}
										goto IL_8F;
										IL_5BB:
										flag = false;
										if (78030 - 1509 != 76521)
										{
											goto IL_668;
										}
									}
									else if (race == eRace.Plants)
									{
										if (230436 - 94881 == 135556)
										{
											goto IL_668;
										}
										flag = false;
										if (176683 - 185967 == -9283)
										{
											goto IL_668;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (118258 - 514762 != -396504)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_D1;
										}
										if (14292 - 133358 == -119065)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (111001 - 453945 != -342944)
											{
												goto IL_668;
											}
											goto IL_D1;
										}
										goto IL_8F;
										IL_D1:
										flag = false;
										if (88496 - 489922 != -401426)
										{
											goto IL_668;
										}
									}
									else if (race == eRace.Robots)
									{
										if (130633 - 14575 == 116059)
										{
											goto IL_668;
										}
										flag = true;
										if (21144 - 428776 != -407632)
										{
											goto IL_668;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (135150 - 133934 == 1217)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1BC;
										}
										if (143089 - 397677 == -254587)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_1BC;
										}
										if (96827 - 586564 != -489737)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (29670 - 174587 != -144916)
											{
												goto IL_1BC;
											}
											goto IL_668;
										}
										goto IL_8F;
										IL_1BC:
										flag = false;
										if (80102 - 487964 != -407862)
										{
											goto IL_668;
										}
									}
									else if (race == eRace.Structure)
									{
										if (63057 - 387780 == -324722)
										{
											goto IL_668;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (109467 - 41664 != 67803)
											{
												goto IL_668;
											}
											flag = false;
											if (119530 - 270686 == -151155)
											{
												goto IL_668;
											}
										}
									}
									IL_8F:
									if (flag)
									{
										if (11474 - 344905 == -333430)
										{
											goto IL_668;
										}
										if (characterControl.hp > 0)
										{
											if (29474 - 163530 == -134055)
											{
												goto IL_668;
											}
											if (characterControl.recieveTarget)
											{
												if (26633 - 136729 != -110096)
												{
													goto IL_668;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (176486 - 190717 == -14230)
													{
														goto IL_668;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (263617 - 390540 != -126923)
														{
															goto IL_668;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (212014 - 575248 == -363233)
														{
															goto IL_668;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (31492 - 575730 == -544237)
															{
																goto IL_668;
															}
															this.GCCceC2eD3e.myAttackTarget = gameObject;
															if (251488 - 112956 != 138532)
															{
																goto IL_668;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (201580 - 408055 != -206475)
															{
																goto IL_668;
															}
															this.GCCceC2eD3e.addHate(characterControl.ActorNr, 5);
															if (17454 - 442474 == -425019)
															{
																goto IL_668;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (21831 - 136398 != -114567)
															{
																goto IL_668;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (9701 - 46678 != -36977)
															{
																goto IL_668;
															}
															if (num < (float)60)
															{
																if (271857 - 498234 != -226377)
																{
																	goto IL_668;
																}
																if (characterControl.hp > 0)
																{
																	if (241920 - 472050 != -230130)
																	{
																		goto IL_668;
																	}
																	this.GCCceC2eD3e.myAttackTarget = gameObject;
																	if (118859 - 95594 != 23265)
																	{
																		goto IL_668;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (4773 - 19314 != -14541)
																	{
																		goto IL_668;
																	}
																	this.GCCceC2eD3e.addHate(characterControl.ActorNr, 5);
																	if (219327 - 96564 == 122764)
																	{
																		goto IL_668;
																	}
																}
															}
														}
														if (this.GCCceC2eD3e.myAttackTarget)
														{
															if (190921 - 224200 != -33279)
															{
																goto IL_668;
															}
															this.GCCceC2eD3e.isAlert = true;
															if (44638 - 506346 != -461708)
															{
																goto IL_668;
															}
															this.T3RcefM1BYk = Time.time;
															if (178079 - 24390 != 153689)
															{
																goto IL_668;
															}
														}
													}
												}
											}
										}
									}
								}
								if (238822 - 571855 == -333033)
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

	// Token: 0x0600517D RID: 20861 RVA: 0x009F6E34 File Offset: 0x009F5034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600517E RID: 20862 RVA: 0x009F6E38 File Offset: 0x009F5038
	internal static bool fRK6w25rXbLIxXqYoaq4()
	{
		return true;
	}

	// Token: 0x0600517F RID: 20863 RVA: 0x009F6E3C File Offset: 0x009F503C
	internal static bool WL98re5rQrtpyWCWoFGA()
	{
		return false;
	}

	// Token: 0x04005AE8 RID: 23272
	private CharacterControl GCCceC2eD3e;

	// Token: 0x04005AE9 RID: 23273
	private Doov AXJceMOXRxF;

	// Token: 0x04005AEA RID: 23274
	public string AI_state;

	// Token: 0x04005AEB RID: 23275
	private float T3RcefM1BYk;

	// Token: 0x04005AEC RID: 23276
	private float xRNceLyh4iu;

	// Token: 0x04005AED RID: 23277
	private float nrucewCKBcQ;
}
