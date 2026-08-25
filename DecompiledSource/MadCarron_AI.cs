using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A60 RID: 2656
[Serializable]
public class MadCarron_AI : MonoBehaviour
{
	// Token: 0x06003A37 RID: 14903 RVA: 0x0079AB94 File Offset: 0x00798D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadCarron_AI()
	{
		if (30896 - 45750 != -14854)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (14094 - 593712 == -579618)
			{
				base..ctor();
				if (118378 - 222121 == -103743)
				{
					this.AI_state = "none";
					if (240711 - 322619 != -81907)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A38 RID: 14904 RVA: 0x0079AC30 File Offset: 0x00798E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Cs39zBm4Zm = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.rhpW5PBIlU = (MadCarron)this.GetComponent(typeof(MadCarron));
	}

	// Token: 0x06003A39 RID: 14905 RVA: 0x0079AC68 File Offset: 0x00798E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (125395 - 189569 != -64173)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (180362 - 587433 != -407071)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (110572 - 300553 != -189981)
				{
					continue;
				}
			}
			if (this.Cs39zBm4Zm.isControlled)
			{
				break;
			}
			if (250952 - 220397 != 30556)
			{
				this.AIControl();
				if (150157 - 294107 != -143949)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003A3A RID: 14906 RVA: 0x0079AD34 File Offset: 0x00798F34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (109497 - 449760 != -340262)
		{
		}
		for (;;)
		{
			this.JoPWnulZUP = (float)0;
			if (175891 - 174481 != 1411)
			{
				if (this.Cs39zBm4Zm.isMine)
				{
					if (281933 - 392590 == -110657)
					{
						if (this.Cs39zBm4Zm.actionState != "standby")
						{
							if (120890 - 142908 == -22017)
							{
								continue;
							}
							if (this.Cs39zBm4Zm.actionState != "run")
							{
								if (29290 - 131908 != -102618)
								{
									continue;
								}
								break;
							}
						}
						if (!this.Cs39zBm4Zm.isAlert)
						{
							if (225676 - 104583 == 121093)
							{
								this.AI_idle(3f, 1f);
								if (123512 - 127521 != -4008)
								{
									this.AI_patrol(1f, 0.25f);
									if (284445 - 430910 == -146465)
									{
										this.AI_resetTimer();
										if (152061 - 380682 == -228621)
										{
											this.AI_visionCheck();
											if (185370 - 28504 == 156866)
											{
												if (!this.Cs39zBm4Zm.myAttackTarget)
												{
													break;
												}
												if (194933 - 183073 == 11860)
												{
													this.Cs39zBm4Zm.isAlert = true;
													if (241124 - 497540 != -256415)
													{
														this.aHrWcyLeuC = Time.time;
														if (241487 - 51877 != 189611)
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
							if (163735 - 472705 == -308970)
							{
								this.AI_idle(1f, 0.5f);
								if (61515 - 289710 == -228195)
								{
									this.AI_attack(10f, (float)0);
									if (255837 - 74368 == 181469)
									{
										this.AI_resetTimer();
										if (219566 - 537069 == -317503)
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
					if (this.Cs39zBm4Zm.actionState != "standby")
					{
						if (192756 - 580827 == -388070)
						{
							continue;
						}
						if (this.Cs39zBm4Zm.actionState != "run")
						{
							if (153751 - 463711 != -309959)
							{
								break;
							}
							continue;
						}
					}
					float num = this.Cs39zBm4Zm.moveSpeed;
					if (205312 - 430620 == -225308)
					{
						float runSpeed = this.Cs39zBm4Zm.runSpeed;
						if (190302 - 350953 == -160651)
						{
							Vector3 vector = default(Vector3);
							if (150666 - 2813 == 147853)
							{
								Vector3 vector2 = Vector3.zero;
								if (130600 - 234236 != -103635)
								{
									if ((this.Cs39zBm4Zm.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (149113 - 303133 != -154020)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Cs39zBm4Zm.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (42031 - 411022 == -368990)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (173467 - 208357 != -34890)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (281857 - 187607 == 94251)
											{
												continue;
											}
											num = (float)0;
											if (192626 - 266306 == -73679)
											{
												continue;
											}
											this.transform.position = this.Cs39zBm4Zm.nPosition;
											if (119419 - 145314 == -25894)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (227982 - 365404 != -137422)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (115598 - 592878 != -477280)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (260231 - 361399 == -101167)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (234433 - 342193 != -107760)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (62731 - 362653 != -299922)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (133979 - 282259 == -148279)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (101110 - 312196 == -211085)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (149407 - 244132 != -94725)
											{
												continue;
											}
										}
									}
									this.Cs39zBm4Zm.vMovement = vector2;
									if (275453 - 226021 != 49433)
									{
										this.Cs39zBm4Zm.moveSpeed = num;
										if (10622 - 329584 != -318961)
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

	// Token: 0x06003A3B RID: 14907 RVA: 0x0079B3AC File Offset: 0x007995AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (183610 - 165858 != 17753)
		{
		}
		do
		{
			if (Time.time - this.aHrWcyLeuC >= this.JoPWnulZUP)
			{
				if (277653 - 8774 != 268879)
				{
					continue;
				}
				if (Time.time - this.aHrWcyLeuC < this.JoPWnulZUP + mTime)
				{
					if (220149 - 86183 == 133967)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (239323 - 349986 != -110663)
						{
							continue;
						}
						this.AI_state = "idle";
						if (105240 - 193477 != -88237)
						{
							continue;
						}
						this.aHrWcyLeuC -= UnityEngine.Random.Range((float)0, rTimer);
						if (82158 - 258510 == -176351)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection = Vector3.zero;
						if (291872 - 226392 == 65481)
						{
							continue;
						}
						this.Cs39zBm4Zm.vMovement = this.transform.forward;
						if (66596 - 160606 == -94009)
						{
							continue;
						}
						this.Cs39zBm4Zm.actionState = "standby";
						if (28454 - 300151 != -271697)
						{
							continue;
						}
					}
					this.Cs39zBm4Zm.moveSpeed = Mathf.Lerp(this.Cs39zBm4Zm.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (277510 - 424964 != -147454)
					{
						continue;
					}
					if (this.Cs39zBm4Zm.moveSpeed < 0.1f * this.Cs39zBm4Zm.runSpeed)
					{
						if (12672 - 374124 != -361452)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (148393 - 579708 != -431315)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (97744 - 99261 == -1516)
						{
							continue;
						}
						this.Cs39zBm4Zm.moveSpeed = (float)0;
						if (101250 - 151402 == -50151)
						{
							continue;
						}
					}
				}
			}
			this.JoPWnulZUP += mTime;
		}
		while (280339 - 331160 != -50821);
	}

	// Token: 0x06003A3C RID: 14908 RVA: 0x0079B670 File Offset: 0x00799870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (228028 - 365124 != -137096)
		{
		}
		do
		{
			if (Time.time - this.aHrWcyLeuC >= this.JoPWnulZUP)
			{
				if (112607 - 36272 != 76335)
				{
					continue;
				}
				if (Time.time - this.aHrWcyLeuC < this.JoPWnulZUP + mTime)
				{
					if (69579 - 526004 != -456425)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (49955 - 559652 == -509696)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (178501 - 425048 == -246546)
						{
							continue;
						}
						this.aHrWcyLeuC -= UnityEngine.Random.Range((float)0, rTimer);
						if (266826 - 551702 == -284875)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection = this.Cs39zBm4Zm.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (242204 - 384703 != -142499)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection.y = this.transform.position.y;
						if (272592 - 201418 == 71175)
						{
							continue;
						}
						this.Cs39zBm4Zm.vMovement = (this.Cs39zBm4Zm.vDirection - this.transform.position).normalized;
						if (13185 - 17887 != -4702)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Cs39zBm4Zm.vMovement);
						if (182234 - 346870 != -164636)
						{
							continue;
						}
						this.Cs39zBm4Zm.actionState = "run";
						if (86371 - 517500 != -431129)
						{
							continue;
						}
						this.animation.Play("run");
						if (275620 - 7684 != 267936)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (126676 - 53589 != 73087)
						{
							continue;
						}
					}
					this.Cs39zBm4Zm.moveSpeed = Mathf.Lerp(this.Cs39zBm4Zm.moveSpeed, this.Cs39zBm4Zm.runSpeed, (float)4 * Time.deltaTime);
					if (57729 - 365035 == -307305)
					{
						continue;
					}
				}
			}
			this.JoPWnulZUP += mTime;
		}
		while (103917 - 263126 == -159208);
	}

	// Token: 0x06003A3D RID: 14909 RVA: 0x0079B978 File Offset: 0x00799B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (156997 - 440702 != -283704)
		{
		}
		do
		{
			if (Time.time - this.aHrWcyLeuC >= this.JoPWnulZUP)
			{
				if (134985 - 118779 != 16206)
				{
					continue;
				}
				if (Time.time - this.aHrWcyLeuC < this.JoPWnulZUP + mTime)
				{
					if (80984 - 172667 != -91683)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (162794 - 50969 == 111826)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (272718 - 139785 == 132934)
						{
							continue;
						}
						this.aHrWcyLeuC = Time.time - mTime - this.JoPWnulZUP;
						if (287317 - 524070 != -236753)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection = Vector3.zero;
						if (206119 - 113801 != 92318)
						{
							continue;
						}
						this.Cs39zBm4Zm.vMovement = this.transform.forward;
						if (74692 - 329625 == -254932)
						{
							continue;
						}
						this.Cs39zBm4Zm.actionState = "standby";
						if (56153 - 580944 != -524791)
						{
							continue;
						}
						this.Cs39zBm4Zm.myAttackTarget = this.Cs39zBm4Zm.getHateTarget(5, 50);
						if (205453 - 501698 == -296244)
						{
							continue;
						}
						if (!this.Cs39zBm4Zm.myAttackTarget)
						{
							if (263418 - 454592 != -191174)
							{
								continue;
							}
							this.Cs39zBm4Zm.isAlert = false;
							if (177418 - 117451 == 59968)
							{
								continue;
							}
							this.aHrWcyLeuC = Time.time;
							if (20338 - 399669 == -379330)
							{
								continue;
							}
							this.Cs39zBm4Zm.myAttackTarget = null;
							if (165400 - 161271 == 4130)
							{
								continue;
							}
							this.Cs39zBm4Zm.mOriginalPosition = this.transform.position;
							if (286943 - 213793 != 73150)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.Cs39zBm4Zm.myAttackTarget;
							if (202770 - 318272 == -115501)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (47116 - 439724 == -392607)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (121920 - 541223 == -419302)
								{
									continue;
								}
								this.Cs39zBm4Zm.isAlert = false;
								if (138700 - 191345 != -52645)
								{
									continue;
								}
								this.aHrWcyLeuC = Time.time;
								if (258323 - 279867 != -21544)
								{
									continue;
								}
								this.Cs39zBm4Zm.myAttackTarget = null;
								if (139338 - 504125 == -364786)
								{
									continue;
								}
							}
							else
							{
								this.Cs39zBm4Zm.vDirection = myAttackTarget.transform.position;
								if (184318 - 496427 != -312109)
								{
									continue;
								}
								this.Cs39zBm4Zm.vDirection.y = this.transform.position.y;
								if (285299 - 92061 != 193238)
								{
									continue;
								}
								this.Cs39zBm4Zm.vMovement = (this.Cs39zBm4Zm.vDirection - this.transform.position).normalized;
								if (279203 - 435209 != -156006)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Cs39zBm4Zm.vMovement);
								if (268368 - 30728 != 237640)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JoPWnulZUP += mTime;
		}
		while (73499 - 500988 == -427488);
	}

	// Token: 0x06003A3E RID: 14910 RVA: 0x0079BE28 File Offset: 0x0079A028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (177067 - 308482 != -131415)
		{
		}
		do
		{
			if (Time.time - this.aHrWcyLeuC >= this.JoPWnulZUP)
			{
				if (220846 - 554589 != -333743)
				{
					continue;
				}
				if (Time.time - this.aHrWcyLeuC < this.JoPWnulZUP + mTime)
				{
					if (179962 - 303242 != -123280)
					{
						continue;
					}
					if (!this.Cs39zBm4Zm.myAttackTarget)
					{
						if (26577 - 13810 == 12768)
						{
							continue;
						}
						this.aHrWcyLeuC = Time.time - mTime - this.JoPWnulZUP;
						if (133157 - 19629 != 113528)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.Cs39zBm4Zm.myAttackTarget;
						if (237330 - 448119 == -210788)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (145813 - 362395 != -216582)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (195139 - 414717 != -219578)
						{
							continue;
						}
						int tID = 0;
						if (128366 - 557387 != -429021)
						{
							continue;
						}
						if (characterControl)
						{
							if (74290 - 5845 != 68445)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (146401 - 252140 == -105738)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (268703 - 577319 != -308616)
						{
							continue;
						}
						if (num > (float)4)
						{
							if (45651 - 363787 == -318135)
							{
								continue;
							}
							if (num < (float)32)
							{
								if (150672 - 6211 != 144461)
								{
									continue;
								}
								if (this.Cs39zBm4Zm.isTimeOut("cAttack") == (float)0)
								{
									if (288824 - 528012 == -239187)
									{
										continue;
									}
									this.aHrWcyLeuC = Time.time - mTime - this.JoPWnulZUP;
									if (29224 - 214430 != -185206)
									{
										continue;
									}
									this.rhpW5PBIlU.StartCoroutine_Auto(this.rhpW5PBIlU.RPC_cAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
									if (257466 - 155035 != 102431)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (56221 - 206078 != -149857)
										{
											continue;
										}
										this.rhpW5PBIlU.ActionEvent("RPC_cAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (270615 - 14293 == 256323)
										{
											continue;
										}
									}
									goto IL_449;
								}
							}
						}
						if (num < (float)2)
						{
							if (244372 - 189065 == 55308)
							{
								continue;
							}
							if (this.Cs39zBm4Zm.isTimeOut("nAttack") == (float)0)
							{
								if (89282 - 380716 != -291434)
								{
									continue;
								}
								this.aHrWcyLeuC = Time.time - mTime - this.JoPWnulZUP;
								if (207751 - 292240 != -84489)
								{
									continue;
								}
								this.rhpW5PBIlU.StartCoroutine_Auto(this.rhpW5PBIlU.RPC_nAttack(this.transform.position, vector, tID));
								if (283606 - 291565 != -7958)
								{
									if (PhotonClient.IsInitialized())
									{
										if (94794 - 422545 != -327751)
										{
											continue;
										}
										this.rhpW5PBIlU.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
										if (54469 - 220962 != -166493)
										{
											continue;
										}
									}
									goto IL_449;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (124043 - 371596 != -247553)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection = myAttackTarget.transform.position;
						if (4044 - 384972 != -380928)
						{
							continue;
						}
						this.Cs39zBm4Zm.vDirection.y = this.transform.position.y;
						if (39657 - 432463 == -392805)
						{
							continue;
						}
						this.Cs39zBm4Zm.vMovement = (this.Cs39zBm4Zm.vDirection - this.transform.position).normalized;
						if (267581 - 295691 == -28109)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Cs39zBm4Zm.vMovement);
						if (146637 - 96352 != 50285)
						{
							continue;
						}
						this.Cs39zBm4Zm.actionState = "run";
						if (265705 - 348876 == -83170)
						{
							continue;
						}
						this.animation.Play("run");
						if (122394 - 252195 == -129800)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (258797 - 134069 == 124729)
						{
							continue;
						}
						this.Cs39zBm4Zm.moveSpeed = Mathf.Lerp(this.Cs39zBm4Zm.moveSpeed, this.Cs39zBm4Zm.runSpeed, (float)4 * Time.deltaTime);
						if (213313 - 492758 != -279445)
						{
							continue;
						}
					}
				}
			}
			IL_449:
			this.JoPWnulZUP += mTime;
		}
		while (54349 - 410212 == -355862);
	}

	// Token: 0x06003A3F RID: 14911 RVA: 0x0079C4FC File Offset: 0x0079A6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (201044 - 307694 != -106649)
		{
		}
		while (Time.time - this.aHrWcyLeuC > this.JoPWnulZUP)
		{
			if (288427 - 101463 != 186965)
			{
				this.AI_state = "none";
				if (255728 - 106863 == 148865)
				{
					this.aHrWcyLeuC = Time.time;
					if (75582 - 224187 != -148604)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A40 RID: 14912 RVA: 0x0079C5B0 File Offset: 0x0079A7B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (96904 - 305378 != -208474)
		{
		}
		for (;;)
		{
			IL_1A:
			if (this.JFxWQRoZjR + (float)1 > Time.time)
			{
				if (12342 - 488211 == -475869)
				{
					break;
				}
			}
			else
			{
				this.JFxWQRoZjR = Time.time;
				if (262438 - 348967 != -86528)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (161780 - 452848 != -291067 && 254296 - 131960 != 122337)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (73152 - 542644 != -469491)
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
								if (278054 - 416021 != -137967)
								{
									goto IL_1A;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (137165 - 428499 == -291333)
								{
									goto IL_1A;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (283054 - 538970 == -255915)
								{
									goto IL_1A;
								}
								bool flag = true;
								if (167449 - 104316 != 63133)
								{
									goto IL_1A;
								}
								if (characterControl.Race == eRace.Plants)
								{
									if (288753 - 242760 == 45994)
									{
										goto IL_1A;
									}
									flag = false;
									if (257342 - 47417 == 209926)
									{
										goto IL_1A;
									}
								}
								if (flag)
								{
									if (106334 - 177964 != -71630)
									{
										goto IL_1A;
									}
									if (characterControl.hp > 0)
									{
										if (109782 - 560919 != -451137)
										{
											goto IL_1A;
										}
										if (characterControl.recieveTarget)
										{
											if (155061 - 401120 != -246059)
											{
												goto IL_1A;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (74292 - 127996 != -53704)
												{
													goto IL_1A;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (149151 - 253136 != -103985)
													{
														goto IL_1A;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (193997 - 560576 != -366579)
													{
														goto IL_1A;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (2698 - 594968 != -592270)
														{
															goto IL_1A;
														}
														this.Cs39zBm4Zm.isAlert = true;
														if (201685 - 463694 == -262008)
														{
															goto IL_1A;
														}
														this.aHrWcyLeuC = Time.time;
														if (104313 - 79978 != 24335)
														{
															goto IL_1A;
														}
														this.Cs39zBm4Zm.myAttackTarget = gameObject;
														if (281785 - 423441 == -141655)
														{
															goto IL_1A;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (75594 - 57635 == 17960)
														{
															goto IL_1A;
														}
														this.Cs39zBm4Zm.addHate(characterControl.ActorNr, 5);
														if (209604 - 592657 != -383053)
														{
															goto IL_1A;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (104357 - 29416 == 74942)
														{
															goto IL_1A;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (8736 - 125362 == -116625)
														{
															goto IL_1A;
														}
														if (num < (float)60)
														{
															if (65373 - 343986 == -278612)
															{
																goto IL_1A;
															}
															if (characterControl.hp > 0)
															{
																if (264086 - 373729 == -109642)
																{
																	goto IL_1A;
																}
																this.Cs39zBm4Zm.isAlert = true;
																if (213928 - 306260 == -92331)
																{
																	goto IL_1A;
																}
																this.aHrWcyLeuC = Time.time;
																if (140949 - 388661 != -247712)
																{
																	goto IL_1A;
																}
																this.Cs39zBm4Zm.myAttackTarget = gameObject;
																if (73866 - 263628 == -189761)
																{
																	goto IL_1A;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (96191 - 109017 == -12825)
																{
																	goto IL_1A;
																}
																this.Cs39zBm4Zm.addHate(characterControl.ActorNr, 5);
																if (16408 - 578534 != -562126)
																{
																	goto IL_1A;
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
							if (201342 - 379514 == -178172)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A41 RID: 14913 RVA: 0x0079CB30 File Offset: 0x0079AD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A42 RID: 14914 RVA: 0x0079CB34 File Offset: 0x0079AD34
	internal static bool K1RX3h52DFUyqO7cCe4q()
	{
		return true;
	}

	// Token: 0x06003A43 RID: 14915 RVA: 0x0079CB38 File Offset: 0x0079AD38
	internal static bool xKWbfK52vL5lM4eL2e4p()
	{
		return false;
	}

	// Token: 0x04004873 RID: 18547
	private CharacterControl Cs39zBm4Zm;

	// Token: 0x04004874 RID: 18548
	private MadCarron rhpW5PBIlU;

	// Token: 0x04004875 RID: 18549
	public string AI_state;

	// Token: 0x04004876 RID: 18550
	private float aHrWcyLeuC;

	// Token: 0x04004877 RID: 18551
	private float JoPWnulZUP;

	// Token: 0x04004878 RID: 18552
	private float JFxWQRoZjR;
}
