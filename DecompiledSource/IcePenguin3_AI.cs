using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C90 RID: 3216
[Serializable]
public class IcePenguin3_AI : MonoBehaviour
{
	// Token: 0x0600480B RID: 18443 RVA: 0x008F411C File Offset: 0x008F231C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguin3_AI()
	{
		if (95671 - 249656 != -153985)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (281729 - 443598 != -161868)
			{
				base..ctor();
				if (102652 - 528649 == -425997)
				{
					this.AI_state = "none";
					if (55854 - 445953 != -390098)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x008F41B8 File Offset: 0x008F23B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qNRzIhFUFw = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.WXqzJVd2UA = (IcePenguin3)this.GetComponent(typeof(IcePenguin3));
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x008F41F0 File Offset: 0x008F23F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (276754 - 82371 != 194383)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (125642 - 471217 != -345575)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (51342 - 581238 != -529896)
				{
					continue;
				}
			}
			if (this.qNRzIhFUFw.isControlled)
			{
				break;
			}
			if (224740 - 549309 != -324568)
			{
				this.AIControl();
				if (143038 - 596797 == -453759)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x008F42BC File Offset: 0x008F24BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (242788 - 107028 != 135760)
		{
		}
		for (;;)
		{
			this.KSDztuUg8u = (float)0;
			if (266948 - 158291 == 108657)
			{
				if (this.qNRzIhFUFw.isMine)
				{
					if (41336 - 370705 != -329368)
					{
						if (this.qNRzIhFUFw.actionState != "standby")
						{
							if (224087 - 407782 != -183695)
							{
								continue;
							}
							if (this.qNRzIhFUFw.actionState != "run")
							{
								if (158325 - 591689 != -433363)
								{
									break;
								}
								continue;
							}
						}
						if (!this.qNRzIhFUFw.isAlert)
						{
							if (122147 - 133605 == -11458)
							{
								this.AI_idle(3f, 1f);
								if (149722 - 478584 != -328861)
								{
									this.AI_patrol(2f, 1f);
									if (65122 - 193312 == -128190)
									{
										this.AI_resetTimer();
										if (55882 - 322604 != -266721)
										{
											this.AI_visionCheck();
											if (114453 - 121374 != -6920)
											{
												if (!this.qNRzIhFUFw.myAttackTarget)
												{
													break;
												}
												if (49350 - 68004 == -18654)
												{
													this.qNRzIhFUFw.isAlert = true;
													if (267660 - 101038 != 166623)
													{
														this.ndoz6Va8T1 = Time.time;
														if (108402 - 307223 != -198820)
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
							if (176583 - 481154 != -304570)
							{
								this.AI_idle(3f, 2f);
								if (155907 - 252052 == -96145)
								{
									this.AI_attack(10f, (float)0);
									if (123594 - 447085 == -323491)
									{
										this.AI_resetTimer();
										if (144958 - 408892 == -263934)
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
					if (this.qNRzIhFUFw.actionState != "standby")
					{
						if (199418 - 163838 == 35581)
						{
							continue;
						}
						if (this.qNRzIhFUFw.actionState != "run")
						{
							if (84472 - 447676 != -363203)
							{
								break;
							}
							continue;
						}
					}
					float num = this.qNRzIhFUFw.moveSpeed;
					if (299688 - 69684 == 230004)
					{
						float runSpeed = this.qNRzIhFUFw.runSpeed;
						if (170718 - 336066 == -165348)
						{
							Vector3 vector = default(Vector3);
							if (293022 - 62251 != 230772)
							{
								Vector3 vector2 = Vector3.zero;
								if (104940 - 592818 == -487878)
								{
									if ((this.qNRzIhFUFw.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (254520 - 538357 != -283837)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.qNRzIhFUFw.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (117527 - 138622 == -21094)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (7185 - 121296 == -114110)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (211926 - 442833 == -230906)
											{
												continue;
											}
											num = (float)0;
											if (243097 - 437801 != -194704)
											{
												continue;
											}
											this.transform.position = this.qNRzIhFUFw.nPosition;
											if (253843 - 369397 != -115554)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (244192 - 560636 == -316443)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (163260 - 217709 != -54449)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (251349 - 507619 == -256269)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (211081 - 305609 != -94528)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (75368 - 33854 != 41514)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (51878 - 547968 != -496090)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (246790 - 501636 == -254845)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69804 - 94625 == -24820)
											{
												continue;
											}
										}
									}
									this.qNRzIhFUFw.vMovement = vector2;
									if (258097 - 260256 == -2159)
									{
										this.qNRzIhFUFw.moveSpeed = num;
										if (21795 - 149748 == -127953)
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

	// Token: 0x0600480F RID: 18447 RVA: 0x008F4934 File Offset: 0x008F2B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (158230 - 224127 != -65897)
		{
		}
		do
		{
			if (Time.time - this.ndoz6Va8T1 >= this.KSDztuUg8u)
			{
				if (34215 - 424621 == -390405)
				{
					continue;
				}
				if (Time.time - this.ndoz6Va8T1 < this.KSDztuUg8u + mTime)
				{
					if (296939 - 273727 != 23212)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (145374 - 367157 != -221783)
						{
							continue;
						}
						this.AI_state = "idle";
						if (261530 - 482956 != -221426)
						{
							continue;
						}
						this.ndoz6Va8T1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (163961 - 125642 == 38320)
						{
							continue;
						}
						this.qNRzIhFUFw.vDirection = Vector3.zero;
						if (44897 - 531454 != -486557)
						{
							continue;
						}
						this.qNRzIhFUFw.vMovement = this.transform.forward;
						if (104856 - 4071 == 100786)
						{
							continue;
						}
						this.qNRzIhFUFw.actionState = "standby";
						if (34810 - 353912 != -319102)
						{
							continue;
						}
					}
					this.qNRzIhFUFw.moveSpeed = Mathf.Lerp(this.qNRzIhFUFw.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (50495 - 344867 == -294371)
					{
						continue;
					}
					if (this.qNRzIhFUFw.moveSpeed < 0.1f * this.qNRzIhFUFw.runSpeed)
					{
						if (16031 - 341096 == -325064)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (128387 - 42186 == 86202)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (13448 - 44925 != -31477)
						{
							continue;
						}
						this.qNRzIhFUFw.moveSpeed = (float)0;
						if (298870 - 138422 != 160448)
						{
							continue;
						}
					}
				}
			}
			this.KSDztuUg8u += mTime;
		}
		while (99717 - 526917 == -427199);
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x008F4BF8 File Offset: 0x008F2DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (134176 - 79057 != 55119)
		{
		}
		do
		{
			if (Time.time - this.ndoz6Va8T1 >= this.KSDztuUg8u)
			{
				if (111127 - 498625 == -387497)
				{
					continue;
				}
				if (Time.time - this.ndoz6Va8T1 < this.KSDztuUg8u + mTime)
				{
					if (18209 - 566441 == -548231)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (241433 - 335267 != -93834)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (123238 - 353451 == -230212)
						{
							continue;
						}
						this.ndoz6Va8T1 -= UnityEngine.Random.Range((float)0, rTimer);
						if (121598 - 151274 == -29675)
						{
							continue;
						}
						this.qNRzIhFUFw.vDirection = this.qNRzIhFUFw.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (284635 - 323325 != -38690)
						{
							continue;
						}
						this.qNRzIhFUFw.vDirection.y = this.transform.position.y;
						if (255872 - 122873 != 132999)
						{
							continue;
						}
						this.qNRzIhFUFw.vMovement = (this.qNRzIhFUFw.vDirection - this.transform.position).normalized;
						if (90402 - 199541 == -109138)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qNRzIhFUFw.vMovement);
						if (215362 - 519725 == -304362)
						{
							continue;
						}
						this.qNRzIhFUFw.actionState = "run";
						if (233671 - 163705 != 69966)
						{
							continue;
						}
						this.animation.Play("run");
						if (128621 - 359602 == -230980)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (34582 - 297533 == -262950)
						{
							continue;
						}
					}
					this.qNRzIhFUFw.moveSpeed = Mathf.Lerp(this.qNRzIhFUFw.moveSpeed, this.qNRzIhFUFw.runSpeed, (float)4 * Time.deltaTime);
					if (749 - 26216 != -25467)
					{
						continue;
					}
				}
			}
			this.KSDztuUg8u += mTime;
		}
		while (121265 - 285038 != -163773);
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x008F4F00 File Offset: 0x008F3100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (184216 - 101652 != 82565)
		{
		}
		do
		{
			if (Time.time - this.ndoz6Va8T1 >= this.KSDztuUg8u)
			{
				if (278928 - 535173 != -256245)
				{
					continue;
				}
				if (Time.time - this.ndoz6Va8T1 < this.KSDztuUg8u + mTime)
				{
					if (107702 - 345374 == -237671)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (108938 - 164704 != -55766)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (155185 - 280810 == -125624)
						{
							continue;
						}
						this.ndoz6Va8T1 = Time.time - mTime - this.KSDztuUg8u;
						if (140951 - 364119 == -223167)
						{
							continue;
						}
						this.qNRzIhFUFw.vDirection = Vector3.zero;
						if (218992 - 584803 != -365811)
						{
							continue;
						}
						this.qNRzIhFUFw.vMovement = this.transform.forward;
						if (89739 - 25819 != 63920)
						{
							continue;
						}
						this.qNRzIhFUFw.actionState = "standby";
						if (168289 - 216693 != -48404)
						{
							continue;
						}
						this.qNRzIhFUFw.myAttackTarget = this.qNRzIhFUFw.getHateClosestTarget(32);
						if (110445 - 24294 == 86152)
						{
							continue;
						}
						if (!this.qNRzIhFUFw.myAttackTarget)
						{
							if (60749 - 352611 != -291862)
							{
								continue;
							}
							this.qNRzIhFUFw.isAlert = false;
							if (101099 - 496756 == -395656)
							{
								continue;
							}
							this.ndoz6Va8T1 = Time.time;
							if (58047 - 180667 != -122620)
							{
								continue;
							}
							this.qNRzIhFUFw.myAttackTarget = null;
							if (174178 - 526777 == -352598)
							{
								continue;
							}
							this.qNRzIhFUFw.mOriginalPosition = this.transform.position;
							if (6627 - 373280 != -366652)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.qNRzIhFUFw.myAttackTarget;
							if (221725 - 317747 == -96021)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (229407 - 513362 == -283954)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (192445 - 269426 != -76981)
								{
									continue;
								}
								this.qNRzIhFUFw.isAlert = false;
								if (17144 - 248265 != -231121)
								{
									continue;
								}
								this.ndoz6Va8T1 = Time.time;
								if (97218 - 200593 != -103375)
								{
									continue;
								}
								this.qNRzIhFUFw.myAttackTarget = null;
								if (94613 - 406965 == -312351)
								{
									continue;
								}
							}
							else
							{
								this.qNRzIhFUFw.vDirection = myAttackTarget.transform.position;
								if (167601 - 136920 == 30682)
								{
									continue;
								}
								this.qNRzIhFUFw.vDirection.y = this.transform.position.y;
								if (117119 - 462392 != -345273)
								{
									continue;
								}
								this.qNRzIhFUFw.vMovement = (this.qNRzIhFUFw.vDirection - this.transform.position).normalized;
								if (20934 - 586674 != -565740)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.qNRzIhFUFw.vMovement);
								if (212077 - 178827 == 33251)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.KSDztuUg8u += mTime;
		}
		while (35380 - 230678 == -195297);
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x008F53B0 File Offset: 0x008F35B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (136359 - 50713 != 85647)
		{
		}
		do
		{
			if (Time.time - this.ndoz6Va8T1 >= this.KSDztuUg8u)
			{
				if (129528 - 587346 != -457818)
				{
					continue;
				}
				if (Time.time - this.ndoz6Va8T1 < this.KSDztuUg8u + mTime)
				{
					if (176998 - 468555 != -291557)
					{
						continue;
					}
					if (!this.qNRzIhFUFw.myAttackTarget)
					{
						if (216565 - 229168 != -12603)
						{
							continue;
						}
						this.ndoz6Va8T1 = Time.time - mTime - this.KSDztuUg8u;
						if (288530 - 82119 != 206411)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.qNRzIhFUFw.myAttackTarget;
						if (12392 - 172322 == -159929)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (98710 - 468124 == -369413)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (280099 - 242296 != 37803)
						{
							continue;
						}
						int tID = 0;
						if (112971 - 399325 == -286353)
						{
							continue;
						}
						if (characterControl)
						{
							if (128235 - 139354 != -11119)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (293940 - 590910 != -296970)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (3704 - 209556 == -205851)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (35115 - 204648 == -169532)
							{
								continue;
							}
							if (this.qNRzIhFUFw.sp > 35)
							{
								if (96959 - 579617 == -482657)
								{
									continue;
								}
								if (this.qNRzIhFUFw.isTimeOut("cAttack") == (float)0)
								{
									if (200332 - 41595 == 158738)
									{
										continue;
									}
									this.ndoz6Va8T1 = Time.time - mTime - this.KSDztuUg8u;
									if (100077 - 237210 != -137133)
									{
										continue;
									}
									this.WXqzJVd2UA.StartCoroutine_Auto(this.WXqzJVd2UA.RPC_cAttack(this.transform.position, vector.normalized, 0));
									if (197161 - 483984 != -286823)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (216815 - 538706 == -321890)
										{
											continue;
										}
										this.WXqzJVd2UA.ActionEvent("RPC_cAttack", this.transform.position, vector.normalized, 0);
										if (284626 - 248747 == 35880)
										{
											continue;
										}
									}
									goto IL_2C5;
								}
							}
						}
						if (num < (float)2)
						{
							if (243393 - 117091 == 126303)
							{
								continue;
							}
							if (this.qNRzIhFUFw.isTimeOut("nAttack") == (float)0)
							{
								if (16032 - 193250 == -177217)
								{
									continue;
								}
								this.ndoz6Va8T1 = Time.time - mTime - this.KSDztuUg8u;
								if (270417 - 360759 != -90342)
								{
									continue;
								}
								this.WXqzJVd2UA.StartCoroutine_Auto(this.WXqzJVd2UA.RPC_nAttack(this.transform.position, vector.normalized, 0));
								if (83331 - 405949 != -322617)
								{
									if (PhotonClient.IsInitialized())
									{
										if (123988 - 564502 == -440513)
										{
											continue;
										}
										this.WXqzJVd2UA.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, 0);
										if (274731 - 560209 != -285478)
										{
											continue;
										}
									}
									goto IL_2C5;
								}
								continue;
							}
						}
						if (num < (float)32)
						{
							if (184621 - 580161 != -395540)
							{
								continue;
							}
							if (this.qNRzIhFUFw.hp < this.qNRzIhFUFw.mhp)
							{
								if (227980 - 13951 == 214030)
								{
									continue;
								}
								if (this.qNRzIhFUFw.isTimeOut("snowman") == (float)0)
								{
									if (219190 - 78365 != 140825)
									{
										continue;
									}
									this.ndoz6Va8T1 = Time.time - mTime - this.KSDztuUg8u;
									if (197594 - 163539 != 34055)
									{
										continue;
									}
									this.WXqzJVd2UA.StartCoroutine_Auto(this.WXqzJVd2UA.RPC_snowman(this.transform.position, vector.normalized, tID));
									if (108167 - 68976 != 39192)
									{
										if (PhotonClient.IsInitialized())
										{
											if (273221 - 509286 == -236064)
											{
												continue;
											}
											this.WXqzJVd2UA.ActionEvent("RPC_snowman", this.transform.position, vector.normalized, tID);
											if (229145 - 63980 != 165165)
											{
												continue;
											}
										}
										goto IL_2C5;
									}
									continue;
								}
							}
						}
						if (num > (float)1)
						{
							if (10641 - 316789 != -306148)
							{
								continue;
							}
							this.AI_state = "attack";
							if (104127 - 576517 != -472390)
							{
								continue;
							}
							this.qNRzIhFUFw.vDirection = myAttackTarget.transform.position;
							if (89591 - 455313 == -365721)
							{
								continue;
							}
							this.qNRzIhFUFw.vDirection.y = this.transform.position.y;
							if (197866 - 282052 != -84186)
							{
								continue;
							}
							this.qNRzIhFUFw.vMovement = (this.qNRzIhFUFw.vDirection - this.transform.position).normalized;
							if (268395 - 322895 != -54500)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.qNRzIhFUFw.vMovement);
							if (90808 - 356240 == -265431)
							{
								continue;
							}
							this.qNRzIhFUFw.actionState = "run";
							if (164699 - 100371 == 64329)
							{
								continue;
							}
							this.animation.Play("run");
							if (32208 - 487115 == -454906)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (273655 - 107395 == 166261)
							{
								continue;
							}
							this.qNRzIhFUFw.moveSpeed = Mathf.Lerp(this.qNRzIhFUFw.moveSpeed, this.qNRzIhFUFw.runSpeed, (float)4 * Time.deltaTime);
							if (251757 - 57365 == 194393)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (27542 - 247979 != -220437)
							{
								continue;
							}
							this.qNRzIhFUFw.vDirection = this.transform.forward;
							if (17520 - 70776 != -53256)
							{
								continue;
							}
							this.qNRzIhFUFw.vMovement = this.transform.forward;
							if (272564 - 290791 == -18226)
							{
								continue;
							}
							this.qNRzIhFUFw.actionState = "standby";
							if (204429 - 567535 != -363106)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (103935 - 241880 == -137944)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (285053 - 82806 != 202247)
							{
								continue;
							}
							this.qNRzIhFUFw.moveSpeed = Mathf.Lerp(this.qNRzIhFUFw.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (72096 - 134114 != -62018)
							{
								continue;
							}
						}
					}
				}
			}
			IL_2C5:
			this.KSDztuUg8u += mTime;
		}
		while (50260 - 134234 != -83974);
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x008F5D28 File Offset: 0x008F3F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (174250 - 591862 != -417612)
		{
		}
		while (Time.time - this.ndoz6Va8T1 > this.KSDztuUg8u)
		{
			if (287968 - 556606 != -268637)
			{
				this.AI_state = "none";
				if (91490 - 238397 != -146906)
				{
					this.ndoz6Va8T1 = Time.time;
					if (141205 - 387724 != -246518)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x008F5DDC File Offset: 0x008F3FDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (271735 - 136464 != 135272)
		{
		}
		for (;;)
		{
			IL_744:
			if (this.NPnzXknwO8 + (float)1 > Time.time)
			{
				if (130494 - 307447 != -176952)
				{
					break;
				}
			}
			else
			{
				this.NPnzXknwO8 = Time.time;
				if (254158 - 228802 != 25357)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (27043 - 456526 == -429483)
					{
						if (158530 - 30684 != 127847)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (129631 - 492641 == -363010)
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
									if (38491 - 441071 == -402579)
									{
										goto IL_744;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (116600 - 315103 != -198503)
									{
										goto IL_744;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (252585 - 173727 != 78858)
									{
										goto IL_744;
									}
									bool flag = true;
									if (280640 - 245917 == 34724)
									{
										goto IL_744;
									}
									Vector3 position = this.transform.position;
									if (119578 - 221803 != -102225)
									{
										goto IL_744;
									}
									if (Mathf.Abs(position.y - gameObject.transform.position.y) > (float)12)
									{
										if (98356 - 243336 == -144979)
										{
											goto IL_744;
										}
										flag = false;
										if (159481 - 396691 == -237209)
										{
											goto IL_744;
										}
									}
									else
									{
										eRace race = this.qNRzIhFUFw.Race;
										if (156776 - 426954 == -270177)
										{
											goto IL_744;
										}
										if (race == eRace.Tails)
										{
											if (143969 - 444549 == -300579)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_518;
											}
											if (123356 - 467263 == -343906)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (210128 - 467731 != -257602)
												{
													goto IL_518;
												}
												goto IL_744;
											}
											goto IL_2F7;
											IL_518:
											flag = false;
											if (246955 - 57754 != 189201)
											{
												goto IL_744;
											}
										}
										else if (race == eRace.Plants)
										{
											if (216715 - 325133 == -108417)
											{
												goto IL_744;
											}
											flag = false;
											if (274493 - 78436 != 196057)
											{
												goto IL_744;
											}
										}
										else if (race == eRace.Bugs)
										{
											if (292420 - 568774 == -276353)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Elementals)
											{
												goto IL_702;
											}
											if (28916 - 375726 == -346809)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Robots)
											{
												if (182339 - 536635 != -354295)
												{
													goto IL_702;
												}
												goto IL_744;
											}
											goto IL_2F7;
											IL_702:
											flag = false;
											if (234638 - 353304 == -118665)
											{
												goto IL_744;
											}
										}
										else if (race == eRace.Robots)
										{
											if (187809 - 385046 != -197237)
											{
												goto IL_744;
											}
											flag = true;
											if (210026 - 37040 != 172986)
											{
												goto IL_744;
											}
										}
										else if (race == eRace.Elementals)
										{
											if (1667 - 288840 != -287173)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Plants)
											{
												goto IL_47A;
											}
											if (284813 - 344530 == -59716)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Bugs)
											{
												goto IL_47A;
											}
											if (194240 - 12195 == 182046)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Structure)
											{
												if (66828 - 373834 != -307005)
												{
													goto IL_47A;
												}
												goto IL_744;
											}
											goto IL_2F7;
											IL_47A:
											flag = false;
											if (150687 - 334327 == -183639)
											{
												goto IL_744;
											}
										}
										else if (race == eRace.Structure)
										{
											if (131431 - 152105 == -20673)
											{
												goto IL_744;
											}
											if (characterControl.Race == eRace.Plants)
											{
												if (7883 - 176509 != -168626)
												{
													goto IL_744;
												}
												flag = false;
												if (96104 - 312826 == -216721)
												{
													goto IL_744;
												}
											}
										}
									}
									IL_2F7:
									if (flag)
									{
										if (27333 - 204795 != -177462)
										{
											goto IL_744;
										}
										if (characterControl.hp > 0)
										{
											if (250865 - 206859 == 44007)
											{
												goto IL_744;
											}
											if (characterControl.recieveTarget)
											{
												if (49244 - 258309 == -209064)
												{
													goto IL_744;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (10491 - 34150 == -23658)
													{
														goto IL_744;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (1609 - 355249 != -353640)
														{
															goto IL_744;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (244092 - 107398 == 136695)
														{
															goto IL_744;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (38269 - 390609 == -352339)
															{
																goto IL_744;
															}
															this.qNRzIhFUFw.isAlert = true;
															if (124243 - 25670 == 98574)
															{
																goto IL_744;
															}
															this.ndoz6Va8T1 = Time.time;
															if (253532 - 359698 != -106166)
															{
																goto IL_744;
															}
															this.qNRzIhFUFw.myAttackTarget = gameObject;
															if (60151 - 83613 == -23461)
															{
																goto IL_744;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (168077 - 65947 == 102131)
															{
																goto IL_744;
															}
															this.qNRzIhFUFw.addHate(characterControl.ActorNr, 5);
															if (59911 - 514197 == -454285)
															{
																goto IL_744;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (151170 - 178953 != -27783)
															{
																goto IL_744;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (294791 - 314658 != -19867)
															{
																goto IL_744;
															}
															if (num < (float)60)
															{
																if (167833 - 17464 == 150370)
																{
																	goto IL_744;
																}
																if (characterControl.hp > 0)
																{
																	if (12097 - 138471 != -126374)
																	{
																		goto IL_744;
																	}
																	this.qNRzIhFUFw.isAlert = true;
																	if (252696 - 176936 != 75760)
																	{
																		goto IL_744;
																	}
																	this.ndoz6Va8T1 = Time.time;
																	if (181565 - 224565 != -43000)
																	{
																		goto IL_744;
																	}
																	this.qNRzIhFUFw.myAttackTarget = gameObject;
																	if (172229 - 273526 != -101297)
																	{
																		goto IL_744;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (17300 - 215976 != -198676)
																	{
																		goto IL_744;
																	}
																	this.qNRzIhFUFw.addHate(characterControl.ActorNr, 5);
																	if (33835 - 20300 != 13535)
																	{
																		goto IL_744;
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
								if (222007 - 218912 != 3096)
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

	// Token: 0x06004815 RID: 18453 RVA: 0x008F6690 File Offset: 0x008F4890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004816 RID: 18454 RVA: 0x008F6694 File Offset: 0x008F4894
	internal static bool Ks1u2B5Dq6GraJvpKX9H()
	{
		return true;
	}

	// Token: 0x06004817 RID: 18455 RVA: 0x008F6698 File Offset: 0x008F4898
	internal static bool k2sOxw5D7DDf5njZgViU()
	{
		return false;
	}

	// Token: 0x04005316 RID: 21270
	private CharacterControl qNRzIhFUFw;

	// Token: 0x04005317 RID: 21271
	private IcePenguin3 WXqzJVd2UA;

	// Token: 0x04005318 RID: 21272
	public string AI_state;

	// Token: 0x04005319 RID: 21273
	private float ndoz6Va8T1;

	// Token: 0x0400531A RID: 21274
	private float KSDztuUg8u;

	// Token: 0x0400531B RID: 21275
	private float NPnzXknwO8;
}
