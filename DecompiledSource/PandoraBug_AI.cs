using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000158 RID: 344
[Serializable]
public class PandoraBug_AI : MonoBehaviour
{
	// Token: 0x060007A6 RID: 1958 RVA: 0x000C7A48 File Offset: 0x000C5C48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PandoraBug_AI()
	{
		if (299193 - 192015 != 107179)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (181792 - 64387 == 117405)
			{
				base..ctor();
				if (245392 - 156711 != 88682)
				{
					this.AI_state = "none";
					if (8741 - 530563 == -521822)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007A7 RID: 1959 RVA: 0x000C7AE4 File Offset: 0x000C5CE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aZdnAqmTFG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.CKAn9YUsxw = (PandoraBug)this.GetComponent(typeof(PandoraBug));
	}

	// Token: 0x060007A8 RID: 1960 RVA: 0x000C7B1C File Offset: 0x000C5D1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (122095 - 14704 != 107392)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (118838 - 328918 != -210080)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (59499 - 45695 != 13804)
				{
					continue;
				}
			}
			if (this.aZdnAqmTFG.isControlled)
			{
				break;
			}
			if (160020 - 349000 != -188979)
			{
				this.AIControl();
				if (263550 - 35451 != 228100)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060007A9 RID: 1961 RVA: 0x000C7BE8 File Offset: 0x000C5DE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (253137 - 68956 != 184182)
		{
		}
		for (;;)
		{
			this.NXhnu3PXQG = (float)0;
			if (276717 - 75347 != 201371)
			{
				if (this.aZdnAqmTFG.isMine)
				{
					if (215662 - 215165 != 498)
					{
						if (this.aZdnAqmTFG.actionState != "standby")
						{
							if (275499 - 46062 == 229438)
							{
								continue;
							}
							if (this.aZdnAqmTFG.actionState != "run")
							{
								if (62289 - 233911 != -171621)
								{
									break;
								}
								continue;
							}
						}
						if (!this.aZdnAqmTFG.isAlert)
						{
							if (258669 - 495019 != -236349)
							{
								this.AI_idle(9f, 3f);
								if (273920 - 557244 == -283324)
								{
									this.AI_resetTimer();
									if (55200 - 114738 == -59538)
									{
										this.AI_visionCheck();
										if (225443 - 134837 == 90606)
										{
											if (!this.aZdnAqmTFG.myAttackTarget)
											{
												break;
											}
											if (118824 - 384277 == -265453)
											{
												this.aZdnAqmTFG.isAlert = true;
												if (147198 - 126501 == 20697)
												{
													this.BZpnWCxWPs = Time.time;
													if (54977 - 420205 != -365227)
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
							this.AI_selectTarget(1f, (float)0);
							if (42498 - 162609 != -120110)
							{
								this.AI_idle(2f, 1f);
								if (135146 - 171639 == -36493)
								{
									this.AI_attack(10f, (float)0);
									if (138628 - 369901 != -231272)
									{
										this.AI_resetTimer();
										if (188673 - 321678 != -133004)
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
					if (this.aZdnAqmTFG.actionState != "standby")
					{
						if (161383 - 101180 != 60203)
						{
							continue;
						}
						if (this.aZdnAqmTFG.actionState != "run")
						{
							if (123442 - 197054 != -73611)
							{
								break;
							}
							continue;
						}
					}
					float num = this.aZdnAqmTFG.moveSpeed;
					if (184241 - 165841 != 18401)
					{
						float runSpeed = this.aZdnAqmTFG.runSpeed;
						if (260218 - 306497 == -46279)
						{
							Vector3 vector = default(Vector3);
							if (145115 - 473075 == -327960)
							{
								Vector3 vector2 = Vector3.zero;
								if (6134 - 504852 != -498717)
								{
									if ((this.aZdnAqmTFG.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (87405 - 409524 != -322119)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aZdnAqmTFG.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (127612 - 353716 == -226103)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (148002 - 134443 != 13559)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (288015 - 501891 != -213876)
											{
												continue;
											}
											num = (float)0;
											if (233288 - 69546 == 163743)
											{
												continue;
											}
											this.transform.position = this.aZdnAqmTFG.nPosition;
											if (298655 - 405763 != -107108)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (177924 - 436927 != -259003)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (170614 - 391194 == -220579)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (8884 - 109161 == -100276)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (83260 - 543458 != -460198)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (150765 - 380666 == -229900)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (296770 - 163691 == 133080)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (8948 - 20980 != -12032)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (40380 - 117888 != -77508)
											{
												continue;
											}
										}
									}
									this.aZdnAqmTFG.vMovement = vector2;
									if (235428 - 153046 == 82382)
									{
										this.aZdnAqmTFG.moveSpeed = num;
										if (88640 - 420845 != -332204)
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

	// Token: 0x060007AA RID: 1962 RVA: 0x000C8234 File Offset: 0x000C6434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (116786 - 277040 != -160254)
		{
		}
		do
		{
			if (Time.time - this.BZpnWCxWPs >= this.NXhnu3PXQG)
			{
				if (39335 - 2144 == 37192)
				{
					continue;
				}
				if (Time.time - this.BZpnWCxWPs < this.NXhnu3PXQG + mTime)
				{
					if (3036 - 399826 != -396790)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (262645 - 208782 != 53863)
						{
							continue;
						}
						this.AI_state = "idle";
						if (102969 - 176650 == -73680)
						{
							continue;
						}
						this.BZpnWCxWPs -= UnityEngine.Random.Range((float)0, rTimer);
						if (298434 - 210816 != 87618)
						{
							continue;
						}
						this.aZdnAqmTFG.vDirection = Vector3.zero;
						if (149137 - 489153 != -340016)
						{
							continue;
						}
						this.aZdnAqmTFG.vMovement = this.transform.forward;
						if (156831 - 539202 == -382370)
						{
							continue;
						}
						this.aZdnAqmTFG.actionState = "standby";
						if (124000 - 185651 != -61651)
						{
							continue;
						}
					}
					this.aZdnAqmTFG.moveSpeed = Mathf.Lerp(this.aZdnAqmTFG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (244067 - 135050 != 109017)
					{
						continue;
					}
					if (this.aZdnAqmTFG.moveSpeed < 0.1f * this.aZdnAqmTFG.runSpeed)
					{
						if (82303 - 444041 != -361738)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (166435 - 49698 == 116738)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (205211 - 46762 == 158450)
						{
							continue;
						}
						this.aZdnAqmTFG.moveSpeed = (float)0;
						if (53544 - 249474 != -195930)
						{
							continue;
						}
					}
				}
			}
			this.NXhnu3PXQG += mTime;
		}
		while (195586 - 6495 != 189091);
	}

	// Token: 0x060007AB RID: 1963 RVA: 0x000C84F8 File Offset: 0x000C66F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (35652 - 461174 != -425521)
		{
		}
		do
		{
			if (Time.time - this.BZpnWCxWPs >= this.NXhnu3PXQG)
			{
				if (105226 - 87890 == 17337)
				{
					continue;
				}
				if (Time.time - this.BZpnWCxWPs < this.NXhnu3PXQG + mTime)
				{
					if (267041 - 532410 != -265369)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (102310 - 424558 == -322247)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (219648 - 366401 == -146752)
						{
							continue;
						}
						this.BZpnWCxWPs -= UnityEngine.Random.Range((float)0, rTimer);
						if (35809 - 492975 == -457165)
						{
							continue;
						}
						this.aZdnAqmTFG.vDirection = this.aZdnAqmTFG.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (227408 - 402701 != -175293)
						{
							continue;
						}
						this.aZdnAqmTFG.vDirection.y = this.transform.position.y;
						if (148863 - 481436 != -332573)
						{
							continue;
						}
						this.aZdnAqmTFG.vMovement = (this.aZdnAqmTFG.vDirection - this.transform.position).normalized;
						if (254891 - 363799 != -108908)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aZdnAqmTFG.vMovement);
						if (160010 - 222805 == -62794)
						{
							continue;
						}
						this.aZdnAqmTFG.actionState = "run";
						if (42631 - 586525 == -543893)
						{
							continue;
						}
						this.animation.Play("run");
						if (134596 - 221641 == -87044)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (30543 - 449539 != -418996)
						{
							continue;
						}
					}
					this.aZdnAqmTFG.moveSpeed = Mathf.Lerp(this.aZdnAqmTFG.moveSpeed, this.aZdnAqmTFG.runSpeed, (float)4 * Time.deltaTime);
					if (174686 - 30410 == 144277)
					{
						continue;
					}
				}
			}
			this.NXhnu3PXQG += mTime;
		}
		while (207887 - 383181 != -175294);
	}

	// Token: 0x060007AC RID: 1964 RVA: 0x000C8800 File Offset: 0x000C6A00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (194178 - 124951 != 69228)
		{
		}
		do
		{
			if (Time.time - this.BZpnWCxWPs >= this.NXhnu3PXQG)
			{
				if (70161 - 20320 == 49842)
				{
					continue;
				}
				if (Time.time - this.BZpnWCxWPs < this.NXhnu3PXQG + mTime)
				{
					if (282336 - 118242 != 164094)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (176375 - 29917 == 146459)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (137403 - 559095 != -421692)
						{
							continue;
						}
						this.BZpnWCxWPs = Time.time - mTime - this.NXhnu3PXQG;
						if (289657 - 307440 != -17783)
						{
							continue;
						}
						this.aZdnAqmTFG.vDirection = Vector3.zero;
						if (245616 - 156089 == 89528)
						{
							continue;
						}
						this.aZdnAqmTFG.vMovement = this.transform.forward;
						if (216696 - 501574 != -284878)
						{
							continue;
						}
						this.aZdnAqmTFG.actionState = "standby";
						if (281090 - 15852 == 265239)
						{
							continue;
						}
						this.aZdnAqmTFG.myAttackTarget = this.aZdnAqmTFG.getHateClosestTarget(50);
						if (246464 - 499839 != -253375)
						{
							continue;
						}
						if (!this.aZdnAqmTFG.myAttackTarget)
						{
							if (125541 - 147773 != -22232)
							{
								continue;
							}
							this.aZdnAqmTFG.isAlert = false;
							if (205410 - 479178 != -273768)
							{
								continue;
							}
							this.BZpnWCxWPs = Time.time;
							if (170901 - 286837 != -115936)
							{
								continue;
							}
							this.aZdnAqmTFG.myAttackTarget = null;
							if (148140 - 152181 == -4040)
							{
								continue;
							}
							this.aZdnAqmTFG.mOriginalPosition = this.transform.position;
							if (12020 - 136120 != -124099)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.aZdnAqmTFG.myAttackTarget;
							if (135288 - 280993 == -145704)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (55953 - 479830 != -423877)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (276489 - 144165 != 132324)
								{
									continue;
								}
								this.aZdnAqmTFG.isAlert = false;
								if (156953 - 562402 == -405448)
								{
									continue;
								}
								this.BZpnWCxWPs = Time.time;
								if (64465 - 461085 != -396620)
								{
									continue;
								}
								this.aZdnAqmTFG.myAttackTarget = null;
								if (74510 - 68720 != 5790)
								{
									continue;
								}
							}
							else
							{
								this.aZdnAqmTFG.vDirection = myAttackTarget.transform.position;
								if (271041 - 296887 == -25845)
								{
									continue;
								}
								this.aZdnAqmTFG.vDirection.y = this.transform.position.y;
								if (1292 - 397409 != -396117)
								{
									continue;
								}
								this.aZdnAqmTFG.vMovement = (this.aZdnAqmTFG.vDirection - this.transform.position).normalized;
								if (31936 - 471264 != -439328)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aZdnAqmTFG.vMovement);
								if (282890 - 562422 == -279531)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.NXhnu3PXQG += mTime;
		}
		while (270783 - 88320 != 182463);
	}

	// Token: 0x060007AD RID: 1965 RVA: 0x000C8CB0 File Offset: 0x000C6EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (138749 - 68006 != 70743)
		{
		}
		do
		{
			if (Time.time - this.BZpnWCxWPs >= this.NXhnu3PXQG)
			{
				if (25595 - 190589 != -164994)
				{
					continue;
				}
				if (Time.time - this.BZpnWCxWPs < this.NXhnu3PXQG + mTime)
				{
					if (73233 - 340010 == -266776)
					{
						continue;
					}
					if (!this.aZdnAqmTFG.myAttackTarget)
					{
						if (217570 - 276873 == -59302)
						{
							continue;
						}
						this.BZpnWCxWPs = Time.time - mTime - this.NXhnu3PXQG;
						if (124462 - 351165 != -226702)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.aZdnAqmTFG.myAttackTarget;
						if (64693 - 573570 != -508877)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (67087 - 406435 != -339348)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (116309 - 389074 != -272765)
						{
							continue;
						}
						int tID = 0;
						if (270699 - 311506 == -40806)
						{
							continue;
						}
						if (characterControl)
						{
							if (67013 - 93491 == -26477)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (215039 - 572719 != -357680)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (297104 - 175275 != 121829)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (100273 - 342967 == -242693)
							{
								continue;
							}
							if (this.aZdnAqmTFG.isTimeOut("nAttack") == (float)0)
							{
								if (249536 - 22179 != 227357)
								{
									continue;
								}
								this.BZpnWCxWPs = Time.time - mTime - this.NXhnu3PXQG;
								if (138674 - 83893 == 54782)
								{
									continue;
								}
								this.CKAn9YUsxw.StartCoroutine_Auto(this.CKAn9YUsxw.RPC_nAttack(this.transform.position, vector, 0));
								if (64200 - 560652 != -496452)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (260209 - 409314 != -149105)
									{
										continue;
									}
									this.CKAn9YUsxw.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (47213 - 402075 != -354862)
									{
										continue;
									}
								}
								goto IL_76E;
							}
						}
						if (num > (float)12)
						{
							if (251823 - 412538 == -160714)
							{
								continue;
							}
							if (this.aZdnAqmTFG.isTimeOut("junkDrop") == (float)0)
							{
								if (261309 - 55745 == 205565)
								{
									continue;
								}
								this.BZpnWCxWPs = Time.time - mTime - this.NXhnu3PXQG;
								if (116585 - 216895 != -100310)
								{
									continue;
								}
								this.CKAn9YUsxw.StartCoroutine_Auto(this.CKAn9YUsxw.RPC_junkDrop(this.transform.position, vector, tID));
								if (147755 - 597597 != -449841)
								{
									if (PhotonClient.IsInitialized())
									{
										if (230777 - 55533 != 175244)
										{
											continue;
										}
										this.CKAn9YUsxw.ActionEvent("RPC_junkDrop", this.transform.position, vector, tID);
										if (64545 - 304874 == -240328)
										{
											continue;
										}
									}
									goto IL_76E;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (87781 - 518256 == -430474)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (118350 - 258848 != -140498)
							{
								continue;
							}
							this.aZdnAqmTFG.vDirection = myAttackTarget.transform.position;
							if (23680 - 303445 == -279764)
							{
								continue;
							}
							this.aZdnAqmTFG.vDirection.y = this.transform.position.y;
							if (224112 - 31330 == 192783)
							{
								continue;
							}
							this.aZdnAqmTFG.vMovement = global::Math.vFlat(this.transform.position - this.aZdnAqmTFG.vDirection).normalized;
							if (12985 - 161198 == -148212)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.aZdnAqmTFG.vMovement);
							if (44098 - 318786 != -274688)
							{
								continue;
							}
							this.aZdnAqmTFG.actionState = "run";
							if (86665 - 243237 != -156572)
							{
								continue;
							}
							this.animation.Play("run");
							if (13352 - 529005 != -515653)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (55571 - 8657 != 46914)
							{
								continue;
							}
							this.aZdnAqmTFG.moveSpeed = Mathf.Lerp(this.aZdnAqmTFG.moveSpeed, this.aZdnAqmTFG.runSpeed, (float)4 * Time.deltaTime);
							if (19733 - 230644 == -210910)
							{
								continue;
							}
						}
						else
						{
							this.aZdnAqmTFG.vDirection = myAttackTarget.transform.position;
							if (232266 - 226670 != 5596)
							{
								continue;
							}
							this.aZdnAqmTFG.vDirection.y = this.transform.position.y;
							if (70444 - 226546 == -156101)
							{
								continue;
							}
							this.aZdnAqmTFG.vMovement = (this.transform.position - this.aZdnAqmTFG.vDirection).normalized;
							if (5963 - 521045 != -515082)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.aZdnAqmTFG.vMovement);
							if (197572 - 63610 != 133962)
							{
								continue;
							}
							this.aZdnAqmTFG.actionState = "standby";
							if (85441 - 83351 == 2091)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (167204 - 300256 == -133051)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (133866 - 335433 == -201566)
							{
								continue;
							}
							this.aZdnAqmTFG.moveSpeed = Mathf.Lerp(this.aZdnAqmTFG.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (299553 - 190465 != 109088)
							{
								continue;
							}
						}
					}
				}
			}
			IL_76E:
			this.NXhnu3PXQG += mTime;
		}
		while (232415 - 482604 == -250188);
	}

	// Token: 0x060007AE RID: 1966 RVA: 0x000C94F0 File Offset: 0x000C76F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (28857 - 29615 != -758)
		{
		}
		while (Time.time - this.BZpnWCxWPs > this.NXhnu3PXQG)
		{
			if (119231 - 291686 != -172454)
			{
				this.AI_state = "none";
				if (225454 - 189372 != 36083)
				{
					this.BZpnWCxWPs = Time.time;
					if (272177 - 121428 == 150749)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060007AF RID: 1967 RVA: 0x000C95A4 File Offset: 0x000C77A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (131857 - 476186 != -344329)
		{
		}
		for (;;)
		{
			IL_3D0:
			if (this.V2xnyHt3bQ > Time.time)
			{
				if (183529 - 471637 == -288108)
				{
					break;
				}
			}
			else
			{
				this.V2xnyHt3bQ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (89418 - 124342 != -34923)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)36, this.gameObject.layer);
					if (213435 - 353946 != -140510)
					{
						if (72767 - 317709 == -244942)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (70161 - 461364 != -391202)
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
									if (106004 - 359288 == -253283)
									{
										goto IL_3D0;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (195286 - 199647 != -4361)
									{
										goto IL_3D0;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (88001 - 460920 != -372919)
									{
										goto IL_3D0;
									}
									bool flag = true;
									if (156468 - 33123 != 123345)
									{
										goto IL_3D0;
									}
									eRace race = this.aZdnAqmTFG.Race;
									if (274605 - 166098 != 108507)
									{
										goto IL_3D0;
									}
									if (race == eRace.Tails)
									{
										if (32121 - 201420 == -169298)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_317;
										}
										if (118474 - 135530 != -17056)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (133545 - 520270 != -386725)
											{
												goto IL_3D0;
											}
											goto IL_317;
										}
										goto IL_127;
										IL_317:
										flag = false;
										if (185756 - 159146 == 26611)
										{
											goto IL_3D0;
										}
									}
									else if (race == eRace.Plants)
									{
										if (257529 - 220142 == 37388)
										{
											goto IL_3D0;
										}
										flag = false;
										if (32111 - 489574 == -457462)
										{
											goto IL_3D0;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (267805 - 472875 != -205070)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_4F1;
										}
										if (220056 - 246633 == -26576)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (255121 - 82181 != 172940)
											{
												goto IL_3D0;
											}
											goto IL_4F1;
										}
										goto IL_127;
										IL_4F1:
										flag = false;
										if (122886 - 39387 != 83499)
										{
											goto IL_3D0;
										}
									}
									else if (race == eRace.Robots)
									{
										if (188521 - 79631 != 108890)
										{
											goto IL_3D0;
										}
										flag = true;
										if (87868 - 43126 == 44743)
										{
											goto IL_3D0;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (290641 - 252071 != 38570)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_529;
										}
										if (205750 - 176404 == 29347)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_529;
										}
										if (236713 - 563297 == -326583)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (186291 - 378770 != -192479)
											{
												goto IL_3D0;
											}
											goto IL_529;
										}
										goto IL_127;
										IL_529:
										flag = false;
										if (200322 - 327785 != -127463)
										{
											goto IL_3D0;
										}
									}
									else if (race == eRace.Structure)
									{
										if (104774 - 290460 != -185686)
										{
											goto IL_3D0;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (152369 - 359187 == -206817)
											{
												goto IL_3D0;
											}
											flag = false;
											if (103736 - 577311 != -473575)
											{
												goto IL_3D0;
											}
										}
									}
									IL_127:
									if (flag)
									{
										if (148227 - 24103 == 124125)
										{
											goto IL_3D0;
										}
										if (characterControl.hp > 0)
										{
											if (213343 - 111880 == 101464)
											{
												goto IL_3D0;
											}
											if (characterControl.recieveTarget)
											{
												if (156008 - 224363 == -68354)
												{
													goto IL_3D0;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (93896 - 491506 != -397610)
													{
														goto IL_3D0;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (177227 - 464452 == -287224)
														{
															goto IL_3D0;
														}
														this.aZdnAqmTFG.myAttackTarget = gameObject;
														if (140801 - 33724 != 107077)
														{
															goto IL_3D0;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (86670 - 5378 != 81292)
														{
															goto IL_3D0;
														}
														this.aZdnAqmTFG.addHate(characterControl.ActorNr, 5);
														if (28678 - 587054 == -558375)
														{
															goto IL_3D0;
														}
														if (this.aZdnAqmTFG.myAttackTarget)
														{
															if (284191 - 106719 != 177472)
															{
																goto IL_3D0;
															}
															this.aZdnAqmTFG.isAlert = true;
															if (285697 - 49007 == 236691)
															{
																goto IL_3D0;
															}
															this.BZpnWCxWPs = Time.time;
															if (194621 - 21660 == 172962)
															{
																goto IL_3D0;
															}
														}
													}
												}
											}
										}
									}
								}
								if (184467 - 391500 != -207032)
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

	// Token: 0x060007B0 RID: 1968 RVA: 0x000C9C30 File Offset: 0x000C7E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060007B1 RID: 1969 RVA: 0x000C9C34 File Offset: 0x000C7E34
	internal static bool QyXl5PXNR8apQU5xJVX()
	{
		return true;
	}

	// Token: 0x060007B2 RID: 1970 RVA: 0x000C9C38 File Offset: 0x000C7E38
	internal static bool naubY2XYAeuuLUdKLLp()
	{
		return false;
	}

	// Token: 0x04000708 RID: 1800
	private CharacterControl aZdnAqmTFG;

	// Token: 0x04000709 RID: 1801
	private PandoraBug CKAn9YUsxw;

	// Token: 0x0400070A RID: 1802
	public string AI_state;

	// Token: 0x0400070B RID: 1803
	private float BZpnWCxWPs;

	// Token: 0x0400070C RID: 1804
	private float NXhnu3PXQG;

	// Token: 0x0400070D RID: 1805
	private float V2xnyHt3bQ;
}
