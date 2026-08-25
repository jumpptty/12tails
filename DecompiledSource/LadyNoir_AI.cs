using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CC2 RID: 3266
[Serializable]
public class LadyNoir_AI : MonoBehaviour
{
	// Token: 0x06004941 RID: 18753 RVA: 0x00914940 File Offset: 0x00912B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LadyNoir_AI()
	{
		if (178538 - 300134 != -121595)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (263859 - 398981 != -135121)
			{
				base..ctor();
				if (30696 - 441115 != -410418)
				{
					this.AI_state = "none";
					if (167267 - 60167 == 107100)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004942 RID: 18754 RVA: 0x009149DC File Offset: 0x00912BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.fmUzmUIRgK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.mSmzjXFVbw = (LadyNoir)this.GetComponent(typeof(LadyNoir));
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x00914A14 File Offset: 0x00912C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (114899 - 441336 != -326437)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (215695 - 440155 != -224460)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (154661 - 152811 == 1851)
				{
					continue;
				}
			}
			if (this.fmUzmUIRgK.isControlled)
			{
				break;
			}
			if (285113 - 383782 == -98669)
			{
				this.AIControl();
				if (125132 - 465047 != -339914)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004944 RID: 18756 RVA: 0x00914AE0 File Offset: 0x00912CE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (78419 - 559816 != -481396)
		{
		}
		for (;;)
		{
			this.TNtzkYlawr = (float)0;
			if (237700 - 488219 == -250519)
			{
				if (this.fmUzmUIRgK.isMine)
				{
					if (45870 - 208617 == -162747)
					{
						if (this.fmUzmUIRgK.actionState != "standby")
						{
							if (227089 - 458553 != -231464)
							{
								continue;
							}
							if (this.fmUzmUIRgK.actionState != "run")
							{
								if (298931 - 288579 != 10352)
								{
									continue;
								}
								break;
							}
						}
						if (!this.fmUzmUIRgK.isAlert)
						{
							if (104937 - 42756 == 62181)
							{
								this.AI_idle(3f, 1f);
								if (193277 - 368612 != -175334)
								{
									this.AI_patrol(1f, 0.25f);
									if (198678 - 292375 != -93696)
									{
										this.AI_resetTimer();
										if (106672 - 380152 == -273480)
										{
											this.AI_visionCheck();
											if (162827 - 539116 != -376288)
											{
												if (!this.fmUzmUIRgK.myAttackTarget)
												{
													break;
												}
												if (155507 - 373250 == -217743)
												{
													this.fmUzmUIRgK.isAlert = true;
													if (276223 - 577401 != -301177)
													{
														this.mLtzosuY5j = Time.time;
														if (273664 - 420178 != -146513)
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
							if (15488 - 496253 == -480765)
							{
								this.AI_patrol(1f, 1f);
								if (14716 - 443250 != -428533)
								{
									this.AI_attack(10f, (float)0);
									if (131542 - 27693 == 103849)
									{
										this.AI_resetTimer();
										if (147411 - 569041 != -421629)
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
					if (this.fmUzmUIRgK.actionState != "standby")
					{
						if (108432 - 275881 == -167448)
						{
							continue;
						}
						if (this.fmUzmUIRgK.actionState != "run")
						{
							if (190424 - 462494 != -272070)
							{
								continue;
							}
							break;
						}
					}
					float num = this.fmUzmUIRgK.moveSpeed;
					if (84811 - 68246 != 16566)
					{
						float runSpeed = this.fmUzmUIRgK.runSpeed;
						if (116780 - 491616 != -374835)
						{
							Vector3 vector = default(Vector3);
							if (79749 - 40125 != 39625)
							{
								Vector3 vector2 = Vector3.zero;
								if (137899 - 219206 == -81307)
								{
									if ((this.fmUzmUIRgK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (7896 - 54690 != -46794)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.fmUzmUIRgK.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (199997 - 164052 == 35946)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (271650 - 66384 != 205266)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (55170 - 412773 != -357603)
											{
												continue;
											}
											num = (float)0;
											if (296377 - 271059 == 25319)
											{
												continue;
											}
											this.transform.position = this.fmUzmUIRgK.nPosition;
											if (1893 - 432126 == -430232)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (146212 - 340535 != -194323)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (56762 - 245814 != -189052)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (83211 - 577804 != -494593)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (273389 - 378228 != -104839)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (47244 - 353364 == -306119)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (211221 - 64900 == 146322)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (83689 - 69893 != 13796)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (100821 - 158933 != -58112)
											{
												continue;
											}
										}
									}
									this.fmUzmUIRgK.vMovement = vector2;
									if (216247 - 396564 == -180317)
									{
										this.fmUzmUIRgK.moveSpeed = num;
										if (59602 - 425502 == -365900)
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

	// Token: 0x06004945 RID: 18757 RVA: 0x00915158 File Offset: 0x00913358
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (196628 - 413062 != -216433)
		{
		}
		do
		{
			if (Time.time - this.mLtzosuY5j >= this.TNtzkYlawr)
			{
				if (242388 - 134177 != 108211)
				{
					continue;
				}
				if (Time.time - this.mLtzosuY5j < this.TNtzkYlawr + mTime)
				{
					if (119817 - 69856 == 49962)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (164150 - 72830 != 91320)
						{
							continue;
						}
						this.AI_state = "idle";
						if (221523 - 398381 == -176857)
						{
							continue;
						}
						this.mLtzosuY5j -= UnityEngine.Random.Range((float)0, rTimer);
						if (190780 - 211300 == -20519)
						{
							continue;
						}
						this.fmUzmUIRgK.vDirection = Vector3.zero;
						if (119713 - 377252 == -257538)
						{
							continue;
						}
						this.fmUzmUIRgK.vMovement = this.transform.forward;
						if (171536 - 475817 != -304281)
						{
							continue;
						}
						this.fmUzmUIRgK.actionState = "standby";
						if (65327 - 376966 != -311639)
						{
							continue;
						}
					}
					this.fmUzmUIRgK.moveSpeed = Mathf.Lerp(this.fmUzmUIRgK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (64361 - 579362 == -515000)
					{
						continue;
					}
					if (this.fmUzmUIRgK.moveSpeed < 0.1f * this.fmUzmUIRgK.runSpeed)
					{
						if (232273 - 337735 != -105462)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (49280 - 177350 != -128070)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (29615 - 221288 == -191672)
						{
							continue;
						}
						this.fmUzmUIRgK.moveSpeed = (float)0;
						if (299815 - 475900 == -176084)
						{
							continue;
						}
					}
				}
			}
			this.TNtzkYlawr += mTime;
		}
		while (120105 - 85979 != 34126);
	}

	// Token: 0x06004946 RID: 18758 RVA: 0x0091541C File Offset: 0x0091361C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (38925 - 18010 != 20915)
		{
		}
		do
		{
			if (Time.time - this.mLtzosuY5j >= this.TNtzkYlawr)
			{
				if (297447 - 228423 == 69025)
				{
					continue;
				}
				if (Time.time - this.mLtzosuY5j < this.TNtzkYlawr + mTime)
				{
					if (178944 - 579023 == -400078)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (159005 - 314815 == -155809)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (198202 - 205771 == -7568)
						{
							continue;
						}
						this.mLtzosuY5j -= UnityEngine.Random.Range((float)0, rTimer);
						if (227100 - 282259 == -55158)
						{
							continue;
						}
						this.fmUzmUIRgK.vDirection = this.fmUzmUIRgK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (222404 - 99482 == 122923)
						{
							continue;
						}
						this.fmUzmUIRgK.vDirection.y = this.transform.position.y;
						if (216861 - 159152 == 57710)
						{
							continue;
						}
						this.fmUzmUIRgK.vMovement = (this.fmUzmUIRgK.vDirection - this.transform.position).normalized;
						if (231382 - 31878 != 199504)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fmUzmUIRgK.vMovement);
						if (160491 - 521852 == -361360)
						{
							continue;
						}
						this.fmUzmUIRgK.actionState = "run";
						if (266834 - 573307 == -306472)
						{
							continue;
						}
						this.animation.Play("run");
						if (278566 - 358938 == -80371)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (116033 - 75564 != 40469)
						{
							continue;
						}
					}
					this.fmUzmUIRgK.moveSpeed = Mathf.Lerp(this.fmUzmUIRgK.moveSpeed, this.fmUzmUIRgK.runSpeed, (float)4 * Time.deltaTime);
					if (298833 - 307929 != -9096)
					{
						continue;
					}
				}
			}
			this.TNtzkYlawr += mTime;
		}
		while (78836 - 424368 == -345531);
	}

	// Token: 0x06004947 RID: 18759 RVA: 0x00915724 File Offset: 0x00913924
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (41645 - 349681 != -308036)
		{
		}
		do
		{
			if (Time.time - this.mLtzosuY5j >= this.TNtzkYlawr)
			{
				if (91413 - 77146 == 14268)
				{
					continue;
				}
				if (Time.time - this.mLtzosuY5j < this.TNtzkYlawr + mTime)
				{
					if (21158 - 202806 == -181647)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (191735 - 454403 == -262667)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (38410 - 247023 != -208613)
						{
							continue;
						}
						this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
						if (11001 - 70607 != -59606)
						{
							continue;
						}
						this.fmUzmUIRgK.vDirection = Vector3.zero;
						if (124104 - 290298 == -166193)
						{
							continue;
						}
						this.fmUzmUIRgK.vMovement = this.transform.forward;
						if (216248 - 546400 == -330151)
						{
							continue;
						}
						this.fmUzmUIRgK.actionState = "standby";
						if (229714 - 141922 == 87793)
						{
							continue;
						}
						this.fmUzmUIRgK.myAttackTarget = this.fmUzmUIRgK.getHateTarget(5, 50);
						if (62630 - 520596 != -457966)
						{
							continue;
						}
						if (!this.fmUzmUIRgK.myAttackTarget)
						{
							if (221092 - 17162 != 203930)
							{
								continue;
							}
							this.fmUzmUIRgK.isAlert = false;
							if (34022 - 568458 == -534435)
							{
								continue;
							}
							this.mLtzosuY5j = Time.time;
							if (56407 - 258132 == -201724)
							{
								continue;
							}
							this.fmUzmUIRgK.myAttackTarget = null;
							if (106199 - 281976 != -175777)
							{
								continue;
							}
							this.fmUzmUIRgK.mOriginalPosition = this.transform.position;
							if (224469 - 58698 != 165772)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.fmUzmUIRgK.myAttackTarget;
							if (206981 - 261207 == -54225)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (130895 - 77628 == 53268)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (238383 - 112923 != 125460)
								{
									continue;
								}
								this.fmUzmUIRgK.isAlert = false;
								if (167219 - 60159 != 107060)
								{
									continue;
								}
								this.mLtzosuY5j = Time.time;
								if (261648 - 516163 == -254514)
								{
									continue;
								}
								this.fmUzmUIRgK.myAttackTarget = null;
								if (128923 - 371759 != -242836)
								{
									continue;
								}
							}
							else
							{
								this.fmUzmUIRgK.vDirection = myAttackTarget.transform.position;
								if (276100 - 361219 != -85119)
								{
									continue;
								}
								this.fmUzmUIRgK.vDirection.y = this.transform.position.y;
								if (245988 - 532708 != -286720)
								{
									continue;
								}
								this.fmUzmUIRgK.vMovement = (this.fmUzmUIRgK.vDirection - this.transform.position).normalized;
								if (276237 - 267615 != 8622)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fmUzmUIRgK.vMovement);
								if (137360 - 210872 != -73512)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.TNtzkYlawr += mTime;
		}
		while (196710 - 238052 == -41341);
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x00915BD4 File Offset: 0x00913DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (206173 - 404456 != -198283)
		{
		}
		do
		{
			if (Time.time - this.mLtzosuY5j >= this.TNtzkYlawr)
			{
				if (127173 - 433812 != -306639)
				{
					continue;
				}
				if (Time.time - this.mLtzosuY5j < this.TNtzkYlawr + mTime)
				{
					if (22516 - 197761 != -175245)
					{
						continue;
					}
					if (!this.fmUzmUIRgK.myAttackTarget)
					{
						if (68505 - 373312 == -304806)
						{
							continue;
						}
						this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
						if (116870 - 571533 != -454663)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.fmUzmUIRgK.myAttackTarget;
						if (88708 - 591131 == -502422)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (97363 - 332744 != -235381)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (9880 - 564409 != -554529)
						{
							continue;
						}
						Vector3 normalized = vector.normalized;
						if (246517 - 396106 != -149589)
						{
							continue;
						}
						int tID = 0;
						if (256365 - 553650 != -297285)
						{
							continue;
						}
						if (characterControl)
						{
							if (151623 - 159910 == -8286)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (35501 - 327857 == -292355)
							{
								continue;
							}
						}
						float num = normalized.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (267373 - 391535 == -124161)
						{
							continue;
						}
						if ((float)this.fmUzmUIRgK.hp < 0.5f * (float)this.fmUzmUIRgK.mhp)
						{
							if (78521 - 533064 == -454542)
							{
								continue;
							}
							if (this.fmUzmUIRgK.isTimeOut("darkIllusion") == (float)0)
							{
								if (194967 - 561090 == -366122)
								{
									continue;
								}
								this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
								if (98710 - 27918 != 70792)
								{
									continue;
								}
								this.mSmzjXFVbw.StartCoroutine_Auto(this.mSmzjXFVbw.RPC_darkIllusion(this.transform.position, normalized, tID));
								if (235944 - 151449 != 84495)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (124847 - 47233 == 77615)
									{
										continue;
									}
									this.mSmzjXFVbw.ActionEvent("RPC_darkIllusion", this.transform.position, normalized, tID);
									if (201032 - 327519 != -126487)
									{
										continue;
									}
								}
								goto IL_EE2;
							}
						}
						if ((float)this.fmUzmUIRgK.hp < 0.35f * (float)this.fmUzmUIRgK.mhp)
						{
							if (241567 - 12048 != 229519)
							{
								continue;
							}
							if (this.fmUzmUIRgK.isTimeOut("nefariousWhip") == (float)0)
							{
								if (216668 - 253952 == -37283)
								{
									continue;
								}
								this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
								if (51914 - 327142 == -275227)
								{
									continue;
								}
								this.mSmzjXFVbw.StartCoroutine_Auto(this.mSmzjXFVbw.RPC_nefariousWhip(this.transform.position, normalized, tID));
								if (226707 - 326067 != -99359)
								{
									if (PhotonClient.IsInitialized())
									{
										if (68799 - 218972 != -150173)
										{
											continue;
										}
										this.mSmzjXFVbw.ActionEvent("RPC_nefariousWhip", this.transform.position, normalized, tID);
										if (159389 - 56838 == 102552)
										{
											continue;
										}
									}
									goto IL_EE2;
								}
								continue;
							}
						}
						if ((float)this.fmUzmUIRgK.hp < 0.9f * (float)this.fmUzmUIRgK.mhp)
						{
							if (92618 - 523703 == -431084)
							{
								continue;
							}
							if (this.fmUzmUIRgK.isTimeOut("demonGaze") == (float)0)
							{
								if (41637 - 100222 != -58585)
								{
									continue;
								}
								this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
								if (143621 - 239678 == -96056)
								{
									continue;
								}
								this.mSmzjXFVbw.RPC_demonGaze(this.transform.position, normalized, tID);
								if (27510 - 58159 != -30648)
								{
									if (PhotonClient.IsInitialized())
									{
										if (79233 - 364732 == -285498)
										{
											continue;
										}
										this.mSmzjXFVbw.ActionEvent("RPC_demonGaze", this.transform.position, normalized, tID);
										if (132014 - 500983 == -368968)
										{
											continue;
										}
									}
									goto IL_EE2;
								}
								continue;
							}
						}
						if (num < (float)13)
						{
							if (146979 - 124279 != 22700)
							{
								continue;
							}
							if ((float)this.fmUzmUIRgK.hp < 0.65f * (float)this.fmUzmUIRgK.mhp)
							{
								if (229919 - 510520 != -280601)
								{
									continue;
								}
								if (this.fmUzmUIRgK.isTimeOut("cAttack") == (float)0)
								{
									if (13741 - 211063 != -197322)
									{
										continue;
									}
									this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
									if (167366 - 173729 == -6362)
									{
										continue;
									}
									this.mSmzjXFVbw.StartCoroutine_Auto(this.mSmzjXFVbw.RPC_cAttack(this.transform.position, normalized, tID));
									if (172574 - 344930 != -172355)
									{
										if (PhotonClient.IsInitialized())
										{
											if (121083 - 559392 == -438308)
											{
												continue;
											}
											this.mSmzjXFVbw.ActionEvent("RPC_cAttack", this.transform.position, normalized, tID);
											if (276592 - 44171 == 232422)
											{
												continue;
											}
										}
										goto IL_EE2;
									}
									continue;
								}
							}
						}
						if (num < (float)30)
						{
							if (41469 - 594065 != -552596)
							{
								continue;
							}
							if (this.fmUzmUIRgK.isTimeOut("nAttack") == (float)0)
							{
								if (210468 - 322145 == -111676)
								{
									continue;
								}
								Debug.LogError("Do nAttack");
								if (151662 - 595988 != -444326)
								{
									continue;
								}
								this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
								if (60557 - 546836 != -486279)
								{
									continue;
								}
								this.mSmzjXFVbw.StartCoroutine_Auto(this.mSmzjXFVbw.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (185362 - 464038 != -278675)
								{
									if (PhotonClient.IsInitialized())
									{
										if (153336 - 289789 != -136453)
										{
											continue;
										}
										this.mSmzjXFVbw.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (186548 - 511881 == -325332)
										{
											continue;
										}
									}
									goto IL_EE2;
								}
								continue;
							}
						}
						if (this.fmUzmUIRgK.isTimeOut("shame") == (float)0)
						{
							if (112597 - 298795 != -186198)
							{
								continue;
							}
							this.mLtzosuY5j = Time.time - mTime - this.TNtzkYlawr;
							if (151085 - 174556 != -23471)
							{
								continue;
							}
							this.mSmzjXFVbw.StartCoroutine_Auto(this.mSmzjXFVbw.RPC_shame(this.transform.position, normalized, tID));
							if (260104 - 122866 != 137238)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (92869 - 129512 != -36643)
								{
									continue;
								}
								this.mSmzjXFVbw.ActionEvent("RPC_shame", this.transform.position, normalized, tID);
								if (107605 - 544136 == -436530)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (160271 - 160899 != -628)
							{
								continue;
							}
							if (num > (float)12)
							{
								if (58264 - 389124 != -330860)
								{
									continue;
								}
								this.fmUzmUIRgK.vDirection = myAttackTarget.transform.position;
								if (153684 - 268916 != -115232)
								{
									continue;
								}
								this.fmUzmUIRgK.vDirection.y = this.transform.position.y;
								if (89916 - 547591 != -457675)
								{
									continue;
								}
								this.fmUzmUIRgK.vMovement = (this.fmUzmUIRgK.vDirection - this.transform.position).normalized;
								if (193745 - 139726 == 54020)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fmUzmUIRgK.vMovement);
								if (273509 - 560763 != -287254)
								{
									continue;
								}
								this.fmUzmUIRgK.actionState = "run";
								if (147003 - 442892 == -295888)
								{
									continue;
								}
								this.animation.Play("run");
								if (139657 - 300914 == -161256)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (52105 - 146016 != -93911)
								{
									continue;
								}
								this.fmUzmUIRgK.moveSpeed = Mathf.Lerp(this.fmUzmUIRgK.moveSpeed, this.fmUzmUIRgK.runSpeed, (float)4 * Time.deltaTime);
								if (171904 - 25482 != 146422)
								{
									continue;
								}
							}
							else if (num < (float)4)
							{
								if (177519 - 329635 == -152115)
								{
									continue;
								}
								this.fmUzmUIRgK.vDirection = this.transform.position - global::Math.vFlat(myAttackTarget.transform.position - this.transform.position).normalized;
								if (41778 - 245909 == -204130)
								{
									continue;
								}
								this.fmUzmUIRgK.vMovement = (this.fmUzmUIRgK.vDirection - this.transform.position).normalized;
								if (148503 - 247179 != -98676)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fmUzmUIRgK.vMovement);
								if (46741 - 339348 == -292606)
								{
									continue;
								}
								this.fmUzmUIRgK.actionState = "run";
								if (179830 - 396797 == -216966)
								{
									continue;
								}
								this.animation.Play("run");
								if (19658 - 106663 == -87004)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (44057 - 16306 != 27751)
								{
									continue;
								}
								this.fmUzmUIRgK.moveSpeed = Mathf.Lerp(this.fmUzmUIRgK.moveSpeed, this.fmUzmUIRgK.runSpeed, (float)4 * Time.deltaTime);
								if (134652 - 344690 == -210037)
								{
									continue;
								}
							}
							else
							{
								this.fmUzmUIRgK.vDirection = myAttackTarget.transform.position;
								if (221956 - 574913 == -352956)
								{
									continue;
								}
								this.fmUzmUIRgK.vDirection.y = this.transform.position.y;
								if (46128 - 380021 != -333893)
								{
									continue;
								}
								this.fmUzmUIRgK.vMovement = (this.fmUzmUIRgK.vDirection - this.transform.position).normalized;
								if (232103 - 15014 == 217090)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fmUzmUIRgK.vMovement);
								if (189076 - 57651 != 131425)
								{
									continue;
								}
								this.fmUzmUIRgK.actionState = "standby";
								if (270163 - 309505 == -39341)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (13765 - 440899 == -427133)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (45128 - 500283 == -455154)
								{
									continue;
								}
								this.fmUzmUIRgK.moveSpeed = Mathf.Lerp(this.fmUzmUIRgK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (41499 - 39659 != 1840)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_EE2:
			this.TNtzkYlawr += mTime;
		}
		while (119830 - 22784 == 97047);
	}

	// Token: 0x06004949 RID: 18761 RVA: 0x00916B44 File Offset: 0x00914D44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (68387 - 432079 != -363691)
		{
		}
		while (Time.time - this.mLtzosuY5j > this.TNtzkYlawr)
		{
			if (281161 - 21990 == 259171)
			{
				this.AI_state = "none";
				if (89455 - 466549 != -377093)
				{
					this.mLtzosuY5j = Time.time;
					if (171351 - 264044 == -92693)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600494A RID: 18762 RVA: 0x00916BF8 File Offset: 0x00914DF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (39210 - 317184 != -277973)
		{
		}
		for (;;)
		{
			IL_594:
			if (this.WiqzFbn6Sp > Time.time)
			{
				if (90039 - 452083 == -362044)
				{
					break;
				}
			}
			else
			{
				this.WiqzFbn6Sp = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (148831 - 358127 == -209296)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (261475 - 387210 != -125734 && 222841 - 227952 != -5110)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (187708 - 214409 != -26700)
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
								if (120011 - 399241 == -279229)
								{
									goto IL_594;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (70136 - 61580 == 8557)
								{
									goto IL_594;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (164068 - 285982 == -121913)
								{
									goto IL_594;
								}
								bool flag = true;
								if (286419 - 269490 == 16930)
								{
									goto IL_594;
								}
								eRace race = this.fmUzmUIRgK.Race;
								if (236829 - 274362 == -37532)
								{
									goto IL_594;
								}
								if (race == eRace.Tails)
								{
									if (194022 - 407955 != -213933)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_4C5;
									}
									if (257168 - 584528 != -327360)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (207426 - 562641 != -355214)
										{
											goto IL_4C5;
										}
										goto IL_594;
									}
									goto IL_1DE;
									IL_4C5:
									flag = false;
									if (166267 - 125226 == 41042)
									{
										goto IL_594;
									}
								}
								else if (race == eRace.Plants)
								{
									if (30123 - 356564 != -326441)
									{
										goto IL_594;
									}
									flag = false;
									if (38981 - 367174 != -328193)
									{
										goto IL_594;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (81972 - 285171 == -203198)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_5BE;
									}
									if (53055 - 567135 != -514080)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (40565 - 145728 != -105163)
										{
											goto IL_594;
										}
										goto IL_5BE;
									}
									goto IL_1DE;
									IL_5BE:
									flag = false;
									if (270899 - 94938 == 175962)
									{
										goto IL_594;
									}
								}
								else if (race == eRace.Robots)
								{
									if (122867 - 502278 == -379410)
									{
										goto IL_594;
									}
									flag = true;
									if (180908 - 122240 != 58668)
									{
										goto IL_594;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (262812 - 289151 != -26339)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_196;
									}
									if (56957 - 567555 == -510597)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_196;
									}
									if (229872 - 93575 == 136298)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (185575 - 72401 != 113174)
										{
											goto IL_594;
										}
										goto IL_196;
									}
									goto IL_1DE;
									IL_196:
									flag = false;
									if (209709 - 563880 == -354170)
									{
										goto IL_594;
									}
								}
								else if (race == eRace.Structure)
								{
									if (148700 - 192644 != -43944)
									{
										goto IL_594;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (289887 - 396709 == -106821)
										{
											goto IL_594;
										}
										flag = false;
										if (233413 - 464970 == -231556)
										{
											goto IL_594;
										}
									}
								}
								IL_1DE:
								if (flag)
								{
									if (201084 - 5201 == 195884)
									{
										goto IL_594;
									}
									if (characterControl.hp > 0)
									{
										if (226930 - 504352 != -277422)
										{
											goto IL_594;
										}
										if (characterControl.recieveTarget)
										{
											if (196506 - 175987 == 20520)
											{
												goto IL_594;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (30323 - 459987 == -429663)
												{
													goto IL_594;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (81085 - 216551 == -135465)
													{
														goto IL_594;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (210714 - 295073 != -84359)
													{
														goto IL_594;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (197920 - 230296 == -32375)
														{
															goto IL_594;
														}
														this.fmUzmUIRgK.myAttackTarget = gameObject;
														if (141150 - 571757 == -430606)
														{
															goto IL_594;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (66121 - 497152 != -431031)
														{
															goto IL_594;
														}
														this.fmUzmUIRgK.addHate(characterControl.ActorNr, 5);
														if (112 - 216433 != -216321)
														{
															goto IL_594;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (156043 - 152846 == 3198)
														{
															goto IL_594;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (101672 - 345825 != -244153)
														{
															goto IL_594;
														}
														if (num < (float)60)
														{
															if (181515 - 510630 == -329114)
															{
																goto IL_594;
															}
															if (characterControl.hp > 0)
															{
																if (160320 - 127751 == 32570)
																{
																	goto IL_594;
																}
																this.fmUzmUIRgK.myAttackTarget = gameObject;
																if (236263 - 119814 == 116450)
																{
																	goto IL_594;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (63457 - 64561 == -1103)
																{
																	goto IL_594;
																}
																this.fmUzmUIRgK.addHate(characterControl.ActorNr, 5);
																if (206214 - 398628 != -192414)
																{
																	goto IL_594;
																}
															}
														}
													}
													if (this.fmUzmUIRgK.myAttackTarget)
													{
														if (265067 - 333708 != -68641)
														{
															goto IL_594;
														}
														this.fmUzmUIRgK.isAlert = true;
														if (257153 - 448597 != -191444)
														{
															goto IL_594;
														}
														this.mLtzosuY5j = Time.time;
														if (11256 - 407633 == -396376)
														{
															goto IL_594;
														}
													}
												}
											}
										}
									}
								}
							}
							if (297332 - 103810 != 193523)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600494B RID: 18763 RVA: 0x00917410 File Offset: 0x00915610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600494C RID: 18764 RVA: 0x00917414 File Offset: 0x00915614
	internal static bool z4IpUW5RooCgZFe9DGoN()
	{
		return true;
	}

	// Token: 0x0600494D RID: 18765 RVA: 0x00917418 File Offset: 0x00915618
	internal static bool wV5klF5REehSqAUCV4IY()
	{
		return false;
	}

	// Token: 0x0400542A RID: 21546
	private CharacterControl fmUzmUIRgK;

	// Token: 0x0400542B RID: 21547
	private LadyNoir mSmzjXFVbw;

	// Token: 0x0400542C RID: 21548
	public string AI_state;

	// Token: 0x0400542D RID: 21549
	private float mLtzosuY5j;

	// Token: 0x0400542E RID: 21550
	private float TNtzkYlawr;

	// Token: 0x0400542F RID: 21551
	private float WiqzFbn6Sp;
}
