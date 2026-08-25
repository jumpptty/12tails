using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EB7 RID: 3767
[Serializable]
public class GiantGallonBotAI : MonoBehaviour
{
	// Token: 0x06005565 RID: 21861 RVA: 0x00A5A474 File Offset: 0x00A58674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GiantGallonBotAI()
	{
		if (45500 - 412795 != -367295)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (210460 - 22380 == 188080)
			{
				base..ctor();
				if (50951 - 92353 == -41402)
				{
					this.AI_state = "none";
					if (254011 - 91482 != 162530)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005566 RID: 21862 RVA: 0x00A5A510 File Offset: 0x00A58710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.tQNcJX4cByc = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.E31cJO7C0Ib = (GiantGallonBot)this.GetComponent(typeof(GiantGallonBot));
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x00A5A548 File Offset: 0x00A58748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (73212 - 210016 != -136803)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (160885 - 293307 != -132422)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (181818 - 155115 != 26703)
				{
					continue;
				}
			}
			if (this.tQNcJX4cByc.isControlled)
			{
				break;
			}
			if (186708 - 118924 != 67785)
			{
				this.AIControl();
				if (237830 - 480330 != -242499)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x00A5A614 File Offset: 0x00A58814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (289057 - 175412 != 113645)
		{
		}
		for (;;)
		{
			this.Qq8cJvaWmMQ = (float)0;
			if (113688 - 519881 == -406193)
			{
				if (this.tQNcJX4cByc.isMine)
				{
					if (107468 - 89883 != 17586)
					{
						if (this.tQNcJX4cByc.actionState != "standby")
						{
							if (203243 - 187901 == 15343)
							{
								continue;
							}
							if (this.tQNcJX4cByc.actionState != "run")
							{
								if (140101 - 382508 != -242407)
								{
									continue;
								}
								break;
							}
						}
						if (!this.tQNcJX4cByc.isAlert)
						{
							if (228981 - 510285 == -281304)
							{
								this.AI_idle(3f, 1f);
								if (209485 - 222310 == -12825)
								{
									this.AI_patrol(1f, 0.25f);
									if (130853 - 469320 != -338466)
									{
										this.AI_resetTimer();
										if (248020 - 578849 != -330828)
										{
											this.AI_visionCheck();
											if (18249 - 587113 == -568864)
											{
												if (!this.tQNcJX4cByc.myAttackTarget)
												{
													break;
												}
												if (153074 - 56295 == 96779)
												{
													this.tQNcJX4cByc.isAlert = true;
													if (67679 - 168508 == -100829)
													{
														this.hKvcJ26R4Oh = Time.time;
														if (11381 - 126399 != -115017)
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
							if (49620 - 337518 != -287897)
							{
								this.AI_idle(3f, 1f);
								if (251391 - 152427 == 98964)
								{
									this.AI_attack(10f, (float)0);
									if (291000 - 12705 == 278295)
									{
										this.AI_resetTimer();
										if (283202 - 356501 != -73298)
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
					if (this.tQNcJX4cByc.actionState != "standby")
					{
						if (182603 - 133796 != 48807)
						{
							continue;
						}
						if (this.tQNcJX4cByc.actionState != "run")
						{
							if (58885 - 137872 != -78986)
							{
								break;
							}
							continue;
						}
					}
					float num = this.tQNcJX4cByc.moveSpeed;
					if (137619 - 437264 == -299645)
					{
						float runSpeed = this.tQNcJX4cByc.runSpeed;
						if (86130 - 168607 != -82476)
						{
							Vector3 vector = default(Vector3);
							if (112605 - 497659 != -385053)
							{
								Vector3 vector2 = Vector3.zero;
								if (1666 - 510140 != -508473)
								{
									if ((this.tQNcJX4cByc.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (181853 - 462986 != -281133)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.tQNcJX4cByc.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (49560 - 457762 == -408201)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (232990 - 434235 == -201244)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (68842 - 265241 == -196398)
											{
												continue;
											}
											num = (float)0;
											if (118650 - 397229 != -278579)
											{
												continue;
											}
											this.transform.position = this.tQNcJX4cByc.nPosition;
											if (19375 - 322364 != -302989)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (23288 - 168511 != -145223)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (193795 - 176792 != 17003)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (100025 - 23765 == 76261)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (123990 - 549558 == -425567)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (56653 - 95395 != -38742)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (7453 - 576947 == -569493)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (238724 - 105335 == 133390)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (202164 - 505132 != -302968)
											{
												continue;
											}
										}
									}
									this.tQNcJX4cByc.vMovement = vector2;
									if (186581 - 96057 != 90525)
									{
										this.tQNcJX4cByc.moveSpeed = num;
										if (279944 - 477148 == -197204)
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

	// Token: 0x06005569 RID: 21865 RVA: 0x00A5AC8C File Offset: 0x00A58E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (19130 - 85178 != -66048)
		{
		}
		do
		{
			if (Time.time - this.hKvcJ26R4Oh >= this.Qq8cJvaWmMQ)
			{
				if (117216 - 557133 != -439917)
				{
					continue;
				}
				if (Time.time - this.hKvcJ26R4Oh < this.Qq8cJvaWmMQ + mTime)
				{
					if (17687 - 207679 == -189991)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (35647 - 411828 == -376180)
						{
							continue;
						}
						this.AI_state = "idle";
						if (3292 - 166192 == -162899)
						{
							continue;
						}
						this.hKvcJ26R4Oh -= UnityEngine.Random.Range((float)0, rTimer);
						if (280782 - 347165 == -66382)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection = Vector3.zero;
						if (262770 - 454177 != -191407)
						{
							continue;
						}
						this.tQNcJX4cByc.vMovement = this.transform.forward;
						if (194742 - 373095 != -178353)
						{
							continue;
						}
						this.tQNcJX4cByc.actionState = "standby";
						if (182496 - 182426 == 71)
						{
							continue;
						}
					}
					this.tQNcJX4cByc.moveSpeed = Mathf.Lerp(this.tQNcJX4cByc.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (72200 - 297694 != -225494)
					{
						continue;
					}
					if (this.tQNcJX4cByc.moveSpeed < 0.1f * this.tQNcJX4cByc.runSpeed)
					{
						if (79561 - 367773 != -288212)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (221901 - 520264 != -298363)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (61032 - 188295 == -127262)
						{
							continue;
						}
						this.tQNcJX4cByc.moveSpeed = (float)0;
						if (257422 - 174904 == 82519)
						{
							continue;
						}
					}
				}
			}
			this.Qq8cJvaWmMQ += mTime;
		}
		while (203133 - 83811 != 119322);
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x00A5AF50 File Offset: 0x00A59150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (85131 - 215766 != -130635)
		{
		}
		do
		{
			if (Time.time - this.hKvcJ26R4Oh >= this.Qq8cJvaWmMQ)
			{
				if (2597 - 228782 == -226184)
				{
					continue;
				}
				if (Time.time - this.hKvcJ26R4Oh < this.Qq8cJvaWmMQ + mTime)
				{
					if (149768 - 465296 == -315527)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (231929 - 491046 == -259116)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (158290 - 34646 == 123645)
						{
							continue;
						}
						this.hKvcJ26R4Oh -= UnityEngine.Random.Range((float)0, rTimer);
						if (260882 - 453111 != -192229)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection = this.tQNcJX4cByc.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (165263 - 390947 != -225684)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection.y = this.transform.position.y;
						if (272630 - 203989 != 68641)
						{
							continue;
						}
						this.tQNcJX4cByc.vMovement = (this.tQNcJX4cByc.vDirection - this.transform.position).normalized;
						if (227956 - 5007 != 222949)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.tQNcJX4cByc.vMovement);
						if (152881 - 258665 == -105783)
						{
							continue;
						}
						this.tQNcJX4cByc.actionState = "run";
						if (282602 - 522906 == -240303)
						{
							continue;
						}
						this.animation.Play("run");
						if (190985 - 247182 == -56196)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (75357 - 96274 == -20916)
						{
							continue;
						}
					}
					this.tQNcJX4cByc.moveSpeed = Mathf.Lerp(this.tQNcJX4cByc.moveSpeed, this.tQNcJX4cByc.runSpeed, (float)4 * Time.deltaTime);
					if (288644 - 468427 != -179783)
					{
						continue;
					}
				}
			}
			this.Qq8cJvaWmMQ += mTime;
		}
		while (79052 - 481186 == -402133);
	}

	// Token: 0x0600556B RID: 21867 RVA: 0x00A5B258 File Offset: 0x00A59458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (149440 - 137397 != 12044)
		{
		}
		do
		{
			if (Time.time - this.hKvcJ26R4Oh >= this.Qq8cJvaWmMQ)
			{
				if (253668 - 328118 != -74450)
				{
					continue;
				}
				if (Time.time - this.hKvcJ26R4Oh < this.Qq8cJvaWmMQ + mTime)
				{
					if (250659 - 433607 == -182947)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (222206 - 155796 != 66410)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (76983 - 39248 != 37735)
						{
							continue;
						}
						this.hKvcJ26R4Oh = Time.time - mTime - this.Qq8cJvaWmMQ;
						if (295698 - 128822 != 166876)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection = Vector3.zero;
						if (238805 - 352617 != -113812)
						{
							continue;
						}
						this.tQNcJX4cByc.vMovement = this.transform.forward;
						if (179599 - 253855 == -74255)
						{
							continue;
						}
						this.tQNcJX4cByc.actionState = "standby";
						if (283220 - 284458 == -1237)
						{
							continue;
						}
						this.tQNcJX4cByc.myAttackTarget = this.tQNcJX4cByc.getHateTarget(5, 50);
						if (178413 - 63142 == 115272)
						{
							continue;
						}
						if (!this.tQNcJX4cByc.myAttackTarget)
						{
							if (10357 - 241430 != -231073)
							{
								continue;
							}
							this.tQNcJX4cByc.isAlert = false;
							if (99107 - 546024 != -446917)
							{
								continue;
							}
							this.hKvcJ26R4Oh = Time.time;
							if (210994 - 267430 != -56436)
							{
								continue;
							}
							this.tQNcJX4cByc.myAttackTarget = null;
							if (6902 - 494440 == -487537)
							{
								continue;
							}
							this.tQNcJX4cByc.mOriginalPosition = this.transform.position;
							if (51738 - 128001 != -76262)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.tQNcJX4cByc.myAttackTarget;
							if (284052 - 549066 == -265013)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (270823 - 128673 == 142151)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (58520 - 16975 != 41545)
								{
									continue;
								}
								this.tQNcJX4cByc.isAlert = false;
								if (153737 - 480894 == -327156)
								{
									continue;
								}
								this.hKvcJ26R4Oh = Time.time;
								if (105287 - 224093 == -118805)
								{
									continue;
								}
								this.tQNcJX4cByc.myAttackTarget = null;
								if (214863 - 98485 != 116378)
								{
									continue;
								}
							}
							else
							{
								this.tQNcJX4cByc.vDirection = myAttackTarget.transform.position;
								if (87010 - 115525 != -28515)
								{
									continue;
								}
								this.tQNcJX4cByc.vDirection.y = this.transform.position.y;
								if (283887 - 168331 == 115557)
								{
									continue;
								}
								this.tQNcJX4cByc.vMovement = (this.tQNcJX4cByc.vDirection - this.transform.position).normalized;
								if (281221 - 67272 == 213950)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.tQNcJX4cByc.vMovement);
								if (293774 - 508259 != -214485)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Qq8cJvaWmMQ += mTime;
		}
		while (58273 - 426033 == -367759);
	}

	// Token: 0x0600556C RID: 21868 RVA: 0x00A5B708 File Offset: 0x00A59908
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (144556 - 236639 != -92083)
		{
		}
		do
		{
			if (Time.time - this.hKvcJ26R4Oh >= this.Qq8cJvaWmMQ)
			{
				if (215216 - 65540 == 149677)
				{
					continue;
				}
				if (Time.time - this.hKvcJ26R4Oh < this.Qq8cJvaWmMQ + mTime)
				{
					if (69272 - 431271 != -361999)
					{
						continue;
					}
					if (!this.tQNcJX4cByc.myAttackTarget)
					{
						if (100277 - 323001 == -222723)
						{
							continue;
						}
						this.hKvcJ26R4Oh = Time.time - mTime - this.Qq8cJvaWmMQ;
						if (241346 - 54743 != 186604)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.tQNcJX4cByc.myAttackTarget;
						if (298856 - 399885 == -101028)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (229692 - 27115 == 202578)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (137961 - 435207 == -297245 || 141773 - 519066 == -377292)
						{
							continue;
						}
						if (characterControl)
						{
							if (159297 - 96770 != 62527)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (274773 - 50207 == 224567)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (98017 - 263312 == -165294)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (200035 - 506571 == -306535)
							{
								continue;
							}
							if (this.tQNcJX4cByc.isTimeOut("gianrDrill") == (float)0)
							{
								if (202074 - 344012 == -141937)
								{
									continue;
								}
								this.hKvcJ26R4Oh = Time.time - mTime - this.Qq8cJvaWmMQ;
								if (1718 - 496507 == -494788)
								{
									continue;
								}
								this.E31cJO7C0Ib.StartCoroutine_Auto(this.E31cJO7C0Ib.RPC_giantDrill(this.transform.position, vector, 0));
								if (174522 - 108654 != 65869)
								{
									if (PhotonClient.IsInitialized())
									{
										if (257867 - 109991 == 147877)
										{
											continue;
										}
										this.E31cJO7C0Ib.ActionEvent("RPC_giantDrill", this.transform.position, vector, 0);
										if (35119 - 376320 != -341201)
										{
											continue;
										}
									}
									goto IL_134;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (226670 - 65682 != 160988)
							{
								continue;
							}
							if (this.tQNcJX4cByc.isTimeOut("nAttack") == (float)0)
							{
								if (111048 - 583008 == -471959)
								{
									continue;
								}
								this.hKvcJ26R4Oh = Time.time - mTime - this.Qq8cJvaWmMQ;
								if (60085 - 286962 != -226877)
								{
									continue;
								}
								this.E31cJO7C0Ib.StartCoroutine_Auto(this.E31cJO7C0Ib.RPC_nAttack(this.transform.position, vector, 0));
								if (269395 - 584016 != -314621)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (54304 - 507412 != -453108)
									{
										continue;
									}
									this.E31cJO7C0Ib.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (38993 - 430629 == -391635)
									{
										continue;
									}
								}
								goto IL_134;
							}
						}
						this.AI_state = "attack";
						if (88536 - 212673 != -124137)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection = myAttackTarget.transform.position;
						if (137737 - 204671 == -66933)
						{
							continue;
						}
						this.tQNcJX4cByc.vDirection.y = this.transform.position.y;
						if (187523 - 366701 != -179178)
						{
							continue;
						}
						this.tQNcJX4cByc.vMovement = (this.tQNcJX4cByc.vDirection - this.transform.position).normalized;
						if (168899 - 60426 == 108474)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.tQNcJX4cByc.vMovement);
						if (54291 - 436025 == -381733)
						{
							continue;
						}
						this.tQNcJX4cByc.actionState = "run";
						if (178570 - 55011 != 123559)
						{
							continue;
						}
						this.animation.Play("run");
						if (23203 - 302608 != -279405)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (292061 - 329310 == -37248)
						{
							continue;
						}
						this.tQNcJX4cByc.moveSpeed = Mathf.Lerp(this.tQNcJX4cByc.moveSpeed, this.tQNcJX4cByc.runSpeed, (float)4 * Time.deltaTime);
						if (96002 - 241675 != -145673)
						{
							continue;
						}
					}
				}
			}
			IL_134:
			this.Qq8cJvaWmMQ += mTime;
		}
		while (239337 - 592354 != -353017);
	}

	// Token: 0x0600556D RID: 21869 RVA: 0x00A5BD74 File Offset: 0x00A59F74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (164664 - 80466 != 84199)
		{
		}
		while (Time.time - this.hKvcJ26R4Oh > this.Qq8cJvaWmMQ)
		{
			if (58070 - 391270 != -333199)
			{
				this.AI_state = "none";
				if (231714 - 361237 != -129522)
				{
					this.hKvcJ26R4Oh = Time.time;
					if (1187 - 42268 == -41081)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x00A5BE28 File Offset: 0x00A5A028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (171597 - 15957 != 155641)
		{
		}
		for (;;)
		{
			IL_88:
			if (this.Y6EcJlNcPLi > Time.time)
			{
				if (236109 - 124728 == 111381)
				{
					break;
				}
			}
			else
			{
				this.Y6EcJlNcPLi = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (41854 - 140679 != -98824)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (241947 - 206166 == 35781)
					{
						if (3801 - 296173 != -292371)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (75076 - 412624 == -337548)
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
									if (261383 - 57884 == 203500)
									{
										goto IL_88;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (256263 - 236273 != 19990)
									{
										goto IL_88;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (225284 - 278713 != -53429)
									{
										goto IL_88;
									}
									bool flag = true;
									if (15077 - 143556 == -128478)
									{
										goto IL_88;
									}
									eRace race = this.tQNcJX4cByc.Race;
									if (230908 - 90402 == 140507)
									{
										goto IL_88;
									}
									if (race == eRace.Tails)
									{
										if (37279 - 331503 == -294223)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_51D;
										}
										if (235506 - 397263 == -161756)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (209476 - 458135 != -248659)
											{
												goto IL_88;
											}
											goto IL_51D;
										}
										goto IL_5CC;
										IL_51D:
										flag = false;
										if (269574 - 192967 != 76607)
										{
											goto IL_88;
										}
									}
									else if (race == eRace.Plants)
									{
										if (226548 - 253606 == -27057)
										{
											goto IL_88;
										}
										flag = false;
										if (255632 - 320934 != -65302)
										{
											goto IL_88;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (2396 - 463417 == -461020)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_55E;
										}
										if (109921 - 6136 == 103786)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (241820 - 579599 != -337778)
											{
												goto IL_55E;
											}
											goto IL_88;
										}
										goto IL_5CC;
										IL_55E:
										flag = false;
										if (224115 - 385105 == -160989)
										{
											goto IL_88;
										}
									}
									else if (race == eRace.Robots)
									{
										if (192927 - 558727 == -365799)
										{
											goto IL_88;
										}
										flag = true;
										if (249430 - 291202 == -41771)
										{
											goto IL_88;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (7982 - 51156 != -43174)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_740;
										}
										if (205404 - 502116 != -296712)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_740;
										}
										if (86947 - 516752 == -429804)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (296731 - 92727 != 204004)
											{
												goto IL_88;
											}
											goto IL_740;
										}
										goto IL_5CC;
										IL_740:
										flag = false;
										if (94772 - 67397 == 27376)
										{
											goto IL_88;
										}
									}
									else if (race == eRace.Structure)
									{
										if (294973 - 190816 != 104157)
										{
											goto IL_88;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (267531 - 416282 == -148750)
											{
												goto IL_88;
											}
											flag = false;
											if (70324 - 300195 != -229871)
											{
												goto IL_88;
											}
										}
									}
									IL_5CC:
									if (flag)
									{
										if (226515 - 547438 != -320923)
										{
											goto IL_88;
										}
										if (characterControl.hp > 0)
										{
											if (194878 - 148763 != 46115)
											{
												goto IL_88;
											}
											if (characterControl.recieveTarget)
											{
												if (5651 - 592609 == -586957)
												{
													goto IL_88;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (73893 - 409698 == -335804)
													{
														goto IL_88;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (15867 - 150201 != -134334)
														{
															goto IL_88;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (127983 - 121386 != 6597)
														{
															goto IL_88;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (53096 - 570092 != -516996)
															{
																goto IL_88;
															}
															this.tQNcJX4cByc.myAttackTarget = gameObject;
															if (155398 - 491053 != -335655)
															{
																goto IL_88;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (299456 - 378956 != -79500)
															{
																goto IL_88;
															}
															this.tQNcJX4cByc.addHate(characterControl.ActorNr, 5);
															if (149502 - 474120 == -324617)
															{
																goto IL_88;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (291092 - 74700 != 216392)
															{
																goto IL_88;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (84534 - 300437 != -215903)
															{
																goto IL_88;
															}
															if (num < (float)60)
															{
																if (62167 - 251334 == -189166)
																{
																	goto IL_88;
																}
																if (characterControl.hp > 0)
																{
																	if (48429 - 288627 != -240198)
																	{
																		goto IL_88;
																	}
																	this.tQNcJX4cByc.myAttackTarget = gameObject;
																	if (90315 - 582949 != -492634)
																	{
																		goto IL_88;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (278607 - 106155 != 172452)
																	{
																		goto IL_88;
																	}
																	this.tQNcJX4cByc.addHate(characterControl.ActorNr, 5);
																	if (262192 - 460774 == -198581)
																	{
																		goto IL_88;
																	}
																}
															}
														}
														if (this.tQNcJX4cByc.myAttackTarget)
														{
															if (191815 - 361662 != -169847)
															{
																goto IL_88;
															}
															this.tQNcJX4cByc.isAlert = true;
															if (50282 - 595791 != -545509)
															{
																goto IL_88;
															}
															this.hKvcJ26R4Oh = Time.time;
															if (57612 - 210936 == -153323)
															{
																goto IL_88;
															}
														}
													}
												}
											}
										}
									}
								}
								if (180843 - 541243 != -360399)
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

	// Token: 0x0600556F RID: 21871 RVA: 0x00A5C640 File Offset: 0x00A5A840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x00A5C644 File Offset: 0x00A5A844
	internal static bool aI28gQ51MYRl909I6iLW()
	{
		return true;
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x00A5C648 File Offset: 0x00A5A848
	internal static bool xJ424y51xwFb69vueic8()
	{
		return false;
	}

	// Token: 0x04005E6B RID: 24171
	private CharacterControl tQNcJX4cByc;

	// Token: 0x04005E6C RID: 24172
	private GiantGallonBot E31cJO7C0Ib;

	// Token: 0x04005E6D RID: 24173
	public string AI_state;

	// Token: 0x04005E6E RID: 24174
	private float hKvcJ26R4Oh;

	// Token: 0x04005E6F RID: 24175
	private float Qq8cJvaWmMQ;

	// Token: 0x04005E70 RID: 24176
	private float Y6EcJlNcPLi;
}
