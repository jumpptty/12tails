using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200020B RID: 523
[Serializable]
public class SkyBug_AI : MonoBehaviour
{
	// Token: 0x06000BCB RID: 3019 RVA: 0x0012F51C File Offset: 0x0012D71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SkyBug_AI()
	{
		if (272033 - 70316 != 201718)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (147728 - 309093 != -161364)
			{
				base..ctor();
				if (96909 - 193724 == -96815)
				{
					this.AI_state = "none";
					if (47210 - 549329 == -502119)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0012F5B8 File Offset: 0x0012D7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (54971 - 60312 != -5341)
		{
		}
		for (;;)
		{
			this.hPteLn1l0E = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (200493 - 453322 == -252829)
			{
				this.fOPeN6Jgbf = (SkyBug)this.GetComponent(typeof(SkyBug));
				if (185631 - 304541 != -118909)
				{
					GameObject gameObject = global::Math.findChildObject(this.transform, "Root").gameObject;
					if (80465 - 534718 != -454252)
					{
						if (gameObject)
						{
							if (98378 - 210002 != -111624)
							{
								continue;
							}
							this.KiSewAio8n = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (182244 - 188568 != -6324)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find SkyBugHead CharacterControl");
							if (179042 - 67246 != 111796)
							{
								continue;
							}
						}
						GameObject gameObject2 = global::Math.findChildObject(this.transform, "Tail6").gameObject;
						if (135709 - 394004 == -258295)
						{
							if (gameObject2)
							{
								if (27374 - 50098 != -22723)
								{
									this.VdneUnSjJg = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (151000 - 170217 != -19216)
									{
										break;
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find SkyBugTail CharacterControl");
								if (293681 - 411620 != -117938)
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

	// Token: 0x06000BCD RID: 3021 RVA: 0x0012F7C0 File Offset: 0x0012D9C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (169328 - 489801 != -320473)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (69246 - 206782 != -137536)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (170630 - 46571 == 124060)
				{
					continue;
				}
			}
			if (this.hPteLn1l0E.isControlled)
			{
				break;
			}
			if (214018 - 568381 == -354363)
			{
				this.AIControl();
				if (265886 - 219833 != 46054)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x0012F88C File Offset: 0x0012DA8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (30585 - 296018 != -265432)
		{
		}
		for (;;)
		{
			this.t9LePy0VPO = (float)0;
			if (141130 - 394183 == -253053)
			{
				if (this.hPteLn1l0E.isMine)
				{
					if (134464 - 284002 == -149538)
					{
						if (this.hPteLn1l0E.actionState != "standby")
						{
							if (250772 - 202835 != 47937)
							{
								continue;
							}
							if (this.hPteLn1l0E.actionState != "run")
							{
								if (142715 - 219611 != -76895)
								{
									break;
								}
								continue;
							}
						}
						if (!this.hPteLn1l0E.isAlert)
						{
							if (265046 - 523205 != -258158)
							{
								this.AI_idle(5f, 1f);
								if (204602 - 111122 != 93481)
								{
									this.AI_resetTimer();
									if (64114 - 209216 != -145101)
									{
										this.AI_visionCheck();
										if (241200 - 175442 != 65759)
										{
											if (!this.hPteLn1l0E.myAttackTarget)
											{
												break;
											}
											if (155801 - 522305 != -366503)
											{
												this.hPteLn1l0E.isAlert = true;
												if (82495 - 210466 != -127970)
												{
													this.I4WeESmkKN = Time.time;
													if (274656 - 315193 != -40536)
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
							if (281704 - 541188 == -259484)
							{
								this.AI_idle(2f, 2f);
								if (286878 - 70389 == 216489)
								{
									this.AI_attack(7f, 2f);
									if (58324 - 397826 == -339502)
									{
										this.AI_resetTimer();
										if (223760 - 391342 == -167582)
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
					if (this.hPteLn1l0E.actionState != "standby")
					{
						if (17226 - 136451 != -119225)
						{
							continue;
						}
						if (this.hPteLn1l0E.actionState != "run")
						{
							if (269223 - 267762 != 1462)
							{
								break;
							}
							continue;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (171750 - 338531 == -166781)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (201430 - 155220 != 46211)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x0012FBF4 File Offset: 0x0012DDF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (84723 - 73564 != 11160)
		{
		}
		do
		{
			if (Time.time - this.I4WeESmkKN >= this.t9LePy0VPO)
			{
				if (117452 - 181090 == -63637)
				{
					continue;
				}
				if (Time.time - this.I4WeESmkKN < this.t9LePy0VPO + mTime)
				{
					if (244860 - 289953 == -45092)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (13690 - 173415 == -159724)
						{
							continue;
						}
						this.AI_state = "idle";
						if (41983 - 220313 != -178330)
						{
							continue;
						}
						this.I4WeESmkKN -= UnityEngine.Random.Range((float)0, rTimer);
						if (218626 - 4747 != 213879)
						{
							continue;
						}
						this.hPteLn1l0E.vDirection = Vector3.zero;
						if (61561 - 569551 == -507989)
						{
							continue;
						}
						this.hPteLn1l0E.vMovement = this.transform.forward;
						if (268312 - 343495 != -75183)
						{
							continue;
						}
						this.hPteLn1l0E.actionState = "standby";
						if (213057 - 598500 == -385442)
						{
							continue;
						}
					}
					this.hPteLn1l0E.moveSpeed = Mathf.Lerp(this.hPteLn1l0E.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (234783 - 13822 == 220962)
					{
						continue;
					}
					if (this.hPteLn1l0E.moveSpeed < 0.1f * this.hPteLn1l0E.runSpeed)
					{
						if (171351 - 343921 == -172569)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (257300 - 321347 != -64047)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (270956 - 444667 != -173711)
						{
							continue;
						}
						this.hPteLn1l0E.moveSpeed = (float)0;
						if (202449 - 564493 != -362044)
						{
							continue;
						}
					}
				}
			}
			this.t9LePy0VPO += mTime;
		}
		while (61354 - 351422 != -290068);
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x0012FEB8 File Offset: 0x0012E0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_combineHate()
	{
		if (256321 - 255578 != 743)
		{
		}
		for (;;)
		{
			IL_29B:
			int num = Mathf.CeilToInt(Time.time);
			if (173037 - 357565 == -184528)
			{
				if (!this.KiSewAio8n)
				{
					if (6179 - 493381 == -487202)
					{
						break;
					}
				}
				else if (!this.VdneUnSjJg)
				{
					if (110763 - 275981 != -165217)
					{
						break;
					}
				}
				else
				{
					if (this.KiSewAio8n.hp > 0)
					{
						if (45955 - 219076 != -173121)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.KiSewAio8n.mHateList);
						if (28140 - 318528 == -290387)
						{
							continue;
						}
						while (enumerator.MoveNext())
						{
							object obj = enumerator.Current;
							object obj3;
							object obj2 = obj3 = obj;
							if (!(obj2 is hateClass))
							{
								obj3 = RuntimeServices.Coerce(obj2, typeof(hateClass));
							}
							hateClass hateClass = (hateClass)obj3;
							if (227863 - 453287 == -225423)
							{
								goto IL_29B;
							}
							if (hateClass.hate - num > 0)
							{
								if (268708 - 401269 == -132560)
								{
									goto IL_29B;
								}
								this.hPteLn1l0E.addHate(hateClass.ID, Mathf.CeilToInt(0.5f * (float)(hateClass.hate - num)));
								if (5110 - 306914 == -301803)
								{
									goto IL_29B;
								}
								UnityRuntimeServices.Update(enumerator, hateClass);
								if (132370 - 354959 != -222589)
								{
									goto IL_29B;
								}
							}
						}
						if (236495 - 70368 != 166127)
						{
							continue;
						}
						this.KiSewAio8n.mHateList.Clear();
						if (224001 - 29003 == 194999)
						{
							continue;
						}
					}
					if (this.VdneUnSjJg.hp <= 0)
					{
						break;
					}
					if (281599 - 229173 != 52427)
					{
						IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.VdneUnSjJg.mHateList);
						if (292064 - 252556 == 39508)
						{
							while (enumerator2.MoveNext())
							{
								object obj4 = enumerator2.Current;
								object obj6;
								object obj5 = obj6 = obj4;
								if (!(obj5 is hateClass))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(hateClass));
								}
								hateClass hateClass2 = (hateClass)obj6;
								if (213170 - 372795 == -159624)
								{
									goto IL_29B;
								}
								if (hateClass2.hate - num > 0)
								{
									if (211329 - 147283 != 64046)
									{
										goto IL_29B;
									}
									this.hPteLn1l0E.addHate(hateClass2.ID, Mathf.CeilToInt(0.5f * (float)(hateClass2.hate - num)));
									if (120265 - 299813 != -179548)
									{
										goto IL_29B;
									}
									UnityRuntimeServices.Update(enumerator2, hateClass2);
									if (16914 - 249089 != -232175)
									{
										goto IL_29B;
									}
								}
							}
							if (270448 - 338171 != -67722)
							{
								this.VdneUnSjJg.mHateList.Clear();
								if (71275 - 358270 == -286995)
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

	// Token: 0x06000BD1 RID: 3025 RVA: 0x0013025C File Offset: 0x0012E45C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (288501 - 324419 != -35918)
		{
		}
		do
		{
			if (Time.time - this.I4WeESmkKN >= this.t9LePy0VPO)
			{
				if (164433 - 586511 != -422078)
				{
					continue;
				}
				if (Time.time - this.I4WeESmkKN < this.t9LePy0VPO + mTime)
				{
					if (274084 - 557059 == -282974)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (64733 - 478024 != -413291)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (176211 - 176243 == -31)
						{
							continue;
						}
						this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
						if (97081 - 99979 == -2897)
						{
							continue;
						}
						this.AI_combineHate();
						if (182275 - 277272 != -94997)
						{
							continue;
						}
						this.hPteLn1l0E.vDirection = Vector3.zero;
						if (126647 - 383460 == -256812)
						{
							continue;
						}
						this.hPteLn1l0E.vMovement = this.transform.forward;
						if (238520 - 119839 != 118681)
						{
							continue;
						}
						this.hPteLn1l0E.actionState = "standby";
						if (73973 - 447615 == -373641)
						{
							continue;
						}
						this.hPteLn1l0E.myAttackTarget = this.hPteLn1l0E.getHateTarget(12, 50);
						if (106999 - 363725 != -256726)
						{
							continue;
						}
						if (!this.hPteLn1l0E.myAttackTarget)
						{
							if (98279 - 288863 != -190584)
							{
								continue;
							}
							this.hPteLn1l0E.isAlert = false;
							if (75346 - 584069 == -508722)
							{
								continue;
							}
							this.I4WeESmkKN = Time.time;
							if (223275 - 382434 == -159158)
							{
								continue;
							}
							this.hPteLn1l0E.myAttackTarget = null;
							if (81273 - 452865 != -371592)
							{
								continue;
							}
							this.hPteLn1l0E.mOriginalPosition = this.transform.position;
							if (33866 - 328897 != -295030)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.hPteLn1l0E.myAttackTarget;
							if (249764 - 589858 != -340094)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (88105 - 341830 != -253725)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (203376 - 341643 == -138266)
								{
									continue;
								}
								this.hPteLn1l0E.isAlert = false;
								if (163116 - 164021 != -905)
								{
									continue;
								}
								this.I4WeESmkKN = Time.time;
								if (164056 - 326686 != -162630)
								{
									continue;
								}
								this.hPteLn1l0E.myAttackTarget = null;
								if (116380 - 71743 == 44638)
								{
									continue;
								}
							}
							else
							{
								this.hPteLn1l0E.vDirection = myAttackTarget.transform.position;
								if (175961 - 319247 != -143286)
								{
									continue;
								}
								this.hPteLn1l0E.vDirection.y = this.transform.position.y;
								if (71669 - 342185 == -270515)
								{
									continue;
								}
								this.hPteLn1l0E.vMovement = (this.hPteLn1l0E.vDirection - this.transform.position).normalized;
								if (116647 - 69736 != 46911)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.hPteLn1l0E.vMovement);
								if (254540 - 549025 == -294484)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.t9LePy0VPO += mTime;
		}
		while (34390 - 255901 != -221511);
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x0013072C File Offset: 0x0012E92C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (7925 - 50693 != -42768)
		{
		}
		do
		{
			if (Time.time - this.I4WeESmkKN >= this.t9LePy0VPO)
			{
				if (130853 - 269834 != -138981)
				{
					continue;
				}
				if (Time.time - this.I4WeESmkKN < this.t9LePy0VPO + mTime)
				{
					if (203488 - 323061 == -119572)
					{
						continue;
					}
					if (!this.hPteLn1l0E.myAttackTarget)
					{
						if (13398 - 308417 != -295019)
						{
							continue;
						}
						this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
						if (116515 - 72762 != 43753)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.hPteLn1l0E.myAttackTarget;
						if (180652 - 341381 == -160728)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (285841 - 94444 != 191397)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (148009 - 499508 != -351499)
						{
							continue;
						}
						if (122904 - 296009 != -173105)
						{
							continue;
						}
						if (characterControl)
						{
							if (248909 - 438491 == -189581)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (279736 - 8163 != 271573)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (29273 - 217148 == -187874)
						{
							continue;
						}
						int num2 = UnityEngine.Random.Range(0, 100);
						if (77154 - 333576 != -256422)
						{
							continue;
						}
						if ((float)(this.KiSewAio8n.hp + this.VdneUnSjJg.hp) < ((float)1 - 0.2f * (float)this.GFLeSZnBGD) * (float)(this.KiSewAio8n.mhp + this.VdneUnSjJg.mhp))
						{
							if (291813 - 30953 != 260860)
							{
								continue;
							}
							this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
							if (119395 - 303501 == -184105)
							{
								continue;
							}
							this.fOPeN6Jgbf.StartCoroutine_Auto(this.fOPeN6Jgbf.RPC_skyHigh(this.transform.position, this.transform.forward, 0));
							if (38718 - 205734 == -167015)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (105060 - 94814 == 10247)
								{
									continue;
								}
								this.fOPeN6Jgbf.ActionEvent("RPC_skyHigh", this.transform.position, this.transform.forward, 0);
								if (102883 - 133475 == -30591)
								{
									continue;
								}
							}
							this.GFLeSZnBGD++;
							if (67156 - 125947 != -58791)
							{
								continue;
							}
						}
						else
						{
							if (Game.useAdvanceMode)
							{
								goto IL_37A;
							}
							if (151329 - 482672 != -331343)
							{
								continue;
							}
							if (this.KiSewAio8n.hp <= 0)
							{
								goto IL_37A;
							}
							if (200044 - 147848 == 52197)
							{
								continue;
							}
							if (this.VdneUnSjJg.hp <= 0)
							{
								if (172833 - 363030 != -190196)
								{
									goto IL_37A;
								}
								continue;
							}
							IL_797:
							if (this.hPteLn1l0E.isTimeOut("skyBolt") == (float)0)
							{
								if (200832 - 441068 == -240235)
								{
									continue;
								}
								this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
								if (259071 - 272091 != -13020)
								{
									continue;
								}
								this.fOPeN6Jgbf.StartCoroutine_Auto(this.fOPeN6Jgbf.RPC_skyBolt(this.transform.position, this.transform.forward, 0));
								if (184056 - 503193 != -319136)
								{
									if (PhotonClient.IsInitialized())
									{
										if (167054 - 261965 == -94910)
										{
											continue;
										}
										this.fOPeN6Jgbf.ActionEvent("RPC_skyBolt", this.transform.position, this.transform.forward, 0);
										if (161466 - 251352 == -89885)
										{
											continue;
										}
									}
									goto IL_829;
								}
								continue;
							}
							else if (this.hPteLn1l0E.isTimeOut("skyOrb") == (float)0)
							{
								if (197886 - 239311 == -41424)
								{
									continue;
								}
								this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
								if (217584 - 585323 != -367739)
								{
									continue;
								}
								this.fOPeN6Jgbf.StartCoroutine_Auto(this.fOPeN6Jgbf.RPC_skyOrb(this.transform.position, this.transform.forward, 0));
								if (296077 - 88463 != 207615)
								{
									if (PhotonClient.IsInitialized())
									{
										if (249178 - 41267 == 207912)
										{
											continue;
										}
										this.fOPeN6Jgbf.ActionEvent("RPC_skyOrb", this.transform.position, this.transform.forward, 0);
										if (295844 - 93170 != 202674)
										{
											continue;
										}
									}
									goto IL_829;
								}
								continue;
							}
							else if (this.hPteLn1l0E.isTimeOut("nAttack") == (float)0)
							{
								if (262375 - 306471 != -44096)
								{
									continue;
								}
								this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
								if (18382 - 576922 != -558540)
								{
									continue;
								}
								this.fOPeN6Jgbf.StartCoroutine_Auto(this.fOPeN6Jgbf.RPC_skyWind(this.transform.position, this.transform.forward, 0));
								if (171610 - 528711 != -357100)
								{
									if (PhotonClient.IsInitialized())
									{
										if (73306 - 99300 == -25993)
										{
											continue;
										}
										this.fOPeN6Jgbf.ActionEvent("RPC_skyWind", this.transform.position, this.transform.forward, 0);
										if (237862 - 312768 == -74905)
										{
											continue;
										}
									}
									goto IL_829;
								}
								continue;
							}
							else
							{
								this.AI_state = "attack";
								if (1874 - 12887 == -11012)
								{
									continue;
								}
								this.hPteLn1l0E.vDirection = this.gameObject.transform.forward;
								if (239525 - 14608 == 224918)
								{
									continue;
								}
								this.hPteLn1l0E.vMovement = this.gameObject.transform.forward;
								if (219485 - 222648 != -3163)
								{
									continue;
								}
								this.hPteLn1l0E.actionState = "standby";
								if (263400 - 1638 != 261762)
								{
									continue;
								}
								this.animation.Play("root");
								if (147073 - 437442 != -290369)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (18064 - 277958 == -259893)
								{
									continue;
								}
								this.hPteLn1l0E.moveSpeed = (float)0;
								if (282220 - 404528 != -122308)
								{
									continue;
								}
								goto IL_829;
							}
							IL_37A:
							if (this.hPteLn1l0E.isTimeOut("perfectStorm") != (float)0)
							{
								goto IL_797;
							}
							if (238976 - 434158 == -195181)
							{
								continue;
							}
							this.I4WeESmkKN = Time.time - mTime - this.t9LePy0VPO;
							if (263633 - 157801 == 105833)
							{
								continue;
							}
							this.fOPeN6Jgbf.StartCoroutine_Auto(this.fOPeN6Jgbf.RPC_perfectStorm(this.transform.position, this.transform.forward, 0));
							if (38637 - 294687 == -256049)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (121758 - 305290 != -183532)
								{
									continue;
								}
								this.fOPeN6Jgbf.ActionEvent("RPC_perfectStorm", this.transform.position, this.transform.forward, 0);
								if (250159 - 316050 == -65890)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_829:
			this.t9LePy0VPO += mTime;
		}
		while (247889 - 307429 == -59539);
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x001310FC File Offset: 0x0012F2FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (228157 - 501303 != -273145)
		{
		}
		while (Time.time - this.I4WeESmkKN > this.t9LePy0VPO)
		{
			if (49252 - 237638 == -188386)
			{
				this.AI_state = "none";
				if (297445 - 554346 == -256901)
				{
					this.I4WeESmkKN = Time.time;
					if (266906 - 341136 == -74230)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x001311B0 File Offset: 0x0012F3B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (148938 - 192949 != -44011)
		{
		}
		for (;;)
		{
			IL_537:
			if (this.xEbeB8uBxE + (float)1 > Time.time)
			{
				if (244158 - 261982 != -17823)
				{
					break;
				}
			}
			else
			{
				this.xEbeB8uBxE = Time.time;
				if (274833 - 567131 == -292298)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position - (float)8 * Vector3.up, (float)50, this.gameObject.layer);
					if (132548 - 397068 == -264520)
					{
						if (235533 - 238071 == -2538)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (250464 - 587332 == -336868)
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
									if (193667 - 384921 == -191253)
									{
										goto IL_537;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (198105 - 53823 != 144282)
									{
										goto IL_537;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (120756 - 394135 == -273378)
									{
										goto IL_537;
									}
									bool flag = true;
									if (278081 - 503169 == -225087)
									{
										goto IL_537;
									}
									eRace race = this.hPteLn1l0E.Race;
									if (292354 - 175619 == 116736)
									{
										goto IL_537;
									}
									if (race == eRace.Tails)
									{
										if (66629 - 34668 != 31961)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_1A;
										}
										if (176358 - 267238 == -90879)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (175933 - 564812 != -388878)
											{
												goto IL_1A;
											}
											goto IL_537;
										}
										goto IL_310;
										IL_1A:
										flag = false;
										if (285955 - 250731 != 35224)
										{
											goto IL_537;
										}
									}
									else if (race == eRace.Plants)
									{
										if (181627 - 265240 == -83612)
										{
											goto IL_537;
										}
										flag = false;
										if (82748 - 126006 != -43258)
										{
											goto IL_537;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (79391 - 530929 == -451537)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_D6;
										}
										if (67719 - 305208 != -237489)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (139912 - 8520 != 131393)
											{
												goto IL_D6;
											}
											goto IL_537;
										}
										goto IL_310;
										IL_D6:
										flag = false;
										if (155666 - 491369 == -335702)
										{
											goto IL_537;
										}
									}
									else if (race == eRace.Robots)
									{
										if (2592 - 94988 != -92396)
										{
											goto IL_537;
										}
										flag = true;
										if (73544 - 332060 != -258516)
										{
											goto IL_537;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (196910 - 317250 != -120340)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_492;
										}
										if (294440 - 253815 == 40626)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_492;
										}
										if (277702 - 64512 == 213191)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (266017 - 469012 != -202994)
											{
												goto IL_492;
											}
											goto IL_537;
										}
										goto IL_310;
										IL_492:
										flag = false;
										if (81374 - 386974 != -305600)
										{
											goto IL_537;
										}
									}
									else if (race == eRace.Structure)
									{
										if (278506 - 101878 != 176628)
										{
											goto IL_537;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (83952 - 558642 == -474689)
											{
												goto IL_537;
											}
											flag = false;
											if (39514 - 282078 == -242563)
											{
												goto IL_537;
											}
										}
									}
									IL_310:
									if (flag)
									{
										if (83113 - 390970 == -307856)
										{
											goto IL_537;
										}
										if (characterControl.hp > 0)
										{
											if (201183 - 333445 == -132261)
											{
												goto IL_537;
											}
											if (characterControl.recieveTarget)
											{
												if (211942 - 279511 != -67569)
												{
													goto IL_537;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (262134 - 430690 != -168556)
													{
														goto IL_537;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (174956 - 474158 != -299202)
														{
															goto IL_537;
														}
														this.hPteLn1l0E.isAlert = true;
														if (121903 - 383900 == -261996)
														{
															goto IL_537;
														}
														this.I4WeESmkKN = Time.time;
														if (11444 - 187655 == -176210)
														{
															goto IL_537;
														}
														this.hPteLn1l0E.myAttackTarget = gameObject;
														if (8917 - 38857 != -29940)
														{
															goto IL_537;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (250909 - 114120 != 136789)
														{
															goto IL_537;
														}
														this.hPteLn1l0E.addHate(characterControl.ActorNr, 60);
														if (222583 - 422805 != -200222)
														{
															goto IL_537;
														}
													}
												}
											}
										}
									}
								}
								if (293956 - 466818 != -172861)
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

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00131810 File Offset: 0x0012FA10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00131814 File Offset: 0x0012FA14
	internal static bool HcTGBsWeyCdoDPXbibe()
	{
		return true;
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x00131818 File Offset: 0x0012FA18
	internal static bool t5twTbWr9OBQkdfhAtk()
	{
		return false;
	}

	// Token: 0x04000A91 RID: 2705
	private CharacterControl hPteLn1l0E;

	// Token: 0x04000A92 RID: 2706
	private CharacterControl KiSewAio8n;

	// Token: 0x04000A93 RID: 2707
	private CharacterControl VdneUnSjJg;

	// Token: 0x04000A94 RID: 2708
	private SkyBug fOPeN6Jgbf;

	// Token: 0x04000A95 RID: 2709
	public string AI_state;

	// Token: 0x04000A96 RID: 2710
	private float I4WeESmkKN;

	// Token: 0x04000A97 RID: 2711
	private float t9LePy0VPO;

	// Token: 0x04000A98 RID: 2712
	private int GFLeSZnBGD;

	// Token: 0x04000A99 RID: 2713
	private float xEbeB8uBxE;
}
