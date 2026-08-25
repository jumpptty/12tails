using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E20 RID: 3616
[Serializable]
public class Fay_AI : MonoBehaviour
{
	// Token: 0x060051C2 RID: 20930 RVA: 0x009FBE50 File Offset: 0x009FA050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fay_AI()
	{
		if (293726 - 517784 != -224058)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (257664 - 32693 != 224972)
			{
				base..ctor();
				if (119540 - 159288 == -39748)
				{
					this.AI_state = "none";
					if (35173 - 246256 == -211083)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060051C3 RID: 20931 RVA: 0x009FBEEC File Offset: 0x009FA0EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ah8ceEg10Ci = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.BYecePOAYk1 = (Fay)this.GetComponent(typeof(Fay));
	}

	// Token: 0x060051C4 RID: 20932 RVA: 0x009FBF24 File Offset: 0x009FA124
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (66660 - 260555 != -193894)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (152812 - 398510 == -245697)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (131349 - 452645 != -321296)
				{
					continue;
				}
			}
			if (this.ah8ceEg10Ci.isControlled)
			{
				break;
			}
			if (245197 - 34159 != 211039)
			{
				this.AIControl();
				if (120670 - 201540 == -80870)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060051C5 RID: 20933 RVA: 0x009FBFF0 File Offset: 0x009FA1F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (9625 - 474540 != -464914)
		{
		}
		for (;;)
		{
			this.s7OceBK35ck = (float)0;
			if (159532 - 128312 != 31221)
			{
				if (this.ah8ceEg10Ci.isMine)
				{
					if (219672 - 76005 != 143668)
					{
						if (this.ah8ceEg10Ci.actionState != "standby")
						{
							if (155767 - 374595 != -218828)
							{
								continue;
							}
							if (this.ah8ceEg10Ci.actionState != "run")
							{
								if (262722 - 138859 != 123863)
								{
									continue;
								}
								break;
							}
						}
						if (!this.ah8ceEg10Ci.isAlert)
						{
							if (248693 - 413634 != -164940)
							{
								this.AI_idle(2f, 1f);
								if (233347 - 492296 != -258948)
								{
									this.AI_patrol(3f, 2f);
									if (202854 - 338883 == -136029)
									{
										this.AI_resetTimer();
										if (134484 - 30643 != 103842)
										{
											this.AI_visionCheck();
											if (23948 - 267566 != -243617)
											{
												if (!this.ah8ceEg10Ci.myAttackTarget)
												{
													break;
												}
												if (118354 - 29553 == 88801)
												{
													this.ah8ceEg10Ci.isAlert = true;
													if (383 - 366744 != -366360)
													{
														this.Yy1ceSJKXOI = Time.time;
														if (150674 - 71386 != 79289)
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
							if (194610 - 442782 != -248171)
							{
								this.AI_patrol(3f, 2f);
								if (21086 - 144863 != -123776)
								{
									this.AI_attack(7f, (float)0);
									if (96849 - 414505 == -317656)
									{
										this.AI_resetTimer();
										if (163482 - 565691 == -402209)
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
					if (this.ah8ceEg10Ci.actionState != "standby")
					{
						if (76688 - 450865 != -374177)
						{
							continue;
						}
						if (this.ah8ceEg10Ci.actionState != "run")
						{
							if (161939 - 179576 != -17637)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ah8ceEg10Ci.moveSpeed;
					if (290774 - 571690 != -280915)
					{
						float runSpeed = this.ah8ceEg10Ci.runSpeed;
						if (177366 - 249842 != -72475)
						{
							Vector3 vector = default(Vector3);
							if (158445 - 458393 == -299948)
							{
								Vector3 vector2 = Vector3.zero;
								if (236130 - 547978 != -311847)
								{
									if ((this.ah8ceEg10Ci.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (210482 - 318739 != -108257)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ah8ceEg10Ci.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (267381 - 421834 == -154452)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (273066 - 222446 != 50620)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (178930 - 192702 == -13771)
											{
												continue;
											}
											num = (float)0;
											if (148106 - 358389 == -210282)
											{
												continue;
											}
											this.transform.position = this.ah8ceEg10Ci.nPosition;
											if (289307 - 362036 == -72728)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (127473 - 361402 == -233928)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (250695 - 300674 != -49979)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (188644 - 74319 != 114325)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (176817 - 582684 != -405867)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (292601 - 295243 == -2641)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (197058 - 111735 == 85324)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (62871 - 384091 != -321220)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (188993 - 378666 != -189673)
											{
												continue;
											}
										}
									}
									this.ah8ceEg10Ci.vMovement = vector2;
									if (52727 - 441522 != -388794)
									{
										this.ah8ceEg10Ci.moveSpeed = num;
										if (241978 - 52342 == 189636)
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

	// Token: 0x060051C6 RID: 20934 RVA: 0x009FC668 File Offset: 0x009FA868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (149921 - 248094 != -98173)
		{
		}
		do
		{
			if (Time.time - this.Yy1ceSJKXOI >= this.s7OceBK35ck)
			{
				if (242387 - 464084 != -221697)
				{
					continue;
				}
				if (Time.time - this.Yy1ceSJKXOI < this.s7OceBK35ck + mTime)
				{
					if (113926 - 66892 == 47035)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (237867 - 52581 != 185286)
						{
							continue;
						}
						this.AI_state = "idle";
						if (25616 - 17259 == 8358)
						{
							continue;
						}
						this.Yy1ceSJKXOI -= UnityEngine.Random.Range((float)0, rTimer);
						if (112756 - 350741 == -237984)
						{
							continue;
						}
						this.ah8ceEg10Ci.vDirection = Vector3.zero;
						if (1362 - 377015 == -375652)
						{
							continue;
						}
						this.ah8ceEg10Ci.vMovement = this.transform.forward;
						if (131106 - 81620 == 49487)
						{
							continue;
						}
						this.ah8ceEg10Ci.actionState = "standby";
						if (176860 - 594943 == -418082)
						{
							continue;
						}
					}
					this.ah8ceEg10Ci.moveSpeed = Mathf.Lerp(this.ah8ceEg10Ci.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (282602 - 137627 == 144976)
					{
						continue;
					}
					if (this.ah8ceEg10Ci.moveSpeed < 0.1f * this.ah8ceEg10Ci.runSpeed)
					{
						if (81765 - 336627 == -254861)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (19112 - 238487 == -219374)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (195119 - 484120 != -289001)
						{
							continue;
						}
						this.ah8ceEg10Ci.moveSpeed = (float)0;
						if (167701 - 106240 != 61461)
						{
							continue;
						}
					}
				}
			}
			this.s7OceBK35ck += mTime;
		}
		while (286212 - 405596 != -119384);
	}

	// Token: 0x060051C7 RID: 20935 RVA: 0x009FC92C File Offset: 0x009FAB2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (114384 - 177496 != -63111)
		{
		}
		do
		{
			if (Time.time - this.Yy1ceSJKXOI >= this.s7OceBK35ck)
			{
				if (203436 - 39728 != 163708)
				{
					continue;
				}
				if (Time.time - this.Yy1ceSJKXOI < this.s7OceBK35ck + mTime)
				{
					if (287909 - 344916 != -57007)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (208059 - 118735 == 89325)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (31743 - 571127 != -539384)
						{
							continue;
						}
						this.Yy1ceSJKXOI -= UnityEngine.Random.Range((float)0, rTimer);
						if (218163 - 48653 != 169510)
						{
							continue;
						}
						this.ah8ceEg10Ci.vDirection = this.ah8ceEg10Ci.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (219499 - 199662 != 19837)
						{
							continue;
						}
						this.ah8ceEg10Ci.vDirection.y = this.transform.position.y;
						if (10032 - 453265 == -443232)
						{
							continue;
						}
						this.ah8ceEg10Ci.vMovement = (this.ah8ceEg10Ci.vDirection - this.transform.position).normalized;
						if (152667 - 579086 == -426418)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ah8ceEg10Ci.vMovement);
						if (94135 - 536455 == -442319)
						{
							continue;
						}
						this.ah8ceEg10Ci.actionState = "run";
						if (257594 - 96300 != 161294)
						{
							continue;
						}
						this.animation.Play("run");
						if (170159 - 471186 != -301027)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (207612 - 449160 == -241547)
						{
							continue;
						}
						this.ah8ceEg10Ci.runSpeed = (float)5;
						if (34677 - 527844 == -493166)
						{
							continue;
						}
					}
					this.ah8ceEg10Ci.moveSpeed = Mathf.Lerp(this.ah8ceEg10Ci.moveSpeed, this.ah8ceEg10Ci.runSpeed, (float)4 * Time.deltaTime);
					if (13785 - 403636 == -389850)
					{
						continue;
					}
				}
			}
			this.s7OceBK35ck += mTime;
		}
		while (154819 - 343252 != -188433);
	}

	// Token: 0x060051C8 RID: 20936 RVA: 0x009FCC5C File Offset: 0x009FAE5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (85906 - 402143 != -316236)
		{
		}
		do
		{
			if (Time.time - this.Yy1ceSJKXOI >= this.s7OceBK35ck)
			{
				if (109 - 137315 == -137205)
				{
					continue;
				}
				if (Time.time - this.Yy1ceSJKXOI < this.s7OceBK35ck + mTime)
				{
					if (288276 - 174929 == 113348)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (248306 - 523696 != -275390)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (125221 - 380708 != -255487)
						{
							continue;
						}
						this.Yy1ceSJKXOI = Time.time - mTime - this.s7OceBK35ck;
						if (237270 - 285273 != -48003)
						{
							continue;
						}
						this.ah8ceEg10Ci.vDirection = Vector3.zero;
						if (159930 - 303324 != -143394)
						{
							continue;
						}
						this.ah8ceEg10Ci.vMovement = this.transform.forward;
						if (141281 - 136495 == 4787)
						{
							continue;
						}
						this.ah8ceEg10Ci.actionState = "standby";
						if (146031 - 296712 != -150681)
						{
							continue;
						}
						this.ah8ceEg10Ci.myAttackTarget = this.ah8ceEg10Ci.getRandomHateTarget(50);
						if (291264 - 254074 != 37190)
						{
							continue;
						}
						if (!this.ah8ceEg10Ci.myAttackTarget)
						{
							if (118136 - 451569 != -333433)
							{
								continue;
							}
							this.ah8ceEg10Ci.isAlert = false;
							if (6553 - 61690 != -55137)
							{
								continue;
							}
							this.Yy1ceSJKXOI = Time.time;
							if (97238 - 549750 != -452512)
							{
								continue;
							}
							this.ah8ceEg10Ci.myAttackTarget = null;
							if (94217 - 495337 == -401119)
							{
								continue;
							}
							this.ah8ceEg10Ci.mOriginalPosition = this.transform.position;
							if (32518 - 287904 != -255385)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.ah8ceEg10Ci.myAttackTarget;
							if (4723 - 529109 == -524385)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (76746 - 289717 == -212970)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (50725 - 300301 != -249576)
								{
									continue;
								}
								this.ah8ceEg10Ci.isAlert = false;
								if (294359 - 357486 == -63126)
								{
									continue;
								}
								this.Yy1ceSJKXOI = Time.time;
								if (237240 - 181392 == 55849)
								{
									continue;
								}
								this.ah8ceEg10Ci.myAttackTarget = null;
								if (154568 - 465806 != -311238)
								{
									continue;
								}
							}
							else
							{
								this.ah8ceEg10Ci.vDirection = myAttackTarget.transform.position;
								if (199149 - 11798 != 187351)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection.y = this.transform.position.y;
								if (72058 - 44507 == 27552)
								{
									continue;
								}
								this.ah8ceEg10Ci.vMovement = (this.ah8ceEg10Ci.vDirection - this.transform.position).normalized;
								if (69517 - 556782 == -487264)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ah8ceEg10Ci.vMovement);
								if (253793 - 264416 == -10622)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.s7OceBK35ck += mTime;
		}
		while (195763 - 559707 != -363944);
	}

	// Token: 0x060051C9 RID: 20937 RVA: 0x009FD10C File Offset: 0x009FB30C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (200262 - 482600 != -282338)
		{
		}
		do
		{
			if (Time.time - this.Yy1ceSJKXOI >= this.s7OceBK35ck)
			{
				if (87934 - 450504 == -362569)
				{
					continue;
				}
				if (Time.time - this.Yy1ceSJKXOI < this.s7OceBK35ck + mTime)
				{
					if (16576 - 22116 == -5539)
					{
						continue;
					}
					if (!this.ah8ceEg10Ci.myAttackTarget)
					{
						if (59325 - 50572 == 8754)
						{
							continue;
						}
						this.Yy1ceSJKXOI = Time.time - mTime - this.s7OceBK35ck;
						if (267107 - 112273 != 154835)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.ah8ceEg10Ci.myAttackTarget;
						if (258669 - 176702 != 81967)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (291853 - 593903 == -302049)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (239523 - 203128 != 36395)
						{
							continue;
						}
						int tID = 0;
						if (51283 - 450645 != -399362)
						{
							continue;
						}
						if (characterControl)
						{
							if (73943 - 31062 != 42881)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (290478 - 3072 != 287406)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (254410 - 489405 == -234994)
						{
							continue;
						}
						if (this.ah8ceEg10Ci.isTimeOut("magicLance") == (float)0)
						{
							if (125108 - 276250 != -151142)
							{
								continue;
							}
							if (num < (float)30)
							{
								if (197077 - 491435 == -294357)
								{
									continue;
								}
								this.Yy1ceSJKXOI = Time.time - mTime - this.s7OceBK35ck;
								if (146509 - 426878 == -280368)
								{
									continue;
								}
								this.BYecePOAYk1.StartCoroutine_Auto(this.BYecePOAYk1.RPC_magicLance(this.transform.position, vector, tID));
								if (68533 - 253970 != -185436)
								{
									if (PhotonClient.IsInitialized())
									{
										if (234074 - 92102 != 141972)
										{
											continue;
										}
										this.BYecePOAYk1.ActionEvent("RPC_magicLance", this.transform.position, vector, tID);
										if (151840 - 424511 != -272671)
										{
											continue;
										}
									}
									goto IL_3E0;
								}
								continue;
							}
						}
						if (this.ah8ceEg10Ci.isTimeOut("dispell") == (float)0)
						{
							if (243254 - 523227 != -279973)
							{
								continue;
							}
							this.Yy1ceSJKXOI = Time.time - mTime - this.s7OceBK35ck;
							if (99579 - 13264 != 86315)
							{
								continue;
							}
							this.BYecePOAYk1.StartCoroutine_Auto(this.BYecePOAYk1.RPC_dispell(this.transform.position, vector, tID));
							if (299686 - 228766 == 70921)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (89968 - 248217 == -158248)
								{
									continue;
								}
								this.BYecePOAYk1.ActionEvent("RPC_dispell", this.transform.position, vector, tID);
								if (98125 - 115527 != -17402)
								{
									continue;
								}
							}
						}
						else if (this.ah8ceEg10Ci.isTimeOut("nAttack") == (float)0)
						{
							if (86585 - 462333 == -375747)
							{
								continue;
							}
							this.Yy1ceSJKXOI = Time.time - mTime - this.s7OceBK35ck;
							if (194707 - 585477 != -390770)
							{
								continue;
							}
							this.BYecePOAYk1.StartCoroutine_Auto(this.BYecePOAYk1.RPC_nAttack(this.transform.position, vector, tID));
							if (239523 - 209324 == 30200)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (17676 - 539843 != -522167)
								{
									continue;
								}
								this.BYecePOAYk1.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
								if (193803 - 2819 != 190984)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (32403 - 427714 == -395310)
							{
								continue;
							}
							if (num > (float)30)
							{
								if (25526 - 138522 == -112995)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection = myAttackTarget.transform.position;
								if (237782 - 366373 == -128590)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection.y = this.transform.position.y;
								if (245318 - 206760 == 38559)
								{
									continue;
								}
								this.ah8ceEg10Ci.vMovement = (this.ah8ceEg10Ci.vDirection - this.transform.position).normalized;
								if (95435 - 126386 == -30950)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ah8ceEg10Ci.vMovement);
								if (230233 - 53262 != 176971)
								{
									continue;
								}
								this.ah8ceEg10Ci.actionState = "run";
								if (192290 - 513967 == -321676)
								{
									continue;
								}
								this.animation.Play("run");
								if (297296 - 552929 == -255632)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (218340 - 480866 == -262525)
								{
									continue;
								}
								this.ah8ceEg10Ci.moveSpeed = Mathf.Lerp(this.ah8ceEg10Ci.moveSpeed, this.ah8ceEg10Ci.runSpeed, (float)4 * Time.deltaTime);
								if (163387 - 432980 == -269592)
								{
									continue;
								}
							}
							else if (num < (float)6)
							{
								if (102993 - 434685 == -331691)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection = myAttackTarget.transform.position;
								if (138663 - 140132 != -1469)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection.y = this.transform.position.y;
								if (268705 - 21971 == 246735)
								{
									continue;
								}
								this.ah8ceEg10Ci.vMovement = (this.transform.position - this.ah8ceEg10Ci.vDirection).normalized;
								if (226801 - 283143 == -56341)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ah8ceEg10Ci.vMovement);
								if (118203 - 547780 != -429577)
								{
									continue;
								}
								this.ah8ceEg10Ci.actionState = "run";
								if (265053 - 247168 != 17885)
								{
									continue;
								}
								this.animation.Play("run");
								if (117350 - 544314 == -426963)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (21309 - 248976 == -227666)
								{
									continue;
								}
								this.ah8ceEg10Ci.moveSpeed = Mathf.Lerp(this.ah8ceEg10Ci.moveSpeed, (float)5, (float)4 * Time.deltaTime);
								if (104545 - 120198 == -15652)
								{
									continue;
								}
							}
							else
							{
								this.ah8ceEg10Ci.vDirection = myAttackTarget.transform.position;
								if (287950 - 71119 != 216831)
								{
									continue;
								}
								this.ah8ceEg10Ci.vDirection.y = this.transform.position.y;
								if (153776 - 470551 == -316774)
								{
									continue;
								}
								this.ah8ceEg10Ci.vMovement = (this.ah8ceEg10Ci.vDirection - this.transform.position).normalized;
								if (298479 - 438898 == -140418)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ah8ceEg10Ci.vMovement);
								if (96860 - 119711 == -22850)
								{
									continue;
								}
								this.ah8ceEg10Ci.actionState = "standby";
								if (24150 - 290741 != -266591)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (114255 - 401984 != -287729)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (229228 - 220386 != 8842)
								{
									continue;
								}
								this.ah8ceEg10Ci.moveSpeed = Mathf.Lerp(this.ah8ceEg10Ci.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (84956 - 202569 != -117613)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_3E0:
			this.s7OceBK35ck += mTime;
		}
		while (54742 - 373763 == -319020);
	}

	// Token: 0x060051CA RID: 20938 RVA: 0x009FDBF0 File Offset: 0x009FBDF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (264407 - 472532 != -208125)
		{
		}
		while (Time.time - this.Yy1ceSJKXOI > this.s7OceBK35ck)
		{
			if (165980 - 244348 != -78367)
			{
				this.AI_state = "none";
				if (92814 - 512130 != -419315)
				{
					this.Yy1ceSJKXOI = Time.time;
					if (246607 - 2944 == 243663)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060051CB RID: 20939 RVA: 0x009FDCA4 File Offset: 0x009FBEA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (84044 - 181159 != -97114)
		{
		}
		for (;;)
		{
			IL_7D0:
			if (this.CXEce0Hqy3U > Time.time)
			{
				if (106842 - 376342 == -269500)
				{
					break;
				}
			}
			else
			{
				this.CXEce0Hqy3U = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (259373 - 543357 == -283984)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (113123 - 48304 == 64819)
					{
						if (253439 - 589856 != -336416)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (136643 - 324587 != -187943)
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
									if (239900 - 250036 == -10135)
									{
										goto IL_7D0;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (283983 - 314909 == -30925)
									{
										goto IL_7D0;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (52087 - 279092 != -227005)
									{
										goto IL_7D0;
									}
									bool flag = true;
									if (58317 - 319561 == -261243)
									{
										goto IL_7D0;
									}
									eRace race = this.ah8ceEg10Ci.Race;
									if (275820 - 464831 == -189010)
									{
										goto IL_7D0;
									}
									if (race == eRace.Tails)
									{
										if (230722 - 451610 != -220888)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_4A5;
										}
										if (175030 - 152830 != 22200)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (75669 - 23575 != 52094)
											{
												goto IL_7D0;
											}
											goto IL_4A5;
										}
										goto IL_3B7;
										IL_4A5:
										flag = false;
										if (35880 - 481410 != -445530)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Plants)
									{
										if (18866 - 591186 != -572320)
										{
											goto IL_7D0;
										}
										flag = false;
										if (53236 - 580196 == -526959)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (241741 - 336354 != -94613)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_543;
										}
										if (260138 - 214918 == 45221)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (297294 - 451982 != -154688)
											{
												goto IL_7D0;
											}
											goto IL_543;
										}
										goto IL_3B7;
										IL_543:
										flag = false;
										if (110500 - 100887 == 9614)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Robots)
									{
										if (293654 - 592694 == -299039)
										{
											goto IL_7D0;
										}
										flag = true;
										if (202185 - 584720 != -382535)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (17225 - 532233 == -515007)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_2D6;
										}
										if (234855 - 190394 != 44461)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_2D6;
										}
										if (294343 - 273256 == 21088)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (189038 - 133575 != 55463)
											{
												goto IL_7D0;
											}
											goto IL_2D6;
										}
										goto IL_3B7;
										IL_2D6:
										flag = false;
										if (282090 - 112034 != 170056)
										{
											goto IL_7D0;
										}
									}
									else if (race == eRace.Structure)
									{
										if (59157 - 298288 != -239131)
										{
											goto IL_7D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (1555 - 550422 == -548866)
											{
												goto IL_7D0;
											}
											flag = false;
											if (8633 - 356693 != -348060)
											{
												goto IL_7D0;
											}
										}
									}
									IL_3B7:
									if (flag)
									{
										if (195880 - 188972 != 6908)
										{
											goto IL_7D0;
										}
										if (characterControl.hp > 0)
										{
											if (4136 - 343611 == -339474)
											{
												goto IL_7D0;
											}
											if (characterControl.recieveTarget)
											{
												if (267363 - 513784 != -246421)
												{
													goto IL_7D0;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (134423 - 380275 != -245852)
													{
														goto IL_7D0;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (51520 - 566686 != -515166)
														{
															goto IL_7D0;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (196547 - 137835 == 58713)
														{
															goto IL_7D0;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (237880 - 408367 != -170487)
															{
																goto IL_7D0;
															}
															this.ah8ceEg10Ci.myAttackTarget = gameObject;
															if (202234 - 319297 != -117063)
															{
																goto IL_7D0;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (134027 - 172879 != -38852)
															{
																goto IL_7D0;
															}
															this.ah8ceEg10Ci.addHate(characterControl.ActorNr, 5);
															if (293773 - 295676 == -1902)
															{
																goto IL_7D0;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (115874 - 543485 == -427610)
															{
																goto IL_7D0;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (94118 - 138293 != -44175)
															{
																goto IL_7D0;
															}
															if (num < (float)60)
															{
																if (85852 - 362677 != -276825)
																{
																	goto IL_7D0;
																}
																if (characterControl.hp > 0)
																{
																	if (190511 - 592728 != -402217)
																	{
																		goto IL_7D0;
																	}
																	this.ah8ceEg10Ci.myAttackTarget = gameObject;
																	if (130602 - 155406 != -24804)
																	{
																		goto IL_7D0;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (159192 - 294393 != -135201)
																	{
																		goto IL_7D0;
																	}
																	this.ah8ceEg10Ci.addHate(characterControl.ActorNr, 5);
																	if (151369 - 467464 == -316094)
																	{
																		goto IL_7D0;
																	}
																}
															}
														}
														if (this.ah8ceEg10Ci.myAttackTarget)
														{
															if (26914 - 485077 == -458162)
															{
																goto IL_7D0;
															}
															this.ah8ceEg10Ci.isAlert = true;
															if (267340 - 186834 != 80506)
															{
																goto IL_7D0;
															}
															this.Yy1ceSJKXOI = Time.time;
															if (97664 - 444798 == -347133)
															{
																goto IL_7D0;
															}
														}
													}
												}
											}
										}
									}
								}
								if (194970 - 181622 != 13349)
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

	// Token: 0x060051CC RID: 20940 RVA: 0x009FE4BC File Offset: 0x009FC6BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x009FE4C0 File Offset: 0x009FC6C0
	internal static bool cDKww25rd6CFP3bAAhg7()
	{
		return true;
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x009FE4C4 File Offset: 0x009FC6C4
	internal static bool AAIXFX5rJ0frNk2IeH5Q()
	{
		return false;
	}

	// Token: 0x04005B2A RID: 23338
	private CharacterControl ah8ceEg10Ci;

	// Token: 0x04005B2B RID: 23339
	private Fay BYecePOAYk1;

	// Token: 0x04005B2C RID: 23340
	public string AI_state;

	// Token: 0x04005B2D RID: 23341
	private float Yy1ceSJKXOI;

	// Token: 0x04005B2E RID: 23342
	private float s7OceBK35ck;

	// Token: 0x04005B2F RID: 23343
	private float CXEce0Hqy3U;
}
