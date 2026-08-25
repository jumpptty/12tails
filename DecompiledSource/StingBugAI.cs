using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200021A RID: 538
[Serializable]
public class StingBugAI : MonoBehaviour
{
	// Token: 0x06000C28 RID: 3112 RVA: 0x001368CC File Offset: 0x00134ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingBugAI()
	{
		if (82930 - 202826 != -119895)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (167554 - 549887 == -382333)
			{
				base..ctor();
				if (49824 - 269792 == -219968)
				{
					this.AI_state = "none";
					if (197813 - 376164 != -178350)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000C29 RID: 3113 RVA: 0x00136968 File Offset: 0x00134B68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (250770 - 369276 != -118506)
		{
		}
		for (;;)
		{
			this.B2Hem5h2rf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (71457 - 11105 == 60352)
			{
				this.tEpejTgsSk = (StingBug)this.GetComponent(typeof(StingBug));
				if (71299 - 491656 == -420357)
				{
					this.d6CeovRTuY = this.tEpejTgsSk.stingBugType;
					if (109069 - 519517 != -410447)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000C2A RID: 3114 RVA: 0x00136A38 File Offset: 0x00134C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (5797 - 304868 != -299070)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (26200 - 303109 != -276909)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (174095 - 221743 != -47648)
				{
					continue;
				}
			}
			if (this.B2Hem5h2rf.isControlled)
			{
				break;
			}
			if (13398 - 526160 != -512761)
			{
				this.AIControl();
				if (190503 - 520611 != -330107)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000C2B RID: 3115 RVA: 0x00136B04 File Offset: 0x00134D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (190921 - 235056 != -44134)
		{
		}
		for (;;)
		{
			this.jLOeF7a4f7 = (float)0;
			if (20637 - 544405 == -523768)
			{
				if (this.B2Hem5h2rf.isMine)
				{
					if (208434 - 156314 == 52120)
					{
						if (this.B2Hem5h2rf.actionState != "standby")
						{
							if (136724 - 110988 != 25736)
							{
								continue;
							}
							if (this.B2Hem5h2rf.actionState != "run")
							{
								if (82005 - 262497 != -180492)
								{
									continue;
								}
								break;
							}
						}
						if (!this.B2Hem5h2rf.isAlert)
						{
							if (272578 - 298004 == -25426)
							{
								this.AI_idle(3f, 1f);
								if (15614 - 94537 == -78923)
								{
									this.AI_patrol(1f, 0.25f);
									if (290357 - 254549 != 35809)
									{
										this.AI_resetTimer();
										if (5785 - 506769 == -500984)
										{
											this.AI_visionCheck();
											if (7906 - 294084 != -286177)
											{
												if (!this.B2Hem5h2rf.myAttackTarget)
												{
													break;
												}
												if (268628 - 57385 != 211244)
												{
													this.B2Hem5h2rf.isAlert = true;
													if (56645 - 4346 == 52299)
													{
														this.osxekQqA5h = Time.time;
														if (37691 - 380915 == -343224)
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
							if (235219 - 386986 != -151766)
							{
								this.AI_idle(3f, 1f);
								if (147393 - 280599 != -133205)
								{
									this.AI_attack(10f, (float)0);
									if (290663 - 413772 != -123108)
									{
										this.AI_resetTimer();
										if (133708 - 469866 != -336157)
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
					if (this.B2Hem5h2rf.actionState != "standby")
					{
						if (176883 - 81329 == 95555)
						{
							continue;
						}
						if (this.B2Hem5h2rf.actionState != "run")
						{
							if (17922 - 71864 != -53941)
							{
								break;
							}
							continue;
						}
					}
					float num = this.B2Hem5h2rf.moveSpeed;
					if (131019 - 134752 == -3733)
					{
						float runSpeed = this.B2Hem5h2rf.runSpeed;
						if (179961 - 364501 != -184539)
						{
							Vector3 vector = default(Vector3);
							if (244342 - 450272 != -205929)
							{
								Vector3 vector2 = Vector3.zero;
								if (66887 - 529972 != -463084)
								{
									if ((this.B2Hem5h2rf.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (258197 - 282181 != -23984)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.B2Hem5h2rf.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (29250 - 235884 == -206633)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (229195 - 274173 == -44977)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (291016 - 374134 == -83117)
											{
												continue;
											}
											num = (float)0;
											if (167432 - 515746 == -348313)
											{
												continue;
											}
											this.transform.position = this.B2Hem5h2rf.nPosition;
											if (177609 - 57046 == 120564)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (123099 - 310870 != -187771)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (227960 - 578044 == -350083)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (64524 - 453879 == -389354)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (77941 - 23390 == 54552)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (216018 - 558712 != -342694)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (166629 - 314491 == -147861)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (27840 - 71443 == -43602)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (107216 - 157107 != -49891)
											{
												continue;
											}
										}
									}
									this.B2Hem5h2rf.vMovement = vector2;
									if (188944 - 51348 == 137596)
									{
										this.B2Hem5h2rf.moveSpeed = num;
										if (130971 - 45042 != 85930)
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

	// Token: 0x06000C2C RID: 3116 RVA: 0x0013717C File Offset: 0x0013537C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (20512 - 444110 != -423598)
		{
		}
		do
		{
			if (Time.time - this.osxekQqA5h >= this.jLOeF7a4f7)
			{
				if (221111 - 385395 == -164283)
				{
					continue;
				}
				if (Time.time - this.osxekQqA5h < this.jLOeF7a4f7 + mTime)
				{
					if (144148 - 420264 != -276116)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (269882 - 341665 == -71782)
						{
							continue;
						}
						this.AI_state = "idle";
						if (100659 - 497863 != -397204)
						{
							continue;
						}
						this.osxekQqA5h -= UnityEngine.Random.Range((float)0, rTimer);
						if (141447 - 17167 == 124281)
						{
							continue;
						}
						this.B2Hem5h2rf.vDirection = Vector3.zero;
						if (94272 - 426248 != -331976)
						{
							continue;
						}
						this.B2Hem5h2rf.vMovement = this.transform.forward;
						if (290547 - 130807 == 159741)
						{
							continue;
						}
						this.B2Hem5h2rf.actionState = "standby";
						if (258832 - 195212 == 63621)
						{
							continue;
						}
					}
					this.B2Hem5h2rf.moveSpeed = Mathf.Lerp(this.B2Hem5h2rf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (17434 - 87226 == -69791)
					{
						continue;
					}
					if (this.B2Hem5h2rf.moveSpeed < 0.1f * this.B2Hem5h2rf.runSpeed)
					{
						if (185124 - 355376 == -170251)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (135128 - 90858 == 44271)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (12407 - 2577 != 9830)
						{
							continue;
						}
						this.B2Hem5h2rf.moveSpeed = (float)0;
						if (290655 - 166504 == 124152)
						{
							continue;
						}
					}
				}
			}
			this.jLOeF7a4f7 += mTime;
		}
		while (108337 - 339872 != -231535);
	}

	// Token: 0x06000C2D RID: 3117 RVA: 0x00137440 File Offset: 0x00135640
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (25817 - 134311 != -108493)
		{
		}
		do
		{
			if (Time.time - this.osxekQqA5h >= this.jLOeF7a4f7)
			{
				if (245632 - 581798 == -336165)
				{
					continue;
				}
				if (Time.time - this.osxekQqA5h < this.jLOeF7a4f7 + mTime)
				{
					if (294727 - 563989 != -269262)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (74156 - 462985 != -388829)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (122430 - 250524 == -128093)
						{
							continue;
						}
						this.osxekQqA5h -= UnityEngine.Random.Range((float)0, rTimer);
						if (49427 - 319764 != -270337)
						{
							continue;
						}
						this.B2Hem5h2rf.vDirection = this.B2Hem5h2rf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (219381 - 587500 != -368119)
						{
							continue;
						}
						this.B2Hem5h2rf.vDirection.y = this.transform.position.y;
						if (76668 - 220644 == -143975)
						{
							continue;
						}
						this.B2Hem5h2rf.vMovement = (this.B2Hem5h2rf.vDirection - this.transform.position).normalized;
						if (147973 - 213872 != -65899)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.B2Hem5h2rf.vMovement);
						if (134537 - 90769 == 43769)
						{
							continue;
						}
						this.B2Hem5h2rf.actionState = "run";
						if (93437 - 180753 == -87315)
						{
							continue;
						}
						this.animation.Play("run");
						if (127170 - 592171 != -465001)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (171625 - 510815 == -339189)
						{
							continue;
						}
					}
					this.B2Hem5h2rf.moveSpeed = Mathf.Lerp(this.B2Hem5h2rf.moveSpeed, this.B2Hem5h2rf.runSpeed, (float)4 * Time.deltaTime);
					if (266823 - 490054 == -223230)
					{
						continue;
					}
				}
			}
			this.jLOeF7a4f7 += mTime;
		}
		while (165492 - 554359 != -388867);
	}

	// Token: 0x06000C2E RID: 3118 RVA: 0x00137748 File Offset: 0x00135948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (93849 - 447683 != -353834)
		{
		}
		do
		{
			if (Time.time - this.osxekQqA5h >= this.jLOeF7a4f7)
			{
				if (137575 - 322797 != -185222)
				{
					continue;
				}
				if (Time.time - this.osxekQqA5h < this.jLOeF7a4f7 + mTime)
				{
					if (60948 - 255026 == -194077)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (284161 - 498733 == -214571)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (197850 - 437930 != -240080)
						{
							continue;
						}
						this.osxekQqA5h = Time.time - mTime - this.jLOeF7a4f7;
						if (208367 - 412948 == -204580)
						{
							continue;
						}
						this.B2Hem5h2rf.vDirection = Vector3.zero;
						if (68736 - 596290 != -527554)
						{
							continue;
						}
						this.B2Hem5h2rf.vMovement = this.transform.forward;
						if (103989 - 224902 != -120913)
						{
							continue;
						}
						this.B2Hem5h2rf.actionState = "standby";
						if (19896 - 408684 != -388788)
						{
							continue;
						}
						this.B2Hem5h2rf.myAttackTarget = this.B2Hem5h2rf.getHateTarget(5, 50);
						if (196505 - 237262 == -40756)
						{
							continue;
						}
						if (!this.B2Hem5h2rf.myAttackTarget)
						{
							if (245864 - 32042 == 213823)
							{
								continue;
							}
							this.B2Hem5h2rf.isAlert = false;
							if (32447 - 386854 != -354407)
							{
								continue;
							}
							this.osxekQqA5h = Time.time;
							if (31972 - 307358 != -275386)
							{
								continue;
							}
							this.B2Hem5h2rf.myAttackTarget = null;
							if (224077 - 543744 == -319666)
							{
								continue;
							}
							this.B2Hem5h2rf.mOriginalPosition = this.transform.position;
							if (25700 - 60620 != -34919)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.B2Hem5h2rf.myAttackTarget;
							if (271206 - 301543 == -30336)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (174787 - 68952 == 105836)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (252105 - 274360 != -22255)
								{
									continue;
								}
								this.B2Hem5h2rf.isAlert = false;
								if (67487 - 536867 == -469379)
								{
									continue;
								}
								this.osxekQqA5h = Time.time;
								if (43032 - 401988 != -358956)
								{
									continue;
								}
								this.B2Hem5h2rf.myAttackTarget = null;
								if (289596 - 53414 != 236182)
								{
									continue;
								}
							}
							else
							{
								this.B2Hem5h2rf.vDirection = myAttackTarget.transform.position;
								if (71228 - 115295 != -44067)
								{
									continue;
								}
								this.B2Hem5h2rf.vDirection.y = this.transform.position.y;
								if (26375 - 252126 == -225750)
								{
									continue;
								}
								this.B2Hem5h2rf.vMovement = (this.B2Hem5h2rf.vDirection - this.transform.position).normalized;
								if (250552 - 479252 != -228700)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.B2Hem5h2rf.vMovement);
								if (168745 - 100833 == 67913)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.jLOeF7a4f7 += mTime;
		}
		while (248116 - 387743 == -139626);
	}

	// Token: 0x06000C2F RID: 3119 RVA: 0x00137BF8 File Offset: 0x00135DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (32785 - 136016 != -103230)
		{
		}
		do
		{
			if (Time.time - this.osxekQqA5h >= this.jLOeF7a4f7)
			{
				if (267671 - 110919 != 156752)
				{
					continue;
				}
				if (Time.time - this.osxekQqA5h < this.jLOeF7a4f7 + mTime)
				{
					if (43192 - 336134 == -292941)
					{
						continue;
					}
					if (!this.B2Hem5h2rf.myAttackTarget)
					{
						if (177200 - 259532 == -82331)
						{
							continue;
						}
						this.osxekQqA5h = Time.time - mTime - this.jLOeF7a4f7;
						if (112252 - 242363 != -130111)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.B2Hem5h2rf.myAttackTarget;
						if (44106 - 125752 != -81646)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (287089 - 472103 == -185013)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (212906 - 373533 != -160627)
						{
							continue;
						}
						if (this.d6CeovRTuY == eStingBugType.red)
						{
							if (21985 - 505741 == -483755)
							{
								continue;
							}
							if (num > (float)3)
							{
								if (133459 - 275052 != -141593)
								{
									continue;
								}
								if (this.B2Hem5h2rf.isTimeOut("nAttack") == (float)0)
								{
									if (160955 - 554130 != -393175)
									{
										continue;
									}
									this.osxekQqA5h = Time.time - mTime - this.jLOeF7a4f7;
									if (45048 - 240766 == -195717)
									{
										continue;
									}
									this.tEpejTgsSk.StartCoroutine_Auto(this.tEpejTgsSk.RPC_leafSpear(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
									if (245948 - 264130 != -18182)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (198256 - 286192 != -87936)
										{
											continue;
										}
										this.tEpejTgsSk.ActionEvent("RPC_leafSpear", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (164558 - 177050 != -12492)
										{
											continue;
										}
									}
									goto IL_230;
								}
							}
						}
						if (num < (float)2)
						{
							if (117488 - 324651 != -207163)
							{
								continue;
							}
							this.osxekQqA5h = Time.time - mTime - this.jLOeF7a4f7;
							if (199147 - 457978 != -258831)
							{
								continue;
							}
							this.tEpejTgsSk.StartCoroutine_Auto(this.tEpejTgsSk.RPC_sting(this.transform.position, vector, 0));
							if (133143 - 216352 == -83208)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (153493 - 73810 != 79683)
								{
									continue;
								}
								this.tEpejTgsSk.ActionEvent("RPC_sting", this.transform.position, vector, 0);
								if (157050 - 515645 == -358594)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (199001 - 33131 == 165871)
							{
								continue;
							}
							this.B2Hem5h2rf.vDirection = myAttackTarget.transform.position;
							if (43914 - 21147 != 22767)
							{
								continue;
							}
							this.B2Hem5h2rf.vDirection.y = this.transform.position.y;
							if (120583 - 319708 == -199124)
							{
								continue;
							}
							this.B2Hem5h2rf.vMovement = (this.B2Hem5h2rf.vDirection - this.transform.position).normalized;
							if (232039 - 335557 != -103518)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.B2Hem5h2rf.vMovement);
							if (56943 - 584590 == -527646)
							{
								continue;
							}
							this.B2Hem5h2rf.actionState = "run";
							if (90683 - 466033 == -375349)
							{
								continue;
							}
							this.animation.Play("run");
							if (226225 - 370288 == -144062)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (123214 - 576371 != -453157)
							{
								continue;
							}
							this.B2Hem5h2rf.moveSpeed = Mathf.Lerp(this.B2Hem5h2rf.moveSpeed, this.B2Hem5h2rf.runSpeed, (float)4 * Time.deltaTime);
							if (45429 - 250461 != -205032)
							{
								continue;
							}
						}
					}
				}
			}
			IL_230:
			this.jLOeF7a4f7 += mTime;
		}
		while (35607 - 57260 != -21653);
	}

	// Token: 0x06000C30 RID: 3120 RVA: 0x00138208 File Offset: 0x00136408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (217390 - 572579 != -355189)
		{
		}
		while (Time.time - this.osxekQqA5h > this.jLOeF7a4f7)
		{
			if (29477 - 406545 != -377067)
			{
				this.AI_state = "none";
				if (126496 - 184376 != -57879)
				{
					this.osxekQqA5h = Time.time;
					if (155674 - 231652 != -75977)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000C31 RID: 3121 RVA: 0x001382BC File Offset: 0x001364BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (121117 - 271572 != -150455)
		{
		}
		for (;;)
		{
			IL_391:
			if (this.UJ2eAsCSXq > Time.time)
			{
				if (292330 - 181379 == 110951)
				{
					break;
				}
			}
			else
			{
				this.UJ2eAsCSXq = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (68646 - 242987 == -174341)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (30597 - 303611 != -273013)
					{
						if (45722 - 516709 == -470987)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (8546 - 3319 != 5228)
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
									if (215233 - 548029 == -332795)
									{
										goto IL_391;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (298059 - 63092 != 234967)
									{
										goto IL_391;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (33111 - 80425 == -47313)
									{
										goto IL_391;
									}
									bool flag = true;
									if (272508 - 596268 == -323759)
									{
										goto IL_391;
									}
									eRace race = this.B2Hem5h2rf.Race;
									if (230421 - 297300 == -66878)
									{
										goto IL_391;
									}
									if (race == eRace.Tails)
									{
										if (48927 - 558329 != -509402)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5BC;
										}
										if (118067 - 187432 == -69364)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (218500 - 524915 != -306414)
											{
												goto IL_5BC;
											}
											goto IL_391;
										}
										goto IL_562;
										IL_5BC:
										flag = false;
										if (221271 - 389703 == -168431)
										{
											goto IL_391;
										}
									}
									else if (race == eRace.Plants)
									{
										if (171344 - 381861 != -210517)
										{
											goto IL_391;
										}
										flag = false;
										if (254205 - 593154 == -338948)
										{
											goto IL_391;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (37222 - 393619 == -356396)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1A7;
										}
										if (167190 - 327667 != -160477)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (3540 - 506237 != -502697)
											{
												goto IL_391;
											}
											goto IL_1A7;
										}
										goto IL_562;
										IL_1A7:
										flag = false;
										if (119932 - 184799 == -64866)
										{
											goto IL_391;
										}
									}
									else if (race == eRace.Robots)
									{
										if (30022 - 458717 == -428694)
										{
											goto IL_391;
										}
										flag = true;
										if (247398 - 146723 == 100676)
										{
											goto IL_391;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (297901 - 460911 == -163009)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5D8;
										}
										if (149052 - 106752 == 42301)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5D8;
										}
										if (129699 - 354036 != -224337)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (149791 - 289388 != -139597)
											{
												goto IL_391;
											}
											goto IL_5D8;
										}
										goto IL_562;
										IL_5D8:
										flag = false;
										if (227359 - 108272 != 119087)
										{
											goto IL_391;
										}
									}
									else if (race == eRace.Structure)
									{
										if (137042 - 399331 != -262289)
										{
											goto IL_391;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (129274 - 341984 == -212709)
											{
												goto IL_391;
											}
											flag = false;
											if (32878 - 566947 == -534068)
											{
												goto IL_391;
											}
										}
									}
									IL_562:
									if (flag)
									{
										if (215191 - 508716 == -293524)
										{
											goto IL_391;
										}
										if (characterControl.hp > 0)
										{
											if (73748 - 306336 == -232587)
											{
												goto IL_391;
											}
											if (characterControl.recieveTarget)
											{
												if (19859 - 214592 == -194732)
												{
													goto IL_391;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (5355 - 314588 == -309232)
													{
														goto IL_391;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (165562 - 16445 != 149117)
														{
															goto IL_391;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (26960 - 389899 == -362938)
														{
															goto IL_391;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (164718 - 352346 != -187628)
															{
																goto IL_391;
															}
															this.B2Hem5h2rf.myAttackTarget = gameObject;
															if (135200 - 311840 != -176640)
															{
																goto IL_391;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (174215 - 41910 != 132305)
															{
																goto IL_391;
															}
															this.B2Hem5h2rf.addHate(characterControl.ActorNr, 5);
															if (40888 - 541093 != -500205)
															{
																goto IL_391;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (21953 - 41170 != -19217)
															{
																goto IL_391;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (189153 - 253980 == -64826)
															{
																goto IL_391;
															}
															if (num < (float)60)
															{
																if (88258 - 377028 != -288770)
																{
																	goto IL_391;
																}
																if (characterControl.hp > 0)
																{
																	if (271983 - 75622 == 196362)
																	{
																		goto IL_391;
																	}
																	this.B2Hem5h2rf.myAttackTarget = gameObject;
																	if (39290 - 274697 == -235406)
																	{
																		goto IL_391;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (114476 - 282012 == -167535)
																	{
																		goto IL_391;
																	}
																	this.B2Hem5h2rf.addHate(characterControl.ActorNr, 5);
																	if (82472 - 206349 != -123877)
																	{
																		goto IL_391;
																	}
																}
															}
														}
														if (this.B2Hem5h2rf.myAttackTarget)
														{
															if (191014 - 542186 != -351172)
															{
																goto IL_391;
															}
															this.B2Hem5h2rf.isAlert = true;
															if (100574 - 20497 != 80077)
															{
																goto IL_391;
															}
															this.osxekQqA5h = Time.time;
															if (227536 - 3426 == 224111)
															{
																goto IL_391;
															}
														}
													}
												}
											}
										}
									}
								}
								if (83632 - 498992 == -415360)
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

	// Token: 0x06000C32 RID: 3122 RVA: 0x00138AD4 File Offset: 0x00136CD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C33 RID: 3123 RVA: 0x00138AD8 File Offset: 0x00136CD8
	internal static bool IT8qnSAokTK2BBnAIKg()
	{
		return true;
	}

	// Token: 0x06000C34 RID: 3124 RVA: 0x00138ADC File Offset: 0x00136CDC
	internal static bool GjdnbmAEAlBeREJvEhN()
	{
		return false;
	}

	// Token: 0x04000AC9 RID: 2761
	private CharacterControl B2Hem5h2rf;

	// Token: 0x04000ACA RID: 2762
	private StingBug tEpejTgsSk;

	// Token: 0x04000ACB RID: 2763
	private eStingBugType d6CeovRTuY;

	// Token: 0x04000ACC RID: 2764
	public string AI_state;

	// Token: 0x04000ACD RID: 2765
	private float osxekQqA5h;

	// Token: 0x04000ACE RID: 2766
	private float jLOeF7a4f7;

	// Token: 0x04000ACF RID: 2767
	private float UJ2eAsCSXq;
}
