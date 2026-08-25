using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200042A RID: 1066
[Serializable]
public class FireGod_AI : MonoBehaviour
{
	// Token: 0x060018DA RID: 6362 RVA: 0x00289434 File Offset: 0x00287634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FireGod_AI()
	{
		if (170980 - 220853 != -49872)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (25383 - 447555 != -422171)
			{
				base..ctor();
				if (73074 - 230583 != -157508)
				{
					this.AI_state = "none";
					if (180868 - 295897 != -115028)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060018DB RID: 6363 RVA: 0x002894D0 File Offset: 0x002876D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.a2K2rdaBIv = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Jju2xq9B7J = (FireGod)this.GetComponent(typeof(FireGod));
	}

	// Token: 0x060018DC RID: 6364 RVA: 0x00289508 File Offset: 0x00287708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (217672 - 121550 != 96123)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (251186 - 347585 != -96399)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (283707 - 542974 == -259266)
				{
					continue;
				}
			}
			if (this.a2K2rdaBIv.isControlled)
			{
				break;
			}
			if (186766 - 401458 != -214691)
			{
				this.AIControl();
				if (110921 - 147280 != -36358)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060018DD RID: 6365 RVA: 0x002895D4 File Offset: 0x002877D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (298449 - 239339 != 59110)
		{
		}
		for (;;)
		{
			this.KQr2YFxwwM = (float)0;
			if (59867 - 389397 == -329530)
			{
				if (this.a2K2rdaBIv.isMine)
				{
					if (62245 - 430588 != -368342)
					{
						if (this.a2K2rdaBIv.actionState != "standby")
						{
							if (191221 - 288515 == -97293)
							{
								continue;
							}
							if (this.a2K2rdaBIv.actionState != "run")
							{
								if (149552 - 436957 != -287404)
								{
									break;
								}
								continue;
							}
						}
						if (!this.a2K2rdaBIv.isAlert)
						{
							if (165759 - 7662 != 158098)
							{
								this.AI_idle(3f, 1f);
								if (285771 - 547548 == -261777)
								{
									this.AI_patrol(1f, 0.25f);
									if (2902 - 111509 == -108607)
									{
										this.AI_resetTimer();
										if (26510 - 461913 != -435402)
										{
											this.AI_visionCheck();
											if (81818 - 396243 != -314424)
											{
												if (!this.a2K2rdaBIv.myAttackTarget)
												{
													break;
												}
												if (297416 - 120674 == 176742)
												{
													this.a2K2rdaBIv.isAlert = true;
													if (262768 - 151771 != 110998)
													{
														this.ahO2TXahQH = Time.time;
														if (12540 - 149112 == -136572)
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
							if (241407 - 223953 != 17455)
							{
								this.AI_idle(2f, 1f);
								if (63470 - 582067 == -518597)
								{
									this.AI_attack(10f, (float)0);
									if (184752 - 526534 == -341782)
									{
										this.AI_resetTimer();
										if (286830 - 202831 == 83999)
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
					if (this.a2K2rdaBIv.actionState != "standby")
					{
						if (65187 - 513603 != -448416)
						{
							continue;
						}
						if (this.a2K2rdaBIv.actionState != "run")
						{
							if (295539 - 472073 != -176534)
							{
								continue;
							}
							break;
						}
					}
					float num = this.a2K2rdaBIv.moveSpeed;
					if (215793 - 469461 != -253667)
					{
						float runSpeed = this.a2K2rdaBIv.runSpeed;
						if (123301 - 580489 != -457187)
						{
							Vector3 vector = default(Vector3);
							if (250173 - 1658 != 248516)
							{
								Vector3 vector2 = Vector3.zero;
								if (143713 - 276538 == -132825)
								{
									if ((this.a2K2rdaBIv.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (63679 - 208831 != -145152)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.a2K2rdaBIv.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (35850 - 374749 != -338899)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (214716 - 48213 == 166504)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (123478 - 48652 != 74826)
											{
												continue;
											}
											num = (float)0;
											if (232493 - 216807 != 15686)
											{
												continue;
											}
											this.transform.position = this.a2K2rdaBIv.nPosition;
											if (212306 - 213380 == -1073)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (232299 - 100144 == 132156)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (128073 - 296527 == -168453)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (80607 - 239882 != -159275)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (240039 - 485167 == -245127)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (35919 - 283970 == -248050)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (215537 - 372660 != -157123)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (286886 - 84786 != 202100)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (260276 - 188304 != 71972)
											{
												continue;
											}
										}
									}
									this.a2K2rdaBIv.vMovement = vector2;
									if (117289 - 249759 != -132469)
									{
										this.a2K2rdaBIv.moveSpeed = num;
										if (153444 - 198745 == -45301)
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

	// Token: 0x060018DE RID: 6366 RVA: 0x00289C4C File Offset: 0x00287E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (43176 - 257704 != -214527)
		{
		}
		do
		{
			if (Time.time - this.ahO2TXahQH >= this.KQr2YFxwwM)
			{
				if (196142 - 159195 == 36948)
				{
					continue;
				}
				if (Time.time - this.ahO2TXahQH < this.KQr2YFxwwM + mTime)
				{
					if (106936 - 7000 != 99936)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (187696 - 596499 == -408802)
						{
							continue;
						}
						this.AI_state = "idle";
						if (255950 - 105466 == 150485)
						{
							continue;
						}
						this.ahO2TXahQH -= UnityEngine.Random.Range((float)0, rTimer);
						if (165590 - 74819 != 90771)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection = Vector3.zero;
						if (203165 - 178475 != 24690)
						{
							continue;
						}
						this.a2K2rdaBIv.vMovement = this.transform.forward;
						if (230654 - 358793 == -128138)
						{
							continue;
						}
						this.a2K2rdaBIv.actionState = "standby";
						if (235397 - 354216 != -118819)
						{
							continue;
						}
					}
					this.a2K2rdaBIv.moveSpeed = Mathf.Lerp(this.a2K2rdaBIv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (299330 - 480650 != -181320)
					{
						continue;
					}
					if (this.a2K2rdaBIv.moveSpeed < 0.1f * this.a2K2rdaBIv.runSpeed)
					{
						if (294928 - 244705 == 50224)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (133907 - 543960 == -410052)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (81431 - 43812 != 37619)
						{
							continue;
						}
						this.a2K2rdaBIv.moveSpeed = (float)0;
						if (152830 - 75186 == 77645)
						{
							continue;
						}
					}
				}
			}
			this.KQr2YFxwwM += mTime;
		}
		while (96167 - 303149 != -206982);
	}

	// Token: 0x060018DF RID: 6367 RVA: 0x00289F10 File Offset: 0x00288110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (297839 - 5988 != 291852)
		{
		}
		do
		{
			if (Time.time - this.ahO2TXahQH >= this.KQr2YFxwwM)
			{
				if (265928 - 83591 == 182338)
				{
					continue;
				}
				if (Time.time - this.ahO2TXahQH < this.KQr2YFxwwM + mTime)
				{
					if (222535 - 132736 == 89800)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (254432 - 170238 == 84195)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (82286 - 271283 == -188996)
						{
							continue;
						}
						this.ahO2TXahQH -= UnityEngine.Random.Range((float)0, rTimer);
						if (104912 - 378257 == -273344)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection = this.a2K2rdaBIv.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (109939 - 112564 == -2624)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection.y = this.transform.position.y;
						if (50234 - 571759 != -521525)
						{
							continue;
						}
						this.a2K2rdaBIv.vMovement = (this.a2K2rdaBIv.vDirection - this.transform.position).normalized;
						if (150431 - 162274 != -11843)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.a2K2rdaBIv.vMovement);
						if (155333 - 574777 == -419443)
						{
							continue;
						}
						this.a2K2rdaBIv.actionState = "run";
						if (114563 - 331580 == -217016)
						{
							continue;
						}
						this.animation.Play("run");
						if (115685 - 47000 != 68685)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (140436 - 401496 == -261059)
						{
							continue;
						}
					}
					this.a2K2rdaBIv.moveSpeed = Mathf.Lerp(this.a2K2rdaBIv.moveSpeed, this.a2K2rdaBIv.runSpeed, (float)4 * Time.deltaTime);
					if (75680 - 301528 != -225848)
					{
						continue;
					}
				}
			}
			this.KQr2YFxwwM += mTime;
		}
		while (241750 - 102605 == 139146);
	}

	// Token: 0x060018E0 RID: 6368 RVA: 0x0028A218 File Offset: 0x00288418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (83819 - 186604 != -102785)
		{
		}
		do
		{
			if (Time.time - this.ahO2TXahQH >= this.KQr2YFxwwM)
			{
				if (21203 - 234088 == -212884)
				{
					continue;
				}
				if (Time.time - this.ahO2TXahQH < this.KQr2YFxwwM + mTime)
				{
					if (119211 - 471510 != -352299)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (136691 - 454156 != -317465)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (247575 - 307520 == -59944)
						{
							continue;
						}
						this.ahO2TXahQH = Time.time - mTime - this.KQr2YFxwwM;
						if (283366 - 141508 == 141859)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection = Vector3.zero;
						if (113474 - 532077 == -418602)
						{
							continue;
						}
						this.a2K2rdaBIv.vMovement = this.transform.forward;
						if (82392 - 303792 != -221400)
						{
							continue;
						}
						this.a2K2rdaBIv.actionState = "standby";
						if (288706 - 468665 == -179958)
						{
							continue;
						}
						this.a2K2rdaBIv.myAttackTarget = this.a2K2rdaBIv.getHateTarget(5, 50);
						if (128513 - 294988 != -166475)
						{
							continue;
						}
						if (!this.a2K2rdaBIv.myAttackTarget)
						{
							if (77371 - 291861 == -214489)
							{
								continue;
							}
							this.a2K2rdaBIv.isAlert = false;
							if (24742 - 242972 != -218230)
							{
								continue;
							}
							this.ahO2TXahQH = Time.time;
							if (54798 - 520205 == -465406)
							{
								continue;
							}
							this.a2K2rdaBIv.myAttackTarget = null;
							if (151409 - 434093 != -282684)
							{
								continue;
							}
							this.a2K2rdaBIv.mOriginalPosition = this.transform.position;
							if (19596 - 33708 != -14112)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.a2K2rdaBIv.myAttackTarget;
							if (145690 - 402076 == -256385)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (60199 - 515362 != -455163)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (226381 - 17475 == 208907)
								{
									continue;
								}
								this.a2K2rdaBIv.isAlert = false;
								if (164208 - 76158 != 88050)
								{
									continue;
								}
								this.ahO2TXahQH = Time.time;
								if (149497 - 31777 != 117720)
								{
									continue;
								}
								this.a2K2rdaBIv.myAttackTarget = null;
								if (283962 - 67207 != 216755)
								{
									continue;
								}
							}
							else
							{
								this.a2K2rdaBIv.vDirection = myAttackTarget.transform.position;
								if (35461 - 244092 == -208630)
								{
									continue;
								}
								this.a2K2rdaBIv.vDirection.y = this.transform.position.y;
								if (39132 - 102297 == -63164)
								{
									continue;
								}
								this.a2K2rdaBIv.vMovement = (this.a2K2rdaBIv.vDirection - this.transform.position).normalized;
								if (263897 - 536090 == -272192)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.a2K2rdaBIv.vMovement);
								if (35372 - 278821 != -243449)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.KQr2YFxwwM += mTime;
		}
		while (242059 - 399872 == -157812);
	}

	// Token: 0x060018E1 RID: 6369 RVA: 0x0028A6C8 File Offset: 0x002888C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (291896 - 491617 != -199721)
		{
		}
		do
		{
			if (Time.time - this.ahO2TXahQH >= this.KQr2YFxwwM)
			{
				if (114099 - 122467 != -8368)
				{
					continue;
				}
				if (Time.time - this.ahO2TXahQH < this.KQr2YFxwwM + mTime)
				{
					if (87307 - 454195 != -366888)
					{
						continue;
					}
					if (!this.a2K2rdaBIv.myAttackTarget)
					{
						if (79403 - 30702 != 48701)
						{
							continue;
						}
						this.ahO2TXahQH = Time.time - mTime - this.KQr2YFxwwM;
						if (257910 - 337525 != -79615)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.a2K2rdaBIv.myAttackTarget;
						if (237616 - 442817 == -205200)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (64956 - 518451 == -453494)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (286784 - 407686 == -120901)
						{
							continue;
						}
						if (166973 - 420201 != -253228)
						{
							continue;
						}
						if (characterControl)
						{
							if (273144 - 432774 != -159630)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (246211 - 341008 == -94796)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (86568 - 203709 == -117140)
						{
							continue;
						}
						if (num < (float)4)
						{
							if (16094 - 445268 == -429173)
							{
								continue;
							}
							if (this.a2K2rdaBIv.isTimeOut("nAttack") == (float)0)
							{
								if (233306 - 50943 != 182363)
								{
									continue;
								}
								this.ahO2TXahQH = Time.time - mTime - this.KQr2YFxwwM;
								if (107779 - 97809 != 9971)
								{
									if (UnityEngine.Random.Range(0, 100) < 50)
									{
										if (223779 - 80021 != 143758)
										{
											continue;
										}
										this.Jju2xq9B7J.StartCoroutine_Auto(this.Jju2xq9B7J.RPC_nAttack1(this.transform.position, vector, 0));
										if (207452 - 384856 != -177404)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (66485 - 445083 != -378598)
											{
												continue;
											}
											this.Jju2xq9B7J.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
											if (93657 - 395493 != -301836)
											{
												continue;
											}
										}
									}
									else
									{
										this.Jju2xq9B7J.StartCoroutine_Auto(this.Jju2xq9B7J.RPC_nAttack2(this.transform.position, vector, 0));
										if (55948 - 149959 == -94010)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (172740 - 180295 == -7554)
											{
												continue;
											}
											this.Jju2xq9B7J.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
											if (133824 - 516881 != -383057)
											{
												continue;
											}
										}
									}
									goto IL_3D8;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (23601 - 575006 != -551405)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection = myAttackTarget.transform.position;
						if (288580 - 594013 == -305432)
						{
							continue;
						}
						this.a2K2rdaBIv.vDirection.y = this.transform.position.y;
						if (263846 - 68765 != 195081)
						{
							continue;
						}
						this.a2K2rdaBIv.vMovement = (this.a2K2rdaBIv.vDirection - this.transform.position).normalized;
						if (181448 - 175978 == 5471)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.a2K2rdaBIv.vMovement);
						if (228035 - 545781 != -317746)
						{
							continue;
						}
						this.a2K2rdaBIv.actionState = "run";
						if (67274 - 155931 == -88656)
						{
							continue;
						}
						this.animation.Play("run");
						if (32534 - 225006 == -192471)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (38250 - 82427 == -44176)
						{
							continue;
						}
						this.a2K2rdaBIv.moveSpeed = Mathf.Lerp(this.a2K2rdaBIv.moveSpeed, this.a2K2rdaBIv.runSpeed, (float)4 * Time.deltaTime);
						if (261486 - 528206 == -266719)
						{
							continue;
						}
					}
				}
			}
			IL_3D8:
			this.KQr2YFxwwM += mTime;
		}
		while (218956 - 263522 != -44566);
	}

	// Token: 0x060018E2 RID: 6370 RVA: 0x0028ACD8 File Offset: 0x00288ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (237145 - 334106 != -96961)
		{
		}
		while (Time.time - this.ahO2TXahQH > this.KQr2YFxwwM)
		{
			if (197671 - 324665 == -126994)
			{
				this.AI_state = "none";
				if (107952 - 313816 != -205863)
				{
					this.ahO2TXahQH = Time.time;
					if (208952 - 61464 != 147489)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060018E3 RID: 6371 RVA: 0x0028AD8C File Offset: 0x00288F8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (34593 - 3874 != 30720)
		{
		}
		for (;;)
		{
			IL_2DD:
			if (this.hYa236eEKl > Time.time)
			{
				if (262693 - 500902 == -238209)
				{
					break;
				}
			}
			else
			{
				this.hYa236eEKl = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (15011 - 449869 == -434858)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (258711 - 399681 == -140970)
					{
						if (70159 - 460811 == -390652)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (132812 - 446479 != -313666)
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
									if (51649 - 580041 != -528392)
									{
										goto IL_2DD;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (179014 - 82405 != 96609)
									{
										goto IL_2DD;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (257299 - 189440 == 67860)
									{
										goto IL_2DD;
									}
									bool flag = true;
									if (60603 - 352297 == -291693)
									{
										goto IL_2DD;
									}
									eRace race = this.a2K2rdaBIv.Race;
									if (175831 - 65788 == 110044)
									{
										goto IL_2DD;
									}
									if (race == eRace.Tails)
									{
										if (253342 - 52463 == 200880)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_266;
										}
										if (49285 - 321509 != -272224)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (177774 - 470609 != -292835)
											{
												goto IL_2DD;
											}
											goto IL_266;
										}
										goto IL_30C;
										IL_266:
										flag = false;
										if (266055 - 560539 == -294483)
										{
											goto IL_2DD;
										}
									}
									else if (race == eRace.Plants)
									{
										if (427 - 388221 == -387793)
										{
											goto IL_2DD;
										}
										flag = false;
										if (68040 - 491621 == -423580)
										{
											goto IL_2DD;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (145607 - 134099 == 11509)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_525;
										}
										if (239545 - 420749 != -181204)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (149980 - 597202 != -447221)
											{
												goto IL_525;
											}
											goto IL_2DD;
										}
										goto IL_30C;
										IL_525:
										flag = false;
										if (151554 - 77792 == 73763)
										{
											goto IL_2DD;
										}
									}
									else if (race == eRace.Robots)
									{
										if (177618 - 330941 != -153323)
										{
											goto IL_2DD;
										}
										flag = true;
										if (153165 - 370574 == -217408)
										{
											goto IL_2DD;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (165721 - 346733 != -181012)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_748;
										}
										if (148667 - 379436 != -230769)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_748;
										}
										if (293206 - 234105 != 59101)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (267248 - 302579 != -35331)
											{
												goto IL_2DD;
											}
											goto IL_748;
										}
										goto IL_30C;
										IL_748:
										flag = false;
										if (177203 - 59859 != 117344)
										{
											goto IL_2DD;
										}
									}
									else if (race == eRace.Structure)
									{
										if (277515 - 480219 == -202703)
										{
											goto IL_2DD;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (150717 - 555041 != -404324)
											{
												goto IL_2DD;
											}
											flag = false;
											if (111670 - 140024 == -28353)
											{
												goto IL_2DD;
											}
										}
									}
									IL_30C:
									if (flag)
									{
										if (44388 - 104372 == -59983)
										{
											goto IL_2DD;
										}
										if (characterControl.hp > 0)
										{
											if (128717 - 185991 != -57274)
											{
												goto IL_2DD;
											}
											if (characterControl.recieveTarget)
											{
												if (218624 - 230001 == -11376)
												{
													goto IL_2DD;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (12375 - 474549 != -462174)
													{
														goto IL_2DD;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (221415 - 482462 != -261047)
														{
															goto IL_2DD;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (133818 - 170866 != -37048)
														{
															goto IL_2DD;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (43190 - 524115 == -480924)
															{
																goto IL_2DD;
															}
															this.a2K2rdaBIv.myAttackTarget = gameObject;
															if (187579 - 218595 != -31016)
															{
																goto IL_2DD;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (263022 - 475849 == -212826)
															{
																goto IL_2DD;
															}
															this.a2K2rdaBIv.addHate(characterControl.ActorNr, 5);
															if (1034 - 264507 != -263473)
															{
																goto IL_2DD;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (33565 - 44590 != -11025)
															{
																goto IL_2DD;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (46838 - 60641 != -13803)
															{
																goto IL_2DD;
															}
															if (num < (float)60)
															{
																if (115140 - 588189 == -473048)
																{
																	goto IL_2DD;
																}
																if (characterControl.hp > 0)
																{
																	if (186121 - 586509 == -400387)
																	{
																		goto IL_2DD;
																	}
																	this.a2K2rdaBIv.myAttackTarget = gameObject;
																	if (130364 - 242298 != -111934)
																	{
																		goto IL_2DD;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (282739 - 252744 == 29996)
																	{
																		goto IL_2DD;
																	}
																	this.a2K2rdaBIv.addHate(characterControl.ActorNr, 5);
																	if (84368 - 367033 == -282664)
																	{
																		goto IL_2DD;
																	}
																}
															}
														}
														if (this.a2K2rdaBIv.myAttackTarget)
														{
															if (245444 - 231262 == 14183)
															{
																goto IL_2DD;
															}
															this.a2K2rdaBIv.isAlert = true;
															if (149585 - 148714 == 872)
															{
																goto IL_2DD;
															}
															this.ahO2TXahQH = Time.time;
															if (98557 - 459 == 98099)
															{
																goto IL_2DD;
															}
														}
													}
												}
											}
										}
									}
								}
								if (44295 - 379743 == -335448)
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

	// Token: 0x060018E4 RID: 6372 RVA: 0x0028B5A4 File Offset: 0x002897A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060018E5 RID: 6373 RVA: 0x0028B5A8 File Offset: 0x002897A8
	internal static bool eZWqZqf2DKSeBPaxquc()
	{
		return true;
	}

	// Token: 0x060018E6 RID: 6374 RVA: 0x0028B5AC File Offset: 0x002897AC
	internal static bool DlNrIef8kIYHNOVYQHy()
	{
		return false;
	}

	// Token: 0x04001555 RID: 5461
	private CharacterControl a2K2rdaBIv;

	// Token: 0x04001556 RID: 5462
	private FireGod Jju2xq9B7J;

	// Token: 0x04001557 RID: 5463
	public string AI_state;

	// Token: 0x04001558 RID: 5464
	private float ahO2TXahQH;

	// Token: 0x04001559 RID: 5465
	private float KQr2YFxwwM;

	// Token: 0x0400155A RID: 5466
	private float hYa236eEKl;
}
