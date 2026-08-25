using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EAB RID: 3755
[Serializable]
public class GallonBotAI : MonoBehaviour
{
	// Token: 0x0600551A RID: 21786 RVA: 0x00A52D00 File Offset: 0x00A50F00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GallonBotAI()
	{
		if (10588 - 418607 != -408018)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (121315 - 92845 == 28470)
			{
				base..ctor();
				if (41366 - 244222 != -202855)
				{
					this.AI_state = "none";
					if (76548 - 15956 == 60592)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x00A52D9C File Offset: 0x00A50F9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Q4McJeRQsTL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Tu2cJIjEIU3 = (GallonBot)this.GetComponent(typeof(GallonBot));
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x00A52DD4 File Offset: 0x00A50FD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (47956 - 535113 != -487156)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (127236 - 90166 != 37070)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (154760 - 270165 == -115404)
				{
					continue;
				}
			}
			if (this.Q4McJeRQsTL.isControlled)
			{
				break;
			}
			if (199467 - 190239 == 9228)
			{
				this.AIControl();
				if (76445 - 207320 != -130874)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x00A52EA0 File Offset: 0x00A510A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (160270 - 473597 != -313326)
		{
		}
		for (;;)
		{
			this.jRicJ6E1SHX = (float)0;
			if (216458 - 106623 != 109836)
			{
				if (this.Q4McJeRQsTL.isMine)
				{
					if (102496 - 224781 != -122284)
					{
						if (this.Q4McJeRQsTL.actionState != "standby")
						{
							if (251195 - 128764 != 122431)
							{
								continue;
							}
							if (this.Q4McJeRQsTL.actionState != "run")
							{
								if (171376 - 340046 != -168669)
								{
									break;
								}
								continue;
							}
						}
						if (!this.Q4McJeRQsTL.isAlert)
						{
							if (222290 - 455380 != -233089)
							{
								this.AI_idle(3f, 1f);
								if (145322 - 152267 == -6945)
								{
									this.AI_patrol(1f, 0.25f);
									if (138460 - 59635 == 78825)
									{
										this.AI_resetTimer();
										if (242023 - 301038 == -59015)
										{
											this.AI_visionCheck();
											if (257803 - 83796 != 174008)
											{
												if (!this.Q4McJeRQsTL.myAttackTarget)
												{
													break;
												}
												if (42843 - 32964 != 9880)
												{
													this.Q4McJeRQsTL.isAlert = true;
													if (23576 - 177770 != -154193)
													{
														this.e4NcJJVUDPe = Time.time;
														if (85819 - 409401 == -323582)
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
							if (52882 - 435440 != -382557)
							{
								this.AI_idle(1f, 1f);
								if (224637 - 339663 != -115025)
								{
									this.AI_patrol(2f, 1f);
									if (73160 - 17647 != 55514)
									{
										this.AI_attack(10f, (float)0);
										if (207982 - 597581 == -389599)
										{
											this.AI_resetTimer();
											if (128975 - 31441 == 97534)
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
					if (this.Q4McJeRQsTL.actionState != "standby")
					{
						if (107581 - 178609 == -71027)
						{
							continue;
						}
						if (this.Q4McJeRQsTL.actionState != "run")
						{
							if (116941 - 195826 != -78884)
							{
								break;
							}
							continue;
						}
					}
					float num = this.Q4McJeRQsTL.moveSpeed;
					if (266392 - 495956 == -229564)
					{
						float runSpeed = this.Q4McJeRQsTL.runSpeed;
						if (27132 - 236349 == -209217)
						{
							Vector3 vector = default(Vector3);
							if (135105 - 217193 != -82087)
							{
								Vector3 vector2 = Vector3.zero;
								if (270879 - 465830 == -194951)
								{
									if ((this.Q4McJeRQsTL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (183425 - 183090 != 335)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Q4McJeRQsTL.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (45997 - 350609 != -304612)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (182720 - 447355 == -264634)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (223528 - 288982 != -65454)
											{
												continue;
											}
											num = (float)0;
											if (72894 - 276362 == -203467)
											{
												continue;
											}
											this.transform.position = this.Q4McJeRQsTL.nPosition;
											if (149950 - 527834 == -377883)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (267121 - 125775 != 141346)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (299455 - 356196 == -56740)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (233322 - 265547 != -32225)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (169159 - 317088 == -147928)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (14020 - 191131 != -177111)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (110102 - 525765 != -415663)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (141125 - 313083 != -171958)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (247695 - 456659 != -208964)
											{
												continue;
											}
										}
									}
									this.Q4McJeRQsTL.vMovement = vector2;
									if (120609 - 214173 == -93564)
									{
										this.Q4McJeRQsTL.moveSpeed = num;
										if (81852 - 296145 != -214292)
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

	// Token: 0x0600551E RID: 21790 RVA: 0x00A53540 File Offset: 0x00A51740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (31122 - 181482 != -150359)
		{
		}
		do
		{
			if (Time.time - this.e4NcJJVUDPe >= this.jRicJ6E1SHX)
			{
				if (14062 - 243628 == -229565)
				{
					continue;
				}
				if (Time.time - this.e4NcJJVUDPe < this.jRicJ6E1SHX + mTime)
				{
					if (89638 - 431803 == -342164)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (197968 - 26779 == 171190)
						{
							continue;
						}
						this.AI_state = "idle";
						if (243403 - 39184 == 204220)
						{
							continue;
						}
						this.e4NcJJVUDPe -= UnityEngine.Random.Range((float)0, rTimer);
						if (272850 - 313494 == -40643)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection = Vector3.zero;
						if (268524 - 388661 == -120136)
						{
							continue;
						}
						this.Q4McJeRQsTL.vMovement = this.transform.forward;
						if (127643 - 397763 == -270119)
						{
							continue;
						}
						this.Q4McJeRQsTL.actionState = "standby";
						if (33403 - 38381 != -4978)
						{
							continue;
						}
					}
					this.Q4McJeRQsTL.moveSpeed = Mathf.Lerp(this.Q4McJeRQsTL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (120387 - 269103 == -148715)
					{
						continue;
					}
					if (this.Q4McJeRQsTL.moveSpeed < 0.1f * this.Q4McJeRQsTL.runSpeed)
					{
						if (82780 - 581460 == -498679)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (93265 - 48878 == 44388)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (129157 - 340531 == -211373)
						{
							continue;
						}
						this.Q4McJeRQsTL.moveSpeed = (float)0;
						if (244579 - 22552 == 222028)
						{
							continue;
						}
					}
				}
			}
			this.jRicJ6E1SHX += mTime;
		}
		while (227076 - 433412 != -206336);
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x00A53804 File Offset: 0x00A51A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (299897 - 399395 != -99497)
		{
		}
		do
		{
			if (Time.time - this.e4NcJJVUDPe >= this.jRicJ6E1SHX)
			{
				if (238755 - 285090 == -46334)
				{
					continue;
				}
				if (Time.time - this.e4NcJJVUDPe < this.jRicJ6E1SHX + mTime)
				{
					if (157725 - 400121 != -242396)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (227772 - 584635 != -356863)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (46105 - 21617 != 24488)
						{
							continue;
						}
						this.e4NcJJVUDPe -= UnityEngine.Random.Range((float)0, rTimer);
						if (264079 - 285423 == -21343)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection = this.Q4McJeRQsTL.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (36449 - 129521 != -93072)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection.y = this.transform.position.y;
						if (16431 - 459858 == -443426)
						{
							continue;
						}
						this.Q4McJeRQsTL.vMovement = (this.Q4McJeRQsTL.vDirection - this.transform.position).normalized;
						if (292319 - 512894 != -220575)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Q4McJeRQsTL.vMovement);
						if (107389 - 114077 != -6688)
						{
							continue;
						}
						this.Q4McJeRQsTL.actionState = "run";
						if (57236 - 279859 == -222622)
						{
							continue;
						}
						this.animation.Play("run");
						if (74074 - 421583 == -347508)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (163696 - 61260 != 102436)
						{
							continue;
						}
					}
					this.Q4McJeRQsTL.moveSpeed = Mathf.Lerp(this.Q4McJeRQsTL.moveSpeed, this.Q4McJeRQsTL.runSpeed, (float)4 * Time.deltaTime);
					if (202469 - 207278 != -4809)
					{
						continue;
					}
				}
			}
			this.jRicJ6E1SHX += mTime;
		}
		while (253850 - 160391 == 93460);
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x00A53B0C File Offset: 0x00A51D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (37192 - 219756 != -182563)
		{
		}
		do
		{
			if (Time.time - this.e4NcJJVUDPe >= this.jRicJ6E1SHX)
			{
				if (84372 - 446329 == -361956)
				{
					continue;
				}
				if (Time.time - this.e4NcJJVUDPe < this.jRicJ6E1SHX + mTime)
				{
					if (227884 - 282421 != -54537)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (64156 - 162120 != -97964)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (87336 - 312096 != -224760)
						{
							continue;
						}
						this.e4NcJJVUDPe = Time.time - mTime - this.jRicJ6E1SHX;
						if (193564 - 508872 != -315308)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection = Vector3.zero;
						if (85466 - 324003 == -238536)
						{
							continue;
						}
						this.Q4McJeRQsTL.vMovement = this.transform.forward;
						if (198294 - 342336 != -144042)
						{
							continue;
						}
						this.Q4McJeRQsTL.actionState = "standby";
						if (130462 - 280082 != -149620)
						{
							continue;
						}
						this.Q4McJeRQsTL.myAttackTarget = this.Q4McJeRQsTL.getHateTarget(5, 50);
						if (159421 - 168337 == -8915)
						{
							continue;
						}
						if (!this.Q4McJeRQsTL.myAttackTarget)
						{
							if (13726 - 493948 == -480221)
							{
								continue;
							}
							this.Q4McJeRQsTL.isAlert = false;
							if (248560 - 250935 == -2374)
							{
								continue;
							}
							this.e4NcJJVUDPe = Time.time;
							if (40511 - 79674 != -39163)
							{
								continue;
							}
							this.Q4McJeRQsTL.myAttackTarget = null;
							if (150973 - 106362 != 44611)
							{
								continue;
							}
							this.Q4McJeRQsTL.mOriginalPosition = this.transform.position;
							if (85238 - 256758 != -171520)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Q4McJeRQsTL.myAttackTarget;
							if (76101 - 557092 == -480990)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (160777 - 181889 != -21112)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (204644 - 424210 == -219565)
								{
									continue;
								}
								this.Q4McJeRQsTL.isAlert = false;
								if (7878 - 375528 == -367649)
								{
									continue;
								}
								this.e4NcJJVUDPe = Time.time;
								if (105133 - 355745 != -250612)
								{
									continue;
								}
								this.Q4McJeRQsTL.myAttackTarget = null;
								if (271250 - 20111 != 251139)
								{
									continue;
								}
							}
							else
							{
								this.Q4McJeRQsTL.vDirection = myAttackTarget.transform.position;
								if (120456 - 136110 != -15654)
								{
									continue;
								}
								this.Q4McJeRQsTL.vDirection.y = this.transform.position.y;
								if (94754 - 240048 != -145294)
								{
									continue;
								}
								this.Q4McJeRQsTL.vMovement = (this.Q4McJeRQsTL.vDirection - this.transform.position).normalized;
								if (86917 - 450886 != -363969)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Q4McJeRQsTL.vMovement);
								if (93103 - 222952 != -129849)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.jRicJ6E1SHX += mTime;
		}
		while (15627 - 499833 != -484206);
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x00A53FBC File Offset: 0x00A521BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (248035 - 109868 != 138167)
		{
		}
		do
		{
			if (Time.time - this.e4NcJJVUDPe >= this.jRicJ6E1SHX)
			{
				if (199936 - 137302 == 62635)
				{
					continue;
				}
				if (Time.time - this.e4NcJJVUDPe < this.jRicJ6E1SHX + mTime)
				{
					if (129207 - 75950 == 53258)
					{
						continue;
					}
					if (!this.Q4McJeRQsTL.myAttackTarget)
					{
						if (262991 - 306295 != -43304)
						{
							continue;
						}
						this.e4NcJJVUDPe = Time.time - mTime - this.jRicJ6E1SHX;
						if (96128 - 547665 != -451537)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.Q4McJeRQsTL.myAttackTarget;
						if (183681 - 569692 == -386010)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (166575 - 592912 == -426336)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (49255 - 306898 != -257643)
						{
							continue;
						}
						int tID = 0;
						if (134628 - 239585 != -104957)
						{
							continue;
						}
						if (characterControl)
						{
							if (183187 - 597162 == -413974)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (16010 - 74811 == -58800)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (224833 - 585616 != -360783)
						{
							continue;
						}
						if (num < (float)24)
						{
							if (90792 - 112092 != -21300)
							{
								continue;
							}
							if (this.Q4McJeRQsTL.isTimeOut("gallonMissile") == (float)0)
							{
								if (121181 - 538274 == -417092)
								{
									continue;
								}
								this.e4NcJJVUDPe = Time.time - mTime - this.jRicJ6E1SHX;
								if (161936 - 394907 == -232970)
								{
									continue;
								}
								this.Tu2cJIjEIU3.StartCoroutine_Auto(this.Tu2cJIjEIU3.RPC_gallonMissile(this.transform.position, vector, tID));
								if (33795 - 554966 != -521170)
								{
									if (PhotonClient.IsInitialized())
									{
										if (202290 - 13433 != 188857)
										{
											continue;
										}
										this.Tu2cJIjEIU3.ActionEvent("RPC_gallonMissile", this.transform.position, vector, tID);
										if (121809 - 120478 != 1331)
										{
											continue;
										}
									}
									goto IL_3A6;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (107865 - 427589 != -319724)
							{
								continue;
							}
							if (this.Q4McJeRQsTL.isTimeOut("drill") == (float)0)
							{
								if (127163 - 256787 != -129624)
								{
									continue;
								}
								this.e4NcJJVUDPe = Time.time - mTime - this.jRicJ6E1SHX;
								if (83811 - 118577 == -34765)
								{
									continue;
								}
								this.Tu2cJIjEIU3.StartCoroutine_Auto(this.Tu2cJIjEIU3.RPC_drill(this.transform.position, vector, 0));
								if (95753 - 113694 != -17941)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (69477 - 459496 != -390019)
									{
										continue;
									}
									this.Tu2cJIjEIU3.ActionEvent("RPC_drill", this.transform.position, vector, 0);
									if (150352 - 581187 != -430835)
									{
										continue;
									}
								}
								goto IL_3A6;
							}
						}
						if (num < (float)1)
						{
							if (89241 - 384840 == -295598)
							{
								continue;
							}
							if (this.Q4McJeRQsTL.isTimeOut("nAttack") == (float)0)
							{
								if (74685 - 175106 != -100421)
								{
									continue;
								}
								this.e4NcJJVUDPe = Time.time - mTime - this.jRicJ6E1SHX;
								if (49916 - 485118 == -435201)
								{
									continue;
								}
								this.Tu2cJIjEIU3.StartCoroutine_Auto(this.Tu2cJIjEIU3.RPC_nAttack(this.transform.position, vector, 0));
								if (203998 - 167784 != 36215)
								{
									if (PhotonClient.IsInitialized())
									{
										if (68181 - 125752 == -57570)
										{
											continue;
										}
										this.Tu2cJIjEIU3.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (253834 - 338091 != -84257)
										{
											continue;
										}
									}
									goto IL_3A6;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (168136 - 300738 != -132602)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection = myAttackTarget.transform.position;
						if (237505 - 350900 == -113394)
						{
							continue;
						}
						this.Q4McJeRQsTL.vDirection.y = this.transform.position.y;
						if (162741 - 71333 != 91408)
						{
							continue;
						}
						this.Q4McJeRQsTL.vMovement = (this.Q4McJeRQsTL.vDirection - this.transform.position).normalized;
						if (169338 - 526436 == -357097)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Q4McJeRQsTL.vMovement);
						if (35680 - 325313 != -289633)
						{
							continue;
						}
						this.Q4McJeRQsTL.actionState = "run";
						if (87088 - 450615 != -363527)
						{
							continue;
						}
						this.animation.Play("run");
						if (36796 - 496459 == -459662)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (93992 - 290666 == -196673)
						{
							continue;
						}
						this.Q4McJeRQsTL.moveSpeed = Mathf.Lerp(this.Q4McJeRQsTL.moveSpeed, this.Q4McJeRQsTL.runSpeed, (float)4 * Time.deltaTime);
						if (118764 - 367187 == -248422)
						{
							continue;
						}
					}
				}
			}
			IL_3A6:
			this.jRicJ6E1SHX += mTime;
		}
		while (61229 - 348700 != -287471);
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x00A54748 File Offset: 0x00A52948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (231291 - 216448 != 14843)
		{
		}
		while (Time.time - this.e4NcJJVUDPe > this.jRicJ6E1SHX)
		{
			if (127907 - 212705 == -84798)
			{
				this.AI_state = "none";
				if (37276 - 219425 == -182149)
				{
					this.e4NcJJVUDPe = Time.time;
					if (62130 - 195617 != -133486)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x00A547FC File Offset: 0x00A529FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (31623 - 529407 != -497784)
		{
		}
		for (;;)
		{
			IL_681:
			if (this.Tb5cJtGhYnh > Time.time)
			{
				if (103847 - 382804 == -278957)
				{
					break;
				}
			}
			else
			{
				this.Tb5cJtGhYnh = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (236749 - 291056 != -54306)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (99311 - 396735 != -297423)
					{
						if (4585 - 375132 == -370547)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (65831 - 277591 != -211759)
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
									if (83611 - 56001 != 27610)
									{
										goto IL_681;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (31054 - 347046 != -315992)
									{
										goto IL_681;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (155707 - 373369 != -217662)
									{
										goto IL_681;
									}
									bool flag = true;
									if (30132 - 251270 != -221138)
									{
										goto IL_681;
									}
									eRace race = this.Q4McJeRQsTL.Race;
									if (119721 - 475095 != -355374)
									{
										goto IL_681;
									}
									if (race == eRace.Tails)
									{
										if (201706 - 302155 == -100448)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_373;
										}
										if (46366 - 263536 != -217170)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (137513 - 499911 != -362398)
											{
												goto IL_681;
											}
											goto IL_373;
										}
										goto IL_293;
										IL_373:
										flag = false;
										if (96728 - 540554 == -443825)
										{
											goto IL_681;
										}
									}
									else if (race == eRace.Plants)
									{
										if (199020 - 408612 == -209591)
										{
											goto IL_681;
										}
										flag = false;
										if (116290 - 258981 == -142690)
										{
											goto IL_681;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (287080 - 279939 == 7142)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_447;
										}
										if (161054 - 416856 != -255802)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (230605 - 137379 != 93227)
											{
												goto IL_447;
											}
											goto IL_681;
										}
										goto IL_293;
										IL_447:
										flag = false;
										if (267560 - 234880 == 32681)
										{
											goto IL_681;
										}
									}
									else if (race == eRace.Robots)
									{
										if (78147 - 104129 != -25982)
										{
											goto IL_681;
										}
										flag = true;
										if (65785 - 2935 != 62850)
										{
											goto IL_681;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (250394 - 589196 == -338801)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_71D;
										}
										if (257813 - 198234 != 59579)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_71D;
										}
										if (299427 - 80029 != 219398)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (48286 - 453530 != -405244)
											{
												goto IL_681;
											}
											goto IL_71D;
										}
										goto IL_293;
										IL_71D:
										flag = false;
										if (293610 - 262780 != 30830)
										{
											goto IL_681;
										}
									}
									else if (race == eRace.Structure)
									{
										if (146721 - 534382 != -387661)
										{
											goto IL_681;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (206364 - 193880 == 12485)
											{
												goto IL_681;
											}
											flag = false;
											if (211429 - 479610 != -268181)
											{
												goto IL_681;
											}
										}
									}
									IL_293:
									if (flag)
									{
										if (166859 - 229228 == -62368)
										{
											goto IL_681;
										}
										if (characterControl.hp > 0)
										{
											if (142487 - 558522 != -416035)
											{
												goto IL_681;
											}
											if (characterControl.recieveTarget)
											{
												if (17552 - 454570 != -437018)
												{
													goto IL_681;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (279690 - 120131 == 159560)
													{
														goto IL_681;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (208431 - 11536 == 196896)
														{
															goto IL_681;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (65569 - 233978 == -168408)
														{
															goto IL_681;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (69627 - 342934 == -273306)
															{
																goto IL_681;
															}
															this.Q4McJeRQsTL.myAttackTarget = gameObject;
															if (133584 - 58304 == 75281)
															{
																goto IL_681;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (4770 - 361585 == -356814)
															{
																goto IL_681;
															}
															this.Q4McJeRQsTL.addHate(characterControl.ActorNr, 5);
															if (80253 - 490922 != -410669)
															{
																goto IL_681;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (268156 - 293404 == -25247)
															{
																goto IL_681;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (255872 - 380512 == -124639)
															{
																goto IL_681;
															}
															if (num < (float)60)
															{
																if (269678 - 594637 != -324959)
																{
																	goto IL_681;
																}
																if (characterControl.hp > 0)
																{
																	if (81673 - 383815 != -302142)
																	{
																		goto IL_681;
																	}
																	this.Q4McJeRQsTL.myAttackTarget = gameObject;
																	if (138216 - 448915 != -310699)
																	{
																		goto IL_681;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (64444 - 481501 == -417056)
																	{
																		goto IL_681;
																	}
																	this.Q4McJeRQsTL.addHate(characterControl.ActorNr, 5);
																	if (139623 - 416823 == -277199)
																	{
																		goto IL_681;
																	}
																}
															}
														}
														if (this.Q4McJeRQsTL.myAttackTarget)
														{
															if (221496 - 531793 != -310297)
															{
																goto IL_681;
															}
															this.Q4McJeRQsTL.isAlert = true;
															if (274804 - 158426 != 116378)
															{
																goto IL_681;
															}
															this.e4NcJJVUDPe = Time.time;
															if (183554 - 323412 != -139858)
															{
																goto IL_681;
															}
														}
													}
												}
											}
										}
									}
								}
								if (17356 - 305381 != -288024)
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

	// Token: 0x06005524 RID: 21796 RVA: 0x00A55014 File Offset: 0x00A53214
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x00A55018 File Offset: 0x00A53218
	internal static bool J0fe4X51c5IUCVZl4Nj1()
	{
		return true;
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x00A5501C File Offset: 0x00A5321C
	internal static bool D3U9p551UaiMp60PU015()
	{
		return false;
	}

	// Token: 0x04005E2C RID: 24108
	private CharacterControl Q4McJeRQsTL;

	// Token: 0x04005E2D RID: 24109
	private GallonBot Tu2cJIjEIU3;

	// Token: 0x04005E2E RID: 24110
	public string AI_state;

	// Token: 0x04005E2F RID: 24111
	private float e4NcJJVUDPe;

	// Token: 0x04005E30 RID: 24112
	private float jRicJ6E1SHX;

	// Token: 0x04005E31 RID: 24113
	private float Tb5cJtGhYnh;
}
