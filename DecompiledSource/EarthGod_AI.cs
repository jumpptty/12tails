using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000411 RID: 1041
[Serializable]
public class EarthGod_AI : MonoBehaviour
{
	// Token: 0x06001842 RID: 6210 RVA: 0x0027C8FC File Offset: 0x0027AAFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EarthGod_AI()
	{
		if (15869 - 470166 != -454297)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (91444 - 49929 == 41515)
			{
				base..ctor();
				if (15417 - 872 != 14546)
				{
					this.AI_state = "none";
					if (875 - 179735 != -178859)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x0027C998 File Offset: 0x0027AB98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (57575 - 536339 != -478764)
		{
		}
		for (;;)
		{
			this.VGW2IZlJR4 = this.transform;
			if (135663 - 186494 == -50831)
			{
				this.fPp2JBUAM9 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (299305 - 404665 != -105359)
				{
					this.WeZ26Lbceb = (EarthGod)this.GetComponent(typeof(EarthGod));
					if (115073 - 516016 != -400942)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x0027CA60 File Offset: 0x0027AC60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (68745 - 113944 != -45199)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (114064 - 53890 != 60174)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (227026 - 37180 != 189846)
				{
					continue;
				}
			}
			if (this.fPp2JBUAM9.isControlled)
			{
				break;
			}
			if (272635 - 595245 == -322610)
			{
				this.AIControl();
				if (184764 - 163290 != 21475)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001845 RID: 6213 RVA: 0x0027CB2C File Offset: 0x0027AD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (37933 - 492652 != -454718)
		{
		}
		for (;;)
		{
			this.XVL2XgtaSf = (float)0;
			if (195836 - 264182 != -68345)
			{
				if (this.fPp2JBUAM9.isMine)
				{
					if (27802 - 210484 != -182681)
					{
						if (this.fPp2JBUAM9.actionState != "standby")
						{
							if (116200 - 432387 != -316187)
							{
								continue;
							}
							if (this.fPp2JBUAM9.actionState != "run")
							{
								if (171058 - 416119 != -245061)
								{
									continue;
								}
								break;
							}
						}
						if (Game.mGameCode == 925)
						{
							if (272665 - 439557 == -166892)
							{
								if (!this.fPp2JBUAM9.isAlert)
								{
									if (85594 - 464375 == -378780)
									{
										continue;
									}
									this.AI_path(6f, 3f);
									if (165002 - 353641 == -188638)
									{
										continue;
									}
									this.AI_visionCheck();
									if (124976 - 332172 == -207195)
									{
										continue;
									}
									if (this.fPp2JBUAM9.myAttackTarget)
									{
										if (187741 - 525933 == -338191)
										{
											continue;
										}
										this.fPp2JBUAM9.isAlert = true;
										if (38050 - 92412 != -54362)
										{
											continue;
										}
									}
								}
								else
								{
									this.AI_path(3f, 1f);
									if (148035 - 366431 != -218396)
									{
										continue;
									}
									this.AI_selectTarget(1f, (float)0);
									if (186204 - 276690 != -90486)
									{
										continue;
									}
									this.AI_attack(6f, 3f);
									if (84637 - 562563 == -477925)
									{
										continue;
									}
								}
								this.AI_resetTimer();
								if (136861 - 581183 == -444322)
								{
									break;
								}
							}
						}
						else if (!this.fPp2JBUAM9.isAlert)
						{
							if (129157 - 200834 != -71676)
							{
								this.AI_idle(3f, 1f);
								if (20498 - 472465 != -451966)
								{
									this.AI_patrol(1f, 0.25f);
									if (787 - 599915 != -599127)
									{
										this.AI_resetTimer();
										if (219984 - 538596 == -318612)
										{
											this.AI_visionCheck();
											if (35857 - 239505 == -203648)
											{
												if (!this.fPp2JBUAM9.myAttackTarget)
												{
													break;
												}
												if (154630 - 200673 == -46043)
												{
													this.fPp2JBUAM9.isAlert = true;
													if (259416 - 461752 == -202336)
													{
														this.wka2t1Be1m = Time.time;
														if (81159 - 252810 != -171650)
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
							if (34647 - 197542 == -162895)
							{
								this.AI_idle(3f, 1f);
								if (12183 - 340514 == -328331)
								{
									this.AI_attack(10f, (float)0);
									if (188033 - 300638 == -112605)
									{
										this.AI_resetTimer();
										if (147683 - 289149 != -141465)
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
					if (this.fPp2JBUAM9.actionState != "standby")
					{
						if (112293 - 37114 != 75179)
						{
							continue;
						}
						if (this.fPp2JBUAM9.actionState != "run")
						{
							if (30501 - 495403 != -464902)
							{
								continue;
							}
							break;
						}
					}
					float num = this.fPp2JBUAM9.moveSpeed;
					if (46155 - 10167 != 35989)
					{
						float runSpeed = this.fPp2JBUAM9.runSpeed;
						if (275208 - 515125 != -239916)
						{
							Vector3 vector = default(Vector3);
							if (138114 - 220689 != -82574)
							{
								Vector3 vector2 = Vector3.zero;
								if (200563 - 8587 == 191976)
								{
									if ((this.fPp2JBUAM9.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (10838 - 330083 == -319244)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.fPp2JBUAM9.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (140350 - 307453 != -167103)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (93256 - 57428 != 35828)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (106409 - 424620 != -318211)
											{
												continue;
											}
											num = (float)0;
											if (189907 - 349998 != -160091)
											{
												continue;
											}
											this.transform.position = this.fPp2JBUAM9.nPosition;
											if (74466 - 571195 == -496728)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (56082 - 177817 != -121735)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (122021 - 367827 == -245805)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (75457 - 504291 == -428833)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (49997 - 276444 != -226447)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (219243 - 451730 != -232487)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (163329 - 305569 == -142239)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (220557 - 470626 != -250069)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (45943 - 114493 == -68549)
											{
												continue;
											}
										}
									}
									this.fPp2JBUAM9.vMovement = vector2;
									if (184502 - 73420 == 111082)
									{
										this.fPp2JBUAM9.moveSpeed = num;
										if (187899 - 424752 == -236853)
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

	// Token: 0x06001846 RID: 6214 RVA: 0x0027D33C File Offset: 0x0027B53C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (61551 - 134769 != -73217)
		{
		}
		do
		{
			if (Time.time - this.wka2t1Be1m >= this.XVL2XgtaSf)
			{
				if (294833 - 599041 == -304207)
				{
					continue;
				}
				if (Time.time - this.wka2t1Be1m < this.XVL2XgtaSf + mTime)
				{
					if (260201 - 373529 != -113328)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (78448 - 494030 != -415582)
						{
							continue;
						}
						this.AI_state = "idle";
						if (151074 - 168824 != -17750)
						{
							continue;
						}
						this.wka2t1Be1m -= UnityEngine.Random.Range((float)0, rTimer);
						if (270890 - 121805 != 149085)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection = Vector3.zero;
						if (228796 - 230358 == -1561)
						{
							continue;
						}
						this.fPp2JBUAM9.vMovement = this.transform.forward;
						if (124465 - 156453 != -31988)
						{
							continue;
						}
						this.fPp2JBUAM9.actionState = "standby";
						if (74260 - 587296 == -513035)
						{
							continue;
						}
					}
					this.fPp2JBUAM9.moveSpeed = Mathf.Lerp(this.fPp2JBUAM9.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (97111 - 371653 != -274542)
					{
						continue;
					}
					if (this.fPp2JBUAM9.moveSpeed < 0.1f * this.fPp2JBUAM9.runSpeed)
					{
						if (81468 - 536646 != -455178)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (230560 - 398359 != -167799)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (91299 - 292645 != -201346)
						{
							continue;
						}
						this.fPp2JBUAM9.moveSpeed = (float)0;
						if (282583 - 583901 == -301317)
						{
							continue;
						}
					}
				}
			}
			this.XVL2XgtaSf += mTime;
		}
		while (3804 - 545904 == -542099);
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x0027D600 File Offset: 0x0027B800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (41400 - 332704 != -291304)
		{
		}
		do
		{
			if (Time.time - this.wka2t1Be1m >= this.XVL2XgtaSf)
			{
				if (193499 - 56811 == 136689)
				{
					continue;
				}
				if (Time.time - this.wka2t1Be1m < this.XVL2XgtaSf + mTime)
				{
					if (121697 - 127839 == -6141)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (106664 - 572470 != -465806)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (15081 - 291204 != -276123)
						{
							continue;
						}
						this.wka2t1Be1m -= UnityEngine.Random.Range((float)0, rTimer);
						if (208205 - 171831 != 36374)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection = this.fPp2JBUAM9.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (27590 - 599618 != -572028)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection.y = this.transform.position.y;
						if (157700 - 473505 == -315804)
						{
							continue;
						}
						this.fPp2JBUAM9.vMovement = (this.fPp2JBUAM9.vDirection - this.transform.position).normalized;
						if (183132 - 320754 != -137622)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fPp2JBUAM9.vMovement);
						if (200002 - 58234 == 141769)
						{
							continue;
						}
						this.fPp2JBUAM9.actionState = "run";
						if (8054 - 575474 == -567419)
						{
							continue;
						}
						this.animation.Play("run");
						if (125639 - 353355 == -227715)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (132538 - 395239 == -262700)
						{
							continue;
						}
					}
					this.fPp2JBUAM9.moveSpeed = Mathf.Lerp(this.fPp2JBUAM9.moveSpeed, this.fPp2JBUAM9.runSpeed, (float)4 * Time.deltaTime);
					if (66611 - 306111 == -239499)
					{
						continue;
					}
				}
			}
			this.XVL2XgtaSf += mTime;
		}
		while (65856 - 442311 == -376454);
	}

	// Token: 0x06001848 RID: 6216 RVA: 0x0027D908 File Offset: 0x0027BB08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_path(float mTime, float rTimer)
	{
		if (225016 - 447024 != -222007)
		{
		}
		for (;;)
		{
			if (Game.mGameCode != 925)
			{
				if (118236 - 431548 != -313311)
				{
					break;
				}
			}
			else
			{
				if (Time.time - this.wka2t1Be1m >= this.XVL2XgtaSf)
				{
					if (189069 - 555602 != -366533)
					{
						continue;
					}
					if (Time.time - this.wka2t1Be1m < this.XVL2XgtaSf + mTime)
					{
						if (145623 - 251084 == -105460)
						{
							continue;
						}
						if (!this.zlZ22v0Otp)
						{
							if (42242 - 281316 != -239074)
							{
								continue;
							}
							if (this.vq72Of96Fx < 9)
							{
								if (272080 - 345831 == -73750)
								{
									continue;
								}
								this.vq72Of96Fx++;
								if (36649 - 341635 != -304986)
								{
									continue;
								}
								GameObject exists = GameObject.Find("WayPoint" + this.vq72Of96Fx);
								if (241135 - 530352 == -289216)
								{
									continue;
								}
								if (exists)
								{
									if (259821 - 129545 == 130277)
									{
										continue;
									}
									this.zlZ22v0Otp = exists;
									if (150121 - 551584 != -401463)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find WayPoint" + this.vq72Of96Fx);
									if (42269 - 280684 != -238415)
									{
										continue;
									}
								}
							}
						}
						if (this.zlZ22v0Otp)
						{
							if (17143 - 387782 == -370638)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(this.zlZ22v0Otp.transform.position - this.VGW2IZlJR4.position);
							if (27536 - 72880 != -45344)
							{
								continue;
							}
							float sqrMagnitude = vector.sqrMagnitude;
							if (242355 - 83595 == 158761)
							{
								continue;
							}
							if (sqrMagnitude < (float)4)
							{
								if (73708 - 327091 != -253383)
								{
									continue;
								}
								this.zlZ22v0Otp = null;
								if (184950 - 331497 != -146547)
								{
									continue;
								}
							}
							else
							{
								this.AI_state = "path";
								if (86114 - 180040 == -93925)
								{
									continue;
								}
								this.fPp2JBUAM9.vMovement = vector.normalized;
								if (31380 - 329258 == -297877)
								{
									continue;
								}
								this.VGW2IZlJR4.rotation = Quaternion.LookRotation(this.fPp2JBUAM9.vMovement);
								if (71749 - 73711 == -1961)
								{
									continue;
								}
								this.fPp2JBUAM9.actionState = "run";
								if (167601 - 290732 == -123130)
								{
									continue;
								}
								this.animation.Play("run");
								if (297643 - 211647 != 85996)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (274700 - 595145 == -320444)
								{
									continue;
								}
								this.fPp2JBUAM9.moveSpeed = Mathf.Lerp(this.fPp2JBUAM9.moveSpeed, this.fPp2JBUAM9.runSpeed, (float)4 * Time.deltaTime);
								if (23055 - 416313 != -393258)
								{
									continue;
								}
							}
						}
					}
				}
				this.XVL2XgtaSf += mTime;
				if (199395 - 516458 != -317062)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x0027DD44 File Offset: 0x0027BF44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (87938 - 246976 != -159037)
		{
		}
		do
		{
			if (Time.time - this.wka2t1Be1m >= this.XVL2XgtaSf)
			{
				if (224101 - 390964 != -166863)
				{
					continue;
				}
				if (Time.time - this.wka2t1Be1m < this.XVL2XgtaSf + mTime)
				{
					if (82101 - 87521 != -5420)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (210088 - 332839 != -122751)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (15445 - 329262 == -313816)
						{
							continue;
						}
						this.wka2t1Be1m = Time.time - mTime - this.XVL2XgtaSf;
						if (98309 - 110814 == -12504)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection = Vector3.zero;
						if (259592 - 410538 == -150945)
						{
							continue;
						}
						this.fPp2JBUAM9.vMovement = this.transform.forward;
						if (222765 - 161364 != 61401)
						{
							continue;
						}
						this.fPp2JBUAM9.actionState = "standby";
						if (201843 - 403513 != -201670)
						{
							continue;
						}
						this.fPp2JBUAM9.myAttackTarget = this.fPp2JBUAM9.getHateTarget(5, 50);
						if (9148 - 150331 == -141182)
						{
							continue;
						}
						if (!this.fPp2JBUAM9.myAttackTarget)
						{
							if (130259 - 69751 != 60508)
							{
								continue;
							}
							this.fPp2JBUAM9.isAlert = false;
							if (37871 - 270123 == -232251)
							{
								continue;
							}
							this.wka2t1Be1m = Time.time;
							if (83736 - 556751 == -473014)
							{
								continue;
							}
							this.fPp2JBUAM9.myAttackTarget = null;
							if (152896 - 242278 != -89382)
							{
								continue;
							}
							this.fPp2JBUAM9.mOriginalPosition = this.transform.position;
							if (72960 - 283728 != -210768)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.fPp2JBUAM9.myAttackTarget;
							if (273698 - 463413 != -189715)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (221441 - 89735 != 131706)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (131123 - 240820 == -109696)
								{
									continue;
								}
								this.fPp2JBUAM9.isAlert = false;
								if (154934 - 469780 == -314845)
								{
									continue;
								}
								this.wka2t1Be1m = Time.time;
								if (174681 - 446668 != -271987)
								{
									continue;
								}
								this.fPp2JBUAM9.myAttackTarget = null;
								if (131448 - 359695 != -228247)
								{
									continue;
								}
							}
							else
							{
								this.fPp2JBUAM9.vDirection = myAttackTarget.transform.position;
								if (92359 - 238670 != -146311)
								{
									continue;
								}
								this.fPp2JBUAM9.vDirection.y = this.transform.position.y;
								if (6044 - 469122 == -463077)
								{
									continue;
								}
								this.fPp2JBUAM9.vMovement = (this.fPp2JBUAM9.vDirection - this.transform.position).normalized;
								if (129978 - 94115 == 35864)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.fPp2JBUAM9.vMovement);
								if (16828 - 114575 != -97747)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.XVL2XgtaSf += mTime;
		}
		while (90271 - 379165 == -288893);
	}

	// Token: 0x0600184A RID: 6218 RVA: 0x0027E1F4 File Offset: 0x0027C3F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (227836 - 123926 != 103910)
		{
		}
		do
		{
			if (Time.time - this.wka2t1Be1m >= this.XVL2XgtaSf)
			{
				if (143459 - 538510 != -395051)
				{
					continue;
				}
				if (Time.time - this.wka2t1Be1m < this.XVL2XgtaSf + mTime)
				{
					if (127991 - 182900 != -54909)
					{
						continue;
					}
					if (!this.fPp2JBUAM9.myAttackTarget)
					{
						if (219354 - 55096 != 164258)
						{
							continue;
						}
						this.wka2t1Be1m = Time.time - mTime - this.XVL2XgtaSf;
						if (54849 - 532795 != -477945)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.fPp2JBUAM9.myAttackTarget;
						if (141013 - 90693 != 50320)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (256554 - 9460 == 247095)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (28982 - 398425 != -369443)
						{
							continue;
						}
						int tID = 0;
						if (40382 - 527507 != -487125)
						{
							continue;
						}
						if (characterControl)
						{
							if (149721 - 563432 != -413711)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (20034 - 279337 != -259303)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (86358 - 369142 != -282784)
						{
							continue;
						}
						if (num <= (float)6)
						{
							if (123497 - 397734 != -274237)
							{
								continue;
							}
							if (this.fPp2JBUAM9.isTimeOut("nAttack") == (float)0)
							{
								if (124214 - 50933 == 73282)
								{
									continue;
								}
								this.wka2t1Be1m = Time.time - mTime - this.XVL2XgtaSf;
								if (285879 - 255824 == 30056)
								{
									continue;
								}
								int num2 = UnityEngine.Random.Range(0, 2);
								if (207552 - 506351 != -298799)
								{
									continue;
								}
								if (num2 == 0)
								{
									if (205234 - 595235 != -390001)
									{
										continue;
									}
									this.WeZ26Lbceb.StartCoroutine_Auto(this.WeZ26Lbceb.RPC_nAttack1(this.transform.position, vector, 0));
									if (278724 - 194119 == 84606)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (61099 - 65467 == -4367)
										{
											continue;
										}
										this.WeZ26Lbceb.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
										if (71786 - 42472 != 29314)
										{
											continue;
										}
									}
								}
								else if (num2 == 1)
								{
									if (118962 - 201757 == -82794)
									{
										continue;
									}
									this.WeZ26Lbceb.StartCoroutine_Auto(this.WeZ26Lbceb.RPC_nAttack2(this.transform.position, vector, 0));
									if (35745 - 236345 != -200600)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (101688 - 182314 != -80626)
										{
											continue;
										}
										this.WeZ26Lbceb.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
										if (155114 - 533278 != -378164)
										{
											continue;
										}
									}
								}
								goto IL_3CC;
							}
						}
						if (num >= (float)12)
						{
							if (124200 - 16046 != 108154)
							{
								continue;
							}
							if (this.fPp2JBUAM9.isTimeOut("groundStrike") == (float)0)
							{
								if (254267 - 260606 != -6339)
								{
									continue;
								}
								this.wka2t1Be1m = Time.time - mTime - this.XVL2XgtaSf;
								if (46474 - 121087 != -74613)
								{
									continue;
								}
								this.WeZ26Lbceb.StartCoroutine_Auto(this.WeZ26Lbceb.RPC_groundStrike(this.transform.position, vector, tID));
								if (161744 - 546730 != -384986)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (152290 - 92321 != 59969)
									{
										continue;
									}
									this.WeZ26Lbceb.ActionEvent("RPC_groundStrike", this.transform.position, vector, tID);
									if (194832 - 312442 != -117610)
									{
										continue;
									}
								}
								goto IL_3CC;
							}
						}
						if (num <= (float)30)
						{
							if (45718 - 335811 != -290093)
							{
								continue;
							}
							if (this.fPp2JBUAM9.sp >= 75)
							{
								if (121735 - 213030 == -91294)
								{
									continue;
								}
								if (this.fPp2JBUAM9.isTimeOut("titanQuake") == (float)0)
								{
									if (262253 - 425127 != -162874)
									{
										continue;
									}
									this.wka2t1Be1m = Time.time - mTime - this.XVL2XgtaSf;
									if (56132 - 378175 != -322043)
									{
										continue;
									}
									this.WeZ26Lbceb.StartCoroutine_Auto(this.WeZ26Lbceb.RPC_titanQuake(this.transform.position, vector, 0));
									if (212061 - 395247 != -183185)
									{
										if (PhotonClient.IsInitialized())
										{
											if (267892 - 588206 != -320314)
											{
												continue;
											}
											this.WeZ26Lbceb.ActionEvent("RPC_titanQuake", this.transform.position, vector, 0);
											if (249887 - 527724 == -277836)
											{
												continue;
											}
										}
										goto IL_3CC;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (282232 - 452652 != -170420)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection = myAttackTarget.transform.position;
						if (131334 - 125580 == 5755)
						{
							continue;
						}
						this.fPp2JBUAM9.vDirection.y = this.transform.position.y;
						if (100332 - 427803 != -327471)
						{
							continue;
						}
						this.fPp2JBUAM9.vMovement = (this.fPp2JBUAM9.vDirection - this.transform.position).normalized;
						if (23342 - 396434 == -373091)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.fPp2JBUAM9.vMovement);
						if (205692 - 538787 == -333094)
						{
							continue;
						}
						this.fPp2JBUAM9.actionState = "run";
						if (244470 - 181658 == 62813)
						{
							continue;
						}
						this.animation.Play("run");
						if (81855 - 297432 != -215577)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (234261 - 186080 == 48182)
						{
							continue;
						}
						this.fPp2JBUAM9.moveSpeed = Mathf.Lerp(this.fPp2JBUAM9.moveSpeed, this.fPp2JBUAM9.runSpeed, (float)4 * Time.deltaTime);
						if (39316 - 516875 == -477558)
						{
							continue;
						}
					}
				}
			}
			IL_3CC:
			this.XVL2XgtaSf += mTime;
		}
		while (231679 - 307869 != -76190);
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x0027EAB4 File Offset: 0x0027CCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (192419 - 582115 != -389695)
		{
		}
		while (Time.time - this.wka2t1Be1m > this.XVL2XgtaSf)
		{
			if (186230 - 407650 == -221420)
			{
				this.AI_state = "none";
				if (126849 - 389978 == -263129)
				{
					this.wka2t1Be1m = Time.time;
					if (186871 - 11472 != 175400)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x0027EB68 File Offset: 0x0027CD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (108071 - 462578 != -354506)
		{
		}
		for (;;)
		{
			IL_201:
			if (this.OuB2vqyppb > Time.time)
			{
				if (9136 - 371455 == -362319)
				{
					break;
				}
			}
			else
			{
				this.OuB2vqyppb = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (128255 - 124661 == 3594)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (263254 - 5266 != 257989)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (161942 - 181145 == -19203)
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
								if (24318 - 60856 != -36538)
								{
									goto IL_201;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (147389 - 252354 == -104964)
								{
									goto IL_201;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (76643 - 45913 != 30730)
								{
									goto IL_201;
								}
								bool flag = true;
								if (193425 - 493745 == -300319)
								{
									goto IL_201;
								}
								eRace race = characterControl.Race;
								if (101057 - 318014 == -216956)
								{
									goto IL_201;
								}
								if (race == eRace.Plants)
								{
									if (228860 - 279767 == -50906)
									{
										goto IL_201;
									}
									flag = false;
									if (243665 - 202014 != 41651)
									{
										goto IL_201;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (186611 - 143980 != 42631)
									{
										goto IL_201;
									}
									flag = false;
									if (159222 - 577196 != -417974)
									{
										goto IL_201;
									}
								}
								else if (race == eRace.Tails)
								{
									if (161352 - 586776 != -425424)
									{
										goto IL_201;
									}
									flag = false;
									if (4352 - 574952 == -570599)
									{
										goto IL_201;
									}
								}
								else if (race == eRace.Robots)
								{
									if (53974 - 363952 != -309978)
									{
										goto IL_201;
									}
									flag = true;
									if (173874 - 478628 != -304754)
									{
										goto IL_201;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (118780 - 27344 == 91437)
									{
										goto IL_201;
									}
									flag = false;
									if (123796 - 553729 == -429932)
									{
										goto IL_201;
									}
								}
								else if (race == eRace.Structure)
								{
									if (220468 - 477478 != -257010)
									{
										goto IL_201;
									}
									flag = false;
									if (193423 - 52596 == 140828)
									{
										goto IL_201;
									}
								}
								if (flag)
								{
									if (249145 - 71218 == 177928)
									{
										goto IL_201;
									}
									if (characterControl.hp > 0)
									{
										if (296826 - 591121 != -294295)
										{
											goto IL_201;
										}
										if (characterControl.recieveTarget)
										{
											if (136925 - 522524 != -385599)
											{
												goto IL_201;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (134609 - 435294 != -300685)
												{
													goto IL_201;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (264998 - 299862 != -34864)
													{
														goto IL_201;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (20117 - 595941 == -575823)
													{
														goto IL_201;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (231721 - 303543 == -71821)
														{
															goto IL_201;
														}
														this.fPp2JBUAM9.myAttackTarget = gameObject;
														if (205438 - 319219 == -113780)
														{
															goto IL_201;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (228146 - 57424 == 170723)
														{
															goto IL_201;
														}
														this.fPp2JBUAM9.addHate(characterControl.ActorNr, 5);
														if (4996 - 442900 == -437903)
														{
															goto IL_201;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (186048 - 303285 != -117237)
														{
															goto IL_201;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (180544 - 46438 != 134106)
														{
															goto IL_201;
														}
														if (num < (float)60)
														{
															if (112392 - 167014 != -54622)
															{
																goto IL_201;
															}
															if (characterControl.hp > 0)
															{
																if (288891 - 557071 != -268180)
																{
																	goto IL_201;
																}
																this.fPp2JBUAM9.myAttackTarget = gameObject;
																if (214693 - 252895 != -38202)
																{
																	goto IL_201;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (149900 - 257263 != -107363)
																{
																	goto IL_201;
																}
																this.fPp2JBUAM9.addHate(characterControl.ActorNr, 5);
																if (94524 - 294743 == -200218)
																{
																	goto IL_201;
																}
															}
														}
													}
													if (this.fPp2JBUAM9.myAttackTarget)
													{
														if (225799 - 510340 == -284540)
														{
															goto IL_201;
														}
														this.fPp2JBUAM9.isAlert = true;
														if (80188 - 568244 != -488056)
														{
															goto IL_201;
														}
														this.wka2t1Be1m = Time.time;
														if (166342 - 386482 != -220140)
														{
															goto IL_201;
														}
													}
												}
											}
										}
									}
								}
							}
							if (146278 - 228532 == -82254)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x0027F230 File Offset: 0x0027D430
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x0027F234 File Offset: 0x0027D434
	internal static bool dm6GrRgn6wudOAC3w5D()
	{
		return true;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x0027F238 File Offset: 0x0027D438
	internal static bool Vu6DEXg6ICvr6M93JxA()
	{
		return false;
	}

	// Token: 0x040014E7 RID: 5351
	private Transform VGW2IZlJR4;

	// Token: 0x040014E8 RID: 5352
	private CharacterControl fPp2JBUAM9;

	// Token: 0x040014E9 RID: 5353
	private EarthGod WeZ26Lbceb;

	// Token: 0x040014EA RID: 5354
	public string AI_state;

	// Token: 0x040014EB RID: 5355
	private float wka2t1Be1m;

	// Token: 0x040014EC RID: 5356
	private float XVL2XgtaSf;

	// Token: 0x040014ED RID: 5357
	private int vq72Of96Fx;

	// Token: 0x040014EE RID: 5358
	private GameObject zlZ22v0Otp;

	// Token: 0x040014EF RID: 5359
	private float OuB2vqyppb;
}
