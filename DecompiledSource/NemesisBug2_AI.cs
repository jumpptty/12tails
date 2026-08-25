using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200012E RID: 302
[Serializable]
public class NemesisBug2_AI : MonoBehaviour
{
	// Token: 0x060006AD RID: 1709 RVA: 0x000AF524 File Offset: 0x000AD724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public NemesisBug2_AI()
	{
		if (98318 - 114409 != -16090)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (71710 - 223454 != -151743)
			{
				base..ctor();
				if (257617 - 254527 == 3090)
				{
					this.AI_state = "none";
					if (137942 - 13157 == 124785)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006AE RID: 1710 RVA: 0x000AF5C0 File Offset: 0x000AD7C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aLNnakaC0H = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.urrn4h7tbd = (NemesisBug2)this.GetComponent(typeof(NemesisBug2));
	}

	// Token: 0x060006AF RID: 1711 RVA: 0x000AF5F8 File Offset: 0x000AD7F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (106181 - 141623 != -35441)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (270534 - 234301 != 36233)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (56235 - 40701 == 15535)
				{
					continue;
				}
			}
			if (this.aLNnakaC0H.isControlled)
			{
				break;
			}
			if (48008 - 525026 == -477018)
			{
				this.AIControl();
				if (290064 - 232076 != 57989)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060006B0 RID: 1712 RVA: 0x000AF6C4 File Offset: 0x000AD8C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (261688 - 168792 != 92896)
		{
		}
		for (;;)
		{
			this.o93nHJrOJi = (float)0;
			if (156621 - 110540 == 46081)
			{
				if (this.aLNnakaC0H.isMine)
				{
					if (125508 - 514747 != -389238)
					{
						if (this.aLNnakaC0H.actionState != "standby")
						{
							if (128761 - 478091 != -349330)
							{
								continue;
							}
							if (this.aLNnakaC0H.actionState != "run")
							{
								if (214510 - 508819 != -294308)
								{
									break;
								}
								continue;
							}
						}
						if (!this.aLNnakaC0H.isAlert)
						{
							if (227518 - 38517 == 189001)
							{
								this.AI_idle(3f, 1f);
								if (181642 - 252575 != -70932)
								{
									this.AI_patrol(3f, 2f);
									if (25993 - 334423 != -308429)
									{
										this.AI_resetTimer();
										if (101815 - 118847 == -17032)
										{
											this.AI_visionCheck();
											if (168899 - 472729 == -303830)
											{
												if (!this.aLNnakaC0H.myAttackTarget)
												{
													break;
												}
												if (52320 - 435232 != -382911)
												{
													this.aLNnakaC0H.isAlert = true;
													if (66836 - 132693 == -65857)
													{
														this.z5RnsLjpUE = Time.time;
														if (53256 - 189438 != -136181)
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
							if (246864 - 264144 == -17280)
							{
								this.AI_idle(2f, 1f);
								if (136363 - 536600 == -400237)
								{
									this.AI_attack(10f, (float)0);
									if (279658 - 270469 != 9190)
									{
										this.AI_resetTimer();
										if (104735 - 349649 != -244913)
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
					if (this.aLNnakaC0H.actionState != "standby")
					{
						if (95801 - 576234 != -480433)
						{
							continue;
						}
						if (this.aLNnakaC0H.actionState != "run")
						{
							if (208198 - 529354 != -321155)
							{
								break;
							}
							continue;
						}
					}
					float num = this.aLNnakaC0H.moveSpeed;
					if (120604 - 365240 == -244636)
					{
						float runSpeed = this.aLNnakaC0H.runSpeed;
						if (80623 - 266362 == -185739)
						{
							Vector3 vector = default(Vector3);
							if (42785 - 6596 != 36190)
							{
								Vector3 vector2 = Vector3.zero;
								if (116200 - 193902 != -77701)
								{
									if ((this.aLNnakaC0H.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (212005 - 348580 != -136575)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aLNnakaC0H.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (28196 - 539840 == -511643)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (170190 - 573836 != -403646)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (258085 - 360019 != -101934)
											{
												continue;
											}
											num = (float)0;
											if (246323 - 495519 != -249196)
											{
												continue;
											}
											this.transform.position = this.aLNnakaC0H.nPosition;
											if (15904 - 185113 != -169209)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (155939 - 62599 != 93340)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (238404 - 458787 != -220383)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (77921 - 26458 == 51464)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (220382 - 35410 == 184973)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52476 - 547270 == -494793)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (240117 - 516854 == -276736)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (240813 - 120759 == 120055)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (195346 - 360279 != -164933)
											{
												continue;
											}
										}
									}
									this.aLNnakaC0H.vMovement = vector2;
									if (286508 - 457043 == -170535)
									{
										this.aLNnakaC0H.moveSpeed = num;
										if (1211 - 44048 == -42837)
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

	// Token: 0x060006B1 RID: 1713 RVA: 0x000AFD3C File Offset: 0x000ADF3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (264154 - 312116 != -47962)
		{
		}
		do
		{
			if (Time.time - this.z5RnsLjpUE >= this.o93nHJrOJi)
			{
				if (253446 - 267544 != -14098)
				{
					continue;
				}
				if (Time.time - this.z5RnsLjpUE < this.o93nHJrOJi + mTime)
				{
					if (260424 - 129785 != 130639)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (265782 - 547779 == -281996)
						{
							continue;
						}
						this.AI_state = "idle";
						if (93730 - 463715 != -369985)
						{
							continue;
						}
						this.z5RnsLjpUE -= UnityEngine.Random.Range((float)0, rTimer);
						if (299316 - 256532 != 42784)
						{
							continue;
						}
						this.aLNnakaC0H.vDirection = Vector3.zero;
						if (106995 - 569171 == -462175)
						{
							continue;
						}
						this.aLNnakaC0H.vMovement = this.transform.forward;
						if (274548 - 511544 == -236995)
						{
							continue;
						}
						this.aLNnakaC0H.actionState = "standby";
						if (64612 - 369369 != -304757)
						{
							continue;
						}
					}
					this.aLNnakaC0H.moveSpeed = Mathf.Lerp(this.aLNnakaC0H.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (71636 - 70047 == 1590)
					{
						continue;
					}
					if (this.aLNnakaC0H.moveSpeed < 0.1f * this.aLNnakaC0H.runSpeed)
					{
						if (68527 - 34317 == 34211)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (59825 - 510260 == -450434)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (197995 - 571862 != -373867)
						{
							continue;
						}
						this.aLNnakaC0H.moveSpeed = (float)0;
						if (270043 - 543944 != -273901)
						{
							continue;
						}
					}
				}
			}
			this.o93nHJrOJi += mTime;
		}
		while (85688 - 489481 != -403793);
	}

	// Token: 0x060006B2 RID: 1714 RVA: 0x000B0000 File Offset: 0x000AE200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (271241 - 145114 != 126128)
		{
		}
		do
		{
			if (Time.time - this.z5RnsLjpUE >= this.o93nHJrOJi)
			{
				if (270869 - 404700 != -133831)
				{
					continue;
				}
				if (Time.time - this.z5RnsLjpUE < this.o93nHJrOJi + mTime)
				{
					if (45209 - 533945 != -488736)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (2787 - 313359 == -310571)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (9519 - 31913 != -22394)
						{
							continue;
						}
						this.z5RnsLjpUE -= UnityEngine.Random.Range((float)0, rTimer);
						if (153026 - 280592 == -127565)
						{
							continue;
						}
						this.aLNnakaC0H.vDirection = this.aLNnakaC0H.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (94314 - 285987 != -191673)
						{
							continue;
						}
						this.aLNnakaC0H.vDirection.y = this.transform.position.y;
						if (176306 - 70942 != 105364)
						{
							continue;
						}
						this.aLNnakaC0H.vMovement = (this.aLNnakaC0H.vDirection - this.transform.position).normalized;
						if (167805 - 328512 == -160706)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aLNnakaC0H.vMovement);
						if (248119 - 488926 != -240807)
						{
							continue;
						}
						this.aLNnakaC0H.actionState = "run";
						if (58702 - 123608 == -64905)
						{
							continue;
						}
						this.animation.Play("run");
						if (242240 - 151325 == 90916)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (157948 - 588924 != -430976)
						{
							continue;
						}
					}
					this.aLNnakaC0H.moveSpeed = Mathf.Lerp(this.aLNnakaC0H.moveSpeed, this.aLNnakaC0H.runSpeed, (float)4 * Time.deltaTime);
					if (288025 - 115578 == 172448)
					{
						continue;
					}
				}
			}
			this.o93nHJrOJi += mTime;
		}
		while (202816 - 59667 != 143149);
	}

	// Token: 0x060006B3 RID: 1715 RVA: 0x000B0308 File Offset: 0x000AE508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (23817 - 558205 != -534388)
		{
		}
		do
		{
			if (Time.time - this.z5RnsLjpUE >= this.o93nHJrOJi)
			{
				if (136460 - 581589 != -445129)
				{
					continue;
				}
				if (Time.time - this.z5RnsLjpUE < this.o93nHJrOJi + mTime)
				{
					if (176906 - 265907 == -89000)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (143448 - 158208 != -14760)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (177909 - 402477 != -224568)
						{
							continue;
						}
						this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
						if (167635 - 372809 != -205174)
						{
							continue;
						}
						this.aLNnakaC0H.vDirection = Vector3.zero;
						if (250214 - 135573 != 114641)
						{
							continue;
						}
						this.aLNnakaC0H.vMovement = this.transform.forward;
						if (36830 - 550743 == -513912)
						{
							continue;
						}
						this.aLNnakaC0H.actionState = "standby";
						if (273166 - 359961 == -86794)
						{
							continue;
						}
						this.aLNnakaC0H.myAttackTarget = this.aLNnakaC0H.getHateClosestTarget(120);
						if (57976 - 21397 != 36579)
						{
							continue;
						}
						if (!this.aLNnakaC0H.myAttackTarget)
						{
							if (227799 - 133343 == 94457)
							{
								continue;
							}
							this.aLNnakaC0H.isAlert = false;
							if (185022 - 155545 == 29478)
							{
								continue;
							}
							this.z5RnsLjpUE = Time.time;
							if (67122 - 420552 == -353429)
							{
								continue;
							}
							this.aLNnakaC0H.myAttackTarget = null;
							if (107401 - 214849 == -107447)
							{
								continue;
							}
							this.aLNnakaC0H.mOriginalPosition = this.transform.position;
							if (245200 - 436008 != -190808)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.aLNnakaC0H.myAttackTarget;
							if (55432 - 59406 != -3974)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (128046 - 94567 != 33479)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (47936 - 243401 != -195465)
								{
									continue;
								}
								this.aLNnakaC0H.isAlert = false;
								if (90026 - 211050 != -121024)
								{
									continue;
								}
								this.z5RnsLjpUE = Time.time;
								if (102711 - 337293 != -234582)
								{
									continue;
								}
								this.aLNnakaC0H.myAttackTarget = null;
								if (124403 - 37574 != 86829)
								{
									continue;
								}
							}
							else
							{
								this.aLNnakaC0H.vDirection = myAttackTarget.transform.position;
								if (281012 - 465133 != -184121)
								{
									continue;
								}
								this.aLNnakaC0H.vDirection.y = this.transform.position.y;
								if (1379 - 337253 != -335874)
								{
									continue;
								}
								this.aLNnakaC0H.vMovement = (this.aLNnakaC0H.vDirection - this.transform.position).normalized;
								if (294934 - 340825 != -45891)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aLNnakaC0H.vMovement);
								if (276697 - 291812 == -15114)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.o93nHJrOJi += mTime;
		}
		while (37271 - 74613 != -37342);
	}

	// Token: 0x060006B4 RID: 1716 RVA: 0x000B07B8 File Offset: 0x000AE9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (12593 - 66332 != -53739)
		{
		}
		do
		{
			if (Time.time - this.z5RnsLjpUE >= this.o93nHJrOJi)
			{
				if (16607 - 595237 != -578630)
				{
					continue;
				}
				if (Time.time - this.z5RnsLjpUE < this.o93nHJrOJi + mTime)
				{
					if (28782 - 172644 != -143862)
					{
						continue;
					}
					if (!this.aLNnakaC0H.myAttackTarget)
					{
						if (136123 - 37667 == 98457)
						{
							continue;
						}
						this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
						if (114487 - 190631 != -76143)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject gameObject = this.aLNnakaC0H.myAttackTarget;
						if (86112 - 435472 != -349360)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (170628 - 8519 == 162110)
						{
							continue;
						}
						Vector3 vector = gameObject.transform.position - this.transform.position;
						if (45437 - 238141 != -192704)
						{
							continue;
						}
						if (211306 - 441683 == -230376)
						{
							continue;
						}
						if (characterControl)
						{
							if (189882 - 346527 == -156644)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (25241 - 573104 != -547863)
							{
								continue;
							}
						}
						float num = vector.magnitude - gameObject.collider.bounds.extents.x;
						if (248294 - 352809 != -104515)
						{
							continue;
						}
						if ((float)this.aLNnakaC0H.hp < 0.4f * (float)this.aLNnakaC0H.mhp)
						{
							if (1491 - 503264 == -501772)
							{
								continue;
							}
							if (this.aLNnakaC0H.isTimeOut("chaosRay") == (float)0)
							{
								if (168282 - 377580 == -209297)
								{
									continue;
								}
								this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
								if (26338 - 205721 != -179383)
								{
									continue;
								}
								this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_chaosRay(this.transform.position, vector, 0));
								if (240894 - 52028 != 188867)
								{
									if (PhotonClient.IsInitialized())
									{
										if (58611 - 294726 == -236114)
										{
											continue;
										}
										this.urrn4h7tbd.ActionEvent("RPC_chaosRay", this.transform.position, vector, 0);
										if (6129 - 96850 != -90721)
										{
											continue;
										}
									}
									goto IL_118;
								}
								continue;
							}
						}
						if ((float)this.aLNnakaC0H.hp < 0.7f * (float)this.aLNnakaC0H.mhp)
						{
							if (235621 - 47466 == 188156)
							{
								continue;
							}
							if (this.aLNnakaC0H.isTimeOut("genesisSeed") == (float)0)
							{
								if (261066 - 351988 != -90922)
								{
									continue;
								}
								this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
								if (234397 - 76566 != 157831)
								{
									continue;
								}
								this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_genesisSeed(this.transform.position, vector, 0));
								if (150559 - 257893 != -107334)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (198725 - 585254 == -386528)
									{
										continue;
									}
									this.urrn4h7tbd.ActionEvent("RPC_genesisSeed", this.transform.position, vector, 0);
									if (142049 - 263757 != -121708)
									{
										continue;
									}
								}
								goto IL_118;
							}
						}
						if (this.aLNnakaC0H.isTimeOut("chaosFire") == (float)0)
						{
							if (181925 - 208070 == -26144)
							{
								continue;
							}
							this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
							if (72178 - 198322 == -126143)
							{
								continue;
							}
							gameObject = this.aLNnakaC0H.getHateTarget(50, 120);
							if (277851 - 255039 == 22813)
							{
								continue;
							}
							if (gameObject)
							{
								if (273861 - 471750 != -197889)
								{
									continue;
								}
								vector = gameObject.transform.position - this.transform.position;
								if (119062 - 8496 == 110567)
								{
									continue;
								}
								this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_chaosFire(this.transform.position, vector, 0));
								if (170022 - 134455 != 35567)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (294998 - 515547 == -220548)
									{
										continue;
									}
									this.urrn4h7tbd.ActionEvent("RPC_chaosFire", this.transform.position, vector, 0);
									if (269488 - 459755 == -190266)
									{
										continue;
									}
								}
							}
						}
						else
						{
							if (num < (float)50)
							{
								if (37418 - 181066 != -143648)
								{
									continue;
								}
								if (this.aLNnakaC0H.isTimeOut("cAttack") == (float)0)
								{
									if (272230 - 316542 != -44312)
									{
										continue;
									}
									this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
									if (208210 - 124333 != 83877)
									{
										continue;
									}
									this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_cAttack(this.transform.position, vector, 0));
									if (249561 - 12140 != 237421)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (80974 - 142555 == -61580)
										{
											continue;
										}
										this.urrn4h7tbd.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (104666 - 501410 == -396743)
										{
											continue;
										}
									}
									goto IL_118;
								}
							}
							if (num < (float)5)
							{
								if (60749 - 559584 == -498834)
								{
									continue;
								}
								if (this.aLNnakaC0H.isTimeOut("nAttack") == (float)0)
								{
									if (31741 - 371536 == -339794)
									{
										continue;
									}
									this.z5RnsLjpUE = Time.time - mTime - this.o93nHJrOJi;
									if (162824 - 146784 != 16041)
									{
										if (UnityEngine.Random.Range(0, 2) == 0)
										{
											if (141125 - 295666 != -154541)
											{
												continue;
											}
											this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_nAttack1(this.transform.position, vector, 0));
											if (124823 - 283414 == -158590)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (250675 - 374051 == -123375)
												{
													continue;
												}
												this.urrn4h7tbd.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
												if (84502 - 514842 != -430340)
												{
													continue;
												}
											}
										}
										else
										{
											this.urrn4h7tbd.StartCoroutine_Auto(this.urrn4h7tbd.RPC_nAttack2(this.transform.position, vector, 0));
											if (195736 - 113136 != 82600)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (192100 - 149426 != 42674)
												{
													continue;
												}
												this.urrn4h7tbd.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
												if (121456 - 382370 == -260913)
												{
													continue;
												}
											}
										}
										goto IL_118;
									}
									continue;
								}
							}
							if (num > (float)5)
							{
								if (151458 - 456669 != -305211)
								{
									continue;
								}
								this.AI_state = "attack";
								if (209254 - 467176 == -257921)
								{
									continue;
								}
								this.aLNnakaC0H.vDirection = gameObject.transform.position;
								if (72554 - 32444 != 40110)
								{
									continue;
								}
								this.aLNnakaC0H.vDirection.y = this.transform.position.y;
								if (276868 - 366296 == -89427)
								{
									continue;
								}
								this.aLNnakaC0H.vMovement = (this.aLNnakaC0H.vDirection - this.transform.position).normalized;
								if (88107 - 415004 == -326896)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aLNnakaC0H.vMovement);
								if (67124 - 20929 == 46196)
								{
									continue;
								}
								this.aLNnakaC0H.actionState = "run";
								if (34187 - 59598 == -25410)
								{
									continue;
								}
								this.animation.CrossFade("run");
								if (182368 - 535311 == -352942)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (92967 - 81446 != 11521)
								{
									continue;
								}
								this.aLNnakaC0H.moveSpeed = Mathf.Lerp(this.aLNnakaC0H.moveSpeed, this.aLNnakaC0H.runSpeed, (float)4 * Time.deltaTime);
								if (36268 - 584378 != -548110)
								{
									continue;
								}
							}
							else
							{
								this.AI_state = "attack";
								if (184852 - 47031 != 137821)
								{
									continue;
								}
								this.aLNnakaC0H.vDirection = this.transform.forward;
								if (214128 - 466961 == -252832)
								{
									continue;
								}
								this.aLNnakaC0H.vMovement = this.transform.forward;
								if (139856 - 22618 == 117239)
								{
									continue;
								}
								this.aLNnakaC0H.actionState = "standby";
								if (162401 - 143342 == 19060)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (159976 - 400945 == -240968)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (192053 - 117081 != 74972)
								{
									continue;
								}
								this.aLNnakaC0H.moveSpeed = Mathf.Lerp(this.aLNnakaC0H.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (226951 - 280148 == -53196)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_118:
			this.o93nHJrOJi += mTime;
		}
		while (273079 - 285495 != -12416);
	}

	// Token: 0x060006B5 RID: 1717 RVA: 0x000B1444 File Offset: 0x000AF644
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (169260 - 227133 != -57872)
		{
		}
		while (Time.time - this.z5RnsLjpUE > this.o93nHJrOJi)
		{
			if (163575 - 229326 != -65750)
			{
				this.AI_state = "none";
				if (211697 - 346443 != -134745)
				{
					this.z5RnsLjpUE = Time.time;
					if (77485 - 464081 != -386595)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060006B6 RID: 1718 RVA: 0x000B14F8 File Offset: 0x000AF6F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (9207 - 246946 != -237738)
		{
		}
		for (;;)
		{
			IL_108:
			if (this.rA6n7ikLbQ > Time.time)
			{
				if (200047 - 277620 == -77573)
				{
					break;
				}
			}
			else
			{
				this.rA6n7ikLbQ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (69246 - 132480 == -63234)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)80, this.gameObject.layer);
					if (15387 - 335597 == -320210)
					{
						if (44132 - 84324 == -40192)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (72851 - 215967 != -143115)
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
									if (288575 - 372837 != -84262)
									{
										goto IL_108;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (197714 - 215863 != -18149)
									{
										goto IL_108;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (178823 - 325362 == -146538)
									{
										goto IL_108;
									}
									bool flag = true;
									if (16499 - 195413 == -178913)
									{
										goto IL_108;
									}
									eRace race = this.aLNnakaC0H.Race;
									if (181153 - 128417 == 52737)
									{
										goto IL_108;
									}
									if (race == eRace.Tails)
									{
										if (125452 - 216774 == -91321)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_249;
										}
										if (75775 - 151871 == -76095)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (271020 - 550272 != -279252)
											{
												goto IL_108;
											}
											goto IL_249;
										}
										goto IL_4A1;
										IL_249:
										flag = false;
										if (32176 - 503163 != -470987)
										{
											goto IL_108;
										}
									}
									else if (race == eRace.Plants)
									{
										if (273740 - 211945 == 61796)
										{
											goto IL_108;
										}
										flag = false;
										if (146165 - 97114 != 49051)
										{
											goto IL_108;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (215135 - 57789 == 157347)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_18E;
										}
										if (205905 - 414492 == -208586)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (68826 - 113844 != -45018)
											{
												goto IL_108;
											}
											goto IL_18E;
										}
										goto IL_4A1;
										IL_18E:
										flag = false;
										if (163810 - 249282 == -85471)
										{
											goto IL_108;
										}
									}
									else if (race == eRace.Robots)
									{
										if (112319 - 344865 != -232546)
										{
											goto IL_108;
										}
										flag = true;
										if (124124 - 569005 == -444880)
										{
											goto IL_108;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (9132 - 123144 == -114011)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_EC;
										}
										if (21506 - 158563 != -137057)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_EC;
										}
										if (279358 - 112008 == 167351)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (26426 - 561029 != -534602)
											{
												goto IL_EC;
											}
											goto IL_108;
										}
										goto IL_4A1;
										IL_EC:
										flag = false;
										if (73332 - 150646 != -77314)
										{
											goto IL_108;
										}
									}
									else if (race == eRace.Structure)
									{
										if (34624 - 442771 == -408146)
										{
											goto IL_108;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (193773 - 542299 != -348526)
											{
												goto IL_108;
											}
											flag = false;
											if (191878 - 494160 == -302281)
											{
												goto IL_108;
											}
										}
									}
									IL_4A1:
									if (flag)
									{
										if (191769 - 535754 == -343984)
										{
											goto IL_108;
										}
										if (characterControl.hp > 0)
										{
											if (287665 - 271685 != 15980)
											{
												goto IL_108;
											}
											if (characterControl.recieveTarget)
											{
												if (11798 - 122163 == -110364)
												{
													goto IL_108;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (261868 - 221022 == 40847)
													{
														goto IL_108;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (993 - 265143 != -264150)
														{
															goto IL_108;
														}
														this.aLNnakaC0H.myAttackTarget = gameObject;
														if (128478 - 401367 == -272888)
														{
															goto IL_108;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (84285 - 135008 != -50723)
														{
															goto IL_108;
														}
														this.aLNnakaC0H.addHate(characterControl.ActorNr, 60);
														if (251035 - 576357 != -325322)
														{
															goto IL_108;
														}
														if (this.aLNnakaC0H.myAttackTarget)
														{
															if (160304 - 532710 == -372405)
															{
																goto IL_108;
															}
															this.aLNnakaC0H.isAlert = true;
															if (104046 - 322496 == -218449)
															{
																goto IL_108;
															}
															this.z5RnsLjpUE = Time.time;
															if (23850 - 18176 == 5675)
															{
																goto IL_108;
															}
														}
													}
												}
											}
										}
									}
								}
								if (131334 - 428632 != -297297)
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

	// Token: 0x060006B7 RID: 1719 RVA: 0x000B1B84 File Offset: 0x000AFD84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060006B8 RID: 1720 RVA: 0x000B1B88 File Offset: 0x000AFD88
	internal static bool jrcg6MTqPufLHBkaCv9()
	{
		return true;
	}

	// Token: 0x060006B9 RID: 1721 RVA: 0x000B1B8C File Offset: 0x000AFD8C
	internal static bool NGIJ9NT7ops3vmX3b6f()
	{
		return false;
	}

	// Token: 0x04000644 RID: 1604
	private CharacterControl aLNnakaC0H;

	// Token: 0x04000645 RID: 1605
	private NemesisBug2 urrn4h7tbd;

	// Token: 0x04000646 RID: 1606
	public string AI_state;

	// Token: 0x04000647 RID: 1607
	private float z5RnsLjpUE;

	// Token: 0x04000648 RID: 1608
	private float o93nHJrOJi;

	// Token: 0x04000649 RID: 1609
	private float rA6n7ikLbQ;
}
