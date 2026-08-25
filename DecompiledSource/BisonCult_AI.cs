using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B9A RID: 2970
[Serializable]
public class BisonCult_AI : MonoBehaviour
{
	// Token: 0x06004230 RID: 16944 RVA: 0x0085B320 File Offset: 0x00859520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BisonCult_AI()
	{
		if (136680 - 87024 != 49657)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (175952 - 563699 == -387747)
			{
				base..ctor();
				if (144111 - 453383 == -309272)
				{
					this.AI_state = "none";
					if (56035 - 356562 != -300526)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x0085B3BC File Offset: 0x008595BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.g8rVftiHlg = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.EHhVLsjxi4 = (BisonCult)this.GetComponent(typeof(BisonCult));
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x0085B3F4 File Offset: 0x008595F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (296748 - 9388 != 287360)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (188680 - 340586 == -151905)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (216063 - 55604 != 160459)
				{
					continue;
				}
			}
			if (this.g8rVftiHlg.isControlled)
			{
				break;
			}
			if (274610 - 403487 != -128876)
			{
				this.AIControl();
				if (100937 - 40993 != 59945)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x0085B4C0 File Offset: 0x008596C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (167582 - 500971 != -333388)
		{
		}
		for (;;)
		{
			this.zehVUX651o = (float)0;
			if (27940 - 340101 != -312160)
			{
				if (this.g8rVftiHlg.isMine)
				{
					if (87694 - 534224 == -446530)
					{
						if (this.g8rVftiHlg.actionState != "standby")
						{
							if (61755 - 505831 != -444076)
							{
								continue;
							}
							if (this.g8rVftiHlg.actionState != "run")
							{
								if (32441 - 435095 != -402653)
								{
									break;
								}
								continue;
							}
						}
						if (!this.g8rVftiHlg.isAlert)
						{
							if (197320 - 475656 == -278336)
							{
								this.AI_idle(5f, 2f);
								if (62356 - 355963 != -293606)
								{
									this.AI_patrol(2f, 1f);
									if (135679 - 547527 == -411848)
									{
										this.AI_resetTimer();
										if (248114 - 366763 != -118648)
										{
											this.AI_visionCheck();
											if (202021 - 425970 == -223949)
											{
												if (!this.g8rVftiHlg.myAttackTarget)
												{
													break;
												}
												if (27346 - 363198 == -335852)
												{
													this.g8rVftiHlg.isAlert = true;
													if (140961 - 452360 == -311399)
													{
														this.pVxVwVQkNJ = Time.time;
														if (6282 - 128622 == -122340)
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
							if (156740 - 232996 == -76256)
							{
								this.AI_idle(2f, 1f);
								if (110312 - 522244 != -411931)
								{
									this.AI_attack(10f, (float)0);
									if (40258 - 253762 == -213504)
									{
										this.AI_resetTimer();
										if (179532 - 259088 != -79555)
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
					if (this.g8rVftiHlg.actionState != "standby")
					{
						if (147667 - 293493 == -145825)
						{
							continue;
						}
						if (this.g8rVftiHlg.actionState != "run")
						{
							if (122580 - 9591 != 112990)
							{
								break;
							}
							continue;
						}
					}
					float num = this.g8rVftiHlg.moveSpeed;
					if (44252 - 367384 == -323132)
					{
						float runSpeed = this.g8rVftiHlg.runSpeed;
						if (197185 - 348548 != -151362)
						{
							Vector3 vector = default(Vector3);
							if (97216 - 537216 != -439999)
							{
								Vector3 vector2 = Vector3.zero;
								if (5911 - 599739 == -593828)
								{
									if ((this.g8rVftiHlg.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (265611 - 441343 != -175732)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.g8rVftiHlg.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (299688 - 75016 == 224673)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (234111 - 539839 != -305728)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (26092 - 533816 != -507724)
											{
												continue;
											}
											num = (float)0;
											if (77150 - 278072 != -200922)
											{
												continue;
											}
											this.transform.position = this.g8rVftiHlg.nPosition;
											if (240338 - 79546 != 160792)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (154221 - 587319 == -433097)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (55804 - 293398 == -237593)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (131849 - 402524 == -270674)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (261020 - 427718 != -166698)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (86344 - 262667 != -176323)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (292211 - 452936 == -160724)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (202646 - 304020 == -101373)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (134725 - 432662 == -297936)
											{
												continue;
											}
										}
									}
									this.g8rVftiHlg.vMovement = vector2;
									if (28117 - 516692 == -488575)
									{
										this.g8rVftiHlg.moveSpeed = num;
										if (126785 - 319869 == -193084)
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

	// Token: 0x06004234 RID: 16948 RVA: 0x0085BB38 File Offset: 0x00859D38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (141895 - 355336 != -213441)
		{
		}
		do
		{
			if (Time.time - this.pVxVwVQkNJ >= this.zehVUX651o)
			{
				if (285571 - 92145 == 193427)
				{
					continue;
				}
				if (Time.time - this.pVxVwVQkNJ < this.zehVUX651o + mTime)
				{
					if (72076 - 415008 == -342931)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (242108 - 582093 == -339984)
						{
							continue;
						}
						this.AI_state = "idle";
						if (195364 - 382900 != -187536)
						{
							continue;
						}
						this.pVxVwVQkNJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (46013 - 114323 != -68310)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection = Vector3.zero;
						if (200319 - 344305 == -143985)
						{
							continue;
						}
						this.g8rVftiHlg.vMovement = this.transform.forward;
						if (113887 - 184097 != -70210)
						{
							continue;
						}
						this.g8rVftiHlg.actionState = "standby";
						if (250900 - 486609 != -235709)
						{
							continue;
						}
					}
					this.g8rVftiHlg.moveSpeed = Mathf.Lerp(this.g8rVftiHlg.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (135877 - 251397 != -115520)
					{
						continue;
					}
					if (this.g8rVftiHlg.moveSpeed < 0.1f * this.g8rVftiHlg.runSpeed)
					{
						if (94844 - 425718 == -330873)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (189873 - 327834 != -137961)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (192315 - 118828 == 73488)
						{
							continue;
						}
						this.g8rVftiHlg.moveSpeed = (float)0;
						if (256352 - 375851 != -119499)
						{
							continue;
						}
					}
				}
			}
			this.zehVUX651o += mTime;
		}
		while (135782 - 378507 == -242724);
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x0085BDFC File Offset: 0x00859FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (230729 - 347460 != -116730)
		{
		}
		do
		{
			if (Time.time - this.pVxVwVQkNJ >= this.zehVUX651o)
			{
				if (145130 - 382537 != -237407)
				{
					continue;
				}
				if (Time.time - this.pVxVwVQkNJ < this.zehVUX651o + mTime)
				{
					if (135848 - 477108 != -341260)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (123448 - 299839 != -176391)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (85979 - 365771 == -279791)
						{
							continue;
						}
						this.pVxVwVQkNJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (63148 - 333534 != -270386)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection = this.g8rVftiHlg.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (57871 - 67681 != -9810)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection.y = this.transform.position.y;
						if (218692 - 361391 != -142699)
						{
							continue;
						}
						this.g8rVftiHlg.vMovement = (this.g8rVftiHlg.vDirection - this.transform.position).normalized;
						if (201165 - 525893 != -324728)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.g8rVftiHlg.vMovement);
						if (147472 - 368980 != -221508)
						{
							continue;
						}
						this.g8rVftiHlg.actionState = "run";
						if (119586 - 387277 == -267690)
						{
							continue;
						}
						this.animation.Play("run");
						if (234527 - 566939 == -332411)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (103597 - 364146 != -260549)
						{
							continue;
						}
					}
					this.g8rVftiHlg.moveSpeed = Mathf.Lerp(this.g8rVftiHlg.moveSpeed, this.g8rVftiHlg.runSpeed, (float)4 * Time.deltaTime);
					if (232010 - 388202 == -156191)
					{
						continue;
					}
				}
			}
			this.zehVUX651o += mTime;
		}
		while (254200 - 450203 != -196003);
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x0085C104 File Offset: 0x0085A304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (262418 - 226924 != 35495)
		{
		}
		do
		{
			if (Time.time - this.pVxVwVQkNJ >= this.zehVUX651o)
			{
				if (83011 - 544073 == -461061)
				{
					continue;
				}
				if (Time.time - this.pVxVwVQkNJ < this.zehVUX651o + mTime)
				{
					if (209036 - 161183 == 47854)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (130627 - 512113 != -381486)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (259507 - 31779 != 227728)
						{
							continue;
						}
						this.pVxVwVQkNJ = Time.time - mTime - this.zehVUX651o;
						if (43741 - 247590 != -203849)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection = Vector3.zero;
						if (59069 - 323543 == -264473)
						{
							continue;
						}
						this.g8rVftiHlg.vMovement = this.transform.forward;
						if (47224 - 87698 != -40474)
						{
							continue;
						}
						this.g8rVftiHlg.actionState = "standby";
						if (202071 - 542198 != -340127)
						{
							continue;
						}
						this.g8rVftiHlg.myAttackTarget = this.g8rVftiHlg.getHateTarget(5, 50);
						if (136888 - 378703 != -241815)
						{
							continue;
						}
						if (!this.g8rVftiHlg.myAttackTarget)
						{
							if (47421 - 79564 != -32143)
							{
								continue;
							}
							this.g8rVftiHlg.isAlert = false;
							if (64015 - 388067 == -324051)
							{
								continue;
							}
							this.pVxVwVQkNJ = Time.time;
							if (63920 - 8916 == 55005)
							{
								continue;
							}
							this.g8rVftiHlg.myAttackTarget = null;
							if (134411 - 60228 == 74184)
							{
								continue;
							}
							this.g8rVftiHlg.mOriginalPosition = this.transform.position;
							if (214298 - 191639 != 22660)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.g8rVftiHlg.myAttackTarget;
							if (261870 - 362766 != -100896)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (185511 - 572012 != -386501)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (169169 - 232792 == -63622)
								{
									continue;
								}
								this.g8rVftiHlg.isAlert = false;
								if (274523 - 390211 != -115688)
								{
									continue;
								}
								this.pVxVwVQkNJ = Time.time;
								if (277077 - 43736 == 233342)
								{
									continue;
								}
								this.g8rVftiHlg.myAttackTarget = null;
								if (15880 - 232306 == -216425)
								{
									continue;
								}
							}
							else
							{
								this.g8rVftiHlg.vDirection = myAttackTarget.transform.position;
								if (59325 - 204076 == -144750)
								{
									continue;
								}
								this.g8rVftiHlg.vDirection.y = this.transform.position.y;
								if (41035 - 558587 != -517552)
								{
									continue;
								}
								this.g8rVftiHlg.vMovement = (this.g8rVftiHlg.vDirection - this.transform.position).normalized;
								if (5867 - 9931 == -4063)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.g8rVftiHlg.vMovement);
								if (156231 - 328472 == -172240)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.zehVUX651o += mTime;
		}
		while (265577 - 553860 == -288282);
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x0085C5B4 File Offset: 0x0085A7B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (294699 - 401235 != -106536)
		{
		}
		do
		{
			if (Time.time - this.pVxVwVQkNJ >= this.zehVUX651o)
			{
				if (201997 - 314177 != -112180)
				{
					continue;
				}
				if (Time.time - this.pVxVwVQkNJ < this.zehVUX651o + mTime)
				{
					if (172604 - 467753 != -295149)
					{
						continue;
					}
					if (!this.g8rVftiHlg.myAttackTarget)
					{
						if (220992 - 299443 == -78450)
						{
							continue;
						}
						this.pVxVwVQkNJ = Time.time - mTime - this.zehVUX651o;
						if (146035 - 231390 != -85354)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.g8rVftiHlg.myAttackTarget;
						if (226973 - 195646 == 31328)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (93054 - 577461 != -484407)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (121738 - 247607 == -125868)
						{
							continue;
						}
						if (173749 - 533095 != -359346)
						{
							continue;
						}
						if (characterControl)
						{
							if (111069 - 552544 != -441475)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (232119 - 379907 != -147788)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (294224 - 390958 == -96733)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (279909 - 315843 != -35934)
							{
								continue;
							}
							if (this.g8rVftiHlg.isTimeOut("slam") == (float)0)
							{
								if (105945 - 255180 == -149234)
								{
									continue;
								}
								this.pVxVwVQkNJ = Time.time - mTime - this.zehVUX651o;
								if (29129 - 7394 != 21735)
								{
									continue;
								}
								this.EHhVLsjxi4.StartCoroutine_Auto(this.EHhVLsjxi4.RPC_slam(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (123763 - 401895 != -278131)
								{
									if (PhotonClient.IsInitialized())
									{
										if (229532 - 169010 != 60522)
										{
											continue;
										}
										this.EHhVLsjxi4.ActionEvent("RPC_slam", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (44987 - 49684 == -4696)
										{
											continue;
										}
									}
									goto IL_145;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (135014 - 172841 != -37827)
							{
								continue;
							}
							if (this.g8rVftiHlg.isTimeOut("nAttack") == (float)0)
							{
								if (15735 - 480389 != -464654)
								{
									continue;
								}
								this.pVxVwVQkNJ = Time.time - mTime - this.zehVUX651o;
								if (18890 - 265387 == -246496)
								{
									continue;
								}
								this.EHhVLsjxi4.StartCoroutine_Auto(this.EHhVLsjxi4.RPC_nAttack(this.transform.position, vector, 0));
								if (134464 - 353025 != -218560)
								{
									if (PhotonClient.IsInitialized())
									{
										if (93363 - 484645 == -391281)
										{
											continue;
										}
										this.EHhVLsjxi4.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (261598 - 480273 != -218675)
										{
											continue;
										}
									}
									goto IL_145;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (192756 - 383014 == -190257)
							{
								continue;
							}
							if (this.g8rVftiHlg.sp >= 35)
							{
								if (20006 - 201633 == -181626)
								{
									continue;
								}
								if (this.g8rVftiHlg.isTimeOut("cAttack") == (float)0)
								{
									if (43951 - 375252 != -331301)
									{
										continue;
									}
									this.pVxVwVQkNJ = Time.time - mTime - this.zehVUX651o;
									if (152221 - 404843 != -252622)
									{
										continue;
									}
									this.EHhVLsjxi4.StartCoroutine_Auto(this.EHhVLsjxi4.RPC_cAttack(this.transform.position, vector, 0));
									if (269374 - 187001 != 82373)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (63407 - 143166 == -79758)
										{
											continue;
										}
										this.EHhVLsjxi4.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (292277 - 44085 == 248193)
										{
											continue;
										}
									}
									goto IL_145;
								}
							}
						}
						this.AI_state = "attack";
						if (151924 - 148620 != 3304)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection = myAttackTarget.transform.position;
						if (16276 - 409595 == -393318)
						{
							continue;
						}
						this.g8rVftiHlg.vDirection.y = this.transform.position.y;
						if (115957 - 271009 != -155052)
						{
							continue;
						}
						this.g8rVftiHlg.vMovement = (this.g8rVftiHlg.vDirection - this.transform.position).normalized;
						if (256404 - 83832 != 172572)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.g8rVftiHlg.vMovement);
						if (274450 - 194427 == 80024)
						{
							continue;
						}
						this.g8rVftiHlg.actionState = "run";
						if (137351 - 24130 == 113222)
						{
							continue;
						}
						this.animation.Play("run");
						if (15145 - 523368 != -508223)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (295942 - 350280 != -54338)
						{
							continue;
						}
						this.g8rVftiHlg.moveSpeed = Mathf.Lerp(this.g8rVftiHlg.moveSpeed, this.g8rVftiHlg.runSpeed, (float)4 * Time.deltaTime);
						if (137546 - 460215 == -322668)
						{
							continue;
						}
					}
				}
			}
			IL_145:
			this.zehVUX651o += mTime;
		}
		while (162346 - 11577 != 150769);
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x0085CDB0 File Offset: 0x0085AFB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (80909 - 227231 != -146322)
		{
		}
		while (Time.time - this.pVxVwVQkNJ > this.zehVUX651o)
		{
			if (93365 - 219684 != -126318)
			{
				this.AI_state = "none";
				if (195612 - 428091 == -232479)
				{
					this.pVxVwVQkNJ = Time.time;
					if (182672 - 216611 != -33938)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x0085CE64 File Offset: 0x0085B064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (117579 - 520842 != -403262)
		{
		}
		for (;;)
		{
			IL_75B:
			if (this.TqbVN0fyT3 > Time.time)
			{
				if (8180 - 483343 == -475163)
				{
					break;
				}
			}
			else
			{
				this.TqbVN0fyT3 = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (160361 - 209092 == -48731)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (100528 - 242745 != -142216)
					{
						if (269546 - 572985 == -303439)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (33977 - 526226 != -492248)
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
									if (11477 - 540475 != -528998)
									{
										goto IL_75B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (206185 - 593653 == -387467)
									{
										goto IL_75B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (39658 - 1520 != 38138)
									{
										goto IL_75B;
									}
									bool flag = true;
									if (210268 - 109225 != 101043)
									{
										goto IL_75B;
									}
									eRace race = this.g8rVftiHlg.Race;
									if (257326 - 15699 == 241628)
									{
										goto IL_75B;
									}
									if (race == eRace.Tails)
									{
										if (26641 - 232176 != -205535)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_71B;
										}
										if (248384 - 62777 != 185607)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (270841 - 354392 != -83550)
											{
												goto IL_71B;
											}
											goto IL_75B;
										}
										goto IL_15C;
										IL_71B:
										flag = false;
										if (17286 - 60551 != -43265)
										{
											goto IL_75B;
										}
									}
									else if (race == eRace.Plants)
									{
										if (49074 - 88868 == -39793)
										{
											goto IL_75B;
										}
										flag = false;
										if (64723 - 66016 != -1293)
										{
											goto IL_75B;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (282310 - 41840 == 240471)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_529;
										}
										if (201818 - 230166 == -28347)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (292094 - 550165 != -258071)
											{
												goto IL_75B;
											}
											goto IL_529;
										}
										goto IL_15C;
										IL_529:
										flag = false;
										if (93811 - 408695 == -314883)
										{
											goto IL_75B;
										}
									}
									else if (race == eRace.Robots)
									{
										if (124505 - 191868 != -67363)
										{
											goto IL_75B;
										}
										flag = true;
										if (222912 - 78177 != 144735)
										{
											goto IL_75B;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (214481 - 429440 != -214959)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5B8;
										}
										if (195706 - 75685 == 120022)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5B8;
										}
										if (162227 - 99617 == 62611)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (107477 - 397751 != -290273)
											{
												goto IL_5B8;
											}
											goto IL_75B;
										}
										goto IL_15C;
										IL_5B8:
										flag = false;
										if (97179 - 441362 != -344183)
										{
											goto IL_75B;
										}
									}
									else if (race == eRace.Structure)
									{
										if (154216 - 432562 != -278346)
										{
											goto IL_75B;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (10615 - 156984 != -146369)
											{
												goto IL_75B;
											}
											flag = false;
											if (145109 - 27457 != 117652)
											{
												goto IL_75B;
											}
										}
									}
									IL_15C:
									if (flag)
									{
										if (184471 - 287711 != -103240)
										{
											goto IL_75B;
										}
										if (characterControl.hp > 0)
										{
											if (271369 - 95316 != 176053)
											{
												goto IL_75B;
											}
											if (characterControl.recieveTarget)
											{
												if (52112 - 168267 == -116154)
												{
													goto IL_75B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (84995 - 388507 == -303511)
													{
														goto IL_75B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (249235 - 378056 != -128821)
														{
															goto IL_75B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (225363 - 238237 == -12873)
														{
															goto IL_75B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (45405 - 367250 != -321845)
															{
																goto IL_75B;
															}
															this.g8rVftiHlg.myAttackTarget = gameObject;
															if (224885 - 259626 != -34741)
															{
																goto IL_75B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (136723 - 594021 == -457297)
															{
																goto IL_75B;
															}
															this.g8rVftiHlg.addHate(characterControl.ActorNr, 5);
															if (89854 - 235426 != -145572)
															{
																goto IL_75B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (161391 - 404280 == -242888)
															{
																goto IL_75B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (224136 - 575301 == -351164)
															{
																goto IL_75B;
															}
															if (num < (float)60)
															{
																if (140883 - 518955 != -378072)
																{
																	goto IL_75B;
																}
																if (characterControl.hp > 0)
																{
																	if (60434 - 320541 != -260107)
																	{
																		goto IL_75B;
																	}
																	this.g8rVftiHlg.myAttackTarget = gameObject;
																	if (285728 - 188889 == 96840)
																	{
																		goto IL_75B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (288791 - 347257 != -58466)
																	{
																		goto IL_75B;
																	}
																	this.g8rVftiHlg.addHate(characterControl.ActorNr, 5);
																	if (154788 - 34613 == 120176)
																	{
																		goto IL_75B;
																	}
																}
															}
														}
														if (this.g8rVftiHlg.myAttackTarget)
														{
															if (126771 - 206820 != -80049)
															{
																goto IL_75B;
															}
															this.g8rVftiHlg.isAlert = true;
															if (207167 - 415109 == -207941)
															{
																goto IL_75B;
															}
															this.pVxVwVQkNJ = Time.time;
															if (243575 - 143733 == 99843)
															{
																goto IL_75B;
															}
														}
													}
												}
											}
										}
									}
								}
								if (271348 - 542302 != -270953)
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

	// Token: 0x0600423A RID: 16954 RVA: 0x0085D67C File Offset: 0x0085B87C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x0085D680 File Offset: 0x0085B880
	internal static bool w6AxV55gby5WC8s6MrCX()
	{
		return true;
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x0085D684 File Offset: 0x0085B884
	internal static bool M9AkLk5gusLgckNx9tGS()
	{
		return false;
	}

	// Token: 0x04004E29 RID: 20009
	private CharacterControl g8rVftiHlg;

	// Token: 0x04004E2A RID: 20010
	private BisonCult EHhVLsjxi4;

	// Token: 0x04004E2B RID: 20011
	public string AI_state;

	// Token: 0x04004E2C RID: 20012
	private float pVxVwVQkNJ;

	// Token: 0x04004E2D RID: 20013
	private float zehVUX651o;

	// Token: 0x04004E2E RID: 20014
	private float TqbVN0fyT3;
}
