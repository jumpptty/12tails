using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A4C RID: 2636
[Serializable]
public class Fungko_AI : MonoBehaviour
{
	// Token: 0x060039B8 RID: 14776 RVA: 0x0078D89C File Offset: 0x0078BA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fungko_AI()
	{
		if (296617 - 498386 != -201768)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (178301 - 329775 != -151473)
			{
				base..ctor();
				if (6315 - 410471 != -404155)
				{
					this.AI_state = "none";
					if (107699 - 156065 == -48366)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060039B9 RID: 14777 RVA: 0x0078D938 File Offset: 0x0078BB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Ufs9oMBlXQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Cwa9klGf3O = (Fungko)this.GetComponent(typeof(Fungko));
	}

	// Token: 0x060039BA RID: 14778 RVA: 0x0078D970 File Offset: 0x0078BB70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (127626 - 174018 != -46392)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (66382 - 40806 == 25577)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (235790 - 514695 != -278905)
				{
					continue;
				}
			}
			if (this.Ufs9oMBlXQ.isControlled)
			{
				break;
			}
			if (260420 - 448838 == -188418)
			{
				this.AIControl();
				if (52075 - 141681 == -89606)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060039BB RID: 14779 RVA: 0x0078DA3C File Offset: 0x0078BC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (43891 - 260631 != -216739)
		{
		}
		for (;;)
		{
			this.ukn9AUvTY7 = (float)0;
			if (34492 - 362952 == -328460)
			{
				if (this.Ufs9oMBlXQ.isMine)
				{
					if (125610 - 33794 != 91817)
					{
						if (this.Ufs9oMBlXQ.actionState != "standby")
						{
							if (70081 - 488077 == -417995)
							{
								continue;
							}
							if (this.Ufs9oMBlXQ.actionState != "run")
							{
								if (292669 - 397332 != -104663)
								{
									continue;
								}
								break;
							}
						}
						if (!this.Ufs9oMBlXQ.isAlert)
						{
							if (10678 - 13887 == -3209)
							{
								this.AI_idle(2f, 1f);
								if (146745 - 344616 == -197871)
								{
									this.AI_patrol(2f, 1f);
									if (58108 - 327630 == -269522)
									{
										this.AI_resetTimer();
										if (280824 - 263357 != 17468)
										{
											this.AI_visionCheck();
											if (211626 - 180823 == 30803)
											{
												if (!this.Ufs9oMBlXQ.myAttackTarget)
												{
													break;
												}
												if (165513 - 328454 == -162941)
												{
													this.Ufs9oMBlXQ.isAlert = true;
													if (248252 - 432777 == -184525)
													{
														this.wHL9FSpGOL = Time.time;
														if (179101 - 577740 != -398638)
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
							if (66816 - 27518 != 39299)
							{
								this.AI_idle(1.5f, 1f);
								if (244481 - 471150 == -226669)
								{
									this.StartCoroutine_Auto(this.AI_attack(8f, (float)0));
									if (80942 - 244316 != -163373)
									{
										this.AI_resetTimer();
										if (228484 - 52240 == 176244)
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
					if (this.Ufs9oMBlXQ.actionState != "standby")
					{
						if (30919 - 40145 != -9226)
						{
							continue;
						}
						if (this.Ufs9oMBlXQ.actionState != "run")
						{
							if (169041 - 374700 != -205658)
							{
								break;
							}
							continue;
						}
					}
					float num = this.Ufs9oMBlXQ.moveSpeed;
					if (23693 - 288615 == -264922)
					{
						float runSpeed = this.Ufs9oMBlXQ.runSpeed;
						if (187707 - 25265 != 162443)
						{
							Vector3 vector = default(Vector3);
							if (252302 - 66987 != 185316)
							{
								Vector3 vector2 = Vector3.zero;
								if (260452 - 251952 != 8501)
								{
									if ((this.Ufs9oMBlXQ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (298342 - 86991 != 211351)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Ufs9oMBlXQ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (67616 - 243831 != -176215)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (90177 - 532621 != -442444)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (249525 - 13329 != 236196)
											{
												continue;
											}
											num = (float)0;
											if (270978 - 221970 != 49008)
											{
												continue;
											}
											this.transform.position = this.Ufs9oMBlXQ.nPosition;
											if (259517 - 512593 == -253075)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (224502 - 451725 == -227222)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (47317 - 31485 != 15832)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (219116 - 355026 == -135909)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (13985 - 241559 != -227574)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (154990 - 578114 == -423123)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (209293 - 91742 == 117552)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (73642 - 177211 != -103569)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (272780 - 253971 == 18810)
											{
												continue;
											}
										}
									}
									this.Ufs9oMBlXQ.vMovement = vector2;
									if (283774 - 122886 == 160888)
									{
										this.Ufs9oMBlXQ.moveSpeed = num;
										if (122824 - 377044 == -254220)
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

	// Token: 0x060039BC RID: 14780 RVA: 0x0078E0BC File Offset: 0x0078C2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (196406 - 11346 != 185060)
		{
		}
		do
		{
			if (Time.time - this.wHL9FSpGOL >= this.ukn9AUvTY7)
			{
				if (27212 - 292390 == -265177)
				{
					continue;
				}
				if (Time.time - this.wHL9FSpGOL < this.ukn9AUvTY7 + mTime)
				{
					if (172262 - 154292 != 17970)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (54554 - 164470 == -109915)
						{
							continue;
						}
						this.AI_state = "idle";
						if (210905 - 563061 != -352156)
						{
							continue;
						}
						this.wHL9FSpGOL -= UnityEngine.Random.Range((float)0, rTimer);
						if (216310 - 480337 != -264027)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vDirection = Vector3.zero;
						if (146751 - 244963 != -98212)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vMovement = this.transform.forward;
						if (91585 - 527815 == -436229)
						{
							continue;
						}
						this.Ufs9oMBlXQ.actionState = "standby";
						if (101561 - 78020 != 23541)
						{
							continue;
						}
					}
					this.Ufs9oMBlXQ.moveSpeed = Mathf.Lerp(this.Ufs9oMBlXQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (277478 - 547277 == -269798)
					{
						continue;
					}
					if (this.Ufs9oMBlXQ.moveSpeed < 0.1f * this.Ufs9oMBlXQ.runSpeed)
					{
						if (238473 - 243064 != -4591)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (51428 - 65242 != -13814)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (162497 - 426425 != -263928)
						{
							continue;
						}
						this.Ufs9oMBlXQ.moveSpeed = (float)0;
						if (186504 - 162438 == 24067)
						{
							continue;
						}
					}
				}
			}
			this.ukn9AUvTY7 += mTime;
		}
		while (173420 - 132785 == 40636);
	}

	// Token: 0x060039BD RID: 14781 RVA: 0x0078E380 File Offset: 0x0078C580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (28731 - 273148 != -244416)
		{
		}
		do
		{
			if (Time.time - this.wHL9FSpGOL >= this.ukn9AUvTY7)
			{
				if (127014 - 189166 == -62151)
				{
					continue;
				}
				if (Time.time - this.wHL9FSpGOL < this.ukn9AUvTY7 + mTime)
				{
					if (58978 - 177782 == -118803)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (215537 - 85442 != 130095)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (232690 - 54463 != 178227)
						{
							continue;
						}
						this.wHL9FSpGOL -= UnityEngine.Random.Range((float)0, rTimer);
						if (219408 - 9270 != 210138)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vDirection = this.Ufs9oMBlXQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (168244 - 541665 != -373421)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vDirection.y = this.transform.position.y;
						if (50601 - 93854 == -43252)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vMovement = (this.Ufs9oMBlXQ.vDirection - this.transform.position).normalized;
						if (31215 - 151936 == -120720)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Ufs9oMBlXQ.vMovement);
						if (299164 - 591740 == -292575)
						{
							continue;
						}
						this.Ufs9oMBlXQ.actionState = "run";
						if (27146 - 381258 == -354111)
						{
							continue;
						}
						this.animation.Play("run");
						if (187360 - 515617 != -328257)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (166639 - 65326 == 101314)
						{
							continue;
						}
					}
					this.Ufs9oMBlXQ.moveSpeed = Mathf.Lerp(this.Ufs9oMBlXQ.moveSpeed, this.Ufs9oMBlXQ.runSpeed, (float)4 * Time.deltaTime);
					if (269380 - 568902 == -299521)
					{
						continue;
					}
				}
			}
			this.ukn9AUvTY7 += mTime;
		}
		while (82965 - 198855 == -115889);
	}

	// Token: 0x060039BE RID: 14782 RVA: 0x0078E688 File Offset: 0x0078C888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (289886 - 248464 != 41422)
		{
		}
		do
		{
			if (Time.time - this.wHL9FSpGOL >= this.ukn9AUvTY7)
			{
				if (13544 - 25224 == -11679)
				{
					continue;
				}
				if (Time.time - this.wHL9FSpGOL < this.ukn9AUvTY7 + mTime)
				{
					if (189518 - 517704 == -328185)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (168776 - 580870 != -412094)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (229472 - 299392 == -69919)
						{
							continue;
						}
						this.wHL9FSpGOL = Time.time - mTime - this.ukn9AUvTY7;
						if (26398 - 218183 == -191784)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vDirection = Vector3.zero;
						if (177698 - 427873 != -250175)
						{
							continue;
						}
						this.Ufs9oMBlXQ.vMovement = this.transform.forward;
						if (268918 - 235467 == 33452)
						{
							continue;
						}
						this.Ufs9oMBlXQ.actionState = "standby";
						if (43237 - 38036 != 5201)
						{
							continue;
						}
						this.Ufs9oMBlXQ.myAttackTarget = this.Ufs9oMBlXQ.getHateTarget(5, 50);
						if (132049 - 298370 != -166321)
						{
							continue;
						}
						if (!this.Ufs9oMBlXQ.myAttackTarget)
						{
							if (3345 - 15369 != -12024)
							{
								continue;
							}
							this.Ufs9oMBlXQ.isAlert = false;
							if (87201 - 372372 == -285170)
							{
								continue;
							}
							this.wHL9FSpGOL = Time.time;
							if (126933 - 255813 != -128880)
							{
								continue;
							}
							this.Ufs9oMBlXQ.myAttackTarget = null;
							if (42405 - 483317 != -440912)
							{
								continue;
							}
							this.Ufs9oMBlXQ.mOriginalPosition = this.transform.position;
							if (115950 - 136402 != -20452)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Ufs9oMBlXQ.myAttackTarget;
							if (226004 - 107436 == 118569)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (35625 - 10134 != 25491)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (160163 - 386931 != -226768)
								{
									continue;
								}
								this.Ufs9oMBlXQ.isAlert = false;
								if (41120 - 477657 == -436536)
								{
									continue;
								}
								this.wHL9FSpGOL = Time.time;
								if (49400 - 448201 != -398801)
								{
									continue;
								}
								this.Ufs9oMBlXQ.myAttackTarget = null;
								if (118948 - 266909 == -147960)
								{
									continue;
								}
							}
							else
							{
								this.Ufs9oMBlXQ.vDirection = myAttackTarget.transform.position;
								if (5227 - 234687 == -229459)
								{
									continue;
								}
								this.Ufs9oMBlXQ.vDirection.y = this.transform.position.y;
								if (158156 - 103969 == 54188)
								{
									continue;
								}
								this.Ufs9oMBlXQ.vMovement = (this.Ufs9oMBlXQ.vDirection - this.transform.position).normalized;
								if (274505 - 458345 == -183839)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Ufs9oMBlXQ.vMovement);
								if (180642 - 309981 == -129338)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ukn9AUvTY7 += mTime;
		}
		while (172481 - 132977 == 39505);
	}

	// Token: 0x060039BF RID: 14783 RVA: 0x0078EB38 File Offset: 0x0078CD38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new Fungko_AI.$AI_attack$30126(mTime, this).GetEnumerator();
	}

	// Token: 0x060039C0 RID: 14784 RVA: 0x0078EB48 File Offset: 0x0078CD48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (162595 - 364264 != -201669)
		{
		}
		while (Time.time - this.wHL9FSpGOL > this.ukn9AUvTY7)
		{
			if (65173 - 168440 == -103267)
			{
				this.AI_state = "none";
				if (272622 - 124087 == 148535)
				{
					this.wHL9FSpGOL = Time.time;
					if (296858 - 31781 == 265077)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060039C1 RID: 14785 RVA: 0x0078EBFC File Offset: 0x0078CDFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (228112 - 560024 != -331911)
		{
		}
		for (;;)
		{
			IL_589:
			if (this.WlM99Ex87P > Time.time)
			{
				if (125467 - 353805 == -228338)
				{
					break;
				}
			}
			else
			{
				this.WlM99Ex87P = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (166400 - 225054 == -58654)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (12878 - 266587 != -253708 && 221052 - 219899 != 1154)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (203748 - 69040 == 134708)
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
								if (113088 - 91038 != 22050)
								{
									goto IL_589;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (234140 - 381806 != -147666)
								{
									goto IL_589;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (150137 - 79540 == 70598)
								{
									goto IL_589;
								}
								bool flag = true;
								if (158620 - 577901 != -419281)
								{
									goto IL_589;
								}
								eRace race = this.Ufs9oMBlXQ.Race;
								if (229821 - 363555 != -133734)
								{
									goto IL_589;
								}
								if (race == eRace.Tails)
								{
									if (213238 - 357907 != -144669)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_10B;
									}
									if (30008 - 60145 != -30137)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (33463 - 507678 != -474214)
										{
											goto IL_10B;
										}
										goto IL_589;
									}
									goto IL_2A7;
									IL_10B:
									flag = false;
									if (114614 - 30614 != 84000)
									{
										goto IL_589;
									}
								}
								else if (race == eRace.Plants)
								{
									if (166332 - 309087 == -142754)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										if (261680 - 105974 != 155706)
										{
											goto IL_589;
										}
										flag = false;
										if (58174 - 316561 != -258387)
										{
											goto IL_589;
										}
									}
								}
								else if (race == eRace.Bugs)
								{
									if (26842 - 13112 == 13731)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_44A;
									}
									if (29370 - 114815 == -85444)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (277063 - 276234 != 829)
										{
											goto IL_589;
										}
										goto IL_44A;
									}
									goto IL_2A7;
									IL_44A:
									flag = false;
									if (172596 - 47747 != 124849)
									{
										goto IL_589;
									}
								}
								else if (race == eRace.Robots)
								{
									if (233703 - 53752 != 179951)
									{
										goto IL_589;
									}
									flag = true;
									if (254892 - 274806 != -19914)
									{
										goto IL_589;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (250746 - 66854 == 183893)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6BB;
									}
									if (83662 - 188407 == -104744)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6BB;
									}
									if (116130 - 17311 == 98820)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (160841 - 80057 != 80785)
										{
											goto IL_6BB;
										}
										goto IL_589;
									}
									goto IL_2A7;
									IL_6BB:
									flag = false;
									if (236739 - 152151 == 84589)
									{
										goto IL_589;
									}
								}
								else if (race == eRace.Structure)
								{
									if (52335 - 458600 == -406264)
									{
										goto IL_589;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (199538 - 450734 != -251196)
										{
											goto IL_589;
										}
										flag = false;
										if (78235 - 465196 == -386960)
										{
											goto IL_589;
										}
									}
								}
								IL_2A7:
								if (flag)
								{
									if (14474 - 214171 != -199697)
									{
										goto IL_589;
									}
									if (characterControl.hp > 0)
									{
										if (100756 - 321641 == -220884)
										{
											goto IL_589;
										}
										if (characterControl.recieveTarget)
										{
											if (57272 - 414679 != -357407)
											{
												goto IL_589;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (83866 - 328735 != -244869)
												{
													goto IL_589;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (53252 - 557172 == -503919)
													{
														goto IL_589;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (165671 - 96809 == 68863)
													{
														goto IL_589;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (267983 - 348062 == -80078)
														{
															goto IL_589;
														}
														this.Ufs9oMBlXQ.myAttackTarget = gameObject;
														if (156399 - 34836 != 121563)
														{
															goto IL_589;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (220048 - 334346 != -114298)
														{
															goto IL_589;
														}
														this.Ufs9oMBlXQ.addHate(characterControl.ActorNr, 5);
														if (230133 - 182083 == 48051)
														{
															goto IL_589;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (37871 - 558544 != -520673)
														{
															goto IL_589;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (275611 - 154985 == 120627)
														{
															goto IL_589;
														}
														if (num < (float)60)
														{
															if (72690 - 200340 != -127650)
															{
																goto IL_589;
															}
															if (characterControl.hp > 0)
															{
																if (218533 - 449601 == -231067)
																{
																	goto IL_589;
																}
																this.Ufs9oMBlXQ.myAttackTarget = gameObject;
																if (264928 - 308178 == -43249)
																{
																	goto IL_589;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (155528 - 568711 != -413183)
																{
																	goto IL_589;
																}
																this.Ufs9oMBlXQ.addHate(characterControl.ActorNr, 5);
																if (27041 - 110755 != -83714)
																{
																	goto IL_589;
																}
															}
														}
													}
													if (this.Ufs9oMBlXQ.myAttackTarget)
													{
														if (12310 - 313506 != -301196)
														{
															goto IL_589;
														}
														this.Ufs9oMBlXQ.isAlert = true;
														if (298821 - 594647 != -295826)
														{
															goto IL_589;
														}
														this.wHL9FSpGOL = Time.time;
														if (176175 - 366731 == -190555)
														{
															goto IL_589;
														}
													}
												}
											}
										}
									}
								}
							}
							if (72252 - 62233 == 10019)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060039C2 RID: 14786 RVA: 0x0078F43C File Offset: 0x0078D63C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060039C3 RID: 14787 RVA: 0x0078F440 File Offset: 0x0078D640
	internal static bool KjpVOZ525uVXec1lwbmu()
	{
		return true;
	}

	// Token: 0x060039C4 RID: 14788 RVA: 0x0078F444 File Offset: 0x0078D644
	internal static bool DGns8O52p9Xj7p00U1Nx()
	{
		return false;
	}

	// Token: 0x04004809 RID: 18441
	private CharacterControl Ufs9oMBlXQ;

	// Token: 0x0400480A RID: 18442
	private Fungko Cwa9klGf3O;

	// Token: 0x0400480B RID: 18443
	public string AI_state;

	// Token: 0x0400480C RID: 18444
	private float wHL9FSpGOL;

	// Token: 0x0400480D RID: 18445
	private float ukn9AUvTY7;

	// Token: 0x0400480E RID: 18446
	private float WlM99Ex87P;

	// Token: 0x02000A4D RID: 2637
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$30126 : GenericGenerator<object>
	{
		// Token: 0x060039C5 RID: 14789 RVA: 0x0078F448 File Offset: 0x0078D648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$30126(float mTime, Fungko_AI self_)
		{
			if (19288 - 406488 != -387200)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (44016 - 358957 == -314941)
				{
					base..ctor();
					if (195898 - 598551 != -402652)
					{
						this.$mTime$30137 = mTime;
						if (55272 - 518212 != -462939)
						{
							this.$self_$30138 = self_;
							if (201424 - 506107 != -304682)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x0078F504 File Offset: 0x0078D704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<object> GetEnumerator()
		{
			return new Fungko_AI.$AI_attack$30126.$(this.$mTime$30137, this.$self_$30138);
		}

		// Token: 0x060039C7 RID: 14791 RVA: 0x0078F518 File Offset: 0x0078D718
		internal static bool obrpuB52VW7efg8hVKeB()
		{
			return true;
		}

		// Token: 0x060039C8 RID: 14792 RVA: 0x0078F51C File Offset: 0x0078D71C
		internal static bool yC7YJH52tIX5jlY5r4pw()
		{
			return false;
		}

		// Token: 0x0400480F RID: 18447
		internal float $mTime$30137;

		// Token: 0x04004810 RID: 18448
		internal Fungko_AI $self_$30138;

		// Token: 0x02000A4E RID: 2638
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<object>, IEnumerator
		{
			// Token: 0x060039C9 RID: 14793 RVA: 0x0078F520 File Offset: 0x0078D720
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, Fungko_AI self_)
			{
				if (288416 - 311997 != -23580)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (59296 - 95080 != -35783)
					{
						base..ctor();
						if (12677 - 574484 != -561806)
						{
							this.$mTime$30135 = mTime;
							if (123774 - 545441 != -421666)
							{
								this.$self_$30136 = self_;
								if (174908 - 24853 == 150055)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060039CA RID: 14794 RVA: 0x0078F5DC File Offset: 0x0078D7DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130293 - 135858 != -5564)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D06;
					case 2:
					{
						object obj2;
						object obj = obj2 = this.$tFriendList$30132[UnityEngine.Random.Range(0, this.$tFriendList$30132.length)];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tFriend$30133 = (GameObject)obj2;
						if (202610 - 547602 == -344991)
						{
							continue;
						}
						if (!this.$tFriend$30133)
						{
							goto IL_28A;
						}
						if (131288 - 589802 == -458513)
						{
							continue;
						}
						this.$tFriendChar$30134 = (CharacterControl)this.$tFriend$30133.GetComponent(typeof(CharacterControl));
						if (160333 - 439001 == -278667)
						{
							continue;
						}
						if (!this.$tFriendChar$30134)
						{
							goto IL_28A;
						}
						if (36830 - 69612 == -32781)
						{
							continue;
						}
						if (this.$tFriend$30133 == this.$self_$30136.gameObject)
						{
							if (11128 - 283811 != -272683)
							{
								continue;
							}
							this.$tDir$30129 = this.$self_$30136.transform.forward;
							if (194770 - 205648 != -10878)
							{
								continue;
							}
						}
						else
						{
							this.$tDir$30129 = (this.$tFriend$30133.transform.position - this.$self_$30136.transform.position).normalized;
							if (36886 - 64840 != -27954)
							{
								continue;
							}
						}
						this.$tID$30130 = this.$tFriendChar$30134.ActorNr;
						if (276940 - 145033 != 131907)
						{
							continue;
						}
						this.$self_$30136.Cwa9klGf3O.StartCoroutine_Auto(this.$self_$30136.Cwa9klGf3O.RPC_buff(this.$self_$30136.transform.position, this.$tDir$30129, this.$tID$30130));
						if (180385 - 525311 == -344925)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_28A;
						}
						if (110122 - 401496 != -291374)
						{
							continue;
						}
						this.$self_$30136.Cwa9klGf3O.ActionEvent("RPC_buff", this.$self_$30136.transform.position, this.$tDir$30129, this.$tID$30130);
						if (93475 - 504143 != -410667)
						{
							goto IL_28A;
						}
						continue;
					}
					default:
						if (43867 - 120662 != -76795)
						{
							continue;
						}
						break;
					}
					if (Time.time - this.$self_$30136.wHL9FSpGOL >= this.$self_$30136.ukn9AUvTY7)
					{
						if (256904 - 320618 != -63714)
						{
							continue;
						}
						if (Time.time - this.$self_$30136.wHL9FSpGOL < this.$self_$30136.ukn9AUvTY7 + this.$mTime$30135)
						{
							if (51112 - 145302 == -94189)
							{
								continue;
							}
							if (!this.$self_$30136.Ufs9oMBlXQ.myAttackTarget)
							{
								if (202097 - 250596 != -48499)
								{
									continue;
								}
								this.$self_$30136.wHL9FSpGOL = Time.time - this.$mTime$30135 - this.$self_$30136.ukn9AUvTY7;
								if (171512 - 359277 != -187765)
								{
									continue;
								}
								goto IL_B94;
							}
							else
							{
								this.$tObject$30127 = this.$self_$30136.Ufs9oMBlXQ.myAttackTarget;
								if (278951 - 378157 != -99206)
								{
									continue;
								}
								this.$tChar$30128 = (CharacterControl)this.$tObject$30127.GetComponent(typeof(CharacterControl));
								if (7666 - 393443 == -385776)
								{
									continue;
								}
								this.$tDir$30129 = this.$tObject$30127.transform.position - this.$self_$30136.transform.position;
								if (98807 - 12132 != 86675)
								{
									continue;
								}
								this.$tID$30130 = 0;
								if (274133 - 134863 == 139271)
								{
									continue;
								}
								if (this.$tChar$30128)
								{
									if (227859 - 150992 == 76868)
									{
										continue;
									}
									this.$tID$30130 = this.$tChar$30128.ActorNr;
									if (278440 - 399567 == -121126)
									{
										continue;
									}
								}
								this.$distance$30131 = this.$tDir$30129.magnitude - this.$tObject$30127.collider.bounds.extents.x;
								if (168546 - 417759 != -249213)
								{
									continue;
								}
								if (this.$distance$30131 < (float)2)
								{
									if (17464 - 69182 != -51718)
									{
										continue;
									}
									if (this.$self_$30136.Ufs9oMBlXQ.isTimeOut("nAttack") == (float)0)
									{
										if (84103 - 269721 == -185617)
										{
											continue;
										}
										this.$self_$30136.wHL9FSpGOL = Time.time - this.$mTime$30135 - this.$self_$30136.ukn9AUvTY7;
										if (218229 - 509640 == -291410)
										{
											continue;
										}
										this.$self_$30136.Cwa9klGf3O.StartCoroutine_Auto(this.$self_$30136.Cwa9klGf3O.RPC_nAttack(this.$self_$30136.transform.position, this.$tDir$30129.normalized, 0));
										if (108169 - 75945 != 32225)
										{
											if (PhotonClient.IsInitialized())
											{
												if (185165 - 404676 == -219510)
												{
													continue;
												}
												this.$self_$30136.Cwa9klGf3O.ActionEvent("RPC_nAttack", this.$self_$30136.transform.position, this.$tDir$30129.normalized, 0);
												if (162479 - 10436 != 152043)
												{
													continue;
												}
											}
											goto IL_3CB;
										}
										continue;
									}
								}
								if (this.$self_$30136.Ufs9oMBlXQ.isTimeOut("cAttack") == (float)0)
								{
									if (63178 - 336602 != -273424)
									{
										continue;
									}
									this.$self_$30136.wHL9FSpGOL = Time.time - this.$mTime$30135 - this.$self_$30136.ukn9AUvTY7;
									if (209252 - 482362 == -273109)
									{
										continue;
									}
									if (UnityEngine.Random.Range(0, 100) < 60)
									{
										if (38590 - 555565 != -516975)
										{
											continue;
										}
										this.$tFriendList$30132 = Hate.findFriends(this.$self_$30136.transform.position, (float)40, this.$self_$30136.gameObject.layer);
										if (269349 - 425675 == -156325)
										{
											continue;
										}
										if (this.$tFriendList$30132.length > 0)
										{
											if (146371 - 213494 != -67122)
											{
												break;
											}
											continue;
										}
									}
									else
									{
										this.$self_$30136.Cwa9klGf3O.StartCoroutine_Auto(this.$self_$30136.Cwa9klGf3O.RPC_debuff(this.$self_$30136.transform.position, this.$tDir$30129, this.$tID$30130));
										if (287025 - 361277 == -74251)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (295172 - 233577 != 61595)
											{
												continue;
											}
											this.$self_$30136.Cwa9klGf3O.ActionEvent("RPC_debuff", this.$self_$30136.transform.position, this.$tDir$30129, this.$tID$30130);
											if (180957 - 252369 != -71412)
											{
												continue;
											}
										}
									}
								}
								else
								{
									this.$self_$30136.AI_state = "attack";
									if (288806 - 132824 == 155983)
									{
										continue;
									}
									if (this.$distance$30131 < (float)5)
									{
										if (269879 - 310953 == -41073)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.vDirection = this.$tObject$30127.transform.position;
										if (255143 - 223486 != 31657)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.vDirection.y = this.$self_$30136.transform.position.y;
										if (19698 - 32839 != -13141)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.vMovement = (this.$self_$30136.transform.position - this.$self_$30136.Ufs9oMBlXQ.vDirection).normalized;
										if (208337 - 510337 != -302000)
										{
											continue;
										}
										this.$self_$30136.transform.rotation = Quaternion.LookRotation(this.$self_$30136.Ufs9oMBlXQ.vMovement);
										if (4384 - 567255 != -562871)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.actionState = "run";
										if (191680 - 180998 != 10682)
										{
											continue;
										}
										this.$self_$30136.animation.Play("run");
										if (9492 - 77305 != -67813)
										{
											continue;
										}
										this.$self_$30136.animation.wrapMode = WrapMode.Loop;
										if (202716 - 245187 != -42471)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.moveSpeed = Mathf.Lerp(this.$self_$30136.Ufs9oMBlXQ.moveSpeed, this.$self_$30136.Ufs9oMBlXQ.runSpeed, (float)4 * Time.deltaTime);
										if (172362 - 523064 != -350702)
										{
											continue;
										}
									}
									else
									{
										this.$self_$30136.Ufs9oMBlXQ.vDirection = this.$tObject$30127.transform.position;
										if (187249 - 387332 == -200082)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.vDirection.y = this.$self_$30136.transform.position.y;
										if (55631 - 585454 == -529822)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.vMovement = (this.$self_$30136.Ufs9oMBlXQ.vDirection - this.$self_$30136.transform.position).normalized;
										if (56924 - 509123 == -452198)
										{
											continue;
										}
										this.$self_$30136.transform.rotation = Quaternion.LookRotation(this.$self_$30136.Ufs9oMBlXQ.vMovement);
										if (91321 - 541161 == -449839)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.actionState = "standby";
										if (215574 - 354137 != -138563)
										{
											continue;
										}
										this.$self_$30136.animation.CrossFade("root");
										if (247244 - 459287 == -212042)
										{
											continue;
										}
										this.$self_$30136.animation.wrapMode = WrapMode.Loop;
										if (142243 - 264507 != -122264)
										{
											continue;
										}
										this.$self_$30136.Ufs9oMBlXQ.moveSpeed = (float)0;
										if (273529 - 364659 == -91129)
										{
											continue;
										}
									}
								}
							}
						}
					}
					IL_3CB:
					this.$self_$30136.ukn9AUvTY7 = this.$self_$30136.ukn9AUvTY7 + this.$mTime$30135;
					if (2433 - 375617 == -373183)
					{
						continue;
					}
					this.YieldDefault(1);
					if (239456 - 194283 != 45173)
					{
						continue;
					}
					goto IL_D06;
					IL_25B:
					goto IL_3CB;
					IL_28A:
					goto IL_25B;
				}
				return this.YieldDefault(2);
				IL_B94:
				IL_D06:
				return false;
			}

			// Token: 0x060039CB RID: 14795 RVA: 0x00790304 File Offset: 0x0078E504
			internal static bool xielWK52NRxprRNoDXI6()
			{
				return true;
			}

			// Token: 0x060039CC RID: 14796 RVA: 0x00790308 File Offset: 0x0078E508
			internal static bool muAO1Z52YyY4LAa98Xjs()
			{
				return false;
			}

			// Token: 0x04004811 RID: 18449
			internal GameObject $tObject$30127;

			// Token: 0x04004812 RID: 18450
			internal CharacterControl $tChar$30128;

			// Token: 0x04004813 RID: 18451
			internal Vector3 $tDir$30129;

			// Token: 0x04004814 RID: 18452
			internal int $tID$30130;

			// Token: 0x04004815 RID: 18453
			internal float $distance$30131;

			// Token: 0x04004816 RID: 18454
			internal UnityScript.Lang.Array $tFriendList$30132;

			// Token: 0x04004817 RID: 18455
			internal GameObject $tFriend$30133;

			// Token: 0x04004818 RID: 18456
			internal CharacterControl $tFriendChar$30134;

			// Token: 0x04004819 RID: 18457
			internal float $mTime$30135;

			// Token: 0x0400481A RID: 18458
			internal Fungko_AI $self_$30136;
		}
	}
}
