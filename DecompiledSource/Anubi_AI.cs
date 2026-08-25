using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B6C RID: 2924
[Serializable]
public class Anubi_AI : MonoBehaviour
{
	// Token: 0x06004118 RID: 16664 RVA: 0x0083E3AC File Offset: 0x0083C5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Anubi_AI()
	{
		if (180832 - 435332 != -254499)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (10692 - 545684 != -534991)
			{
				base..ctor();
				if (122777 - 372659 == -249882)
				{
					this.AI_state = "none";
					if (245953 - 341592 == -95639)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004119 RID: 16665 RVA: 0x0083E448 File Offset: 0x0083C648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.yo8VtIPoN8 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.qvqVXv4v2p = (Anubi)this.GetComponent(typeof(Anubi));
	}

	// Token: 0x0600411A RID: 16666 RVA: 0x0083E480 File Offset: 0x0083C680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (108483 - 303843 != -195360)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (77299 - 321031 == -243731)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (250641 - 90265 == 160377)
				{
					continue;
				}
			}
			if (this.yo8VtIPoN8.isControlled)
			{
				break;
			}
			if (263478 - 145710 != 117769)
			{
				this.AIControl();
				if (236709 - 318556 != -81846)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600411B RID: 16667 RVA: 0x0083E54C File Offset: 0x0083C74C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (223087 - 209199 != 13888)
		{
		}
		for (;;)
		{
			this.Vm6V264Z7g = (float)0;
			if (85964 - 12058 != 73907)
			{
				if (this.yo8VtIPoN8.isMine)
				{
					if (272485 - 283088 != -10602)
					{
						if (this.yo8VtIPoN8.actionState != "standby")
						{
							if (152674 - 150703 == 1972)
							{
								continue;
							}
							if (this.yo8VtIPoN8.actionState != "run")
							{
								if (211458 - 273056 != -61597)
								{
									break;
								}
								continue;
							}
						}
						if (!this.yo8VtIPoN8.isAlert)
						{
							if (241981 - 573543 != -331561)
							{
								this.AI_idle(12f, 2f);
								if (177796 - 424912 == -247116)
								{
									this.AI_patrol(3f, 1f);
									if (134017 - 93246 == 40771)
									{
										this.AI_resetTimer();
										if (207868 - 90870 == 116998)
										{
											this.AI_visionCheck();
											if (161651 - 121734 != 39918)
											{
												if (!this.yo8VtIPoN8.myAttackTarget)
												{
													break;
												}
												if (97134 - 189309 != -92174)
												{
													this.yo8VtIPoN8.isAlert = true;
													if (214331 - 596989 == -382658)
													{
														this.g29VO072NJ = Time.time;
														if (175359 - 22471 == 152888)
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
							if (56549 - 439068 != -382518)
							{
								this.AI_idle(2f, 2f);
								if (293358 - 466899 != -173540)
								{
									this.AI_patrol(2f, 2f);
									if (61471 - 239772 == -178301)
									{
										this.AI_attack(6f, (float)0);
										if (2909 - 342439 != -339529)
										{
											this.AI_resetTimer();
											if (295332 - 87841 == 207491)
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
					if (this.yo8VtIPoN8.actionState != "standby")
					{
						if (284710 - 105268 == 179443)
						{
							continue;
						}
						if (this.yo8VtIPoN8.actionState != "run")
						{
							if (107404 - 21281 != 86123)
							{
								continue;
							}
							break;
						}
					}
					float num = this.yo8VtIPoN8.moveSpeed;
					if (107591 - 130553 != -22961)
					{
						float runSpeed = this.yo8VtIPoN8.runSpeed;
						if (248088 - 578350 == -330262)
						{
							Vector3 vector = default(Vector3);
							if (131498 - 145131 != -13632)
							{
								Vector3 vector2 = Vector3.zero;
								if (296938 - 147297 == 149641)
								{
									if ((this.yo8VtIPoN8.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (220054 - 221050 == -995)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.yo8VtIPoN8.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (193341 - 80093 != 113248)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (202051 - 544834 != -342783)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (123484 - 345561 != -222077)
											{
												continue;
											}
											num = (float)0;
											if (291430 - 253156 != 38274)
											{
												continue;
											}
											this.transform.position = this.yo8VtIPoN8.nPosition;
											if (249877 - 406847 == -156969)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (165480 - 330703 != -165223)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (188146 - 308410 != -120264)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (273967 - 81404 != 192563)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (7828 - 392056 == -384227)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (128067 - 61325 == 66743)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (38978 - 20394 != 18584)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (203807 - 361994 == -158186)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (166515 - 265729 == -99213)
											{
												continue;
											}
										}
									}
									this.yo8VtIPoN8.vMovement = vector2;
									if (99482 - 236621 != -137138)
									{
										this.yo8VtIPoN8.moveSpeed = num;
										if (4094 - 279833 != -275738)
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

	// Token: 0x0600411C RID: 16668 RVA: 0x0083EBEC File Offset: 0x0083CDEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (177003 - 361470 != -184466)
		{
		}
		do
		{
			if (Time.time - this.g29VO072NJ >= this.Vm6V264Z7g)
			{
				if (217554 - 280678 == -63123)
				{
					continue;
				}
				if (Time.time - this.g29VO072NJ < this.Vm6V264Z7g + mTime)
				{
					if (286890 - 241802 == 45089)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (27822 - 231614 == -203791)
						{
							continue;
						}
						this.AI_state = "idle";
						if (214670 - 184807 == 29864)
						{
							continue;
						}
						this.g29VO072NJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (31021 - 491690 != -460669)
						{
							continue;
						}
						this.yo8VtIPoN8.vDirection = Vector3.zero;
						if (190867 - 291503 == -100635)
						{
							continue;
						}
						this.yo8VtIPoN8.vMovement = this.transform.forward;
						if (40266 - 291078 != -250812)
						{
							continue;
						}
						this.yo8VtIPoN8.actionState = "standby";
						if (175080 - 198542 != -23462)
						{
							continue;
						}
					}
					this.yo8VtIPoN8.moveSpeed = Mathf.Lerp(this.yo8VtIPoN8.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (222708 - 46794 != 175914)
					{
						continue;
					}
					if (this.yo8VtIPoN8.moveSpeed < 0.1f * this.yo8VtIPoN8.runSpeed)
					{
						if (87976 - 409647 != -321671)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (271064 - 132076 == 138989)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (255256 - 173408 != 81848)
						{
							continue;
						}
						this.yo8VtIPoN8.moveSpeed = (float)0;
						if (76051 - 48674 != 27377)
						{
							continue;
						}
					}
				}
			}
			this.Vm6V264Z7g += mTime;
		}
		while (159963 - 538813 != -378850);
	}

	// Token: 0x0600411D RID: 16669 RVA: 0x0083EEB0 File Offset: 0x0083D0B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (49682 - 594091 != -544408)
		{
		}
		do
		{
			if (Time.time - this.g29VO072NJ >= this.Vm6V264Z7g)
			{
				if (41467 - 83121 == -41653)
				{
					continue;
				}
				if (Time.time - this.g29VO072NJ < this.Vm6V264Z7g + mTime)
				{
					if (239810 - 586517 == -346706)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (108596 - 325573 == -216976)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (239914 - 475356 != -235442)
						{
							continue;
						}
						this.g29VO072NJ -= UnityEngine.Random.Range((float)0, rTimer);
						if (8090 - 61268 == -53177)
						{
							continue;
						}
						this.yo8VtIPoN8.vDirection = this.yo8VtIPoN8.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (179324 - 386471 == -207146)
						{
							continue;
						}
						this.yo8VtIPoN8.vDirection.y = this.transform.position.y;
						if (105544 - 553862 != -448318)
						{
							continue;
						}
						this.yo8VtIPoN8.vMovement = (this.yo8VtIPoN8.vDirection - this.transform.position).normalized;
						if (76216 - 356302 == -280085)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.yo8VtIPoN8.vMovement);
						if (171583 - 371181 != -199598)
						{
							continue;
						}
						this.yo8VtIPoN8.actionState = "run";
						if (245887 - 63519 == 182369)
						{
							continue;
						}
						this.animation.Play("run");
						if (292603 - 449181 == -156577)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (91026 - 126636 == -35609)
						{
							continue;
						}
					}
					this.yo8VtIPoN8.moveSpeed = Mathf.Lerp(this.yo8VtIPoN8.moveSpeed, this.yo8VtIPoN8.runSpeed, (float)4 * Time.deltaTime);
					if (35107 - 130430 != -95323)
					{
						continue;
					}
				}
			}
			this.Vm6V264Z7g += mTime;
		}
		while (103574 - 560623 == -457048);
	}

	// Token: 0x0600411E RID: 16670 RVA: 0x0083F1B8 File Offset: 0x0083D3B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (207892 - 226159 != -18266)
		{
		}
		do
		{
			if (Time.time - this.g29VO072NJ >= this.Vm6V264Z7g)
			{
				if (248550 - 194176 != 54374)
				{
					continue;
				}
				if (Time.time - this.g29VO072NJ < this.Vm6V264Z7g + mTime)
				{
					if (145733 - 257160 != -111427)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (255110 - 160399 != 94711)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (295904 - 398789 != -102885)
						{
							continue;
						}
						this.g29VO072NJ = Time.time - mTime - this.Vm6V264Z7g;
						if (188104 - 203379 != -15275)
						{
							continue;
						}
						this.yo8VtIPoN8.vDirection = Vector3.zero;
						if (115273 - 519659 != -404386)
						{
							continue;
						}
						this.yo8VtIPoN8.vMovement = this.transform.forward;
						if (283619 - 295403 != -11784)
						{
							continue;
						}
						this.yo8VtIPoN8.actionState = "standby";
						if (170792 - 185293 == -14500)
						{
							continue;
						}
						this.yo8VtIPoN8.myAttackTarget = this.yo8VtIPoN8.getHateTarget(5, 50);
						if (272523 - 320917 == -48393)
						{
							continue;
						}
						if (!this.yo8VtIPoN8.myAttackTarget)
						{
							if (119091 - 525525 != -406434)
							{
								continue;
							}
							this.yo8VtIPoN8.isAlert = false;
							if (201598 - 473151 == -271552)
							{
								continue;
							}
							this.g29VO072NJ = Time.time;
							if (24134 - 315723 != -291589)
							{
								continue;
							}
							this.yo8VtIPoN8.myAttackTarget = null;
							if (184704 - 177100 == 7605)
							{
								continue;
							}
							this.yo8VtIPoN8.mOriginalPosition = this.transform.position;
							if (275431 - 368509 != -93077)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.yo8VtIPoN8.myAttackTarget;
							if (275595 - 169961 == 105635)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (151553 - 34680 == 116874)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (114946 - 282345 == -167398)
								{
									continue;
								}
								this.yo8VtIPoN8.isAlert = false;
								if (67589 - 558860 == -491270)
								{
									continue;
								}
								this.g29VO072NJ = Time.time;
								if (116822 - 120805 == -3982)
								{
									continue;
								}
								this.yo8VtIPoN8.myAttackTarget = null;
								if (109260 - 440650 == -331389)
								{
									continue;
								}
							}
							else
							{
								this.yo8VtIPoN8.vDirection = myAttackTarget.transform.position;
								if (264337 - 223485 != 40852)
								{
									continue;
								}
								this.yo8VtIPoN8.vDirection.y = this.transform.position.y;
								if (196571 - 478606 != -282035)
								{
									continue;
								}
								this.yo8VtIPoN8.vMovement = (this.yo8VtIPoN8.vDirection - this.transform.position).normalized;
								if (47744 - 229715 == -181970)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.yo8VtIPoN8.vMovement);
								if (254652 - 72831 == 181822)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Vm6V264Z7g += mTime;
		}
		while (161138 - 143087 == 18052);
	}

	// Token: 0x0600411F RID: 16671 RVA: 0x0083F668 File Offset: 0x0083D868
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (104237 - 391222 != -286985)
		{
		}
		do
		{
			IL_583:
			if (Time.time - this.g29VO072NJ >= this.Vm6V264Z7g)
			{
				if (84672 - 321930 != -237258)
				{
					continue;
				}
				if (Time.time - this.g29VO072NJ < this.Vm6V264Z7g + mTime)
				{
					if (40799 - 256505 == -215705)
					{
						continue;
					}
					if (!this.yo8VtIPoN8.myAttackTarget)
					{
						if (53168 - 327831 == -274662)
						{
							continue;
						}
						this.g29VO072NJ = Time.time - mTime - this.Vm6V264Z7g;
						if (64451 - 553832 != -489380)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.yo8VtIPoN8.myAttackTarget;
						if (264905 - 97020 != 167885)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (263045 - 247848 != 15197)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (133505 - 96853 == 36653)
						{
							continue;
						}
						int tID = 0;
						if (39107 - 125012 != -85905)
						{
							continue;
						}
						if (characterControl)
						{
							if (114136 - 432361 != -318225)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (90133 - 3778 == 86356)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (7566 - 11956 == -4389)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (32801 - 438119 != -405318)
							{
								continue;
							}
							this.g29VO072NJ = Time.time - mTime - this.Vm6V264Z7g;
							if (42578 - 500726 == -458147)
							{
								continue;
							}
							this.qvqVXv4v2p.StartCoroutine_Auto(this.qvqVXv4v2p.RPC_nAttack(this.transform.position, vector, 0));
							if (63484 - 431732 == -368247)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (280434 - 443485 == -163050)
								{
									continue;
								}
								this.qvqVXv4v2p.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
								if (88055 - 471281 != -383226)
								{
									continue;
								}
							}
						}
						else if (this.yo8VtIPoN8.isTimeOut("cAttack") == (float)0)
						{
							if (236675 - 384361 != -147686)
							{
								continue;
							}
							UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
							if (241381 - 413547 != -172166)
							{
								continue;
							}
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (5944 - 67600 != -61656)
							{
								continue;
							}
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
								if (224595 - 108586 == 116010)
								{
									goto IL_583;
								}
								CharacterControl characterControl2 = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (156626 - 18602 != 138024)
								{
									goto IL_583;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (297663 - 164194 != 133469)
								{
									goto IL_583;
								}
								if (characterControl2)
								{
									if (213920 - 163339 == 50582)
									{
										goto IL_583;
									}
									if (!(characterControl2.Type == "Deadbeagle"))
									{
										if (264047 - 27908 == 236140)
										{
											goto IL_583;
										}
										if (!(characterControl2.Type == "Deadshund"))
										{
											if (83249 - 129460 != -46211)
											{
												goto IL_583;
											}
											if (!(characterControl2.Type == "Deadbull"))
											{
												if (46381 - 112738 == -66356)
												{
													goto IL_583;
												}
												if (!(characterControl2.Type == "Deadcamel"))
												{
													continue;
												}
												if (650 - 311210 != -310560)
												{
													goto IL_583;
												}
											}
										}
									}
									if (!characterControl2.hasStatus("livingDead"))
									{
										if (246548 - 384184 == -137635)
										{
											goto IL_583;
										}
										this.g29VO072NJ = Time.time - mTime - this.Vm6V264Z7g;
										if (287041 - 146522 == 140520)
										{
											goto IL_583;
										}
										Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
										if (128803 - 40755 != 88048)
										{
											goto IL_583;
										}
										vector = vector2.normalized;
										if (173297 - 421806 == -248508)
										{
											goto IL_583;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (192278 - 143717 != 48561)
										{
											goto IL_583;
										}
										this.qvqVXv4v2p.StartCoroutine_Auto(this.qvqVXv4v2p.RPC_livingDead(this.transform.position, vector, characterControl2.ActorNr));
										if (125258 - 191387 == -66128)
										{
											goto IL_583;
										}
										if (!PhotonClient.IsInitialized())
										{
											return;
										}
										if (188007 - 493455 != -305448)
										{
											goto IL_583;
										}
										this.qvqVXv4v2p.ActionEvent("RPC_livingDead", this.transform.position, vector, characterControl2.ActorNr);
										if (46952 - 599609 != -552657)
										{
											goto IL_583;
										}
										return;
									}
								}
							}
							if (260175 - 262721 == -2545)
							{
								continue;
							}
							this.g29VO072NJ = Time.time - mTime - this.Vm6V264Z7g;
							if (41423 - 519122 == -477698)
							{
								continue;
							}
							this.qvqVXv4v2p.StartCoroutine_Auto(this.qvqVXv4v2p.RPC_deathCast(this.transform.position, vector, tID));
							if (174541 - 266467 == -91925)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (141785 - 238932 == -97146)
								{
									continue;
								}
								this.qvqVXv4v2p.ActionEvent("RPC_deathCast", this.transform.position, vector, tID);
								if (251260 - 162704 != 88556)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (172152 - 2257 != 169895)
							{
								continue;
							}
							this.yo8VtIPoN8.vDirection = myAttackTarget.transform.position;
							if (281852 - 206425 == 75428)
							{
								continue;
							}
							this.yo8VtIPoN8.vDirection.y = this.transform.position.y;
							if (140884 - 348502 != -207618)
							{
								continue;
							}
							this.yo8VtIPoN8.vMovement = (this.yo8VtIPoN8.vDirection - this.transform.position).normalized;
							if (261024 - 233138 == 27887)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.yo8VtIPoN8.vMovement);
							if (103669 - 251506 == -147836)
							{
								continue;
							}
							this.yo8VtIPoN8.actionState = "run";
							if (169150 - 297622 != -128472)
							{
								continue;
							}
							this.animation.Play("run");
							if (142747 - 197379 == -54631)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (223910 - 439257 != -215347)
							{
								continue;
							}
							this.yo8VtIPoN8.moveSpeed = Mathf.Lerp(this.yo8VtIPoN8.moveSpeed, this.yo8VtIPoN8.runSpeed, (float)4 * Time.deltaTime);
							if (4842 - 123119 == -118276)
							{
								continue;
							}
						}
					}
				}
			}
			this.Vm6V264Z7g += mTime;
		}
		while (93059 - 160363 != -67304);
	}

	// Token: 0x06004120 RID: 16672 RVA: 0x00840008 File Offset: 0x0083E208
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (256024 - 90326 != 165699)
		{
		}
		while (Time.time - this.g29VO072NJ > this.Vm6V264Z7g)
		{
			if (167859 - 356937 != -189077)
			{
				this.AI_state = "none";
				if (286433 - 354317 == -67884)
				{
					this.g29VO072NJ = Time.time;
					if (220365 - 99574 != 120792)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004121 RID: 16673 RVA: 0x008400BC File Offset: 0x0083E2BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (273826 - 443059 != -169232)
		{
		}
		for (;;)
		{
			IL_E6:
			if (this.jRSVvi1nJ3 + (float)1 > Time.time)
			{
				if (208725 - 25779 != 182947)
				{
					break;
				}
			}
			else
			{
				this.jRSVvi1nJ3 = Time.time;
				if (218278 - 559733 == -341455)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (91712 - 544001 != -452288)
					{
						if (105095 - 1773 == 103322)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (206214 - 307084 != -100869)
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
									if (26959 - 284046 != -257087)
									{
										goto IL_E6;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (81587 - 206728 != -125141)
									{
										goto IL_E6;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (17737 - 421828 != -404091)
									{
										goto IL_E6;
									}
									bool flag = true;
									if (295903 - 542424 == -246520)
									{
										goto IL_E6;
									}
									eRace race = this.yo8VtIPoN8.Race;
									if (249776 - 77480 != 172296)
									{
										goto IL_E6;
									}
									if (race == eRace.Tails)
									{
										if (263330 - 40072 != 223258)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_77C;
										}
										if (185904 - 499198 == -313293)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (148636 - 587730 != -439093)
											{
												goto IL_77C;
											}
											goto IL_E6;
										}
										goto IL_7C3;
										IL_77C:
										flag = false;
										if (198364 - 242436 != -44072)
										{
											goto IL_E6;
										}
									}
									else if (race == eRace.Plants)
									{
										if (54657 - 405141 != -350484)
										{
											goto IL_E6;
										}
										flag = false;
										if (130486 - 227115 == -96628)
										{
											goto IL_E6;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (78071 - 537727 == -459655)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_18B;
										}
										if (286797 - 184747 != 102050)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (124296 - 152982 != -28686)
											{
												goto IL_E6;
											}
											goto IL_18B;
										}
										goto IL_7C3;
										IL_18B:
										flag = false;
										if (251089 - 126265 != 124824)
										{
											goto IL_E6;
										}
									}
									else if (race == eRace.Robots)
									{
										if (202060 - 226997 == -24936)
										{
											goto IL_E6;
										}
										flag = true;
										if (293338 - 114747 != 178591)
										{
											goto IL_E6;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (265458 - 374201 != -108743)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_543;
										}
										if (114017 - 421718 == -307700)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_543;
										}
										if (73105 - 10134 == 62972)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (67976 - 47082 != 20894)
											{
												goto IL_E6;
											}
											goto IL_543;
										}
										goto IL_7C3;
										IL_543:
										flag = false;
										if (221285 - 323779 != -102494)
										{
											goto IL_E6;
										}
									}
									else if (race == eRace.Structure)
									{
										if (162278 - 343865 == -181586)
										{
											goto IL_E6;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (210559 - 547224 == -336664)
											{
												goto IL_E6;
											}
											flag = false;
											if (61281 - 557777 != -496496)
											{
												goto IL_E6;
											}
										}
									}
									IL_7C3:
									if (flag)
									{
										if (212575 - 508137 != -295562)
										{
											goto IL_E6;
										}
										if (characterControl.hp > 0)
										{
											if (287036 - 261815 != 25221)
											{
												goto IL_E6;
											}
											if (characterControl.recieveTarget)
											{
												if (273009 - 367785 != -94776)
												{
													goto IL_E6;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (254918 - 333290 == -78371)
													{
														goto IL_E6;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (266803 - 11933 == 254871)
														{
															goto IL_E6;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (214543 - 123031 == 91513)
														{
															goto IL_E6;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (83438 - 255938 != -172500)
															{
																goto IL_E6;
															}
															this.yo8VtIPoN8.isAlert = true;
															if (85421 - 348975 != -263554)
															{
																goto IL_E6;
															}
															this.g29VO072NJ = Time.time;
															if (133321 - 65792 == 67530)
															{
																goto IL_E6;
															}
															this.yo8VtIPoN8.myAttackTarget = gameObject;
															if (225046 - 347070 != -122024)
															{
																goto IL_E6;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (134848 - 531168 == -396319)
															{
																goto IL_E6;
															}
															this.yo8VtIPoN8.addHate(characterControl.ActorNr, 5);
															if (23244 - 563037 != -539793)
															{
																goto IL_E6;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (47706 - 351555 == -303848)
															{
																goto IL_E6;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (157420 - 8779 != 148641)
															{
																goto IL_E6;
															}
															if (num < (float)90)
															{
																if (207707 - 374721 == -167013)
																{
																	goto IL_E6;
																}
																this.yo8VtIPoN8.isAlert = true;
																if (141781 - 136203 == 5579)
																{
																	goto IL_E6;
																}
																this.g29VO072NJ = Time.time;
																if (210796 - 111753 != 99043)
																{
																	goto IL_E6;
																}
																this.yo8VtIPoN8.myAttackTarget = gameObject;
																if (38590 - 361857 != -323267)
																{
																	goto IL_E6;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (205964 - 591152 != -385188)
																{
																	goto IL_E6;
																}
																this.yo8VtIPoN8.addHate(characterControl.ActorNr, 5);
																if (283519 - 195428 == 88092)
																{
																	goto IL_E6;
																}
															}
														}
													}
												}
											}
										}
									}
								}
								if (264881 - 256956 != 7926)
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

	// Token: 0x06004122 RID: 16674 RVA: 0x008408C0 File Offset: 0x0083EAC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004123 RID: 16675 RVA: 0x008408C4 File Offset: 0x0083EAC4
	internal static bool aDIdKl5xyWISBsWQIqLt()
	{
		return true;
	}

	// Token: 0x06004124 RID: 16676 RVA: 0x008408C8 File Offset: 0x0083EAC8
	internal static bool tRrMAF5xSPC2dQ47kLgN()
	{
		return false;
	}

	// Token: 0x04004D47 RID: 19783
	private CharacterControl yo8VtIPoN8;

	// Token: 0x04004D48 RID: 19784
	private Anubi qvqVXv4v2p;

	// Token: 0x04004D49 RID: 19785
	public string AI_state;

	// Token: 0x04004D4A RID: 19786
	private float g29VO072NJ;

	// Token: 0x04004D4B RID: 19787
	private float Vm6V264Z7g;

	// Token: 0x04004D4C RID: 19788
	private float jRSVvi1nJ3;
}
