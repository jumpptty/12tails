using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E30 RID: 3632
[Serializable]
public class Matti_AI : MonoBehaviour
{
	// Token: 0x0600521E RID: 21022 RVA: 0x00A062E4 File Offset: 0x00A044E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Matti_AI()
	{
		if (34590 - 573005 != -538415)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (261416 - 526649 != -265232)
			{
				base..ctor();
				if (240295 - 321452 == -81157)
				{
					this.AI_state = "none";
					if (234668 - 255647 == -20979)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600521F RID: 21023 RVA: 0x00A06380 File Offset: 0x00A04580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.nSDceDSEWds = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Qsgcemu8BCh = (Matti)this.GetComponent(typeof(Matti));
	}

	// Token: 0x06005220 RID: 21024 RVA: 0x00A063B8 File Offset: 0x00A045B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (287884 - 576469 != -288585)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (244332 - 258930 == -14597)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (96360 - 284690 == -188329)
				{
					continue;
				}
			}
			if (this.nSDceDSEWds.isControlled)
			{
				break;
			}
			if (3756 - 300816 == -297060)
			{
				this.AIControl();
				if (62898 - 345891 != -282992)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005221 RID: 21025 RVA: 0x00A06484 File Offset: 0x00A04684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (214128 - 527873 != -313745)
		{
		}
		for (;;)
		{
			this.z8AceocmOhT = (float)0;
			if (245784 - 408725 != -162940)
			{
				if (this.nSDceDSEWds.isMine)
				{
					if (139437 - 161998 == -22561)
					{
						if (this.nSDceDSEWds.actionState != "standby")
						{
							if (62634 - 389719 != -327085)
							{
								continue;
							}
							if (this.nSDceDSEWds.actionState != "run")
							{
								if (267773 - 161199 != 106575)
								{
									break;
								}
								continue;
							}
						}
						if (!this.nSDceDSEWds.isAlert)
						{
							if (221431 - 390933 == -169502)
							{
								this.AI_idle(3f, 1f);
								if (94981 - 185428 == -90447)
								{
									this.AI_patrol(1f, 0.5f);
									if (77391 - 289839 == -212448)
									{
										this.AI_resetTimer();
										if (280699 - 599934 == -319235)
										{
											this.AI_visionCheck();
											if (287152 - 90178 == 196974)
											{
												if (!this.nSDceDSEWds.myAttackTarget)
												{
													break;
												}
												if (266593 - 215349 != 51245)
												{
													this.nSDceDSEWds.isAlert = true;
													if (173397 - 306851 == -133454)
													{
														this.SdIcejhrYhO = Time.time;
														if (199857 - 307126 == -107269)
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
							if (22608 - 533803 != -511194)
							{
								this.AI_patrol(1f, 0.25f);
								if (47678 - 257624 != -209945)
								{
									this.AI_attack(10f, (float)0);
									if (128914 - 136447 == -7533)
									{
										this.AI_resetTimer();
										if (124688 - 20958 != 103731)
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
					if (this.nSDceDSEWds.actionState != "standby")
					{
						if (186998 - 451242 != -264244)
						{
							continue;
						}
						if (this.nSDceDSEWds.actionState != "run")
						{
							if (270720 - 548859 != -278138)
							{
								break;
							}
							continue;
						}
					}
					float num = this.nSDceDSEWds.moveSpeed;
					if (121389 - 373780 != -252390)
					{
						float runSpeed = this.nSDceDSEWds.runSpeed;
						if (19321 - 509725 != -490403)
						{
							Vector3 vector = default(Vector3);
							if (250916 - 79613 == 171303)
							{
								Vector3 vector2 = Vector3.zero;
								if (58131 - 25731 != 32401)
								{
									if ((this.nSDceDSEWds.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (80921 - 381625 != -300704)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.nSDceDSEWds.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (196698 - 334457 == -137758)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (100892 - 136096 != -35204)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (55298 - 437164 == -381865)
											{
												continue;
											}
											num = (float)0;
											if (271392 - 171034 == 100359)
											{
												continue;
											}
											this.transform.position = this.nSDceDSEWds.nPosition;
											if (61908 - 242795 != -180887)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (136454 - 528993 != -392539)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (70375 - 453676 == -383300)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (192386 - 576314 != -383928)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (90336 - 422812 != -332476)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (297559 - 3954 == 293606)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (146388 - 503770 != -357382)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (116218 - 165337 != -49119)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (168756 - 341886 == -173129)
											{
												continue;
											}
										}
									}
									this.nSDceDSEWds.vMovement = vector2;
									if (277223 - 262742 == 14481)
									{
										this.nSDceDSEWds.moveSpeed = num;
										if (294616 - 348765 != -54148)
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

	// Token: 0x06005222 RID: 21026 RVA: 0x00A06AFC File Offset: 0x00A04CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (11739 - 421231 != -409491)
		{
		}
		do
		{
			if (Time.time - this.SdIcejhrYhO >= this.z8AceocmOhT)
			{
				if (136156 - 213870 != -77714)
				{
					continue;
				}
				if (Time.time - this.SdIcejhrYhO < this.z8AceocmOhT + mTime)
				{
					if (224313 - 424846 == -200532)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (20294 - 528141 != -507847)
						{
							continue;
						}
						this.AI_state = "idle";
						if (240675 - 203320 == 37356)
						{
							continue;
						}
						this.SdIcejhrYhO -= UnityEngine.Random.Range((float)0, rTimer);
						if (221403 - 271728 == -50324)
						{
							continue;
						}
						this.nSDceDSEWds.vDirection = Vector3.zero;
						if (260958 - 41331 == 219628)
						{
							continue;
						}
						this.nSDceDSEWds.vMovement = this.transform.forward;
						if (46461 - 302090 == -255628)
						{
							continue;
						}
						this.nSDceDSEWds.actionState = "standby";
						if (286496 - 597772 != -311276)
						{
							continue;
						}
					}
					this.nSDceDSEWds.moveSpeed = Mathf.Lerp(this.nSDceDSEWds.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (227359 - 543304 == -315944)
					{
						continue;
					}
					if (this.nSDceDSEWds.moveSpeed < 0.1f * this.nSDceDSEWds.runSpeed)
					{
						if (85892 - 338094 == -252201)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (137078 - 240961 == -103882)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (96666 - 554795 != -458129)
						{
							continue;
						}
						this.nSDceDSEWds.moveSpeed = (float)0;
						if (274404 - 189579 != 84825)
						{
							continue;
						}
					}
				}
			}
			this.z8AceocmOhT += mTime;
		}
		while (123260 - 466836 == -343575);
	}

	// Token: 0x06005223 RID: 21027 RVA: 0x00A06DC0 File Offset: 0x00A04FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (78798 - 282491 != -203693)
		{
		}
		for (;;)
		{
			this.nSDceDSEWds.vDirection = followObject.transform.position;
			if (1690 - 406192 == -404502)
			{
				this.nSDceDSEWds.vDirection.y = this.transform.position.y;
				if (187633 - 101455 == 86178)
				{
					this.nSDceDSEWds.vMovement = (this.nSDceDSEWds.vDirection - this.transform.position).normalized;
					if (236490 - 303719 == -67229)
					{
						this.transform.rotation = Quaternion.LookRotation(this.nSDceDSEWds.vMovement);
						if (137535 - 480618 == -343083)
						{
							this.nSDceDSEWds.actionState = "run";
							if (36809 - 308154 == -271345)
							{
								this.animation.Play("run");
								if (64610 - 225498 == -160888)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (107612 - 296186 != -188573)
									{
										this.nSDceDSEWds.moveSpeed = Mathf.Lerp(this.nSDceDSEWds.moveSpeed, this.nSDceDSEWds.runSpeed, (float)4 * Time.deltaTime);
										if (285880 - 25666 == 260214)
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

	// Token: 0x06005224 RID: 21028 RVA: 0x00A06FA8 File Offset: 0x00A051A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (60233 - 225542 != -165308)
		{
		}
		do
		{
			if (Time.time - this.SdIcejhrYhO >= this.z8AceocmOhT)
			{
				if (220878 - 441113 != -220235)
				{
					continue;
				}
				if (Time.time - this.SdIcejhrYhO < this.z8AceocmOhT + mTime)
				{
					if (229296 - 381182 == -151885)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (268850 - 267890 != 960)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (202651 - 46120 != 156531)
						{
							continue;
						}
						this.SdIcejhrYhO -= UnityEngine.Random.Range((float)0, rTimer);
						if (2033 - 454873 == -452839)
						{
							continue;
						}
						this.nSDceDSEWds.vDirection = this.nSDceDSEWds.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (89553 - 406442 != -316889)
						{
							continue;
						}
						this.nSDceDSEWds.vDirection.y = this.transform.position.y;
						if (97257 - 168115 != -70858)
						{
							continue;
						}
						this.nSDceDSEWds.vMovement = (this.nSDceDSEWds.vDirection - this.transform.position).normalized;
						if (256084 - 284104 != -28020)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.nSDceDSEWds.vMovement);
						if (33878 - 569896 != -536018)
						{
							continue;
						}
						this.nSDceDSEWds.actionState = "run";
						if (144672 - 76268 == 68405)
						{
							continue;
						}
						this.animation.Play("run");
						if (136467 - 408521 != -272054)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (236902 - 79202 != 157700)
						{
							continue;
						}
					}
					this.nSDceDSEWds.moveSpeed = Mathf.Lerp(this.nSDceDSEWds.moveSpeed, this.nSDceDSEWds.runSpeed, (float)4 * Time.deltaTime);
					if (258738 - 204402 != 54336)
					{
						continue;
					}
				}
			}
			this.z8AceocmOhT += mTime;
		}
		while (62630 - 432999 == -370368);
	}

	// Token: 0x06005225 RID: 21029 RVA: 0x00A072B0 File Offset: 0x00A054B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (160138 - 409027 != -248888)
		{
		}
		do
		{
			if (Time.time - this.SdIcejhrYhO >= this.z8AceocmOhT)
			{
				if (294624 - 165272 == 129353)
				{
					continue;
				}
				if (Time.time - this.SdIcejhrYhO < this.z8AceocmOhT + mTime)
				{
					if (238618 - 298033 != -59415)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (64664 - 11795 == 52870)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (126271 - 106287 == 19985)
						{
							continue;
						}
						this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
						if (141506 - 37902 == 103605)
						{
							continue;
						}
						this.nSDceDSEWds.vDirection = Vector3.zero;
						if (32455 - 240053 != -207598)
						{
							continue;
						}
						this.nSDceDSEWds.vMovement = this.transform.forward;
						if (79185 - 504289 == -425103)
						{
							continue;
						}
						this.nSDceDSEWds.actionState = "standby";
						if (171803 - 156872 != 14931)
						{
							continue;
						}
						this.nSDceDSEWds.myAttackTarget = this.nSDceDSEWds.getHateTarget(5, 50);
						if (40320 - 247910 != -207590)
						{
							continue;
						}
						if (!this.nSDceDSEWds.myAttackTarget)
						{
							if (238387 - 395765 == -157377)
							{
								continue;
							}
							this.nSDceDSEWds.isAlert = false;
							if (150473 - 96549 != 53924)
							{
								continue;
							}
							this.SdIcejhrYhO = Time.time;
							if (160032 - 122615 == 37418)
							{
								continue;
							}
							this.nSDceDSEWds.myAttackTarget = null;
							if (127028 - 356316 != -229288)
							{
								continue;
							}
							this.nSDceDSEWds.mOriginalPosition = this.transform.position;
							if (182486 - 510507 != -328020)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.nSDceDSEWds.myAttackTarget;
							if (25791 - 174591 == -148799)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (255124 - 520477 == -265352)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (18760 - 259039 == -240278)
								{
									continue;
								}
								this.nSDceDSEWds.isAlert = false;
								if (252487 - 501060 == -248572)
								{
									continue;
								}
								this.SdIcejhrYhO = Time.time;
								if (163211 - 583151 != -419940)
								{
									continue;
								}
								this.nSDceDSEWds.myAttackTarget = null;
								if (179187 - 145030 == 34158)
								{
									continue;
								}
							}
							else
							{
								this.nSDceDSEWds.vDirection = myAttackTarget.transform.position;
								if (283822 - 99995 != 183827)
								{
									continue;
								}
								this.nSDceDSEWds.vDirection.y = this.transform.position.y;
								if (188025 - 455022 == -266996)
								{
									continue;
								}
								this.nSDceDSEWds.vMovement = (this.nSDceDSEWds.vDirection - this.transform.position).normalized;
								if (297406 - 477557 != -180151)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.nSDceDSEWds.vMovement);
								if (152886 - 119693 == 33194)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.z8AceocmOhT += mTime;
		}
		while (158541 - 415344 != -256803);
	}

	// Token: 0x06005226 RID: 21030 RVA: 0x00A07760 File Offset: 0x00A05960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (266022 - 356606 != -90584)
		{
		}
		do
		{
			if (Time.time - this.SdIcejhrYhO >= this.z8AceocmOhT)
			{
				if (199615 - 163279 != 36336)
				{
					continue;
				}
				if (Time.time - this.SdIcejhrYhO < this.z8AceocmOhT + mTime)
				{
					if (186796 - 302307 != -115511)
					{
						continue;
					}
					if (!this.nSDceDSEWds.myAttackTarget)
					{
						if (100660 - 583412 != -482752)
						{
							continue;
						}
						this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
						if (202079 - 498223 != -296144)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.nSDceDSEWds.myAttackTarget;
						if (22928 - 133922 == -110993)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (91196 - 510854 == -419657)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (50053 - 578848 != -528795)
						{
							continue;
						}
						int tID = 0;
						if (12554 - 344570 != -332016)
						{
							continue;
						}
						if (characterControl)
						{
							if (9901 - 429544 != -419643)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (288808 - 241144 == 47665)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (234703 - 390258 != -155555)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (280619 - 64733 != 215886)
							{
								continue;
							}
							if ((float)this.nSDceDSEWds.hp < 0.33f * (float)this.nSDceDSEWds.mhp)
							{
								if (129763 - 114765 != 14998)
								{
									continue;
								}
								if (this.nSDceDSEWds.isTimeOut("murder") == (float)0)
								{
									if (219670 - 33756 != 185914)
									{
										continue;
									}
									this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
									if (157309 - 378089 != -220780)
									{
										continue;
									}
									this.Qsgcemu8BCh.StartCoroutine_Auto(this.Qsgcemu8BCh.RPC_murder(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
									if (236497 - 398441 != -161944)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (247198 - 240127 != 7071)
										{
											continue;
										}
										this.Qsgcemu8BCh.ActionEvent("RPC_murder", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (9789 - 191164 != -181375)
										{
											continue;
										}
									}
									goto IL_96F;
								}
							}
						}
						if (num < (float)5)
						{
							if (174282 - 171367 != 2915)
							{
								continue;
							}
							if ((float)this.nSDceDSEWds.hp < 0.66f * (float)this.nSDceDSEWds.mhp)
							{
								if (73943 - 257954 != -184011)
								{
									continue;
								}
								if (this.nSDceDSEWds.isTimeOut("meatGrinder") == (float)0)
								{
									if (131584 - 315054 != -183470)
									{
										continue;
									}
									this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
									if (217578 - 304243 != -86665)
									{
										continue;
									}
									this.Qsgcemu8BCh.StartCoroutine_Auto(this.Qsgcemu8BCh.RPC_meatGrinder(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
									if (185551 - 265389 != -79837)
									{
										if (PhotonClient.IsInitialized())
										{
											if (81374 - 243969 != -162595)
											{
												continue;
											}
											this.Qsgcemu8BCh.ActionEvent("RPC_meatGrinder", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
											if (118088 - 388020 != -269932)
											{
												continue;
											}
										}
										goto IL_96F;
									}
									continue;
								}
							}
						}
						if (num < (float)4)
						{
							if (146710 - 149038 == -2327)
							{
								continue;
							}
							if (this.nSDceDSEWds.isTimeOut("rollStrike") == (float)0)
							{
								if (63989 - 453726 != -389737)
								{
									continue;
								}
								this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
								if (268382 - 17596 == 250787)
								{
									continue;
								}
								this.Qsgcemu8BCh.StartCoroutine_Auto(this.Qsgcemu8BCh.RPC_rollStrike(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (259679 - 40296 != 219384)
								{
									if (PhotonClient.IsInitialized())
									{
										if (227269 - 383512 == -156242)
										{
											continue;
										}
										this.Qsgcemu8BCh.ActionEvent("RPC_rollStrike", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (285874 - 179756 == 106119)
										{
											continue;
										}
									}
									goto IL_96F;
								}
								continue;
							}
						}
						if (num > (float)4)
						{
							if (66759 - 214760 != -148001)
							{
								continue;
							}
							if (!this.nSDceDSEWds.hasStatus("blend"))
							{
								if (150147 - 16234 != 133913)
								{
									continue;
								}
								if (this.nSDceDSEWds.isTimeOut("noTrace") == (float)0)
								{
									if (71390 - 442858 == -371467)
									{
										continue;
									}
									this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
									if (103619 - 148875 != -45256)
									{
										continue;
									}
									this.Qsgcemu8BCh.StartCoroutine_Auto(this.Qsgcemu8BCh.RPC_noTrace(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
									if (155496 - 440859 != -285362)
									{
										if (PhotonClient.IsInitialized())
										{
											if (128563 - 259000 != -130437)
											{
												continue;
											}
											this.Qsgcemu8BCh.ActionEvent("RPC_noTrace", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
											if (75626 - 310437 == -234810)
											{
												continue;
											}
										}
										goto IL_96F;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (65063 - 113844 != -48781)
							{
								continue;
							}
							if (this.nSDceDSEWds.isTimeOut("nAttack") == (float)0)
							{
								if (257300 - 465759 == -208458)
								{
									continue;
								}
								this.SdIcejhrYhO = Time.time - mTime - this.z8AceocmOhT;
								if (216626 - 533708 == -317081)
								{
									continue;
								}
								this.Qsgcemu8BCh.StartCoroutine_Auto(this.Qsgcemu8BCh.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (141591 - 49482 != 92109)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (225170 - 79454 == 145717)
									{
										continue;
									}
									this.Qsgcemu8BCh.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
									if (226256 - 102406 != 123850)
									{
										continue;
									}
								}
								goto IL_96F;
							}
						}
						this.AI_state = "attack";
						if (212211 - 529494 == -317282)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (144208 - 292140 == -147931)
							{
								continue;
							}
							this.nSDceDSEWds.vDirection = myAttackTarget.transform.position;
							if (152303 - 330666 != -178363)
							{
								continue;
							}
							this.nSDceDSEWds.vDirection.y = this.transform.position.y;
							if (65893 - 1394 != 64499)
							{
								continue;
							}
							this.nSDceDSEWds.vMovement = (this.nSDceDSEWds.vDirection - this.transform.position).normalized;
							if (242244 - 82332 == 159913)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.nSDceDSEWds.vMovement);
							if (21972 - 238610 != -216638)
							{
								continue;
							}
							this.nSDceDSEWds.actionState = "run";
							if (92462 - 380908 == -288445)
							{
								continue;
							}
							this.animation.Play("run");
							if (285270 - 324471 != -39201)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (38778 - 379462 == -340683)
							{
								continue;
							}
							this.nSDceDSEWds.moveSpeed = Mathf.Lerp(this.nSDceDSEWds.moveSpeed, this.nSDceDSEWds.runSpeed, (float)4 * Time.deltaTime);
							if (69310 - 378836 != -309526)
							{
								continue;
							}
						}
						else
						{
							this.nSDceDSEWds.vDirection = myAttackTarget.transform.position;
							if (183539 - 336329 == -152789)
							{
								continue;
							}
							this.nSDceDSEWds.vDirection.y = this.transform.position.y;
							if (83882 - 103454 == -19571)
							{
								continue;
							}
							this.nSDceDSEWds.vMovement = (this.nSDceDSEWds.vDirection - this.transform.position).normalized;
							if (162014 - 259972 != -97958)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.nSDceDSEWds.vMovement);
							if (111583 - 490430 == -378846)
							{
								continue;
							}
							this.nSDceDSEWds.actionState = "standby";
							if (239143 - 108913 != 130230)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (79457 - 4052 != 75405)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (244168 - 591199 != -347031)
							{
								continue;
							}
							this.nSDceDSEWds.moveSpeed = Mathf.Lerp(this.nSDceDSEWds.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (249775 - 509615 == -259839)
							{
								continue;
							}
						}
					}
				}
			}
			IL_96F:
			this.z8AceocmOhT += mTime;
		}
		while (60422 - 462292 != -401870);
	}

	// Token: 0x06005227 RID: 21031 RVA: 0x00A08500 File Offset: 0x00A06700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (107460 - 185512 != -78052)
		{
		}
		while (Time.time - this.SdIcejhrYhO > this.z8AceocmOhT)
		{
			if (4732 - 465707 != -460974)
			{
				this.AI_state = "none";
				if (219643 - 562960 == -343317)
				{
					this.SdIcejhrYhO = Time.time;
					if (107921 - 321968 == -214047)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005228 RID: 21032 RVA: 0x00A085B4 File Offset: 0x00A067B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (152672 - 27494 != 125179)
		{
		}
		for (;;)
		{
			IL_622:
			if (this.fgjcekxHCju > Time.time)
			{
				if (297581 - 154530 == 143051)
				{
					break;
				}
			}
			else
			{
				this.fgjcekxHCju = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (225842 - 152500 == 73342)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (293484 - 589333 != -295848 && 131723 - 32877 != 98847)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (267934 - 411144 != -143209)
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
								if (258911 - 76930 != 181981)
								{
									goto IL_622;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (179013 - 462198 != -283185)
								{
									goto IL_622;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (169915 - 57686 == 112230)
								{
									goto IL_622;
								}
								bool flag = true;
								if (184811 - 582981 == -398169)
								{
									goto IL_622;
								}
								eRace race = this.nSDceDSEWds.Race;
								if (269682 - 517025 == -247342)
								{
									goto IL_622;
								}
								if (race == eRace.Tails)
								{
									if (150064 - 225239 != -75175)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_197;
									}
									if (294087 - 25900 == 268188)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (234159 - 374283 != -140124)
										{
											goto IL_622;
										}
										goto IL_197;
									}
									goto IL_5C2;
									IL_197:
									flag = false;
									if (171268 - 493215 != -321947)
									{
										goto IL_622;
									}
								}
								else if (race == eRace.Plants)
								{
									if (28143 - 440607 != -412464)
									{
										goto IL_622;
									}
									flag = false;
									if (230336 - 592810 != -362474)
									{
										goto IL_622;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (114434 - 475611 != -361177)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_5E2;
									}
									if (215860 - 554132 == -338271)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (45708 - 12200 != 33509)
										{
											goto IL_5E2;
										}
										goto IL_622;
									}
									goto IL_5C2;
									IL_5E2:
									flag = false;
									if (180756 - 425468 != -244712)
									{
										goto IL_622;
									}
								}
								else if (race == eRace.Robots)
								{
									if (70916 - 191524 == -120607)
									{
										goto IL_622;
									}
									flag = true;
									if (44199 - 14083 != 30116)
									{
										goto IL_622;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (54888 - 415756 != -360868)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_139;
									}
									if (208860 - 96719 != 112141)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_139;
									}
									if (78891 - 81152 != -2261)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (61762 - 540695 != -478932)
										{
											goto IL_139;
										}
										goto IL_622;
									}
									goto IL_5C2;
									IL_139:
									flag = false;
									if (111961 - 473111 == -361149)
									{
										goto IL_622;
									}
								}
								else if (race == eRace.Structure)
								{
									if (242926 - 455905 != -212979)
									{
										goto IL_622;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (160971 - 90116 != 70855)
										{
											goto IL_622;
										}
										flag = false;
										if (202408 - 453259 != -250851)
										{
											goto IL_622;
										}
									}
								}
								IL_5C2:
								if (flag)
								{
									if (9457 - 230503 == -221045)
									{
										goto IL_622;
									}
									if (characterControl.hp > 0)
									{
										if (291878 - 295847 != -3969)
										{
											goto IL_622;
										}
										if (characterControl.recieveTarget)
										{
											if (134418 - 13301 != 121117)
											{
												goto IL_622;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (299785 - 109044 != 190741)
												{
													goto IL_622;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (264641 - 356019 == -91377)
													{
														goto IL_622;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (226701 - 447325 != -220624)
													{
														goto IL_622;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (132550 - 108007 == 24544)
														{
															goto IL_622;
														}
														this.nSDceDSEWds.myAttackTarget = gameObject;
														if (174903 - 13019 == 161885)
														{
															goto IL_622;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (77886 - 498820 != -420934)
														{
															goto IL_622;
														}
														this.nSDceDSEWds.addHate(characterControl.ActorNr, 5);
														if (264131 - 54066 != 210065)
														{
															goto IL_622;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (46142 - 535042 == -488899)
														{
															goto IL_622;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (264330 - 464939 == -200608)
														{
															goto IL_622;
														}
														if (num < (float)60)
														{
															if (16346 - 345748 == -329401)
															{
																goto IL_622;
															}
															if (characterControl.hp > 0)
															{
																if (108542 - 467988 != -359446)
																{
																	goto IL_622;
																}
																this.nSDceDSEWds.myAttackTarget = gameObject;
																if (207017 - 54299 == 152719)
																{
																	goto IL_622;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (253464 - 199095 != 54369)
																{
																	goto IL_622;
																}
																this.nSDceDSEWds.addHate(characterControl.ActorNr, 5);
																if (86459 - 453400 == -366940)
																{
																	goto IL_622;
																}
															}
														}
													}
													if (this.nSDceDSEWds.myAttackTarget)
													{
														if (281887 - 307015 == -25127)
														{
															goto IL_622;
														}
														this.nSDceDSEWds.isAlert = true;
														if (96459 - 589600 != -493141)
														{
															goto IL_622;
														}
														this.SdIcejhrYhO = Time.time;
														if (110386 - 268876 != -158490)
														{
															goto IL_622;
														}
													}
												}
											}
										}
									}
								}
							}
							if (164814 - 151988 != 12827)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005229 RID: 21033 RVA: 0x00A08DCC File Offset: 0x00A06FCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600522A RID: 21034 RVA: 0x00A08DD0 File Offset: 0x00A06FD0
	internal static bool IZxhFq5jTqhuOe4sJK4V()
	{
		return true;
	}

	// Token: 0x0600522B RID: 21035 RVA: 0x00A08DD4 File Offset: 0x00A06FD4
	internal static bool y5L6nl5j3mwcg8N1pr38()
	{
		return false;
	}

	// Token: 0x04005B8F RID: 23439
	private CharacterControl nSDceDSEWds;

	// Token: 0x04005B90 RID: 23440
	private Matti Qsgcemu8BCh;

	// Token: 0x04005B91 RID: 23441
	public string AI_state;

	// Token: 0x04005B92 RID: 23442
	private float SdIcejhrYhO;

	// Token: 0x04005B93 RID: 23443
	private float z8AceocmOhT;

	// Token: 0x04005B94 RID: 23444
	private float fgjcekxHCju;
}
