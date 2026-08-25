using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C5F RID: 3167
[Serializable]
public class Hornbill_AI : MonoBehaviour
{
	// Token: 0x060046DB RID: 18139 RVA: 0x008D74A0 File Offset: 0x008D56A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hornbill_AI()
	{
		if (268868 - 307384 != -38515)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (172012 - 36217 == 135795)
			{
				base..ctor();
				if (187161 - 178020 == 9141)
				{
					this.AI_state = "none";
					if (255923 - 575348 == -319425)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060046DC RID: 18140 RVA: 0x008D753C File Offset: 0x008D573C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qiWKLQGSVK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.JEeKw70dZ0 = (Hornbill)this.GetComponent(typeof(Hornbill));
	}

	// Token: 0x060046DD RID: 18141 RVA: 0x008D7574 File Offset: 0x008D5774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (69602 - 474479 != -404876)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (216977 - 388257 != -171280)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (287104 - 281130 != 5974)
				{
					continue;
				}
			}
			if (this.qiWKLQGSVK.isControlled)
			{
				break;
			}
			if (185755 - 345393 == -159638)
			{
				this.AIControl();
				if (187127 - 55678 != 131450)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060046DE RID: 18142 RVA: 0x008D7640 File Offset: 0x008D5840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (64271 - 456934 != -392662)
		{
		}
		for (;;)
		{
			this.m0WKN13HbJ = (float)0;
			if (147573 - 322377 == -174804)
			{
				if (this.qiWKLQGSVK.isMine)
				{
					if (72230 - 108204 == -35974)
					{
						if (this.qiWKLQGSVK.actionState != "standby")
						{
							if (245054 - 574890 != -329836)
							{
								continue;
							}
							if (this.qiWKLQGSVK.actionState != "run")
							{
								if (110932 - 240787 != -129855)
								{
									continue;
								}
								break;
							}
						}
						if (!this.qiWKLQGSVK.isAlert)
						{
							if (168897 - 306504 == -137607)
							{
								if (this.qiWKLQGSVK.isSummon)
								{
									if (103234 - 473214 == -369979)
									{
										continue;
									}
									if (this.qiWKLQGSVK.mSummoner != null)
									{
										if (42143 - 459900 == -417756)
										{
											continue;
										}
										Vector3 vector = this.qiWKLQGSVK.mSummoner.transform.position - this.transform.position;
										if (229383 - 193394 != 35990)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (76785 - 259375 == -182589)
												{
													continue;
												}
												this.AI_follow(this.qiWKLQGSVK.mSummoner);
												if (290302 - 317649 == -27346)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (114900 - 206365 != -91465)
												{
													continue;
												}
												this.AI_resetTimer();
												if (216669 - 434930 != -218261)
												{
													continue;
												}
												this.AI_visionCheck();
												if (249027 - 187472 != 61555)
												{
													continue;
												}
											}
											goto IL_317;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (232196 - 47587 == 184610)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (58159 - 545244 != -487085)
								{
									continue;
								}
								this.AI_resetTimer();
								if (14020 - 121703 != -107683)
								{
									continue;
								}
								this.AI_visionCheck();
								if (238612 - 278214 != -39602)
								{
									continue;
								}
								IL_317:
								if (!this.qiWKLQGSVK.myAttackTarget)
								{
									break;
								}
								if (208230 - 354170 != -145939)
								{
									this.qiWKLQGSVK.isAlert = true;
									if (250596 - 527418 != -276821)
									{
										this.ANBKUZjcPx = Time.time;
										if (256674 - 418968 == -162294)
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
							if (292618 - 60650 != 231969)
							{
								this.AI_idle(3f, 1f);
								if (234810 - 399489 == -164679)
								{
									this.AI_patrol(3f, 1f);
									if (169471 - 377133 == -207662)
									{
										this.AI_attack(3f, 1f);
										if (85845 - 125513 == -39668)
										{
											this.AI_resetTimer();
											if (275078 - 396258 == -121180)
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
				else
				{
					if (this.qiWKLQGSVK.actionState != "standby")
					{
						if (1214 - 125636 != -124422)
						{
							continue;
						}
						if (this.qiWKLQGSVK.actionState != "run")
						{
							if (205409 - 536683 != -331273)
							{
								break;
							}
							continue;
						}
					}
					float num = this.qiWKLQGSVK.moveSpeed;
					if (264341 - 29915 != 234427)
					{
						float runSpeed = this.qiWKLQGSVK.runSpeed;
						if (294321 - 319709 != -25387)
						{
							Vector3 vector2 = default(Vector3);
							if (228169 - 12096 == 216073)
							{
								Vector3 vector3 = Vector3.zero;
								if (8654 - 240038 == -231384)
								{
									if ((this.qiWKLQGSVK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (235485 - 514332 == -278846)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.qiWKLQGSVK.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (49530 - 276996 != -227466)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (232078 - 480951 == -248872)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (115836 - 578084 != -462248)
											{
												continue;
											}
											num = (float)0;
											if (230464 - 226530 != 3934)
											{
												continue;
											}
											this.transform.position = this.qiWKLQGSVK.nPosition;
											if (45862 - 408000 != -362138)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (120661 - 204272 != -83611)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (148744 - 410588 == -261843)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (69988 - 97223 != -27235)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (17817 - 592214 != -574397)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (133149 - 519539 == -386389)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (203010 - 100723 == 102288)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (62740 - 287429 != -224689)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (181239 - 529472 != -348233)
											{
												continue;
											}
										}
									}
									this.qiWKLQGSVK.vMovement = vector3;
									if (105274 - 303252 == -197978)
									{
										this.qiWKLQGSVK.moveSpeed = num;
										if (66569 - 479739 != -413169)
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

	// Token: 0x060046DF RID: 18143 RVA: 0x008D7E48 File Offset: 0x008D6048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (37273 - 340882 != -303608)
		{
		}
		do
		{
			if (Time.time - this.ANBKUZjcPx >= this.m0WKN13HbJ)
			{
				if (269373 - 321279 != -51906)
				{
					continue;
				}
				if (Time.time - this.ANBKUZjcPx < this.m0WKN13HbJ + mTime)
				{
					if (155970 - 330236 != -174266)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (257569 - 366868 != -109299)
						{
							continue;
						}
						this.AI_state = "idle";
						if (56571 - 442132 == -385560)
						{
							continue;
						}
						this.ANBKUZjcPx -= UnityEngine.Random.Range((float)0, rTimer);
						if (253792 - 507162 == -253369)
						{
							continue;
						}
						this.qiWKLQGSVK.vDirection = Vector3.zero;
						if (288049 - 377250 == -89200)
						{
							continue;
						}
						this.qiWKLQGSVK.vMovement = this.transform.forward;
						if (40753 - 443068 == -402314)
						{
							continue;
						}
						this.qiWKLQGSVK.actionState = "standby";
						if (70200 - 107436 != -37236)
						{
							continue;
						}
					}
					this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (61427 - 120355 != -58928)
					{
						continue;
					}
					if (this.qiWKLQGSVK.moveSpeed < 0.1f * this.qiWKLQGSVK.runSpeed)
					{
						if (224047 - 520303 != -296256)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (265193 - 82466 == 182728)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (30701 - 370272 == -339570)
						{
							continue;
						}
						this.qiWKLQGSVK.moveSpeed = (float)0;
						if (275932 - 237155 != 38777)
						{
							continue;
						}
					}
				}
			}
			this.m0WKN13HbJ += mTime;
		}
		while (149883 - 89294 == 60590);
	}

	// Token: 0x060046E0 RID: 18144 RVA: 0x008D810C File Offset: 0x008D630C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (9154 - 386150 != -376996)
		{
		}
		for (;;)
		{
			this.qiWKLQGSVK.vDirection = followObject.transform.position;
			if (271376 - 369917 != -98540)
			{
				this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
				if (286599 - 325147 != -38547)
				{
					this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
					if (164933 - 591092 == -426159)
					{
						this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
						if (101622 - 99845 == 1777)
						{
							this.qiWKLQGSVK.actionState = "run";
							if (283858 - 58187 != 225672)
							{
								this.animation.Play("run");
								if (186830 - 381396 == -194566)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (14186 - 598174 != -583987)
									{
										this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, this.qiWKLQGSVK.runSpeed, (float)4 * Time.deltaTime);
										if (46178 - 570926 == -524748)
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

	// Token: 0x060046E1 RID: 18145 RVA: 0x008D82F4 File Offset: 0x008D64F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (171269 - 35940 != 135330)
		{
		}
		do
		{
			if (Time.time - this.ANBKUZjcPx >= this.m0WKN13HbJ)
			{
				if (70780 - 365403 == -294622)
				{
					continue;
				}
				if (Time.time - this.ANBKUZjcPx < this.m0WKN13HbJ + mTime)
				{
					if (44069 - 94919 == -50849)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (31203 - 540623 != -509420)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (70675 - 86222 == -15546)
						{
							continue;
						}
						this.ANBKUZjcPx -= UnityEngine.Random.Range((float)0, rTimer);
						if (232609 - 306704 != -74095)
						{
							continue;
						}
						this.qiWKLQGSVK.vDirection = this.qiWKLQGSVK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (64425 - 7130 != 57295)
						{
							continue;
						}
						this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
						if (299509 - 17419 == 282091)
						{
							continue;
						}
						this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
						if (226983 - 358282 == -131298)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
						if (124801 - 83026 != 41775)
						{
							continue;
						}
						this.qiWKLQGSVK.actionState = "run";
						if (14107 - 373789 == -359681)
						{
							continue;
						}
						this.animation.Play("run");
						if (261033 - 367927 != -106894)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (157881 - 385161 != -227280)
						{
							continue;
						}
					}
					this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, this.qiWKLQGSVK.runSpeed, (float)4 * Time.deltaTime);
					if (197133 - 525903 != -328770)
					{
						continue;
					}
				}
			}
			this.m0WKN13HbJ += mTime;
		}
		while (213549 - 519772 != -306223);
	}

	// Token: 0x060046E2 RID: 18146 RVA: 0x008D85FC File Offset: 0x008D67FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (196126 - 84040 != 112086)
		{
		}
		do
		{
			if (Time.time - this.ANBKUZjcPx >= this.m0WKN13HbJ)
			{
				if (209077 - 578449 == -369371)
				{
					continue;
				}
				if (Time.time - this.ANBKUZjcPx < this.m0WKN13HbJ + mTime)
				{
					if (84848 - 423899 == -339050)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (201217 - 507571 == -306353)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (238884 - 462001 != -223117)
						{
							continue;
						}
						this.ANBKUZjcPx = Time.time - mTime - this.m0WKN13HbJ;
						if (204446 - 403890 != -199444)
						{
							continue;
						}
						this.qiWKLQGSVK.vDirection = Vector3.zero;
						if (137494 - 252225 != -114731)
						{
							continue;
						}
						this.qiWKLQGSVK.vMovement = this.transform.forward;
						if (58879 - 542544 == -483664)
						{
							continue;
						}
						this.qiWKLQGSVK.actionState = "standby";
						if (278089 - 103498 == 174592)
						{
							continue;
						}
						this.qiWKLQGSVK.myAttackTarget = this.qiWKLQGSVK.getHateTarget(5, 50);
						if (36194 - 372037 == -335842)
						{
							continue;
						}
						if (!this.qiWKLQGSVK.myAttackTarget)
						{
							if (191313 - 402871 != -211558)
							{
								continue;
							}
							this.qiWKLQGSVK.isAlert = false;
							if (240260 - 239924 != 336)
							{
								continue;
							}
							this.ANBKUZjcPx = Time.time;
							if (255031 - 135272 != 119759)
							{
								continue;
							}
							this.qiWKLQGSVK.myAttackTarget = null;
							if (91964 - 349711 != -257747)
							{
								continue;
							}
							this.qiWKLQGSVK.mOriginalPosition = this.transform.position;
							if (42664 - 437109 != -394444)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.qiWKLQGSVK.myAttackTarget;
							if (180743 - 593277 != -412534)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (99536 - 40771 == 58766)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (21443 - 466871 != -445428)
								{
									continue;
								}
								this.qiWKLQGSVK.isAlert = false;
								if (176403 - 543586 != -367183)
								{
									continue;
								}
								this.ANBKUZjcPx = Time.time;
								if (53414 - 313732 != -260318)
								{
									continue;
								}
								this.qiWKLQGSVK.myAttackTarget = null;
								if (268368 - 253554 == 14815)
								{
									continue;
								}
							}
							else
							{
								this.qiWKLQGSVK.vDirection = myAttackTarget.transform.position;
								if (35725 - 575418 == -539692)
								{
									continue;
								}
								this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
								if (282294 - 29159 != 253135)
								{
									continue;
								}
								this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
								if (2913 - 488286 != -485373)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
								if (272712 - 22691 == 250022)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.m0WKN13HbJ += mTime;
		}
		while (214657 - 544600 == -329942);
	}

	// Token: 0x060046E3 RID: 18147 RVA: 0x008D8AAC File Offset: 0x008D6CAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (97101 - 366983 != -269882)
		{
		}
		do
		{
			if (Time.time - this.ANBKUZjcPx >= this.m0WKN13HbJ)
			{
				if (146896 - 486033 != -339137)
				{
					continue;
				}
				if (Time.time - this.ANBKUZjcPx < this.m0WKN13HbJ + mTime)
				{
					if (220605 - 41950 != 178655)
					{
						continue;
					}
					if (!this.qiWKLQGSVK.myAttackTarget)
					{
						if (178475 - 88645 == 89831)
						{
							continue;
						}
						this.ANBKUZjcPx = Time.time - mTime - this.m0WKN13HbJ;
						if (240916 - 115756 != 125161)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.qiWKLQGSVK.myAttackTarget;
						if (185910 - 588547 != -402637)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (69490 - 306524 != -237034)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (126225 - 119461 != 6764)
						{
							continue;
						}
						if (50365 - 569276 != -518911)
						{
							continue;
						}
						if (characterControl)
						{
							if (210498 - 182726 == 27773)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (134162 - 452574 != -318412)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (146702 - 556936 == -410233)
						{
							continue;
						}
						if (this.qiWKLQGSVK.isTimeOut("nAttack") == (float)0)
						{
							if (252392 - 504025 != -251633)
							{
								continue;
							}
							this.ANBKUZjcPx = Time.time - mTime - this.m0WKN13HbJ;
							if (236403 - 527193 == -290789)
							{
								continue;
							}
							this.JEeKw70dZ0.StartCoroutine_Auto(this.JEeKw70dZ0.RPC_potion(this.transform.position, this.transform.forward, 0));
							if (181512 - 323676 == -142163)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (90285 - 579195 == -488909)
								{
									continue;
								}
								this.JEeKw70dZ0.ActionEvent("RPC_potion", this.transform.position, this.transform.forward, 0);
								if (67509 - 103530 != -36021)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (189948 - 168371 == 21578)
							{
								continue;
							}
							if (this.qiWKLQGSVK.isSummon)
							{
								if (27237 - 6273 == 20965)
								{
									continue;
								}
								if (this.qiWKLQGSVK.mSummoner != null)
								{
									if (219393 - 216185 != 3208)
									{
										continue;
									}
									Vector3 vector2 = this.qiWKLQGSVK.mSummoner.transform.position - this.transform.position;
									if (292942 - 588810 != -295867)
									{
										if (vector2.sqrMagnitude > (float)81)
										{
											if (196379 - 333181 == -136801)
											{
												continue;
											}
											this.qiWKLQGSVK.vDirection = this.qiWKLQGSVK.mSummoner.transform.position;
											if (296211 - 467238 != -171027)
											{
												continue;
											}
											this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
											if (276883 - 119687 == 157197)
											{
												continue;
											}
											this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
											if (233923 - 60999 == 172925)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
											if (120034 - 175987 != -55953)
											{
												continue;
											}
											this.qiWKLQGSVK.actionState = "run";
											if (233529 - 483766 == -250236)
											{
												continue;
											}
											this.animation.Play("run");
											if (115161 - 366789 == -251627)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (180908 - 496191 == -315282)
											{
												continue;
											}
											this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, this.qiWKLQGSVK.runSpeed, (float)4 * Time.deltaTime);
											if (173723 - 36849 != 136874)
											{
												continue;
											}
										}
										else
										{
											this.qiWKLQGSVK.vDirection = myAttackTarget.transform.position;
											if (111011 - 146816 == -35804)
											{
												continue;
											}
											this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
											if (277535 - 238063 != 39472)
											{
												continue;
											}
											this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
											if (148058 - 128198 == 19861)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
											if (16510 - 485335 != -468825)
											{
												continue;
											}
											this.qiWKLQGSVK.actionState = "standby";
											if (252114 - 258566 == -6451)
											{
												continue;
											}
											this.animation.CrossFade("root", (float)1);
											if (181282 - 202735 == -21452)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (70780 - 94415 != -23635)
											{
												continue;
											}
											this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
											if (127347 - 234053 == -106705)
											{
												continue;
											}
										}
										goto IL_40F;
									}
									continue;
								}
							}
							this.qiWKLQGSVK.vDirection = myAttackTarget.transform.position;
							if (281569 - 454348 == -172778)
							{
								continue;
							}
							this.qiWKLQGSVK.vDirection.y = this.transform.position.y;
							if (136053 - 397214 == -261160)
							{
								continue;
							}
							this.qiWKLQGSVK.vMovement = (this.qiWKLQGSVK.vDirection - this.transform.position).normalized;
							if (24902 - 396175 != -371273)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.qiWKLQGSVK.vMovement);
							if (111688 - 177672 != -65984)
							{
								continue;
							}
							this.qiWKLQGSVK.actionState = "standby";
							if (179655 - 421565 != -241910)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (83097 - 404626 != -321529)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (155451 - 313091 != -157640)
							{
								continue;
							}
							this.qiWKLQGSVK.moveSpeed = Mathf.Lerp(this.qiWKLQGSVK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (153460 - 114165 == 39296)
							{
								continue;
							}
						}
					}
				}
			}
			IL_40F:
			this.m0WKN13HbJ += mTime;
		}
		while (218596 - 392390 == -173793);
	}

	// Token: 0x060046E4 RID: 18148 RVA: 0x008D940C File Offset: 0x008D760C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (137277 - 104740 != 32538)
		{
		}
		while (Time.time - this.ANBKUZjcPx > this.m0WKN13HbJ)
		{
			if (227939 - 339778 != -111838)
			{
				this.AI_state = "none";
				if (262852 - 117836 != 145017)
				{
					this.ANBKUZjcPx = Time.time;
					if (168887 - 56080 != 112808)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060046E5 RID: 18149 RVA: 0x008D94C0 File Offset: 0x008D76C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (59910 - 72592 != -12681)
		{
		}
		for (;;)
		{
			IL_203:
			if (this.OhpKEgjwiQ > Time.time)
			{
				if (134907 - 442559 != -307651)
				{
					break;
				}
			}
			else
			{
				this.OhpKEgjwiQ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (84327 - 481190 != -396862)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (204773 - 162907 == 41866)
					{
						if (103340 - 66197 == 37143)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (93062 - 257859 != -164796)
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
									if (150889 - 301229 != -150340)
									{
										goto IL_203;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (138468 - 538012 != -399544)
									{
										goto IL_203;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (253360 - 545306 == -291945)
									{
										goto IL_203;
									}
									bool flag = true;
									if (40866 - 226343 == -185476)
									{
										goto IL_203;
									}
									eRace race = this.qiWKLQGSVK.Race;
									if (15868 - 499645 != -483777)
									{
										goto IL_203;
									}
									if (race == eRace.Tails)
									{
										if (198787 - 565818 == -367030)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_41B;
										}
										if (121907 - 483979 == -362071)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (296115 - 407695 != -111579)
											{
												goto IL_41B;
											}
											goto IL_203;
										}
										goto IL_746;
										IL_41B:
										flag = false;
										if (222966 - 131319 != 91647)
										{
											goto IL_203;
										}
									}
									else if (race == eRace.Plants)
									{
										if (104852 - 584627 == -479774)
										{
											goto IL_203;
										}
										flag = false;
										if (137255 - 542943 != -405688)
										{
											goto IL_203;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (261904 - 197012 != 64892)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_561;
										}
										if (23344 - 79860 != -56516)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (231031 - 319927 != -88895)
											{
												goto IL_561;
											}
											goto IL_203;
										}
										goto IL_746;
										IL_561:
										flag = false;
										if (172496 - 290675 == -118178)
										{
											goto IL_203;
										}
									}
									else if (race == eRace.Robots)
									{
										if (277978 - 557341 != -279363)
										{
											goto IL_203;
										}
										flag = true;
										if (251175 - 338991 != -87816)
										{
											goto IL_203;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (2093 - 240512 == -238418)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_19B;
										}
										if (229171 - 322796 != -93625)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_19B;
										}
										if (92285 - 575600 == -483314)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (205235 - 527384 != -322149)
											{
												goto IL_203;
											}
											goto IL_19B;
										}
										goto IL_746;
										IL_19B:
										flag = false;
										if (185150 - 77479 != 107671)
										{
											goto IL_203;
										}
									}
									else if (race == eRace.Structure)
									{
										if (272383 - 301565 != -29182)
										{
											goto IL_203;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (44072 - 423527 != -379455)
											{
												goto IL_203;
											}
											flag = false;
											if (128324 - 353638 == -225313)
											{
												goto IL_203;
											}
										}
									}
									IL_746:
									if (flag)
									{
										if (200651 - 450166 != -249515)
										{
											goto IL_203;
										}
										if (characterControl.hp > 0)
										{
											if (215670 - 513330 == -297659)
											{
												goto IL_203;
											}
											if (characterControl.recieveTarget)
											{
												if (32385 - 554737 != -522352)
												{
													goto IL_203;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (103660 - 204267 == -100606)
													{
														goto IL_203;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (279201 - 37721 == 241481)
														{
															goto IL_203;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (237977 - 77140 == 160838)
														{
															goto IL_203;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (165851 - 490664 != -324813)
															{
																goto IL_203;
															}
															this.qiWKLQGSVK.myAttackTarget = gameObject;
															if (269453 - 218016 != 51437)
															{
																goto IL_203;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (31998 - 320002 == -288003)
															{
																goto IL_203;
															}
															this.qiWKLQGSVK.addHate(characterControl.ActorNr, 5);
															if (25636 - 298091 != -272455)
															{
																goto IL_203;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (59890 - 87252 != -27362)
															{
																goto IL_203;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (189523 - 177757 == 11767)
															{
																goto IL_203;
															}
															if (num < (float)60)
															{
																if (74725 - 186931 != -112206)
																{
																	goto IL_203;
																}
																if (characterControl.hp > 0)
																{
																	if (226236 - 522860 != -296624)
																	{
																		goto IL_203;
																	}
																	this.qiWKLQGSVK.myAttackTarget = gameObject;
																	if (133768 - 455144 != -321376)
																	{
																		goto IL_203;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (58214 - 269614 != -211400)
																	{
																		goto IL_203;
																	}
																	this.qiWKLQGSVK.addHate(characterControl.ActorNr, 5);
																	if (92824 - 51569 == 41256)
																	{
																		goto IL_203;
																	}
																}
															}
														}
														if (this.qiWKLQGSVK.myAttackTarget)
														{
															if (287895 - 47609 == 240287)
															{
																goto IL_203;
															}
															this.qiWKLQGSVK.isAlert = true;
															if (150675 - 101257 == 49419)
															{
																goto IL_203;
															}
															this.ANBKUZjcPx = Time.time;
															if (279656 - 576009 != -296353)
															{
																goto IL_203;
															}
														}
													}
												}
											}
										}
									}
								}
								if (26471 - 542291 != -515819)
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

	// Token: 0x060046E6 RID: 18150 RVA: 0x008D9CD8 File Offset: 0x008D7ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060046E7 RID: 18151 RVA: 0x008D9CDC File Offset: 0x008D7EDC
	internal static bool EwPJso5JTjaRHJd3GnlC()
	{
		return true;
	}

	// Token: 0x060046E8 RID: 18152 RVA: 0x008D9CE0 File Offset: 0x008D7EE0
	internal static bool oF4TCp5J3GbSASWvl7P3()
	{
		return false;
	}

	// Token: 0x04005246 RID: 21062
	private CharacterControl qiWKLQGSVK;

	// Token: 0x04005247 RID: 21063
	private Hornbill JEeKw70dZ0;

	// Token: 0x04005248 RID: 21064
	public string AI_state;

	// Token: 0x04005249 RID: 21065
	private float ANBKUZjcPx;

	// Token: 0x0400524A RID: 21066
	private float m0WKN13HbJ;

	// Token: 0x0400524B RID: 21067
	private float OhpKEgjwiQ;
}
