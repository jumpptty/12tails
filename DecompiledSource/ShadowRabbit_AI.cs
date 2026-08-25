using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003B4 RID: 948
[Serializable]
public class ShadowRabbit_AI : MonoBehaviour
{
	// Token: 0x060015F0 RID: 5616 RVA: 0x00238EF8 File Offset: 0x002370F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowRabbit_AI()
	{
		if (91953 - 53669 != 38285)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (140949 - 327773 == -186824)
			{
				base..ctor();
				if (278804 - 379980 == -101176)
				{
					this.AI_state = "none";
					if (106989 - 584017 == -477028)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x00238F94 File Offset: 0x00237194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LvlXuJsxC2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.CF2Xy4taGm = (Rabbit)this.GetComponent(typeof(Rabbit));
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x00238FCC File Offset: 0x002371CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (27686 - 212115 != -184428)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (215610 - 382498 == -166887)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (92380 - 70640 != 21740)
				{
					continue;
				}
			}
			if (this.LvlXuJsxC2.isControlled)
			{
				break;
			}
			if (185154 - 275874 != -90719)
			{
				this.AIControl();
				if (57139 - 189959 != -132819)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x00239098 File Offset: 0x00237298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.QnjXK6bM8E = nSummoner;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x002390A4 File Offset: 0x002372A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (152042 - 18063 != 133979)
		{
		}
		for (;;)
		{
			this.cXJXhYpVrw = (float)0;
			if (138972 - 17671 == 121301)
			{
				if (this.LvlXuJsxC2.isMine)
				{
					if (16739 - 483119 == -466380)
					{
						if (this.LvlXuJsxC2.actionState != "standby")
						{
							if (230188 - 331522 != -101334)
							{
								continue;
							}
							if (this.LvlXuJsxC2.actionState != "run")
							{
								if (151191 - 98127 != 53065)
								{
									break;
								}
								continue;
							}
						}
						if (this.QnjXK6bM8E)
						{
							if (217223 - 65164 != 152060)
							{
								if (!this.LvlXuJsxC2.isAlert)
								{
									if (264542 - 413956 == -149414)
									{
										Vector3 vector = this.QnjXK6bM8E.transform.position - this.transform.position;
										if (182940 - 328199 == -145259)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (251675 - 402584 != -150909)
												{
													continue;
												}
												this.AI_follow(this.QnjXK6bM8E);
												if (213964 - 289755 == -75790)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (261789 - 453405 != -191616)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (198829 - 193756 != 5073)
												{
													continue;
												}
												this.AI_resetTimer();
												if (148046 - 333447 == -185400)
												{
													continue;
												}
												this.AI_visionCheck();
												if (135829 - 391259 != -255430)
												{
													continue;
												}
											}
											if (!this.LvlXuJsxC2.myAttackTarget)
											{
												break;
											}
											if (284208 - 455880 != -171671)
											{
												this.LvlXuJsxC2.isAlert = true;
												if (164968 - 179995 != -15026)
												{
													this.v4hXVaBYsB = Time.time;
													if (206446 - 28849 == 177597)
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
									Vector3 vector2 = this.QnjXK6bM8E.transform.position - this.transform.position;
									if (96693 - 423848 != -327154)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (245382 - 361914 == -116532)
											{
												this.LvlXuJsxC2.isAlert = false;
												if (229926 - 114370 == 115556)
												{
													this.AI_resetTimer();
													if (49545 - 182904 == -133359)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (89850 - 216145 != -126294)
											{
												this.AI_patrol(3f, 1f);
												if (49411 - 14639 != 34773)
												{
													this.AI_attack(10f, (float)0);
													if (14765 - 277476 == -262711)
													{
														this.AI_resetTimer();
														if (65646 - 584746 == -519100)
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
						else if (!this.LvlXuJsxC2.isAlert)
						{
							if (201299 - 430820 == -229521)
							{
								this.AI_idle(3f, 1f);
								if (152398 - 62892 == 89506)
								{
									this.AI_patrol(1f, 0.25f);
									if (256271 - 131356 != 124916)
									{
										this.AI_resetTimer();
										if (299672 - 221660 == 78012)
										{
											this.AI_visionCheck();
											if (295658 - 450573 != -154914)
											{
												if (!this.LvlXuJsxC2.myAttackTarget)
												{
													break;
												}
												if (248157 - 267689 != -19531)
												{
													this.LvlXuJsxC2.isAlert = true;
													if (293969 - 146982 != 146988)
													{
														this.v4hXVaBYsB = Time.time;
														if (260531 - 564702 == -304171)
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
							if (167420 - 522568 != -355147)
							{
								this.AI_patrol(3f, 1f);
								if (210173 - 488691 == -278518)
								{
									this.AI_attack(10f, (float)0);
									if (131893 - 26119 == 105774)
									{
										this.AI_resetTimer();
										if (28018 - 7032 == 20986)
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
					if (this.LvlXuJsxC2.actionState != "standby")
					{
						if (26971 - 161083 == -134111)
						{
							continue;
						}
						if (this.LvlXuJsxC2.actionState != "run")
						{
							if (250747 - 530090 != -279342)
							{
								break;
							}
							continue;
						}
					}
					float num = this.LvlXuJsxC2.moveSpeed;
					if (216177 - 394547 != -178369)
					{
						float runSpeed = this.LvlXuJsxC2.runSpeed;
						if (244988 - 403246 != -158257)
						{
							Vector3 vector3 = default(Vector3);
							if (40549 - 315667 == -275118)
							{
								Vector3 vector4 = Vector3.zero;
								if (233584 - 129032 != 104553)
								{
									if ((this.LvlXuJsxC2.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (80473 - 64364 != 16109)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.LvlXuJsxC2.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (28174 - 3762 == 24413)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (147398 - 119906 != 27492)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (8888 - 162315 != -153427)
											{
												continue;
											}
											num = (float)0;
											if (30904 - 416102 == -385197)
											{
												continue;
											}
											this.transform.position = this.LvlXuJsxC2.nPosition;
											if (140316 - 350747 != -210431)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (160206 - 64150 == 96057)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (253927 - 592722 != -338795)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (285107 - 188340 == 96768)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (179428 - 148895 != 30533)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (24109 - 247831 != -223722)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (148442 - 591566 == -443123)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (181211 - 439192 == -257980)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (13016 - 300760 == -287743)
											{
												continue;
											}
										}
									}
									this.LvlXuJsxC2.vMovement = vector4;
									if (207240 - 227976 != -20735)
									{
										this.LvlXuJsxC2.moveSpeed = num;
										if (60479 - 152144 != -91664)
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

	// Token: 0x060015F5 RID: 5621 RVA: 0x00239A64 File Offset: 0x00237C64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (73227 - 427781 != -354554)
		{
		}
		do
		{
			if (Time.time - this.v4hXVaBYsB >= this.cXJXhYpVrw)
			{
				if (163112 - 193429 == -30316)
				{
					continue;
				}
				if (Time.time - this.v4hXVaBYsB < this.cXJXhYpVrw + mTime)
				{
					if (228060 - 478529 != -250469)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (92031 - 244508 != -152477)
						{
							continue;
						}
						this.AI_state = "idle";
						if (118262 - 260549 != -142287)
						{
							continue;
						}
						this.v4hXVaBYsB -= UnityEngine.Random.Range((float)0, rTimer);
						if (121877 - 215414 != -93537)
						{
							continue;
						}
						this.LvlXuJsxC2.vDirection = Vector3.zero;
						if (236352 - 387664 == -151311)
						{
							continue;
						}
						this.LvlXuJsxC2.vMovement = this.transform.forward;
						if (12690 - 444172 != -431482)
						{
							continue;
						}
						this.LvlXuJsxC2.actionState = "standby";
						if (76547 - 546269 == -469721)
						{
							continue;
						}
					}
					this.LvlXuJsxC2.moveSpeed = Mathf.Lerp(this.LvlXuJsxC2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (199470 - 237342 == -37871)
					{
						continue;
					}
					if (this.LvlXuJsxC2.moveSpeed < 0.1f * this.LvlXuJsxC2.runSpeed)
					{
						if (86268 - 197996 == -111727)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (55735 - 326162 == -270426)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (153614 - 491258 == -337643)
						{
							continue;
						}
						this.LvlXuJsxC2.moveSpeed = (float)0;
						if (273442 - 467333 == -193890)
						{
							continue;
						}
					}
				}
			}
			this.cXJXhYpVrw += mTime;
		}
		while (203534 - 577005 != -373471);
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x00239D28 File Offset: 0x00237F28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (43924 - 416922 != -372998)
		{
		}
		do
		{
			if (Time.time - this.v4hXVaBYsB >= this.cXJXhYpVrw)
			{
				if (283984 - 27626 != 256358)
				{
					continue;
				}
				if (Time.time - this.v4hXVaBYsB < this.cXJXhYpVrw + mTime)
				{
					if (66887 - 228700 != -161813)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (253962 - 298943 == -44980)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (18880 - 266643 != -247763)
						{
							continue;
						}
						this.v4hXVaBYsB -= UnityEngine.Random.Range((float)0, rTimer);
						if (68742 - 483953 == -415210)
						{
							continue;
						}
						this.LvlXuJsxC2.vDirection = this.LvlXuJsxC2.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (201366 - 510805 != -309439)
						{
							continue;
						}
						this.LvlXuJsxC2.vDirection.y = this.transform.position.y;
						if (70709 - 145696 != -74987)
						{
							continue;
						}
						this.LvlXuJsxC2.vMovement = (this.LvlXuJsxC2.vDirection - this.transform.position).normalized;
						if (7434 - 329900 == -322465)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.LvlXuJsxC2.vMovement);
						if (192932 - 233175 != -40243)
						{
							continue;
						}
						this.LvlXuJsxC2.actionState = "run";
						if (11500 - 440210 != -428710)
						{
							continue;
						}
						this.animation.Play("run");
						if (237796 - 153694 == 84103)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (224479 - 108093 == 116387)
						{
							continue;
						}
					}
					this.LvlXuJsxC2.moveSpeed = Mathf.Lerp(this.LvlXuJsxC2.moveSpeed, this.LvlXuJsxC2.runSpeed, (float)4 * Time.deltaTime);
					if (62566 - 581641 != -519075)
					{
						continue;
					}
				}
			}
			this.cXJXhYpVrw += mTime;
		}
		while (151166 - 400010 == -248843);
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x0023A030 File Offset: 0x00238230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (130832 - 464890 != -334058)
		{
		}
		for (;;)
		{
			this.LvlXuJsxC2.vDirection = followObject.transform.position;
			if (132205 - 133197 == -992)
			{
				this.LvlXuJsxC2.vDirection.y = this.transform.position.y;
				if (28596 - 553625 != -525028)
				{
					this.LvlXuJsxC2.vMovement = (this.LvlXuJsxC2.vDirection - this.transform.position).normalized;
					if (29862 - 135114 != -105251)
					{
						this.transform.rotation = Quaternion.LookRotation(this.LvlXuJsxC2.vMovement);
						if (257173 - 58973 != 198201)
						{
							this.LvlXuJsxC2.actionState = "run";
							if (152843 - 587836 != -434992)
							{
								this.animation.Play("run");
								if (262152 - 122582 == 139570)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (256114 - 386874 == -130760)
									{
										this.LvlXuJsxC2.moveSpeed = Mathf.Lerp(this.LvlXuJsxC2.moveSpeed, this.LvlXuJsxC2.runSpeed, (float)4 * Time.deltaTime);
										if (117635 - 503764 == -386129)
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

	// Token: 0x060015F8 RID: 5624 RVA: 0x0023A218 File Offset: 0x00238418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (279068 - 91838 != 187231)
		{
		}
		do
		{
			if (Time.time - this.v4hXVaBYsB >= this.cXJXhYpVrw)
			{
				if (233009 - 122184 == 110826)
				{
					continue;
				}
				if (Time.time - this.v4hXVaBYsB < this.cXJXhYpVrw + mTime)
				{
					if (123080 - 7365 == 115716)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (57191 - 231818 == -174626)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (266149 - 449691 == -183541)
						{
							continue;
						}
						this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
						if (154242 - 324731 != -170489)
						{
							continue;
						}
						this.LvlXuJsxC2.vDirection = Vector3.zero;
						if (250179 - 382335 != -132156)
						{
							continue;
						}
						this.LvlXuJsxC2.vMovement = this.transform.forward;
						if (129038 - 220976 == -91937)
						{
							continue;
						}
						this.LvlXuJsxC2.actionState = "standby";
						if (271736 - 258042 != 13694)
						{
							continue;
						}
						this.LvlXuJsxC2.myAttackTarget = this.LvlXuJsxC2.getHateTarget(5, 50);
						if (215275 - 223198 == -7922)
						{
							continue;
						}
						if (!this.LvlXuJsxC2.myAttackTarget)
						{
							if (89424 - 242588 != -153164)
							{
								continue;
							}
							this.LvlXuJsxC2.isAlert = false;
							if (89055 - 296424 != -207369)
							{
								continue;
							}
							this.v4hXVaBYsB = Time.time;
							if (112589 - 508302 == -395712)
							{
								continue;
							}
							this.LvlXuJsxC2.myAttackTarget = null;
							if (153388 - 298685 == -145296)
							{
								continue;
							}
							this.LvlXuJsxC2.mOriginalPosition = this.transform.position;
							if (111321 - 595229 != -483908)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.LvlXuJsxC2.myAttackTarget;
							if (123805 - 458943 == -335137)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (279773 - 399584 != -119811)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (140758 - 293624 != -152866)
								{
									continue;
								}
								this.LvlXuJsxC2.isAlert = false;
								if (66924 - 396510 == -329585)
								{
									continue;
								}
								this.v4hXVaBYsB = Time.time;
								if (84576 - 408058 != -323482)
								{
									continue;
								}
								this.LvlXuJsxC2.myAttackTarget = null;
								if (52699 - 136108 == -83408)
								{
									continue;
								}
							}
							else
							{
								this.LvlXuJsxC2.vDirection = myAttackTarget.transform.position;
								if (60971 - 513358 == -452386)
								{
									continue;
								}
								this.LvlXuJsxC2.vDirection.y = this.transform.position.y;
								if (255978 - 501059 == -245080)
								{
									continue;
								}
								this.LvlXuJsxC2.vMovement = (this.LvlXuJsxC2.vDirection - this.transform.position).normalized;
								if (230841 - 238497 == -7655)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LvlXuJsxC2.vMovement);
								if (96514 - 277536 != -181022)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.cXJXhYpVrw += mTime;
		}
		while (33024 - 337548 == -304523);
	}

	// Token: 0x060015F9 RID: 5625 RVA: 0x0023A6C8 File Offset: 0x002388C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (295877 - 386227 != -90349)
		{
		}
		do
		{
			if (Time.time - this.v4hXVaBYsB >= this.cXJXhYpVrw)
			{
				if (275476 - 479515 == -204038)
				{
					continue;
				}
				if (Time.time - this.v4hXVaBYsB < this.cXJXhYpVrw + mTime)
				{
					if (216827 - 466401 == -249573)
					{
						continue;
					}
					if (!this.LvlXuJsxC2.myAttackTarget)
					{
						if (69483 - 430923 != -361440)
						{
							continue;
						}
						this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
						if (122538 - 12683 != 109855)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.LvlXuJsxC2.myAttackTarget;
						if (142923 - 354566 == -211642)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (266875 - 101229 != 165646)
						{
							continue;
						}
						Vector3 vector = global::Math.vFlat(myAttackTarget.transform.position - this.transform.position);
						if (274511 - 504791 != -230280)
						{
							continue;
						}
						int tID = 0;
						if (225275 - 498233 == -272957)
						{
							continue;
						}
						if (characterControl)
						{
							if (63971 - 51655 == 12317)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (102154 - 500822 == -398667)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (254433 - 558980 != -304547)
						{
							continue;
						}
						if (num < (float)18)
						{
							if (162426 - 442432 == -280005)
							{
								continue;
							}
							if (this.LvlXuJsxC2.sp <= 90)
							{
								goto IL_12A7;
							}
							if (234836 - 353845 != -119009)
							{
								continue;
							}
							if (num >= (float)6)
							{
								goto IL_12A7;
							}
							if (9570 - 540419 == -530848)
							{
								continue;
							}
							if (!this.LvlXuJsxC2.hasSkill(372))
							{
								goto IL_12A7;
							}
							if (291777 - 388153 != -96376)
							{
								continue;
							}
							if (this.LvlXuJsxC2.isTimeOut("RPC_millionaire") != (float)0)
							{
								goto IL_12A7;
							}
							if (118806 - 157100 != -38294)
							{
								continue;
							}
							this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
							if (160629 - 527564 == -366934)
							{
								continue;
							}
							this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_millionaire(this.transform.position, vector.normalized, 0, 2));
							if (75326 - 208725 != -133399)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (29386 - 230464 == -201077)
								{
									continue;
								}
								this.CF2Xy4taGm.ActionEvent("RPC_millionaire2", this.transform.position, vector.normalized, 0);
								if (94457 - 497469 == -403011)
								{
									continue;
								}
							}
							IL_1189:
							goto IL_132;
							IL_12A7:
							if (this.LvlXuJsxC2.sp > 85)
							{
								if (11069 - 331502 == -320432)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(272))
								{
									if (268748 - 291245 == -22496)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("gorgonShot") == (float)0)
									{
										if (281945 - 419486 == -137540)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (293737 - 422121 != -128384)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_gorgonShot(this.transform.position, vector.normalized, tID, 2));
										if (124788 - 410151 != -285363)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (159831 - 16001 != 143830)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_gorgonShot4", this.transform.position, vector.normalized, tID);
											if (273036 - 294111 == -21074)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 50)
							{
								if (257429 - 521736 != -264307)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(352))
								{
									if (127670 - 498208 == -370537)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("RPC_shootingArray") == (float)0)
									{
										if (265937 - 12 != 265925)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (138153 - 525435 == -387281)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_shootingArray(this.transform.position, vector.normalized, 0, 2));
										if (283552 - 387128 != -103576)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (187619 - 540505 == -352885)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_shootingArray2", this.transform.position, vector.normalized, 0);
											if (115964 - 46274 == 69691)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 45)
							{
								if (127659 - 395532 == -267872)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(264))
								{
									if (288361 - 542592 == -254230)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("rapidTrance") == (float)0)
									{
										if (270206 - 367998 == -97791)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (36675 - 238324 == -201648)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_rapidTrance(this.transform.position, vector.normalized, tID, 1));
										if (199717 - 549557 != -349840)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (83969 - 323693 != -239724)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_rapidTrance1", this.transform.position, vector.normalized, tID);
											if (266787 - 371039 != -104252)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 40)
							{
								if (100747 - 570544 != -469797)
								{
									continue;
								}
								if (num < (float)7)
								{
									if (181349 - 26137 == 155213)
									{
										continue;
									}
									if (this.LvlXuJsxC2.hasSkill(334))
									{
										if (105689 - 458490 != -352801)
										{
											continue;
										}
										if (this.LvlXuJsxC2.isTimeOut("circleShot") == (float)0)
										{
											if (20261 - 472769 != -452508)
											{
												continue;
											}
											this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
											if (152563 - 456008 != -303445)
											{
												continue;
											}
											this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_circleShot(this.transform.position, vector.normalized, 0, 2));
											if (238507 - 472045 != -233538)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (222781 - 157345 != 65436)
												{
													continue;
												}
												this.CF2Xy4taGm.ActionEvent("RPC_circleShot2", this.transform.position, vector.normalized, 0);
												if (149861 - 62166 != 87695)
												{
													continue;
												}
											}
											goto IL_1189;
										}
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 35)
							{
								if (82706 - 129172 == -46465)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(244))
								{
									if (269140 - 133740 == 135401)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("acidicField") == (float)0)
									{
										if (81907 - 575189 != -493282)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (90488 - 108616 != -18128)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_cast1("acidicField", this.transform.position, vector.normalized, 0, 2));
										if (263793 - 38899 != 224894)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (180514 - 395856 != -215342)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_acidicField2", this.transform.position, vector.normalized, 0);
											if (200545 - 225875 == -25329)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 30)
							{
								if (74843 - 361656 != -286813)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(332))
								{
									if (85014 - 357887 == -272872)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("fourShot") == (float)0)
									{
										if (67464 - 104171 == -36706)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (216610 - 35481 == 181130)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_fourShot(this.transform.position, vector.normalized, 0, 2));
										if (225945 - 451304 != -225359)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (56258 - 309133 != -252875)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_fourShot2", this.transform.position, vector.normalized, 0);
											if (153 - 148020 == -147866)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 25)
							{
								if (85605 - 161896 != -76291)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(242))
								{
									if (284999 - 517319 == -232319)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("stickyGum") == (float)0)
									{
										if (188460 - 477071 == -288610)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (9012 - 96677 != -87665)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_cast1("stickyGum", this.transform.position, vector.normalized, 0, 2));
										if (240155 - 180131 != 60024)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (230384 - 298509 != -68125)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_stickyGum2", this.transform.position, vector.normalized, 0);
											if (108498 - 208495 != -99997)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 20)
							{
								if (50906 - 509666 != -458760)
								{
									continue;
								}
								if (num < (float)2)
								{
									if (158516 - 99782 == 58735)
									{
										continue;
									}
									if (this.LvlXuJsxC2.hasSkill(324))
									{
										if (163729 - 110991 == 52739)
										{
											continue;
										}
										if (this.LvlXuJsxC2.isTimeOut("backpack") == (float)0)
										{
											if (268386 - 500129 != -231743)
											{
												continue;
											}
											this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
											if (272150 - 80058 == 192093)
											{
												continue;
											}
											this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_backpack(this.transform.position, vector.normalized, 0, 2));
											if (164725 - 312243 != -147518)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (38730 - 102355 != -63625)
												{
													continue;
												}
												this.CF2Xy4taGm.ActionEvent("RPC_backpack2", this.transform.position, vector.normalized, 0);
												if (261373 - 360519 == -99145)
												{
													continue;
												}
											}
											goto IL_1189;
										}
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 15)
							{
								if (92857 - 523730 != -430873)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(214))
								{
									if (107688 - 591398 != -483710)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("mix") == (float)0)
									{
										if (226761 - 445144 != -218383)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (79431 - 310032 != -230601)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_cast1("mix", this.transform.position, vector.normalized, 0, 4));
										if (80057 - 165845 != -85787)
										{
											if (PhotonClient.IsInitialized())
											{
												if (163054 - 172609 != -9555)
												{
													continue;
												}
												this.CF2Xy4taGm.ActionEvent("RPC_mix4", this.transform.position, vector.normalized, 0);
												if (203850 - 133564 == 70287)
												{
													continue;
												}
											}
											goto IL_1189;
										}
										continue;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 10)
							{
								if (177470 - 388266 == -210795)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(304))
								{
									if (212811 - 385342 == -172530)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("gilShot") == (float)0)
									{
										if (200691 - 500049 == -299357)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (43642 - 305890 == -262247)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_gilShot(this.transform.position, vector.normalized, tID, 4));
										if (193904 - 258761 != -64857)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (248696 - 471261 != -222565)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_gilShot4", this.transform.position, vector.normalized, tID);
											if (135041 - 232911 != -97870)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.sp > 5)
							{
								if (112316 - 486352 == -374035)
								{
									continue;
								}
								if (this.LvlXuJsxC2.hasSkill(204))
								{
									if (42979 - 461447 != -418468)
									{
										continue;
									}
									if (this.LvlXuJsxC2.isTimeOut("maimShot") == (float)0)
									{
										if (10985 - 175410 == -164424)
										{
											continue;
										}
										this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
										if (157938 - 263944 != -106006)
										{
											continue;
										}
										this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_maimShot(this.transform.position, vector.normalized, tID, 4));
										if (106099 - 554257 != -448158)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (20990 - 18002 == 2989)
											{
												continue;
											}
											this.CF2Xy4taGm.ActionEvent("RPC_maimShot4", this.transform.position, vector.normalized, tID);
											if (48833 - 275080 == -226246)
											{
												continue;
											}
										}
										goto IL_1189;
									}
								}
							}
							if (this.LvlXuJsxC2.isTimeOut("nAttack") == (float)0)
							{
								if (85751 - 145716 == -59964)
								{
									continue;
								}
								this.v4hXVaBYsB = Time.time - mTime - this.cXJXhYpVrw;
								if (295102 - 503988 != -208886)
								{
									continue;
								}
								this.CF2Xy4taGm.StartCoroutine_Auto(this.CF2Xy4taGm.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (74730 - 198596 != -123866)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (26061 - 2998 != 23063)
									{
										continue;
									}
									this.CF2Xy4taGm.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
									if (169465 - 253998 != -84533)
									{
										continue;
									}
								}
							}
							else
							{
								this.AI_state = "attack";
								if (189575 - 494751 == -305175)
								{
									continue;
								}
								this.LvlXuJsxC2.vDirection = myAttackTarget.transform.position;
								if (220197 - 113389 == 106809)
								{
									continue;
								}
								this.LvlXuJsxC2.vDirection.y = this.transform.position.y;
								if (55481 - 382166 == -326684)
								{
									continue;
								}
								this.LvlXuJsxC2.vMovement = (this.LvlXuJsxC2.vDirection - this.transform.position).normalized;
								if (232316 - 97828 != 134488)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.LvlXuJsxC2.vMovement);
								if (243991 - 537061 != -293070)
								{
									continue;
								}
								this.LvlXuJsxC2.actionState = "standby";
								if (100968 - 77892 == 23077)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.2f);
								if (81381 - 211713 != -130332)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (140212 - 381524 != -241312)
								{
									continue;
								}
								this.LvlXuJsxC2.moveSpeed = Mathf.Lerp(this.LvlXuJsxC2.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (278164 - 426281 == -148116)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (241367 - 483091 == -241723)
							{
								continue;
							}
							this.LvlXuJsxC2.vDirection = myAttackTarget.transform.position;
							if (163312 - 593990 == -430677)
							{
								continue;
							}
							this.LvlXuJsxC2.vDirection.y = this.transform.position.y;
							if (61812 - 221566 != -159754)
							{
								continue;
							}
							this.LvlXuJsxC2.vMovement = (this.LvlXuJsxC2.vDirection - this.transform.position).normalized;
							if (231717 - 23129 != 208588)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.LvlXuJsxC2.vMovement);
							if (75445 - 210640 == -135194)
							{
								continue;
							}
							this.LvlXuJsxC2.actionState = "run";
							if (224508 - 575555 != -351047)
							{
								continue;
							}
							this.animation.Play("run");
							if (82926 - 218876 == -135949)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (141654 - 81734 == 59921)
							{
								continue;
							}
							this.LvlXuJsxC2.moveSpeed = Mathf.Lerp(this.LvlXuJsxC2.moveSpeed, this.LvlXuJsxC2.runSpeed, (float)4 * Time.deltaTime);
							if (122753 - 53894 == 68860)
							{
								continue;
							}
						}
					}
				}
			}
			IL_132:
			this.cXJXhYpVrw += mTime;
		}
		while (252651 - 151176 != 101475);
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0023BF64 File Offset: 0x0023A164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (289114 - 160320 != 128795)
		{
		}
		while (Time.time - this.v4hXVaBYsB > this.cXJXhYpVrw)
		{
			if (261757 - 316777 != -55019)
			{
				this.AI_state = "none";
				if (273348 - 510404 == -237056)
				{
					this.v4hXVaBYsB = Time.time;
					if (218946 - 219002 != -55)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0023C018 File Offset: 0x0023A218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (259019 - 504943 != -245924)
		{
		}
		for (;;)
		{
			IL_362:
			if (this.LM1Xz1Wn0O + (float)1 > Time.time)
			{
				if (125426 - 323661 == -198235)
				{
					break;
				}
			}
			else
			{
				this.LM1Xz1Wn0O = Time.time;
				if (126619 - 135253 == -8634)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (45270 - 94760 != -49489)
					{
						if (213296 - 363798 == -150502)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (99888 - 583347 == -483459)
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
									if (174922 - 96794 != 78128)
									{
										goto IL_362;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (79442 - 573483 != -494041)
									{
										goto IL_362;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (227843 - 493120 != -265277)
									{
										goto IL_362;
									}
									bool flag = true;
									if (176015 - 147198 == 28818)
									{
										goto IL_362;
									}
									eRace race = this.LvlXuJsxC2.Race;
									if (71454 - 120764 != -49310)
									{
										goto IL_362;
									}
									if (race == eRace.Tails)
									{
										if (132074 - 300422 == -168347)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_40;
										}
										if (279897 - 147690 != 132207)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (78752 - 244616 != -165864)
											{
												goto IL_362;
											}
											goto IL_40;
										}
										goto IL_4E1;
										IL_40:
										flag = false;
										if (25503 - 473512 == -448008)
										{
											goto IL_362;
										}
									}
									else if (race == eRace.Plants)
									{
										if (102439 - 207414 == -104974)
										{
											goto IL_362;
										}
										flag = false;
										if (253139 - 515748 != -262609)
										{
											goto IL_362;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (80284 - 310312 == -230027)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_5AA;
										}
										if (63052 - 232276 == -169223)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (43438 - 225747 != -182309)
											{
												goto IL_362;
											}
											goto IL_5AA;
										}
										goto IL_4E1;
										IL_5AA:
										flag = false;
										if (1031 - 410962 != -409931)
										{
											goto IL_362;
										}
									}
									else if (race == eRace.Robots)
									{
										if (88516 - 153103 == -64586)
										{
											goto IL_362;
										}
										flag = true;
										if (147390 - 271805 == -124414)
										{
											goto IL_362;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (163032 - 507778 != -344746)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_25F;
										}
										if (2576 - 299221 == -296644)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_25F;
										}
										if (39916 - 429902 != -389986)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (109919 - 2069 != 107850)
											{
												goto IL_362;
											}
											goto IL_25F;
										}
										goto IL_4E1;
										IL_25F:
										flag = false;
										if (276277 - 498981 != -222704)
										{
											goto IL_362;
										}
									}
									else if (race == eRace.Structure)
									{
										if (260744 - 138360 != 122384)
										{
											goto IL_362;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (233518 - 68742 != 164776)
											{
												goto IL_362;
											}
											flag = false;
											if (81652 - 385831 == -304178)
											{
												goto IL_362;
											}
										}
									}
									IL_4E1:
									if (flag)
									{
										if (298193 - 495006 == -196812)
										{
											goto IL_362;
										}
										if (characterControl.hp > 0)
										{
											if (142638 - 105924 != 36714)
											{
												goto IL_362;
											}
											if (characterControl.recieveTarget)
											{
												if (140174 - 416061 == -275886)
												{
													goto IL_362;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (77894 - 508747 == -430852)
													{
														goto IL_362;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (201618 - 105671 == 95948)
														{
															goto IL_362;
														}
														this.LvlXuJsxC2.isAlert = true;
														if (86162 - 314335 == -228172)
														{
															goto IL_362;
														}
														this.v4hXVaBYsB = Time.time;
														if (82448 - 145296 == -62847)
														{
															goto IL_362;
														}
														this.LvlXuJsxC2.myAttackTarget = gameObject;
														if (291213 - 241566 == 49648)
														{
															goto IL_362;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (180423 - 239054 != -58631)
														{
															goto IL_362;
														}
														this.LvlXuJsxC2.addHate(characterControl.ActorNr, 5);
														if (176389 - 449870 != -273481)
														{
															goto IL_362;
														}
													}
												}
											}
										}
									}
								}
								if (160385 - 131684 != 28702)
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

	// Token: 0x060015FC RID: 5628 RVA: 0x0023C668 File Offset: 0x0023A868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0023C66C File Offset: 0x0023A86C
	internal static bool cTnpZGFn6140nRgDelh()
	{
		return true;
	}

	// Token: 0x060015FE RID: 5630 RVA: 0x0023C670 File Offset: 0x0023A870
	internal static bool JG1ABOF6cguG8Y4MAw6()
	{
		return false;
	}

	// Token: 0x040012E5 RID: 4837
	private CharacterControl LvlXuJsxC2;

	// Token: 0x040012E6 RID: 4838
	private Rabbit CF2Xy4taGm;

	// Token: 0x040012E7 RID: 4839
	public string AI_state;

	// Token: 0x040012E8 RID: 4840
	private float v4hXVaBYsB;

	// Token: 0x040012E9 RID: 4841
	private float cXJXhYpVrw;

	// Token: 0x040012EA RID: 4842
	private GameObject QnjXK6bM8E;

	// Token: 0x040012EB RID: 4843
	private float LM1Xz1Wn0O;
}
