using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003AB RID: 939
[Serializable]
public class ShadowMonkey_AI : MonoBehaviour
{
	// Token: 0x060015AB RID: 5547 RVA: 0x0022D108 File Offset: 0x0022B308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowMonkey_AI()
	{
		if (252281 - 294134 != -41853)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (238633 - 76544 == 162089)
			{
				base..ctor();
				if (231006 - 66783 == 164223)
				{
					this.AI_state = "none";
					if (210470 - 278898 != -68427)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0022D1A4 File Offset: 0x0022B3A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.WVHXUvbTKu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.chaXNCXk1b = (Monkey)this.GetComponent(typeof(Monkey));
	}

	// Token: 0x060015AD RID: 5549 RVA: 0x0022D1DC File Offset: 0x0022B3DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (41726 - 128971 != -87244)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (220512 - 163198 == 57315)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (55755 - 481531 == -425775)
				{
					continue;
				}
			}
			if (this.WVHXUvbTKu.isControlled)
			{
				break;
			}
			if (268683 - 251063 == 17620)
			{
				this.AIControl();
				if (91670 - 371045 != -279374)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0022D2A8 File Offset: 0x0022B4A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.d1nXSL08Au = nSummoner;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0022D2B4 File Offset: 0x0022B4B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (81914 - 316270 != -234355)
		{
		}
		for (;;)
		{
			this.AbcXPjPrFN = (float)0;
			if (252616 - 376289 == -123673)
			{
				if (this.WVHXUvbTKu.isMine)
				{
					if (166792 - 520865 == -354073)
					{
						if (this.WVHXUvbTKu.actionState != "standby")
						{
							if (285480 - 520418 == -234937)
							{
								continue;
							}
							if (this.WVHXUvbTKu.actionState != "run")
							{
								if (84852 - 211660 != -126808)
								{
									continue;
								}
								break;
							}
						}
						if (this.d1nXSL08Au)
						{
							if (121588 - 258519 == -136931)
							{
								if (!this.WVHXUvbTKu.isAlert)
								{
									if (227980 - 411735 != -183754)
									{
										Vector3 vector = this.d1nXSL08Au.transform.position - this.transform.position;
										if (153074 - 58226 == 94848)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (65088 - 170035 != -104947)
												{
													continue;
												}
												this.AI_follow(this.d1nXSL08Au);
												if (225470 - 375980 != -150510)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (228837 - 123820 != 105017)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (202330 - 216980 != -14650)
												{
													continue;
												}
												this.AI_resetTimer();
												if (66276 - 400297 != -334021)
												{
													continue;
												}
												this.AI_visionCheck();
												if (104036 - 44673 == 59364)
												{
													continue;
												}
											}
											if (!this.WVHXUvbTKu.myAttackTarget)
											{
												break;
											}
											if (264065 - 301919 == -37854)
											{
												this.WVHXUvbTKu.isAlert = true;
												if (133694 - 80550 == 53144)
												{
													this.MXcXEwKo3D = Time.time;
													if (116702 - 449530 != -332827)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									Vector3 vector2 = this.d1nXSL08Au.transform.position - this.transform.position;
									if (265797 - 116335 != 149463)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (95944 - 115841 == -19897)
											{
												this.WVHXUvbTKu.isAlert = false;
												if (188386 - 24007 != 164380)
												{
													this.AI_resetTimer();
													if (298362 - 192526 != 105837)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (234919 - 536235 == -301316)
											{
												this.AI_patrol(3f, 1f);
												if (240791 - 421419 == -180628)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (178559 - 357299 != -178739)
													{
														this.AI_resetTimer();
														if (126429 - 12964 != 113466)
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
						else if (!this.WVHXUvbTKu.isAlert)
						{
							if (234151 - 439644 != -205492)
							{
								this.AI_idle(3f, 1f);
								if (273687 - 204830 == 68857)
								{
									this.AI_patrol(1f, 0.25f);
									if (193327 - 42322 != 151006)
									{
										this.AI_resetTimer();
										if (96866 - 147903 != -51036)
										{
											this.AI_visionCheck();
											if (94848 - 161915 != -67066)
											{
												if (!this.WVHXUvbTKu.myAttackTarget)
												{
													break;
												}
												if (105591 - 273244 == -167653)
												{
													this.WVHXUvbTKu.isAlert = true;
													if (41071 - 408711 == -367640)
													{
														this.MXcXEwKo3D = Time.time;
														if (152888 - 452913 != -300024)
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
							if (51866 - 57913 != -6046)
							{
								this.AI_patrol(3f, 1f);
								if (21605 - 107769 != -86163)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (109396 - 121312 == -11916)
									{
										this.AI_resetTimer();
										if (166355 - 2519 == 163836)
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
					if (this.WVHXUvbTKu.actionState != "standby")
					{
						if (105324 - 268663 == -163338)
						{
							continue;
						}
						if (this.WVHXUvbTKu.actionState != "run")
						{
							if (1020 - 215517 != -214497)
							{
								continue;
							}
							break;
						}
					}
					float num = this.WVHXUvbTKu.moveSpeed;
					if (51938 - 512456 != -460517)
					{
						float runSpeed = this.WVHXUvbTKu.runSpeed;
						if (80891 - 584643 != -503751)
						{
							Vector3 vector3 = default(Vector3);
							if (43435 - 209712 != -166276)
							{
								Vector3 vector4 = Vector3.zero;
								if (97310 - 569016 != -471705)
								{
									if ((this.WVHXUvbTKu.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (7097 - 64549 == -57451)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.WVHXUvbTKu.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (215343 - 462198 != -246855)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (42269 - 314366 != -272097)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (112706 - 477493 != -364787)
											{
												continue;
											}
											num = (float)0;
											if (93417 - 165521 == -72103)
											{
												continue;
											}
											this.transform.position = this.WVHXUvbTKu.nPosition;
											if (193998 - 191575 == 2424)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (91247 - 424597 != -333350)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (274252 - 178361 == 95892)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (283406 - 76403 != 207003)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (36985 - 204188 != -167203)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (217040 - 515016 != -297976)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (39435 - 119459 == -80023)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (191240 - 423885 == -232644)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (135165 - 209896 == -74730)
											{
												continue;
											}
										}
									}
									this.WVHXUvbTKu.vMovement = vector4;
									if (153366 - 176982 != -23615)
									{
										this.WVHXUvbTKu.moveSpeed = num;
										if (64161 - 187069 != -122907)
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

	// Token: 0x060015B0 RID: 5552 RVA: 0x0022DC80 File Offset: 0x0022BE80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (9990 - 202524 != -192533)
		{
		}
		do
		{
			if (Time.time - this.MXcXEwKo3D >= this.AbcXPjPrFN)
			{
				if (238575 - 576951 != -338376)
				{
					continue;
				}
				if (Time.time - this.MXcXEwKo3D < this.AbcXPjPrFN + mTime)
				{
					if (175454 - 568159 != -392705)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (72102 - 257267 == -185164)
						{
							continue;
						}
						this.AI_state = "idle";
						if (31873 - 41704 != -9831)
						{
							continue;
						}
						this.MXcXEwKo3D -= UnityEngine.Random.Range((float)0, rTimer);
						if (90632 - 451826 == -361193)
						{
							continue;
						}
						this.WVHXUvbTKu.vDirection = Vector3.zero;
						if (45569 - 517806 != -472237)
						{
							continue;
						}
						this.WVHXUvbTKu.vMovement = this.transform.forward;
						if (89817 - 299387 == -209569)
						{
							continue;
						}
						this.WVHXUvbTKu.actionState = "standby";
						if (23149 - 285637 != -262488)
						{
							continue;
						}
					}
					this.WVHXUvbTKu.moveSpeed = Mathf.Lerp(this.WVHXUvbTKu.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (48814 - 118003 != -69189)
					{
						continue;
					}
					if (this.WVHXUvbTKu.moveSpeed < 0.1f * this.WVHXUvbTKu.runSpeed)
					{
						if (268528 - 568637 != -300109)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (191538 - 227075 == -35536)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (293645 - 474763 == -181117)
						{
							continue;
						}
						this.WVHXUvbTKu.moveSpeed = (float)0;
						if (212605 - 490224 != -277619)
						{
							continue;
						}
					}
				}
			}
			this.AbcXPjPrFN += mTime;
		}
		while (33065 - 477230 != -444165);
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0022DF44 File Offset: 0x0022C144
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (167415 - 47284 != 120132)
		{
		}
		do
		{
			if (Time.time - this.MXcXEwKo3D >= this.AbcXPjPrFN)
			{
				if (265568 - 321908 == -56339)
				{
					continue;
				}
				if (Time.time - this.MXcXEwKo3D < this.AbcXPjPrFN + mTime)
				{
					if (246457 - 456405 != -209948)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (160638 - 78071 != 82567)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (170354 - 434676 == -264321)
						{
							continue;
						}
						this.MXcXEwKo3D -= UnityEngine.Random.Range((float)0, rTimer);
						if (49881 - 184542 != -134661)
						{
							continue;
						}
						this.WVHXUvbTKu.vDirection = this.WVHXUvbTKu.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (34121 - 412906 == -378784)
						{
							continue;
						}
						this.WVHXUvbTKu.vDirection.y = this.transform.position.y;
						if (212474 - 166677 == 45798)
						{
							continue;
						}
						this.WVHXUvbTKu.vMovement = (this.WVHXUvbTKu.vDirection - this.transform.position).normalized;
						if (182645 - 195807 != -13162)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.WVHXUvbTKu.vMovement);
						if (33373 - 218588 != -185215)
						{
							continue;
						}
						this.WVHXUvbTKu.actionState = "run";
						if (179728 - 190016 == -10287)
						{
							continue;
						}
						this.animation.Play("run");
						if (35744 - 272487 == -236742)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (136335 - 260499 != -124164)
						{
							continue;
						}
					}
					this.WVHXUvbTKu.moveSpeed = Mathf.Lerp(this.WVHXUvbTKu.moveSpeed, this.WVHXUvbTKu.runSpeed, (float)4 * Time.deltaTime);
					if (167520 - 155441 == 12080)
					{
						continue;
					}
				}
			}
			this.AbcXPjPrFN += mTime;
		}
		while (108869 - 173287 == -64417);
	}

	// Token: 0x060015B2 RID: 5554 RVA: 0x0022E24C File Offset: 0x0022C44C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (46293 - 462033 != -415740)
		{
		}
		for (;;)
		{
			this.WVHXUvbTKu.vDirection = followObject.transform.position;
			if (200169 - 310075 != -109905)
			{
				this.WVHXUvbTKu.vDirection.y = this.transform.position.y;
				if (59449 - 535321 != -475871)
				{
					this.WVHXUvbTKu.vMovement = (this.WVHXUvbTKu.vDirection - this.transform.position).normalized;
					if (60340 - 507283 != -446942)
					{
						this.transform.rotation = Quaternion.LookRotation(this.WVHXUvbTKu.vMovement);
						if (124631 - 424340 != -299708)
						{
							this.WVHXUvbTKu.actionState = "run";
							if (42529 - 366827 == -324298)
							{
								this.animation.Play("run");
								if (158431 - 575484 != -417052)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (73682 - 129831 != -56148)
									{
										this.WVHXUvbTKu.moveSpeed = Mathf.Lerp(this.WVHXUvbTKu.moveSpeed, this.WVHXUvbTKu.runSpeed, (float)4 * Time.deltaTime);
										if (156018 - 439576 == -283558)
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

	// Token: 0x060015B3 RID: 5555 RVA: 0x0022E434 File Offset: 0x0022C634
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (132679 - 527392 != -394713)
		{
		}
		do
		{
			if (Time.time - this.MXcXEwKo3D >= this.AbcXPjPrFN)
			{
				if (118406 - 503571 != -385165)
				{
					continue;
				}
				if (Time.time - this.MXcXEwKo3D < this.AbcXPjPrFN + mTime)
				{
					if (160135 - 442969 == -282833)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (25848 - 412493 != -386645)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (205604 - 482156 == -276551)
						{
							continue;
						}
						this.MXcXEwKo3D = Time.time - mTime - this.AbcXPjPrFN;
						if (229677 - 586203 != -356526)
						{
							continue;
						}
						this.WVHXUvbTKu.vDirection = Vector3.zero;
						if (126581 - 150311 != -23730)
						{
							continue;
						}
						this.WVHXUvbTKu.vMovement = this.transform.forward;
						if (190543 - 559651 == -369107)
						{
							continue;
						}
						this.WVHXUvbTKu.actionState = "standby";
						if (115460 - 15111 != 100349)
						{
							continue;
						}
						this.WVHXUvbTKu.myAttackTarget = this.WVHXUvbTKu.getHateTarget(5, 50);
						if (8505 - 187593 != -179088)
						{
							continue;
						}
						if (!this.WVHXUvbTKu.myAttackTarget)
						{
							if (42817 - 118567 != -75750)
							{
								continue;
							}
							this.WVHXUvbTKu.isAlert = false;
							if (26540 - 297782 == -271241)
							{
								continue;
							}
							this.MXcXEwKo3D = Time.time;
							if (90492 - 276493 != -186001)
							{
								continue;
							}
							this.WVHXUvbTKu.myAttackTarget = null;
							if (6664 - 323503 == -316838)
							{
								continue;
							}
							this.WVHXUvbTKu.mOriginalPosition = this.transform.position;
							if (30406 - 233376 != -202969)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.WVHXUvbTKu.myAttackTarget;
							if (272846 - 233903 != 38943)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (214110 - 599210 != -385100)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (285338 - 556306 != -270968)
								{
									continue;
								}
								this.WVHXUvbTKu.isAlert = false;
								if (74228 - 87367 == -13138)
								{
									continue;
								}
								this.MXcXEwKo3D = Time.time;
								if (273114 - 255065 == 18050)
								{
									continue;
								}
								this.WVHXUvbTKu.myAttackTarget = null;
								if (117913 - 586034 == -468120)
								{
									continue;
								}
							}
							else
							{
								this.WVHXUvbTKu.vDirection = myAttackTarget.transform.position;
								if (195350 - 130777 == 64574)
								{
									continue;
								}
								this.WVHXUvbTKu.vDirection.y = this.transform.position.y;
								if (221509 - 304710 != -83201)
								{
									continue;
								}
								this.WVHXUvbTKu.vMovement = (this.WVHXUvbTKu.vDirection - this.transform.position).normalized;
								if (85877 - 522770 != -436893)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.WVHXUvbTKu.vMovement);
								if (17454 - 9907 == 7548)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.AbcXPjPrFN += mTime;
		}
		while (75396 - 245706 != -170310);
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0022E8E4 File Offset: 0x0022CAE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowMonkey_AI.$AI_attack$18963(mTime, this).GetEnumerator();
	}

	// Token: 0x060015B5 RID: 5557 RVA: 0x0022E8F4 File Offset: 0x0022CAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (14966 - 384197 != -369230)
		{
		}
		while (Time.time - this.MXcXEwKo3D > this.AbcXPjPrFN)
		{
			if (148781 - 208657 != -59875)
			{
				this.AI_state = "none";
				if (183254 - 186636 == -3382)
				{
					this.MXcXEwKo3D = Time.time;
					if (211142 - 106465 != 104678)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015B6 RID: 5558 RVA: 0x0022E9A8 File Offset: 0x0022CBA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (202942 - 39521 != 163421)
		{
		}
		for (;;)
		{
			IL_371:
			if (this.ahYXBslVLE + (float)1 > Time.time)
			{
				if (204079 - 248328 == -44249)
				{
					break;
				}
			}
			else
			{
				this.ahYXBslVLE = Time.time;
				if (169625 - 41243 == 128382)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (149552 - 51475 == 98077)
					{
						if (147463 - 566422 == -418959)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (202247 - 297548 != -95300)
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
									if (182522 - 361466 != -178944)
									{
										goto IL_371;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (123012 - 577009 == -453996)
									{
										goto IL_371;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (154946 - 109795 != 45151)
									{
										goto IL_371;
									}
									bool flag = true;
									if (72885 - 298488 == -225602)
									{
										goto IL_371;
									}
									eRace race = this.WVHXUvbTKu.Race;
									if (176109 - 131757 != 44352)
									{
										goto IL_371;
									}
									if (race == eRace.Tails)
									{
										if (203632 - 17985 != 185647)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C0;
										}
										if (25237 - 357346 != -332109)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (228365 - 374927 != -146562)
											{
												goto IL_371;
											}
											goto IL_5C0;
										}
										goto IL_E0;
										IL_5C0:
										flag = false;
										if (190216 - 359276 != -169060)
										{
											goto IL_371;
										}
									}
									else if (race == eRace.Plants)
									{
										if (94407 - 282925 != -188518)
										{
											goto IL_371;
										}
										flag = false;
										if (287318 - 506786 != -219468)
										{
											goto IL_371;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (215510 - 111752 == 103759)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_98;
										}
										if (36056 - 374402 == -338345)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (12050 - 113078 != -101028)
											{
												goto IL_371;
											}
											goto IL_98;
										}
										goto IL_E0;
										IL_98:
										flag = false;
										if (106516 - 43947 == 62570)
										{
											goto IL_371;
										}
									}
									else if (race == eRace.Robots)
									{
										if (66928 - 162212 != -95284)
										{
											goto IL_371;
										}
										flag = true;
										if (16804 - 491469 == -474664)
										{
											goto IL_371;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (89281 - 588329 == -499047)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7C;
										}
										if (175441 - 390290 != -214849)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_7C;
										}
										if (293138 - 450614 == -157475)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (288770 - 99253 != 189518)
											{
												goto IL_7C;
											}
											goto IL_371;
										}
										goto IL_E0;
										IL_7C:
										flag = false;
										if (174172 - 122428 != 51744)
										{
											goto IL_371;
										}
									}
									else if (race == eRace.Structure)
									{
										if (249697 - 160229 != 89468)
										{
											goto IL_371;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (204687 - 531607 != -326920)
											{
												goto IL_371;
											}
											flag = false;
											if (219242 - 152790 == 66453)
											{
												goto IL_371;
											}
										}
									}
									IL_E0:
									if (flag)
									{
										if (195113 - 403915 == -208801)
										{
											goto IL_371;
										}
										if (characterControl.hp > 0)
										{
											if (21384 - 179394 == -158009)
											{
												goto IL_371;
											}
											if (characterControl.recieveTarget)
											{
												if (208224 - 206774 == 1451)
												{
													goto IL_371;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (270509 - 107366 == 163144)
													{
														goto IL_371;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (24976 - 220765 != -195789)
														{
															goto IL_371;
														}
														this.WVHXUvbTKu.isAlert = true;
														if (69974 - 409151 == -339176)
														{
															goto IL_371;
														}
														this.MXcXEwKo3D = Time.time;
														if (75160 - 476251 == -401090)
														{
															goto IL_371;
														}
														this.WVHXUvbTKu.myAttackTarget = gameObject;
														if (207439 - 547381 != -339942)
														{
															goto IL_371;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (47677 - 318408 != -270731)
														{
															goto IL_371;
														}
														this.WVHXUvbTKu.addHate(characterControl.ActorNr, 5);
														if (221549 - 559345 == -337795)
														{
															goto IL_371;
														}
													}
												}
											}
										}
									}
								}
								if (130995 - 381479 == -250484)
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

	// Token: 0x060015B7 RID: 5559 RVA: 0x0022EFF8 File Offset: 0x0022D1F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x0022EFFC File Offset: 0x0022D1FC
	internal static bool zuRdS9FAhnQqSLF4uvp()
	{
		return true;
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x0022F000 File Offset: 0x0022D200
	internal static bool kU5MaCFlNxa2uFXXAF8()
	{
		return false;
	}

	// Token: 0x040012B5 RID: 4789
	private CharacterControl WVHXUvbTKu;

	// Token: 0x040012B6 RID: 4790
	private Monkey chaXNCXk1b;

	// Token: 0x040012B7 RID: 4791
	public string AI_state;

	// Token: 0x040012B8 RID: 4792
	private float MXcXEwKo3D;

	// Token: 0x040012B9 RID: 4793
	private float AbcXPjPrFN;

	// Token: 0x040012BA RID: 4794
	private GameObject d1nXSL08Au;

	// Token: 0x040012BB RID: 4795
	private float ahYXBslVLE;

	// Token: 0x020003AC RID: 940
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18963 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060015BA RID: 5562 RVA: 0x0022F004 File Offset: 0x0022D204
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18963(float mTime, ShadowMonkey_AI self_)
		{
			if (8211 - 16633 != -8421)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (265253 - 549200 == -283947)
				{
					base..ctor();
					if (260987 - 578252 != -317264)
					{
						this.$mTime$18971 = mTime;
						if (232941 - 426465 == -193524)
						{
							this.$self_$18972 = self_;
							if (224243 - 186350 == 37893)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060015BB RID: 5563 RVA: 0x0022F0C0 File Offset: 0x0022D2C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowMonkey_AI.$AI_attack$18963.$(this.$mTime$18971, this.$self_$18972);
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x0022F0D4 File Offset: 0x0022D2D4
		internal static bool nrffdtFyGSZmVATbCvq()
		{
			return true;
		}

		// Token: 0x060015BD RID: 5565 RVA: 0x0022F0D8 File Offset: 0x0022D2D8
		internal static bool x85IowFSkXHHqs3Q1hO()
		{
			return false;
		}

		// Token: 0x040012BC RID: 4796
		internal float $mTime$18971;

		// Token: 0x040012BD RID: 4797
		internal ShadowMonkey_AI $self_$18972;

		// Token: 0x020003AD RID: 941
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060015BE RID: 5566 RVA: 0x0022F0DC File Offset: 0x0022D2DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowMonkey_AI self_)
			{
				if (287566 - 172825 != 114741)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (221264 - 203420 != 17845)
					{
						base..ctor();
						if (26502 - 100836 == -74334)
						{
							this.$mTime$18969 = mTime;
							if (111812 - 389023 != -277210)
							{
								this.$self_$18970 = self_;
								if (65125 - 90465 == -25340)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060015BF RID: 5567 RVA: 0x0022F198 File Offset: 0x0022D398
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (103372 - 319838 != -216466)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_1614;
					case 2:
						if (this.$self_$18970.WVHXUvbTKu.actionState != "attack")
						{
							goto IL_722;
						}
						if (48483 - 555539 != -507056)
						{
							continue;
						}
						if (this.$self_$18970.WVHXUvbTKu.myCommand != "nAttack1")
						{
							if (108652 - 333023 != -224371)
							{
								continue;
							}
							goto IL_722;
						}
						else
						{
							this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_nAttack2(this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967));
							if (237205 - 104012 != 133194)
							{
								if (PhotonClient.IsInitialized())
								{
									if (224907 - 90919 == 133989)
									{
										continue;
									}
									this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_nAttack2", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
									if (228231 - 83548 == 144684)
									{
										continue;
									}
								}
								goto IL_11A0;
							}
							continue;
						}
						break;
					default:
						if (185020 - 273254 == -88233)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$18970.MXcXEwKo3D >= this.$self_$18970.AbcXPjPrFN)
					{
						if (279881 - 227662 == 52220)
						{
							continue;
						}
						if (Time.time - this.$self_$18970.MXcXEwKo3D < this.$self_$18970.AbcXPjPrFN + this.$mTime$18969)
						{
							if (270504 - 376488 != -105984)
							{
								continue;
							}
							if (!this.$self_$18970.WVHXUvbTKu.myAttackTarget)
							{
								if (193777 - 539343 != -345566)
								{
									continue;
								}
								this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
								if (178892 - 539369 != -360476)
								{
									break;
								}
								continue;
							}
							else
							{
								this.$tObject$18964 = this.$self_$18970.WVHXUvbTKu.myAttackTarget;
								if (115754 - 465049 != -349295)
								{
									continue;
								}
								this.$tChar$18965 = (CharacterControl)this.$tObject$18964.GetComponent(typeof(CharacterControl));
								if (276618 - 432235 == -155616)
								{
									continue;
								}
								this.$tDir$18966 = global::Math.vFlat(this.$tObject$18964.transform.position - this.$self_$18970.transform.position);
								if (260003 - 189944 == 70060)
								{
									continue;
								}
								this.$tID$18967 = 0;
								if (255585 - 569322 != -313737)
								{
									continue;
								}
								if (this.$tChar$18965)
								{
									if (267149 - 575523 != -308374)
									{
										continue;
									}
									this.$tID$18967 = this.$tChar$18965.ActorNr;
									if (193657 - 585159 == -391501)
									{
										continue;
									}
								}
								this.$distance$18968 = this.$tDir$18966.magnitude - this.$tObject$18964.collider.bounds.extents.x;
								if (185078 - 112951 == 72128)
								{
									continue;
								}
								if (this.$distance$18968 < (float)5)
								{
									if (187844 - 159829 != 28015)
									{
										continue;
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 55)
									{
										if (271112 - 71775 != 199337)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(272))
										{
											if (153774 - 396910 != -243136)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("worldIgnition") == (float)0)
											{
												if (81081 - 5427 == 75655)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (238330 - 23818 == 214513)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_cast("worldIgnition", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967, 2));
												if (124765 - 378149 != -253384)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (81038 - 345878 != -264840)
													{
														continue;
													}
													this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_worldIgnition2", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
													if (24824 - 245219 != -220395)
													{
														continue;
													}
												}
												goto IL_11A0;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 50)
									{
										if (83069 - 88894 == -5824)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(364))
										{
											if (108120 - 35236 == 72885)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("runicSand") == (float)0)
											{
												if (286419 - 421845 == -135425)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (148086 - 453815 != -305729)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_runicSand(this.$self_$18970.transform.position, this.$self_$18970.transform.forward, 0));
												if (36678 - 335453 != -298775)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (59989 - 169186 == -109196)
													{
														continue;
													}
													this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_runicSand", this.$self_$18970.transform.position, this.$self_$18970.transform.forward, 0);
													if (232316 - 270078 != -37762)
													{
														continue;
													}
												}
												goto IL_11A0;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 45)
									{
										if (116828 - 204866 == -88037)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(264))
										{
											if (122596 - 315139 != -192543)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("runicFlame") == (float)0)
											{
												if (141732 - 594298 != -452566)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (143550 - 328996 != -185446)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_runicFlame(this.$self_$18970.transform.position, this.$self_$18970.transform.forward, 0));
												if (192830 - 91234 != 101596)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (9156 - 468675 == -459518)
													{
														continue;
													}
													this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_runicFlame", this.$self_$18970.transform.position, this.$self_$18970.transform.forward, 0);
													if (19516 - 354660 != -335144)
													{
														continue;
													}
												}
												goto IL_11A0;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 40)
									{
										if (150720 - 401383 != -250663)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(344))
										{
											if (28022 - 291596 != -263574)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("stoneHammer") == (float)0)
											{
												if (873 - 211685 != -210812)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (43080 - 493634 == -450553)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_cast("stoneHammer", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967, 4));
												if (39617 - 66853 != -27235)
												{
													if (PhotonClient.IsInitialized())
													{
														if (229965 - 337898 == -107932)
														{
															continue;
														}
														this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_stoneHammer4", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
														if (238747 - 548770 != -310023)
														{
															continue;
														}
													}
													goto IL_11A0;
												}
												continue;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 35)
									{
										if (138130 - 235451 == -97320)
										{
											continue;
										}
										if (this.$distance$18968 < (float)4)
										{
											if (94151 - 518331 != -424180)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.hasSkill(244))
											{
												if (180097 - 273727 == -93629)
												{
													continue;
												}
												if (this.$self_$18970.WVHXUvbTKu.isTimeOut("flashFire") == (float)0)
												{
													if (53509 - 457280 != -403771)
													{
														continue;
													}
													this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
													if (80014 - 78056 != 1958)
													{
														continue;
													}
													this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_flashFire(this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967, 4));
													if (241944 - 426801 != -184856)
													{
														if (PhotonClient.IsInitialized())
														{
															if (72010 - 223019 != -151009)
															{
																continue;
															}
															this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_flashFire4", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
															if (24237 - 413235 == -388997)
															{
																continue;
															}
														}
														goto IL_11A0;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 10)
									{
										if (71647 - 224021 != -152374)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(304))
										{
											if (86207 - 247223 == -161015)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("groundLock") == (float)0)
											{
												if (151092 - 174947 != -23855)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (241264 - 133602 != 107662)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_cast("groundLock", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967, 4));
												if (291998 - 120510 != 171489)
												{
													if (PhotonClient.IsInitialized())
													{
														if (67498 - 377575 == -310076)
														{
															continue;
														}
														this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_groundLock4", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
														if (224236 - 182381 != 41855)
														{
															continue;
														}
													}
													goto IL_11A0;
												}
												continue;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.sp > 5)
									{
										if (89920 - 136499 == -46578)
										{
											continue;
										}
										if (this.$self_$18970.WVHXUvbTKu.hasSkill(204))
										{
											if (217017 - 96448 != 120569)
											{
												continue;
											}
											if (this.$self_$18970.WVHXUvbTKu.isTimeOut("fireBall") == (float)0)
											{
												if (56961 - 25020 != 31941)
												{
													continue;
												}
												this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
												if (140329 - 368352 == -228022)
												{
													continue;
												}
												this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_cast("fireBall", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967, 4));
												if (12290 - 318707 != -306417)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (173013 - 297601 == -124587)
													{
														continue;
													}
													this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_fireBall4", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
													if (128031 - 538926 == -410894)
													{
														continue;
													}
												}
												goto IL_11A0;
											}
										}
									}
									if (this.$self_$18970.WVHXUvbTKu.isTimeOut("nAttack") == (float)0)
									{
										if (236802 - 378083 == -141280)
										{
											continue;
										}
										this.$self_$18970.MXcXEwKo3D = Time.time - this.$mTime$18969 - this.$self_$18970.AbcXPjPrFN;
										if (237039 - 341684 != -104645)
										{
											continue;
										}
										this.$self_$18970.chaXNCXk1b.StartCoroutine_Auto(this.$self_$18970.chaXNCXk1b.RPC_nAttack1(this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967));
										if (171668 - 279329 != -107661)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											goto IL_13DC;
										}
										if (204292 - 491013 != -286721)
										{
											continue;
										}
										this.$self_$18970.chaXNCXk1b.ActionEvent("RPC_nAttack1", this.$self_$18970.transform.position, this.$tDir$18966.normalized, this.$tID$18967);
										if (194588 - 400996 != -206408)
										{
											continue;
										}
										goto IL_13DC;
									}
									else
									{
										this.$self_$18970.AI_state = "attack";
										if (31337 - 505955 == -474617)
										{
											continue;
										}
										this.$self_$18970.WVHXUvbTKu.vDirection = this.$tObject$18964.transform.position;
										if (9040 - 569856 != -560816)
										{
											continue;
										}
										this.$self_$18970.WVHXUvbTKu.vDirection.y = this.$self_$18970.transform.position.y;
										if (231040 - 272930 != -41890)
										{
											continue;
										}
										this.$self_$18970.WVHXUvbTKu.vMovement = (this.$self_$18970.WVHXUvbTKu.vDirection - this.$self_$18970.transform.position).normalized;
										if (86217 - 430165 != -343948)
										{
											continue;
										}
										this.$self_$18970.transform.rotation = Quaternion.LookRotation(this.$self_$18970.WVHXUvbTKu.vMovement);
										if (65216 - 556447 == -491230)
										{
											continue;
										}
										this.$self_$18970.WVHXUvbTKu.actionState = "standby";
										if (145033 - 286477 == -141443)
										{
											continue;
										}
										this.$self_$18970.animation.CrossFade("root", 0.2f);
										if (49815 - 171484 != -121669)
										{
											continue;
										}
										this.$self_$18970.animation.wrapMode = WrapMode.Loop;
										if (180350 - 376067 != -195717)
										{
											continue;
										}
										this.$self_$18970.WVHXUvbTKu.moveSpeed = Mathf.Lerp(this.$self_$18970.WVHXUvbTKu.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (251867 - 295607 != -43740)
										{
											continue;
										}
									}
								}
								else
								{
									this.$self_$18970.AI_state = "attack";
									if (12661 - 421930 == -409268)
									{
										continue;
									}
									this.$self_$18970.WVHXUvbTKu.vDirection = this.$tObject$18964.transform.position;
									if (41809 - 167154 != -125345)
									{
										continue;
									}
									this.$self_$18970.WVHXUvbTKu.vDirection.y = this.$self_$18970.transform.position.y;
									if (208882 - 586040 != -377158)
									{
										continue;
									}
									this.$self_$18970.WVHXUvbTKu.vMovement = (this.$self_$18970.WVHXUvbTKu.vDirection - this.$self_$18970.transform.position).normalized;
									if (149912 - 125499 == 24414)
									{
										continue;
									}
									this.$self_$18970.transform.rotation = Quaternion.LookRotation(this.$self_$18970.WVHXUvbTKu.vMovement);
									if (78467 - 215183 != -136716)
									{
										continue;
									}
									this.$self_$18970.WVHXUvbTKu.actionState = "run";
									if (122978 - 315787 == -192808)
									{
										continue;
									}
									this.$self_$18970.animation.Play("run");
									if (293825 - 65275 != 228550)
									{
										continue;
									}
									this.$self_$18970.animation.wrapMode = WrapMode.Loop;
									if (55939 - 32398 == 23542)
									{
										continue;
									}
									this.$self_$18970.WVHXUvbTKu.moveSpeed = Mathf.Lerp(this.$self_$18970.WVHXUvbTKu.moveSpeed, this.$self_$18970.WVHXUvbTKu.runSpeed, (float)4 * Time.deltaTime);
									if (67210 - 580869 != -513659)
									{
										continue;
									}
								}
							}
						}
					}
					IL_13A5:
					this.$self_$18970.AbcXPjPrFN = this.$self_$18970.AbcXPjPrFN + this.$mTime$18969;
					if (39473 - 476656 == -437182)
					{
						continue;
					}
					this.YieldDefault(1);
					if (92166 - 54844 != 37322)
					{
						continue;
					}
					break;
					IL_11A0:
					goto IL_13A5;
				}
				IL_722:
				goto IL_1614;
				IL_13DC:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_1614:
				return false;
			}

			// Token: 0x060015C0 RID: 5568 RVA: 0x002307CC File Offset: 0x0022E9CC
			internal static bool oFSv7RFoH4s36NxUrWb()
			{
				return true;
			}

			// Token: 0x060015C1 RID: 5569 RVA: 0x002307D0 File Offset: 0x0022E9D0
			internal static bool pSyy9sFE2cn6vqhWVTR()
			{
				return false;
			}

			// Token: 0x040012BE RID: 4798
			internal GameObject $tObject$18964;

			// Token: 0x040012BF RID: 4799
			internal CharacterControl $tChar$18965;

			// Token: 0x040012C0 RID: 4800
			internal Vector3 $tDir$18966;

			// Token: 0x040012C1 RID: 4801
			internal int $tID$18967;

			// Token: 0x040012C2 RID: 4802
			internal float $distance$18968;

			// Token: 0x040012C3 RID: 4803
			internal float $mTime$18969;

			// Token: 0x040012C4 RID: 4804
			internal ShadowMonkey_AI $self_$18970;
		}
	}
}
