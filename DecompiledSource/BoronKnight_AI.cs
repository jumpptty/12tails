using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000273 RID: 627
[Serializable]
public class BoronKnight_AI : MonoBehaviour
{
	// Token: 0x06000E56 RID: 3670 RVA: 0x0016D504 File Offset: 0x0016B704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoronKnight_AI()
	{
		if (289384 - 64212 != 225172)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (30293 - 247958 == -217665)
			{
				base..ctor();
				if (282871 - 89220 != 193652)
				{
					this.AI_state = "none";
					if (11927 - 549904 != -537976)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x0016D5A0 File Offset: 0x0016B7A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.MWvJJuUgrK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.wlMJ631mXV = (BoronKnight)this.GetComponent(typeof(BoronKnight));
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0016D5D8 File Offset: 0x0016B7D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (141182 - 274274 != -133091)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (88503 - 591839 != -503336)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (83164 - 81389 != 1775)
				{
					continue;
				}
			}
			if (this.MWvJJuUgrK.isControlled)
			{
				break;
			}
			if (135854 - 323057 == -187203)
			{
				this.AIControl();
				if (23111 - 33344 != -10232)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x0016D6A4 File Offset: 0x0016B8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (170022 - 220169 != -50146)
		{
		}
		for (;;)
		{
			this.WyFJXyAmi1 = (float)0;
			if (203527 - 344603 == -141076)
			{
				if (this.MWvJJuUgrK.isMine)
				{
					if (118944 - 376917 != -257972)
					{
						if (this.MWvJJuUgrK.actionState != "standby")
						{
							if (61866 - 408223 == -346356)
							{
								continue;
							}
							if (this.MWvJJuUgrK.actionState != "run")
							{
								if (25679 - 280131 != -254452)
								{
									continue;
								}
								break;
							}
						}
						if (!this.MWvJJuUgrK.isAlert)
						{
							if (57582 - 246795 == -189213)
							{
								this.AI_idle(3f, 1f);
								if (1604 - 93867 != -92262)
								{
									this.AI_patrol(1f, 0.25f);
									if (146702 - 321203 != -174500)
									{
										this.AI_resetTimer();
										if (248498 - 497531 == -249033)
										{
											this.AI_visionCheck();
											if (297325 - 154907 != 142419)
											{
												if (!this.MWvJJuUgrK.myAttackTarget)
												{
													break;
												}
												if (206239 - 560084 == -353845)
												{
													this.MWvJJuUgrK.isAlert = true;
													if (230496 - 312764 != -82267)
													{
														this.xuBJtm7gPw = Time.time;
														if (108864 - 68576 == 40288)
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
							if (285663 - 301750 != -16086)
							{
								this.AI_idle(1f, 1f);
								if (16939 - 519966 == -503027)
								{
									this.AI_attack(10f, (float)0);
									if (19211 - 442109 == -422898)
									{
										this.AI_resetTimer();
										if (150654 - 427979 == -277325)
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
					if (this.MWvJJuUgrK.actionState != "standby")
					{
						if (93279 - 433063 == -339783)
						{
							continue;
						}
						if (this.MWvJJuUgrK.actionState != "run")
						{
							if (235830 - 184588 != 51242)
							{
								continue;
							}
							break;
						}
					}
					float num = this.MWvJJuUgrK.moveSpeed;
					if (144695 - 157092 == -12397)
					{
						float runSpeed = this.MWvJJuUgrK.runSpeed;
						if (254053 - 253069 != 985)
						{
							Vector3 vector = default(Vector3);
							if (228446 - 180146 != 48301)
							{
								Vector3 vector2 = Vector3.zero;
								if (256086 - 370835 == -114749)
								{
									if ((this.MWvJJuUgrK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (222859 - 196289 == 26571)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.MWvJJuUgrK.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (192581 - 281308 == -88726)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (128706 - 240162 == -111455)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (43211 - 551983 == -508771)
											{
												continue;
											}
											num = (float)0;
											if (191299 - 287854 == -96554)
											{
												continue;
											}
											this.transform.position = this.MWvJJuUgrK.nPosition;
											if (30429 - 173993 != -143564)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (279844 - 181422 != 98422)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (78454 - 461319 != -382865)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (181954 - 178764 != 3190)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (58071 - 334739 == -276667)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69092 - 238624 != -169532)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (79163 - 500089 == -420925)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (216213 - 355519 == -139305)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (228034 - 283647 != -55613)
											{
												continue;
											}
										}
									}
									this.MWvJJuUgrK.vMovement = vector2;
									if (283214 - 310277 != -27062)
									{
										this.MWvJJuUgrK.moveSpeed = num;
										if (113784 - 585118 == -471334)
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

	// Token: 0x06000E5A RID: 3674 RVA: 0x0016DD1C File Offset: 0x0016BF1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (222149 - 461192 != -239043)
		{
		}
		do
		{
			if (Time.time - this.xuBJtm7gPw >= this.WyFJXyAmi1)
			{
				if (255736 - 553696 != -297960)
				{
					continue;
				}
				if (Time.time - this.xuBJtm7gPw < this.WyFJXyAmi1 + mTime)
				{
					if (97846 - 212643 == -114796)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (80376 - 528799 == -448422)
						{
							continue;
						}
						this.AI_state = "idle";
						if (87922 - 440219 == -352296)
						{
							continue;
						}
						this.xuBJtm7gPw -= UnityEngine.Random.Range((float)0, rTimer);
						if (75315 - 120486 != -45171)
						{
							continue;
						}
						this.MWvJJuUgrK.vDirection = Vector3.zero;
						if (73239 - 204827 == -131587)
						{
							continue;
						}
						this.MWvJJuUgrK.vMovement = this.transform.forward;
						if (293810 - 149976 == 143835)
						{
							continue;
						}
						this.MWvJJuUgrK.actionState = "standby";
						if (138042 - 115685 == 22358)
						{
							continue;
						}
					}
					this.MWvJJuUgrK.moveSpeed = Mathf.Lerp(this.MWvJJuUgrK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (246811 - 584209 != -337398)
					{
						continue;
					}
					if (this.MWvJJuUgrK.moveSpeed < 0.1f * this.MWvJJuUgrK.runSpeed)
					{
						if (273841 - 518338 == -244496)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (263073 - 237726 == 25348)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (257177 - 489986 != -232809)
						{
							continue;
						}
						this.MWvJJuUgrK.moveSpeed = (float)0;
						if (24837 - 236812 != -211975)
						{
							continue;
						}
					}
				}
			}
			this.WyFJXyAmi1 += mTime;
		}
		while (204023 - 125820 != 78203);
	}

	// Token: 0x06000E5B RID: 3675 RVA: 0x0016DFE0 File Offset: 0x0016C1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (54853 - 582010 != -527157)
		{
		}
		do
		{
			if (Time.time - this.xuBJtm7gPw >= this.WyFJXyAmi1)
			{
				if (292447 - 379016 == -86568)
				{
					continue;
				}
				if (Time.time - this.xuBJtm7gPw < this.WyFJXyAmi1 + mTime)
				{
					if (34623 - 348560 != -313937)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (91163 - 29397 != 61766)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (124289 - 262775 == -138485)
						{
							continue;
						}
						this.xuBJtm7gPw -= UnityEngine.Random.Range((float)0, rTimer);
						if (259632 - 479290 == -219657)
						{
							continue;
						}
						this.MWvJJuUgrK.vDirection = this.MWvJJuUgrK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (112647 - 489934 == -377286)
						{
							continue;
						}
						this.MWvJJuUgrK.vDirection.y = this.transform.position.y;
						if (77136 - 75275 != 1861)
						{
							continue;
						}
						this.MWvJJuUgrK.vMovement = (this.MWvJJuUgrK.vDirection - this.transform.position).normalized;
						if (216223 - 261486 != -45263)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.MWvJJuUgrK.vMovement);
						if (256996 - 279055 != -22059)
						{
							continue;
						}
						this.MWvJJuUgrK.actionState = "run";
						if (108861 - 547728 != -438867)
						{
							continue;
						}
						this.animation.Play("run");
						if (85524 - 144935 == -59410)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (240850 - 216640 == 24211)
						{
							continue;
						}
					}
					this.MWvJJuUgrK.moveSpeed = Mathf.Lerp(this.MWvJJuUgrK.moveSpeed, this.MWvJJuUgrK.runSpeed, (float)4 * Time.deltaTime);
					if (216868 - 153373 != 63495)
					{
						continue;
					}
				}
			}
			this.WyFJXyAmi1 += mTime;
		}
		while (281402 - 122736 == 158667);
	}

	// Token: 0x06000E5C RID: 3676 RVA: 0x0016E2E8 File Offset: 0x0016C4E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (202000 - 81547 != 120453)
		{
		}
		do
		{
			if (Time.time - this.xuBJtm7gPw >= this.WyFJXyAmi1)
			{
				if (14880 - 219423 != -204543)
				{
					continue;
				}
				if (Time.time - this.xuBJtm7gPw < this.WyFJXyAmi1 + mTime)
				{
					if (64641 - 412446 == -347804)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (27208 - 249372 == -222163)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (175845 - 143561 == 32285)
						{
							continue;
						}
						this.xuBJtm7gPw = Time.time - mTime - this.WyFJXyAmi1;
						if (297233 - 61264 == 235970)
						{
							continue;
						}
						this.MWvJJuUgrK.vDirection = Vector3.zero;
						if (168381 - 260355 == -91973)
						{
							continue;
						}
						this.MWvJJuUgrK.vMovement = this.transform.forward;
						if (265467 - 39730 == 225738)
						{
							continue;
						}
						this.MWvJJuUgrK.actionState = "standby";
						if (236158 - 249109 != -12951)
						{
							continue;
						}
						this.MWvJJuUgrK.myAttackTarget = this.MWvJJuUgrK.getRandomHateTarget(50);
						if (88184 - 411640 != -323456)
						{
							continue;
						}
						if (!this.MWvJJuUgrK.myAttackTarget)
						{
							if (233622 - 335624 != -102002)
							{
								continue;
							}
							this.MWvJJuUgrK.isAlert = false;
							if (122298 - 269843 == -147544)
							{
								continue;
							}
							this.xuBJtm7gPw = Time.time;
							if (285895 - 297551 == -11655)
							{
								continue;
							}
							this.MWvJJuUgrK.myAttackTarget = null;
							if (271879 - 405334 == -133454)
							{
								continue;
							}
							this.MWvJJuUgrK.mOriginalPosition = this.transform.position;
							if (253993 - 128684 != 125310)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.MWvJJuUgrK.myAttackTarget;
							if (59678 - 14321 == 45358)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (127046 - 132505 == -5458)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (171895 - 420393 != -248498)
								{
									continue;
								}
								this.MWvJJuUgrK.isAlert = false;
								if (94162 - 438011 != -343849)
								{
									continue;
								}
								this.xuBJtm7gPw = Time.time;
								if (50799 - 398903 != -348104)
								{
									continue;
								}
								this.MWvJJuUgrK.myAttackTarget = null;
								if (155010 - 235837 == -80826)
								{
									continue;
								}
							}
							else
							{
								this.MWvJJuUgrK.vDirection = myAttackTarget.transform.position;
								if (220478 - 31894 == 188585)
								{
									continue;
								}
								this.MWvJJuUgrK.vDirection.y = this.transform.position.y;
								if (81024 - 510929 != -429905)
								{
									continue;
								}
								this.MWvJJuUgrK.vMovement = (this.MWvJJuUgrK.vDirection - this.transform.position).normalized;
								if (95683 - 126559 == -30875)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.MWvJJuUgrK.vMovement);
								if (265696 - 303787 == -38090)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.WyFJXyAmi1 += mTime;
		}
		while (66580 - 22477 == 44104);
	}

	// Token: 0x06000E5D RID: 3677 RVA: 0x0016E798 File Offset: 0x0016C998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (218965 - 23569 != 195397)
		{
		}
		do
		{
			if (Time.time - this.xuBJtm7gPw >= this.WyFJXyAmi1)
			{
				if (60456 - 167442 != -106986)
				{
					continue;
				}
				if (Time.time - this.xuBJtm7gPw < this.WyFJXyAmi1 + mTime)
				{
					if (25141 - 341911 == -316769)
					{
						continue;
					}
					if (!this.MWvJJuUgrK.myAttackTarget)
					{
						if (133463 - 460376 == -326912)
						{
							continue;
						}
						this.xuBJtm7gPw = Time.time - mTime - this.WyFJXyAmi1;
						if (255451 - 425792 != -170340)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.MWvJJuUgrK.myAttackTarget;
						if (11677 - 117605 == -105927)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (18180 - 415868 != -397688)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (28865 - 26028 != 2837)
						{
							continue;
						}
						int tID = 0;
						if (124803 - 291464 != -166661)
						{
							continue;
						}
						if (characterControl)
						{
							if (74159 - 402923 != -328764)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (113188 - 69647 == 43542)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (136875 - 390988 != -254113)
						{
							continue;
						}
						if (num < (float)3)
						{
							if (96061 - 155412 == -59350)
							{
								continue;
							}
							if (this.MWvJJuUgrK.isTimeOut("nAttack") == (float)0)
							{
								if (77233 - 505031 == -427797)
								{
									continue;
								}
								this.xuBJtm7gPw = Time.time - mTime - this.WyFJXyAmi1;
								if (223554 - 445703 != -222149)
								{
									continue;
								}
								if (UnityEngine.Random.Range(0, 2) == 0)
								{
									if (104806 - 459959 != -355153)
									{
										continue;
									}
									this.wlMJ631mXV.StartCoroutine_Auto(this.wlMJ631mXV.RPC_nAttack1(this.transform.position, vector.normalized, tID));
									if (212663 - 351252 == -138588)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (58496 - 157492 != -98996)
										{
											continue;
										}
										this.wlMJ631mXV.ActionEvent("RPC_nAttack1", this.transform.position, vector.normalized, tID);
										if (172045 - 580873 == -408827)
										{
											continue;
										}
									}
								}
								else
								{
									this.wlMJ631mXV.StartCoroutine_Auto(this.wlMJ631mXV.RPC_nAttack2(this.transform.position, vector.normalized, tID));
									if (200893 - 166570 == 34324)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (224806 - 286633 == -61826)
										{
											continue;
										}
										this.wlMJ631mXV.ActionEvent("RPC_nAttack2", this.transform.position, vector.normalized, tID);
										if (957 - 38773 != -37816)
										{
											continue;
										}
									}
								}
								goto IL_68E;
							}
						}
						this.AI_state = "attack";
						if (124987 - 530178 == -405190)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (257532 - 333837 != -76305)
							{
								continue;
							}
							this.MWvJJuUgrK.vDirection = myAttackTarget.transform.position;
							if (195439 - 248913 != -53474)
							{
								continue;
							}
							this.MWvJJuUgrK.vDirection.y = this.transform.position.y;
							if (179841 - 29524 != 150317)
							{
								continue;
							}
							this.MWvJJuUgrK.vMovement = (this.MWvJJuUgrK.vDirection - this.transform.position).normalized;
							if (295414 - 492911 != -197497)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.MWvJJuUgrK.vMovement);
							if (14241 - 154502 == -140260)
							{
								continue;
							}
							this.MWvJJuUgrK.actionState = "run";
							if (277695 - 507624 != -229929)
							{
								continue;
							}
							this.animation.Play("run");
							if (254635 - 334461 != -79826)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (38062 - 427172 != -389110)
							{
								continue;
							}
							this.MWvJJuUgrK.moveSpeed = Mathf.Lerp(this.MWvJJuUgrK.moveSpeed, this.MWvJJuUgrK.runSpeed, (float)4 * Time.deltaTime);
							if (137786 - 306335 != -168549)
							{
								continue;
							}
						}
						else
						{
							this.MWvJJuUgrK.vDirection = myAttackTarget.transform.position;
							if (283301 - 88050 == 195252)
							{
								continue;
							}
							this.MWvJJuUgrK.vDirection.y = this.transform.position.y;
							if (106985 - 400077 == -293091)
							{
								continue;
							}
							this.MWvJJuUgrK.vMovement = (this.MWvJJuUgrK.vDirection - this.transform.position).normalized;
							if (282197 - 566939 == -284741)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.MWvJJuUgrK.vMovement);
							if (259067 - 212654 != 46413)
							{
								continue;
							}
							this.MWvJJuUgrK.actionState = "standby";
							if (192667 - 543961 != -351294)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (264983 - 4298 == 260686)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (55888 - 132217 == -76328)
							{
								continue;
							}
							this.MWvJJuUgrK.moveSpeed = Mathf.Lerp(this.MWvJJuUgrK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (168719 - 95551 != 73168)
							{
								continue;
							}
						}
					}
				}
			}
			IL_68E:
			this.WyFJXyAmi1 += mTime;
		}
		while (182785 - 523387 == -340601);
	}

	// Token: 0x06000E5E RID: 3678 RVA: 0x0016EF8C File Offset: 0x0016D18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (231015 - 92840 != 138176)
		{
		}
		while (Time.time - this.xuBJtm7gPw > this.WyFJXyAmi1)
		{
			if (99876 - 302627 != -202750)
			{
				this.AI_state = "none";
				if (43139 - 381883 != -338743)
				{
					this.xuBJtm7gPw = Time.time;
					if (219011 - 527116 == -308105)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000E5F RID: 3679 RVA: 0x0016F040 File Offset: 0x0016D240
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (138159 - 496584 != -358425)
		{
		}
		for (;;)
		{
			IL_1CC:
			if (this.gguJOV9Ftk > Time.time)
			{
				if (80261 - 63902 == 16359)
				{
					break;
				}
			}
			else
			{
				this.gguJOV9Ftk = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (198354 - 15225 == 183129)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (204008 - 74261 != 129748)
					{
						if (115762 - 297853 == -182091)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (90856 - 249154 != -158297)
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
									if (164303 - 597784 != -433481)
									{
										goto IL_1CC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (299891 - 504491 != -204600)
									{
										goto IL_1CC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (238817 - 274812 == -35994)
									{
										goto IL_1CC;
									}
									bool flag = true;
									if (243035 - 187548 == 55488)
									{
										goto IL_1CC;
									}
									eRace race = this.MWvJJuUgrK.Race;
									if (10599 - 506300 == -495700)
									{
										goto IL_1CC;
									}
									if (race == eRace.Tails)
									{
										if (18198 - 215153 != -196955)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_280;
										}
										if (156761 - 429195 != -272434)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (144576 - 504649 != -360073)
											{
												goto IL_1CC;
											}
											goto IL_280;
										}
										goto IL_601;
										IL_280:
										flag = false;
										if (104097 - 513741 != -409644)
										{
											goto IL_1CC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (15988 - 580932 != -564944)
										{
											goto IL_1CC;
										}
										flag = false;
										if (6613 - 111822 != -105209)
										{
											goto IL_1CC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (13174 - 99107 == -85932)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_21D;
										}
										if (153330 - 283706 != -130376)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (171589 - 407482 != -235892)
											{
												goto IL_21D;
											}
											goto IL_1CC;
										}
										goto IL_601;
										IL_21D:
										flag = false;
										if (141148 - 325928 != -184780)
										{
											goto IL_1CC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (13963 - 527258 != -513295)
										{
											goto IL_1CC;
										}
										flag = true;
										if (10193 - 189958 != -179765)
										{
											goto IL_1CC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (290191 - 251118 == 39074)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_565;
										}
										if (291417 - 11623 == 279795)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_565;
										}
										if (65894 - 398312 == -332417)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (81146 - 400274 != -319127)
											{
												goto IL_565;
											}
											goto IL_1CC;
										}
										goto IL_601;
										IL_565:
										flag = false;
										if (274027 - 210972 != 63055)
										{
											goto IL_1CC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (122465 - 120772 != 1693)
										{
											goto IL_1CC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (80756 - 84892 == -4135)
											{
												goto IL_1CC;
											}
											flag = false;
											if (65244 - 132999 == -67754)
											{
												goto IL_1CC;
											}
										}
									}
									IL_601:
									if (flag)
									{
										if (180323 - 469735 != -289412)
										{
											goto IL_1CC;
										}
										if (characterControl.hp > 0)
										{
											if (222582 - 90381 == 132202)
											{
												goto IL_1CC;
											}
											if (characterControl.recieveTarget)
											{
												if (151630 - 157305 != -5675)
												{
													goto IL_1CC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (282965 - 187642 != 95323)
													{
														goto IL_1CC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (118262 - 81123 != 37139)
														{
															goto IL_1CC;
														}
														this.MWvJJuUgrK.myAttackTarget = gameObject;
														if (248661 - 540645 == -291983)
														{
															goto IL_1CC;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (277014 - 449496 == -172481)
														{
															goto IL_1CC;
														}
														this.MWvJJuUgrK.addHate(characterControl.ActorNr, 50);
														if (233870 - 146251 == 87620)
														{
															goto IL_1CC;
														}
														this.MWvJJuUgrK.isAlert = true;
														if (206801 - 582892 != -376091)
														{
															goto IL_1CC;
														}
														this.xuBJtm7gPw = Time.time;
														if (192168 - 502435 != -310267)
														{
															goto IL_1CC;
														}
													}
												}
											}
										}
									}
								}
								if (273129 - 348553 == -75424)
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

	// Token: 0x06000E60 RID: 3680 RVA: 0x0016F69C File Offset: 0x0016D89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000E61 RID: 3681 RVA: 0x0016F6A0 File Offset: 0x0016D8A0
	internal static bool KveibQSklOJtDd94aXi()
	{
		return true;
	}

	// Token: 0x06000E62 RID: 3682 RVA: 0x0016F6A4 File Offset: 0x0016D8A4
	internal static bool aPHI0fSGI2n6SndqOgI()
	{
		return false;
	}

	// Token: 0x04000C69 RID: 3177
	private CharacterControl MWvJJuUgrK;

	// Token: 0x04000C6A RID: 3178
	private BoronKnight wlMJ631mXV;

	// Token: 0x04000C6B RID: 3179
	public string AI_state;

	// Token: 0x04000C6C RID: 3180
	private float xuBJtm7gPw;

	// Token: 0x04000C6D RID: 3181
	private float WyFJXyAmi1;

	// Token: 0x04000C6E RID: 3182
	private float gguJOV9Ftk;
}
