using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A8D RID: 2701
[Serializable]
public class PumpkonAI : MonoBehaviour
{
	// Token: 0x06003B7D RID: 15229 RVA: 0x007B9AA8 File Offset: 0x007B7CA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PumpkonAI()
	{
		if (210315 - 412748 != -202432)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (124418 - 57920 == 66498)
			{
				base..ctor();
				if (95350 - 241407 != -146056)
				{
					this.AI_state = "none";
					if (176111 - 98708 == 77403)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B7E RID: 15230 RVA: 0x007B9B44 File Offset: 0x007B7D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.nZJWPj4ZVl = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.SEwWSowKSQ = (Pumpkon)this.GetComponent(typeof(Pumpkon));
	}

	// Token: 0x06003B7F RID: 15231 RVA: 0x007B9B7C File Offset: 0x007B7D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (!this.nZJWPj4ZVl.isControlled)
		{
			this.AIControl();
		}
	}

	// Token: 0x06003B80 RID: 15232 RVA: 0x007B9B94 File Offset: 0x007B7D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (272296 - 577220 != -304923)
		{
		}
		for (;;)
		{
			this.Kr5W0LnPxQ = (float)0;
			if (248113 - 537129 == -289016)
			{
				if (this.nZJWPj4ZVl.isMine)
				{
					if (11174 - 38749 != -27574)
					{
						if (this.nZJWPj4ZVl.actionState != "standby")
						{
							if (202064 - 553826 != -351762)
							{
								continue;
							}
							if (this.nZJWPj4ZVl.actionState != "run")
							{
								if (235408 - 21077 != 214331)
								{
									continue;
								}
								break;
							}
						}
						if (!this.nZJWPj4ZVl.isAlert)
						{
							if (180482 - 217833 == -37351)
							{
								this.AI_idle(2f, 1f);
								if (103057 - 515360 == -412303)
								{
									this.AI_patrol(3f, 2f);
									if (262556 - 147115 != 115442)
									{
										this.AI_resetTimer();
										if (40148 - 377138 == -336990)
										{
											if (!this.nZJWPj4ZVl.myAttackTarget)
											{
												break;
											}
											if (280815 - 522850 == -242035)
											{
												this.nZJWPj4ZVl.isAlert = true;
												if (184250 - 286315 != -102064)
												{
													this.UojWBBKMCr = Time.time;
													if (161062 - 460541 != -299478)
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
							this.AI_attack(5f, (float)0);
							if (47637 - 87330 == -39693)
							{
								this.AI_resetAlert();
								if (71098 - 93723 != -22624)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (this.nZJWPj4ZVl.actionState != "standby")
					{
						if (217819 - 508036 == -290216)
						{
							continue;
						}
						if (this.nZJWPj4ZVl.actionState != "run")
						{
							if (192448 - 542867 != -350418)
							{
								break;
							}
							continue;
						}
					}
					if (this.nZJWPj4ZVl.nSpeed != (float)0)
					{
						if (242907 - 404835 == -161927)
						{
							continue;
						}
						if (this.nZJWPj4ZVl.nPosition != this.nZJWPj4ZVl.oPosition)
						{
							if (258480 - 105064 != 153416)
							{
								continue;
							}
							Vector3 a = this.nZJWPj4ZVl.nPosition + 0.1f * this.nZJWPj4ZVl.runSpeed * this.nZJWPj4ZVl.nDirection;
							if (218230 - 547771 == -329540)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (248962 - 391879 == -142916)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (254996 - 356407 != -101411)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (117319 - 290231 != -172912)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (202335 - 105286 == 97050)
							{
								continue;
							}
							if (magnitude > this.nZJWPj4ZVl.runSpeed)
							{
								if (18791 - 589655 != -570864)
								{
									continue;
								}
								this.transform.position = this.nZJWPj4ZVl.nPosition;
								if (94405 - 23375 != 71030)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.nZJWPj4ZVl.runSpeed)
							{
								if (80330 - 260880 == -180549)
								{
									continue;
								}
								this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, 1.1f * this.nZJWPj4ZVl.runSpeed, (float)10 * Time.deltaTime);
								if (229148 - 535137 != -305989)
								{
									continue;
								}
								this.nZJWPj4ZVl.vDirection = normalized;
								if (207714 - 83661 != 124053)
								{
									continue;
								}
								this.nZJWPj4ZVl.vMovement = normalized;
								if (18925 - 379209 == -360283)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (235312 - 546455 == -311142)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (139650 - 515345 == -375694)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (188933 - 337107 == -148173)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (3219 - 248924 == -245704)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (101241 - 408986 != -307744)
								{
									break;
								}
								continue;
							}
							else
							{
								this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (147695 - 24325 == 123371)
								{
									continue;
								}
								this.nZJWPj4ZVl.vDirection = normalized;
								if (6893 - 146689 != -139796)
								{
									continue;
								}
								this.nZJWPj4ZVl.vMovement = normalized;
								if (178582 - 346698 == -168115)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (213706 - 113553 == 100154)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (62225 - 235462 != -173237)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.nZJWPj4ZVl.moveSpeed != (float)0)
					{
						if (158813 - 281376 == -122563)
						{
							Vector3 vector3 = global::Math.vFlat(this.nZJWPj4ZVl.nPosition - this.transform.position);
							if (192033 - 30512 == 161521)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (247976 - 308499 != -60522)
								{
									if (sqrMagnitude > this.nZJWPj4ZVl.runSpeed)
									{
										if (123147 - 230777 == -107630)
										{
											this.transform.position = this.nZJWPj4ZVl.nPosition;
											if (65825 - 596573 == -530748)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (20862 - 277668 != -256805)
										{
											if (sqrMagnitude > (float)1)
											{
												if (221080 - 467135 != -246055)
												{
													continue;
												}
												this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, this.nZJWPj4ZVl.runSpeed, (float)10 * Time.deltaTime);
												if (49457 - 400067 == -350609)
												{
													continue;
												}
											}
											else
											{
												this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (71554 - 428497 == -356942)
												{
													continue;
												}
											}
											this.nZJWPj4ZVl.vMovement = vector3;
											if (30370 - 223425 == -193055)
											{
												this.nZJWPj4ZVl.vDirection = vector3;
												if (192220 - 543810 != -351589)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (273530 - 278701 != -5170)
													{
														this.animation.CrossFade("run", 0.2f);
														if (232810 - 231061 == 1749)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (185747 - 20670 != 165078)
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
										this.nZJWPj4ZVl.vMovement = vector3;
										if (44582 - 412798 == -368216)
										{
											this.nZJWPj4ZVl.moveSpeed = (float)0;
											if (218769 - 461799 != -243029)
											{
												this.transform.rotation = Quaternion.LookRotation(this.nZJWPj4ZVl.vDirection);
												if (85260 - 310456 != -225195)
												{
													this.animation.CrossFade("root", 0.2f);
													if (255718 - 360290 != -104571)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (249238 - 438007 == -188769)
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
						if (256809 - 279595 == -22786)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (122248 - 351427 == -229179)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B81 RID: 15233 RVA: 0x007BA6A4 File Offset: 0x007B88A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (228309 - 554210 != -325900)
		{
		}
		do
		{
			if (Time.time - this.UojWBBKMCr >= this.Kr5W0LnPxQ)
			{
				if (196914 - 593217 != -396303)
				{
					continue;
				}
				if (Time.time - this.UojWBBKMCr < this.Kr5W0LnPxQ + mTime)
				{
					if (75089 - 404203 != -329114)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (80555 - 372138 != -291583)
						{
							continue;
						}
						this.AI_state = "idle";
						if (8574 - 410123 != -401549)
						{
							continue;
						}
						this.UojWBBKMCr -= UnityEngine.Random.Range((float)0, rTimer);
						if (104906 - 505940 == -401033)
						{
							continue;
						}
						this.nZJWPj4ZVl.vDirection = Vector3.zero;
						if (79223 - 121778 != -42555)
						{
							continue;
						}
						this.nZJWPj4ZVl.vMovement = this.transform.forward;
						if (136158 - 534127 == -397968)
						{
							continue;
						}
						this.nZJWPj4ZVl.actionState = "standby";
						if (15517 - 581524 == -566006)
						{
							continue;
						}
					}
					this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (220670 - 222176 == -1505)
					{
						continue;
					}
					if (this.nZJWPj4ZVl.moveSpeed < 0.1f * this.nZJWPj4ZVl.runSpeed)
					{
						if (56779 - 590881 == -534101)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (100069 - 587130 != -487061)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (45295 - 202735 != -157440)
						{
							continue;
						}
						this.nZJWPj4ZVl.moveSpeed = (float)0;
						if (253120 - 464536 != -211416)
						{
							continue;
						}
					}
				}
			}
			this.Kr5W0LnPxQ += mTime;
		}
		while (207579 - 374322 != -166743);
	}

	// Token: 0x06003B82 RID: 15234 RVA: 0x007BA968 File Offset: 0x007B8B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (55314 - 142499 != -87184)
		{
		}
		do
		{
			if (Time.time - this.UojWBBKMCr >= this.Kr5W0LnPxQ)
			{
				if (43919 - 354306 != -310387)
				{
					continue;
				}
				if (Time.time - this.UojWBBKMCr < this.Kr5W0LnPxQ + mTime)
				{
					if (274972 - 66551 != 208421)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (231936 - 26764 != 205172)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (155369 - 62826 == 92544)
						{
							continue;
						}
						this.UojWBBKMCr -= UnityEngine.Random.Range((float)0, rTimer);
						if (44007 - 19359 == 24649)
						{
							continue;
						}
						this.nZJWPj4ZVl.vDirection = this.nZJWPj4ZVl.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (107518 - 43094 == 64425)
						{
							continue;
						}
						this.nZJWPj4ZVl.vDirection.y = this.transform.position.y;
						if (231891 - 225787 == 6105)
						{
							continue;
						}
						this.nZJWPj4ZVl.vMovement = (this.nZJWPj4ZVl.vDirection - this.transform.position).normalized;
						if (45585 - 561877 == -516291)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.nZJWPj4ZVl.vMovement);
						if (239564 - 510552 == -270987)
						{
							continue;
						}
						this.nZJWPj4ZVl.actionState = "run";
						if (144043 - 514917 != -370874)
						{
							continue;
						}
						this.animation.Play("run");
						if (141583 - 203071 != -61488)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (248576 - 90535 == 158042)
						{
							continue;
						}
					}
					this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, this.nZJWPj4ZVl.runSpeed, (float)4 * Time.deltaTime);
					if (7273 - 75974 == -68700)
					{
						continue;
					}
				}
			}
			this.Kr5W0LnPxQ += mTime;
		}
		while (266475 - 158753 == 107723);
	}

	// Token: 0x06003B83 RID: 15235 RVA: 0x007BAC70 File Offset: 0x007B8E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (51387 - 158577 != -107190)
		{
		}
		do
		{
			if (Time.time - this.UojWBBKMCr >= this.Kr5W0LnPxQ)
			{
				if (265012 - 18439 == 246574)
				{
					continue;
				}
				if (Time.time - this.UojWBBKMCr < this.Kr5W0LnPxQ + mTime)
				{
					if (226725 - 10291 == 216435)
					{
						continue;
					}
					if (!this.nZJWPj4ZVl.myAttackTarget)
					{
						if (293480 - 570212 != -276732)
						{
							continue;
						}
						this.nZJWPj4ZVl.isAlert = false;
						if (136134 - 565893 != -429759)
						{
							continue;
						}
						this.UojWBBKMCr = Time.time;
						if (265200 - 485830 == -220629)
						{
							continue;
						}
						this.nZJWPj4ZVl.myAttackTarget = null;
						if (286460 - 242784 != 43676)
						{
							continue;
						}
						this.nZJWPj4ZVl.mOriginalPosition = this.transform.position;
						if (254338 - 446283 != -191945)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.nZJWPj4ZVl.myAttackTarget;
						if (108799 - 480153 == -371353)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (77828 - 381927 == -304098)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (238039 - 466850 != -228811)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (163220 - 161078 != 2142)
							{
								continue;
							}
							if (this.nZJWPj4ZVl.isTimeOut("nAttack") == (float)0)
							{
								if (74089 - 573363 == -499273)
								{
									continue;
								}
								this.UojWBBKMCr = Time.time - mTime - this.Kr5W0LnPxQ;
								if (133361 - 314272 == -180910)
								{
									continue;
								}
								this.SEwWSowKSQ.StartCoroutine_Auto(this.SEwWSowKSQ.RPC_nAttack(this.transform.position, vector, 0));
								if (100171 - 182880 != -82708)
								{
									if (PhotonClient.IsInitialized())
									{
										if (103887 - 513571 == -409683)
										{
											continue;
										}
										this.SEwWSowKSQ.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (168506 - 538573 != -370067)
										{
											continue;
										}
									}
									goto IL_422;
								}
								continue;
							}
						}
						if (num > (float)12)
						{
							if (79976 - 367536 != -287560)
							{
								continue;
							}
							this.nZJWPj4ZVl.isAlert = false;
							if (49950 - 354759 == -304808)
							{
								continue;
							}
							this.UojWBBKMCr = Time.time;
							if (236142 - 68439 != 167703)
							{
								continue;
							}
							this.nZJWPj4ZVl.myAttackTarget = null;
							if (55227 - 579164 == -523936)
							{
								continue;
							}
							this.nZJWPj4ZVl.mOriginalPosition = this.transform.position;
							if (286129 - 522752 == -236622)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (27474 - 407606 != -380132)
							{
								continue;
							}
							this.nZJWPj4ZVl.vDirection = myAttackTarget.transform.position;
							if (290174 - 261507 == 28668)
							{
								continue;
							}
							this.nZJWPj4ZVl.vDirection.y = this.transform.position.y;
							if (18073 - 50609 != -32536)
							{
								continue;
							}
							this.nZJWPj4ZVl.vMovement = (this.transform.position - this.nZJWPj4ZVl.vDirection).normalized;
							if (212243 - 507104 != -294861)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.nZJWPj4ZVl.vMovement);
							if (191316 - 597359 == -406042)
							{
								continue;
							}
							this.nZJWPj4ZVl.actionState = "run";
							if (67091 - 354262 != -287171)
							{
								continue;
							}
							this.animation.Play("run");
							if (256134 - 527740 != -271606)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (31011 - 175793 == -144781)
							{
								continue;
							}
							this.nZJWPj4ZVl.moveSpeed = Mathf.Lerp(this.nZJWPj4ZVl.moveSpeed, this.nZJWPj4ZVl.runSpeed, (float)4 * Time.deltaTime);
							if (79423 - 556030 != -476607)
							{
								continue;
							}
						}
					}
				}
			}
			IL_422:
			this.Kr5W0LnPxQ += mTime;
		}
		while (178133 - 546536 != -368403);
	}

	// Token: 0x06003B84 RID: 15236 RVA: 0x007BB260 File Offset: 0x007B9460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetAlert()
	{
		if (220135 - 110997 != 109139)
		{
		}
		while (Time.time - this.UojWBBKMCr > this.Kr5W0LnPxQ)
		{
			if (138753 - 15243 == 123510)
			{
				this.nZJWPj4ZVl.isAlert = false;
				if (69007 - 276332 == -207325)
				{
					this.UojWBBKMCr = Time.time;
					if (34819 - 116502 != -81682)
					{
						this.nZJWPj4ZVl.myAttackTarget = null;
						if (88131 - 537928 != -449796)
						{
							this.nZJWPj4ZVl.mOriginalPosition = this.transform.position;
							if (163202 - 238636 != -75433)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B85 RID: 15237 RVA: 0x007BB36C File Offset: 0x007B956C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (816 - 119992 != -119175)
		{
		}
		while (Time.time - this.UojWBBKMCr > this.Kr5W0LnPxQ)
		{
			if (107098 - 471208 != -364109)
			{
				this.AI_state = "none";
				if (214148 - 570667 != -356518)
				{
					this.UojWBBKMCr = Time.time;
					if (84416 - 47827 != 36590)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B86 RID: 15238 RVA: 0x007BB420 File Offset: 0x007B9620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B87 RID: 15239 RVA: 0x007BB424 File Offset: 0x007B9624
	internal static bool j6PYvQ5ZcWrcC3FTrXbh()
	{
		return true;
	}

	// Token: 0x06003B88 RID: 15240 RVA: 0x007BB428 File Offset: 0x007B9628
	internal static bool KIiCVW5ZUWEcINtmIuUc()
	{
		return false;
	}

	// Token: 0x04004939 RID: 18745
	private CharacterControl nZJWPj4ZVl;

	// Token: 0x0400493A RID: 18746
	private Pumpkon SEwWSowKSQ;

	// Token: 0x0400493B RID: 18747
	public string AI_state;

	// Token: 0x0400493C RID: 18748
	private float UojWBBKMCr;

	// Token: 0x0400493D RID: 18749
	private float Kr5W0LnPxQ;
}
