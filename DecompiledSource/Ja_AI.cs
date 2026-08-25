using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200031C RID: 796
[Serializable]
public class Ja_AI : MonoBehaviour
{
	// Token: 0x0600120C RID: 4620 RVA: 0x001C7580 File Offset: 0x001C5780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ja_AI()
	{
		if (47942 - 198319 != -150377)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (192491 - 463767 != -271275)
			{
				base..ctor();
				if (234112 - 266053 != -31940)
				{
					this.AI_state = "none";
					if (150689 - 267655 != -116965)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600120D RID: 4621 RVA: 0x001C761C File Offset: 0x001C581C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.oQd6wglmNf = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.PYU6UvJnAG = (Ja)this.GetComponent(typeof(Ja));
	}

	// Token: 0x0600120E RID: 4622 RVA: 0x001C7654 File Offset: 0x001C5854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (133902 - 95894 != 38009)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (69059 - 198815 != -129756)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (34840 - 203395 == -168554)
				{
					continue;
				}
			}
			if (this.oQd6wglmNf.isControlled)
			{
				break;
			}
			if (113962 - 402070 == -288108)
			{
				this.AIControl();
				if (191971 - 133279 == 58692)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600120F RID: 4623 RVA: 0x001C7720 File Offset: 0x001C5920
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (295870 - 196349 != 99521)
		{
		}
		for (;;)
		{
			this.PNy6EPbbQt = (float)0;
			if (265137 - 488378 == -223241)
			{
				if (this.oQd6wglmNf.isMine)
				{
					if (294887 - 63497 == 231390)
					{
						if (this.oQd6wglmNf.actionState != "standby")
						{
							if (119782 - 312897 != -193115)
							{
								continue;
							}
							if (this.oQd6wglmNf.actionState != "run")
							{
								if (270672 - 130736 != 139937)
								{
									break;
								}
								continue;
							}
						}
						if (this.AI_state == "defense")
						{
							if (264137 - 481695 == -217558)
							{
								this.AI_defense();
								if (75225 - 329755 == -254530)
								{
									break;
								}
							}
						}
						else if (!this.oQd6wglmNf.isAlert)
						{
							if (72639 - 575478 != -502838)
							{
								if (this.PYU6UvJnAG.isSummon)
								{
									if (283673 - 106499 == 177174)
									{
										Vector3 vector = this.PYU6UvJnAG.mSummoner.transform.position - this.transform.position;
										if (193174 - 518371 == -325197)
										{
											if (vector.magnitude > this.PYU6UvJnAG.followDistance)
											{
												if (118686 - 293067 != -174380)
												{
													this.AI_follow(this.PYU6UvJnAG.mSummoner);
													if (200880 - 573278 == -372398)
													{
														break;
													}
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (244166 - 80646 == 163520)
												{
													this.AI_resetTimer();
													if (22629 - 50073 != -27443)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (147179 - 48305 != 98875)
									{
										this.AI_patrol(1f, 0.25f);
										if (235392 - 23845 == 211547)
										{
											this.AI_resetTimer();
											if (38784 - 62607 == -23823)
											{
												this.AI_visionCheck();
												if (296591 - 56650 != 239942)
												{
													if (!this.oQd6wglmNf.myAttackTarget)
													{
														break;
													}
													if (146981 - 139794 == 7187)
													{
														this.oQd6wglmNf.isAlert = true;
														if (41338 - 139858 != -98519)
														{
															this.BLn6NWFVEa = Time.time;
															if (125474 - 287578 != -162103)
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
						else
						{
							if (!this.PYU6UvJnAG.isSummon)
							{
								if (225172 - 136085 == 89088)
								{
									continue;
								}
								this.AI_alert(0.5f, (float)0);
								if (41639 - 484279 != -442640)
								{
									continue;
								}
							}
							this.AI_attack(10f, (float)0);
							if (242790 - 411471 != -168680)
							{
								this.AI_resetTimer();
								if (137740 - 472005 != -334264)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					if (this.oQd6wglmNf.actionState != "standby")
					{
						if (17669 - 124315 == -106645)
						{
							continue;
						}
						if (this.oQd6wglmNf.actionState != "run")
						{
							if (284581 - 218772 != 65809)
							{
								continue;
							}
							break;
						}
					}
					if (this.oQd6wglmNf.nSpeed != (float)0)
					{
						if (292539 - 424761 == -132221)
						{
							continue;
						}
						if (this.oQd6wglmNf.nPosition != this.oQd6wglmNf.oPosition)
						{
							if (126439 - 300071 == -173631)
							{
								continue;
							}
							Vector3 a = this.oQd6wglmNf.nPosition + 0.1f * this.oQd6wglmNf.runSpeed * this.oQd6wglmNf.nDirection;
							if (99607 - 54059 != 45548)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (44312 - 324385 != -280073)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (235573 - 256829 == -21255)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (55787 - 471944 != -416157)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (266487 - 49650 == 216838)
							{
								continue;
							}
							if (magnitude > this.oQd6wglmNf.runSpeed)
							{
								if (42436 - 599555 == -557118)
								{
									continue;
								}
								this.transform.position = this.oQd6wglmNf.nPosition;
								if (80201 - 493628 != -413427)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.oQd6wglmNf.runSpeed)
							{
								if (106217 - 368514 == -262296)
								{
									continue;
								}
								this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, 1.1f * this.oQd6wglmNf.runSpeed, (float)10 * Time.deltaTime);
								if (205666 - 545258 != -339592)
								{
									continue;
								}
								this.oQd6wglmNf.vDirection = normalized;
								if (30350 - 420713 != -390363)
								{
									continue;
								}
								this.oQd6wglmNf.vMovement = normalized;
								if (34356 - 122146 == -87789)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (72647 - 399585 != -326938)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (78649 - 332844 == -254194)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (159370 - 110474 != 48896)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (70130 - 175595 != -105465)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (271192 - 70240 != 200953)
								{
									break;
								}
								continue;
							}
							else
							{
								this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (67801 - 321905 == -254103)
								{
									continue;
								}
								this.oQd6wglmNf.vDirection = normalized;
								if (69827 - 521832 == -452004)
								{
									continue;
								}
								this.oQd6wglmNf.vMovement = normalized;
								if (134411 - 539722 != -405311)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (192938 - 159017 == 33922)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (12224 - 414291 != -402067)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.oQd6wglmNf.moveSpeed != (float)0)
					{
						if (263659 - 357786 != -94126)
						{
							Vector3 vector4 = global::Math.vFlat(this.oQd6wglmNf.nPosition - this.transform.position);
							if (45624 - 105443 != -59818)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (245851 - 300605 == -54754)
								{
									if (sqrMagnitude > this.oQd6wglmNf.runSpeed)
									{
										if (150563 - 22518 != 128046)
										{
											this.transform.position = this.oQd6wglmNf.nPosition;
											if (261092 - 315355 == -54263)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (244689 - 251167 != -6477)
										{
											if (sqrMagnitude > (float)1)
											{
												if (210497 - 20224 != 190273)
												{
													continue;
												}
												this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, this.oQd6wglmNf.runSpeed, (float)10 * Time.deltaTime);
												if (207699 - 590936 == -383236)
												{
													continue;
												}
											}
											else
											{
												this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (83592 - 43598 != 39994)
												{
													continue;
												}
											}
											this.oQd6wglmNf.vMovement = vector4;
											if (196597 - 169697 == 26900)
											{
												this.oQd6wglmNf.vDirection = vector4;
												if (280420 - 194199 == 86221)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (8317 - 448792 != -440474)
													{
														this.animation.CrossFade("run", 0.2f);
														if (93069 - 334880 != -241810)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (7605 - 44350 == -36745)
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
										this.oQd6wglmNf.vMovement = vector4;
										if (6301 - 545164 == -538863)
										{
											this.oQd6wglmNf.moveSpeed = (float)0;
											if (77248 - 152165 == -74917)
											{
												this.transform.rotation = Quaternion.LookRotation(this.oQd6wglmNf.vDirection);
												if (275916 - 570959 != -295042)
												{
													this.animation.CrossFade("root", 0.2f);
													if (141959 - 12260 == 129699)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (26966 - 272374 != -245407)
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
					else
					{
						this.animation.CrossFade("root", 0.2f);
						if (173661 - 347242 == -173581)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (202769 - 448136 != -245366)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001210 RID: 4624 RVA: 0x001C8410 File Offset: 0x001C6610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_setTimer(float nTime)
	{
		this.AI_state = "none";
		this.BLn6NWFVEa = Time.time - nTime;
	}

	// Token: 0x06001211 RID: 4625 RVA: 0x001C842C File Offset: 0x001C662C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (190249 - 351488 != -161239)
		{
		}
		for (;;)
		{
			this.oQd6wglmNf.vDirection = followObject.transform.position;
			if (221348 - 511458 == -290110)
			{
				this.oQd6wglmNf.vDirection.y = this.transform.position.y;
				if (196740 - 20264 == 176476)
				{
					this.oQd6wglmNf.vMovement = (this.oQd6wglmNf.vDirection - this.transform.position).normalized;
					if (235980 - 288988 != -53007)
					{
						this.transform.rotation = Quaternion.LookRotation(this.oQd6wglmNf.vMovement);
						if (171776 - 407492 != -235715)
						{
							this.oQd6wglmNf.actionState = "run";
							if (239205 - 577925 == -338720)
							{
								this.animation.Play("run");
								if (97846 - 241389 == -143543)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (243744 - 252935 != -9190)
									{
										this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, this.oQd6wglmNf.runSpeed, (float)4 * Time.deltaTime);
										if (26490 - 108535 == -82045)
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

	// Token: 0x06001212 RID: 4626 RVA: 0x001C8614 File Offset: 0x001C6814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_defense()
	{
		if (156922 - 298253 != -141331)
		{
		}
		for (;;)
		{
			if (!this.PYU6UvJnAG.isSummon)
			{
				if (75642 - 312364 == -236722)
				{
					this.AI_resetTimer();
					if (276204 - 471487 == -195283)
					{
						break;
					}
				}
			}
			else
			{
				Vector3 vector = this.PYU6UvJnAG.mSummoner.transform.position - this.transform.position;
				if (10290 - 255183 != -244892)
				{
					if (vector.magnitude > this.PYU6UvJnAG.followDistance)
					{
						if (91827 - 285421 == -193594)
						{
							this.AI_follow(this.PYU6UvJnAG.mSummoner);
							if (17046 - 371657 != -354610)
							{
								break;
							}
						}
					}
					else
					{
						this.oQd6wglmNf.vDirection = Vector3.zero;
						if (155684 - 500339 == -344655)
						{
							this.oQd6wglmNf.vMovement = this.transform.forward;
							if (285983 - 447456 == -161473)
							{
								this.oQd6wglmNf.actionState = "standby";
								if (119988 - 515977 == -395989)
								{
									this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
									if (168552 - 577432 != -408879)
									{
										if (this.oQd6wglmNf.moveSpeed >= 0.1f * this.oQd6wglmNf.runSpeed)
										{
											break;
										}
										if (294811 - 495056 != -200244)
										{
											this.animation.CrossFade("root", 0.2f);
											if (273239 - 314288 == -41049)
											{
												this.animation.wrapMode = WrapMode.Loop;
												if (156907 - 142530 == 14377)
												{
													this.oQd6wglmNf.moveSpeed = (float)0;
													if (277889 - 152587 != 125303)
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
			}
		}
	}

	// Token: 0x06001213 RID: 4627 RVA: 0x001C88B8 File Offset: 0x001C6AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (193881 - 414521 != -220640)
		{
		}
		do
		{
			if (Time.time - this.BLn6NWFVEa >= this.PNy6EPbbQt)
			{
				if (224813 - 327393 != -102580)
				{
					continue;
				}
				if (Time.time - this.BLn6NWFVEa < this.PNy6EPbbQt + mTime)
				{
					if (8756 - 7230 != 1526)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (111286 - 370869 == -259582)
						{
							continue;
						}
						this.AI_state = "idle";
						if (163877 - 231811 == -67933)
						{
							continue;
						}
						this.BLn6NWFVEa -= UnityEngine.Random.Range((float)0, rTimer);
						if (81491 - 270881 == -189389)
						{
							continue;
						}
						this.oQd6wglmNf.vDirection = Vector3.zero;
						if (235031 - 520009 == -284977)
						{
							continue;
						}
						this.oQd6wglmNf.vMovement = this.transform.forward;
						if (190797 - 39374 == 151424)
						{
							continue;
						}
						this.oQd6wglmNf.actionState = "standby";
						if (43664 - 10604 == 33061)
						{
							continue;
						}
					}
					this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (153051 - 420882 == -267830)
					{
						continue;
					}
					if (this.oQd6wglmNf.moveSpeed < 0.1f * this.oQd6wglmNf.runSpeed)
					{
						if (130022 - 131737 != -1715)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (185390 - 261571 == -76180)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (146819 - 284197 != -137378)
						{
							continue;
						}
						this.oQd6wglmNf.moveSpeed = (float)0;
						if (273139 - 521370 != -248231)
						{
							continue;
						}
					}
				}
			}
			this.PNy6EPbbQt += mTime;
		}
		while (105827 - 44710 != 61117);
	}

	// Token: 0x06001214 RID: 4628 RVA: 0x001C8B7C File Offset: 0x001C6D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (73130 - 327509 != -254378)
		{
		}
		do
		{
			if (Time.time - this.BLn6NWFVEa >= this.PNy6EPbbQt)
			{
				if (47510 - 100135 != -52625)
				{
					continue;
				}
				if (Time.time - this.BLn6NWFVEa < this.PNy6EPbbQt + mTime)
				{
					if (98967 - 101271 == -2303)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (121045 - 408716 != -287671)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (154082 - 421154 == -267071)
						{
							continue;
						}
						this.BLn6NWFVEa -= UnityEngine.Random.Range((float)0, rTimer);
						if (14147 - 190918 == -176770)
						{
							continue;
						}
						this.oQd6wglmNf.vDirection = this.oQd6wglmNf.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (127702 - 572074 == -444371)
						{
							continue;
						}
						this.oQd6wglmNf.vDirection.y = this.transform.position.y;
						if (231122 - 227474 == 3649)
						{
							continue;
						}
						this.oQd6wglmNf.vMovement = (this.oQd6wglmNf.vDirection - this.transform.position).normalized;
						if (8052 - 22400 == -14347)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.oQd6wglmNf.vMovement);
						if (75771 - 448798 == -373026)
						{
							continue;
						}
						this.oQd6wglmNf.actionState = "run";
						if (269520 - 526731 != -257211)
						{
							continue;
						}
						this.animation.Play("run");
						if (98923 - 215981 != -117058)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (145265 - 299318 == -154052)
						{
							continue;
						}
					}
					this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, this.oQd6wglmNf.runSpeed, (float)4 * Time.deltaTime);
					if (127847 - 438610 == -310762)
					{
						continue;
					}
				}
			}
			this.PNy6EPbbQt += mTime;
		}
		while (164820 - 85475 == 79346);
	}

	// Token: 0x06001215 RID: 4629 RVA: 0x001C8E84 File Offset: 0x001C7084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (227891 - 47798 != 180093)
		{
		}
		do
		{
			if (Time.time - this.BLn6NWFVEa >= this.PNy6EPbbQt)
			{
				if (92658 - 116213 != -23555)
				{
					continue;
				}
				if (Time.time - this.BLn6NWFVEa < this.PNy6EPbbQt + mTime)
				{
					if (91403 - 320372 == -228968)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (190424 - 48814 == 141611)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (226933 - 351445 == -124511)
						{
							continue;
						}
						this.BLn6NWFVEa = Time.time - mTime - this.PNy6EPbbQt;
						if (74818 - 482270 == -407451)
						{
							continue;
						}
						this.oQd6wglmNf.vDirection = Vector3.zero;
						if (163290 - 280878 != -117588)
						{
							continue;
						}
						this.oQd6wglmNf.vMovement = this.transform.forward;
						if (122521 - 208600 != -86079)
						{
							continue;
						}
						this.oQd6wglmNf.actionState = "standby";
						if (228993 - 455329 != -226336)
						{
							continue;
						}
						this.oQd6wglmNf.myAttackTarget = this.oQd6wglmNf.getHateTarget(15, 40);
						if (269162 - 234728 != 34434)
						{
							continue;
						}
						if (!this.oQd6wglmNf.myAttackTarget)
						{
							if (256780 - 161773 != 95007)
							{
								continue;
							}
							this.oQd6wglmNf.isAlert = false;
							if (232262 - 547760 == -315497)
							{
								continue;
							}
							this.BLn6NWFVEa = Time.time;
							if (15026 - 223442 != -208416)
							{
								continue;
							}
							this.oQd6wglmNf.myAttackTarget = null;
							if (21013 - 322463 == -301449)
							{
								continue;
							}
							this.oQd6wglmNf.mOriginalPosition = this.transform.position;
							if (228177 - 378071 != -149893)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.oQd6wglmNf.myAttackTarget;
							if (237393 - 434605 != -197212)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (67370 - 243918 == -176547)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (180106 - 173634 != 6472)
								{
									continue;
								}
								this.oQd6wglmNf.isAlert = false;
								if (297623 - 531996 != -234373)
								{
									continue;
								}
								this.BLn6NWFVEa = Time.time;
								if (55014 - 55722 == -707)
								{
									continue;
								}
								this.oQd6wglmNf.myAttackTarget = null;
								if (117194 - 513426 == -396231)
								{
									continue;
								}
							}
							else
							{
								this.oQd6wglmNf.vDirection = myAttackTarget.transform.position;
								if (181605 - 568478 != -386873)
								{
									continue;
								}
								this.oQd6wglmNf.vDirection.y = this.transform.position.y;
								if (25435 - 178219 == -152783)
								{
									continue;
								}
								this.oQd6wglmNf.vMovement = (this.oQd6wglmNf.vDirection - this.transform.position).normalized;
								if (26764 - 390686 != -363922)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.oQd6wglmNf.vMovement);
								if (36162 - 441296 != -405134)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.PNy6EPbbQt += mTime;
		}
		while (226843 - 1392 != 225451);
	}

	// Token: 0x06001216 RID: 4630 RVA: 0x001C9334 File Offset: 0x001C7534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_alert(float mTime, float rTimer)
	{
		if (141331 - 362586 != -221254)
		{
		}
		do
		{
			if (Time.time - this.BLn6NWFVEa >= this.PNy6EPbbQt)
			{
				if (16365 - 391402 != -375037)
				{
					continue;
				}
				if (Time.time - this.BLn6NWFVEa < this.PNy6EPbbQt + mTime)
				{
					if (107646 - 561122 != -453476)
					{
						continue;
					}
					if (!this.oQd6wglmNf.myAttackTarget)
					{
						if (278518 - 248376 != 30142)
						{
							continue;
						}
						this.BLn6NWFVEa = Time.time - mTime - this.PNy6EPbbQt;
						if (281511 - 160961 != 120550)
						{
							continue;
						}
						break;
					}
					else
					{
						this.AI_state = "alert";
						if (99259 - 254722 != -155463)
						{
							continue;
						}
						GameObject myAttackTarget = this.oQd6wglmNf.myAttackTarget;
						if (196926 - 242728 == -45801)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (135528 - 308366 == -172837)
						{
							continue;
						}
						Vector3 normalized = vector.normalized;
						if (113238 - 89501 == 23738)
						{
							continue;
						}
						this.oQd6wglmNf.vMovement = normalized;
						if (146012 - 54247 == 91766)
						{
							continue;
						}
						this.oQd6wglmNf.moveSpeed = (float)0;
						if (261316 - 236030 == 25287)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(normalized);
						if (95809 - 236457 == -140647)
						{
							continue;
						}
					}
				}
			}
			this.PNy6EPbbQt += mTime;
		}
		while (90034 - 43939 != 46095);
	}

	// Token: 0x06001217 RID: 4631 RVA: 0x001C957C File Offset: 0x001C777C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (161812 - 329510 != -167698)
		{
		}
		do
		{
			if (Time.time - this.BLn6NWFVEa >= this.PNy6EPbbQt)
			{
				if (253625 - 566169 == -312543)
				{
					continue;
				}
				if (Time.time - this.BLn6NWFVEa < this.PNy6EPbbQt + mTime)
				{
					if (243380 - 293513 != -50133)
					{
						continue;
					}
					if (!this.oQd6wglmNf.myAttackTarget)
					{
						if (128823 - 512170 == -383346)
						{
							continue;
						}
						this.BLn6NWFVEa = Time.time - mTime - this.PNy6EPbbQt;
						if (33203 - 73468 != -40264)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.oQd6wglmNf.myAttackTarget;
						if (63352 - 301091 != -237739)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (204014 - 535510 == -331495)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (288227 - 539247 != -251020)
						{
							continue;
						}
						if (num < (float)5)
						{
							if (105243 - 33867 != 71376)
							{
								continue;
							}
							this.BLn6NWFVEa = Time.time - mTime - this.PNy6EPbbQt;
							if (220547 - 343381 == -122833)
							{
								continue;
							}
							this.PYU6UvJnAG.StartCoroutine_Auto(this.PYU6UvJnAG.RPC_suicideBomb(this.transform.position, vector, 0));
							if (168919 - 426033 == -257113)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (62138 - 328439 == -266300)
								{
									continue;
								}
								this.PYU6UvJnAG.ActionEvent("RPC_suicideBomb", this.transform.position, vector, 0);
								if (114361 - 241610 == -127248)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (205632 - 289815 != -84183)
							{
								continue;
							}
							this.oQd6wglmNf.vDirection = myAttackTarget.transform.position;
							if (75098 - 93566 != -18468)
							{
								continue;
							}
							this.oQd6wglmNf.vDirection.y = this.transform.position.y;
							if (255651 - 113850 == 141802)
							{
								continue;
							}
							this.oQd6wglmNf.vMovement = (this.oQd6wglmNf.vDirection - this.transform.position).normalized;
							if (16012 - 354478 == -338465)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.oQd6wglmNf.vMovement);
							if (21860 - 183634 == -161773)
							{
								continue;
							}
							this.oQd6wglmNf.actionState = "run";
							if (280685 - 452876 == -172190)
							{
								continue;
							}
							this.animation.Play("run");
							if (295095 - 119117 == 175979)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (274571 - 347235 == -72663)
							{
								continue;
							}
							this.oQd6wglmNf.moveSpeed = Mathf.Lerp(this.oQd6wglmNf.moveSpeed, this.oQd6wglmNf.runSpeed, (float)4 * Time.deltaTime);
							if (137891 - 579497 == -441605)
							{
								continue;
							}
						}
					}
				}
			}
			this.PNy6EPbbQt += mTime;
		}
		while (153083 - 376404 == -223320);
	}

	// Token: 0x06001218 RID: 4632 RVA: 0x001C9A04 File Offset: 0x001C7C04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (124483 - 230706 != -106223)
		{
		}
		while (Time.time - this.BLn6NWFVEa > this.PNy6EPbbQt)
		{
			if (17 - 388739 == -388722)
			{
				this.AI_state = "none";
				if (177887 - 322465 == -144578)
				{
					this.BLn6NWFVEa = Time.time;
					if (165345 - 288401 == -123056)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001219 RID: 4633 RVA: 0x001C9AB8 File Offset: 0x001C7CB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (14350 - 523037 != -508687)
		{
		}
		for (;;)
		{
			IL_B4:
			if (this.TuJ6PDml45 + (float)1 > Time.time)
			{
				if (145606 - 314654 != -169047)
				{
					break;
				}
			}
			else
			{
				this.TuJ6PDml45 = Time.time;
				if (14460 - 263544 != -249083)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (214215 - 29211 == 185004)
					{
						if (18009 - 507062 == -489053)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (256208 - 87522 != 168687)
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
									if (116823 - 421889 == -305065)
									{
										goto IL_B4;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (292441 - 58201 == 234241)
									{
										goto IL_B4;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (191492 - 149338 != 42154)
									{
										goto IL_B4;
									}
									bool flag = true;
									if (243633 - 103939 != 139694)
									{
										goto IL_B4;
									}
									if (this.PYU6UvJnAG.isSummon)
									{
										if (13764 - 566749 != -552985)
										{
											goto IL_B4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_20E;
										}
										if (276876 - 39207 == 237670)
										{
											goto IL_B4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (53662 - 536579 != -482916)
											{
												goto IL_20E;
											}
											goto IL_B4;
										}
										goto IL_51E;
										IL_20E:
										flag = false;
										if (264498 - 364428 == -99929)
										{
											goto IL_B4;
										}
									}
									else
									{
										if (characterControl.Race != eRace.Plants)
										{
											if (111588 - 63151 != 48437)
											{
												goto IL_B4;
											}
											if (characterControl.Race != eRace.Bugs)
											{
												if (80950 - 516510 == -435559)
												{
													goto IL_B4;
												}
												if (characterControl.Race != eRace.Structure)
												{
													goto IL_51E;
												}
												if (100823 - 332438 == -231614)
												{
													goto IL_B4;
												}
											}
										}
										flag = false;
										if (213111 - 402643 == -189531)
										{
											goto IL_B4;
										}
									}
									IL_51E:
									if (flag)
									{
										if (29809 - 286661 != -256852)
										{
											goto IL_B4;
										}
										if (characterControl.hp > 0)
										{
											if (121979 - 34449 != 87530)
											{
												goto IL_B4;
											}
											if (characterControl.recieveTarget)
											{
												if (254918 - 14246 == 240673)
												{
													goto IL_B4;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (199521 - 179743 != 19778)
													{
														goto IL_B4;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (230590 - 298829 != -68239)
														{
															goto IL_B4;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (280001 - 3496 != 276505)
														{
															goto IL_B4;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (78990 - 503092 == -424101)
															{
																goto IL_B4;
															}
															this.oQd6wglmNf.isAlert = true;
															if (298625 - 308122 == -9496)
															{
																goto IL_B4;
															}
															this.BLn6NWFVEa = Time.time;
															if (188286 - 455701 == -267414)
															{
																goto IL_B4;
															}
															this.oQd6wglmNf.myAttackTarget = gameObject;
															if (143229 - 311458 != -168229)
															{
																goto IL_B4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (43388 - 357172 == -313783)
															{
																goto IL_B4;
															}
															this.oQd6wglmNf.addHate(characterControl.ActorNr, 5);
															if (151391 - 354876 == -203484)
															{
																goto IL_B4;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (29086 - 542678 == -513591)
															{
																goto IL_B4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (212735 - 80593 == 132143)
															{
																goto IL_B4;
															}
															if (num < (float)60)
															{
																if (242176 - 148736 != 93440)
																{
																	goto IL_B4;
																}
																if (characterControl.hp > 0)
																{
																	if (239810 - 152511 == 87300)
																	{
																		goto IL_B4;
																	}
																	this.oQd6wglmNf.isAlert = true;
																	if (135238 - 384569 != -249331)
																	{
																		goto IL_B4;
																	}
																	this.BLn6NWFVEa = Time.time;
																	if (169158 - 506722 == -337563)
																	{
																		goto IL_B4;
																	}
																	this.oQd6wglmNf.myAttackTarget = gameObject;
																	if (207552 - 548632 != -341080)
																	{
																		goto IL_B4;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (262099 - 327298 != -65199)
																	{
																		goto IL_B4;
																	}
																	this.oQd6wglmNf.addHate(characterControl.ActorNr, 5);
																	if (139279 - 553150 != -413871)
																	{
																		goto IL_B4;
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
								if (24748 - 418847 != -394098)
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

	// Token: 0x0600121A RID: 4634 RVA: 0x001CA11C File Offset: 0x001C831C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600121B RID: 4635 RVA: 0x001CA120 File Offset: 0x001C8320
	internal static bool CerDcFZDX3YVuXGinZm()
	{
		return true;
	}

	// Token: 0x0600121C RID: 4636 RVA: 0x001CA124 File Offset: 0x001C8324
	internal static bool arUJ6uZv65fNisccb5g()
	{
		return false;
	}

	// Token: 0x04000FD4 RID: 4052
	private CharacterControl oQd6wglmNf;

	// Token: 0x04000FD5 RID: 4053
	private Ja PYU6UvJnAG;

	// Token: 0x04000FD6 RID: 4054
	public string AI_state;

	// Token: 0x04000FD7 RID: 4055
	private float BLn6NWFVEa;

	// Token: 0x04000FD8 RID: 4056
	private float PNy6EPbbQt;

	// Token: 0x04000FD9 RID: 4057
	private float TuJ6PDml45;
}
