using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C55 RID: 3157
[Serializable]
public class Hippo_AI : MonoBehaviour
{
	// Token: 0x0600469C RID: 18076 RVA: 0x008D08B0 File Offset: 0x008CEAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hippo_AI()
	{
		if (203560 - 573909 != -370349)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (208805 - 439864 == -231059)
			{
				base..ctor();
				if (50702 - 548733 == -498031)
				{
					this.AI_state = "none";
					if (146983 - 278196 != -131212)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x008D094C File Offset: 0x008CEB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.awZKxIt6AL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.TvVKT2hNmO = (Hippo)this.GetComponent(typeof(Hippo));
	}

	// Token: 0x0600469E RID: 18078 RVA: 0x008D0984 File Offset: 0x008CEB84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (95081 - 182811 != -87729)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (47674 - 259099 != -211425)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (262570 - 442062 != -179492)
				{
					continue;
				}
			}
			if (this.awZKxIt6AL.isControlled)
			{
				break;
			}
			if (144261 - 526946 == -382685)
			{
				this.AIControl();
				if (292622 - 188714 == 103908)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x008D0A50 File Offset: 0x008CEC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (121165 - 116521 != 4645)
		{
		}
		for (;;)
		{
			this.KImK3i1BNL = (float)0;
			if (278978 - 408077 != -129098)
			{
				if (this.awZKxIt6AL.isMine)
				{
					if (278580 - 293328 != -14747)
					{
						if (this.awZKxIt6AL.actionState != "standby")
						{
							if (84822 - 234182 == -149359)
							{
								continue;
							}
							if (this.awZKxIt6AL.actionState != "run")
							{
								if (178441 - 522805 != -344363)
								{
									break;
								}
								continue;
							}
						}
						if (!this.awZKxIt6AL.isAlert)
						{
							if (183309 - 103328 == 79981)
							{
								if (this.awZKxIt6AL.isSummon)
								{
									if (245497 - 97379 == 148119)
									{
										continue;
									}
									if (this.awZKxIt6AL.mSummoner != null)
									{
										if (280985 - 494933 != -213948)
										{
											continue;
										}
										Vector3 vector = this.awZKxIt6AL.mSummoner.transform.position - this.transform.position;
										if (134053 - 409982 != -275929)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (44387 - 275384 == -230996)
											{
												continue;
											}
											this.AI_follow(this.awZKxIt6AL.mSummoner);
											if (24141 - 122029 != -97888)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(5f, 2f);
											if (285061 - 95506 != 189555)
											{
												continue;
											}
											this.AI_resetTimer();
											if (247903 - 88975 != 158928)
											{
												continue;
											}
											this.AI_visionCheck();
											if (195534 - 105966 != 89568)
											{
												continue;
											}
										}
										goto IL_358;
									}
								}
								this.AI_idle(5f, 2f);
								if (240953 - 420875 != -179922)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (62675 - 39411 == 23265)
								{
									continue;
								}
								this.AI_resetTimer();
								if (16580 - 540362 == -523781)
								{
									continue;
								}
								this.AI_visionCheck();
								if (214024 - 322602 == -108577)
								{
									continue;
								}
								IL_358:
								if (!this.awZKxIt6AL.myAttackTarget)
								{
									break;
								}
								if (136790 - 489438 != -352647)
								{
									this.awZKxIt6AL.isAlert = true;
									if (234814 - 259546 != -24731)
									{
										this.PUjKY5VHSr = Time.time;
										if (160181 - 151826 != 8356)
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
							if (44022 - 105066 == -61044)
							{
								this.AI_idle(5f, 2f);
								if (18776 - 421704 != -402927)
								{
									this.AI_attack(10f, (float)0);
									if (161004 - 429943 != -268938)
									{
										this.AI_resetTimer();
										if (151128 - 52282 != 98847)
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
					if (this.awZKxIt6AL.actionState != "standby")
					{
						if (153947 - 414342 == -260394)
						{
							continue;
						}
						if (this.awZKxIt6AL.actionState != "run")
						{
							if (263973 - 337768 != -73795)
							{
								continue;
							}
							break;
						}
					}
					float num = this.awZKxIt6AL.moveSpeed;
					if (246051 - 149810 != 96242)
					{
						float runSpeed = this.awZKxIt6AL.runSpeed;
						if (127020 - 28096 != 98925)
						{
							Vector3 vector2 = default(Vector3);
							if (116647 - 108176 != 8472)
							{
								Vector3 vector3 = Vector3.zero;
								if (207916 - 366639 == -158723)
								{
									if ((this.awZKxIt6AL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (117020 - 330061 != -213041)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.awZKxIt6AL.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (207912 - 37095 == 170818)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (120558 - 335785 == -215226)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (192916 - 453830 == -260913)
											{
												continue;
											}
											num = (float)0;
											if (272986 - 427822 == -154835)
											{
												continue;
											}
											this.transform.position = this.awZKxIt6AL.nPosition;
											if (164475 - 570936 == -406460)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (165354 - 491318 == -325963)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (8820 - 211292 != -202472)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (264341 - 488157 != -223816)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (243119 - 441512 != -198393)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (193893 - 506378 == -312484)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (233790 - 463442 == -229651)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (175034 - 190829 == -15794)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233062 - 426321 == -193258)
											{
												continue;
											}
										}
									}
									this.awZKxIt6AL.vMovement = vector3;
									if (144946 - 424428 == -279482)
									{
										this.awZKxIt6AL.moveSpeed = num;
										if (87495 - 414654 != -327158)
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

	// Token: 0x060046A0 RID: 18080 RVA: 0x008D122C File Offset: 0x008CF42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (174155 - 493763 != -319608)
		{
		}
		do
		{
			if (Time.time - this.PUjKY5VHSr >= this.KImK3i1BNL)
			{
				if (159067 - 578064 == -418996)
				{
					continue;
				}
				if (Time.time - this.PUjKY5VHSr < this.KImK3i1BNL + mTime)
				{
					if (81020 - 88983 == -7962)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (63518 - 250190 != -186672)
						{
							continue;
						}
						this.AI_state = "idle";
						if (181105 - 116659 != 64446)
						{
							continue;
						}
						this.PUjKY5VHSr -= UnityEngine.Random.Range((float)0, rTimer);
						if (127937 - 408453 != -280516)
						{
							continue;
						}
						this.awZKxIt6AL.vDirection = Vector3.zero;
						if (230262 - 477932 != -247670)
						{
							continue;
						}
						this.awZKxIt6AL.vMovement = this.transform.forward;
						if (49340 - 7190 == 42151)
						{
							continue;
						}
						this.awZKxIt6AL.actionState = "standby";
						if (291135 - 18630 != 272505)
						{
							continue;
						}
					}
					this.awZKxIt6AL.moveSpeed = Mathf.Lerp(this.awZKxIt6AL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (42767 - 393385 != -350618)
					{
						continue;
					}
					if (this.awZKxIt6AL.moveSpeed < 0.1f * this.awZKxIt6AL.runSpeed)
					{
						if (63351 - 538429 == -475077)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (155761 - 470110 != -314349)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (177652 - 166153 != 11499)
						{
							continue;
						}
						this.awZKxIt6AL.moveSpeed = (float)0;
						if (100205 - 15694 == 84512)
						{
							continue;
						}
					}
				}
			}
			this.KImK3i1BNL += mTime;
		}
		while (256089 - 365822 == -109732);
	}

	// Token: 0x060046A1 RID: 18081 RVA: 0x008D14F0 File Offset: 0x008CF6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (42628 - 116578 != -73950)
		{
		}
		for (;;)
		{
			this.awZKxIt6AL.vDirection = followObject.transform.position;
			if (131284 - 204757 != -73472)
			{
				this.awZKxIt6AL.vDirection.y = this.transform.position.y;
				if (180026 - 493241 == -313215)
				{
					this.awZKxIt6AL.vMovement = (this.awZKxIt6AL.vDirection - this.transform.position).normalized;
					if (99972 - 129725 != -29752)
					{
						this.transform.rotation = Quaternion.LookRotation(this.awZKxIt6AL.vMovement);
						if (211727 - 359631 != -147903)
						{
							this.awZKxIt6AL.actionState = "run";
							if (133454 - 376134 != -242679)
							{
								this.animation.Play("run");
								if (73668 - 157483 == -83815)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (130061 - 433896 != -303834)
									{
										this.awZKxIt6AL.moveSpeed = Mathf.Lerp(this.awZKxIt6AL.moveSpeed, this.awZKxIt6AL.runSpeed, (float)4 * Time.deltaTime);
										if (104162 - 497130 != -392967)
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

	// Token: 0x060046A2 RID: 18082 RVA: 0x008D16D8 File Offset: 0x008CF8D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (174755 - 405567 != -230811)
		{
		}
		do
		{
			if (Time.time - this.PUjKY5VHSr >= this.KImK3i1BNL)
			{
				if (136086 - 526378 == -390291)
				{
					continue;
				}
				if (Time.time - this.PUjKY5VHSr < this.KImK3i1BNL + mTime)
				{
					if (214745 - 465092 == -250346)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (174937 - 519559 != -344622)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (23875 - 443119 != -419244)
						{
							continue;
						}
						this.PUjKY5VHSr -= UnityEngine.Random.Range((float)0, rTimer);
						if (28912 - 564158 == -535245)
						{
							continue;
						}
						this.awZKxIt6AL.vDirection = this.awZKxIt6AL.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (93426 - 128495 != -35069)
						{
							continue;
						}
						this.awZKxIt6AL.vDirection.y = this.transform.position.y;
						if (115757 - 543307 == -427549)
						{
							continue;
						}
						this.awZKxIt6AL.vMovement = (this.awZKxIt6AL.vDirection - this.transform.position).normalized;
						if (196311 - 582063 == -385751)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.awZKxIt6AL.vMovement);
						if (7110 - 317504 == -310393)
						{
							continue;
						}
						this.awZKxIt6AL.actionState = "run";
						if (6544 - 319061 != -312517)
						{
							continue;
						}
						this.animation.Play("run");
						if (43389 - 332110 != -288721)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (51014 - 141650 == -90635)
						{
							continue;
						}
					}
					this.awZKxIt6AL.moveSpeed = Mathf.Lerp(this.awZKxIt6AL.moveSpeed, this.awZKxIt6AL.runSpeed, (float)4 * Time.deltaTime);
					if (262513 - 321115 == -58601)
					{
						continue;
					}
				}
			}
			this.KImK3i1BNL += mTime;
		}
		while (53541 - 511164 != -457623);
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x008D19E0 File Offset: 0x008CFBE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (45357 - 462382 != -417025)
		{
		}
		do
		{
			if (Time.time - this.PUjKY5VHSr >= this.KImK3i1BNL)
			{
				if (63441 - 418904 == -355462)
				{
					continue;
				}
				if (Time.time - this.PUjKY5VHSr < this.KImK3i1BNL + mTime)
				{
					if (211095 - 362669 == -151573)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (48568 - 322393 != -273825)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (91287 - 552957 != -461670)
						{
							continue;
						}
						this.PUjKY5VHSr = Time.time - mTime - this.KImK3i1BNL;
						if (112809 - 68296 == 44514)
						{
							continue;
						}
						this.awZKxIt6AL.vDirection = Vector3.zero;
						if (266559 - 372060 != -105501)
						{
							continue;
						}
						this.awZKxIt6AL.vMovement = this.transform.forward;
						if (111312 - 23755 != 87557)
						{
							continue;
						}
						this.awZKxIt6AL.actionState = "standby";
						if (60970 - 333943 == -272972)
						{
							continue;
						}
						this.awZKxIt6AL.myAttackTarget = this.awZKxIt6AL.getHateTarget(5, 50);
						if (60376 - 146003 != -85627)
						{
							continue;
						}
						if (!this.awZKxIt6AL.myAttackTarget)
						{
							if (276586 - 568806 == -292219)
							{
								continue;
							}
							this.awZKxIt6AL.isAlert = false;
							if (130536 - 397823 != -267287)
							{
								continue;
							}
							this.PUjKY5VHSr = Time.time;
							if (221675 - 569994 != -348319)
							{
								continue;
							}
							this.awZKxIt6AL.myAttackTarget = null;
							if (272515 - 64361 != 208154)
							{
								continue;
							}
							this.awZKxIt6AL.mOriginalPosition = this.transform.position;
							if (99370 - 531457 != -432086)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.awZKxIt6AL.myAttackTarget;
							if (46107 - 105058 == -58950)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (16275 - 545513 != -529238)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (88388 - 218597 == -130208)
								{
									continue;
								}
								this.awZKxIt6AL.isAlert = false;
								if (68345 - 52271 != 16074)
								{
									continue;
								}
								this.PUjKY5VHSr = Time.time;
								if (126200 - 458083 == -331882)
								{
									continue;
								}
								this.awZKxIt6AL.myAttackTarget = null;
								if (168033 - 232779 != -64746)
								{
									continue;
								}
							}
							else
							{
								this.awZKxIt6AL.vDirection = myAttackTarget.transform.position;
								if (289687 - 237698 == 51990)
								{
									continue;
								}
								this.awZKxIt6AL.vDirection.y = this.transform.position.y;
								if (60767 - 218820 != -158053)
								{
									continue;
								}
								this.awZKxIt6AL.vMovement = (this.awZKxIt6AL.vDirection - this.transform.position).normalized;
								if (211075 - 187533 == 23543)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.awZKxIt6AL.vMovement);
								if (11286 - 179784 != -168498)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.KImK3i1BNL += mTime;
		}
		while (189931 - 391921 == -201989);
	}

	// Token: 0x060046A4 RID: 18084 RVA: 0x008D1E90 File Offset: 0x008D0090
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (25797 - 453047 != -427249)
		{
		}
		do
		{
			if (Time.time - this.PUjKY5VHSr >= this.KImK3i1BNL)
			{
				if (297988 - 574659 != -276671)
				{
					continue;
				}
				if (Time.time - this.PUjKY5VHSr < this.KImK3i1BNL + mTime)
				{
					if (188666 - 61097 == 127570)
					{
						continue;
					}
					if (!this.awZKxIt6AL.myAttackTarget)
					{
						if (148366 - 95977 == 52390)
						{
							continue;
						}
						this.PUjKY5VHSr = Time.time - mTime - this.KImK3i1BNL;
						if (108387 - 589863 != -481476)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.awZKxIt6AL.myAttackTarget;
						if (288403 - 165346 == 123058)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (283700 - 495636 != -211936)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (31608 - 194034 != -162426)
						{
							continue;
						}
						if (34796 - 451025 == -416228)
						{
							continue;
						}
						if (characterControl)
						{
							if (8710 - 339767 != -331057)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (126 - 263593 == -263466)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (123583 - 424752 == -301168)
						{
							continue;
						}
						if ((float)this.awZKxIt6AL.hp < 0.8f * (float)this.awZKxIt6AL.mhp)
						{
							if (225965 - 2363 == 223603)
							{
								continue;
							}
							if (num < (float)5)
							{
								if (161842 - 518782 == -356939)
								{
									continue;
								}
								if (this.awZKxIt6AL.isTimeOut("cAttack") == (float)0)
								{
									if (163329 - 507896 != -344567)
									{
										continue;
									}
									this.PUjKY5VHSr = Time.time - mTime - this.KImK3i1BNL;
									if (147525 - 20030 != 127495)
									{
										continue;
									}
									this.TvVKT2hNmO.StartCoroutine_Auto(this.TvVKT2hNmO.RPC_cAttack(this.transform.position, vector.normalized, 0));
									if (65440 - 192053 != -126612)
									{
										if (PhotonClient.IsInitialized())
										{
											if (141183 - 569307 == -428123)
											{
												continue;
											}
											this.TvVKT2hNmO.ActionEvent("RPC_cAttack", this.transform.position, vector.normalized, 0);
											if (155337 - 106675 == 48663)
											{
												continue;
											}
										}
										goto IL_6E3;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (52553 - 510761 != -458208)
							{
								continue;
							}
							if (this.awZKxIt6AL.isTimeOut("nAttack") == (float)0)
							{
								if (156238 - 250513 != -94275)
								{
									continue;
								}
								this.PUjKY5VHSr = Time.time - mTime - this.KImK3i1BNL;
								if (41770 - 117692 != -75922)
								{
									continue;
								}
								this.TvVKT2hNmO.StartCoroutine_Auto(this.TvVKT2hNmO.RPC_nAttack(this.transform.position, vector.normalized, 0));
								if (43143 - 77626 != -34482)
								{
									if (PhotonClient.IsInitialized())
									{
										if (288464 - 200135 != 88329)
										{
											continue;
										}
										this.TvVKT2hNmO.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, 0);
										if (8986 - 414266 != -405280)
										{
											continue;
										}
									}
									goto IL_6E3;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (147318 - 81055 != 66263)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (168658 - 153929 != 14729)
							{
								continue;
							}
							this.awZKxIt6AL.vDirection = myAttackTarget.transform.position;
							if (38048 - 483049 != -445001)
							{
								continue;
							}
							this.awZKxIt6AL.vDirection.y = this.transform.position.y;
							if (43963 - 435045 != -391082)
							{
								continue;
							}
							this.awZKxIt6AL.vMovement = (this.awZKxIt6AL.vDirection - this.transform.position).normalized;
							if (234065 - 593028 != -358963)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.awZKxIt6AL.vMovement);
							if (181270 - 447601 != -266331)
							{
								continue;
							}
							this.awZKxIt6AL.actionState = "run";
							if (254820 - 140408 == 114413)
							{
								continue;
							}
							this.animation.Play("run");
							if (261443 - 349122 == -87678)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (91144 - 211646 != -120502)
							{
								continue;
							}
							this.awZKxIt6AL.moveSpeed = Mathf.Lerp(this.awZKxIt6AL.moveSpeed, this.awZKxIt6AL.runSpeed, (float)4 * Time.deltaTime);
							if (41559 - 207752 == -166192)
							{
								continue;
							}
						}
						else
						{
							this.awZKxIt6AL.vDirection = myAttackTarget.transform.position;
							if (293325 - 259102 == 34224)
							{
								continue;
							}
							this.awZKxIt6AL.vDirection.y = this.transform.position.y;
							if (229181 - 204431 == 24751)
							{
								continue;
							}
							this.awZKxIt6AL.vMovement = (this.awZKxIt6AL.vDirection - this.transform.position).normalized;
							if (275037 - 382206 == -107168)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.awZKxIt6AL.vMovement);
							if (169344 - 554501 == -385156)
							{
								continue;
							}
							this.awZKxIt6AL.actionState = "standby";
							if (75448 - 522113 != -446665)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (216697 - 578545 != -361848)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (155132 - 260491 == -105358)
							{
								continue;
							}
							this.awZKxIt6AL.moveSpeed = Mathf.Lerp(this.awZKxIt6AL.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (242932 - 152668 == 90265)
							{
								continue;
							}
						}
					}
				}
			}
			IL_6E3:
			this.KImK3i1BNL += mTime;
		}
		while (79719 - 525923 == -446203);
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x008D2720 File Offset: 0x008D0920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (227869 - 60122 != 167747)
		{
		}
		while (Time.time - this.PUjKY5VHSr > this.KImK3i1BNL)
		{
			if (138432 - 83587 == 54845)
			{
				this.AI_state = "none";
				if (200632 - 514999 != -314366)
				{
					this.PUjKY5VHSr = Time.time;
					if (72893 - 114476 == -41583)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x008D27D4 File Offset: 0x008D09D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (5424 - 109876 != -104451)
		{
		}
		for (;;)
		{
			IL_498:
			if (this.kLFKbH2CLl > Time.time)
			{
				if (209936 - 417090 == -207154)
				{
					break;
				}
			}
			else
			{
				this.kLFKbH2CLl = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (268398 - 292440 == -24042)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (57102 - 337866 != -280763)
					{
						if (172251 - 268552 == -96301)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (167217 - 587056 == -419839)
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
									if (179669 - 366587 == -186917)
									{
										goto IL_498;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (57823 - 83572 != -25749)
									{
										goto IL_498;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (69784 - 422616 != -352832)
									{
										goto IL_498;
									}
									bool flag = true;
									if (251658 - 323217 != -71559)
									{
										goto IL_498;
									}
									eRace race = this.awZKxIt6AL.Race;
									if (291143 - 496258 != -205115)
									{
										goto IL_498;
									}
									if (race == eRace.Tails)
									{
										if (169897 - 528537 == -358639)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_9B;
										}
										if (55690 - 243870 != -188180)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (32699 - 60147 != -27448)
											{
												goto IL_498;
											}
											goto IL_9B;
										}
										goto IL_724;
										IL_9B:
										flag = false;
										if (267584 - 465202 == -197617)
										{
											goto IL_498;
										}
									}
									else if (race == eRace.Plants)
									{
										if (188549 - 568978 != -380429)
										{
											goto IL_498;
										}
										flag = false;
										if (184035 - 52604 != 131431)
										{
											goto IL_498;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (184492 - 214453 != -29961)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_52A;
										}
										if (87499 - 379517 != -292018)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (56255 - 108746 != -52491)
											{
												goto IL_498;
											}
											goto IL_52A;
										}
										goto IL_724;
										IL_52A:
										flag = false;
										if (69853 - 7231 != 62622)
										{
											goto IL_498;
										}
									}
									else if (race == eRace.Robots)
									{
										if (146487 - 361912 == -215424)
										{
											goto IL_498;
										}
										flag = true;
										if (212092 - 484166 == -272073)
										{
											goto IL_498;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (159951 - 521401 == -361449)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_47C;
										}
										if (298390 - 356552 != -58162)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_47C;
										}
										if (285212 - 37034 != 248178)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (108299 - 380028 != -271729)
											{
												goto IL_498;
											}
											goto IL_47C;
										}
										goto IL_724;
										IL_47C:
										flag = false;
										if (217429 - 428284 != -210855)
										{
											goto IL_498;
										}
									}
									else if (race == eRace.Structure)
									{
										if (127036 - 311086 == -184049)
										{
											goto IL_498;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (209669 - 534914 != -325245)
											{
												goto IL_498;
											}
											flag = false;
											if (86956 - 409775 != -322819)
											{
												goto IL_498;
											}
										}
									}
									IL_724:
									if (flag)
									{
										if (17652 - 512732 != -495080)
										{
											goto IL_498;
										}
										if (characterControl.hp > 0)
										{
											if (157953 - 24266 != 133687)
											{
												goto IL_498;
											}
											if (characterControl.recieveTarget)
											{
												if (289718 - 137822 != 151896)
												{
													goto IL_498;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (289826 - 484146 != -194320)
													{
														goto IL_498;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (78546 - 133918 != -55372)
														{
															goto IL_498;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (179950 - 559170 == -379219)
														{
															goto IL_498;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (233971 - 94118 != 139853)
															{
																goto IL_498;
															}
															this.awZKxIt6AL.myAttackTarget = gameObject;
															if (250139 - 105677 == 144463)
															{
																goto IL_498;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (135688 - 133351 == 2338)
															{
																goto IL_498;
															}
															this.awZKxIt6AL.addHate(characterControl.ActorNr, 5);
															if (265045 - 516878 != -251833)
															{
																goto IL_498;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (183976 - 71755 != 112221)
															{
																goto IL_498;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (295930 - 342668 != -46738)
															{
																goto IL_498;
															}
															if (num < (float)60)
															{
																if (200381 - 257959 == -57577)
																{
																	goto IL_498;
																}
																if (characterControl.hp > 0)
																{
																	if (63930 - 253417 == -189486)
																	{
																		goto IL_498;
																	}
																	this.awZKxIt6AL.myAttackTarget = gameObject;
																	if (168678 - 503933 != -335255)
																	{
																		goto IL_498;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (233262 - 473489 == -240226)
																	{
																		goto IL_498;
																	}
																	this.awZKxIt6AL.addHate(characterControl.ActorNr, 5);
																	if (64837 - 357643 == -292805)
																	{
																		goto IL_498;
																	}
																}
															}
														}
														if (this.awZKxIt6AL.myAttackTarget)
														{
															if (45300 - 336273 == -290972)
															{
																goto IL_498;
															}
															this.awZKxIt6AL.isAlert = true;
															if (238320 - 406893 != -168573)
															{
																goto IL_498;
															}
															this.PUjKY5VHSr = Time.time;
															if (115148 - 164922 != -49774)
															{
																goto IL_498;
															}
														}
													}
												}
											}
										}
									}
								}
								if (173382 - 532159 != -358776)
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

	// Token: 0x060046A7 RID: 18087 RVA: 0x008D2FEC File Offset: 0x008D11EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060046A8 RID: 18088 RVA: 0x008D2FF0 File Offset: 0x008D11F0
	internal static bool lL4nV25dIFYrUeIrPQAD()
	{
		return true;
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x008D2FF4 File Offset: 0x008D11F4
	internal static bool lcAuaZ5dBnnxZe81kFuC()
	{
		return false;
	}

	// Token: 0x04005216 RID: 21014
	private CharacterControl awZKxIt6AL;

	// Token: 0x04005217 RID: 21015
	private Hippo TvVKT2hNmO;

	// Token: 0x04005218 RID: 21016
	public string AI_state;

	// Token: 0x04005219 RID: 21017
	private float PUjKY5VHSr;

	// Token: 0x0400521A RID: 21018
	private float KImK3i1BNL;

	// Token: 0x0400521B RID: 21019
	private float kLFKbH2CLl;
}
