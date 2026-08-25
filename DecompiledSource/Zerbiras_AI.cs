using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003ED RID: 1005
[Serializable]
public class Zerbiras_AI : MonoBehaviour
{
	// Token: 0x06001778 RID: 6008 RVA: 0x00266A10 File Offset: 0x00264C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Zerbiras_AI()
	{
		if (290420 - 563072 != -272651)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (168284 - 530473 == -362189)
			{
				base..ctor();
				if (237832 - 348647 == -110815)
				{
					this.AI_state = "none";
					if (37193 - 183658 == -146465)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00266AAC File Offset: 0x00264CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.HOSOBsscje = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.KojO0Wji8A = (Zerbiras)this.GetComponent(typeof(Zerbiras));
	}

	// Token: 0x0600177A RID: 6010 RVA: 0x00266AE4 File Offset: 0x00264CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (166959 - 474326 != -307367)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (209238 - 590128 != -380890)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (189091 - 272144 == -83052)
				{
					continue;
				}
			}
			if (this.HOSOBsscje.isControlled)
			{
				break;
			}
			if (264930 - 372127 == -107197)
			{
				this.AIControl();
				if (4494 - 279814 != -275319)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00266BB0 File Offset: 0x00264DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (185379 - 102023 != 83357)
		{
		}
		for (;;)
		{
			this.E0kOiiesia = (float)0;
			if (299948 - 541739 == -241791)
			{
				if (this.HOSOBsscje.isMine)
				{
					if (58405 - 251300 == -192895)
					{
						if (this.HOSOBsscje.actionState != "standby")
						{
							if (287016 - 270532 != 16484)
							{
								continue;
							}
							if (this.HOSOBsscje.actionState != "run")
							{
								if (152356 - 102778 != 49578)
								{
									continue;
								}
								break;
							}
						}
						if (!this.HOSOBsscje.isAlert)
						{
							if (72622 - 403096 != -330473)
							{
								this.AI_idle(3f, 1f);
								if (269498 - 68859 != 200640)
								{
									this.AI_patrol(1f, 0.25f);
									if (259879 - 596653 != -336773)
									{
										this.AI_resetTimer();
										if (119645 - 379673 == -260028)
										{
											this.AI_visionCheck();
											if (232342 - 245761 == -13419)
											{
												if (!this.HOSOBsscje.myAttackTarget)
												{
													break;
												}
												if (227934 - 87513 != 140422)
												{
													this.HOSOBsscje.isAlert = true;
													if (38009 - 550234 == -512225)
													{
														this.he1O8idOul = Time.time;
														if (185212 - 459412 != -274199)
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
							if (221630 - 150193 != 71438)
							{
								this.AI_idle(1f, 1f);
								if (100546 - 546811 == -446265)
								{
									this.AI_patrol(1f, 1f);
									if (212884 - 310072 != -97187)
									{
										this.AI_attack(5f, (float)0);
										if (235494 - 129182 != 106313)
										{
											this.AI_resetTimer();
											if (113704 - 32103 == 81601)
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
					if (this.HOSOBsscje.actionState != "standby")
					{
						if (80163 - 67796 != 12367)
						{
							continue;
						}
						if (this.HOSOBsscje.actionState != "run")
						{
							if (215332 - 482000 != -266668)
							{
								continue;
							}
							break;
						}
					}
					float num = this.HOSOBsscje.moveSpeed;
					if (180210 - 112041 == 68169)
					{
						float runSpeed = this.HOSOBsscje.runSpeed;
						if (92877 - 552977 == -460100)
						{
							Vector3 vector = default(Vector3);
							if (8629 - 157145 == -148516)
							{
								Vector3 vector2 = Vector3.zero;
								if (36547 - 563663 == -527116)
								{
									if ((this.HOSOBsscje.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (278833 - 330344 != -51511)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.HOSOBsscje.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (100247 - 133695 != -33448)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (256905 - 496911 == -240005)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (239896 - 508469 != -268573)
											{
												continue;
											}
											num = (float)0;
											if (72859 - 151592 == -78732)
											{
												continue;
											}
											this.transform.position = this.HOSOBsscje.nPosition;
											if (200586 - 578827 == -378240)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (86248 - 430793 != -344545)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (151065 - 761 != 150304)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (188053 - 237986 != -49933)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (234899 - 410005 != -175106)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (125497 - 129463 != -3966)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (264452 - 114789 != 149663)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (225827 - 274323 != -48496)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (281270 - 353183 != -71913)
											{
												continue;
											}
										}
									}
									this.HOSOBsscje.vMovement = vector2;
									if (99310 - 315660 == -216350)
									{
										this.HOSOBsscje.moveSpeed = num;
										if (32524 - 436802 == -404278)
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

	// Token: 0x0600177C RID: 6012 RVA: 0x00267250 File Offset: 0x00265450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (224748 - 211782 != 12967)
		{
		}
		do
		{
			if (Time.time - this.he1O8idOul >= this.E0kOiiesia)
			{
				if (203424 - 213551 != -10127)
				{
					continue;
				}
				if (Time.time - this.he1O8idOul < this.E0kOiiesia + mTime)
				{
					if (268409 - 596852 != -328443)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (100677 - 544832 == -444154)
						{
							continue;
						}
						this.AI_state = "idle";
						if (208092 - 411750 == -203657)
						{
							continue;
						}
						this.he1O8idOul -= UnityEngine.Random.Range((float)0, rTimer);
						if (185263 - 438459 != -253196)
						{
							continue;
						}
						this.HOSOBsscje.vDirection = Vector3.zero;
						if (221598 - 360602 == -139003)
						{
							continue;
						}
						this.HOSOBsscje.vMovement = this.transform.forward;
						if (119206 - 70782 != 48424)
						{
							continue;
						}
						this.HOSOBsscje.actionState = "standby";
						if (4373 - 375852 == -371478)
						{
							continue;
						}
					}
					this.HOSOBsscje.moveSpeed = Mathf.Lerp(this.HOSOBsscje.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (179366 - 151190 == 28177)
					{
						continue;
					}
					if (this.HOSOBsscje.moveSpeed < 0.1f * this.HOSOBsscje.runSpeed)
					{
						if (263924 - 6695 == 257230)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (120124 - 147667 == -27542)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (28 - 252283 != -252255)
						{
							continue;
						}
						this.HOSOBsscje.moveSpeed = (float)0;
						if (8207 - 124382 == -116174)
						{
							continue;
						}
					}
				}
			}
			this.E0kOiiesia += mTime;
		}
		while (190787 - 380123 == -189335);
	}

	// Token: 0x0600177D RID: 6013 RVA: 0x00267514 File Offset: 0x00265714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (299285 - 488044 != -188759)
		{
		}
		do
		{
			if (Time.time - this.he1O8idOul >= this.E0kOiiesia)
			{
				if (252573 - 130586 == 121988)
				{
					continue;
				}
				if (Time.time - this.he1O8idOul < this.E0kOiiesia + mTime)
				{
					if (67097 - 501009 == -433911)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (238691 - 594884 == -356192)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (285840 - 185398 == 100443)
						{
							continue;
						}
						this.he1O8idOul -= UnityEngine.Random.Range((float)0, rTimer);
						if (183907 - 132772 == 51136)
						{
							continue;
						}
						this.HOSOBsscje.vDirection = this.HOSOBsscje.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (83903 - 376542 != -292639)
						{
							continue;
						}
						this.HOSOBsscje.vDirection.y = this.transform.position.y;
						if (240148 - 180780 != 59368)
						{
							continue;
						}
						this.HOSOBsscje.vMovement = (this.HOSOBsscje.vDirection - this.transform.position).normalized;
						if (86673 - 553670 != -466997)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.HOSOBsscje.vMovement);
						if (150909 - 285875 != -134966)
						{
							continue;
						}
						this.HOSOBsscje.actionState = "run";
						if (292221 - 182934 == 109288)
						{
							continue;
						}
						this.animation.Play("run");
						if (293912 - 541517 != -247605)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (108656 - 498790 != -390134)
						{
							continue;
						}
					}
					this.HOSOBsscje.moveSpeed = Mathf.Lerp(this.HOSOBsscje.moveSpeed, this.HOSOBsscje.runSpeed, (float)4 * Time.deltaTime);
					if (192305 - 138684 == 53622)
					{
						continue;
					}
				}
			}
			this.E0kOiiesia += mTime;
		}
		while (296803 - 353733 == -56929);
	}

	// Token: 0x0600177E RID: 6014 RVA: 0x0026781C File Offset: 0x00265A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (152872 - 441667 != -288795)
		{
		}
		do
		{
			if (Time.time - this.he1O8idOul >= this.E0kOiiesia)
			{
				if (247761 - 477803 == -230041)
				{
					continue;
				}
				if (Time.time - this.he1O8idOul < this.E0kOiiesia + mTime)
				{
					if (191806 - 45174 != 146632)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (273531 - 103157 == 170375)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (57606 - 354619 == -297012)
						{
							continue;
						}
						this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
						if (239863 - 447410 != -207547)
						{
							continue;
						}
						this.HOSOBsscje.vDirection = Vector3.zero;
						if (278254 - 205370 == 72885)
						{
							continue;
						}
						this.HOSOBsscje.vMovement = this.transform.forward;
						if (153728 - 531727 != -377999)
						{
							continue;
						}
						this.HOSOBsscje.actionState = "standby";
						if (275229 - 64793 == 210437)
						{
							continue;
						}
						this.HOSOBsscje.myAttackTarget = this.HOSOBsscje.getHateTarget(5, 50);
						if (211061 - 436949 == -225887)
						{
							continue;
						}
						if (!this.HOSOBsscje.myAttackTarget)
						{
							if (174679 - 584091 != -409412)
							{
								continue;
							}
							this.HOSOBsscje.isAlert = false;
							if (113935 - 337181 == -223245)
							{
								continue;
							}
							this.he1O8idOul = Time.time;
							if (35434 - 419630 != -384196)
							{
								continue;
							}
							this.HOSOBsscje.myAttackTarget = null;
							if (212025 - 178555 != 33470)
							{
								continue;
							}
							this.HOSOBsscje.mOriginalPosition = this.transform.position;
							if (52655 - 572366 != -519711)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.HOSOBsscje.myAttackTarget;
							if (97103 - 24666 != 72437)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (191000 - 48343 == 142658)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (174399 - 490932 == -316532)
								{
									continue;
								}
								this.HOSOBsscje.isAlert = false;
								if (203017 - 396599 != -193582)
								{
									continue;
								}
								this.he1O8idOul = Time.time;
								if (179847 - 511922 != -332075)
								{
									continue;
								}
								this.HOSOBsscje.myAttackTarget = null;
								if (182838 - 467006 != -284168)
								{
									continue;
								}
							}
							else
							{
								this.HOSOBsscje.vDirection = myAttackTarget.transform.position;
								if (214653 - 15791 == 198863)
								{
									continue;
								}
								this.HOSOBsscje.vDirection.y = this.transform.position.y;
								if (27131 - 596034 != -568903)
								{
									continue;
								}
								this.HOSOBsscje.vMovement = (this.HOSOBsscje.vDirection - this.transform.position).normalized;
								if (131044 - 186807 == -55762)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.HOSOBsscje.vMovement);
								if (70268 - 482031 != -411763)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.E0kOiiesia += mTime;
		}
		while (289905 - 296623 == -6717);
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00267CCC File Offset: 0x00265ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (245207 - 273822 != -28615)
		{
		}
		do
		{
			if (Time.time - this.he1O8idOul >= this.E0kOiiesia)
			{
				if (176029 - 426056 != -250027)
				{
					continue;
				}
				if (Time.time - this.he1O8idOul < this.E0kOiiesia + mTime)
				{
					if (290805 - 521987 == -231181)
					{
						continue;
					}
					if (!this.HOSOBsscje.myAttackTarget)
					{
						if (87740 - 332989 == -245248)
						{
							continue;
						}
						this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
						if (80309 - 580145 != -499836)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.HOSOBsscje.myAttackTarget;
						if (120066 - 66036 != 54030)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (114766 - 376324 != -261558)
						{
							continue;
						}
						Vector3 mVector = myAttackTarget.transform.position - this.transform.position;
						if (172717 - 327612 != -154895)
						{
							continue;
						}
						if (234486 - 184220 != 50266)
						{
							continue;
						}
						if (characterControl)
						{
							if (295507 - 579909 != -284402)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (219970 - 44614 == 175357)
							{
								continue;
							}
						}
						float num = mVector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (136967 - 236054 != -99087)
						{
							continue;
						}
						if (num < (float)40)
						{
							if (191093 - 522481 == -331387)
							{
								continue;
							}
							if ((float)this.HOSOBsscje.hp < 0.5f * (float)this.HOSOBsscje.mhp)
							{
								if (284618 - 505102 == -220483)
								{
									continue;
								}
								if (this.HOSOBsscje.isTimeOut("gaze") == (float)0)
								{
									if (224506 - 420328 == -195821)
									{
										continue;
									}
									this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
									if (252700 - 476704 == -224003)
									{
										continue;
									}
									this.KojO0Wji8A.StartCoroutine_Auto(this.KojO0Wji8A.RPC_gaze(this.transform.position, global::Math.vFlat(mVector), 0));
									if (31948 - 498264 != -466316)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (173840 - 348479 == -174638)
										{
											continue;
										}
										this.KojO0Wji8A.ActionEvent("RPC_gaze", this.transform.position, global::Math.vFlat(mVector), 0);
										if (217930 - 557601 != -339671)
										{
											continue;
										}
									}
									goto IL_5D6;
								}
							}
						}
						if (num < (float)2)
						{
							if (146047 - 282614 == -136566)
							{
								continue;
							}
							if (this.HOSOBsscje.isTimeOut("nAttack") == (float)0)
							{
								if (192346 - 515651 != -323305)
								{
									continue;
								}
								this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
								if (225319 - 271365 == -46045)
								{
									continue;
								}
								this.KojO0Wji8A.StartCoroutine_Auto(this.KojO0Wji8A.RPC_nAttack(this.transform.position, global::Math.vFlat(mVector), 0));
								if (212144 - 206326 != 5818)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (234524 - 156189 == 78336)
									{
										continue;
									}
									this.KojO0Wji8A.ActionEvent("RPC_nAttack", this.transform.position, global::Math.vFlat(mVector), 0);
									if (186027 - 188334 == -2306)
									{
										continue;
									}
								}
								goto IL_5D6;
							}
						}
						if (num < (float)20)
						{
							if (181955 - 578245 == -396289)
							{
								continue;
							}
							if (this.HOSOBsscje.isTimeOut("darkOrb") == (float)0)
							{
								if (2134 - 445911 == -443776)
								{
									continue;
								}
								this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
								if (252122 - 168024 != 84098)
								{
									continue;
								}
								this.KojO0Wji8A.StartCoroutine_Auto(this.KojO0Wji8A.RPC_darkOrb(this.transform.position, global::Math.vFlat(mVector), 0));
								if (185124 - 234193 != -49069)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (252262 - 306827 != -54565)
									{
										continue;
									}
									this.KojO0Wji8A.ActionEvent("RPC_darkOrb", this.transform.position, global::Math.vFlat(mVector), 0);
									if (229291 - 19977 != 209314)
									{
										continue;
									}
								}
								goto IL_5D6;
							}
						}
						if (num < (float)4)
						{
							if (120694 - 547882 != -427188)
							{
								continue;
							}
							if (this.HOSOBsscje.isTimeOut("cAttack") == (float)0)
							{
								if (95827 - 467496 != -371669)
								{
									continue;
								}
								this.he1O8idOul = Time.time - mTime - this.E0kOiiesia;
								if (268793 - 364565 == -95771)
								{
									continue;
								}
								this.KojO0Wji8A.StartCoroutine_Auto(this.KojO0Wji8A.RPC_cAttack(this.transform.position, global::Math.vFlat(mVector), 0));
								if (121378 - 275081 != -153703)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (117552 - 371041 != -253489)
									{
										continue;
									}
									this.KojO0Wji8A.ActionEvent("RPC_cAttack", this.transform.position, global::Math.vFlat(mVector), 0);
									if (265306 - 582394 == -317087)
									{
										continue;
									}
								}
								goto IL_5D6;
							}
						}
						this.AI_state = "attack";
						if (75720 - 324270 == -248549)
						{
							continue;
						}
						this.HOSOBsscje.vDirection = myAttackTarget.transform.position;
						if (268320 - 186948 != 81372)
						{
							continue;
						}
						this.HOSOBsscje.vDirection.y = this.transform.position.y;
						if (152001 - 507748 == -355746)
						{
							continue;
						}
						this.HOSOBsscje.vMovement = (this.HOSOBsscje.vDirection - this.transform.position).normalized;
						if (165061 - 392467 != -227406)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.HOSOBsscje.vMovement);
						if (123519 - 129601 == -6081)
						{
							continue;
						}
						this.HOSOBsscje.actionState = "run";
						if (32137 - 176202 == -144064)
						{
							continue;
						}
						this.animation.Play("run");
						if (70526 - 156761 == -86234)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (51709 - 239096 == -187386)
						{
							continue;
						}
						this.HOSOBsscje.moveSpeed = Mathf.Lerp(this.HOSOBsscje.moveSpeed, this.HOSOBsscje.runSpeed, (float)4 * Time.deltaTime);
						if (230023 - 544041 == -314017)
						{
							continue;
						}
					}
				}
			}
			IL_5D6:
			this.E0kOiiesia += mTime;
		}
		while (236341 - 166059 != 70282);
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x002685DC File Offset: 0x002667DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (170671 - 372119 != -201447)
		{
		}
		while (Time.time - this.he1O8idOul > this.E0kOiiesia)
		{
			if (295044 - 278023 != 17022)
			{
				this.AI_state = "none";
				if (209702 - 231433 == -21731)
				{
					this.he1O8idOul = Time.time;
					if (222859 - 367450 == -144591)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001781 RID: 6017 RVA: 0x00268690 File Offset: 0x00266890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (159750 - 120189 != 39562)
		{
		}
		for (;;)
		{
			IL_49D:
			if (this.rABODMWYQt + (float)1 > Time.time)
			{
				if (153517 - 361566 != -208048)
				{
					break;
				}
			}
			else
			{
				this.rABODMWYQt = Time.time;
				if (227629 - 156155 == 71474)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (211659 - 308436 == -96777)
					{
						if (104168 - 7562 == 96606)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (138373 - 113517 != 24857)
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
									if (122500 - 449488 != -326988)
									{
										goto IL_49D;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (71903 - 38119 != 33784)
									{
										goto IL_49D;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (136925 - 346181 != -209256)
									{
										goto IL_49D;
									}
									bool flag = true;
									if (269631 - 105753 != 163878)
									{
										goto IL_49D;
									}
									eRace race = this.HOSOBsscje.Race;
									if (249784 - 367504 == -117719)
									{
										goto IL_49D;
									}
									if (race == eRace.Tails)
									{
										if (48364 - 478230 == -429865)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_481;
										}
										if (70488 - 146571 == -76082)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (249301 - 517498 != -268197)
											{
												goto IL_49D;
											}
											goto IL_481;
										}
										goto IL_759;
										IL_481:
										flag = false;
										if (127723 - 218898 != -91175)
										{
											goto IL_49D;
										}
									}
									else if (race == eRace.Plants)
									{
										if (226885 - 153068 != 73817)
										{
											goto IL_49D;
										}
										flag = false;
										if (216300 - 391005 == -174704)
										{
											goto IL_49D;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (182785 - 445566 != -262781)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_54B;
										}
										if (16048 - 167215 != -151167)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (166452 - 29610 != 136843)
											{
												goto IL_54B;
											}
											goto IL_49D;
										}
										goto IL_759;
										IL_54B:
										flag = false;
										if (26365 - 473225 != -446860)
										{
											goto IL_49D;
										}
									}
									else if (race == eRace.Robots)
									{
										if (104958 - 418850 != -313892)
										{
											goto IL_49D;
										}
										flag = true;
										if (116211 - 446365 == -330153)
										{
											goto IL_49D;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (54926 - 65136 != -10210)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_14B;
										}
										if (86999 - 343094 == -256094)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_14B;
										}
										if (273958 - 169191 != 104767)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (184060 - 182055 != 2005)
											{
												goto IL_49D;
											}
											goto IL_14B;
										}
										goto IL_759;
										IL_14B:
										flag = false;
										if (289851 - 561138 != -271287)
										{
											goto IL_49D;
										}
									}
									else if (race == eRace.Structure)
									{
										if (57743 - 266274 != -208531)
										{
											goto IL_49D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (69602 - 135090 != -65488)
											{
												goto IL_49D;
											}
											flag = false;
											if (126668 - 262996 != -136328)
											{
												goto IL_49D;
											}
										}
									}
									IL_759:
									if (flag)
									{
										if (243232 - 63400 == 179833)
										{
											goto IL_49D;
										}
										if (characterControl.hp > 0)
										{
											if (39611 - 360505 != -320894)
											{
												goto IL_49D;
											}
											if (characterControl.recieveTarget)
											{
												if (90161 - 12411 != 77750)
												{
													goto IL_49D;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (912 - 482020 == -481107)
													{
														goto IL_49D;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (96714 - 247137 != -150423)
														{
															goto IL_49D;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (136776 - 67118 != 69658)
														{
															goto IL_49D;
														}
														if (vector.sqrMagnitude < (float)400)
														{
															if (260652 - 44495 != 216157)
															{
																goto IL_49D;
															}
															this.HOSOBsscje.isAlert = true;
															if (33226 - 377222 == -343995)
															{
																goto IL_49D;
															}
															this.he1O8idOul = Time.time;
															if (280583 - 75982 == 204602)
															{
																goto IL_49D;
															}
															this.HOSOBsscje.myAttackTarget = gameObject;
															if (163074 - 51712 == 111363)
															{
																goto IL_49D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (160509 - 156514 == 3996)
															{
																goto IL_49D;
															}
															this.HOSOBsscje.addHate(characterControl.ActorNr, 5);
															if (199127 - 373311 != -174184)
															{
																goto IL_49D;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (228797 - 126181 != 102616)
															{
																goto IL_49D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (172848 - 443707 != -270859)
															{
																goto IL_49D;
															}
															if (num < (float)60)
															{
																if (97554 - 138872 == -41317)
																{
																	goto IL_49D;
																}
																if (characterControl.hp > 0)
																{
																	if (3603 - 397866 == -394262)
																	{
																		goto IL_49D;
																	}
																	this.HOSOBsscje.isAlert = true;
																	if (251879 - 180730 != 71149)
																	{
																		goto IL_49D;
																	}
																	this.he1O8idOul = Time.time;
																	if (226812 - 247229 != -20417)
																	{
																		goto IL_49D;
																	}
																	this.HOSOBsscje.myAttackTarget = gameObject;
																	if (43746 - 312395 != -268649)
																	{
																		goto IL_49D;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (30997 - 364137 == -333139)
																	{
																		goto IL_49D;
																	}
																	this.HOSOBsscje.addHate(characterControl.ActorNr, 5);
																	if (177438 - 39795 == 137644)
																	{
																		goto IL_49D;
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
								if (154665 - 161670 != -7004)
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

	// Token: 0x06001782 RID: 6018 RVA: 0x00268EB8 File Offset: 0x002670B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x00268EBC File Offset: 0x002670BC
	internal static bool ANxp8fxZfJewKJd9EJF()
	{
		return true;
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00268EC0 File Offset: 0x002670C0
	internal static bool MdQVGRxCYSf0MYYPDXG()
	{
		return false;
	}

	// Token: 0x0400140B RID: 5131
	private CharacterControl HOSOBsscje;

	// Token: 0x0400140C RID: 5132
	private Zerbiras KojO0Wji8A;

	// Token: 0x0400140D RID: 5133
	public string AI_state;

	// Token: 0x0400140E RID: 5134
	private float he1O8idOul;

	// Token: 0x0400140F RID: 5135
	private float E0kOiiesia;

	// Token: 0x04001410 RID: 5136
	private float rABODMWYQt;
}
