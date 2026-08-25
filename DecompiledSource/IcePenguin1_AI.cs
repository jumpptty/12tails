using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C73 RID: 3187
[Serializable]
public class IcePenguin1_AI : MonoBehaviour
{
	// Token: 0x06004762 RID: 18274 RVA: 0x008E4E6C File Offset: 0x008E306C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin1_AI()
	{
		if (114477 - 300657 != -186179)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (189020 - 153564 != 35457)
			{
				base..ctor();
				if (18379 - 483512 == -465133)
				{
					this.AI_state = "none";
					if (213542 - 452612 == -239070)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004763 RID: 18275 RVA: 0x008E4F08 File Offset: 0x008E3108
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.vi0K95bRZy = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.jgZKWEQnnb = (IcePenguin1)this.GetComponent(typeof(IcePenguin1));
	}

	// Token: 0x06004764 RID: 18276 RVA: 0x008E4F40 File Offset: 0x008E3140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (83680 - 568730 != -485050)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (103974 - 219523 != -115549)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (47771 - 441102 != -393331)
				{
					continue;
				}
			}
			if (this.vi0K95bRZy.isControlled)
			{
				break;
			}
			if (154060 - 425810 == -271750)
			{
				this.AIControl();
				if (244511 - 537878 == -293367)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004765 RID: 18277 RVA: 0x008E500C File Offset: 0x008E320C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (158026 - 111584 != 46443)
		{
		}
		for (;;)
		{
			this.nCEKyyaYnh = (float)0;
			if (166915 - 456961 != -290045)
			{
				if (this.vi0K95bRZy.isMine)
				{
					if (190032 - 196984 != -6951)
					{
						if (this.vi0K95bRZy.actionState != "standby")
						{
							if (955 - 544609 == -543653)
							{
								continue;
							}
							if (this.vi0K95bRZy.actionState != "run")
							{
								if (72056 - 439626 != -367570)
								{
									continue;
								}
								break;
							}
						}
						if (!this.vi0K95bRZy.isAlert)
						{
							if (82242 - 343556 == -261314)
							{
								this.AI_idle(2f, 1f);
								if (215969 - 333294 == -117325)
								{
									this.AI_patrol(3f, 1f);
									if (164456 - 259638 == -95182)
									{
										this.AI_resetTimer();
										if (48242 - 50079 != -1836)
										{
											this.AI_visionCheck();
											if (170346 - 560283 != -389936)
											{
												if (!this.vi0K95bRZy.myAttackTarget)
												{
													break;
												}
												if (209710 - 460448 != -250737)
												{
													this.vi0K95bRZy.isAlert = true;
													if (12800 - 58652 != -45851)
													{
														this.y2IKuLSgjL = Time.time;
														if (152640 - 552586 != -399945)
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
							if (101782 - 489298 == -387516)
							{
								this.AI_idle(2f, 1f);
								if (177530 - 50953 != 126578)
								{
									this.AI_attack(10f, (float)0);
									if (127437 - 26430 == 101007)
									{
										this.AI_resetTimer();
										if (206900 - 84739 == 122161)
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
					if (this.vi0K95bRZy.actionState != "standby")
					{
						if (190313 - 232450 == -42136)
						{
							continue;
						}
						if (this.vi0K95bRZy.actionState != "run")
						{
							if (49432 - 443978 != -394545)
							{
								break;
							}
							continue;
						}
					}
					float num = this.vi0K95bRZy.moveSpeed;
					if (234343 - 356964 == -122621)
					{
						float runSpeed = this.vi0K95bRZy.runSpeed;
						if (171314 - 366229 != -194914)
						{
							Vector3 vector = default(Vector3);
							if (72437 - 107319 != -34881)
							{
								Vector3 vector2 = Vector3.zero;
								if (276381 - 206236 == 70145)
								{
									if ((this.vi0K95bRZy.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (226687 - 547302 == -320614)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.vi0K95bRZy.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (239627 - 322475 == -82847)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (136660 - 230868 == -94207)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (65341 - 404906 == -339564)
											{
												continue;
											}
											num = (float)0;
											if (297373 - 515199 != -217826)
											{
												continue;
											}
											this.transform.position = this.vi0K95bRZy.nPosition;
											if (2538 - 561651 == -559112)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (132978 - 78972 != 54006)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (11959 - 429190 != -417231)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (27767 - 432227 == -404459)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (287235 - 256812 != 30423)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (8538 - 110834 != -102296)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (11413 - 161181 != -149768)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (158475 - 235553 == -77077)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (65614 - 253258 == -187643)
											{
												continue;
											}
										}
									}
									this.vi0K95bRZy.vMovement = vector2;
									if (180288 - 154260 != 26029)
									{
										this.vi0K95bRZy.moveSpeed = num;
										if (214055 - 552252 != -338196)
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

	// Token: 0x06004766 RID: 18278 RVA: 0x008E5684 File Offset: 0x008E3884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (112884 - 84389 != 28495)
		{
		}
		do
		{
			if (Time.time - this.y2IKuLSgjL >= this.nCEKyyaYnh)
			{
				if (285445 - 119641 != 165804)
				{
					continue;
				}
				if (Time.time - this.y2IKuLSgjL < this.nCEKyyaYnh + mTime)
				{
					if (33669 - 175735 == -142065)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (247313 - 46964 == 200350)
						{
							continue;
						}
						this.AI_state = "idle";
						if (121081 - 542648 != -421567)
						{
							continue;
						}
						this.y2IKuLSgjL -= UnityEngine.Random.Range((float)0, rTimer);
						if (270685 - 50626 != 220059)
						{
							continue;
						}
						this.vi0K95bRZy.vDirection = Vector3.zero;
						if (32984 - 61568 != -28584)
						{
							continue;
						}
						this.vi0K95bRZy.vMovement = this.transform.forward;
						if (182833 - 403862 != -221029)
						{
							continue;
						}
						this.vi0K95bRZy.actionState = "standby";
						if (135402 - 477924 != -342522)
						{
							continue;
						}
					}
					this.vi0K95bRZy.moveSpeed = Mathf.Lerp(this.vi0K95bRZy.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (158109 - 405961 != -247852)
					{
						continue;
					}
					if (this.vi0K95bRZy.moveSpeed < 0.1f * this.vi0K95bRZy.runSpeed)
					{
						if (25692 - 486975 == -461282)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (54300 - 224246 != -169946)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (173184 - 32793 != 140391)
						{
							continue;
						}
						this.vi0K95bRZy.moveSpeed = (float)0;
						if (115650 - 422290 == -306639)
						{
							continue;
						}
					}
				}
			}
			this.nCEKyyaYnh += mTime;
		}
		while (21822 - 562896 == -541073);
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x008E5948 File Offset: 0x008E3B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (224581 - 359610 != -135028)
		{
		}
		do
		{
			if (Time.time - this.y2IKuLSgjL >= this.nCEKyyaYnh)
			{
				if (117330 - 598040 == -480709)
				{
					continue;
				}
				if (Time.time - this.y2IKuLSgjL < this.nCEKyyaYnh + mTime)
				{
					if (180143 - 12982 == 167162)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (271367 - 432690 != -161323)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (64696 - 209658 != -144962)
						{
							continue;
						}
						this.y2IKuLSgjL -= UnityEngine.Random.Range((float)0, rTimer);
						if (67870 - 389185 == -321314)
						{
							continue;
						}
						this.vi0K95bRZy.vDirection = this.vi0K95bRZy.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (173847 - 583186 == -409338)
						{
							continue;
						}
						this.vi0K95bRZy.vDirection.y = this.transform.position.y;
						if (240671 - 347239 == -106567)
						{
							continue;
						}
						this.vi0K95bRZy.vMovement = (this.vi0K95bRZy.vDirection - this.transform.position).normalized;
						if (285033 - 461811 != -176778)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.vi0K95bRZy.vMovement);
						if (191407 - 313089 == -121681)
						{
							continue;
						}
						this.vi0K95bRZy.actionState = "run";
						if (9546 - 16429 == -6882)
						{
							continue;
						}
						this.animation.Play("run");
						if (139609 - 199691 == -60081)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (142243 - 68281 == 73963)
						{
							continue;
						}
					}
					this.vi0K95bRZy.moveSpeed = Mathf.Lerp(this.vi0K95bRZy.moveSpeed, this.vi0K95bRZy.runSpeed, (float)4 * Time.deltaTime);
					if (195619 - 499488 != -303869)
					{
						continue;
					}
				}
			}
			this.nCEKyyaYnh += mTime;
		}
		while (97192 - 364132 != -266940);
	}

	// Token: 0x06004768 RID: 18280 RVA: 0x008E5C50 File Offset: 0x008E3E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (166360 - 218610 != -52249)
		{
		}
		do
		{
			if (Time.time - this.y2IKuLSgjL >= this.nCEKyyaYnh)
			{
				if (285695 - 483916 == -198220)
				{
					continue;
				}
				if (Time.time - this.y2IKuLSgjL < this.nCEKyyaYnh + mTime)
				{
					if (249318 - 297706 != -48388)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (290491 - 75867 == 214625)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (93223 - 407813 == -314589)
						{
							continue;
						}
						this.y2IKuLSgjL = Time.time - mTime - this.nCEKyyaYnh;
						if (70005 - 67375 == 2631)
						{
							continue;
						}
						this.vi0K95bRZy.vDirection = Vector3.zero;
						if (230841 - 59455 != 171386)
						{
							continue;
						}
						this.vi0K95bRZy.vMovement = this.transform.forward;
						if (250447 - 565886 != -315439)
						{
							continue;
						}
						this.vi0K95bRZy.actionState = "standby";
						if (141764 - 50513 == 91252)
						{
							continue;
						}
						this.vi0K95bRZy.myAttackTarget = this.vi0K95bRZy.getHateTarget(12, 36);
						if (35021 - 404567 == -369545)
						{
							continue;
						}
						if (!this.vi0K95bRZy.myAttackTarget)
						{
							if (78537 - 177441 != -98904)
							{
								continue;
							}
							this.vi0K95bRZy.isAlert = false;
							if (286987 - 341616 == -54628)
							{
								continue;
							}
							this.y2IKuLSgjL = Time.time;
							if (89754 - 342628 == -252873)
							{
								continue;
							}
							this.vi0K95bRZy.myAttackTarget = null;
							if (136601 - 300465 == -163863)
							{
								continue;
							}
							this.vi0K95bRZy.mOriginalPosition = this.transform.position;
							if (283059 - 4948 != 278111)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.vi0K95bRZy.myAttackTarget;
							if (183065 - 127813 == 55253)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (172898 - 430859 != -257961)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (139227 - 430769 != -291542)
								{
									continue;
								}
								this.vi0K95bRZy.isAlert = false;
								if (88948 - 173120 != -84172)
								{
									continue;
								}
								this.y2IKuLSgjL = Time.time;
								if (12116 - 285911 != -273795)
								{
									continue;
								}
								this.vi0K95bRZy.myAttackTarget = null;
								if (243914 - 254100 != -10186)
								{
									continue;
								}
							}
							else
							{
								this.vi0K95bRZy.vDirection = myAttackTarget.transform.position;
								if (74812 - 564385 != -489573)
								{
									continue;
								}
								this.vi0K95bRZy.vDirection.y = this.transform.position.y;
								if (211927 - 118528 != 93399)
								{
									continue;
								}
								this.vi0K95bRZy.vMovement = (this.vi0K95bRZy.vDirection - this.transform.position).normalized;
								if (249952 - 378039 != -128087)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.vi0K95bRZy.vMovement);
								if (65395 - 423684 == -358288)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.nCEKyyaYnh += mTime;
		}
		while (216174 - 528284 == -312109);
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x008E6100 File Offset: 0x008E4300
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (115067 - 399585 != -284517)
		{
		}
		do
		{
			if (Time.time - this.y2IKuLSgjL >= this.nCEKyyaYnh)
			{
				if (27641 - 569759 == -542117)
				{
					continue;
				}
				if (Time.time - this.y2IKuLSgjL < this.nCEKyyaYnh + mTime)
				{
					if (164360 - 98370 != 65990)
					{
						continue;
					}
					if (!this.vi0K95bRZy.myAttackTarget)
					{
						if (15788 - 314768 == -298979)
						{
							continue;
						}
						this.y2IKuLSgjL = Time.time - mTime - this.nCEKyyaYnh;
						if (101204 - 346711 != -245506)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.vi0K95bRZy.myAttackTarget;
						if (86095 - 591906 == -505810)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (17148 - 584559 == -567410)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (254753 - 464651 == -209897 || 241003 - 24761 == 216243)
						{
							continue;
						}
						if (characterControl)
						{
							if (197555 - 87158 != 110397)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (73068 - 117991 != -44923)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (32895 - 555722 != -522827)
						{
							continue;
						}
						if (num < (float)24)
						{
							if (140269 - 587284 == -447014)
							{
								continue;
							}
							if (this.vi0K95bRZy.isTimeOut("nAttack") == (float)0)
							{
								if (128686 - 319028 != -190342)
								{
									continue;
								}
								this.y2IKuLSgjL = Time.time - mTime - this.nCEKyyaYnh;
								if (269500 - 579910 != -310410)
								{
									continue;
								}
								this.jgZKWEQnnb.StartCoroutine_Auto(this.jgZKWEQnnb.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (105371 - 281074 != -175703)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (101188 - 213753 != -112565)
									{
										continue;
									}
									this.jgZKWEQnnb.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
									if (5237 - 347371 == -342133)
									{
										continue;
									}
								}
								goto IL_510;
							}
						}
						if (num > (float)24)
						{
							if (31112 - 524532 == -493419)
							{
								continue;
							}
							this.AI_state = "attack";
							if (175568 - 549157 != -373589)
							{
								continue;
							}
							this.vi0K95bRZy.vDirection = myAttackTarget.transform.position;
							if (97902 - 173993 == -76090)
							{
								continue;
							}
							this.vi0K95bRZy.vDirection.y = this.transform.position.y;
							if (56672 - 139282 != -82610)
							{
								continue;
							}
							this.vi0K95bRZy.vMovement = (this.vi0K95bRZy.vDirection - this.transform.position).normalized;
							if (53408 - 596372 != -542964)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.vi0K95bRZy.vMovement);
							if (188718 - 55669 != 133049)
							{
								continue;
							}
							this.vi0K95bRZy.actionState = "run";
							if (111757 - 411631 == -299873)
							{
								continue;
							}
							this.animation.Play("run");
							if (185481 - 105675 != 79806)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (186190 - 135506 != 50684)
							{
								continue;
							}
							this.vi0K95bRZy.moveSpeed = Mathf.Lerp(this.vi0K95bRZy.moveSpeed, this.vi0K95bRZy.runSpeed, (float)4 * Time.deltaTime);
							if (214367 - 135387 != 78980)
							{
								continue;
							}
						}
						else if (num < (float)6)
						{
							if (168909 - 178142 != -9233)
							{
								continue;
							}
							this.AI_state = "attack";
							if (269085 - 229755 == 39331)
							{
								continue;
							}
							this.vi0K95bRZy.vDirection = -myAttackTarget.transform.position;
							if (97543 - 158447 == -60903)
							{
								continue;
							}
							this.vi0K95bRZy.vDirection.y = this.transform.position.y;
							if (20372 - 388935 == -368562)
							{
								continue;
							}
							this.vi0K95bRZy.vMovement = (this.vi0K95bRZy.vDirection - this.transform.position).normalized;
							if (57416 - 119255 == -61838)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.vi0K95bRZy.vMovement);
							if (117667 - 383358 == -265690)
							{
								continue;
							}
							this.vi0K95bRZy.actionState = "run";
							if (91939 - 255653 != -163714)
							{
								continue;
							}
							this.animation.Play("run");
							if (154371 - 261834 == -107462)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (37415 - 176308 != -138893)
							{
								continue;
							}
							this.vi0K95bRZy.moveSpeed = Mathf.Lerp(this.vi0K95bRZy.moveSpeed, this.vi0K95bRZy.runSpeed, (float)4 * Time.deltaTime);
							if (80420 - 129805 != -49385)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (157279 - 457962 != -300683)
							{
								continue;
							}
							this.vi0K95bRZy.vDirection = this.transform.forward;
							if (98826 - 228510 != -129684)
							{
								continue;
							}
							this.vi0K95bRZy.vMovement = this.transform.forward;
							if (139986 - 309481 != -169495)
							{
								continue;
							}
							this.vi0K95bRZy.actionState = "standby";
							if (81416 - 354972 == -273555)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (272306 - 228206 == 44101)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (52171 - 124785 == -72613)
							{
								continue;
							}
							this.vi0K95bRZy.moveSpeed = Mathf.Lerp(this.vi0K95bRZy.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (137170 - 295342 != -158172)
							{
								continue;
							}
						}
					}
				}
			}
			IL_510:
			this.nCEKyyaYnh += mTime;
		}
		while (150504 - 373637 != -223133);
	}

	// Token: 0x0600476A RID: 18282 RVA: 0x008E69F8 File Offset: 0x008E4BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (268133 - 122089 != 146044)
		{
		}
		while (Time.time - this.y2IKuLSgjL > this.nCEKyyaYnh)
		{
			if (112091 - 483957 != -371865)
			{
				this.AI_state = "none";
				if (262023 - 421922 != -159898)
				{
					this.y2IKuLSgjL = Time.time;
					if (83964 - 92966 == -9002)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600476B RID: 18283 RVA: 0x008E6AAC File Offset: 0x008E4CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (150886 - 365514 != -214628)
		{
		}
		for (;;)
		{
			IL_105:
			if (this.Ef4KVBPKPs + (float)1 > Time.time)
			{
				if (253923 - 200654 != 53270)
				{
					break;
				}
			}
			else
			{
				this.Ef4KVBPKPs = Time.time;
				if (122530 - 463367 != -340836)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (286744 - 535971 != -249226)
					{
						if (49716 - 220430 == -170714)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (257163 - 347412 == -90249)
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
									if (169291 - 513361 != -344070)
									{
										goto IL_105;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (60180 - 46604 != 13576)
									{
										goto IL_105;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (260215 - 134635 != 125580)
									{
										goto IL_105;
									}
									bool flag = true;
									if (285365 - 175654 == 109712)
									{
										goto IL_105;
									}
									Vector3 position = this.transform.position;
									if (270307 - 5152 != 265155)
									{
										goto IL_105;
									}
									if (Mathf.Abs(position.y - gameObject.transform.position.y) > (float)12)
									{
										if (291448 - 195667 != 95781)
										{
											goto IL_105;
										}
										flag = false;
										if (170906 - 578015 != -407109)
										{
											goto IL_105;
										}
									}
									else
									{
										eRace race = this.vi0K95bRZy.Race;
										if (37916 - 19307 == 18610)
										{
											goto IL_105;
										}
										if (race == eRace.Tails)
										{
											if (277335 - 47749 == 229587)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_5E4;
											}
											if (221866 - 56206 != 165660)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (277345 - 473762 != -196417)
												{
													goto IL_105;
												}
												goto IL_5E4;
											}
											goto IL_21A;
											IL_5E4:
											flag = false;
											if (253233 - 255862 == -2628)
											{
												goto IL_105;
											}
										}
										else if (race == eRace.Plants)
										{
											if (156351 - 527015 != -370664)
											{
												goto IL_105;
											}
											flag = false;
											if (160097 - 191427 != -31330)
											{
												goto IL_105;
											}
										}
										else if (race == eRace.Bugs)
										{
											if (120931 - 4554 == 116378)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Elementals)
											{
												goto IL_852;
											}
											if (118927 - 332342 == -213414)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Robots)
											{
												if (244713 - 199666 != 45048)
												{
													goto IL_852;
												}
												goto IL_105;
											}
											goto IL_21A;
											IL_852:
											flag = false;
											if (126134 - 95772 != 30362)
											{
												goto IL_105;
											}
										}
										else if (race == eRace.Robots)
										{
											if (50396 - 192369 != -141973)
											{
												goto IL_105;
											}
											flag = true;
											if (1291 - 76401 != -75110)
											{
												goto IL_105;
											}
										}
										else if (race == eRace.Elementals)
										{
											if (144037 - 398562 != -254525)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_154;
											}
											if (43758 - 45939 == -2180)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Bugs)
											{
												goto IL_154;
											}
											if (207914 - 105640 != 102274)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (180735 - 279021 != -98286)
												{
													goto IL_105;
												}
												goto IL_154;
											}
											goto IL_21A;
											IL_154:
											flag = false;
											if (216610 - 564097 != -347487)
											{
												goto IL_105;
											}
										}
										else if (race == eRace.Structure)
										{
											if (298915 - 591111 != -292196)
											{
												goto IL_105;
											}
											if (characterControl.Race == eRace.Plants)
											{
												if (251176 - 414645 == -163468)
												{
													goto IL_105;
												}
												flag = false;
												if (24771 - 264997 != -240226)
												{
													goto IL_105;
												}
											}
										}
									}
									IL_21A:
									if (flag)
									{
										if (10782 - 15015 != -4233)
										{
											goto IL_105;
										}
										if (characterControl.hp > 0)
										{
											if (197912 - 138175 != 59737)
											{
												goto IL_105;
											}
											if (characterControl.recieveTarget)
											{
												if (32631 - 389878 == -357246)
												{
													goto IL_105;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (170191 - 169423 == 769)
													{
														goto IL_105;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (194907 - 529374 == -334466)
														{
															goto IL_105;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (250436 - 532403 != -281967)
														{
															goto IL_105;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (294878 - 325438 != -30560)
															{
																goto IL_105;
															}
															this.vi0K95bRZy.isAlert = true;
															if (146618 - 336525 == -189906)
															{
																goto IL_105;
															}
															this.y2IKuLSgjL = Time.time;
															if (51585 - 432162 != -380577)
															{
																goto IL_105;
															}
															this.vi0K95bRZy.myAttackTarget = gameObject;
															if (258117 - 506081 != -247964)
															{
																goto IL_105;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (212533 - 294462 == -81928)
															{
																goto IL_105;
															}
															this.vi0K95bRZy.addHate(characterControl.ActorNr, 5);
															if (19568 - 150835 != -131267)
															{
																goto IL_105;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (52814 - 398792 == -345977)
															{
																goto IL_105;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (69581 - 361830 == -292248)
															{
																goto IL_105;
															}
															if (num < (float)60)
															{
																if (215348 - 335543 == -120194)
																{
																	goto IL_105;
																}
																if (characterControl.hp > 0)
																{
																	if (12259 - 375505 == -363245)
																	{
																		goto IL_105;
																	}
																	this.vi0K95bRZy.isAlert = true;
																	if (77849 - 582837 == -504987)
																	{
																		goto IL_105;
																	}
																	this.y2IKuLSgjL = Time.time;
																	if (264603 - 489994 != -225391)
																	{
																		goto IL_105;
																	}
																	this.vi0K95bRZy.myAttackTarget = gameObject;
																	if (123121 - 494885 == -371763)
																	{
																		goto IL_105;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (275714 - 4574 != 271140)
																	{
																		goto IL_105;
																	}
																	this.vi0K95bRZy.addHate(characterControl.ActorNr, 5);
																	if (277328 - 117862 != 159466)
																	{
																		goto IL_105;
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
								if (227757 - 50761 == 176996)
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

	// Token: 0x0600476C RID: 18284 RVA: 0x008E7360 File Offset: 0x008E5560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600476D RID: 18285 RVA: 0x008E7364 File Offset: 0x008E5564
	internal static bool psKh005JbbE8cmk3bIxI()
	{
		return true;
	}

	// Token: 0x0600476E RID: 18286 RVA: 0x008E7368 File Offset: 0x008E5568
	internal static bool iWwDLE5JuZWwmnaXHfTt()
	{
		return false;
	}

	// Token: 0x0400529B RID: 21147
	private CharacterControl vi0K95bRZy;

	// Token: 0x0400529C RID: 21148
	private IcePenguin1 jgZKWEQnnb;

	// Token: 0x0400529D RID: 21149
	public string AI_state;

	// Token: 0x0400529E RID: 21150
	private float y2IKuLSgjL;

	// Token: 0x0400529F RID: 21151
	private float nCEKyyaYnh;

	// Token: 0x040052A0 RID: 21152
	private float Ef4KVBPKPs;
}
