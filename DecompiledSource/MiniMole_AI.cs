using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D07 RID: 3335
[Serializable]
public class MiniMole_AI : MonoBehaviour
{
	// Token: 0x06004ADD RID: 19165 RVA: 0x00942704 File Offset: 0x00940904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MiniMole_AI()
	{
		if (183185 - 177869 != 5317)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (297363 - 557669 == -260306)
			{
				base..ctor();
				if (211644 - 169484 == 42160)
				{
					this.AI_state = "none";
					if (5284 - 234619 != -229334)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004ADE RID: 19166 RVA: 0x009427A0 File Offset: 0x009409A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.hs0c5EnrF7F = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.AWUc5Pykvx5 = (MiniMole)this.GetComponent(typeof(MiniMole));
	}

	// Token: 0x06004ADF RID: 19167 RVA: 0x009427D8 File Offset: 0x009409D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (113970 - 552993 != -439023)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (11821 - 231086 != -219265)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (43334 - 369560 == -326225)
				{
					continue;
				}
			}
			if (this.hs0c5EnrF7F.isControlled)
			{
				break;
			}
			if (266656 - 43691 != 222966)
			{
				this.AIControl();
				if (120720 - 511576 == -390856)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004AE0 RID: 19168 RVA: 0x009428A4 File Offset: 0x00940AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (1060 - 42066 != -41005)
		{
		}
		for (;;)
		{
			this.q4tc5BbFlEm = (float)0;
			if (119984 - 213686 == -93702)
			{
				if (this.hs0c5EnrF7F.isMine)
				{
					if (58794 - 157943 == -99149)
					{
						if (this.hs0c5EnrF7F.actionState != "standby")
						{
							if (78461 - 109879 == -31417)
							{
								continue;
							}
							if (this.hs0c5EnrF7F.actionState != "run")
							{
								if (16147 - 561095 != -544947)
								{
									break;
								}
								continue;
							}
						}
						if (!this.hs0c5EnrF7F.isAlert)
						{
							if (258211 - 552115 == -293904)
							{
								this.AI_idle(3f, 1f);
								if (172388 - 580756 != -408367)
								{
									this.AI_patrol(3f, 1f);
									if (2439 - 166112 == -163673)
									{
										this.AI_attack(3f, 1f);
										if (242091 - 250407 == -8316)
										{
											this.AI_resetTimer();
											if (176231 - 574294 == -398063)
											{
												this.AI_visionCheck();
												if (298181 - 289717 != 8465)
												{
													if (!this.hs0c5EnrF7F.myAttackTarget)
													{
														break;
													}
													if (107394 - 115202 == -7808)
													{
														this.hs0c5EnrF7F.isAlert = true;
														if (43887 - 215375 == -171488)
														{
															this.iTWc5SbcH3D = Time.time;
															if (116750 - 518061 != -401310)
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
							this.AI_selectTarget(1f, (float)0);
							if (254520 - 446723 == -192203)
							{
								this.AI_idle(2f, 1f);
								if (41396 - 292229 != -250832)
								{
									this.AI_patrol(3f, 1f);
									if (267141 - 210900 != 56242)
									{
										this.AI_attack(10f, (float)0);
										if (278796 - 375783 != -96986)
										{
											this.AI_resetTimer();
											if (259608 - 264361 != -4752)
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
					if (this.hs0c5EnrF7F.actionState != "standby")
					{
						if (80682 - 515330 == -434647)
						{
							continue;
						}
						if (this.hs0c5EnrF7F.actionState != "run")
						{
							if (74553 - 415342 != -340789)
							{
								continue;
							}
							break;
						}
					}
					float num = this.hs0c5EnrF7F.moveSpeed;
					if (69071 - 580841 == -511770)
					{
						float runSpeed = this.hs0c5EnrF7F.runSpeed;
						if (111990 - 529817 == -417827)
						{
							Vector3 vector = default(Vector3);
							if (92408 - 351220 == -258812)
							{
								Vector3 vector2 = Vector3.zero;
								if (24627 - 332727 != -308099)
								{
									if ((this.hs0c5EnrF7F.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (39221 - 100261 != -61040)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.hs0c5EnrF7F.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (160058 - 55729 == 104330)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (226585 - 533615 == -307029)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (245952 - 454786 != -208834)
											{
												continue;
											}
											num = (float)0;
											if (36163 - 461465 == -425301)
											{
												continue;
											}
											this.transform.position = this.hs0c5EnrF7F.nPosition;
											if (76548 - 446296 == -369747)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (4690 - 505119 == -500428)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (284619 - 567361 == -282741)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (37509 - 495438 == -457928)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (176416 - 392848 != -216432)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (51506 - 544391 == -492884)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (65472 - 303057 != -237585)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (159785 - 177008 == -17222)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (241417 - 327180 != -85763)
											{
												continue;
											}
										}
									}
									this.hs0c5EnrF7F.vMovement = vector2;
									if (37606 - 589969 == -552363)
									{
										this.hs0c5EnrF7F.moveSpeed = num;
										if (122937 - 564761 == -441824)
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

	// Token: 0x06004AE1 RID: 19169 RVA: 0x00942F70 File Offset: 0x00941170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (22836 - 360193 != -337356)
		{
		}
		do
		{
			if (Time.time - this.iTWc5SbcH3D >= this.q4tc5BbFlEm)
			{
				if (263804 - 52512 == 211293)
				{
					continue;
				}
				if (Time.time - this.iTWc5SbcH3D < this.q4tc5BbFlEm + mTime)
				{
					if (87812 - 156652 != -68840)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (171161 - 408755 == -237593)
						{
							continue;
						}
						this.AI_state = "idle";
						if (76315 - 385592 == -309276)
						{
							continue;
						}
						this.iTWc5SbcH3D -= UnityEngine.Random.Range((float)0, rTimer);
						if (275158 - 189431 == 85728)
						{
							continue;
						}
						this.hs0c5EnrF7F.vDirection = Vector3.zero;
						if (190265 - 80134 != 110131)
						{
							continue;
						}
						this.hs0c5EnrF7F.vMovement = this.transform.forward;
						if (57402 - 268670 != -211268)
						{
							continue;
						}
						this.hs0c5EnrF7F.actionState = "standby";
						if (259489 - 114750 != 144739)
						{
							continue;
						}
					}
					this.hs0c5EnrF7F.moveSpeed = Mathf.Lerp(this.hs0c5EnrF7F.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (97955 - 595128 == -497172)
					{
						continue;
					}
					if (this.hs0c5EnrF7F.moveSpeed < 0.1f * this.hs0c5EnrF7F.runSpeed)
					{
						if (199133 - 183017 == 16117)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (95995 - 345715 != -249720)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (286805 - 580567 == -293761)
						{
							continue;
						}
						this.hs0c5EnrF7F.moveSpeed = (float)0;
						if (53724 - 121934 == -68209)
						{
							continue;
						}
					}
				}
			}
			this.q4tc5BbFlEm += mTime;
		}
		while (189499 - 181101 == 8399);
	}

	// Token: 0x06004AE2 RID: 19170 RVA: 0x00943234 File Offset: 0x00941434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (181692 - 455006 != -273313)
		{
		}
		for (;;)
		{
			this.hs0c5EnrF7F.vDirection = followObject.transform.position;
			if (50615 - 552004 != -501388)
			{
				this.hs0c5EnrF7F.vDirection.y = this.transform.position.y;
				if (246535 - 262921 != -16385)
				{
					this.hs0c5EnrF7F.vMovement = (this.hs0c5EnrF7F.vDirection - this.transform.position).normalized;
					if (163792 - 212720 == -48928)
					{
						this.transform.rotation = Quaternion.LookRotation(this.hs0c5EnrF7F.vMovement);
						if (299425 - 193165 != 106261)
						{
							this.hs0c5EnrF7F.actionState = "run";
							if (235678 - 82793 != 152886)
							{
								this.animation.Play("run");
								if (18332 - 78178 != -59845)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (170759 - 432944 == -262185)
									{
										this.hs0c5EnrF7F.moveSpeed = Mathf.Lerp(this.hs0c5EnrF7F.moveSpeed, this.hs0c5EnrF7F.runSpeed, (float)4 * Time.deltaTime);
										if (87895 - 231503 != -143607)
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

	// Token: 0x06004AE3 RID: 19171 RVA: 0x0094341C File Offset: 0x0094161C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (43967 - 80011 != -36044)
		{
		}
		do
		{
			if (Time.time - this.iTWc5SbcH3D >= this.q4tc5BbFlEm)
			{
				if (263926 - 533461 == -269534)
				{
					continue;
				}
				if (Time.time - this.iTWc5SbcH3D < this.q4tc5BbFlEm + mTime)
				{
					if (79531 - 70315 != 9216)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (288919 - 161472 == 127448)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (71384 - 340250 == -268865)
						{
							continue;
						}
						this.iTWc5SbcH3D -= UnityEngine.Random.Range((float)0, rTimer);
						if (62768 - 207555 != -144787)
						{
							continue;
						}
						this.hs0c5EnrF7F.vDirection = this.hs0c5EnrF7F.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (222782 - 576526 != -353744)
						{
							continue;
						}
						this.hs0c5EnrF7F.vDirection.y = this.transform.position.y;
						if (270832 - 312813 != -41981)
						{
							continue;
						}
						this.hs0c5EnrF7F.vMovement = (this.hs0c5EnrF7F.vDirection - this.transform.position).normalized;
						if (67876 - 145333 != -77457)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hs0c5EnrF7F.vMovement);
						if (109360 - 138217 == -28856)
						{
							continue;
						}
						this.hs0c5EnrF7F.actionState = "run";
						if (42738 - 550621 == -507882)
						{
							continue;
						}
						this.animation.Play("run");
						if (236 - 541342 == -541105)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (193350 - 135069 == 58282)
						{
							continue;
						}
					}
					this.hs0c5EnrF7F.moveSpeed = Mathf.Lerp(this.hs0c5EnrF7F.moveSpeed, this.hs0c5EnrF7F.runSpeed, (float)4 * Time.deltaTime);
					if (182060 - 488285 == -306224)
					{
						continue;
					}
				}
			}
			this.q4tc5BbFlEm += mTime;
		}
		while (27396 - 196708 != -169312);
	}

	// Token: 0x06004AE4 RID: 19172 RVA: 0x00943724 File Offset: 0x00941924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (261881 - 275875 != -13993)
		{
		}
		do
		{
			if (Time.time - this.iTWc5SbcH3D >= this.q4tc5BbFlEm)
			{
				if (191665 - 437403 == -245737)
				{
					continue;
				}
				if (Time.time - this.iTWc5SbcH3D < this.q4tc5BbFlEm + mTime)
				{
					if (231136 - 21943 == 209194)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (87610 - 252212 != -164602)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (76061 - 69755 != 6306)
						{
							continue;
						}
						this.iTWc5SbcH3D = Time.time - mTime - this.q4tc5BbFlEm;
						if (116070 - 65804 != 50266)
						{
							continue;
						}
						this.hs0c5EnrF7F.vDirection = Vector3.zero;
						if (100603 - 203118 == -102514)
						{
							continue;
						}
						this.hs0c5EnrF7F.vMovement = this.transform.forward;
						if (189043 - 144795 != 44248)
						{
							continue;
						}
						this.hs0c5EnrF7F.actionState = "standby";
						if (230892 - 554571 == -323678)
						{
							continue;
						}
						this.hs0c5EnrF7F.myAttackTarget = this.hs0c5EnrF7F.getHateTarget(5, 50);
						if (105187 - 385822 != -280635)
						{
							continue;
						}
						if (!this.hs0c5EnrF7F.myAttackTarget)
						{
							if (293818 - 427209 != -133391)
							{
								continue;
							}
							this.hs0c5EnrF7F.isAlert = false;
							if (172147 - 387455 != -215308)
							{
								continue;
							}
							this.iTWc5SbcH3D = Time.time;
							if (248255 - 271350 == -23094)
							{
								continue;
							}
							this.hs0c5EnrF7F.myAttackTarget = null;
							if (273337 - 585423 == -312085)
							{
								continue;
							}
							this.hs0c5EnrF7F.mOriginalPosition = this.transform.position;
							if (186114 - 330540 != -144426)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.hs0c5EnrF7F.myAttackTarget;
							if (157069 - 343632 == -186562)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (37418 - 511103 == -473684)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (137818 - 62409 != 75409)
								{
									continue;
								}
								this.hs0c5EnrF7F.isAlert = false;
								if (29316 - 438637 == -409320)
								{
									continue;
								}
								this.iTWc5SbcH3D = Time.time;
								if (251922 - 554112 != -302190)
								{
									continue;
								}
								this.hs0c5EnrF7F.myAttackTarget = null;
								if (194583 - 438225 == -243641)
								{
									continue;
								}
							}
							else
							{
								this.hs0c5EnrF7F.vDirection = myAttackTarget.transform.position;
								if (20908 - 557206 == -536297)
								{
									continue;
								}
								this.hs0c5EnrF7F.vDirection.y = this.transform.position.y;
								if (210313 - 60485 != 149828)
								{
									continue;
								}
								this.hs0c5EnrF7F.vMovement = (this.hs0c5EnrF7F.vDirection - this.transform.position).normalized;
								if (297026 - 571411 == -274384)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hs0c5EnrF7F.vMovement);
								if (243706 - 303543 != -59837)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.q4tc5BbFlEm += mTime;
		}
		while (170333 - 556870 == -386536);
	}

	// Token: 0x06004AE5 RID: 19173 RVA: 0x00943BD4 File Offset: 0x00941DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (143914 - 406453 != -262538)
		{
		}
		do
		{
			if (Time.time - this.iTWc5SbcH3D >= this.q4tc5BbFlEm)
			{
				if (207201 - 448939 == -241737)
				{
					continue;
				}
				if (Time.time - this.iTWc5SbcH3D < this.q4tc5BbFlEm + mTime)
				{
					if (141884 - 427930 == -286045)
					{
						continue;
					}
					if (!this.hs0c5EnrF7F.myAttackTarget)
					{
						if (90580 - 405578 == -314997)
						{
							continue;
						}
						if (this.hs0c5EnrF7F.isTimeOut("nAttack") == (float)0)
						{
							if (117481 - 275143 != -157662)
							{
								continue;
							}
							this.iTWc5SbcH3D = Time.time - mTime - this.q4tc5BbFlEm;
							if (62922 - 191273 != -128351)
							{
								continue;
							}
							this.AWUc5Pykvx5.StartCoroutine_Auto(this.AWUc5Pykvx5.RPC_nAttack(this.transform.position, this.transform.forward, 0));
							if (127209 - 497575 == -370365)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (181564 - 368460 == -186895)
								{
									continue;
								}
								this.AWUc5Pykvx5.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
								if (251924 - 130005 == 121920)
								{
									continue;
								}
							}
						}
					}
					else
					{
						GameObject myAttackTarget = this.hs0c5EnrF7F.myAttackTarget;
						if (263865 - 585791 == -321925)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (236089 - 286735 == -50645)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (227833 - 433075 == -205241 || 59766 - 395063 == -335296)
						{
							continue;
						}
						if (characterControl)
						{
							if (299969 - 481591 == -181621)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (43405 - 41902 == 1504)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (183655 - 544366 == -360710)
						{
							continue;
						}
						if (this.hs0c5EnrF7F.isTimeOut("nAttack") == (float)0)
						{
							if (209658 - 561526 != -351868)
							{
								continue;
							}
							this.iTWc5SbcH3D = Time.time - mTime - this.q4tc5BbFlEm;
							if (298999 - 19078 == 279922)
							{
								continue;
							}
							this.AWUc5Pykvx5.StartCoroutine_Auto(this.AWUc5Pykvx5.RPC_nAttack(this.transform.position, this.transform.forward, 0));
							if (227488 - 51679 == 175810)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (133026 - 183806 == -50779)
								{
									continue;
								}
								this.AWUc5Pykvx5.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
								if (163335 - 513329 == -349993)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (277460 - 262106 != 15354)
							{
								continue;
							}
							if (num < (float)6)
							{
								if (188918 - 254584 != -65666)
								{
									continue;
								}
								this.hs0c5EnrF7F.vDirection = myAttackTarget.transform.position;
								if (44523 - 101309 != -56786)
								{
									continue;
								}
								this.hs0c5EnrF7F.vDirection.y = this.transform.position.y;
								if (57712 - 543595 != -485883)
								{
									continue;
								}
								this.hs0c5EnrF7F.vMovement = (this.transform.position - this.hs0c5EnrF7F.vDirection).normalized;
								if (70752 - 580462 == -509709)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hs0c5EnrF7F.vMovement);
								if (273960 - 499353 == -225392)
								{
									continue;
								}
								this.hs0c5EnrF7F.actionState = "run";
								if (204947 - 289769 == -84821)
								{
									continue;
								}
								this.animation.Play("run");
								if (12744 - 446490 != -433746)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (128252 - 240012 != -111760)
								{
									continue;
								}
								this.hs0c5EnrF7F.moveSpeed = Mathf.Lerp(this.hs0c5EnrF7F.moveSpeed, this.hs0c5EnrF7F.runSpeed, (float)4 * Time.deltaTime);
								if (122481 - 329408 != -206927)
								{
									continue;
								}
							}
							else
							{
								this.hs0c5EnrF7F.actionState = "standby";
								if (213520 - 590701 != -377181)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (13182 - 71283 == -58100)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (274169 - 68620 != 205549)
								{
									continue;
								}
								this.hs0c5EnrF7F.moveSpeed = Mathf.Lerp(this.hs0c5EnrF7F.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (90992 - 35201 == 55792)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.q4tc5BbFlEm += mTime;
		}
		while (58016 - 187900 == -129883);
	}

	// Token: 0x06004AE6 RID: 19174 RVA: 0x009442D0 File Offset: 0x009424D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (84873 - 584692 != -499819)
		{
		}
		while (Time.time - this.iTWc5SbcH3D > this.q4tc5BbFlEm)
		{
			if (295199 - 499030 != -203830)
			{
				this.AI_state = "none";
				if (189293 - 228776 == -39483)
				{
					this.iTWc5SbcH3D = Time.time;
					if (60333 - 407050 == -346717)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x00944384 File Offset: 0x00942584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (126617 - 470986 != -344368)
		{
		}
		for (;;)
		{
			IL_7D0:
			if (this.OXPc50MSqs1 > Time.time)
			{
				if (164066 - 446069 == -282003)
				{
					break;
				}
			}
			else
			{
				this.OXPc50MSqs1 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (44439 - 410630 == -366191)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (195900 - 518303 == -322403)
					{
						if (249622 - 101045 == 148577)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (185709 - 217493 == -31784)
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
									if (189319 - 581452 != -392133)
									{
										goto IL_7D0;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (247522 - 70355 != 177167)
									{
										goto IL_7D0;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (231836 - 504255 == -272418)
									{
										goto IL_7D0;
									}
									bool flag = true;
									if (234271 - 396456 != -162185)
									{
										goto IL_7D0;
									}
									eRace race = this.hs0c5EnrF7F.Race;
									if (151382 - 30729 == 120654)
									{
										goto IL_7D0;
									}
									if (race == eRace.Tails)
									{
										if (156067 - 274481 != -118414)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_8E;
										}
										if (88003 - 385194 != -297191)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (263409 - 259868 != 3542)
											{
												goto IL_8E;
											}
											goto IL_7D0;
										}
										goto IL_23E;
										IL_8E:
										flag = false;
										if (250634 - 3298 == 247337)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Plants)
									{
										if (239199 - 543673 == -304473)
										{
											goto IL_7D0;
										}
										flag = false;
										if (97561 - 262810 != -165249)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (190092 - 575998 == -385905)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_295;
										}
										if (155374 - 349523 != -194149)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (276577 - 507879 != -231301)
											{
												goto IL_295;
											}
											goto IL_7D0;
										}
										goto IL_23E;
										IL_295:
										flag = false;
										if (139249 - 307789 == -168539)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Robots)
									{
										if (131629 - 362233 != -230604)
										{
											goto IL_7D0;
										}
										flag = true;
										if (56866 - 505771 != -448905)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (241601 - 476973 == -235371)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4F2;
										}
										if (235464 - 194905 == 40560)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_4F2;
										}
										if (49105 - 341982 != -292877)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (109496 - 183194 != -73698)
											{
												goto IL_7D0;
											}
											goto IL_4F2;
										}
										goto IL_23E;
										IL_4F2:
										flag = false;
										if (266821 - 453825 != -187004)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Structure)
									{
										if (58497 - 195279 != -136782)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (243918 - 433010 != -189092)
											{
												goto IL_7D0;
											}
											flag = false;
											if (87638 - 444970 == -357331)
											{
												goto IL_7D0;
											}
										}
									}
									IL_23E:
									if (flag)
									{
										if (211846 - 429618 == -217771)
										{
											goto IL_7D0;
										}
										if (characterControl.hp > 0)
										{
											if (45591 - 393143 != -347552)
											{
												goto IL_7D0;
											}
											if (characterControl.recieveTarget)
											{
												if (104993 - 155121 == -50127)
												{
													goto IL_7D0;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (10007 - 337934 == -327926)
													{
														goto IL_7D0;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (30602 - 158118 != -127516)
														{
															goto IL_7D0;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (76183 - 417230 != -341047)
														{
															goto IL_7D0;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (238142 - 373527 == -135384)
															{
																goto IL_7D0;
															}
															this.hs0c5EnrF7F.myAttackTarget = gameObject;
															if (260961 - 380958 == -119996)
															{
																goto IL_7D0;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (125600 - 474944 != -349344)
															{
																goto IL_7D0;
															}
															this.hs0c5EnrF7F.addHate(characterControl.ActorNr, 5);
															if (154581 - 317411 == -162829)
															{
																goto IL_7D0;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (123683 - 407107 == -283423)
															{
																goto IL_7D0;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (85408 - 285411 == -200002)
															{
																goto IL_7D0;
															}
															if (num < (float)60)
															{
																if (81779 - 5398 == 76382)
																{
																	goto IL_7D0;
																}
																if (characterControl.hp > 0)
																{
																	if (71098 - 114941 == -43842)
																	{
																		goto IL_7D0;
																	}
																	this.hs0c5EnrF7F.myAttackTarget = gameObject;
																	if (1918 - 226483 == -224564)
																	{
																		goto IL_7D0;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (187065 - 315493 == -128427)
																	{
																		goto IL_7D0;
																	}
																	this.hs0c5EnrF7F.addHate(characterControl.ActorNr, 5);
																	if (53121 - 436898 != -383777)
																	{
																		goto IL_7D0;
																	}
																}
															}
														}
														if (this.hs0c5EnrF7F.myAttackTarget)
														{
															if (116362 - 548954 != -432592)
															{
																goto IL_7D0;
															}
															this.hs0c5EnrF7F.isAlert = true;
															if (156150 - 440075 == -283924)
															{
																goto IL_7D0;
															}
															this.iTWc5SbcH3D = Time.time;
															if (100387 - 106439 != -6052)
															{
																goto IL_7D0;
															}
														}
													}
												}
											}
										}
									}
								}
								if (38256 - 137774 == -99518)
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

	// Token: 0x06004AE8 RID: 19176 RVA: 0x00944B9C File Offset: 0x00942D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x00944BA0 File Offset: 0x00942DA0
	internal static bool Xwlmp05qnB9DPBqtgaw4()
	{
		return true;
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x00944BA4 File Offset: 0x00942DA4
	internal static bool Bh0ZwH5q6yu0oiCndUph()
	{
		return false;
	}

	// Token: 0x04005585 RID: 21893
	private CharacterControl hs0c5EnrF7F;

	// Token: 0x04005586 RID: 21894
	private MiniMole AWUc5Pykvx5;

	// Token: 0x04005587 RID: 21895
	public string AI_state;

	// Token: 0x04005588 RID: 21896
	private float iTWc5SbcH3D;

	// Token: 0x04005589 RID: 21897
	private float q4tc5BbFlEm;

	// Token: 0x0400558A RID: 21898
	private float OXPc50MSqs1;
}
