using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000079 RID: 121
[Serializable]
public class ForestBug_AI : MonoBehaviour
{
	// Token: 0x06000286 RID: 646 RVA: 0x00040574 File Offset: 0x0003E774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ForestBug_AI()
	{
		if (45998 - 423004 != -377005)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (174587 - 427025 == -252438)
			{
				base..ctor();
				if (294260 - 424674 == -130414)
				{
					this.AI_state = "none";
					if (94947 - 283683 == -188736)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00040610 File Offset: 0x0003E810
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LiUAsPwZb = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.c4i9bDFN7 = (ForestBug)this.GetComponent(typeof(ForestBug));
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00040648 File Offset: 0x0003E848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (216424 - 416559 != -200134)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (239602 - 988 != 238614)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (108569 - 146214 == -37644)
				{
					continue;
				}
			}
			if (this.LiUAsPwZb.isControlled)
			{
				break;
			}
			if (153583 - 573148 != -419564)
			{
				this.AIControl();
				if (207010 - 167844 == 39166)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00040714 File Offset: 0x0003E914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (41690 - 493511 != -451820)
		{
		}
		for (;;)
		{
			this.Sg8uQRB1P = (float)0;
			if (186337 - 92452 == 93885)
			{
				if (this.LiUAsPwZb.isMine)
				{
					if (181009 - 49011 != 131999)
					{
						if (this.LiUAsPwZb.actionState != "standby")
						{
							if (78380 - 247228 != -168848)
							{
								continue;
							}
							if (this.LiUAsPwZb.actionState != "run")
							{
								if (147893 - 108158 != 39736)
								{
									break;
								}
								continue;
							}
						}
						if (!this.LiUAsPwZb.isAlert)
						{
							if (210158 - 195879 == 14279)
							{
								this.AI_idle(3f, 1f);
								if (100708 - 171171 != -70462)
								{
									this.AI_patrol(1f, 0.25f);
									if (241974 - 63941 == 178033)
									{
										this.AI_resetTimer();
										if (20358 - 146871 != -126512)
										{
											this.AI_visionCheck();
											if (263466 - 24862 != 238605)
											{
												if (!this.LiUAsPwZb.myAttackTarget)
												{
													break;
												}
												if (69369 - 158494 != -89124)
												{
													this.LiUAsPwZb.isAlert = true;
													if (213700 - 8441 == 205259)
													{
														this.zHSW0wKDV = Time.time;
														if (208591 - 515019 == -306428)
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
							if (100542 - 74519 != 26024)
							{
								this.AI_idle(3f, 2f);
								if (282512 - 589262 != -306749)
								{
									this.AI_attack(4f, (float)0);
									if (30964 - 280803 == -249839)
									{
										this.AI_resetTimer();
										if (74268 - 168430 == -94162)
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
					if (this.LiUAsPwZb.actionState != "standby")
					{
						if (282216 - 484978 == -202761)
						{
							continue;
						}
						if (this.LiUAsPwZb.actionState != "run")
						{
							if (100248 - 141462 != -41213)
							{
								break;
							}
							continue;
						}
					}
					if (this.LiUAsPwZb.nSpeed != (float)0)
					{
						if (239290 - 460872 != -221582)
						{
							continue;
						}
						if (this.LiUAsPwZb.nPosition != this.LiUAsPwZb.oPosition)
						{
							if (272616 - 400770 == -128153)
							{
								continue;
							}
							Vector3 a = this.LiUAsPwZb.nPosition + 0.1f * this.LiUAsPwZb.runSpeed * this.LiUAsPwZb.nDirection;
							if (155112 - 294631 == -139518)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (112466 - 142127 == -29660)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (50724 - 414643 != -363919)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (207905 - 517011 != -309106)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (75450 - 441184 == -365733)
							{
								continue;
							}
							if (magnitude > this.LiUAsPwZb.runSpeed)
							{
								if (288332 - 386667 != -98335)
								{
									continue;
								}
								this.transform.position = this.LiUAsPwZb.nPosition;
								if (251279 - 282656 != -31377)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.LiUAsPwZb.runSpeed)
							{
								if (231055 - 273843 == -42787)
								{
									continue;
								}
								this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, 1.1f * this.LiUAsPwZb.runSpeed, (float)10 * Time.deltaTime);
								if (271748 - 272143 != -395)
								{
									continue;
								}
								this.LiUAsPwZb.vDirection = normalized;
								if (27331 - 494139 != -466808)
								{
									continue;
								}
								this.LiUAsPwZb.vMovement = normalized;
								if (158129 - 13400 == 144730)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (26431 - 558770 == -532338)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (253577 - 449893 == -196315)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (54387 - 525714 == -471326)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (137993 - 44618 != 93375)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (63256 - 172443 != -109187)
								{
									continue;
								}
								break;
							}
							else
							{
								this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (14413 - 554053 == -539639)
								{
									continue;
								}
								this.LiUAsPwZb.vDirection = normalized;
								if (282261 - 357139 == -74877)
								{
									continue;
								}
								this.LiUAsPwZb.vMovement = normalized;
								if (278357 - 587568 == -309210)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (21072 - 445137 == -424064)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (121860 - 404026 != -282166)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.LiUAsPwZb.moveSpeed != (float)0)
					{
						if (62343 - 423458 != -361114)
						{
							Vector3 vector3 = global::Math.vFlat(this.LiUAsPwZb.nPosition - this.transform.position);
							if (57666 - 368987 != -311320)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (206227 - 117359 != 88869)
								{
									if (sqrMagnitude > this.LiUAsPwZb.runSpeed)
									{
										if (70001 - 178473 == -108472)
										{
											this.transform.position = this.LiUAsPwZb.nPosition;
											if (167873 - 200557 == -32684)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (193887 - 112294 != 81594)
										{
											if (sqrMagnitude > (float)1)
											{
												if (67939 - 14344 != 53595)
												{
													continue;
												}
												this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, this.LiUAsPwZb.runSpeed, (float)10 * Time.deltaTime);
												if (90376 - 435047 == -344670)
												{
													continue;
												}
											}
											else
											{
												this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (2824 - 427925 == -425100)
												{
													continue;
												}
											}
											this.LiUAsPwZb.vMovement = vector3;
											if (199459 - 561758 == -362299)
											{
												this.LiUAsPwZb.vDirection = vector3;
												if (287675 - 586608 == -298933)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (163705 - 380289 != -216583)
													{
														this.animation.CrossFade("run", 0.2f);
														if (239848 - 502436 != -262587)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (65289 - 393521 != -328231)
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
										this.LiUAsPwZb.vMovement = vector3;
										if (110242 - 519183 == -408941)
										{
											this.LiUAsPwZb.moveSpeed = (float)0;
											if (146568 - 423562 != -276993)
											{
												this.transform.rotation = Quaternion.LookRotation(this.LiUAsPwZb.vDirection);
												if (5265 - 549057 != -543791)
												{
													this.animation.CrossFade("root", 0.2f);
													if (156113 - 271520 == -115407)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (152023 - 433395 == -281372)
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
						this.animation.CrossFade("root", 0.2f);
						if (60229 - 293107 != -232877)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (17155 - 55834 == -38679)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00041294 File Offset: 0x0003F494
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (227306 - 299631 != -72324)
		{
		}
		do
		{
			if (Time.time - this.zHSW0wKDV >= this.Sg8uQRB1P)
			{
				if (22157 - 253711 != -231554)
				{
					continue;
				}
				if (Time.time - this.zHSW0wKDV < this.Sg8uQRB1P + mTime)
				{
					if (186347 - 482960 != -296613)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (201158 - 47418 != 153740)
						{
							continue;
						}
						this.AI_state = "idle";
						if (8019 - 338687 == -330667)
						{
							continue;
						}
						this.zHSW0wKDV -= UnityEngine.Random.Range((float)0, rTimer);
						if (259559 - 235861 == 23699)
						{
							continue;
						}
						this.LiUAsPwZb.vDirection = Vector3.zero;
						if (278296 - 516659 != -238363)
						{
							continue;
						}
						this.LiUAsPwZb.vMovement = this.transform.forward;
						if (560 - 139219 != -138659)
						{
							continue;
						}
						this.LiUAsPwZb.actionState = "standby";
						if (34735 - 487354 == -452618)
						{
							continue;
						}
					}
					this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (286642 - 472979 != -186337)
					{
						continue;
					}
					if (this.LiUAsPwZb.moveSpeed < 0.1f * this.LiUAsPwZb.runSpeed)
					{
						if (146051 - 166076 != -20025)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (130195 - 74555 != 55640)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (193989 - 18109 != 175880)
						{
							continue;
						}
						this.LiUAsPwZb.moveSpeed = (float)0;
						if (244579 - 131931 == 112649)
						{
							continue;
						}
					}
				}
			}
			this.Sg8uQRB1P += mTime;
		}
		while (183577 - 536240 != -352663);
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00041558 File Offset: 0x0003F758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (262972 - 593170 != -330198)
		{
		}
		do
		{
			if (Time.time - this.zHSW0wKDV >= this.Sg8uQRB1P)
			{
				if (137607 - 406967 == -269359)
				{
					continue;
				}
				if (Time.time - this.zHSW0wKDV < this.Sg8uQRB1P + mTime)
				{
					if (171887 - 304289 != -132402)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (67399 - 452141 == -384741)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (115206 - 165016 != -49810)
						{
							continue;
						}
						this.zHSW0wKDV -= UnityEngine.Random.Range((float)0, rTimer);
						if (106550 - 152446 != -45896)
						{
							continue;
						}
						this.LiUAsPwZb.vDirection = this.LiUAsPwZb.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (68402 - 6129 == 62274)
						{
							continue;
						}
						this.LiUAsPwZb.vDirection.y = this.transform.position.y;
						if (144764 - 429287 == -284522)
						{
							continue;
						}
						this.LiUAsPwZb.vMovement = (this.LiUAsPwZb.vDirection - this.transform.position).normalized;
						if (272926 - 487800 == -214873)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.LiUAsPwZb.vMovement);
						if (216509 - 291426 == -74916)
						{
							continue;
						}
						this.LiUAsPwZb.actionState = "run";
						if (169852 - 79231 != 90621)
						{
							continue;
						}
						this.animation.Play("run");
						if (64015 - 79378 != -15363)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (191202 - 355673 == -164470)
						{
							continue;
						}
					}
					this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, this.LiUAsPwZb.runSpeed, (float)4 * Time.deltaTime);
					if (245718 - 123586 == 122133)
					{
						continue;
					}
				}
			}
			this.Sg8uQRB1P += mTime;
		}
		while (91339 - 568439 != -477100);
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00041860 File Offset: 0x0003FA60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (145676 - 569297 != -423621)
		{
		}
		do
		{
			if (Time.time - this.zHSW0wKDV >= this.Sg8uQRB1P)
			{
				if (208063 - 428014 == -219950)
				{
					continue;
				}
				if (Time.time - this.zHSW0wKDV < this.Sg8uQRB1P + mTime)
				{
					if (122828 - 431663 == -308834)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (195659 - 181539 != 14120)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (256349 - 484281 != -227932)
						{
							continue;
						}
						this.zHSW0wKDV = Time.time - mTime - this.Sg8uQRB1P;
						if (115765 - 439158 == -323392)
						{
							continue;
						}
						this.LiUAsPwZb.vDirection = Vector3.zero;
						if (136747 - 218574 == -81826)
						{
							continue;
						}
						this.LiUAsPwZb.vMovement = this.transform.forward;
						if (31894 - 545697 == -513802)
						{
							continue;
						}
						this.LiUAsPwZb.actionState = "standby";
						if (57973 - 355129 != -297156)
						{
							continue;
						}
						this.LiUAsPwZb.myAttackTarget = this.LiUAsPwZb.getHateTarget(15, 40);
						if (95251 - 385799 != -290548)
						{
							continue;
						}
						if (!this.LiUAsPwZb.myAttackTarget)
						{
							if (183034 - 329833 == -146798)
							{
								continue;
							}
							this.LiUAsPwZb.isAlert = false;
							if (93512 - 188592 != -95080)
							{
								continue;
							}
							this.zHSW0wKDV = Time.time;
							if (136698 - 215099 == -78400)
							{
								continue;
							}
							this.LiUAsPwZb.myAttackTarget = null;
							if (30915 - 221469 != -190554)
							{
								continue;
							}
							this.LiUAsPwZb.mOriginalPosition = this.transform.position;
							if (204525 - 435550 != -231024)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.LiUAsPwZb.myAttackTarget;
							if (137354 - 534265 == -396910)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (126950 - 422916 != -295966)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (9825 - 456282 != -446457)
								{
									continue;
								}
								this.LiUAsPwZb.isAlert = false;
								if (266541 - 585301 != -318760)
								{
									continue;
								}
								this.zHSW0wKDV = Time.time;
								if (33232 - 247987 == -214754)
								{
									continue;
								}
								this.LiUAsPwZb.myAttackTarget = null;
								if (287121 - 130084 == 157038)
								{
									continue;
								}
							}
							else
							{
								this.LiUAsPwZb.vDirection = myAttackTarget.transform.position;
								if (17578 - 559637 == -542058)
								{
									continue;
								}
								this.LiUAsPwZb.vDirection.y = this.transform.position.y;
								if (195449 - 396409 != -200960)
								{
									continue;
								}
								this.LiUAsPwZb.vMovement = (this.LiUAsPwZb.vDirection - this.transform.position).normalized;
								if (92992 - 403257 == -310264)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LiUAsPwZb.vMovement);
								if (80588 - 523419 == -442830)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Sg8uQRB1P += mTime;
		}
		while (10004 - 249830 == -239825);
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00041D10 File Offset: 0x0003FF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (215430 - 100895 != 114536)
		{
		}
		do
		{
			if (Time.time - this.zHSW0wKDV >= this.Sg8uQRB1P)
			{
				if (226500 - 511672 == -285171)
				{
					continue;
				}
				if (Time.time - this.zHSW0wKDV < this.Sg8uQRB1P + mTime)
				{
					if (258140 - 81835 != 176305)
					{
						continue;
					}
					if (!this.LiUAsPwZb.myAttackTarget)
					{
						if (72971 - 521664 == -448692)
						{
							continue;
						}
						this.zHSW0wKDV = Time.time - mTime - this.Sg8uQRB1P;
						if (159067 - 372278 != -213211)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.LiUAsPwZb.myAttackTarget;
						if (96462 - 120987 != -24525)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (267225 - 122612 == 144614)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (43298 - 304113 != -260815)
						{
							continue;
						}
						int tID = 0;
						if (245728 - 226639 == 19090)
						{
							continue;
						}
						if (characterControl)
						{
							if (159245 - 502537 != -343292)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (87405 - 488709 == -401303)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (20099 - 549810 == -529710)
						{
							continue;
						}
						if (this.LiUAsPwZb.isTimeOut("nAttack") == (float)0)
						{
							if (131261 - 198969 == -67707)
							{
								continue;
							}
							if (this.LiUAsPwZb.mp >= 10)
							{
								if (256084 - 435270 == -179185)
								{
									continue;
								}
								this.zHSW0wKDV = Time.time - mTime - this.Sg8uQRB1P;
								if (119373 - 325568 != -206195)
								{
									continue;
								}
								this.c4i9bDFN7.StartCoroutine_Auto(this.c4i9bDFN7.RPC_forestBlast(this.transform.position, vector, tID));
								if (284915 - 287069 != -2154)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (240584 - 137178 != 103406)
									{
										continue;
									}
									this.c4i9bDFN7.ActionEvent("RPC_forestBlast", this.transform.position, vector, tID);
									if (165150 - 83881 != 81269)
									{
										continue;
									}
								}
								goto IL_86;
							}
						}
						this.AI_state = "attack";
						if (253999 - 139698 == 114302)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (266639 - 480253 == -213613)
							{
								continue;
							}
							this.LiUAsPwZb.vDirection = myAttackTarget.transform.position;
							if (56266 - 337571 == -281304)
							{
								continue;
							}
							this.LiUAsPwZb.vDirection.y = this.transform.position.y;
							if (119812 - 177046 == -57233)
							{
								continue;
							}
							this.LiUAsPwZb.vMovement = (this.LiUAsPwZb.vDirection - this.transform.position).normalized;
							if (244382 - 211995 != 32387)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.LiUAsPwZb.vMovement);
							if (279246 - 261058 == 18189)
							{
								continue;
							}
							this.LiUAsPwZb.actionState = "run";
							if (291672 - 162365 != 129307)
							{
								continue;
							}
							this.animation.Play("flyBackward");
							if (60847 - 554673 == -493825)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (233585 - 351765 != -118180)
							{
								continue;
							}
							this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, -this.LiUAsPwZb.runSpeed, (float)4 * Time.deltaTime);
							if (109271 - 1659 == 107613)
							{
								continue;
							}
						}
						else
						{
							this.LiUAsPwZb.vDirection = myAttackTarget.transform.position;
							if (261517 - 279896 == -18378)
							{
								continue;
							}
							this.LiUAsPwZb.vDirection.y = this.transform.position.y;
							if (33726 - 321838 != -288112)
							{
								continue;
							}
							this.LiUAsPwZb.vMovement = (this.LiUAsPwZb.vDirection - this.transform.position).normalized;
							if (89482 - 261804 != -172322)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.LiUAsPwZb.vMovement);
							if (283455 - 230923 == 52533)
							{
								continue;
							}
							this.LiUAsPwZb.actionState = "standby";
							if (298421 - 3673 != 294748)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (25468 - 495495 == -470026)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (249284 - 71584 == 177701)
							{
								continue;
							}
							this.LiUAsPwZb.moveSpeed = Mathf.Lerp(this.LiUAsPwZb.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (9468 - 48218 != -38750)
							{
								continue;
							}
						}
					}
				}
			}
			IL_86:
			this.Sg8uQRB1P += mTime;
		}
		while (91006 - 542668 == -451661);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00042430 File Offset: 0x00040630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (127994 - 443706 != -315711)
		{
		}
		while (Time.time - this.zHSW0wKDV > this.Sg8uQRB1P)
		{
			if (62444 - 368129 == -305685)
			{
				this.AI_state = "none";
				if (98521 - 95034 == 3487)
				{
					this.zHSW0wKDV = Time.time;
					if (128951 - 397543 != -268591)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600028F RID: 655 RVA: 0x000424E4 File Offset: 0x000406E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (27579 - 576085 != -548505)
		{
		}
		for (;;)
		{
			IL_66B:
			if (this.xN0yXvakE > Time.time)
			{
				if (179009 - 470362 == -291353)
				{
					break;
				}
			}
			else
			{
				this.xN0yXvakE = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (66387 - 396168 != -329780)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (20303 - 61442 == -41139)
					{
						if (279401 - 238954 == 40447)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (122645 - 541762 == -419117)
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
									if (280583 - 463699 == -183115)
									{
										goto IL_66B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (31565 - 316111 == -284545)
									{
										goto IL_66B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (6139 - 237545 != -231406)
									{
										goto IL_66B;
									}
									bool flag = true;
									if (73503 - 493510 == -420006)
									{
										goto IL_66B;
									}
									eRace race = this.LiUAsPwZb.Race;
									if (30956 - 555825 == -524868)
									{
										goto IL_66B;
									}
									if (race == eRace.Tails)
									{
										if (1852 - 184474 != -182622)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_584;
										}
										if (111632 - 589506 != -477874)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (257492 - 341250 != -83757)
											{
												goto IL_584;
											}
											goto IL_66B;
										}
										goto IL_625;
										IL_584:
										flag = false;
										if (150893 - 327730 == -176836)
										{
											goto IL_66B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (13371 - 340405 != -327034)
										{
											goto IL_66B;
										}
										flag = false;
										if (119895 - 87667 != 32228)
										{
											goto IL_66B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (224739 - 388383 == -163643)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_5A0;
										}
										if (114802 - 539106 != -424304)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (226796 - 52330 != 174466)
											{
												goto IL_66B;
											}
											goto IL_5A0;
										}
										goto IL_625;
										IL_5A0:
										flag = false;
										if (253557 - 216219 != 37338)
										{
											goto IL_66B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (200200 - 303826 != -103626)
										{
											goto IL_66B;
										}
										flag = true;
										if (231349 - 512372 != -281023)
										{
											goto IL_66B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (243766 - 179861 == 63906)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_6FB;
										}
										if (220 - 480936 == -480715)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_6FB;
										}
										if (38788 - 375588 == -336799)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (229373 - 96337 != 133036)
											{
												goto IL_66B;
											}
											goto IL_6FB;
										}
										goto IL_625;
										IL_6FB:
										flag = false;
										if (184732 - 313002 != -128270)
										{
											goto IL_66B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (247217 - 201380 == 45838)
										{
											goto IL_66B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (174154 - 553348 != -379194)
											{
												goto IL_66B;
											}
											flag = false;
											if (215028 - 467518 != -252490)
											{
												goto IL_66B;
											}
										}
									}
									IL_625:
									if (flag)
									{
										if (286959 - 407652 != -120693)
										{
											goto IL_66B;
										}
										if (characterControl.hp > 0)
										{
											if (255237 - 499572 != -244335)
											{
												goto IL_66B;
											}
											if (characterControl.recieveTarget)
											{
												if (29988 - 398970 == -368981)
												{
													goto IL_66B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (60709 - 343734 == -283024)
													{
														goto IL_66B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (98003 - 41091 != 56912)
														{
															goto IL_66B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (132415 - 100245 != 32170)
														{
															goto IL_66B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (267565 - 225157 == 42409)
															{
																goto IL_66B;
															}
															this.LiUAsPwZb.myAttackTarget = gameObject;
															if (177180 - 541047 == -363866)
															{
																goto IL_66B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (276319 - 565087 == -288767)
															{
																goto IL_66B;
															}
															this.LiUAsPwZb.addHate(characterControl.ActorNr, 5);
															if (290194 - 163922 != 126272)
															{
																goto IL_66B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (278728 - 47504 == 231225)
															{
																goto IL_66B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (186004 - 434754 != -248750)
															{
																goto IL_66B;
															}
															if (num < (float)60)
															{
																if (152364 - 499298 != -346934)
																{
																	goto IL_66B;
																}
																if (characterControl.hp > 0)
																{
																	if (200949 - 24191 != 176758)
																	{
																		goto IL_66B;
																	}
																	this.LiUAsPwZb.myAttackTarget = gameObject;
																	if (273050 - 342977 != -69927)
																	{
																		goto IL_66B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (85331 - 393358 == -308026)
																	{
																		goto IL_66B;
																	}
																	this.LiUAsPwZb.addHate(characterControl.ActorNr, 5);
																	if (179677 - 206167 != -26490)
																	{
																		goto IL_66B;
																	}
																}
															}
														}
														if (this.LiUAsPwZb.myAttackTarget)
														{
															if (15241 - 29767 == -14525)
															{
																goto IL_66B;
															}
															this.LiUAsPwZb.isAlert = true;
															if (179134 - 359289 != -180155)
															{
																goto IL_66B;
															}
															this.zHSW0wKDV = Time.time;
															if (143785 - 3829 == 139957)
															{
																goto IL_66B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (298510 - 55598 == 242912)
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

	// Token: 0x06000290 RID: 656 RVA: 0x00042CFC File Offset: 0x00040EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00042D00 File Offset: 0x00040F00
	internal static bool njnBLwVjxmoOqRb877F()
	{
		return true;
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00042D04 File Offset: 0x00040F04
	internal static bool gXTrdAVhNlXeKmSh93H()
	{
		return false;
	}

	// Token: 0x0400029C RID: 668
	private CharacterControl LiUAsPwZb;

	// Token: 0x0400029D RID: 669
	private ForestBug c4i9bDFN7;

	// Token: 0x0400029E RID: 670
	public string AI_state;

	// Token: 0x0400029F RID: 671
	private float zHSW0wKDV;

	// Token: 0x040002A0 RID: 672
	private float Sg8uQRB1P;

	// Token: 0x040002A1 RID: 673
	private float xN0yXvakE;
}
