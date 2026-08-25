using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B84 RID: 2948
[Serializable]
public class BatCult_AI : MonoBehaviour
{
	// Token: 0x060041A7 RID: 16807 RVA: 0x0084C590 File Offset: 0x0084A790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BatCult_AI()
	{
		if (249116 - 222194 != 26922)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (124287 - 69033 == 55254)
			{
				base..ctor();
				if (229332 - 523054 != -293721)
				{
					this.AI_state = "none";
					if (285246 - 381406 != -96159)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060041A8 RID: 16808 RVA: 0x0084C62C File Offset: 0x0084A82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.CKWVT8OiUM = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.s1mVYQ0bY9 = (BatCult)this.GetComponent(typeof(BatCult));
	}

	// Token: 0x060041A9 RID: 16809 RVA: 0x0084C664 File Offset: 0x0084A864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (214263 - 207199 != 7064)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (178541 - 369110 == -190568)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (226693 - 300018 != -73325)
				{
					continue;
				}
			}
			if (this.CKWVT8OiUM.isControlled)
			{
				break;
			}
			if (43757 - 274220 == -230463)
			{
				this.AIControl();
				if (219316 - 94981 == 124335)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060041AA RID: 16810 RVA: 0x0084C730 File Offset: 0x0084A930
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (177688 - 28168 != 149520)
		{
		}
		for (;;)
		{
			this.JG4Vb1kg52 = (float)0;
			if (104469 - 473910 != -369440)
			{
				if (this.CKWVT8OiUM.isMine)
				{
					if (264408 - 353841 == -89433)
					{
						if (this.CKWVT8OiUM.actionState != "standby")
						{
							if (147048 - 362950 != -215902)
							{
								continue;
							}
							if (this.CKWVT8OiUM.actionState != "run")
							{
								if (120430 - 458326 != -337896)
								{
									continue;
								}
								break;
							}
						}
						if (!this.CKWVT8OiUM.isAlert)
						{
							if (141664 - 141282 == 382)
							{
								this.AI_idle(9f, 3f);
								if (83189 - 89479 == -6290)
								{
									this.AI_patrol(1f, 0.25f);
									if (146930 - 494498 != -347567)
									{
										this.AI_resetTimer();
										if (234427 - 447531 == -213104)
										{
											this.AI_visionCheck();
											if (36758 - 324698 == -287940)
											{
												if (!this.CKWVT8OiUM.myAttackTarget)
												{
													break;
												}
												if (286240 - 64497 == 221743)
												{
													this.CKWVT8OiUM.isAlert = true;
													if (42864 - 451644 == -408780)
													{
														this.FLRV3CEgSi = Time.time;
														if (159396 - 119534 == 39862)
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
							if (183612 - 113455 != 70158)
							{
								this.AI_patrol(1f, 1f);
								if (627 - 546956 != -546328)
								{
									this.AI_attack(10f, (float)0);
									if (252459 - 371940 == -119481)
									{
										this.AI_resetTimer();
										if (243346 - 254498 == -11152)
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
					if (this.CKWVT8OiUM.actionState != "standby")
					{
						if (213948 - 165291 == 48658)
						{
							continue;
						}
						if (this.CKWVT8OiUM.actionState != "run")
						{
							if (109403 - 237961 != -128558)
							{
								continue;
							}
							break;
						}
					}
					float num = this.CKWVT8OiUM.moveSpeed;
					if (299773 - 299276 != 498)
					{
						float runSpeed = this.CKWVT8OiUM.runSpeed;
						if (106541 - 504105 != -397563)
						{
							Vector3 vector = default(Vector3);
							if (38314 - 96968 != -58653)
							{
								Vector3 vector2 = Vector3.zero;
								if (145920 - 492521 != -346600)
								{
									if ((this.CKWVT8OiUM.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (129870 - 128830 == 1041)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.CKWVT8OiUM.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (162089 - 265860 != -103771)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (93105 - 156682 != -63577)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (60384 - 536214 == -475829)
											{
												continue;
											}
											num = (float)0;
											if (168371 - 314203 == -145831)
											{
												continue;
											}
											this.transform.position = this.CKWVT8OiUM.nPosition;
											if (264105 - 10408 == 253698)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (30622 - 34914 != -4292)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (187517 - 427632 != -240115)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (7119 - 432686 != -425567)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (68403 - 392303 != -323900)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (96864 - 338638 != -241774)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (260444 - 484908 == -224463)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (199589 - 305987 != -106398)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (240428 - 529131 == -288702)
											{
												continue;
											}
										}
									}
									this.CKWVT8OiUM.vMovement = vector2;
									if (54415 - 412548 != -358132)
									{
										this.CKWVT8OiUM.moveSpeed = num;
										if (236149 - 370619 != -134469)
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

	// Token: 0x060041AB RID: 16811 RVA: 0x0084CDA8 File Offset: 0x0084AFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (99112 - 289273 != -190160)
		{
		}
		do
		{
			if (Time.time - this.FLRV3CEgSi >= this.JG4Vb1kg52)
			{
				if (64637 - 598347 == -533709)
				{
					continue;
				}
				if (Time.time - this.FLRV3CEgSi < this.JG4Vb1kg52 + mTime)
				{
					if (143940 - 31003 != 112937)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (154576 - 211858 != -57282)
						{
							continue;
						}
						this.AI_state = "idle";
						if (152031 - 144996 != 7035)
						{
							continue;
						}
						this.FLRV3CEgSi -= UnityEngine.Random.Range((float)0, rTimer);
						if (235894 - 353241 == -117346)
						{
							continue;
						}
						this.CKWVT8OiUM.vDirection = Vector3.zero;
						if (145450 - 501172 == -355721)
						{
							continue;
						}
						this.CKWVT8OiUM.vMovement = this.transform.forward;
						if (184788 - 41206 != 143582)
						{
							continue;
						}
						this.CKWVT8OiUM.actionState = "standby";
						if (36428 - 593586 == -557157)
						{
							continue;
						}
					}
					this.CKWVT8OiUM.moveSpeed = Mathf.Lerp(this.CKWVT8OiUM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (165225 - 141812 == 23414)
					{
						continue;
					}
					if (this.CKWVT8OiUM.moveSpeed < 0.1f * this.CKWVT8OiUM.runSpeed)
					{
						if (82397 - 138161 != -55764)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (79968 - 304783 == -224814)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (111000 - 564313 == -453312)
						{
							continue;
						}
						this.CKWVT8OiUM.moveSpeed = (float)0;
						if (104702 - 460538 == -355835)
						{
							continue;
						}
					}
				}
			}
			this.JG4Vb1kg52 += mTime;
		}
		while (298287 - 232644 == 65644);
	}

	// Token: 0x060041AC RID: 16812 RVA: 0x0084D06C File Offset: 0x0084B26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (5205 - 104698 != -99493)
		{
		}
		do
		{
			if (Time.time - this.FLRV3CEgSi >= this.JG4Vb1kg52)
			{
				if (216899 - 125122 == 91778)
				{
					continue;
				}
				if (Time.time - this.FLRV3CEgSi < this.JG4Vb1kg52 + mTime)
				{
					if (116955 - 259739 == -142783)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (261695 - 505674 == -243978)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (140375 - 96357 == 44019)
						{
							continue;
						}
						this.FLRV3CEgSi -= UnityEngine.Random.Range((float)0, rTimer);
						if (223599 - 310651 != -87052)
						{
							continue;
						}
						this.CKWVT8OiUM.vDirection = this.CKWVT8OiUM.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (9471 - 466133 == -456661)
						{
							continue;
						}
						this.CKWVT8OiUM.vDirection.y = this.transform.position.y;
						if (213871 - 53823 == 160049)
						{
							continue;
						}
						this.CKWVT8OiUM.vMovement = (this.CKWVT8OiUM.vDirection - this.transform.position).normalized;
						if (29619 - 396742 != -367123)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.CKWVT8OiUM.vMovement);
						if (138347 - 217562 == -79214)
						{
							continue;
						}
						this.CKWVT8OiUM.actionState = "run";
						if (254302 - 517645 != -263343)
						{
							continue;
						}
						this.animation.Play("run");
						if (246 - 491218 == -490971)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (226279 - 260575 != -34296)
						{
							continue;
						}
					}
					this.CKWVT8OiUM.moveSpeed = Mathf.Lerp(this.CKWVT8OiUM.moveSpeed, this.CKWVT8OiUM.runSpeed, (float)4 * Time.deltaTime);
					if (163984 - 578542 == -414557)
					{
						continue;
					}
				}
			}
			this.JG4Vb1kg52 += mTime;
		}
		while (110337 - 403219 != -292882);
	}

	// Token: 0x060041AD RID: 16813 RVA: 0x0084D374 File Offset: 0x0084B574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (218628 - 269314 != -50686)
		{
		}
		do
		{
			if (Time.time - this.FLRV3CEgSi >= this.JG4Vb1kg52)
			{
				if (251907 - 555759 != -303852)
				{
					continue;
				}
				if (Time.time - this.FLRV3CEgSi < this.JG4Vb1kg52 + mTime)
				{
					if (169809 - 578525 != -408716)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (230673 - 261249 != -30576)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (135472 - 30245 == 105228)
						{
							continue;
						}
						this.FLRV3CEgSi = Time.time - mTime - this.JG4Vb1kg52;
						if (267709 - 162879 != 104830)
						{
							continue;
						}
						this.CKWVT8OiUM.vDirection = Vector3.zero;
						if (190004 - 502883 == -312878)
						{
							continue;
						}
						this.CKWVT8OiUM.vMovement = this.transform.forward;
						if (130306 - 499179 == -368872)
						{
							continue;
						}
						this.CKWVT8OiUM.actionState = "standby";
						if (42536 - 461383 != -418847)
						{
							continue;
						}
						this.CKWVT8OiUM.myAttackTarget = this.CKWVT8OiUM.getHateTarget(5, 50);
						if (146155 - 136359 != 9796)
						{
							continue;
						}
						if (!this.CKWVT8OiUM.myAttackTarget)
						{
							if (66622 - 312121 == -245498)
							{
								continue;
							}
							this.CKWVT8OiUM.isAlert = false;
							if (184838 - 250257 != -65419)
							{
								continue;
							}
							this.FLRV3CEgSi = Time.time;
							if (152604 - 478504 != -325900)
							{
								continue;
							}
							this.CKWVT8OiUM.myAttackTarget = null;
							if (275096 - 411858 != -136762)
							{
								continue;
							}
							this.CKWVT8OiUM.mOriginalPosition = this.transform.position;
							if (211331 - 376005 != -164673)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.CKWVT8OiUM.myAttackTarget;
							if (89448 - 172622 != -83174)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (67069 - 503117 != -436048)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (253114 - 120348 != 132766)
								{
									continue;
								}
								this.CKWVT8OiUM.isAlert = false;
								if (59010 - 21804 != 37206)
								{
									continue;
								}
								this.FLRV3CEgSi = Time.time;
								if (89183 - 390126 != -300943)
								{
									continue;
								}
								this.CKWVT8OiUM.myAttackTarget = null;
								if (253626 - 154602 != 99024)
								{
									continue;
								}
							}
							else
							{
								this.CKWVT8OiUM.vDirection = myAttackTarget.transform.position;
								if (269165 - 190283 == 78883)
								{
									continue;
								}
								this.CKWVT8OiUM.vDirection.y = this.transform.position.y;
								if (178878 - 592754 != -413876)
								{
									continue;
								}
								this.CKWVT8OiUM.vMovement = (this.CKWVT8OiUM.vDirection - this.transform.position).normalized;
								if (264187 - 217826 != 46361)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.CKWVT8OiUM.vMovement);
								if (96481 - 129003 != -32522)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JG4Vb1kg52 += mTime;
		}
		while (236717 - 141045 != 95672);
	}

	// Token: 0x060041AE RID: 16814 RVA: 0x0084D824 File Offset: 0x0084BA24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (282130 - 291056 != -8925)
		{
		}
		do
		{
			if (Time.time - this.FLRV3CEgSi >= this.JG4Vb1kg52)
			{
				if (159366 - 275594 == -116227)
				{
					continue;
				}
				if (Time.time - this.FLRV3CEgSi < this.JG4Vb1kg52 + mTime)
				{
					if (246556 - 384959 == -138402)
					{
						continue;
					}
					if (!this.CKWVT8OiUM.myAttackTarget)
					{
						if (6741 - 598919 == -592177)
						{
							continue;
						}
						this.FLRV3CEgSi = Time.time - mTime - this.JG4Vb1kg52;
						if (62807 - 125966 != -63159)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.CKWVT8OiUM.myAttackTarget;
						if (225194 - 115328 != 109866)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (36955 - 332057 != -295102)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (31873 - 179048 == -147174)
						{
							continue;
						}
						int tID = 0;
						if (76660 - 478948 != -402288)
						{
							continue;
						}
						if (characterControl)
						{
							if (247491 - 467166 != -219675)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (126716 - 124753 != 1963)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (255170 - 432375 == -177204)
						{
							continue;
						}
						if (this.CKWVT8OiUM.isTimeOut("nAttack") == (float)0)
						{
							if (279379 - 451136 == -171756)
							{
								continue;
							}
							this.FLRV3CEgSi = Time.time - mTime - this.JG4Vb1kg52;
							if (286301 - 76138 != 210163)
							{
								continue;
							}
							this.s1mVYQ0bY9.StartCoroutine_Auto(this.s1mVYQ0bY9.RPC_randomCast(this.transform.position, vector, tID));
							if (142085 - 566532 == -424446)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (75447 - 451950 == -376502)
								{
									continue;
								}
								this.s1mVYQ0bY9.ActionEvent("RPC_randomCast", this.transform.position, vector, tID);
								if (245224 - 368721 != -123497)
								{
									continue;
								}
							}
						}
						else
						{
							if (num > (float)3)
							{
								if (209462 - 269224 != -59762)
								{
									continue;
								}
								if (num < (float)12)
								{
									if (124598 - 128309 == -3710)
									{
										continue;
									}
									if (this.CKWVT8OiUM.isTimeOut("cAttack") == (float)0)
									{
										if (285914 - 34618 != 251296)
										{
											continue;
										}
										this.FLRV3CEgSi = Time.time - mTime - this.JG4Vb1kg52;
										if (11306 - 104854 != -93548)
										{
											continue;
										}
										this.s1mVYQ0bY9.StartCoroutine_Auto(this.s1mVYQ0bY9.RPC_cAttack(this.transform.position, vector, tID));
										if (236783 - 553660 != -316876)
										{
											if (PhotonClient.IsInitialized())
											{
												if (143448 - 450287 == -306838)
												{
													continue;
												}
												this.s1mVYQ0bY9.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
												if (69817 - 11870 != 57947)
												{
													continue;
												}
											}
											goto IL_25A;
										}
										continue;
									}
								}
							}
							this.AI_state = "attack";
							if (148440 - 514595 == -366154)
							{
								continue;
							}
							this.CKWVT8OiUM.vDirection = myAttackTarget.transform.position;
							if (277496 - 471186 == -193689)
							{
								continue;
							}
							this.CKWVT8OiUM.vDirection.y = this.transform.position.y;
							if (20861 - 368784 == -347922)
							{
								continue;
							}
							this.CKWVT8OiUM.vMovement = (this.CKWVT8OiUM.vDirection - this.transform.position).normalized;
							if (17760 - 277135 == -259374)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.CKWVT8OiUM.vMovement);
							if (15142 - 141340 == -126197)
							{
								continue;
							}
							if (num > (float)12)
							{
								if (83507 - 47050 != 36457)
								{
									continue;
								}
								this.CKWVT8OiUM.actionState = "run";
								if (219751 - 546229 == -326477)
								{
									continue;
								}
								this.animation.Play("run");
								if (34791 - 328400 == -293608)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (217444 - 91666 == 125779)
								{
									continue;
								}
								this.CKWVT8OiUM.moveSpeed = Mathf.Lerp(this.CKWVT8OiUM.moveSpeed, this.CKWVT8OiUM.runSpeed, (float)4 * Time.deltaTime);
								if (285814 - 91114 == 194701)
								{
									continue;
								}
							}
							else
							{
								this.CKWVT8OiUM.actionState = "standby";
								if (20210 - 474310 != -454100)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.2f);
								if (191329 - 159519 != 31810)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (264357 - 241257 == 23101)
								{
									continue;
								}
								this.CKWVT8OiUM.moveSpeed = Mathf.Lerp(this.CKWVT8OiUM.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (81387 - 24609 == 56779)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_25A:
			this.JG4Vb1kg52 += mTime;
		}
		while (202418 - 268634 == -66215);
	}

	// Token: 0x060041AF RID: 16815 RVA: 0x0084DF78 File Offset: 0x0084C178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (34115 - 109745 != -75629)
		{
		}
		while (Time.time - this.FLRV3CEgSi > this.JG4Vb1kg52)
		{
			if (57472 - 469075 != -411602)
			{
				this.AI_state = "none";
				if (223135 - 508057 != -284921)
				{
					this.FLRV3CEgSi = Time.time;
					if (282340 - 27028 != 255313)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060041B0 RID: 16816 RVA: 0x0084E02C File Offset: 0x0084C22C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (142217 - 487858 != -345641)
		{
		}
		for (;;)
		{
			IL_67C:
			if (this.HlxVd2qNBL > Time.time)
			{
				if (78243 - 534645 != -456401)
				{
					break;
				}
			}
			else
			{
				this.HlxVd2qNBL = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (60576 - 199999 != -139422)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (135785 - 468790 != -333004 && 208661 - 130031 != 78631)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (7162 - 454938 == -447776)
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
								if (1126 - 530278 == -529151)
								{
									goto IL_67C;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (130042 - 451170 != -321128)
								{
									goto IL_67C;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (12662 - 387848 == -375185)
								{
									goto IL_67C;
								}
								bool flag = true;
								if (81214 - 145870 != -64656)
								{
									goto IL_67C;
								}
								eRace race = this.CKWVT8OiUM.Race;
								if (222737 - 352387 == -129649)
								{
									goto IL_67C;
								}
								if (race == eRace.Tails)
								{
									if (74332 - 30126 == 44207)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_5F2;
									}
									if (104581 - 53583 == 50999)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (137389 - 519350 != -381961)
										{
											goto IL_67C;
										}
										goto IL_5F2;
									}
									goto IL_335;
									IL_5F2:
									flag = false;
									if (164182 - 46236 == 117947)
									{
										goto IL_67C;
									}
								}
								else if (race == eRace.Plants)
								{
									if (267479 - 435233 == -167753)
									{
										goto IL_67C;
									}
									flag = false;
									if (156303 - 371668 == -215364)
									{
										goto IL_67C;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (149445 - 570523 != -421078)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_63A;
									}
									if (293313 - 419960 != -126647)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (219381 - 61437 != 157945)
										{
											goto IL_63A;
										}
										goto IL_67C;
									}
									goto IL_335;
									IL_63A:
									flag = false;
									if (6321 - 62223 != -55902)
									{
										goto IL_67C;
									}
								}
								else if (race == eRace.Robots)
								{
									if (128425 - 186660 != -58235)
									{
										goto IL_67C;
									}
									flag = true;
									if (9363 - 517120 == -507756)
									{
										goto IL_67C;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (3707 - 560836 != -557129)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_1A5;
									}
									if (214285 - 586154 == -371868)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_1A5;
									}
									if (17471 - 230726 == -213254)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (120328 - 105379 != 14950)
										{
											goto IL_1A5;
										}
										goto IL_67C;
									}
									goto IL_335;
									IL_1A5:
									flag = false;
									if (135039 - 236483 != -101444)
									{
										goto IL_67C;
									}
								}
								else if (race == eRace.Structure)
								{
									if (186856 - 117257 != 69599)
									{
										goto IL_67C;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (223811 - 436655 == -212843)
										{
											goto IL_67C;
										}
										flag = false;
										if (107434 - 14977 != 92457)
										{
											goto IL_67C;
										}
									}
								}
								IL_335:
								if (flag)
								{
									if (228118 - 570986 != -342868)
									{
										goto IL_67C;
									}
									if (characterControl.hp > 0)
									{
										if (4218 - 320991 != -316773)
										{
											goto IL_67C;
										}
										if (characterControl.recieveTarget)
										{
											if (147264 - 422097 != -274833)
											{
												goto IL_67C;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (278533 - 455179 != -176646)
												{
													goto IL_67C;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (259019 - 163714 != 95305)
													{
														goto IL_67C;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (261572 - 145469 == 116104)
													{
														goto IL_67C;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (73376 - 174626 != -101250)
														{
															goto IL_67C;
														}
														this.CKWVT8OiUM.myAttackTarget = gameObject;
														if (51814 - 583873 != -532059)
														{
															goto IL_67C;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (101945 - 458002 != -356057)
														{
															goto IL_67C;
														}
														this.CKWVT8OiUM.addHate(characterControl.ActorNr, 5);
														if (230493 - 226900 != 3593)
														{
															goto IL_67C;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (63279 - 265970 != -202691)
														{
															goto IL_67C;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (101262 - 372102 == -270839)
														{
															goto IL_67C;
														}
														if (num < (float)60)
														{
															if (6575 - 64519 == -57943)
															{
																goto IL_67C;
															}
															if (characterControl.hp > 0)
															{
																if (285565 - 49742 != 235823)
																{
																	goto IL_67C;
																}
																this.CKWVT8OiUM.myAttackTarget = gameObject;
																if (25150 - 344971 == -319820)
																{
																	goto IL_67C;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (266226 - 166259 == 99968)
																{
																	goto IL_67C;
																}
																this.CKWVT8OiUM.addHate(characterControl.ActorNr, 5);
																if (10724 - 364949 == -354224)
																{
																	goto IL_67C;
																}
															}
														}
													}
													if (this.CKWVT8OiUM.myAttackTarget)
													{
														if (278738 - 495790 != -217052)
														{
															goto IL_67C;
														}
														this.CKWVT8OiUM.isAlert = true;
														if (262159 - 544024 != -281865)
														{
															goto IL_67C;
														}
														this.FLRV3CEgSi = Time.time;
														if (263300 - 345300 == -81999)
														{
															goto IL_67C;
														}
													}
												}
											}
										}
									}
								}
							}
							if (162078 - 67352 == 94726)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060041B1 RID: 16817 RVA: 0x0084E844 File Offset: 0x0084CA44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060041B2 RID: 16818 RVA: 0x0084E848 File Offset: 0x0084CA48
	internal static bool XOWrbS5gNosEaDMcsBwH()
	{
		return true;
	}

	// Token: 0x060041B3 RID: 16819 RVA: 0x0084E84C File Offset: 0x0084CA4C
	internal static bool nKkHA95gY4ZaJWf33pDP()
	{
		return false;
	}

	// Token: 0x04004DBB RID: 19899
	private CharacterControl CKWVT8OiUM;

	// Token: 0x04004DBC RID: 19900
	private BatCult s1mVYQ0bY9;

	// Token: 0x04004DBD RID: 19901
	public string AI_state;

	// Token: 0x04004DBE RID: 19902
	private float FLRV3CEgSi;

	// Token: 0x04004DBF RID: 19903
	private float JG4Vb1kg52;

	// Token: 0x04004DC0 RID: 19904
	private float HlxVd2qNBL;
}
