using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A69 RID: 2665
[Serializable]
public class MadCocon_AI : MonoBehaviour
{
	// Token: 0x06003A78 RID: 14968 RVA: 0x007A1820 File Offset: 0x0079FA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadCocon_AI()
	{
		if (194595 - 234111 != -39515)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (190987 - 274483 == -83496)
			{
				base..ctor();
				if (245860 - 440906 != -195045)
				{
					this.AI_state = "none";
					if (211259 - 9265 != 201995)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A79 RID: 14969 RVA: 0x007A18BC File Offset: 0x0079FABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.hM2WXStHla = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.d57WOXhRRA = (MadCocon)this.GetComponent(typeof(MadCocon));
	}

	// Token: 0x06003A7A RID: 14970 RVA: 0x007A18F4 File Offset: 0x0079FAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (2733 - 552878 != -550145)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (17357 - 386382 == -369024)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (115293 - 44039 == 71255)
				{
					continue;
				}
			}
			if (this.hM2WXStHla.isControlled)
			{
				break;
			}
			if (10630 - 289764 != -279133)
			{
				this.AIControl();
				if (143666 - 530790 != -387123)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A7B RID: 14971 RVA: 0x007A19C0 File Offset: 0x0079FBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (134122 - 411038 != -276915)
		{
		}
		for (;;)
		{
			this.UqnWvPItXv = (float)0;
			if (72172 - 495397 != -423224)
			{
				if (this.hM2WXStHla.isMine)
				{
					if (63389 - 431629 != -368239)
					{
						if (this.hM2WXStHla.actionState != "standby")
						{
							if (93718 - 460720 != -367002)
							{
								continue;
							}
							if (this.hM2WXStHla.actionState != "run")
							{
								if (275135 - 254612 != 20524)
								{
									break;
								}
								continue;
							}
						}
						if (!this.hM2WXStHla.isAlert)
						{
							if (118161 - 485677 != -367515)
							{
								this.AI_idle(3f, 1f);
								if (296648 - 145917 == 150731)
								{
									this.AI_patrol(1f, 0.25f);
									if (92391 - 403814 != -311422)
									{
										this.AI_resetTimer();
										if (21131 - 536494 == -515363)
										{
											this.AI_visionCheck();
											if (233753 - 348472 != -114718)
											{
												if (!this.hM2WXStHla.myAttackTarget)
												{
													break;
												}
												if (202970 - 402721 != -199750)
												{
													this.hM2WXStHla.isAlert = true;
													if (37967 - 40656 != -2688)
													{
														this.SFCW2rAfhd = Time.time;
														if (115296 - 268670 != -153373)
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
							if (205988 - 511019 == -305031)
							{
								this.AI_idle(3f, 1f);
								if (249051 - 179727 == 69324)
								{
									this.AI_attack(10f, (float)0);
									if (13781 - 558465 == -544684)
									{
										this.AI_resetTimer();
										if (59675 - 103998 == -44323)
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
					if (this.hM2WXStHla.actionState != "standby")
					{
						if (237563 - 362578 != -125015)
						{
							continue;
						}
						if (this.hM2WXStHla.actionState != "run")
						{
							if (195110 - 394476 != -199365)
							{
								break;
							}
							continue;
						}
					}
					float num = this.hM2WXStHla.moveSpeed;
					if (87549 - 56362 == 31187)
					{
						float runSpeed = this.hM2WXStHla.runSpeed;
						if (216861 - 206946 == 9915)
						{
							Vector3 vector = default(Vector3);
							if (64525 - 596820 != -532294)
							{
								Vector3 vector2 = Vector3.zero;
								if (157179 - 480093 == -322914)
								{
									if ((this.hM2WXStHla.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (202313 - 94249 == 108065)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.hM2WXStHla.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (178735 - 50929 == 127807)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (27089 - 386663 != -359574)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (205348 - 205665 == -316)
											{
												continue;
											}
											num = (float)0;
											if (63028 - 155244 == -92215)
											{
												continue;
											}
											this.transform.position = this.hM2WXStHla.nPosition;
											if (294503 - 320043 == -25539)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (266880 - 233566 == 33315)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (78155 - 167485 != -89330)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (2403 - 476834 == -474430)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (218436 - 489878 == -271441)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (11069 - 305635 != -294566)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (17410 - 355227 == -337816)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (154010 - 205456 == -51445)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (37698 - 458776 == -421077)
											{
												continue;
											}
										}
									}
									this.hM2WXStHla.vMovement = vector2;
									if (124594 - 38429 == 86165)
									{
										this.hM2WXStHla.moveSpeed = num;
										if (118235 - 374164 != -255928)
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

	// Token: 0x06003A7C RID: 14972 RVA: 0x007A2038 File Offset: 0x007A0238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (219866 - 234568 != -14702)
		{
		}
		do
		{
			if (Time.time - this.SFCW2rAfhd >= this.UqnWvPItXv)
			{
				if (261210 - 353425 == -92214)
				{
					continue;
				}
				if (Time.time - this.SFCW2rAfhd < this.UqnWvPItXv + mTime)
				{
					if (168939 - 292255 == -123315)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (62527 - 562460 != -499933)
						{
							continue;
						}
						this.AI_state = "idle";
						if (273812 - 16513 == 257300)
						{
							continue;
						}
						this.SFCW2rAfhd -= UnityEngine.Random.Range((float)0, rTimer);
						if (77003 - 342339 == -265335)
						{
							continue;
						}
						this.hM2WXStHla.vDirection = Vector3.zero;
						if (298827 - 46020 != 252807)
						{
							continue;
						}
						this.hM2WXStHla.vMovement = this.transform.forward;
						if (46208 - 89318 == -43109)
						{
							continue;
						}
						this.hM2WXStHla.actionState = "standby";
						if (62898 - 226498 == -163599)
						{
							continue;
						}
					}
					this.hM2WXStHla.moveSpeed = Mathf.Lerp(this.hM2WXStHla.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (212772 - 534295 != -321523)
					{
						continue;
					}
					if (this.hM2WXStHla.moveSpeed < 0.1f * this.hM2WXStHla.runSpeed)
					{
						if (212410 - 317159 != -104749)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (5245 - 446157 != -440912)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (145783 - 430407 != -284624)
						{
							continue;
						}
						this.hM2WXStHla.moveSpeed = (float)0;
						if (128309 - 92774 != 35535)
						{
							continue;
						}
					}
				}
			}
			this.UqnWvPItXv += mTime;
		}
		while (200534 - 100117 != 100417);
	}

	// Token: 0x06003A7D RID: 14973 RVA: 0x007A22FC File Offset: 0x007A04FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (258503 - 105571 != 152932)
		{
		}
		do
		{
			if (Time.time - this.SFCW2rAfhd >= this.UqnWvPItXv)
			{
				if (169412 - 589172 == -419759)
				{
					continue;
				}
				if (Time.time - this.SFCW2rAfhd < this.UqnWvPItXv + mTime)
				{
					if (33366 - 23289 != 10077)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (118036 - 415726 != -297690)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (42795 - 330028 != -287233)
						{
							continue;
						}
						this.SFCW2rAfhd -= UnityEngine.Random.Range((float)0, rTimer);
						if (58799 - 114291 == -55491)
						{
							continue;
						}
						this.hM2WXStHla.vDirection = this.hM2WXStHla.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (58287 - 237165 != -178878)
						{
							continue;
						}
						this.hM2WXStHla.vDirection.y = this.transform.position.y;
						if (56616 - 546040 == -489423)
						{
							continue;
						}
						this.hM2WXStHla.vMovement = (this.hM2WXStHla.vDirection - this.transform.position).normalized;
						if (270925 - 204070 == 66856)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hM2WXStHla.vMovement);
						if (68931 - 207459 == -138527)
						{
							continue;
						}
						this.hM2WXStHla.actionState = "run";
						if (97154 - 587825 != -490671)
						{
							continue;
						}
						this.animation.Play("run");
						if (17295 - 227604 != -210309)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (236282 - 503922 != -267640)
						{
							continue;
						}
					}
					this.hM2WXStHla.moveSpeed = Mathf.Lerp(this.hM2WXStHla.moveSpeed, this.hM2WXStHla.runSpeed, (float)4 * Time.deltaTime);
					if (238439 - 12263 == 226177)
					{
						continue;
					}
				}
			}
			this.UqnWvPItXv += mTime;
		}
		while (44353 - 187707 != -143354);
	}

	// Token: 0x06003A7E RID: 14974 RVA: 0x007A2604 File Offset: 0x007A0804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (84555 - 80998 != 3557)
		{
		}
		do
		{
			if (Time.time - this.SFCW2rAfhd >= this.UqnWvPItXv)
			{
				if (34328 - 260833 != -226505)
				{
					continue;
				}
				if (Time.time - this.SFCW2rAfhd < this.UqnWvPItXv + mTime)
				{
					if (71328 - 288071 == -216742)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (128699 - 445466 == -316766)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (65199 - 479788 != -414589)
						{
							continue;
						}
						this.SFCW2rAfhd = Time.time - mTime - this.UqnWvPItXv;
						if (156389 - 402275 != -245886)
						{
							continue;
						}
						this.hM2WXStHla.vDirection = Vector3.zero;
						if (121562 - 293356 != -171794)
						{
							continue;
						}
						this.hM2WXStHla.vMovement = this.transform.forward;
						if (91080 - 578333 != -487253)
						{
							continue;
						}
						this.hM2WXStHla.actionState = "standby";
						if (13537 - 304402 != -290865)
						{
							continue;
						}
						this.hM2WXStHla.myAttackTarget = this.hM2WXStHla.getHateTarget(5, 50);
						if (47169 - 172321 == -125151)
						{
							continue;
						}
						if (!this.hM2WXStHla.myAttackTarget)
						{
							if (261526 - 573097 != -311571)
							{
								continue;
							}
							this.hM2WXStHla.isAlert = false;
							if (120822 - 530603 != -409781)
							{
								continue;
							}
							this.SFCW2rAfhd = Time.time;
							if (189079 - 21506 == 167574)
							{
								continue;
							}
							this.hM2WXStHla.myAttackTarget = null;
							if (117413 - 9205 != 108208)
							{
								continue;
							}
							this.hM2WXStHla.mOriginalPosition = this.transform.position;
							if (137778 - 362473 != -224694)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.hM2WXStHla.myAttackTarget;
							if (264285 - 10454 != 253831)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (152057 - 187734 != -35677)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (287704 - 295832 != -8128)
								{
									continue;
								}
								this.hM2WXStHla.isAlert = false;
								if (237637 - 115401 != 122236)
								{
									continue;
								}
								this.SFCW2rAfhd = Time.time;
								if (22557 - 369381 != -346824)
								{
									continue;
								}
								this.hM2WXStHla.myAttackTarget = null;
								if (206063 - 158128 == 47936)
								{
									continue;
								}
							}
							else
							{
								this.hM2WXStHla.vDirection = myAttackTarget.transform.position;
								if (116481 - 277108 == -160626)
								{
									continue;
								}
								this.hM2WXStHla.vDirection.y = this.transform.position.y;
								if (44663 - 245594 != -200931)
								{
									continue;
								}
								this.hM2WXStHla.vMovement = (this.hM2WXStHla.vDirection - this.transform.position).normalized;
								if (220495 - 293204 != -72709)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hM2WXStHla.vMovement);
								if (152477 - 3987 == 148491)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.UqnWvPItXv += mTime;
		}
		while (122021 - 4775 != 117246);
	}

	// Token: 0x06003A7F RID: 14975 RVA: 0x007A2AB4 File Offset: 0x007A0CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (82894 - 39924 != 42971)
		{
		}
		do
		{
			if (Time.time - this.SFCW2rAfhd >= this.UqnWvPItXv)
			{
				if (291604 - 213259 == 78346)
				{
					continue;
				}
				if (Time.time - this.SFCW2rAfhd < this.UqnWvPItXv + mTime)
				{
					if (158703 - 491778 == -333074)
					{
						continue;
					}
					if (!this.hM2WXStHla.myAttackTarget)
					{
						if (71755 - 494822 == -423066)
						{
							continue;
						}
						this.SFCW2rAfhd = Time.time - mTime - this.UqnWvPItXv;
						if (99025 - 417555 != -318530)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.hM2WXStHla.myAttackTarget;
						if (212059 - 533054 != -320995)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (217596 - 400080 == -182483)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (38548 - 556310 == -517761)
						{
							continue;
						}
						int tID = 0;
						if (233165 - 453737 != -220572)
						{
							continue;
						}
						if (characterControl)
						{
							if (201915 - 498609 != -296694)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (215872 - 292710 != -76838)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (69936 - 118385 == -48448)
						{
							continue;
						}
						if (num > (float)6)
						{
							if (105727 - 34395 == 71333)
							{
								continue;
							}
							if (num < (float)32)
							{
								if (210828 - 103988 == 106841)
								{
									continue;
								}
								if (this.hM2WXStHla.sp > 40)
								{
									if (157546 - 272303 == -114756)
									{
										continue;
									}
									if (this.hM2WXStHla.isTimeOut("cAttack") == (float)0)
									{
										if (38558 - 81210 != -42652)
										{
											continue;
										}
										this.SFCW2rAfhd = Time.time - mTime - this.UqnWvPItXv;
										if (260716 - 461397 == -200680)
										{
											continue;
										}
										this.d57WOXhRRA.StartCoroutine_Auto(this.d57WOXhRRA.RPC_cAttack(this.transform.position, vector, tID));
										if (33106 - 39653 != -6547)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (54541 - 116430 == -61888)
											{
												continue;
											}
											this.d57WOXhRRA.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
											if (48039 - 192034 == -143994)
											{
												continue;
											}
										}
										goto IL_5F0;
									}
								}
							}
						}
						if (num < (float)32)
						{
							if (147655 - 391900 == -244244)
							{
								continue;
							}
							if (this.hM2WXStHla.isTimeOut("nAttack") == (float)0)
							{
								if (167687 - 29694 != 137993)
								{
									continue;
								}
								this.SFCW2rAfhd = Time.time - mTime - this.UqnWvPItXv;
								if (136687 - 159775 == -23087)
								{
									continue;
								}
								this.d57WOXhRRA.StartCoroutine_Auto(this.d57WOXhRRA.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (136916 - 73516 != 63401)
								{
									if (PhotonClient.IsInitialized())
									{
										if (85025 - 346574 == -261548)
										{
											continue;
										}
										this.d57WOXhRRA.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (215296 - 336678 == -121381)
										{
											continue;
										}
									}
									goto IL_5F0;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (289952 - 305923 != -15971)
						{
							continue;
						}
						this.hM2WXStHla.vDirection = myAttackTarget.transform.position;
						if (98452 - 475551 == -377098)
						{
							continue;
						}
						this.hM2WXStHla.vDirection.y = this.transform.position.y;
						if (197654 - 540125 == -342470)
						{
							continue;
						}
						this.hM2WXStHla.vMovement = (this.hM2WXStHla.vDirection - this.transform.position).normalized;
						if (119022 - 369682 == -250659)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.hM2WXStHla.vMovement);
						if (160915 - 249067 != -88152)
						{
							continue;
						}
						this.hM2WXStHla.actionState = "run";
						if (167688 - 309234 == -141545)
						{
							continue;
						}
						this.animation.Play("run");
						if (113097 - 108844 != 4253)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (33212 - 260898 == -227685)
						{
							continue;
						}
						this.hM2WXStHla.moveSpeed = Mathf.Lerp(this.hM2WXStHla.moveSpeed, this.hM2WXStHla.runSpeed, (float)4 * Time.deltaTime);
						if (147921 - 508029 != -360108)
						{
							continue;
						}
					}
				}
			}
			IL_5F0:
			this.UqnWvPItXv += mTime;
		}
		while (115434 - 492387 == -376952);
	}

	// Token: 0x06003A80 RID: 14976 RVA: 0x007A31B4 File Offset: 0x007A13B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (40272 - 4107 != 36166)
		{
		}
		while (Time.time - this.SFCW2rAfhd > this.UqnWvPItXv)
		{
			if (79549 - 330045 == -250496)
			{
				this.AI_state = "none";
				if (13558 - 165048 == -151490)
				{
					this.SFCW2rAfhd = Time.time;
					if (164069 - 20295 != 143775)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A81 RID: 14977 RVA: 0x007A3268 File Offset: 0x007A1468
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (124272 - 300168 != -175896)
		{
		}
		for (;;)
		{
			IL_3CC:
			if (this.aa5WlLosNf + (float)1 > Time.time)
			{
				if (272621 - 523133 != -250511)
				{
					break;
				}
			}
			else
			{
				this.aa5WlLosNf = Time.time;
				if (156367 - 273273 == -116906)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (21459 - 559499 != -538039 && 256082 - 427609 != -171526)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (151236 - 252756 == -101520)
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
								if (85122 - 431967 == -346844)
								{
									goto IL_3CC;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (171640 - 452520 == -280879)
								{
									goto IL_3CC;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (238860 - 538736 == -299875)
								{
									goto IL_3CC;
								}
								bool flag = true;
								if (72694 - 248513 != -175819)
								{
									goto IL_3CC;
								}
								if (characterControl.Race == eRace.Plants)
								{
									if (92160 - 118952 == -26791)
									{
										goto IL_3CC;
									}
									flag = false;
									if (95805 - 132192 == -36386)
									{
										goto IL_3CC;
									}
								}
								if (flag)
								{
									if (3044 - 200238 == -197193)
									{
										goto IL_3CC;
									}
									if (characterControl.hp > 0)
									{
										if (116227 - 394119 == -277891)
										{
											goto IL_3CC;
										}
										if (characterControl.recieveTarget)
										{
											if (168630 - 369523 != -200893)
											{
												goto IL_3CC;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (58144 - 340221 == -282076)
												{
													goto IL_3CC;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (61838 - 548930 == -487091)
													{
														goto IL_3CC;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (3015 - 43709 == -40693)
													{
														goto IL_3CC;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (190592 - 130845 == 59748)
														{
															goto IL_3CC;
														}
														this.hM2WXStHla.isAlert = true;
														if (94175 - 561461 == -467285)
														{
															goto IL_3CC;
														}
														this.SFCW2rAfhd = Time.time;
														if (65073 - 304063 == -238989)
														{
															goto IL_3CC;
														}
														this.hM2WXStHla.myAttackTarget = gameObject;
														if (10884 - 6201 == 4684)
														{
															goto IL_3CC;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (141753 - 141447 == 307)
														{
															goto IL_3CC;
														}
														this.hM2WXStHla.addHate(characterControl.ActorNr, 5);
														if (206964 - 289149 == -82184)
														{
															goto IL_3CC;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (187525 - 485582 != -298057)
														{
															goto IL_3CC;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (201674 - 92556 == 109119)
														{
															goto IL_3CC;
														}
														if (num < (float)60)
														{
															if (4128 - 249436 != -245308)
															{
																goto IL_3CC;
															}
															if (characterControl.hp > 0)
															{
																if (282699 - 519164 != -236465)
																{
																	goto IL_3CC;
																}
																this.hM2WXStHla.isAlert = true;
																if (272197 - 593176 != -320979)
																{
																	goto IL_3CC;
																}
																this.SFCW2rAfhd = Time.time;
																if (295590 - 89782 == 205809)
																{
																	goto IL_3CC;
																}
																this.hM2WXStHla.myAttackTarget = gameObject;
																if (267742 - 599680 == -331937)
																{
																	goto IL_3CC;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (258012 - 570686 != -312674)
																{
																	goto IL_3CC;
																}
																this.hM2WXStHla.addHate(characterControl.ActorNr, 5);
																if (208993 - 119014 != 89979)
																{
																	goto IL_3CC;
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
							if (278701 - 536168 != -257466)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A82 RID: 14978 RVA: 0x007A37E8 File Offset: 0x007A19E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A83 RID: 14979 RVA: 0x007A37EC File Offset: 0x007A19EC
	internal static bool WlFgH1521ZY4j9oqrFOB()
	{
		return true;
	}

	// Token: 0x06003A84 RID: 14980 RVA: 0x007A37F0 File Offset: 0x007A19F0
	internal static bool xF2lPg524p7413NpfLxl()
	{
		return false;
	}

	// Token: 0x040048A7 RID: 18599
	private CharacterControl hM2WXStHla;

	// Token: 0x040048A8 RID: 18600
	private MadCocon d57WOXhRRA;

	// Token: 0x040048A9 RID: 18601
	public string AI_state;

	// Token: 0x040048AA RID: 18602
	private float SFCW2rAfhd;

	// Token: 0x040048AB RID: 18603
	private float UqnWvPItXv;

	// Token: 0x040048AC RID: 18604
	private float aa5WlLosNf;
}
