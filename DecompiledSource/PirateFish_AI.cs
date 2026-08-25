using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D7B RID: 3451
[Serializable]
public class PirateFish_AI : MonoBehaviour
{
	// Token: 0x06004DAF RID: 19887 RVA: 0x0098F324 File Offset: 0x0098D524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PirateFish_AI()
	{
		if (117564 - 98002 != 19563)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (108579 - 399413 == -290834)
			{
				base..ctor();
				if (216875 - 507670 != -290794)
				{
					this.AI_state = "none";
					if (134832 - 155714 != -20881)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004DB0 RID: 19888 RVA: 0x0098F3C0 File Offset: 0x0098D5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.Lf6ccKFU2LF = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.WvlcczP1yIt = (PirateFish)this.GetComponent(typeof(PirateFish));
	}

	// Token: 0x06004DB1 RID: 19889 RVA: 0x0098F3F8 File Offset: 0x0098D5F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (212086 - 309628 != -97542)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (75157 - 83876 != -8719)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (216403 - 549022 == -332618)
				{
					continue;
				}
			}
			if (this.Lf6ccKFU2LF.isControlled)
			{
				break;
			}
			if (6787 - 555471 == -548684)
			{
				this.AIControl();
				if (20918 - 151171 == -130253)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004DB2 RID: 19890 RVA: 0x0098F4C4 File Offset: 0x0098D6C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (144698 - 372948 != -228250)
		{
		}
		for (;;)
		{
			this.IM4cncany6E = (float)0;
			if (289231 - 155139 != 134093)
			{
				if (this.Lf6ccKFU2LF.isMine)
				{
					if (172907 - 57888 != 115020)
					{
						if (this.Lf6ccKFU2LF.actionState != "standby")
						{
							if (172173 - 229278 != -57105)
							{
								continue;
							}
							if (this.Lf6ccKFU2LF.actionState != "run")
							{
								if (73519 - 571711 != -498192)
								{
									continue;
								}
								break;
							}
						}
						if (!this.Lf6ccKFU2LF.isAlert)
						{
							if (286249 - 108941 != 177309)
							{
								this.AI_idle(3f, 2f);
								if (18181 - 513231 == -495050)
								{
									this.AI_patrol(1f, 1f);
									if (47035 - 131489 != -84453)
									{
										this.AI_resetTimer();
										if (291920 - 469112 != -177191)
										{
											this.AI_visionCheck();
											if (65143 - 54927 != 10217)
											{
												if (!this.Lf6ccKFU2LF.myAttackTarget)
												{
													break;
												}
												if (9334 - 311951 == -302617)
												{
													this.Lf6ccKFU2LF.isAlert = true;
													if (127221 - 496036 == -368815)
													{
														this.INXcn5CyVem = Time.time;
														if (243837 - 458725 == -214888)
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
							if (229693 - 328961 != -99267)
							{
								this.AI_idle(1f, 1f);
								if (106897 - 351091 == -244194)
								{
									this.AI_attack(12f, (float)0);
									if (95090 - 477505 == -382415)
									{
										this.AI_resetTimer();
										if (235290 - 447909 != -212618)
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
					if (this.Lf6ccKFU2LF.actionState != "standby")
					{
						if (257311 - 106553 != 150758)
						{
							continue;
						}
						if (this.Lf6ccKFU2LF.actionState != "run")
						{
							if (38352 - 258276 != -219923)
							{
								break;
							}
							continue;
						}
					}
					float num = this.Lf6ccKFU2LF.moveSpeed;
					if (199326 - 215278 == -15952)
					{
						float runSpeed = this.Lf6ccKFU2LF.runSpeed;
						if (189308 - 427743 == -238435)
						{
							Vector3 vector = default(Vector3);
							if (79349 - 424570 != -345220)
							{
								Vector3 vector2 = Vector3.zero;
								if (202286 - 224236 != -21949)
								{
									if ((this.Lf6ccKFU2LF.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (20419 - 181091 != -160672)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.Lf6ccKFU2LF.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (151823 - 572601 == -420777)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (193315 - 204503 != -11188)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (26512 - 3864 != 22648)
											{
												continue;
											}
											num = (float)0;
											if (61835 - 517705 == -455869)
											{
												continue;
											}
											this.transform.position = this.Lf6ccKFU2LF.nPosition;
											if (225331 - 498625 != -273294)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (22629 - 337513 == -314883)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (160552 - 527094 != -366542)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (273781 - 251945 == 21837)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (290927 - 43687 != 247240)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69751 - 495547 != -425796)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (257954 - 479172 != -221218)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (244799 - 572733 == -327933)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288446 - 29030 != 259416)
											{
												continue;
											}
										}
									}
									this.Lf6ccKFU2LF.vMovement = vector2;
									if (15952 - 514828 != -498875)
									{
										this.Lf6ccKFU2LF.moveSpeed = num;
										if (188860 - 173843 == 15017)
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

	// Token: 0x06004DB3 RID: 19891 RVA: 0x0098FB3C File Offset: 0x0098DD3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (248653 - 47004 != 201649)
		{
		}
		do
		{
			if (Time.time - this.INXcn5CyVem >= this.IM4cncany6E)
			{
				if (187478 - 121151 != 66327)
				{
					continue;
				}
				if (Time.time - this.INXcn5CyVem < this.IM4cncany6E + mTime)
				{
					if (174608 - 490975 == -316366)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (299854 - 348097 == -48242)
						{
							continue;
						}
						this.AI_state = "idle";
						if (296787 - 8568 != 288219)
						{
							continue;
						}
						this.INXcn5CyVem -= UnityEngine.Random.Range((float)0, rTimer);
						if (47040 - 461747 != -414707)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vDirection = Vector3.zero;
						if (249906 - 516306 != -266400)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vMovement = this.transform.forward;
						if (222435 - 259676 == -37240)
						{
							continue;
						}
						this.Lf6ccKFU2LF.actionState = "standby";
						if (154060 - 153107 != 953)
						{
							continue;
						}
					}
					this.Lf6ccKFU2LF.moveSpeed = Mathf.Lerp(this.Lf6ccKFU2LF.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (48704 - 44855 == 3850)
					{
						continue;
					}
					if (this.Lf6ccKFU2LF.moveSpeed < 0.1f * this.Lf6ccKFU2LF.runSpeed)
					{
						if (108064 - 21128 != 86936)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (41103 - 465918 == -424814)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (140795 - 451558 != -310763)
						{
							continue;
						}
						this.Lf6ccKFU2LF.moveSpeed = (float)0;
						if (173836 - 459951 == -286114)
						{
							continue;
						}
					}
				}
			}
			this.IM4cncany6E += mTime;
		}
		while (158975 - 399580 == -240604);
	}

	// Token: 0x06004DB4 RID: 19892 RVA: 0x0098FE00 File Offset: 0x0098E000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (1537 - 333320 != -331783)
		{
		}
		do
		{
			if (Time.time - this.INXcn5CyVem >= this.IM4cncany6E)
			{
				if (299594 - 302951 == -3356)
				{
					continue;
				}
				if (Time.time - this.INXcn5CyVem < this.IM4cncany6E + mTime)
				{
					if (251944 - 50529 != 201415)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (96879 - 276393 != -179514)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (16601 - 2193 == 14409)
						{
							continue;
						}
						this.INXcn5CyVem -= UnityEngine.Random.Range((float)0, rTimer);
						if (59721 - 244056 == -184334)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vDirection = this.Lf6ccKFU2LF.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (270719 - 239473 == 31247)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vDirection.y = this.transform.position.y;
						if (145650 - 303373 == -157722)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vMovement = (this.Lf6ccKFU2LF.vDirection - this.transform.position).normalized;
						if (297262 - 486788 != -189526)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.Lf6ccKFU2LF.vMovement);
						if (189363 - 31799 != 157564)
						{
							continue;
						}
						this.Lf6ccKFU2LF.actionState = "run";
						if (2025 - 59304 == -57278)
						{
							continue;
						}
						this.animation.Play("run");
						if (19471 - 455206 != -435735)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (240859 - 113948 != 126911)
						{
							continue;
						}
					}
					this.Lf6ccKFU2LF.moveSpeed = Mathf.Lerp(this.Lf6ccKFU2LF.moveSpeed, this.Lf6ccKFU2LF.runSpeed, (float)4 * Time.deltaTime);
					if (191823 - 102013 == 89811)
					{
						continue;
					}
				}
			}
			this.IM4cncany6E += mTime;
		}
		while (108635 - 291480 != -182845);
	}

	// Token: 0x06004DB5 RID: 19893 RVA: 0x00990108 File Offset: 0x0098E308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (283393 - 286804 != -3410)
		{
		}
		do
		{
			if (Time.time - this.INXcn5CyVem >= this.IM4cncany6E)
			{
				if (167079 - 522301 != -355222)
				{
					continue;
				}
				if (Time.time - this.INXcn5CyVem < this.IM4cncany6E + mTime)
				{
					if (258872 - 476509 == -217636)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (116839 - 310384 != -193545)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (13306 - 580141 == -566834)
						{
							continue;
						}
						this.INXcn5CyVem = Time.time - mTime - this.IM4cncany6E;
						if (141158 - 384788 == -243629)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vDirection = Vector3.zero;
						if (99138 - 321608 == -222469)
						{
							continue;
						}
						this.Lf6ccKFU2LF.vMovement = this.transform.forward;
						if (82144 - 515310 == -433165)
						{
							continue;
						}
						this.Lf6ccKFU2LF.actionState = "standby";
						if (120784 - 535957 != -415173)
						{
							continue;
						}
						this.Lf6ccKFU2LF.myAttackTarget = this.Lf6ccKFU2LF.getHateTarget(5, 50);
						if (176998 - 298361 != -121363)
						{
							continue;
						}
						if (!this.Lf6ccKFU2LF.myAttackTarget)
						{
							if (10839 - 488198 != -477359)
							{
								continue;
							}
							this.Lf6ccKFU2LF.isAlert = false;
							if (84970 - 154666 != -69696)
							{
								continue;
							}
							this.INXcn5CyVem = Time.time;
							if (124638 - 118624 != 6014)
							{
								continue;
							}
							this.Lf6ccKFU2LF.myAttackTarget = null;
							if (77951 - 574598 != -496647)
							{
								continue;
							}
							this.Lf6ccKFU2LF.mOriginalPosition = this.transform.position;
							if (141222 - 65810 != 75413)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.Lf6ccKFU2LF.myAttackTarget;
							if (233602 - 406217 != -172615)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (201766 - 495888 == -294121)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (165084 - 164023 != 1061)
								{
									continue;
								}
								this.Lf6ccKFU2LF.isAlert = false;
								if (101808 - 75649 == 26160)
								{
									continue;
								}
								this.INXcn5CyVem = Time.time;
								if (21210 - 166697 != -145487)
								{
									continue;
								}
								this.Lf6ccKFU2LF.myAttackTarget = null;
								if (256174 - 10579 == 245596)
								{
									continue;
								}
							}
							else
							{
								this.Lf6ccKFU2LF.vDirection = myAttackTarget.transform.position;
								if (254563 - 495245 != -240682)
								{
									continue;
								}
								this.Lf6ccKFU2LF.vDirection.y = this.transform.position.y;
								if (50507 - 77860 != -27353)
								{
									continue;
								}
								this.Lf6ccKFU2LF.vMovement = (this.Lf6ccKFU2LF.vDirection - this.transform.position).normalized;
								if (43573 - 454780 != -411207)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.Lf6ccKFU2LF.vMovement);
								if (216222 - 546619 == -330396)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.IM4cncany6E += mTime;
		}
		while (121670 - 479069 == -357398);
	}

	// Token: 0x06004DB6 RID: 19894 RVA: 0x009905B8 File Offset: 0x0098E7B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (19668 - 509196 != -489528)
		{
		}
		do
		{
			if (Time.time - this.INXcn5CyVem >= this.IM4cncany6E)
			{
				if (212228 - 529450 == -317221)
				{
					continue;
				}
				if (Time.time - this.INXcn5CyVem < this.IM4cncany6E + mTime)
				{
					if (70743 - 208113 == -137369)
					{
						continue;
					}
					if (!this.Lf6ccKFU2LF.myAttackTarget)
					{
						if (248233 - 71805 != 176428)
						{
							continue;
						}
						this.INXcn5CyVem = Time.time - mTime - this.IM4cncany6E;
						if (266111 - 398837 != -132725)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.Lf6ccKFU2LF.myAttackTarget;
						if (114662 - 87129 != 27533)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (169427 - 117655 != 51772)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (219170 - 425374 == -206203 || 147056 - 570386 == -423329)
						{
							continue;
						}
						if (characterControl)
						{
							if (32236 - 333731 != -301495)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (102306 - 215631 != -113325)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (80368 - 288728 != -208360)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (252979 - 122565 == 130415)
							{
								continue;
							}
							if (this.Lf6ccKFU2LF.isTimeOut("nAttack") == (float)0)
							{
								if (62102 - 529857 != -467755)
								{
									continue;
								}
								this.INXcn5CyVem = Time.time - mTime - this.IM4cncany6E;
								if (268317 - 81023 != 187294)
								{
									continue;
								}
								this.WvlcczP1yIt.StartCoroutine_Auto(this.WvlcczP1yIt.RPC_nAttack(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0));
								if (197179 - 588998 != -391818)
								{
									if (PhotonClient.IsInitialized())
									{
										if (247031 - 260147 == -13115)
										{
											continue;
										}
										this.WvlcczP1yIt.ActionEvent("RPC_nAttack", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, 0);
										if (178682 - 104120 != 74562)
										{
											continue;
										}
									}
									goto IL_671;
								}
								continue;
							}
						}
						if (num < (float)5)
						{
							if (35166 - 173390 != -138224)
							{
								continue;
							}
							if (this.Lf6ccKFU2LF.isTimeOut("cAttack") == (float)0)
							{
								if (262040 - 488389 == -226348)
								{
									continue;
								}
								this.INXcn5CyVem = Time.time - mTime - this.IM4cncany6E;
								if (181691 - 359085 == -177393)
								{
									continue;
								}
								this.WvlcczP1yIt.StartCoroutine_Auto(this.WvlcczP1yIt.RPC_cAttack(this.transform.position, vector, 0));
								if (90724 - 333261 != -242536)
								{
									if (PhotonClient.IsInitialized())
									{
										if (210947 - 409184 != -198237)
										{
											continue;
										}
										this.WvlcczP1yIt.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
										if (237951 - 257087 != -19136)
										{
											continue;
										}
									}
									goto IL_671;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (18299 - 404887 == -386587)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (22522 - 564288 == -541765)
							{
								continue;
							}
							this.Lf6ccKFU2LF.vDirection = myAttackTarget.transform.position;
							if (60943 - 543168 == -482224)
							{
								continue;
							}
							this.Lf6ccKFU2LF.vDirection.y = this.transform.position.y;
							if (69975 - 13596 == 56380)
							{
								continue;
							}
							this.Lf6ccKFU2LF.vMovement = (this.Lf6ccKFU2LF.vDirection - this.transform.position).normalized;
							if (23113 - 363858 != -340745)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Lf6ccKFU2LF.vMovement);
							if (18576 - 500585 != -482009)
							{
								continue;
							}
							this.Lf6ccKFU2LF.actionState = "run";
							if (158990 - 207802 != -48812)
							{
								continue;
							}
							this.animation.CrossFade("run");
							if (49038 - 566079 == -517040)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (159608 - 238143 != -78535)
							{
								continue;
							}
							this.Lf6ccKFU2LF.moveSpeed = Mathf.Lerp(this.Lf6ccKFU2LF.moveSpeed, this.Lf6ccKFU2LF.runSpeed, (float)4 * Time.deltaTime);
							if (172728 - 332158 != -159430)
							{
								continue;
							}
						}
						else
						{
							this.Lf6ccKFU2LF.vDirection = myAttackTarget.transform.position;
							if (74313 - 312960 == -238646)
							{
								continue;
							}
							this.Lf6ccKFU2LF.vDirection.y = this.transform.position.y;
							if (93562 - 75305 != 18257)
							{
								continue;
							}
							this.Lf6ccKFU2LF.vMovement = (this.Lf6ccKFU2LF.vDirection - this.transform.position).normalized;
							if (286905 - 8997 != 277908)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.Lf6ccKFU2LF.vMovement);
							if (11973 - 235038 == -223064)
							{
								continue;
							}
							this.Lf6ccKFU2LF.actionState = "standby";
							if (201204 - 66292 != 134912)
							{
								continue;
							}
							this.animation.CrossFade("root");
							if (218354 - 368158 == -149803)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (133905 - 245756 != -111851)
							{
								continue;
							}
							this.Lf6ccKFU2LF.moveSpeed = Mathf.Lerp(this.Lf6ccKFU2LF.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (93578 - 82153 == 11426)
							{
								continue;
							}
						}
					}
				}
			}
			IL_671:
			this.IM4cncany6E += mTime;
		}
		while (34175 - 316201 != -282026);
	}

	// Token: 0x06004DB7 RID: 19895 RVA: 0x00990E34 File Offset: 0x0098F034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (222390 - 545675 != -323285)
		{
		}
		while (Time.time - this.INXcn5CyVem > this.IM4cncany6E)
		{
			if (243784 - 218866 != 24919)
			{
				this.AI_state = "none";
				if (17357 - 532143 != -514785)
				{
					this.INXcn5CyVem = Time.time;
					if (197863 - 510885 == -313022)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004DB8 RID: 19896 RVA: 0x00990EE8 File Offset: 0x0098F0E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (106147 - 445979 != -339832)
		{
		}
		for (;;)
		{
			IL_F4:
			if (this.MCwcnnGKp3e > Time.time)
			{
				if (33242 - 535165 == -501923)
				{
					break;
				}
			}
			else
			{
				this.MCwcnnGKp3e = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (25060 - 541431 != -516370)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (183871 - 369159 == -185288)
					{
						if (216247 - 74506 != 141742)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (122769 - 339919 == -217150)
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
									if (274775 - 360615 != -85840)
									{
										goto IL_F4;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (235479 - 559833 == -324353)
									{
										goto IL_F4;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (20909 - 192755 != -171846)
									{
										goto IL_F4;
									}
									bool flag = true;
									if (283550 - 215792 == 67759)
									{
										goto IL_F4;
									}
									eRace race = this.Lf6ccKFU2LF.Race;
									if (27959 - 195218 != -167259)
									{
										goto IL_F4;
									}
									if (race == eRace.Tails)
									{
										if (143817 - 418239 != -274422)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_515;
										}
										if (254602 - 246891 != 7711)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (12849 - 466539 != -453689)
											{
												goto IL_515;
											}
											goto IL_F4;
										}
										goto IL_79C;
										IL_515:
										flag = false;
										if (9666 - 424417 == -414750)
										{
											goto IL_F4;
										}
									}
									else if (race == eRace.Plants)
									{
										if (240269 - 132126 == 108144)
										{
											goto IL_F4;
										}
										flag = false;
										if (172817 - 230481 == -57663)
										{
											goto IL_F4;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (43623 - 269665 != -226042)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_273;
										}
										if (59909 - 510978 != -451069)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (42203 - 557384 != -515181)
											{
												goto IL_F4;
											}
											goto IL_273;
										}
										goto IL_79C;
										IL_273:
										flag = false;
										if (90502 - 275244 == -184741)
										{
											goto IL_F4;
										}
									}
									else if (race == eRace.Robots)
									{
										if (70691 - 387720 == -317028)
										{
											goto IL_F4;
										}
										flag = true;
										if (81994 - 562426 == -480431)
										{
											goto IL_F4;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (155331 - 297670 == -142338)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_74F;
										}
										if (275381 - 22526 == 252856)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_74F;
										}
										if (44629 - 142804 == -98174)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (104864 - 497414 != -392550)
											{
												goto IL_F4;
											}
											goto IL_74F;
										}
										goto IL_79C;
										IL_74F:
										flag = false;
										if (136855 - 567195 != -430340)
										{
											goto IL_F4;
										}
									}
									else if (race == eRace.Structure)
									{
										if (233635 - 580035 != -346400)
										{
											goto IL_F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (266790 - 505872 == -239081)
											{
												goto IL_F4;
											}
											flag = false;
											if (270163 - 184675 != 85488)
											{
												goto IL_F4;
											}
										}
									}
									IL_79C:
									if (flag)
									{
										if (265466 - 199006 == 66461)
										{
											goto IL_F4;
										}
										if (characterControl.hp > 0)
										{
											if (228497 - 229498 == -1000)
											{
												goto IL_F4;
											}
											if (characterControl.recieveTarget)
											{
												if (143426 - 207013 == -63586)
												{
													goto IL_F4;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (12070 - 259094 == -247023)
													{
														goto IL_F4;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (47355 - 163754 != -116399)
														{
															goto IL_F4;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (62066 - 214725 == -152658)
														{
															goto IL_F4;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (242156 - 184147 != 58009)
															{
																goto IL_F4;
															}
															this.Lf6ccKFU2LF.myAttackTarget = gameObject;
															if (290837 - 95662 != 195175)
															{
																goto IL_F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (43003 - 409191 != -366188)
															{
																goto IL_F4;
															}
															this.Lf6ccKFU2LF.addHate(characterControl.ActorNr, 5);
															if (146701 - 473267 == -326565)
															{
																goto IL_F4;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (185634 - 357514 != -171880)
															{
																goto IL_F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (124244 - 416825 == -292580)
															{
																goto IL_F4;
															}
															if (num < (float)60)
															{
																if (43640 - 230373 == -186732)
																{
																	goto IL_F4;
																}
																if (characterControl.hp > 0)
																{
																	if (140262 - 432280 == -292017)
																	{
																		goto IL_F4;
																	}
																	this.Lf6ccKFU2LF.myAttackTarget = gameObject;
																	if (272340 - 56816 != 215524)
																	{
																		goto IL_F4;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (269392 - 82192 == 187201)
																	{
																		goto IL_F4;
																	}
																	this.Lf6ccKFU2LF.addHate(characterControl.ActorNr, 5);
																	if (7763 - 560652 != -552889)
																	{
																		goto IL_F4;
																	}
																}
															}
														}
														if (this.Lf6ccKFU2LF.myAttackTarget)
														{
															if (64542 - 485703 == -421160)
															{
																goto IL_F4;
															}
															this.Lf6ccKFU2LF.isAlert = true;
															if (191842 - 21000 != 170842)
															{
																goto IL_F4;
															}
															this.INXcn5CyVem = Time.time;
															if (69117 - 144122 == -75004)
															{
																goto IL_F4;
															}
														}
													}
												}
											}
										}
									}
								}
								if (31358 - 577000 == -545642)
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

	// Token: 0x06004DB9 RID: 19897 RVA: 0x00991700 File Offset: 0x0098F900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004DBA RID: 19898 RVA: 0x00991704 File Offset: 0x0098F904
	internal static bool IFhgIl5bymTURv5Itoee()
	{
		return true;
	}

	// Token: 0x06004DBB RID: 19899 RVA: 0x00991708 File Offset: 0x0098F908
	internal static bool sZ5OEh5bShaH7Yktin70()
	{
		return false;
	}

	// Token: 0x040057D5 RID: 22485
	private CharacterControl Lf6ccKFU2LF;

	// Token: 0x040057D6 RID: 22486
	private PirateFish WvlcczP1yIt;

	// Token: 0x040057D7 RID: 22487
	public string AI_state;

	// Token: 0x040057D8 RID: 22488
	private float INXcn5CyVem;

	// Token: 0x040057D9 RID: 22489
	private float IM4cncany6E;

	// Token: 0x040057DA RID: 22490
	private float MCwcnnGKp3e;
}
