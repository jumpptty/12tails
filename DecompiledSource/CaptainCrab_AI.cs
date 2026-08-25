using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BAE RID: 2990
[Serializable]
public class CaptainCrab_AI : MonoBehaviour
{
	// Token: 0x0600429D RID: 17053 RVA: 0x00865A70 File Offset: 0x00863C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CaptainCrab_AI()
	{
		if (128073 - 511221 != -383147)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (13297 - 128142 == -114845)
			{
				base..ctor();
				if (11549 - 463187 != -451637)
				{
					this.AI_state = "none";
					if (23557 - 462239 == -438682)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600429E RID: 17054 RVA: 0x00865B0C File Offset: 0x00863D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.uMCVSQfk9v = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.RDrVBt6SSJ = (CaptainCrab)this.GetComponent(typeof(CaptainCrab));
	}

	// Token: 0x0600429F RID: 17055 RVA: 0x00865B44 File Offset: 0x00863D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (22816 - 370580 != -347763)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (299210 - 108385 == 190826)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (282926 - 350567 == -67640)
				{
					continue;
				}
			}
			if (this.uMCVSQfk9v.isControlled)
			{
				break;
			}
			if (80284 - 460466 != -380181)
			{
				this.AIControl();
				if (191039 - 574798 == -383759)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060042A0 RID: 17056 RVA: 0x00865C10 File Offset: 0x00863E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (223146 - 153124 != 70023)
		{
		}
		for (;;)
		{
			this.pW3V8I917W = (float)0;
			if (248634 - 121815 == 126819)
			{
				if (this.uMCVSQfk9v.isMine)
				{
					if (22341 - 373968 == -351627)
					{
						if (this.uMCVSQfk9v.actionState != "standby")
						{
							if (169000 - 17433 == 151568)
							{
								continue;
							}
							if (this.uMCVSQfk9v.actionState != "run")
							{
								if (134070 - 203396 != -69326)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode == 973)
						{
							if (84299 - 273410 != -189111)
							{
								continue;
							}
							if (Game.mGameStage == 9)
							{
								if (1997 - 140676 == -138678)
								{
									continue;
								}
								if (!this.uMCVSQfk9v.isAlert)
								{
									if (51089 - 319237 == -268147)
									{
										continue;
									}
									this.AI_sail(9f, 3f);
									if (277613 - 7314 != 270299)
									{
										continue;
									}
									this.AI_resetTimer();
									if (49930 - 551644 == -501713)
									{
										continue;
									}
									this.AI_visionCheck();
									if (39146 - 489603 == -450456)
									{
										continue;
									}
									if (!this.uMCVSQfk9v.myAttackTarget)
									{
										break;
									}
									if (41847 - 146913 != -105066)
									{
										continue;
									}
									this.uMCVSQfk9v.isAlert = true;
									if (78438 - 486405 != -407967)
									{
										continue;
									}
									this.fr8V0A67Ny = Time.time;
									if (116183 - 207989 != -91806)
									{
										continue;
									}
									break;
								}
								else
								{
									this.AI_selectTarget(1f, (float)0);
									if (14778 - 174888 != -160110)
									{
										continue;
									}
									this.AI_sail(3f, 1f);
									if (233289 - 95236 != 138053)
									{
										continue;
									}
									this.AI_sailAttack(6f, (float)0);
									if (14569 - 219306 != -204737)
									{
										continue;
									}
									this.AI_resetTimer();
									if (210268 - 472244 != -261975)
									{
										break;
									}
									continue;
								}
							}
						}
						if (!this.uMCVSQfk9v.isAlert)
						{
							if (19176 - 481042 != -461865)
							{
								this.AI_idle(3f, 1f);
								if (110169 - 391862 == -281693)
								{
									this.AI_patrol(1f, 0.25f);
									if (270862 - 411787 == -140925)
									{
										this.AI_resetTimer();
										if (152837 - 271596 == -118759)
										{
											this.AI_visionCheck();
											if (283839 - 110092 != 173748)
											{
												if (!this.uMCVSQfk9v.myAttackTarget)
												{
													break;
												}
												if (37263 - 154122 != -116858)
												{
													this.uMCVSQfk9v.isAlert = true;
													if (13410 - 277300 == -263890)
													{
														this.fr8V0A67Ny = Time.time;
														if (50228 - 405345 != -355116)
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
							if (145139 - 417443 != -272303)
							{
								this.AI_idle(1f, 1f);
								if (108917 - 574017 == -465100)
								{
									this.AI_attack(6f, (float)0);
									if (293935 - 106443 == 187492)
									{
										this.AI_resetTimer();
										if (272937 - 324990 == -52053)
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
					if (this.uMCVSQfk9v.actionState != "standby")
					{
						if (218888 - 42807 != 176081)
						{
							continue;
						}
						if (this.uMCVSQfk9v.actionState != "run")
						{
							if (281066 - 45560 != 235506)
							{
								continue;
							}
							break;
						}
					}
					float num = this.uMCVSQfk9v.moveSpeed;
					if (184520 - 480655 != -296134)
					{
						float runSpeed = this.uMCVSQfk9v.runSpeed;
						if (113361 - 198734 != -85372)
						{
							Vector3 vector = default(Vector3);
							if (273594 - 250845 != 22750)
							{
								Vector3 vector2 = Vector3.zero;
								if (188331 - 573856 != -385524)
								{
									if ((this.uMCVSQfk9v.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (229812 - 471960 != -242148)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.uMCVSQfk9v.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (278666 - 569289 != -290623)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (30803 - 399106 != -368303)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (65066 - 236270 == -171203)
											{
												continue;
											}
											num = (float)0;
											if (165172 - 349036 != -183864)
											{
												continue;
											}
											this.transform.position = this.uMCVSQfk9v.nPosition;
											if (159185 - 359881 != -200696)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (83444 - 275943 == -192498)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (35058 - 594386 != -559328)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (61549 - 291413 == -229863)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (85701 - 187504 == -101802)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (241046 - 322262 != -81216)
											{
												continue;
											}
										}
										else
										{
											if (Game.mGameCode == 973)
											{
												if (177629 - 489944 != -312315)
												{
													continue;
												}
												if (Game.mGameStage == 9)
												{
													if (183542 - 354642 != -171100)
													{
														continue;
													}
													vector2 = -Vector3.forward;
													if (124064 - 35979 == 88086)
													{
														continue;
													}
													this.animation.CrossFade("sail", 0.2f);
													if (131314 - 553082 == -421767)
													{
														continue;
													}
													this.animation.wrapMode = WrapMode.Loop;
													if (16420 - 34030 == -17609)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(vector2);
													if (38305 - 131148 != -92842)
													{
														goto IL_1E6;
													}
													continue;
												}
											}
											vector2 = this.transform.forward;
											if (177585 - 128235 == 49351)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (30243 - 520809 != -490566)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (115947 - 29307 == 86641)
											{
												continue;
											}
										}
									}
									IL_1E6:
									this.uMCVSQfk9v.vMovement = vector2;
									if (105404 - 418179 != -312774)
									{
										this.uMCVSQfk9v.moveSpeed = num;
										if (1407 - 472036 == -470629)
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

	// Token: 0x060042A1 RID: 17057 RVA: 0x00866580 File Offset: 0x00864780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (14245 - 542019 != -527773)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (23294 - 78035 != -54741)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (84284 - 194527 != -110243)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (144027 - 220547 == -76519)
						{
							continue;
						}
						this.AI_state = "idle";
						if (293476 - 435211 != -141735)
						{
							continue;
						}
						this.fr8V0A67Ny -= UnityEngine.Random.Range((float)0, rTimer);
						if (180332 - 47444 == 132889)
						{
							continue;
						}
						this.uMCVSQfk9v.vDirection = Vector3.zero;
						if (211544 - 142324 == 69221)
						{
							continue;
						}
						this.uMCVSQfk9v.vMovement = this.transform.forward;
						if (264840 - 266143 != -1303)
						{
							continue;
						}
						this.uMCVSQfk9v.actionState = "standby";
						if (179469 - 300156 != -120687)
						{
							continue;
						}
					}
					this.uMCVSQfk9v.moveSpeed = Mathf.Lerp(this.uMCVSQfk9v.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (149213 - 477185 != -327972)
					{
						continue;
					}
					if (this.uMCVSQfk9v.moveSpeed < 0.1f * this.uMCVSQfk9v.runSpeed)
					{
						if (114140 - 448959 != -334819)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (264949 - 412593 != -147644)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (74601 - 236690 == -162088)
						{
							continue;
						}
						this.uMCVSQfk9v.moveSpeed = (float)0;
						if (116795 - 61578 != 55217)
						{
							continue;
						}
					}
				}
			}
			this.pW3V8I917W += mTime;
		}
		while (204088 - 373128 != -169040);
	}

	// Token: 0x060042A2 RID: 17058 RVA: 0x00866844 File Offset: 0x00864A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_sail(float mTime, float rTimer)
	{
		if (235807 - 526728 != -290920)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (271488 - 544311 == -272822)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (227958 - 283772 != -55814)
					{
						continue;
					}
					if (this.AI_state != "sail")
					{
						if (268314 - 49017 == 219298)
						{
							continue;
						}
						this.AI_state = "sail";
						if (201231 - 597076 != -395845)
						{
							continue;
						}
						this.fr8V0A67Ny -= UnityEngine.Random.Range((float)0, rTimer);
						if (144055 - 255136 != -111081)
						{
							continue;
						}
						this.uMCVSQfk9v.vDirection = Vector3.zero;
						if (224890 - 412270 != -187380)
						{
							continue;
						}
						this.uMCVSQfk9v.vMovement = -Vector3.forward;
						if (3619 - 593215 == -589595)
						{
							continue;
						}
						this.uMCVSQfk9v.actionState = "standby";
						if (246066 - 240793 == 5274)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
						if (13333 - 49771 == -36437)
						{
							continue;
						}
					}
					this.uMCVSQfk9v.moveSpeed = Mathf.Lerp(this.uMCVSQfk9v.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (210441 - 442152 != -231711)
					{
						continue;
					}
					if (this.uMCVSQfk9v.moveSpeed < 0.1f * this.uMCVSQfk9v.runSpeed)
					{
						if (29878 - 128142 == -98263)
						{
							continue;
						}
						this.animation.CrossFade("sail", 0.2f);
						if (128994 - 335322 != -206328)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (163861 - 291359 != -127498)
						{
							continue;
						}
						this.uMCVSQfk9v.moveSpeed = (float)0;
						if (243087 - 535418 == -292330)
						{
							continue;
						}
					}
				}
			}
			this.pW3V8I917W += mTime;
		}
		while (52055 - 357788 == -305732);
	}

	// Token: 0x060042A3 RID: 17059 RVA: 0x00866B3C File Offset: 0x00864D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (271619 - 147766 != 123854)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (271692 - 151866 == 119827)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (211472 - 344474 == -133001)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (282759 - 529905 != -247146)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (81679 - 590582 != -508903)
						{
							continue;
						}
						this.fr8V0A67Ny -= UnityEngine.Random.Range((float)0, rTimer);
						if (247277 - 33234 != 214043)
						{
							continue;
						}
						this.uMCVSQfk9v.vDirection = this.uMCVSQfk9v.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (198209 - 259947 == -61737)
						{
							continue;
						}
						this.uMCVSQfk9v.vDirection.y = this.transform.position.y;
						if (219834 - 36560 == 183275)
						{
							continue;
						}
						this.uMCVSQfk9v.vMovement = (this.uMCVSQfk9v.vDirection - this.transform.position).normalized;
						if (28272 - 74343 == -46070)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
						if (180923 - 308351 != -127428)
						{
							continue;
						}
						this.uMCVSQfk9v.actionState = "run";
						if (49500 - 400911 == -351410)
						{
							continue;
						}
						this.animation.Play("run");
						if (65442 - 578167 != -512725)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (229133 - 125651 == 103483)
						{
							continue;
						}
					}
					this.uMCVSQfk9v.moveSpeed = Mathf.Lerp(this.uMCVSQfk9v.moveSpeed, this.uMCVSQfk9v.runSpeed, (float)4 * Time.deltaTime);
					if (65272 - 454929 != -389657)
					{
						continue;
					}
				}
			}
			this.pW3V8I917W += mTime;
		}
		while (203780 - 32291 == 171490);
	}

	// Token: 0x060042A4 RID: 17060 RVA: 0x00866E44 File Offset: 0x00865044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (110849 - 575704 != -464855)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (270388 - 6480 == 263909)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (176274 - 401188 != -224914)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (204131 - 242949 != -38818)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (188822 - 318088 != -129266)
						{
							continue;
						}
						this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
						if (297682 - 208552 != 89130)
						{
							continue;
						}
						this.uMCVSQfk9v.vDirection = Vector3.zero;
						if (283357 - 76510 == 206848)
						{
							continue;
						}
						this.uMCVSQfk9v.vMovement = this.transform.forward;
						if (167108 - 69022 != 98086)
						{
							continue;
						}
						this.uMCVSQfk9v.actionState = "standby";
						if (288501 - 419670 == -131168)
						{
							continue;
						}
						this.uMCVSQfk9v.myAttackTarget = this.uMCVSQfk9v.getHateTarget(5, 50);
						if (130604 - 56880 == 73725)
						{
							continue;
						}
						if (!this.uMCVSQfk9v.myAttackTarget)
						{
							if (192365 - 217152 != -24787)
							{
								continue;
							}
							this.uMCVSQfk9v.isAlert = false;
							if (92440 - 518691 == -426250)
							{
								continue;
							}
							this.fr8V0A67Ny = Time.time;
							if (160169 - 472859 != -312690)
							{
								continue;
							}
							this.uMCVSQfk9v.myAttackTarget = null;
							if (142878 - 364038 == -221159)
							{
								continue;
							}
							this.uMCVSQfk9v.mOriginalPosition = this.transform.position;
							if (259594 - 465888 != -206293)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.uMCVSQfk9v.myAttackTarget;
							if (292859 - 35249 != 257610)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (120627 - 523388 != -402761)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (119429 - 296928 != -177499)
								{
									continue;
								}
								this.uMCVSQfk9v.isAlert = false;
								if (4196 - 94963 != -90767)
								{
									continue;
								}
								this.fr8V0A67Ny = Time.time;
								if (136179 - 495364 != -359185)
								{
									continue;
								}
								this.uMCVSQfk9v.myAttackTarget = null;
								if (123716 - 438992 != -315276)
								{
									continue;
								}
							}
							else
							{
								this.uMCVSQfk9v.vDirection = myAttackTarget.transform.position;
								if (108385 - 391205 != -282820)
								{
									continue;
								}
								this.uMCVSQfk9v.vDirection.y = this.transform.position.y;
								if (266399 - 206042 == 60358)
								{
									continue;
								}
								this.uMCVSQfk9v.vMovement = (this.uMCVSQfk9v.vDirection - this.transform.position).normalized;
								if (108059 - 78302 != 29757)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
								if (192641 - 170956 == 21686)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.pW3V8I917W += mTime;
		}
		while (22117 - 409460 == -387342);
	}

	// Token: 0x060042A5 RID: 17061 RVA: 0x008672F4 File Offset: 0x008654F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (33608 - 33078 != 531)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (295393 - 333896 != -38503)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (11415 - 285147 == -273731)
					{
						continue;
					}
					if (!this.uMCVSQfk9v.myAttackTarget)
					{
						if (290669 - 70436 == 220234)
						{
							continue;
						}
						this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
						if (155165 - 115860 != 39306)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.uMCVSQfk9v.myAttackTarget;
						if (211399 - 271109 == -59709)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (268362 - 278043 == -9680)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (131787 - 337993 == -206205)
						{
							continue;
						}
						int tID = 0;
						if (191495 - 284690 != -93195)
						{
							continue;
						}
						if (characterControl)
						{
							if (240833 - 94392 == 146442)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (14576 - 502668 != -488092)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (136078 - 584980 != -448902)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (230048 - 168351 != 61697)
							{
								continue;
							}
							if (this.uMCVSQfk9v.sp >= 45)
							{
								if (248235 - 228212 == 20024)
								{
									continue;
								}
								if (this.uMCVSQfk9v.isTimeOut("cAttack") == (float)0)
								{
									if (177113 - 512962 != -335849)
									{
										continue;
									}
									this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
									if (83541 - 470111 == -386569)
									{
										continue;
									}
									this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_cAttack(this.transform.position, vector, 0));
									if (238690 - 458011 != -219321)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (111201 - 531882 != -420681)
										{
											continue;
										}
										this.RDrVBt6SSJ.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (104669 - 86496 == 18174)
										{
											continue;
										}
									}
									goto IL_D9;
								}
							}
						}
						if (num < (float)3)
						{
							if (166630 - 215732 != -49102)
							{
								continue;
							}
							if (this.uMCVSQfk9v.isTimeOut("nAttack1") == (float)0)
							{
								if (187178 - 352393 == -165214)
								{
									continue;
								}
								if (this.uMCVSQfk9v.isTimeOut("nAttack2") == (float)0)
								{
									if (231055 - 353029 != -121974)
									{
										continue;
									}
									this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
									if (167780 - 67357 != 100423)
									{
										continue;
									}
									if (UnityEngine.Random.Range(0, 100) <= 50)
									{
										if (14560 - 531317 != -516757)
										{
											continue;
										}
										this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack1(this.transform.position, vector, 0));
										if (197704 - 456202 == -258497)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (43130 - 92140 != -49010)
											{
												continue;
											}
											this.RDrVBt6SSJ.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
											if (108625 - 19008 != 89617)
											{
												continue;
											}
										}
									}
									else
									{
										this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack2(this.transform.position, vector, 0));
										if (266404 - 117192 != 149212)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (255383 - 369060 != -113677)
											{
												continue;
											}
											this.RDrVBt6SSJ.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (149452 - 482501 != -333049)
											{
												continue;
											}
										}
									}
									goto IL_D9;
								}
							}
						}
						if (num < (float)3)
						{
							if (173953 - 411933 != -237980)
							{
								continue;
							}
							if (this.uMCVSQfk9v.isTimeOut("nAttack1") == (float)0)
							{
								if (130968 - 296131 != -165163)
								{
									continue;
								}
								this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
								if (298560 - 313633 != -15073)
								{
									continue;
								}
								this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack1(this.transform.position, vector, 0));
								if (278446 - 133855 != 144592)
								{
									if (PhotonClient.IsInitialized())
									{
										if (212606 - 309761 == -97154)
										{
											continue;
										}
										this.RDrVBt6SSJ.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
										if (155463 - 198062 == -42598)
										{
											continue;
										}
									}
									goto IL_D9;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (195673 - 247963 != -52290)
							{
								continue;
							}
							if (this.uMCVSQfk9v.isTimeOut("nAttack2") == (float)0)
							{
								if (259102 - 428466 == -169363)
								{
									continue;
								}
								this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
								if (64959 - 84943 != -19984)
								{
									continue;
								}
								this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack2(this.transform.position, vector, 0));
								if (33399 - 224884 != -191485)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (174399 - 320432 != -146033)
									{
										continue;
									}
									this.RDrVBt6SSJ.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
									if (115958 - 239926 == -123967)
									{
										continue;
									}
								}
								goto IL_D9;
							}
						}
						if (this.pW3V8I917W + mTime - (Time.time - this.fr8V0A67Ny) <= (float)1)
						{
							if (169994 - 247286 == -77291)
							{
								continue;
							}
							this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
							if (226139 - 109930 != 116209)
							{
								continue;
							}
							if ((float)this.uMCVSQfk9v.hp < 0.5f * (float)this.uMCVSQfk9v.mhp)
							{
								if (142328 - 295999 == -153670)
								{
									continue;
								}
								if (this.uMCVSQfk9v.isTimeOut("kitchenDrop") == (float)0)
								{
									if (212954 - 255284 == -42329)
									{
										continue;
									}
									this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_kitchenDrop(this.transform.position, vector, tID));
									if (15611 - 294754 != -279142)
									{
										if (PhotonClient.IsInitialized())
										{
											if (76555 - 524786 == -448230)
											{
												continue;
											}
											this.RDrVBt6SSJ.ActionEvent("RPC_kitchenDrop", this.transform.position, vector, tID);
											if (4553 - 524622 != -520069)
											{
												continue;
											}
										}
										goto IL_9E6;
									}
									continue;
								}
							}
							this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_foodDrop(this.transform.position, vector, tID));
							if (298121 - 544081 == -245959)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (166132 - 222992 != -56860)
								{
									continue;
								}
								this.RDrVBt6SSJ.ActionEvent("RPC_foodDrop", this.transform.position, vector, tID);
								if (167923 - 83467 != 84456)
								{
									continue;
								}
							}
							IL_9E6:;
						}
						else
						{
							this.AI_state = "attack";
							if (182424 - 184493 == -2068)
							{
								continue;
							}
							if (num > 2.4f)
							{
								if (16273 - 482078 != -465805)
								{
									continue;
								}
								this.uMCVSQfk9v.vDirection = myAttackTarget.transform.position;
								if (191997 - 429181 == -237183)
								{
									continue;
								}
								this.uMCVSQfk9v.vDirection.y = this.transform.position.y;
								if (185117 - 326103 == -140985)
								{
									continue;
								}
								this.uMCVSQfk9v.vMovement = (this.uMCVSQfk9v.vDirection - this.transform.position).normalized;
								if (42926 - 6562 != 36364)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
								if (171564 - 444526 != -272962)
								{
									continue;
								}
								this.uMCVSQfk9v.actionState = "run";
								if (277290 - 168928 != 108362)
								{
									continue;
								}
								this.animation.Play("run");
								if (92293 - 214445 != -122152)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (207411 - 570912 != -363501)
								{
									continue;
								}
								this.uMCVSQfk9v.moveSpeed = Mathf.Lerp(this.uMCVSQfk9v.moveSpeed, this.uMCVSQfk9v.runSpeed, (float)4 * Time.deltaTime);
								if (243462 - 337777 == -94314)
								{
									continue;
								}
							}
							else
							{
								this.uMCVSQfk9v.vDirection = myAttackTarget.transform.position;
								if (230306 - 8029 != 222277)
								{
									continue;
								}
								this.uMCVSQfk9v.vDirection.y = this.transform.position.y;
								if (294435 - 9539 == 284897)
								{
									continue;
								}
								this.uMCVSQfk9v.vMovement = (this.uMCVSQfk9v.vDirection - this.transform.position).normalized;
								if (7173 - 597438 == -590264)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
								if (291384 - 19955 == 271430)
								{
									continue;
								}
								this.uMCVSQfk9v.actionState = "standby";
								if (139706 - 379198 != -239492)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (21493 - 524966 != -503473)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (124766 - 456041 == -331274)
								{
									continue;
								}
								this.uMCVSQfk9v.moveSpeed = Mathf.Lerp(this.uMCVSQfk9v.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (64059 - 529103 != -465044)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_D9:
			this.pW3V8I917W += mTime;
		}
		while (150695 - 540972 != -390277);
	}

	// Token: 0x060042A6 RID: 17062 RVA: 0x008680A4 File Offset: 0x008662A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_sailAttack(float mTime, float rTimer)
	{
		if (259961 - 56634 != 203327)
		{
		}
		do
		{
			if (Time.time - this.fr8V0A67Ny >= this.pW3V8I917W)
			{
				if (264591 - 340451 != -75860)
				{
					continue;
				}
				if (Time.time - this.fr8V0A67Ny < this.pW3V8I917W + mTime)
				{
					if (168182 - 94925 != 73257)
					{
						continue;
					}
					if (!this.uMCVSQfk9v.myAttackTarget)
					{
						if (49826 - 310908 != -261082)
						{
							continue;
						}
						this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
						if (286307 - 583520 != -297213)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.uMCVSQfk9v.myAttackTarget;
						if (23656 - 239685 == -216028)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (5716 - 259139 == -253422)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (200142 - 396611 == -196468)
						{
							continue;
						}
						int tID = 0;
						if (156616 - 228982 == -72365)
						{
							continue;
						}
						if (characterControl)
						{
							if (176678 - 132848 == 43831)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (10106 - 447111 != -437005)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (86121 - 442665 != -356544)
						{
							continue;
						}
						if ((float)this.uMCVSQfk9v.hp < 0.5f * (float)this.uMCVSQfk9v.mhp)
						{
							if (5464 - 375069 == -369604)
							{
								continue;
							}
							if (this.uMCVSQfk9v.isTimeOut("kitchenDrop") == (float)0)
							{
								if (294918 - 415290 != -120372)
								{
									continue;
								}
								this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
								if (130746 - 511143 == -380396)
								{
									continue;
								}
								this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_kitchenDrop(this.transform.position, vector, tID));
								if (890 - 598825 != -597935)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (242762 - 512959 != -270197)
									{
										continue;
									}
									this.RDrVBt6SSJ.ActionEvent("RPC_kitchenDrop", this.transform.position, vector, tID);
									if (126874 - 533763 != -406889)
									{
										continue;
									}
								}
								goto IL_57E;
							}
						}
						if (this.uMCVSQfk9v.isTimeOut("foodDrop") == (float)0)
						{
							if (17035 - 155225 != -138190)
							{
								continue;
							}
							this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
							if (277633 - 395229 == -117595)
							{
								continue;
							}
							this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_foodDrop(this.transform.position, vector, tID));
							if (167063 - 121380 == 45684)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (181617 - 245677 != -64060)
								{
									continue;
								}
								this.RDrVBt6SSJ.ActionEvent("RPC_foodDrop", this.transform.position, vector, tID);
								if (154014 - 484581 == -330566)
								{
									continue;
								}
							}
						}
						else if (num < (float)3)
						{
							if (286513 - 72457 == 214057)
							{
								continue;
							}
							this.fr8V0A67Ny = Time.time - mTime - this.pW3V8I917W;
							if (261422 - 462006 != -200584)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 100) <= 50)
							{
								if (15701 - 279603 != -263902)
								{
									continue;
								}
								this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack1(this.transform.position, vector, 0));
								if (134306 - 185831 == -51524)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (220695 - 42356 == 178340)
									{
										continue;
									}
									this.RDrVBt6SSJ.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
									if (166554 - 409590 == -243035)
									{
										continue;
									}
								}
							}
							else
							{
								this.RDrVBt6SSJ.StartCoroutine_Auto(this.RDrVBt6SSJ.RPC_nAttack2(this.transform.position, vector, 0));
								if (136011 - 584456 == -448444)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (196797 - 194687 == 2111)
									{
										continue;
									}
									this.RDrVBt6SSJ.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
									if (91806 - 340738 == -248931)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (213536 - 156758 == 56779)
							{
								continue;
							}
							this.uMCVSQfk9v.vDirection = Vector3.zero;
							if (245199 - 506489 != -261290)
							{
								continue;
							}
							this.uMCVSQfk9v.vMovement = -Vector3.forward;
							if (27942 - 81017 != -53075)
							{
								continue;
							}
							this.uMCVSQfk9v.actionState = "standby";
							if (15486 - 512047 == -496560)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.uMCVSQfk9v.vMovement);
							if (199273 - 74694 == 124580)
							{
								continue;
							}
							this.animation.CrossFade("sail", 0.2f);
							if (150378 - 274523 == -124144)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (232360 - 493769 != -261409)
							{
								continue;
							}
							this.uMCVSQfk9v.moveSpeed = (float)0;
							if (27972 - 558572 != -530600)
							{
								continue;
							}
						}
					}
				}
			}
			IL_57E:
			this.pW3V8I917W += mTime;
		}
		while (289860 - 50254 == 239607);
	}

	// Token: 0x060042A7 RID: 17063 RVA: 0x00868840 File Offset: 0x00866A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (115691 - 25714 != 89978)
		{
		}
		while (Time.time - this.fr8V0A67Ny > this.pW3V8I917W)
		{
			if (257795 - 264983 != -7187)
			{
				this.AI_state = "none";
				if (22279 - 97818 == -75539)
				{
					this.fr8V0A67Ny = Time.time;
					if (146230 - 277672 != -131441)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060042A8 RID: 17064 RVA: 0x008688F4 File Offset: 0x00866AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (101948 - 506264 != -404315)
		{
		}
		for (;;)
		{
			IL_4FB:
			if (this.jUuVi3UGf7 > Time.time)
			{
				if (138381 - 506008 != -367626)
				{
					break;
				}
			}
			else
			{
				this.jUuVi3UGf7 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (240222 - 50581 != 189642)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (180328 - 446186 == -265858)
					{
						if (34529 - 336941 != -302411)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (113660 - 461332 == -347672)
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
									if (273257 - 238933 == 34325)
									{
										goto IL_4FB;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (180707 - 67398 == 113310)
									{
										goto IL_4FB;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (89817 - 278762 != -188945)
									{
										goto IL_4FB;
									}
									bool flag = true;
									if (163233 - 527630 == -364396)
									{
										goto IL_4FB;
									}
									eRace race = this.uMCVSQfk9v.Race;
									if (139610 - 398850 == -259239)
									{
										goto IL_4FB;
									}
									if (race == eRace.Tails)
									{
										if (279608 - 324546 != -44938)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_390;
										}
										if (35850 - 138122 == -102271)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (118204 - 467276 != -349071)
											{
												goto IL_390;
											}
											goto IL_4FB;
										}
										goto IL_14D;
										IL_390:
										flag = false;
										if (82664 - 496106 != -413442)
										{
											goto IL_4FB;
										}
									}
									else if (race == eRace.Plants)
									{
										if (220894 - 398281 != -177387)
										{
											goto IL_4FB;
										}
										flag = false;
										if (281969 - 422749 == -140779)
										{
											goto IL_4FB;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (46010 - 148069 == -102058)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_76C;
										}
										if (46324 - 60177 == -13852)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (64092 - 110676 != -46583)
											{
												goto IL_76C;
											}
											goto IL_4FB;
										}
										goto IL_14D;
										IL_76C:
										flag = false;
										if (273326 - 203350 == 69977)
										{
											goto IL_4FB;
										}
									}
									else if (race == eRace.Robots)
									{
										if (150943 - 301983 != -151040)
										{
											goto IL_4FB;
										}
										flag = true;
										if (136511 - 309476 != -172965)
										{
											goto IL_4FB;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (46485 - 433720 != -387235)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_329;
										}
										if (264247 - 339959 == -75711)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_329;
										}
										if (228353 - 485970 == -257616)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (240185 - 549397 != -309211)
											{
												goto IL_329;
											}
											goto IL_4FB;
										}
										goto IL_14D;
										IL_329:
										flag = false;
										if (52201 - 171078 != -118877)
										{
											goto IL_4FB;
										}
									}
									else if (race == eRace.Structure)
									{
										if (131887 - 1506 != 130381)
										{
											goto IL_4FB;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (114710 - 173636 != -58926)
											{
												goto IL_4FB;
											}
											flag = false;
											if (14308 - 290198 == -275889)
											{
												goto IL_4FB;
											}
										}
									}
									IL_14D:
									if (flag)
									{
										if (38227 - 301306 != -263079)
										{
											goto IL_4FB;
										}
										if (characterControl.hp > 0)
										{
											if (190144 - 275835 == -85690)
											{
												goto IL_4FB;
											}
											if (characterControl.recieveTarget)
											{
												if (173921 - 136514 != 37407)
												{
													goto IL_4FB;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (165747 - 198339 != -32592)
													{
														goto IL_4FB;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (65170 - 137101 != -71931)
														{
															goto IL_4FB;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (251390 - 11139 != 240251)
														{
															goto IL_4FB;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (256913 - 87529 != 169384)
															{
																goto IL_4FB;
															}
															this.uMCVSQfk9v.myAttackTarget = gameObject;
															if (231127 - 455743 == -224615)
															{
																goto IL_4FB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (55221 - 146675 == -91453)
															{
																goto IL_4FB;
															}
															this.uMCVSQfk9v.addHate(characterControl.ActorNr, 5);
															if (232645 - 45638 == 187008)
															{
																goto IL_4FB;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (139387 - 304414 != -165027)
															{
																goto IL_4FB;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (53497 - 504391 == -450893)
															{
																goto IL_4FB;
															}
															if (num < (float)60)
															{
																if (97748 - 173151 == -75402)
																{
																	goto IL_4FB;
																}
																if (characterControl.hp > 0)
																{
																	if (72453 - 82119 == -9665)
																	{
																		goto IL_4FB;
																	}
																	this.uMCVSQfk9v.myAttackTarget = gameObject;
																	if (41674 - 302246 == -260571)
																	{
																		goto IL_4FB;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (111081 - 7907 != 103174)
																	{
																		goto IL_4FB;
																	}
																	this.uMCVSQfk9v.addHate(characterControl.ActorNr, 5);
																	if (266216 - 555928 == -289711)
																	{
																		goto IL_4FB;
																	}
																}
															}
														}
														if (this.uMCVSQfk9v.myAttackTarget)
														{
															if (22959 - 409706 == -386746)
															{
																goto IL_4FB;
															}
															this.uMCVSQfk9v.isAlert = true;
															if (52202 - 305754 != -253552)
															{
																goto IL_4FB;
															}
															this.fr8V0A67Ny = Time.time;
															if (299461 - 331490 == -32028)
															{
																goto IL_4FB;
															}
														}
													}
												}
											}
										}
									}
								}
								if (94251 - 595211 == -500960)
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

	// Token: 0x060042A9 RID: 17065 RVA: 0x0086910C File Offset: 0x0086730C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060042AA RID: 17066 RVA: 0x00869110 File Offset: 0x00867310
	internal static bool Vs3ZEY5fLOJZBYq6IOAx()
	{
		return true;
	}

	// Token: 0x060042AB RID: 17067 RVA: 0x00869114 File Offset: 0x00867314
	internal static bool aZOvvH5fO60hmlgFcYoW()
	{
		return false;
	}

	// Token: 0x04004E96 RID: 20118
	private CharacterControl uMCVSQfk9v;

	// Token: 0x04004E97 RID: 20119
	private CaptainCrab RDrVBt6SSJ;

	// Token: 0x04004E98 RID: 20120
	public string AI_state;

	// Token: 0x04004E99 RID: 20121
	private float fr8V0A67Ny;

	// Token: 0x04004E9A RID: 20122
	private float pW3V8I917W;

	// Token: 0x04004E9B RID: 20123
	private float jUuVi3UGf7;
}
