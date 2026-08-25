using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C19 RID: 3097
[Serializable]
public class Duck_AI : MonoBehaviour
{
	// Token: 0x0600453D RID: 17725 RVA: 0x008AC960 File Offset: 0x008AAB60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Duck_AI()
	{
		if (113152 - 148922 != -35769)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (275336 - 599593 == -324257)
			{
				base..ctor();
				if (142366 - 114363 == 28003)
				{
					this.AI_state = "none";
					if (109364 - 466631 != -357266)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600453E RID: 17726 RVA: 0x008AC9FC File Offset: 0x008AABFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ryNhjrYx7U = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.VaBhoxCRLa = (Carron)this.GetComponent(typeof(Carron));
	}

	// Token: 0x0600453F RID: 17727 RVA: 0x008ACA34 File Offset: 0x008AAC34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (132789 - 538421 != -405631)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (137443 - 311793 != -174350)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (235086 - 574869 != -339783)
				{
					continue;
				}
			}
			if (this.ryNhjrYx7U.isControlled)
			{
				break;
			}
			if (253894 - 476027 != -222132)
			{
				this.AIControl();
				if (279228 - 279933 != -704)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004540 RID: 17728 RVA: 0x008ACB00 File Offset: 0x008AAD00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (64153 - 595552 != -531398)
		{
		}
		for (;;)
		{
			this.PgshFPxmEG = (float)0;
			if (209074 - 278596 == -69522)
			{
				if (this.ryNhjrYx7U.isMine)
				{
					if (237002 - 116505 != 120498)
					{
						if (this.ryNhjrYx7U.actionState != "standby")
						{
							if (219989 - 370647 != -150658)
							{
								continue;
							}
							if (this.ryNhjrYx7U.actionState != "run")
							{
								if (126543 - 61676 != 64868)
								{
									break;
								}
								continue;
							}
						}
						if (!this.ryNhjrYx7U.isAlert)
						{
							if (274406 - 220793 == 53613)
							{
								if (!this.ryNhjrYx7U.isSummon)
								{
									goto IL_57A;
								}
								if (267567 - 165903 != 101664)
								{
									continue;
								}
								if (!(this.ryNhjrYx7U.mSummoner != null))
								{
									goto IL_57A;
								}
								if (184738 - 525597 != -340859)
								{
									continue;
								}
								Vector3 vector = this.ryNhjrYx7U.mSummoner.transform.position - this.transform.position;
								if (53766 - 347457 != -293691)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (105943 - 293716 == -187772)
									{
										continue;
									}
									this.AI_follow(this.ryNhjrYx7U.mSummoner);
									if (71874 - 212254 == -140379)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (249648 - 155405 != 94243)
									{
										continue;
									}
									this.AI_resetTimer();
									if (142719 - 546283 == -403563)
									{
										continue;
									}
									this.AI_visionCheck();
									if (161668 - 444640 != -282972)
									{
										continue;
									}
								}
								IL_462:
								if (!this.ryNhjrYx7U.myAttackTarget)
								{
									break;
								}
								if (213848 - 163147 == 50702)
								{
									continue;
								}
								this.ryNhjrYx7U.isAlert = true;
								if (23988 - 294358 == -270369)
								{
									continue;
								}
								this.IgqhkSDV9c = Time.time;
								if (151844 - 201826 != -49982)
								{
									continue;
								}
								break;
								IL_57A:
								this.AI_idle(3f, 1f);
								if (178246 - 431830 == -253584)
								{
									this.AI_patrol(1f, 0.25f);
									if (65551 - 290016 == -224465)
									{
										this.AI_resetTimer();
										if (17566 - 434981 != -417414)
										{
											this.AI_visionCheck();
											if (220061 - 208036 != 12026)
											{
												goto IL_462;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (220115 - 403249 == -183134)
							{
								this.AI_idle(3f, 1f);
								if (10344 - 48950 != -38605)
								{
									this.AI_attack(10f, (float)0);
									if (145711 - 545579 == -399868)
									{
										this.AI_resetTimer();
										if (101775 - 345426 == -243651)
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
					if (this.ryNhjrYx7U.actionState != "standby")
					{
						if (289321 - 244982 == 44340)
						{
							continue;
						}
						if (this.ryNhjrYx7U.actionState != "run")
						{
							if (86577 - 392464 != -305887)
							{
								continue;
							}
							break;
						}
					}
					float num = this.ryNhjrYx7U.moveSpeed;
					if (86799 - 24571 == 62228)
					{
						float runSpeed = this.ryNhjrYx7U.runSpeed;
						if (85213 - 336217 != -251003)
						{
							Vector3 vector2 = default(Vector3);
							if (126356 - 361745 != -235388)
							{
								Vector3 vector3 = Vector3.zero;
								if (68597 - 470354 == -401757)
								{
									if ((this.ryNhjrYx7U.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (157914 - 580786 != -422872)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.ryNhjrYx7U.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (47595 - 396501 == -348905)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (237887 - 21086 == 216802)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (148183 - 187224 != -39041)
											{
												continue;
											}
											num = (float)0;
											if (227551 - 93032 != 134519)
											{
												continue;
											}
											this.transform.position = this.ryNhjrYx7U.nPosition;
											if (83261 - 562266 == -479004)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (49987 - 26472 == 23516)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (114615 - 273238 != -158623)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (167110 - 370542 == -203431)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (100923 - 53314 == 47610)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (200574 - 9697 == 190878)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (71013 - 502821 != -431808)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (53171 - 506932 != -453761)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (92378 - 372694 == -280315)
											{
												continue;
											}
										}
									}
									this.ryNhjrYx7U.vMovement = vector3;
									if (214741 - 215643 != -901)
									{
										this.ryNhjrYx7U.moveSpeed = num;
										if (159628 - 467680 == -308052)
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

	// Token: 0x06004541 RID: 17729 RVA: 0x008AD2DC File Offset: 0x008AB4DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (47471 - 111517 != -64045)
		{
		}
		do
		{
			if (Time.time - this.IgqhkSDV9c >= this.PgshFPxmEG)
			{
				if (260706 - 536325 == -275618)
				{
					continue;
				}
				if (Time.time - this.IgqhkSDV9c < this.PgshFPxmEG + mTime)
				{
					if (264309 - 596695 == -332385)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (139092 - 481775 != -342683)
						{
							continue;
						}
						this.AI_state = "idle";
						if (48935 - 501532 != -452597)
						{
							continue;
						}
						this.IgqhkSDV9c -= UnityEngine.Random.Range((float)0, rTimer);
						if (118466 - 219052 == -100585)
						{
							continue;
						}
						this.ryNhjrYx7U.vDirection = Vector3.zero;
						if (22783 - 481727 == -458943)
						{
							continue;
						}
						this.ryNhjrYx7U.vMovement = this.transform.forward;
						if (8389 - 370028 == -361638)
						{
							continue;
						}
						this.ryNhjrYx7U.actionState = "standby";
						if (183584 - 520895 == -337310)
						{
							continue;
						}
					}
					this.ryNhjrYx7U.moveSpeed = Mathf.Lerp(this.ryNhjrYx7U.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (220439 - 237160 == -16720)
					{
						continue;
					}
					if (this.ryNhjrYx7U.moveSpeed < 0.1f * this.ryNhjrYx7U.runSpeed)
					{
						if (121722 - 12704 == 109019)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (48821 - 438871 != -390050)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (56015 - 178782 != -122767)
						{
							continue;
						}
						this.ryNhjrYx7U.moveSpeed = (float)0;
						if (9745 - 150380 != -140635)
						{
							continue;
						}
					}
				}
			}
			this.PgshFPxmEG += mTime;
		}
		while (163933 - 25957 == 137977);
	}

	// Token: 0x06004542 RID: 17730 RVA: 0x008AD5A0 File Offset: 0x008AB7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (169898 - 61334 != 108564)
		{
		}
		for (;;)
		{
			this.ryNhjrYx7U.vDirection = followObject.transform.position;
			if (283315 - 427759 != -144443)
			{
				this.ryNhjrYx7U.vDirection.y = this.transform.position.y;
				if (43219 - 481608 == -438389)
				{
					this.ryNhjrYx7U.vMovement = (this.ryNhjrYx7U.vDirection - this.transform.position).normalized;
					if (50271 - 11479 != 38793)
					{
						this.transform.rotation = Quaternion.LookRotation(this.ryNhjrYx7U.vMovement);
						if (253923 - 517508 != -263584)
						{
							this.ryNhjrYx7U.actionState = "run";
							if (261623 - 274118 == -12495)
							{
								this.animation.Play("run");
								if (262001 - 6261 == 255740)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (203447 - 551260 == -347813)
									{
										this.ryNhjrYx7U.moveSpeed = Mathf.Lerp(this.ryNhjrYx7U.moveSpeed, this.ryNhjrYx7U.runSpeed, (float)4 * Time.deltaTime);
										if (212280 - 467507 == -255227)
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

	// Token: 0x06004543 RID: 17731 RVA: 0x008AD788 File Offset: 0x008AB988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (281852 - 505204 != -223351)
		{
		}
		do
		{
			if (Time.time - this.IgqhkSDV9c >= this.PgshFPxmEG)
			{
				if (233874 - 99521 == 134354)
				{
					continue;
				}
				if (Time.time - this.IgqhkSDV9c < this.PgshFPxmEG + mTime)
				{
					if (217280 - 549131 != -331851)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (201736 - 207256 == -5519)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (292054 - 289152 != 2902)
						{
							continue;
						}
						this.IgqhkSDV9c -= UnityEngine.Random.Range((float)0, rTimer);
						if (4024 - 135536 == -131511)
						{
							continue;
						}
						this.ryNhjrYx7U.vDirection = this.ryNhjrYx7U.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (63278 - 186427 != -123149)
						{
							continue;
						}
						this.ryNhjrYx7U.vDirection.y = this.transform.position.y;
						if (1750 - 484002 != -482252)
						{
							continue;
						}
						this.ryNhjrYx7U.vMovement = (this.ryNhjrYx7U.vDirection - this.transform.position).normalized;
						if (228954 - 114249 != 114705)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ryNhjrYx7U.vMovement);
						if (163718 - 429414 != -265696)
						{
							continue;
						}
						this.ryNhjrYx7U.actionState = "run";
						if (79171 - 260748 == -181576)
						{
							continue;
						}
						this.animation.Play("run");
						if (178178 - 380726 == -202547)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (33925 - 507435 != -473510)
						{
							continue;
						}
					}
					this.ryNhjrYx7U.moveSpeed = Mathf.Lerp(this.ryNhjrYx7U.moveSpeed, this.ryNhjrYx7U.runSpeed, (float)4 * Time.deltaTime);
					if (268589 - 227137 != 41452)
					{
						continue;
					}
				}
			}
			this.PgshFPxmEG += mTime;
		}
		while (297713 - 322956 != -25243);
	}

	// Token: 0x06004544 RID: 17732 RVA: 0x008ADA90 File Offset: 0x008ABC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (83085 - 155010 != -71924)
		{
		}
		do
		{
			if (Time.time - this.IgqhkSDV9c >= this.PgshFPxmEG)
			{
				if (242875 - 431942 == -189066)
				{
					continue;
				}
				if (Time.time - this.IgqhkSDV9c < this.PgshFPxmEG + mTime)
				{
					if (78887 - 324117 != -245230)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (63349 - 592614 == -529264)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (107463 - 65023 == 42441)
						{
							continue;
						}
						this.IgqhkSDV9c = Time.time - mTime - this.PgshFPxmEG;
						if (107568 - 365832 == -258263)
						{
							continue;
						}
						this.ryNhjrYx7U.vDirection = Vector3.zero;
						if (137568 - 290148 == -152579)
						{
							continue;
						}
						this.ryNhjrYx7U.vMovement = this.transform.forward;
						if (152506 - 503429 == -350922)
						{
							continue;
						}
						this.ryNhjrYx7U.actionState = "standby";
						if (86042 - 504316 != -418274)
						{
							continue;
						}
						this.ryNhjrYx7U.myAttackTarget = this.ryNhjrYx7U.getHateTarget(5, 50);
						if (277831 - 463446 == -185614)
						{
							continue;
						}
						if (!this.ryNhjrYx7U.myAttackTarget)
						{
							if (107117 - 70669 == 36449)
							{
								continue;
							}
							this.ryNhjrYx7U.isAlert = false;
							if (16730 - 50434 == -33703)
							{
								continue;
							}
							this.IgqhkSDV9c = Time.time;
							if (121556 - 221579 == -100022)
							{
								continue;
							}
							this.ryNhjrYx7U.myAttackTarget = null;
							if (36274 - 400233 == -363958)
							{
								continue;
							}
							this.ryNhjrYx7U.mOriginalPosition = this.transform.position;
							if (174643 - 102625 != 72018)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.ryNhjrYx7U.myAttackTarget;
							if (267237 - 179875 != 87362)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (208073 - 7059 == 201015)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (28146 - 515359 != -487213)
								{
									continue;
								}
								this.ryNhjrYx7U.isAlert = false;
								if (108942 - 228449 != -119507)
								{
									continue;
								}
								this.IgqhkSDV9c = Time.time;
								if (99020 - 446475 != -347455)
								{
									continue;
								}
								this.ryNhjrYx7U.myAttackTarget = null;
								if (147214 - 495736 == -348521)
								{
									continue;
								}
							}
							else
							{
								this.ryNhjrYx7U.vDirection = myAttackTarget.transform.position;
								if (253568 - 224311 != 29257)
								{
									continue;
								}
								this.ryNhjrYx7U.vDirection.y = this.transform.position.y;
								if (25387 - 474974 != -449587)
								{
									continue;
								}
								this.ryNhjrYx7U.vMovement = (this.ryNhjrYx7U.vDirection - this.transform.position).normalized;
								if (19927 - 173501 == -153573)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ryNhjrYx7U.vMovement);
								if (126789 - 273612 != -146823)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.PgshFPxmEG += mTime;
		}
		while (271231 - 17976 == 253256);
	}

	// Token: 0x06004545 RID: 17733 RVA: 0x008ADF40 File Offset: 0x008AC140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (290289 - 219042 != 71247)
		{
		}
		do
		{
			if (Time.time - this.IgqhkSDV9c >= this.PgshFPxmEG)
			{
				if (98485 - 54373 == 44113)
				{
					continue;
				}
				if (Time.time - this.IgqhkSDV9c < this.PgshFPxmEG + mTime)
				{
					if (153075 - 307553 != -154478)
					{
						continue;
					}
					if (!this.ryNhjrYx7U.myAttackTarget)
					{
						if (163343 - 578588 == -415244)
						{
							continue;
						}
						this.IgqhkSDV9c = Time.time - mTime - this.PgshFPxmEG;
						if (165343 - 40126 != 125217)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.ryNhjrYx7U.myAttackTarget;
						if (238547 - 582977 == -344429)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (72765 - 334744 == -261978)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (202202 - 105889 != 96313)
						{
							continue;
						}
						if (60900 - 455543 == -394642)
						{
							continue;
						}
						if (characterControl)
						{
							if (146006 - 565863 != -419857)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (68074 - 586978 != -518904)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (150799 - 32263 == 118537)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (297119 - 21853 == 275267)
							{
								continue;
							}
							if (this.ryNhjrYx7U.isTimeOut("nAttack") == (float)0)
							{
								if (35258 - 428343 == -393084)
								{
									continue;
								}
								this.IgqhkSDV9c = Time.time - mTime - this.PgshFPxmEG;
								if (192298 - 26613 != 165686)
								{
									goto IL_30C;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (193703 - 458116 != -264413)
							{
								continue;
							}
							this.IgqhkSDV9c = Time.time - mTime - this.PgshFPxmEG;
							if (239751 - 116246 == 123506)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (125834 - 42988 == 82847)
							{
								continue;
							}
							if (num > (float)2)
							{
								if (122660 - 10911 != 111749)
								{
									continue;
								}
								this.ryNhjrYx7U.vDirection = myAttackTarget.transform.position;
								if (75500 - 276444 != -200944)
								{
									continue;
								}
								this.ryNhjrYx7U.vDirection.y = this.transform.position.y;
								if (78426 - 249057 == -170630)
								{
									continue;
								}
								this.ryNhjrYx7U.vMovement = (this.ryNhjrYx7U.vDirection - this.transform.position).normalized;
								if (295037 - 517041 != -222004)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ryNhjrYx7U.vMovement);
								if (62594 - 488099 != -425505)
								{
									continue;
								}
								this.ryNhjrYx7U.actionState = "run";
								if (143541 - 73013 != 70528)
								{
									continue;
								}
								this.animation.Play("run");
								if (123802 - 587786 != -463984)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (138817 - 127187 != 11630)
								{
									continue;
								}
								this.ryNhjrYx7U.moveSpeed = Mathf.Lerp(this.ryNhjrYx7U.moveSpeed, this.ryNhjrYx7U.runSpeed, (float)4 * Time.deltaTime);
								if (219299 - 237574 != -18275)
								{
									continue;
								}
							}
							else
							{
								this.ryNhjrYx7U.vDirection = myAttackTarget.transform.position;
								if (89718 - 531284 == -441565)
								{
									continue;
								}
								this.ryNhjrYx7U.vDirection.y = this.transform.position.y;
								if (240472 - 590069 == -349596)
								{
									continue;
								}
								this.ryNhjrYx7U.vMovement = (this.ryNhjrYx7U.vDirection - this.transform.position).normalized;
								if (204530 - 593540 == -389009)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.ryNhjrYx7U.vMovement);
								if (63141 - 506261 == -443119)
								{
									continue;
								}
								this.ryNhjrYx7U.actionState = "standby";
								if (118003 - 214691 != -96688)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (10014 - 597312 != -587298)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (233868 - 343647 == -109778)
								{
									continue;
								}
								this.ryNhjrYx7U.moveSpeed = Mathf.Lerp(this.ryNhjrYx7U.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (74577 - 268574 != -193997)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_30C:
			this.PgshFPxmEG += mTime;
		}
		while (110386 - 294192 == -183805);
	}

	// Token: 0x06004546 RID: 17734 RVA: 0x008AE618 File Offset: 0x008AC818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (67987 - 381288 != -313301)
		{
		}
		while (Time.time - this.IgqhkSDV9c > this.PgshFPxmEG)
		{
			if (121943 - 267300 == -145357)
			{
				this.AI_state = "none";
				if (203220 - 445251 == -242031)
				{
					this.IgqhkSDV9c = Time.time;
					if (88525 - 429957 == -341432)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004547 RID: 17735 RVA: 0x008AE6CC File Offset: 0x008AC8CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (140607 - 157599 != -16992)
		{
		}
		for (;;)
		{
			IL_34E:
			if (this.CpOhAQsW9Q > Time.time)
			{
				if (102657 - 450686 != -348028)
				{
					break;
				}
			}
			else
			{
				this.CpOhAQsW9Q = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (170929 - 22512 != 148418)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (31049 - 249549 == -218500)
					{
						if (83757 - 399413 == -315656)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (140526 - 585549 != -445022)
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
									if (264299 - 462622 == -198322)
									{
										goto IL_34E;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (135371 - 515550 != -380179)
									{
										goto IL_34E;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (92293 - 72809 == 19485)
									{
										goto IL_34E;
									}
									bool flag = true;
									if (66983 - 283894 == -216910)
									{
										goto IL_34E;
									}
									eRace race = this.ryNhjrYx7U.Race;
									if (131713 - 36704 != 95009)
									{
										goto IL_34E;
									}
									if (race == eRace.Tails)
									{
										if (264896 - 438307 == -173410)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_792;
										}
										if (145105 - 459705 != -314600)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (272518 - 14792 != 257727)
											{
												goto IL_792;
											}
											goto IL_34E;
										}
										goto IL_613;
										IL_792:
										flag = false;
										if (149879 - 569023 != -419144)
										{
											goto IL_34E;
										}
									}
									else if (race == eRace.Plants)
									{
										if (22627 - 158733 != -136106)
										{
											goto IL_34E;
										}
										flag = false;
										if (12618 - 228805 != -216187)
										{
											goto IL_34E;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (175377 - 438491 != -263114)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_1A;
										}
										if (66426 - 338173 == -271746)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (120160 - 92343 != 27817)
											{
												goto IL_34E;
											}
											goto IL_1A;
										}
										goto IL_613;
										IL_1A:
										flag = false;
										if (71516 - 51974 != 19542)
										{
											goto IL_34E;
										}
									}
									else if (race == eRace.Robots)
									{
										if (107398 - 223885 == -116486)
										{
											goto IL_34E;
										}
										flag = true;
										if (133999 - 11419 == 122581)
										{
											goto IL_34E;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (91555 - 582821 == -491265)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_679;
										}
										if (6764 - 184799 == -178034)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_679;
										}
										if (274267 - 455500 != -181233)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (216292 - 18389 != 197904)
											{
												goto IL_679;
											}
											goto IL_34E;
										}
										goto IL_613;
										IL_679:
										flag = false;
										if (264891 - 498637 == -233745)
										{
											goto IL_34E;
										}
									}
									else if (race == eRace.Structure)
									{
										if (286097 - 162074 == 124024)
										{
											goto IL_34E;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (287392 - 55345 != 232047)
											{
												goto IL_34E;
											}
											flag = false;
											if (226303 - 511211 == -284907)
											{
												goto IL_34E;
											}
										}
									}
									IL_613:
									if (flag)
									{
										if (58817 - 52710 == 6108)
										{
											goto IL_34E;
										}
										if (characterControl.hp > 0)
										{
											if (165581 - 134179 == 31403)
											{
												goto IL_34E;
											}
											if (characterControl.recieveTarget)
											{
												if (83058 - 349835 != -266777)
												{
													goto IL_34E;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (94836 - 47355 != 47481)
													{
														goto IL_34E;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (299603 - 460492 != -160889)
														{
															goto IL_34E;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (146862 - 470977 == -324114)
														{
															goto IL_34E;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (1176 - 546955 != -545779)
															{
																goto IL_34E;
															}
															this.ryNhjrYx7U.myAttackTarget = gameObject;
															if (180225 - 340965 != -160740)
															{
																goto IL_34E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (179819 - 204838 != -25019)
															{
																goto IL_34E;
															}
															this.ryNhjrYx7U.addHate(characterControl.ActorNr, 5);
															if (71386 - 125049 == -53662)
															{
																goto IL_34E;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (127013 - 10072 == 116942)
															{
																goto IL_34E;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (259422 - 385569 != -126147)
															{
																goto IL_34E;
															}
															if (num < (float)60)
															{
																if (48463 - 20959 != 27504)
																{
																	goto IL_34E;
																}
																if (characterControl.hp > 0)
																{
																	if (277988 - 68672 != 209316)
																	{
																		goto IL_34E;
																	}
																	this.ryNhjrYx7U.myAttackTarget = gameObject;
																	if (50363 - 290543 != -240180)
																	{
																		goto IL_34E;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (213330 - 194094 == 19237)
																	{
																		goto IL_34E;
																	}
																	this.ryNhjrYx7U.addHate(characterControl.ActorNr, 5);
																	if (165496 - 255231 != -89735)
																	{
																		goto IL_34E;
																	}
																}
															}
														}
														if (this.ryNhjrYx7U.myAttackTarget)
														{
															if (231857 - 304436 != -72579)
															{
																goto IL_34E;
															}
															this.ryNhjrYx7U.isAlert = true;
															if (180907 - 333395 != -152488)
															{
																goto IL_34E;
															}
															this.IgqhkSDV9c = Time.time;
															if (24278 - 266545 == -242266)
															{
																goto IL_34E;
															}
														}
													}
												}
											}
										}
									}
								}
								if (40991 - 326544 != -285552)
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

	// Token: 0x06004548 RID: 17736 RVA: 0x008AEEE4 File Offset: 0x008AD0E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004549 RID: 17737 RVA: 0x008AEEE8 File Offset: 0x008AD0E8
	internal static bool Bw8Z8O5ijEjlyRaTabmH()
	{
		return true;
	}

	// Token: 0x0600454A RID: 17738 RVA: 0x008AEEEC File Offset: 0x008AD0EC
	internal static bool AjUWDR5ihXkj82SVSqnO()
	{
		return false;
	}

	// Token: 0x040050B4 RID: 20660
	private CharacterControl ryNhjrYx7U;

	// Token: 0x040050B5 RID: 20661
	private Carron VaBhoxCRLa;

	// Token: 0x040050B6 RID: 20662
	public string AI_state;

	// Token: 0x040050B7 RID: 20663
	private float IgqhkSDV9c;

	// Token: 0x040050B8 RID: 20664
	private float PgshFPxmEG;

	// Token: 0x040050B9 RID: 20665
	private float CpOhAQsW9Q;
}
