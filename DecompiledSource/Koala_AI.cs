using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CAD RID: 3245
[Serializable]
public class Koala_AI : MonoBehaviour
{
	// Token: 0x060048C8 RID: 18632 RVA: 0x00909078 File Offset: 0x00907278
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Koala_AI()
	{
		if (73441 - 352874 != -279432)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (242755 - 399799 == -157044)
			{
				base..ctor();
				if (30108 - 532193 != -502084)
				{
					this.AI_state = "none";
					if (197243 - 135559 == 61684)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060048C9 RID: 18633 RVA: 0x00909114 File Offset: 0x00907314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aDSzUlIwas = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.x14zN9yrgZ = (Koala)this.GetComponent(typeof(Koala));
	}

	// Token: 0x060048CA RID: 18634 RVA: 0x0090914C File Offset: 0x0090734C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (297245 - 321765 != -24520)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (122329 - 386330 == -264000)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (225549 - 420459 == -194909)
				{
					continue;
				}
			}
			if (this.aDSzUlIwas.isControlled)
			{
				break;
			}
			if (24123 - 48916 == -24793)
			{
				this.AIControl();
				if (186315 - 86586 == 99729)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060048CB RID: 18635 RVA: 0x00909218 File Offset: 0x00907418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (247351 - 589560 != -342208)
		{
		}
		for (;;)
		{
			this.jZozPJnlvL = (float)0;
			if (144889 - 147365 != -2475)
			{
				if (this.aDSzUlIwas.isMine)
				{
					if (137527 - 42298 == 95229)
					{
						if (this.aDSzUlIwas.actionState != "standby")
						{
							if (78553 - 554174 == -475620)
							{
								continue;
							}
							if (this.aDSzUlIwas.actionState != "run")
							{
								if (125357 - 244464 != -119107)
								{
									continue;
								}
								break;
							}
						}
						if (!this.aDSzUlIwas.isAlert)
						{
							if (221749 - 40330 != 181420)
							{
								if (this.aDSzUlIwas.isSummon)
								{
									if (195025 - 500038 == -305012)
									{
										continue;
									}
									if (this.aDSzUlIwas.mSummoner != null)
									{
										if (31935 - 532442 == -500506)
										{
											continue;
										}
										Vector3 vector = this.aDSzUlIwas.mSummoner.transform.position - this.transform.position;
										if (241450 - 488356 != -246906)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (235167 - 173871 == 61297)
											{
												continue;
											}
											this.AI_follow(this.aDSzUlIwas.mSummoner);
											if (161068 - 96429 == 64640)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (195501 - 376328 == -180826)
											{
												continue;
											}
											this.AI_resetTimer();
											if (291332 - 598260 != -306928)
											{
												continue;
											}
											this.AI_visionCheck();
											if (155431 - 394615 != -239184)
											{
												continue;
											}
										}
										goto IL_2F7;
									}
								}
								this.AI_idle(3f, 1f);
								if (148230 - 544924 == -396693)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (49714 - 432649 != -382935)
								{
									continue;
								}
								this.AI_resetTimer();
								if (151528 - 469888 == -318359)
								{
									continue;
								}
								this.AI_visionCheck();
								if (215691 - 203550 != 12141)
								{
									continue;
								}
								IL_2F7:
								if (!this.aDSzUlIwas.myAttackTarget)
								{
									break;
								}
								if (167543 - 162637 != 4907)
								{
									this.aDSzUlIwas.isAlert = true;
									if (267889 - 393971 == -126082)
									{
										this.DwPzEDHwJJ = Time.time;
										if (287057 - 513963 == -226906)
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
							if (118047 - 124044 == -5997)
							{
								this.AI_idle(3f, 1f);
								if (61404 - 334863 == -273459)
								{
									this.AI_patrol(2f, 1f);
									if (73121 - 136491 == -63370)
									{
										this.AI_attack(3f, 1f);
										if (254614 - 475397 == -220783)
										{
											this.AI_resetTimer();
											if (69692 - 470194 != -400501)
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
					if (this.aDSzUlIwas.actionState != "standby")
					{
						if (95627 - 410280 != -314653)
						{
							continue;
						}
						if (this.aDSzUlIwas.actionState != "run")
						{
							if (299722 - 299744 != -22)
							{
								continue;
							}
							break;
						}
					}
					float num = this.aDSzUlIwas.moveSpeed;
					if (260604 - 140583 == 120021)
					{
						float runSpeed = this.aDSzUlIwas.runSpeed;
						if (24684 - 463623 != -438938)
						{
							Vector3 vector2 = default(Vector3);
							if (87851 - 519988 != -432136)
							{
								Vector3 vector3 = Vector3.zero;
								if (161588 - 297251 == -135663)
								{
									if ((this.aDSzUlIwas.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (158748 - 42712 == 116037)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aDSzUlIwas.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (258826 - 532017 != -273191)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (58284 - 17754 == 40531)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (177540 - 161129 == 16412)
											{
												continue;
											}
											num = (float)0;
											if (210118 - 93413 != 116705)
											{
												continue;
											}
											this.transform.position = this.aDSzUlIwas.nPosition;
											if (277599 - 130239 != 147360)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (255220 - 77759 != 177461)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (177180 - 2427 != 174753)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (134034 - 245560 == -111525)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (58876 - 154044 == -95167)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69843 - 536326 == -466482)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (68443 - 477442 == -408998)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (75683 - 163721 != -88038)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (82817 - 405093 == -322275)
											{
												continue;
											}
										}
									}
									this.aDSzUlIwas.vMovement = vector3;
									if (201745 - 426675 != -224929)
									{
										this.aDSzUlIwas.moveSpeed = num;
										if (273011 - 287548 == -14537)
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

	// Token: 0x060048CC RID: 18636 RVA: 0x00909A20 File Offset: 0x00907C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (220489 - 285866 != -65377)
		{
		}
		do
		{
			if (Time.time - this.DwPzEDHwJJ >= this.jZozPJnlvL)
			{
				if (133098 - 583096 != -449998)
				{
					continue;
				}
				if (Time.time - this.DwPzEDHwJJ < this.jZozPJnlvL + mTime)
				{
					if (70056 - 499198 == -429141)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (234651 - 419207 == -184555)
						{
							continue;
						}
						this.AI_state = "idle";
						if (47942 - 6012 != 41930)
						{
							continue;
						}
						this.DwPzEDHwJJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (154789 - 537852 == -383062)
						{
							continue;
						}
						this.aDSzUlIwas.vDirection = Vector3.zero;
						if (174147 - 375892 == -201744)
						{
							continue;
						}
						this.aDSzUlIwas.vMovement = this.transform.forward;
						if (65829 - 273314 != -207485)
						{
							continue;
						}
						this.aDSzUlIwas.actionState = "standby";
						if (215766 - 539843 != -324077)
						{
							continue;
						}
					}
					this.aDSzUlIwas.moveSpeed = Mathf.Lerp(this.aDSzUlIwas.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (189389 - 529228 == -339838)
					{
						continue;
					}
					if (this.aDSzUlIwas.moveSpeed < 0.1f * this.aDSzUlIwas.runSpeed)
					{
						if (88907 - 31330 != 57577)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (277207 - 203140 != 74067)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (44626 - 407589 != -362963)
						{
							continue;
						}
						this.aDSzUlIwas.moveSpeed = (float)0;
						if (32877 - 367590 != -334713)
						{
							continue;
						}
					}
				}
			}
			this.jZozPJnlvL += mTime;
		}
		while (78473 - 108116 == -29642);
	}

	// Token: 0x060048CD RID: 18637 RVA: 0x00909CE4 File Offset: 0x00907EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (102224 - 523992 != -421768)
		{
		}
		for (;;)
		{
			this.aDSzUlIwas.vDirection = followObject.transform.position;
			if (26385 - 359293 != -332907)
			{
				this.aDSzUlIwas.vDirection.y = this.transform.position.y;
				if (42865 - 45405 == -2540)
				{
					this.aDSzUlIwas.vMovement = (this.aDSzUlIwas.vDirection - this.transform.position).normalized;
					if (289234 - 269142 == 20092)
					{
						this.transform.rotation = Quaternion.LookRotation(this.aDSzUlIwas.vMovement);
						if (50212 - 215676 == -165464)
						{
							this.aDSzUlIwas.actionState = "run";
							if (40353 - 452957 == -412604)
							{
								this.animation.Play("run");
								if (167255 - 506100 == -338845)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (283809 - 428928 != -145118)
									{
										this.aDSzUlIwas.moveSpeed = Mathf.Lerp(this.aDSzUlIwas.moveSpeed, this.aDSzUlIwas.runSpeed, (float)4 * Time.deltaTime);
										if (299258 - 276013 != 23246)
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

	// Token: 0x060048CE RID: 18638 RVA: 0x00909ECC File Offset: 0x009080CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (156412 - 327133 != -170720)
		{
		}
		do
		{
			if (Time.time - this.DwPzEDHwJJ >= this.jZozPJnlvL)
			{
				if (191320 - 527938 == -336617)
				{
					continue;
				}
				if (Time.time - this.DwPzEDHwJJ < this.jZozPJnlvL + mTime)
				{
					if (241092 - 288298 != -47206)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (100494 - 157833 != -57339)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (60760 - 256707 == -195946)
						{
							continue;
						}
						this.DwPzEDHwJJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (26267 - 561173 != -534906)
						{
							continue;
						}
						this.aDSzUlIwas.vDirection = this.aDSzUlIwas.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (74008 - 288597 != -214589)
						{
							continue;
						}
						this.aDSzUlIwas.vDirection.y = this.transform.position.y;
						if (95457 - 199568 != -104111)
						{
							continue;
						}
						this.aDSzUlIwas.vMovement = (this.aDSzUlIwas.vDirection - this.transform.position).normalized;
						if (201608 - 211867 == -10258)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aDSzUlIwas.vMovement);
						if (23334 - 561244 == -537909)
						{
							continue;
						}
						this.aDSzUlIwas.actionState = "run";
						if (103914 - 1985 != 101929)
						{
							continue;
						}
						this.animation.Play("run");
						if (274103 - 494741 == -220637)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (289086 - 101464 == 187623)
						{
							continue;
						}
					}
					this.aDSzUlIwas.moveSpeed = Mathf.Lerp(this.aDSzUlIwas.moveSpeed, this.aDSzUlIwas.runSpeed, (float)4 * Time.deltaTime);
					if (267711 - 257594 == 10118)
					{
						continue;
					}
				}
			}
			this.jZozPJnlvL += mTime;
		}
		while (296546 - 326837 == -30290);
	}

	// Token: 0x060048CF RID: 18639 RVA: 0x0090A1D4 File Offset: 0x009083D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (143822 - 14987 != 128835)
		{
		}
		do
		{
			if (Time.time - this.DwPzEDHwJJ >= this.jZozPJnlvL)
			{
				if (25640 - 436671 != -411031)
				{
					continue;
				}
				if (Time.time - this.DwPzEDHwJJ < this.jZozPJnlvL + mTime)
				{
					if (177393 - 325985 != -148592)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (115696 - 578995 != -463299)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (156517 - 126572 != 29945)
						{
							continue;
						}
						this.DwPzEDHwJJ = Time.time - mTime - this.jZozPJnlvL;
						if (65242 - 486388 != -421146)
						{
							continue;
						}
						this.aDSzUlIwas.vDirection = Vector3.zero;
						if (96004 - 11573 != 84431)
						{
							continue;
						}
						this.aDSzUlIwas.vMovement = this.transform.forward;
						if (112261 - 253755 != -141494)
						{
							continue;
						}
						this.aDSzUlIwas.actionState = "standby";
						if (157120 - 315080 != -157960)
						{
							continue;
						}
						this.aDSzUlIwas.myAttackTarget = this.aDSzUlIwas.getHateTarget(5, 50);
						if (165074 - 355631 != -190557)
						{
							continue;
						}
						if (!this.aDSzUlIwas.myAttackTarget)
						{
							if (11327 - 256089 == -244761)
							{
								continue;
							}
							this.aDSzUlIwas.isAlert = false;
							if (203035 - 566496 == -363460)
							{
								continue;
							}
							this.DwPzEDHwJJ = Time.time;
							if (196024 - 11934 != 184090)
							{
								continue;
							}
							this.aDSzUlIwas.myAttackTarget = null;
							if (94020 - 466149 == -372128)
							{
								continue;
							}
							this.aDSzUlIwas.mOriginalPosition = this.transform.position;
							if (7013 - 308629 != -301615)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.aDSzUlIwas.myAttackTarget;
							if (60582 - 503540 == -442957)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (223188 - 73557 == 149632)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (208776 - 410348 == -201571)
								{
									continue;
								}
								this.aDSzUlIwas.isAlert = false;
								if (19209 - 369840 != -350631)
								{
									continue;
								}
								this.DwPzEDHwJJ = Time.time;
								if (78955 - 266907 != -187952)
								{
									continue;
								}
								this.aDSzUlIwas.myAttackTarget = null;
								if (13258 - 171763 != -158505)
								{
									continue;
								}
							}
							else
							{
								this.aDSzUlIwas.vDirection = myAttackTarget.transform.position;
								if (80292 - 478198 == -397905)
								{
									continue;
								}
								this.aDSzUlIwas.vDirection.y = this.transform.position.y;
								if (275329 - 334692 != -59363)
								{
									continue;
								}
								this.aDSzUlIwas.vMovement = (this.aDSzUlIwas.vDirection - this.transform.position).normalized;
								if (123387 - 53290 == 70098)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aDSzUlIwas.vMovement);
								if (231268 - 596853 != -365585)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.jZozPJnlvL += mTime;
		}
		while (234743 - 467146 == -232402);
	}

	// Token: 0x060048D0 RID: 18640 RVA: 0x0090A684 File Offset: 0x00908884
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (265988 - 93957 != 172031)
		{
		}
		do
		{
			if (Time.time - this.DwPzEDHwJJ >= this.jZozPJnlvL)
			{
				if (118382 - 205209 != -86827)
				{
					continue;
				}
				if (Time.time - this.DwPzEDHwJJ < this.jZozPJnlvL + mTime)
				{
					if (66268 - 273751 != -207483)
					{
						continue;
					}
					if (!this.aDSzUlIwas.myAttackTarget)
					{
						if (167438 - 496226 == -328787)
						{
							continue;
						}
						this.DwPzEDHwJJ = Time.time - mTime - this.jZozPJnlvL;
						if (272373 - 252527 != 19846)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.aDSzUlIwas.myAttackTarget;
						if (103993 - 505174 == -401180)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (77384 - 576962 == -499577)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (7261 - 7907 == -645)
						{
							continue;
						}
						if (185744 - 27178 != 158566)
						{
							continue;
						}
						if (characterControl)
						{
							if (105378 - 459264 != -353886)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (245289 - 549898 == -304608)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (174311 - 461896 != -287585)
						{
							continue;
						}
						if (this.aDSzUlIwas.isTimeOut("nAttack") == (float)0)
						{
							if (161642 - 536942 != -375300)
							{
								continue;
							}
							this.DwPzEDHwJJ = Time.time - mTime - this.jZozPJnlvL;
							if (229031 - 113640 != 115391)
							{
								continue;
							}
							this.x14zN9yrgZ.StartCoroutine_Auto(this.x14zN9yrgZ.RPC_bun(this.transform.position, this.transform.forward, 0));
							if (237268 - 328251 == -90982)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (98538 - 222929 == -124390)
								{
									continue;
								}
								this.x14zN9yrgZ.ActionEvent("RPC_bun", this.transform.position, this.transform.forward, 0);
								if (210707 - 203994 != 6713)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (211289 - 248880 != -37591)
							{
								continue;
							}
							this.aDSzUlIwas.vDirection = myAttackTarget.transform.position;
							if (29275 - 473801 == -444525)
							{
								continue;
							}
							this.aDSzUlIwas.vDirection.y = this.transform.position.y;
							if (104422 - 360837 == -256414)
							{
								continue;
							}
							this.aDSzUlIwas.vMovement = (this.aDSzUlIwas.vDirection - this.transform.position).normalized;
							if (295035 - 283347 == 11689)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.aDSzUlIwas.vMovement);
							if (171651 - 274835 == -103183)
							{
								continue;
							}
							this.aDSzUlIwas.actionState = "standby";
							if (54231 - 270133 == -215901)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (94708 - 165728 == -71019)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (119504 - 449013 == -329508)
							{
								continue;
							}
							this.aDSzUlIwas.moveSpeed = Mathf.Lerp(this.aDSzUlIwas.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (95485 - 536121 == -440635)
							{
								continue;
							}
						}
					}
				}
			}
			this.jZozPJnlvL += mTime;
		}
		while (12902 - 305739 != -292837);
	}

	// Token: 0x060048D1 RID: 18641 RVA: 0x0090ABB8 File Offset: 0x00908DB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (213870 - 190845 != 23025)
		{
		}
		while (Time.time - this.DwPzEDHwJJ > this.jZozPJnlvL)
		{
			if (257391 - 248632 == 8759)
			{
				this.AI_state = "none";
				if (234384 - 120246 != 114139)
				{
					this.DwPzEDHwJJ = Time.time;
					if (137208 - 407333 == -270125)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060048D2 RID: 18642 RVA: 0x0090AC6C File Offset: 0x00908E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (253967 - 447857 != -193889)
		{
		}
		for (;;)
		{
			IL_787:
			if (this.Kk7zSKUslx > Time.time)
			{
				if (282146 - 548376 == -266230)
				{
					break;
				}
			}
			else
			{
				this.Kk7zSKUslx = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (51085 - 463605 == -412520)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (269867 - 269790 == 77)
					{
						if (252226 - 290051 == -37825)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (233601 - 478665 == -245064)
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
									if (147463 - 5756 != 141707)
									{
										goto IL_787;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (224405 - 257078 == -32672)
									{
										goto IL_787;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (3164 - 182507 != -179343)
									{
										goto IL_787;
									}
									bool flag = true;
									if (240212 - 198544 == 41669)
									{
										goto IL_787;
									}
									eRace race = this.aDSzUlIwas.Race;
									if (214802 - 376382 != -161580)
									{
										goto IL_787;
									}
									if (race == eRace.Tails)
									{
										if (36163 - 475844 == -439680)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5C;
										}
										if (60554 - 570363 != -509809)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (248136 - 307081 != -58944)
											{
												goto IL_5C;
											}
											goto IL_787;
										}
										goto IL_4FC;
										IL_5C:
										flag = false;
										if (22349 - 120895 != -98546)
										{
											goto IL_787;
										}
									}
									else if (race == eRace.Plants)
									{
										if (233708 - 166887 != 66821)
										{
											goto IL_787;
										}
										flag = false;
										if (31367 - 408807 != -377440)
										{
											goto IL_787;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (280214 - 505970 == -225755)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_78;
										}
										if (195000 - 389930 == -194929)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (120387 - 571440 != -451052)
											{
												goto IL_78;
											}
											goto IL_787;
										}
										goto IL_4FC;
										IL_78:
										flag = false;
										if (159318 - 129703 != 29615)
										{
											goto IL_787;
										}
									}
									else if (race == eRace.Robots)
									{
										if (274785 - 565705 == -290919)
										{
											goto IL_787;
										}
										flag = true;
										if (259013 - 550400 == -291386)
										{
											goto IL_787;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (269007 - 25735 != 243272)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_462;
										}
										if (156755 - 28768 == 127988)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_462;
										}
										if (40237 - 440557 != -400320)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (299524 - 255939 != 43585)
											{
												goto IL_787;
											}
											goto IL_462;
										}
										goto IL_4FC;
										IL_462:
										flag = false;
										if (121571 - 210240 == -88668)
										{
											goto IL_787;
										}
									}
									else if (race == eRace.Structure)
									{
										if (135726 - 581568 != -445842)
										{
											goto IL_787;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (222027 - 152690 == 69338)
											{
												goto IL_787;
											}
											flag = false;
											if (118171 - 253786 != -135615)
											{
												goto IL_787;
											}
										}
									}
									IL_4FC:
									if (flag)
									{
										if (218382 - 244781 == -26398)
										{
											goto IL_787;
										}
										if (characterControl.hp > 0)
										{
											if (299737 - 355424 == -55686)
											{
												goto IL_787;
											}
											if (characterControl.recieveTarget)
											{
												if (97806 - 358369 == -260562)
												{
													goto IL_787;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (289353 - 48401 == 240953)
													{
														goto IL_787;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (88283 - 556755 != -468472)
														{
															goto IL_787;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (29130 - 599374 != -570244)
														{
															goto IL_787;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (287674 - 113742 == 173933)
															{
																goto IL_787;
															}
															this.aDSzUlIwas.myAttackTarget = gameObject;
															if (127178 - 154976 == -27797)
															{
																goto IL_787;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (78517 - 63692 == 14826)
															{
																goto IL_787;
															}
															this.aDSzUlIwas.addHate(characterControl.ActorNr, 5);
															if (278908 - 396820 != -117912)
															{
																goto IL_787;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (118033 - 337420 != -219387)
															{
																goto IL_787;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (222178 - 74603 == 147576)
															{
																goto IL_787;
															}
															if (num < (float)60)
															{
																if (11751 - 25687 == -13935)
																{
																	goto IL_787;
																}
																if (characterControl.hp > 0)
																{
																	if (200038 - 357063 != -157025)
																	{
																		goto IL_787;
																	}
																	this.aDSzUlIwas.myAttackTarget = gameObject;
																	if (52537 - 73564 == -21026)
																	{
																		goto IL_787;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (149072 - 576268 == -427195)
																	{
																		goto IL_787;
																	}
																	this.aDSzUlIwas.addHate(characterControl.ActorNr, 5);
																	if (226623 - 47218 != 179405)
																	{
																		goto IL_787;
																	}
																}
															}
														}
														if (this.aDSzUlIwas.myAttackTarget)
														{
															if (96210 - 314161 == -217950)
															{
																goto IL_787;
															}
															this.aDSzUlIwas.isAlert = true;
															if (72165 - 383335 != -311170)
															{
																goto IL_787;
															}
															this.DwPzEDHwJJ = Time.time;
															if (165159 - 52129 == 113031)
															{
																goto IL_787;
															}
														}
													}
												}
											}
										}
									}
								}
								if (274907 - 63257 == 211650)
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

	// Token: 0x060048D3 RID: 18643 RVA: 0x0090B484 File Offset: 0x00909684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060048D4 RID: 18644 RVA: 0x0090B488 File Offset: 0x00909688
	internal static bool wr5DmD5vDotlJGC1xbgk()
	{
		return true;
	}

	// Token: 0x060048D5 RID: 18645 RVA: 0x0090B48C File Offset: 0x0090968C
	internal static bool BtMpWI5vvHT4hFMbDy8P()
	{
		return false;
	}

	// Token: 0x040053AD RID: 21421
	private CharacterControl aDSzUlIwas;

	// Token: 0x040053AE RID: 21422
	private Koala x14zN9yrgZ;

	// Token: 0x040053AF RID: 21423
	public string AI_state;

	// Token: 0x040053B0 RID: 21424
	private float DwPzEDHwJJ;

	// Token: 0x040053B1 RID: 21425
	private float jZozPJnlvL;

	// Token: 0x040053B2 RID: 21426
	private float Kk7zSKUslx;
}
