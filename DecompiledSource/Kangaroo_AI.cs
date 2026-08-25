using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CA4 RID: 3236
[Serializable]
public class Kangaroo_AI : MonoBehaviour
{
	// Token: 0x06004889 RID: 18569 RVA: 0x00902090 File Offset: 0x00900290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Kangaroo_AI()
	{
		if (227759 - 563803 != -336044)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (248427 - 465390 != -216962)
			{
				base..ctor();
				if (36601 - 82779 != -46177)
				{
					this.AI_state = "none";
					if (280106 - 108705 != 171402)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600488A RID: 18570 RVA: 0x0090212C File Offset: 0x0090032C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.wqdzYLiJWM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Layz3X8Gay = (Kangaroo)this.GetComponent(typeof(Kangaroo));
	}

	// Token: 0x0600488B RID: 18571 RVA: 0x00902164 File Offset: 0x00900364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (68316 - 569065 != -500749)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (256750 - 300825 != -44075)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (214228 - 496765 == -282536)
				{
					continue;
				}
			}
			if (this.wqdzYLiJWM.isControlled)
			{
				break;
			}
			if (50884 - 550673 == -499789)
			{
				this.AIControl();
				if (100727 - 76670 == 24057)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600488C RID: 18572 RVA: 0x00902230 File Offset: 0x00900430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (229179 - 439672 != -210493)
		{
		}
		for (;;)
		{
			this.eQ8zda6h1g = (float)0;
			if (101652 - 46344 == 55308)
			{
				if (this.wqdzYLiJWM.isMine)
				{
					if (162252 - 111329 != 50924)
					{
						if (this.wqdzYLiJWM.actionState != "standby")
						{
							if (132602 - 221318 == -88715)
							{
								continue;
							}
							if (this.wqdzYLiJWM.actionState != "run")
							{
								if (276680 - 391365 != -114684)
								{
									break;
								}
								continue;
							}
						}
						if (!this.wqdzYLiJWM.isAlert)
						{
							if (114637 - 159126 == -44489)
							{
								if (this.wqdzYLiJWM.isSummon)
								{
									if (251542 - 112103 == 139440)
									{
										continue;
									}
									if (this.wqdzYLiJWM.mSummoner != null)
									{
										if (26052 - 570420 == -544367)
										{
											continue;
										}
										Vector3 vector = this.wqdzYLiJWM.mSummoner.transform.position - this.transform.position;
										if (18172 - 457259 != -439086)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (250688 - 497153 == -246464)
												{
													continue;
												}
												this.AI_follow(this.wqdzYLiJWM.mSummoner);
												if (91327 - 460725 != -369398)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (256028 - 528722 != -272694)
												{
													continue;
												}
												this.AI_resetTimer();
												if (283541 - 582454 != -298913)
												{
													continue;
												}
												this.AI_visionCheck();
												if (235008 - 366555 != -131547)
												{
													continue;
												}
											}
											goto IL_21D;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (55830 - 424976 == -369145)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (51462 - 91175 == -39712)
								{
									continue;
								}
								this.AI_resetTimer();
								if (187722 - 511352 == -323629)
								{
									continue;
								}
								this.AI_visionCheck();
								if (55992 - 25304 != 30688)
								{
									continue;
								}
								IL_21D:
								if (!this.wqdzYLiJWM.myAttackTarget)
								{
									break;
								}
								if (161064 - 363714 == -202650)
								{
									this.wqdzYLiJWM.isAlert = true;
									if (166998 - 302808 == -135810)
									{
										this.TVmzbeR4k4 = Time.time;
										if (180244 - 67497 != 112748)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (151676 - 225304 != -73627)
							{
								this.AI_idle(3f, 1f);
								if (70567 - 481325 != -410757)
								{
									this.AI_attack(10f, (float)0);
									if (126607 - 553610 == -427003)
									{
										this.AI_resetTimer();
										if (239695 - 558909 == -319214)
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
					if (this.wqdzYLiJWM.actionState != "standby")
					{
						if (186075 - 4529 != 181546)
						{
							continue;
						}
						if (this.wqdzYLiJWM.actionState != "run")
						{
							if (30956 - 458727 != -427770)
							{
								break;
							}
							continue;
						}
					}
					float num = this.wqdzYLiJWM.moveSpeed;
					if (60690 - 292601 == -231911)
					{
						float runSpeed = this.wqdzYLiJWM.runSpeed;
						if (183221 - 599662 != -416440)
						{
							Vector3 vector2 = default(Vector3);
							if (161512 - 524510 != -362997)
							{
								Vector3 vector3 = Vector3.zero;
								if (31570 - 12583 == 18987)
								{
									if ((this.wqdzYLiJWM.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (277064 - 267190 != 9874)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.wqdzYLiJWM.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (262007 - 224647 != 37360)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (40728 - 221966 == -181237)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (104214 - 265868 != -161654)
											{
												continue;
											}
											num = (float)0;
											if (277110 - 511274 != -234164)
											{
												continue;
											}
											this.transform.position = this.wqdzYLiJWM.nPosition;
											if (164327 - 520031 != -355704)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (194112 - 539493 == -345380)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (15471 - 325748 == -310276)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (223564 - 107593 == 115972)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (170778 - 68665 == 102114)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (255863 - 344487 == -88623)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (226644 - 399835 != -173191)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (35909 - 537755 != -501846)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54463 - 48199 != 6264)
											{
												continue;
											}
										}
									}
									this.wqdzYLiJWM.vMovement = vector3;
									if (156529 - 240776 != -84246)
									{
										this.wqdzYLiJWM.moveSpeed = num;
										if (86401 - 224347 == -137946)
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

	// Token: 0x0600488D RID: 18573 RVA: 0x00902A0C File Offset: 0x00900C0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (237526 - 242993 != -5467)
		{
		}
		do
		{
			if (Time.time - this.TVmzbeR4k4 >= this.eQ8zda6h1g)
			{
				if (147736 - 127675 == 20062)
				{
					continue;
				}
				if (Time.time - this.TVmzbeR4k4 < this.eQ8zda6h1g + mTime)
				{
					if (186031 - 257704 == -71672)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (148848 - 57019 != 91829)
						{
							continue;
						}
						this.AI_state = "idle";
						if (150093 - 519963 != -369870)
						{
							continue;
						}
						this.TVmzbeR4k4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (83575 - 235949 == -152373)
						{
							continue;
						}
						this.wqdzYLiJWM.vDirection = Vector3.zero;
						if (136972 - 435519 == -298546)
						{
							continue;
						}
						this.wqdzYLiJWM.vMovement = this.transform.forward;
						if (139408 - 42619 != 96789)
						{
							continue;
						}
						this.wqdzYLiJWM.actionState = "standby";
						if (234240 - 1533 == 232708)
						{
							continue;
						}
					}
					this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (212961 - 239578 == -26616)
					{
						continue;
					}
					if (this.wqdzYLiJWM.moveSpeed < 0.1f * this.wqdzYLiJWM.runSpeed)
					{
						if (278678 - 320111 == -41432)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (235184 - 200878 == 34307)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (3663 - 180341 == -176677)
						{
							continue;
						}
						this.wqdzYLiJWM.moveSpeed = (float)0;
						if (292811 - 583374 != -290563)
						{
							continue;
						}
					}
				}
			}
			this.eQ8zda6h1g += mTime;
		}
		while (155778 - 341574 == -185795);
	}

	// Token: 0x0600488E RID: 18574 RVA: 0x00902CD0 File Offset: 0x00900ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (276948 - 77113 != 199836)
		{
		}
		for (;;)
		{
			this.wqdzYLiJWM.vDirection = followObject.transform.position;
			if (170968 - 524229 != -353260)
			{
				this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
				if (148902 - 476223 == -327321)
				{
					this.wqdzYLiJWM.vMovement = (this.wqdzYLiJWM.vDirection - this.transform.position).normalized;
					if (126822 - 339014 != -212191)
					{
						this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
						if (220075 - 41947 == 178128)
						{
							this.wqdzYLiJWM.actionState = "run";
							if (12962 - 496276 == -483314)
							{
								this.animation.Play("run");
								if (182622 - 562422 == -379800)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (275097 - 462477 == -187380)
									{
										this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, this.wqdzYLiJWM.runSpeed, (float)4 * Time.deltaTime);
										if (164900 - 356322 == -191422)
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

	// Token: 0x0600488F RID: 18575 RVA: 0x00902EB8 File Offset: 0x009010B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (221291 - 114882 != 106409)
		{
		}
		do
		{
			if (Time.time - this.TVmzbeR4k4 >= this.eQ8zda6h1g)
			{
				if (139441 - 235536 == -96094)
				{
					continue;
				}
				if (Time.time - this.TVmzbeR4k4 < this.eQ8zda6h1g + mTime)
				{
					if (50215 - 427884 == -377668)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (212653 - 196343 == 16311)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (57549 - 119520 == -61970)
						{
							continue;
						}
						this.TVmzbeR4k4 -= UnityEngine.Random.Range((float)0, rTimer);
						if (96761 - 444121 == -347359)
						{
							continue;
						}
						this.wqdzYLiJWM.vDirection = this.wqdzYLiJWM.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (94820 - 328454 == -233633)
						{
							continue;
						}
						this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
						if (206029 - 416325 != -210296)
						{
							continue;
						}
						this.wqdzYLiJWM.vMovement = (this.wqdzYLiJWM.vDirection - this.transform.position).normalized;
						if (136875 - 388952 == -252076)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
						if (83781 - 198493 == -114711)
						{
							continue;
						}
						this.wqdzYLiJWM.actionState = "run";
						if (210646 - 14796 == 195851)
						{
							continue;
						}
						this.animation.Play("run");
						if (194698 - 53146 != 141552)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (270762 - 232750 != 38012)
						{
							continue;
						}
					}
					this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, this.wqdzYLiJWM.runSpeed, (float)4 * Time.deltaTime);
					if (154339 - 4892 == 149448)
					{
						continue;
					}
				}
			}
			this.eQ8zda6h1g += mTime;
		}
		while (30682 - 17470 == 13213);
	}

	// Token: 0x06004890 RID: 18576 RVA: 0x009031C0 File Offset: 0x009013C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (72655 - 554009 != -481353)
		{
		}
		do
		{
			if (Time.time - this.TVmzbeR4k4 >= this.eQ8zda6h1g)
			{
				if (98318 - 339707 == -241388)
				{
					continue;
				}
				if (Time.time - this.TVmzbeR4k4 < this.eQ8zda6h1g + mTime)
				{
					if (50660 - 203635 == -152974)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (196673 - 199302 == -2628)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (26280 - 40191 == -13910)
						{
							continue;
						}
						this.TVmzbeR4k4 = Time.time - mTime - this.eQ8zda6h1g;
						if (273916 - 354543 == -80626)
						{
							continue;
						}
						this.wqdzYLiJWM.vDirection = Vector3.zero;
						if (287343 - 568532 != -281189)
						{
							continue;
						}
						this.wqdzYLiJWM.vMovement = this.transform.forward;
						if (253903 - 423165 == -169261)
						{
							continue;
						}
						this.wqdzYLiJWM.actionState = "standby";
						if (152237 - 19561 != 132676)
						{
							continue;
						}
						this.wqdzYLiJWM.myAttackTarget = this.wqdzYLiJWM.getHateClosestTarget(50);
						if (210149 - 275282 != -65133)
						{
							continue;
						}
						if (!this.wqdzYLiJWM.myAttackTarget)
						{
							if (129977 - 159259 != -29282)
							{
								continue;
							}
							this.wqdzYLiJWM.isAlert = false;
							if (272127 - 502548 != -230421)
							{
								continue;
							}
							this.TVmzbeR4k4 = Time.time;
							if (281234 - 445814 == -164579)
							{
								continue;
							}
							this.wqdzYLiJWM.myAttackTarget = null;
							if (117577 - 260226 == -142648)
							{
								continue;
							}
							this.wqdzYLiJWM.mOriginalPosition = this.transform.position;
							if (57470 - 591457 != -533986)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.wqdzYLiJWM.myAttackTarget;
							if (239388 - 396357 != -156969)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (124734 - 371400 != -246666)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (42019 - 479579 != -437560)
								{
									continue;
								}
								this.wqdzYLiJWM.isAlert = false;
								if (165695 - 275086 != -109391)
								{
									continue;
								}
								this.TVmzbeR4k4 = Time.time;
								if (124374 - 452218 == -327843)
								{
									continue;
								}
								this.wqdzYLiJWM.myAttackTarget = null;
								if (24927 - 259018 == -234090)
								{
									continue;
								}
							}
							else
							{
								this.wqdzYLiJWM.vDirection = myAttackTarget.transform.position;
								if (278331 - 497285 == -218953)
								{
									continue;
								}
								this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
								if (21273 - 549361 != -528088)
								{
									continue;
								}
								this.wqdzYLiJWM.vMovement = (this.wqdzYLiJWM.vDirection - this.transform.position).normalized;
								if (289116 - 519765 == -230648)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
								if (106741 - 70696 == 36046)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.eQ8zda6h1g += mTime;
		}
		while (205077 - 159621 != 45456);
	}

	// Token: 0x06004891 RID: 18577 RVA: 0x00903670 File Offset: 0x00901870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (114355 - 277640 != -163285)
		{
		}
		do
		{
			if (Time.time - this.TVmzbeR4k4 >= this.eQ8zda6h1g)
			{
				if (284433 - 132263 == 152171)
				{
					continue;
				}
				if (Time.time - this.TVmzbeR4k4 < this.eQ8zda6h1g + mTime)
				{
					if (189758 - 547854 != -358096)
					{
						continue;
					}
					if (!this.wqdzYLiJWM.myAttackTarget)
					{
						if (145086 - 416573 != -271487)
						{
							continue;
						}
						this.TVmzbeR4k4 = Time.time - mTime - this.eQ8zda6h1g;
						if (129885 - 226558 != -96672)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.wqdzYLiJWM.myAttackTarget;
						if (217972 - 289907 == -71934)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (241254 - 263948 == -22693)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (112230 - 243335 != -131105)
						{
							continue;
						}
						int tID = 0;
						if (289039 - 301156 != -12117)
						{
							continue;
						}
						if (characterControl)
						{
							if (262590 - 137491 == 125100)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (27484 - 247317 == -219832)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (294522 - 178666 == 115857)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (88782 - 100805 == -12022)
							{
								continue;
							}
							if (this.wqdzYLiJWM.isTimeOut("nAttack") == (float)0)
							{
								if (188588 - 592981 != -404393)
								{
									continue;
								}
								this.TVmzbeR4k4 = Time.time - mTime - this.eQ8zda6h1g;
								if (276836 - 83476 != 193360)
								{
									continue;
								}
								this.Layz3X8Gay.StartCoroutine_Auto(this.Layz3X8Gay.RPC_nAttack(this.transform.position, vector.normalized, tID));
								if (259706 - 561289 != -301583)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (98341 - 233264 == -134922)
									{
										continue;
									}
									this.Layz3X8Gay.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
									if (9515 - 8345 == 1171)
									{
										continue;
									}
								}
								goto IL_686;
							}
						}
						if (this.wqdzYLiJWM.isTimeOut("cAttack") == (float)0)
						{
							if (261469 - 76687 == 184783)
							{
								continue;
							}
							this.TVmzbeR4k4 = Time.time - mTime - this.eQ8zda6h1g;
							if (172913 - 438767 == -265853)
							{
								continue;
							}
							this.Layz3X8Gay.StartCoroutine_Auto(this.Layz3X8Gay.RPC_scan(this.transform.position, vector.normalized, tID));
							if (8667 - 599651 == -590983)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (92933 - 233608 != -140675)
								{
									continue;
								}
								this.Layz3X8Gay.ActionEvent("RPC_scan", this.transform.position, vector.normalized, tID);
								if (262468 - 592467 == -329998)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (166935 - 356661 != -189726)
							{
								continue;
							}
							if (this.wqdzYLiJWM.isSummon)
							{
								if (133516 - 233334 == -99817)
								{
									continue;
								}
								if (this.wqdzYLiJWM.mSummoner != null)
								{
									if (74892 - 128389 != -53497)
									{
										continue;
									}
									Vector3 vector2 = this.wqdzYLiJWM.mSummoner.transform.position - this.transform.position;
									if (281193 - 342246 != -61052)
									{
										if (vector2.sqrMagnitude > (float)144)
										{
											if (57677 - 156168 != -98491)
											{
												continue;
											}
											this.wqdzYLiJWM.vDirection = this.wqdzYLiJWM.mSummoner.transform.position;
											if (48791 - 390227 != -341436)
											{
												continue;
											}
											this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
											if (196516 - 364816 != -168300)
											{
												continue;
											}
											this.wqdzYLiJWM.vMovement = (this.wqdzYLiJWM.vDirection - this.transform.position).normalized;
											if (187333 - 423247 != -235914)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
											if (58065 - 268022 == -209956)
											{
												continue;
											}
											this.wqdzYLiJWM.actionState = "run";
											if (226158 - 349583 == -123424)
											{
												continue;
											}
											this.animation.Play("run");
											if (184683 - 422133 == -237449)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (140109 - 105818 == 34292)
											{
												continue;
											}
											this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, this.wqdzYLiJWM.runSpeed, (float)4 * Time.deltaTime);
											if (271782 - 550657 == -278874)
											{
												continue;
											}
										}
										else
										{
											this.wqdzYLiJWM.vDirection = myAttackTarget.transform.position;
											if (175125 - 105937 != 69188)
											{
												continue;
											}
											this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
											if (143676 - 244333 == -100656)
											{
												continue;
											}
											this.wqdzYLiJWM.vMovement = (this.transform.position - this.wqdzYLiJWM.vDirection).normalized;
											if (76941 - 558568 != -481627)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
											if (282039 - 563544 == -281504)
											{
												continue;
											}
											this.wqdzYLiJWM.actionState = "standby";
											if (14704 - 373955 != -359251)
											{
												continue;
											}
											this.animation.CrossFade("root", (float)1);
											if (100189 - 139143 != -38954)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (265686 - 150993 != 114693)
											{
												continue;
											}
											this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
											if (94177 - 31148 != 63029)
											{
												continue;
											}
										}
										goto IL_686;
									}
									continue;
								}
							}
							if (num < (float)6)
							{
								if (75022 - 588890 == -513867)
								{
									continue;
								}
								this.wqdzYLiJWM.vDirection = myAttackTarget.transform.position;
								if (108101 - 124871 != -16770)
								{
									continue;
								}
								this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
								if (68056 - 373420 != -305364)
								{
									continue;
								}
								this.wqdzYLiJWM.vMovement = (this.transform.position - this.wqdzYLiJWM.vDirection).normalized;
								if (197876 - 24293 != 173583)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
								if (228508 - 442555 == -214046)
								{
									continue;
								}
								this.wqdzYLiJWM.actionState = "run";
								if (170140 - 375497 == -205356)
								{
									continue;
								}
								this.animation.Play("run");
								if (68379 - 499303 != -430924)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (115601 - 354798 != -239197)
								{
									continue;
								}
								this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, this.wqdzYLiJWM.runSpeed, (float)4 * Time.deltaTime);
								if (138388 - 134569 == 3820)
								{
									continue;
								}
							}
							else
							{
								this.wqdzYLiJWM.vDirection = myAttackTarget.transform.position;
								if (241485 - 13711 != 227774)
								{
									continue;
								}
								this.wqdzYLiJWM.vDirection.y = this.transform.position.y;
								if (199689 - 560165 == -360475)
								{
									continue;
								}
								this.wqdzYLiJWM.vMovement = (this.transform.position - this.wqdzYLiJWM.vDirection).normalized;
								if (248446 - 170139 == 78308)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.wqdzYLiJWM.vMovement);
								if (294017 - 145549 != 148468)
								{
									continue;
								}
								this.wqdzYLiJWM.actionState = "standby";
								if (265332 - 113263 != 152069)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (295681 - 170275 != 125406)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (210970 - 481208 != -270238)
								{
									continue;
								}
								this.wqdzYLiJWM.moveSpeed = Mathf.Lerp(this.wqdzYLiJWM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (111408 - 489505 != -378097)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_686:
			this.eQ8zda6h1g += mTime;
		}
		while (223666 - 253706 != -30040);
	}

	// Token: 0x06004892 RID: 18578 RVA: 0x009042D0 File Offset: 0x009024D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (204282 - 345056 != -140773)
		{
		}
		while (Time.time - this.TVmzbeR4k4 > this.eQ8zda6h1g)
		{
			if (196487 - 357750 == -161263)
			{
				this.AI_state = "none";
				if (14730 - 563673 == -548943)
				{
					this.TVmzbeR4k4 = Time.time;
					if (15734 - 333056 != -317321)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x00904384 File Offset: 0x00902584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (56516 - 42004 != 14513)
		{
		}
		for (;;)
		{
			IL_222:
			if (this.v1NzgLxJrs > Time.time)
			{
				if (184601 - 292649 != -108047)
				{
					break;
				}
			}
			else
			{
				this.v1NzgLxJrs = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (97898 - 582374 != -484475)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (102425 - 202411 != -99985 && 27940 - 290480 != -262539)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (284955 - 210060 == 74895)
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
								if (134788 - 476518 != -341730)
								{
									goto IL_222;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (193614 - 565438 != -371824)
								{
									goto IL_222;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (202628 - 424739 != -222111)
								{
									goto IL_222;
								}
								bool flag = true;
								if (205519 - 162249 == 43271)
								{
									goto IL_222;
								}
								eRace race = this.wqdzYLiJWM.Race;
								if (60339 - 357990 == -297650)
								{
									goto IL_222;
								}
								if (race == eRace.Tails)
								{
									if (240071 - 47153 == 192919)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_521;
									}
									if (36222 - 116061 == -79838)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (449 - 208746 != -208297)
										{
											goto IL_222;
										}
										goto IL_521;
									}
									goto IL_1F;
									IL_521:
									flag = false;
									if (106660 - 169746 == -63085)
									{
										goto IL_222;
									}
								}
								else if (race == eRace.Plants)
								{
									if (2925 - 286329 != -283404)
									{
										goto IL_222;
									}
									flag = false;
									if (194619 - 219512 == -24892)
									{
										goto IL_222;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (162637 - 428295 == -265657)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_14E;
									}
									if (61146 - 586492 != -525346)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (36200 - 166363 != -130163)
										{
											goto IL_222;
										}
										goto IL_14E;
									}
									goto IL_1F;
									IL_14E:
									flag = false;
									if (76574 - 299560 == -222985)
									{
										goto IL_222;
									}
								}
								else if (race == eRace.Robots)
								{
									if (158500 - 16250 != 142250)
									{
										goto IL_222;
									}
									flag = true;
									if (267810 - 237273 == 30538)
									{
										goto IL_222;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (261282 - 286887 == -25604)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_24C;
									}
									if (28004 - 284889 != -256885)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_24C;
									}
									if (96418 - 246945 == -150526)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (258259 - 429612 != -171352)
										{
											goto IL_24C;
										}
										goto IL_222;
									}
									goto IL_1F;
									IL_24C:
									flag = false;
									if (298266 - 109938 == 188329)
									{
										goto IL_222;
									}
								}
								else if (race == eRace.Structure)
								{
									if (298887 - 101793 != 197094)
									{
										goto IL_222;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (254293 - 185331 == 68963)
										{
											goto IL_222;
										}
										flag = false;
										if (199991 - 320537 == -120545)
										{
											goto IL_222;
										}
									}
								}
								IL_1F:
								if (flag)
								{
									if (3646 - 561589 == -557942)
									{
										goto IL_222;
									}
									if (characterControl.hp > 0)
									{
										if (34833 - 587712 == -552878)
										{
											goto IL_222;
										}
										if (characterControl.recieveTarget)
										{
											if (107696 - 324280 != -216584)
											{
												goto IL_222;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (1055 - 260529 == -259473)
												{
													goto IL_222;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (204207 - 369093 == -164885)
													{
														goto IL_222;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (242722 - 256338 != -13616)
													{
														goto IL_222;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (8945 - 122220 == -113274)
														{
															goto IL_222;
														}
														this.wqdzYLiJWM.myAttackTarget = gameObject;
														if (287557 - 532621 != -245064)
														{
															goto IL_222;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (239666 - 126986 != 112680)
														{
															goto IL_222;
														}
														this.wqdzYLiJWM.addHate(characterControl.ActorNr, 5);
														if (7785 - 497081 != -489296)
														{
															goto IL_222;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (114113 - 155607 != -41494)
														{
															goto IL_222;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (122144 - 25789 == 96356)
														{
															goto IL_222;
														}
														if (num < (float)60)
														{
															if (289849 - 169401 == 120449)
															{
																goto IL_222;
															}
															if (characterControl.hp > 0)
															{
																if (32982 - 221928 == -188945)
																{
																	goto IL_222;
																}
																this.wqdzYLiJWM.myAttackTarget = gameObject;
																if (12420 - 146394 == -133973)
																{
																	goto IL_222;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (129345 - 409005 != -279660)
																{
																	goto IL_222;
																}
																this.wqdzYLiJWM.addHate(characterControl.ActorNr, 5);
																if (203148 - 455401 == -252252)
																{
																	goto IL_222;
																}
															}
														}
													}
													if (this.wqdzYLiJWM.myAttackTarget)
													{
														if (25686 - 251078 == -225391)
														{
															goto IL_222;
														}
														this.wqdzYLiJWM.isAlert = true;
														if (261345 - 338924 != -77579)
														{
															goto IL_222;
														}
														this.TVmzbeR4k4 = Time.time;
														if (187296 - 222817 != -35521)
														{
															goto IL_222;
														}
													}
												}
											}
										}
									}
								}
							}
							if (54949 - 99731 != -44781)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x00904B9C File Offset: 0x00902D9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x00904BA0 File Offset: 0x00902DA0
	internal static bool GdovQs5v2SYDWsUb7dS0()
	{
		return true;
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x00904BA4 File Offset: 0x00902DA4
	internal static bool TZCVLC5v8K9EoGfToEe1()
	{
		return false;
	}

	// Token: 0x04005383 RID: 21379
	private CharacterControl wqdzYLiJWM;

	// Token: 0x04005384 RID: 21380
	private Kangaroo Layz3X8Gay;

	// Token: 0x04005385 RID: 21381
	public string AI_state;

	// Token: 0x04005386 RID: 21382
	private float TVmzbeR4k4;

	// Token: 0x04005387 RID: 21383
	private float eQ8zda6h1g;

	// Token: 0x04005388 RID: 21384
	private float v1NzgLxJrs;
}
