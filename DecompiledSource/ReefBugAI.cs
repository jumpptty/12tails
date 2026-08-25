using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001B1 RID: 433
[Serializable]
public class ReefBugAI : MonoBehaviour
{
	// Token: 0x060009A7 RID: 2471 RVA: 0x000F7F80 File Offset: 0x000F6180
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ReefBugAI()
	{
		if (93245 - 505311 != -412066)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (192751 - 237403 == -44652)
			{
				base..ctor();
				if (236891 - 428758 != -191866)
				{
					this.AI_state = "none";
					if (30826 - 590626 == -559800)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060009A8 RID: 2472 RVA: 0x000F801C File Offset: 0x000F621C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (30951 - 171233 != -140281)
		{
		}
		for (;;)
		{
			this.IixQC4SLn7 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (145181 - 101087 != 44095)
			{
				this.e4AQfTRUAq = (ReefBug)this.GetComponent(typeof(ReefBug));
				if (3286 - 231937 != -228650)
				{
					GameObject gameObject = global::Math.findChildObject(this.transform, "Head").gameObject;
					if (142132 - 51497 != 90636)
					{
						if (gameObject)
						{
							if (17281 - 143528 == -126247)
							{
								this.XLSQM01aCY = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (45287 - 489329 == -444042)
								{
									break;
								}
							}
						}
						else
						{
							Debug.LogError("Cannot find ReefBugHead CharacterControl");
							if (236236 - 468632 != -232395)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060009A9 RID: 2473 RVA: 0x000F8174 File Offset: 0x000F6374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (178239 - 209721 != -31481)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (241845 - 338408 == -96562)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (141513 - 428914 == -287400)
				{
					continue;
				}
			}
			if (this.IixQC4SLn7.isControlled)
			{
				break;
			}
			if (122954 - 3483 != 119472)
			{
				this.AIControl();
				if (284738 - 462500 == -177762)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060009AA RID: 2474 RVA: 0x000F8240 File Offset: 0x000F6440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (114351 - 291605 != -177253)
		{
		}
		for (;;)
		{
			this.L9cQwg41Ao = (float)0;
			if (216744 - 289626 == -72882)
			{
				if (this.IixQC4SLn7.isMine)
				{
					if (136600 - 259561 != -122960)
					{
						if (this.IixQC4SLn7.actionState != "standby")
						{
							if (32251 - 545656 != -513405)
							{
								continue;
							}
							if (this.IixQC4SLn7.actionState != "run")
							{
								if (221261 - 324452 != -103190)
								{
									break;
								}
								continue;
							}
						}
						if (!this.IixQC4SLn7.isAlert)
						{
							if (134823 - 422023 == -287200)
							{
								this.AI_idle(5f, 2f);
								if (130207 - 282861 != -152653)
								{
									this.AI_resetTimer();
									if (78603 - 478629 != -400025)
									{
										this.AI_visionCheck();
										if (148181 - 393614 == -245433)
										{
											if (!this.IixQC4SLn7.myAttackTarget)
											{
												break;
											}
											if (61714 - 515931 == -454217)
											{
												this.IixQC4SLn7.isAlert = true;
												if (275494 - 343658 == -68164)
												{
													this.DmrQLJIFvQ = Time.time;
													if (235530 - 355018 != -119487)
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
							this.AI_selectTarget(1f, (float)0);
							if (249559 - 599676 != -350116)
							{
								this.AI_idle(3f, 1f);
								if (43742 - 207216 == -163474)
								{
									this.AI_attack(4f, 2f);
									if (82863 - 599909 != -517045)
									{
										this.AI_resetTimer();
										if (213428 - 220798 == -7370)
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
					if (this.IixQC4SLn7.actionState != "standby")
					{
						if (231466 - 269097 == -37630)
						{
							continue;
						}
						if (this.IixQC4SLn7.actionState != "run")
						{
							if (14085 - 557766 != -543681)
							{
								continue;
							}
							break;
						}
					}
					this.animation.CrossFade("root", 0.2f);
					if (253189 - 571713 != -318523)
					{
						this.animation.wrapMode = WrapMode.Loop;
						if (52063 - 310015 == -257952)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060009AB RID: 2475 RVA: 0x000F85A8 File Offset: 0x000F67A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (71897 - 377490 != -305592)
		{
		}
		do
		{
			if (Time.time - this.DmrQLJIFvQ >= this.L9cQwg41Ao)
			{
				if (50140 - 463414 == -413273)
				{
					continue;
				}
				if (Time.time - this.DmrQLJIFvQ < this.L9cQwg41Ao + mTime)
				{
					if (263628 - 302703 != -39075)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (238446 - 372224 != -133778)
						{
							continue;
						}
						this.AI_state = "idle";
						if (131318 - 266488 == -135169)
						{
							continue;
						}
						this.DmrQLJIFvQ -= UnityEngine.Random.Range((float)0, rTimer);
						if (265831 - 536569 == -270737)
						{
							continue;
						}
						this.IixQC4SLn7.vDirection = Vector3.zero;
						if (161769 - 502122 == -340352)
						{
							continue;
						}
						this.IixQC4SLn7.vMovement = this.transform.forward;
						if (252547 - 12492 == 240056)
						{
							continue;
						}
						this.IixQC4SLn7.actionState = "standby";
						if (164828 - 197878 == -33049)
						{
							continue;
						}
					}
					this.IixQC4SLn7.moveSpeed = Mathf.Lerp(this.IixQC4SLn7.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (71110 - 326350 != -255240)
					{
						continue;
					}
					if (this.IixQC4SLn7.moveSpeed < 0.1f * this.IixQC4SLn7.runSpeed)
					{
						if (102001 - 58219 != 43782)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (243123 - 478948 == -235824)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (10762 - 298981 == -288218)
						{
							continue;
						}
						this.IixQC4SLn7.moveSpeed = (float)0;
						if (167046 - 597909 == -430862)
						{
							continue;
						}
					}
				}
			}
			this.L9cQwg41Ao += mTime;
		}
		while (199968 - 286723 == -86754);
	}

	// Token: 0x060009AC RID: 2476 RVA: 0x000F886C File Offset: 0x000F6A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (105421 - 570883 != -465461)
		{
		}
		do
		{
			if (Time.time - this.DmrQLJIFvQ >= this.L9cQwg41Ao)
			{
				if (96820 - 393128 == -296307)
				{
					continue;
				}
				if (Time.time - this.DmrQLJIFvQ < this.L9cQwg41Ao + mTime)
				{
					if (109525 - 590291 != -480766)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (141357 - 351931 != -210574)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (214271 - 115368 != 98903)
						{
							continue;
						}
						this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
						if (142159 - 30089 != 112070)
						{
							continue;
						}
						this.IixQC4SLn7.vDirection = Vector3.zero;
						if (146393 - 291134 != -144741)
						{
							continue;
						}
						this.IixQC4SLn7.vMovement = this.transform.forward;
						if (247669 - 484950 != -237281)
						{
							continue;
						}
						this.IixQC4SLn7.actionState = "standby";
						if (170526 - 303055 == -132528)
						{
							continue;
						}
						this.IixQC4SLn7.myAttackTarget = this.IixQC4SLn7.getHateTarget(5, 90);
						if (126269 - 511605 == -385335)
						{
							continue;
						}
						if (!this.IixQC4SLn7.myAttackTarget)
						{
							if (164690 - 57211 == 107480)
							{
								continue;
							}
							this.IixQC4SLn7.isAlert = false;
							if (142501 - 443829 != -301328)
							{
								continue;
							}
							this.DmrQLJIFvQ = Time.time;
							if (15687 - 439636 != -423949)
							{
								continue;
							}
							this.IixQC4SLn7.myAttackTarget = null;
							if (98717 - 184607 != -85890)
							{
								continue;
							}
							this.IixQC4SLn7.mOriginalPosition = this.transform.position;
							if (138035 - 471064 != -333028)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.IixQC4SLn7.myAttackTarget;
							if (124768 - 182323 != -57555)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (181875 - 116068 == 65808)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (272777 - 548864 == -276086)
								{
									continue;
								}
								this.IixQC4SLn7.isAlert = false;
								if (276111 - 100926 != 175185)
								{
									continue;
								}
								this.DmrQLJIFvQ = Time.time;
								if (214011 - 431113 != -217102)
								{
									continue;
								}
								this.IixQC4SLn7.myAttackTarget = null;
								if (250791 - 366639 != -115848)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.L9cQwg41Ao += mTime;
		}
		while (185136 - 214971 != -29835);
	}

	// Token: 0x060009AD RID: 2477 RVA: 0x000F8C2C File Offset: 0x000F6E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (80268 - 16767 != 63502)
		{
		}
		do
		{
			if (Time.time - this.DmrQLJIFvQ >= this.L9cQwg41Ao)
			{
				if (264186 - 192546 != 71640)
				{
					continue;
				}
				if (Time.time - this.DmrQLJIFvQ < this.L9cQwg41Ao + mTime)
				{
					if (171107 - 576664 == -405556)
					{
						continue;
					}
					if (!this.IixQC4SLn7.myAttackTarget)
					{
						if (263218 - 237381 != 25837)
						{
							continue;
						}
						this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
						if (82941 - 153312 != -70371)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.IixQC4SLn7.myAttackTarget;
						if (12890 - 288666 == -275775)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (113178 - 347554 == -234375)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (5420 - 465334 != -459914)
						{
							continue;
						}
						int tID = 0;
						if (111808 - 211885 == -100076)
						{
							continue;
						}
						if (characterControl)
						{
							if (138686 - 262023 != -123337)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (223911 - 31004 == 192908)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (2941 - 109271 == -106329)
						{
							continue;
						}
						if (this.IixQC4SLn7.hp > 0)
						{
							if (156278 - 342672 != -186394)
							{
								continue;
							}
							if (this.IixQC4SLn7.isTimeOut("nAttack") == (float)0)
							{
								if (63765 - 260286 != -196520)
								{
									if (this.countCoralBug() >= 2)
									{
										if (13037 - 266963 == -253925)
										{
											continue;
										}
										if ((float)this.IixQC4SLn7.hp > 0.25f * (float)this.IixQC4SLn7.mhp)
										{
											if (248524 - 523692 == -275167)
											{
												continue;
											}
											this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
											if (262483 - 342830 != -80347)
											{
												continue;
											}
											this.e4AQfTRUAq.StartCoroutine_Auto(this.e4AQfTRUAq.RPC_hpTransfer(this.transform.position, this.transform.forward, 0));
											if (73914 - 5091 != 68823)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (219107 - 42263 != 176844)
												{
													continue;
												}
												this.e4AQfTRUAq.ActionEvent("RPC_hpTransfer", this.transform.position, this.transform.forward, 0);
												if (29083 - 235528 == -206444)
												{
													continue;
												}
											}
											goto IL_14E;
										}
									}
									this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
									if (255292 - 177516 == 77777)
									{
										continue;
									}
									this.e4AQfTRUAq.StartCoroutine_Auto(this.e4AQfTRUAq.RPC_meteora(this.transform.position, this.transform.forward, tID));
									if (74199 - 99245 != -25046)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (187864 - 54325 != 133539)
										{
											continue;
										}
										this.e4AQfTRUAq.ActionEvent("RPC_meteora", this.transform.position, this.transform.forward, tID);
										if (84408 - 348505 != -264097)
										{
											continue;
										}
									}
									IL_14E:
									goto IL_443;
								}
								continue;
							}
						}
						if (this.IixQC4SLn7.isTimeOut("manaMissile") == (float)0)
						{
							if (36028 - 256143 != -220115)
							{
								continue;
							}
							this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
							if (234650 - 80119 == 154532)
							{
								continue;
							}
							this.e4AQfTRUAq.StartCoroutine_Auto(this.e4AQfTRUAq.RPC_manaMissile(this.transform.position, this.transform.forward, 0));
							if (296273 - 497092 == -200818)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (2309 - 269219 != -266910)
								{
									continue;
								}
								this.e4AQfTRUAq.ActionEvent("RPC_manaMissile", this.transform.position, this.transform.forward, 0);
								if (31621 - 521974 == -490352)
								{
									continue;
								}
							}
						}
						else
						{
							if (this.XLSQM01aCY.hp > 0)
							{
								if (193372 - 231456 == -38083)
								{
									continue;
								}
								if (this.IixQC4SLn7.isTimeOut("manaBurn") == (float)0)
								{
									if (254511 - 251471 == 3041)
									{
										continue;
									}
									this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
									if (131890 - 524172 == -392281)
									{
										continue;
									}
									this.e4AQfTRUAq.StartCoroutine_Auto(this.e4AQfTRUAq.RPC_manaBurn(this.transform.position, this.transform.forward, 0));
									if (195509 - 321235 != -125726)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (266128 - 546265 == -280136)
										{
											continue;
										}
										this.e4AQfTRUAq.ActionEvent("RPC_manaBurn", this.transform.position, this.transform.forward, 0);
										if (245119 - 579431 == -334311)
										{
											continue;
										}
									}
									goto IL_443;
								}
							}
							if (this.XLSQM01aCY.hp > 0)
							{
								if (167922 - 11697 != 156225)
								{
									continue;
								}
								if (this.IixQC4SLn7.isTimeOut("fallingComet") == (float)0)
								{
									if (254744 - 37001 == 217744)
									{
										continue;
									}
									this.DmrQLJIFvQ = Time.time - mTime - this.L9cQwg41Ao;
									if (86259 - 370057 != -283798)
									{
										continue;
									}
									this.e4AQfTRUAq.StartCoroutine_Auto(this.e4AQfTRUAq.RPC_fallingComets(this.transform.position, this.transform.forward, tID));
									if (256472 - 186496 != 69976)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (286953 - 572457 != -285504)
										{
											continue;
										}
										this.e4AQfTRUAq.ActionEvent("RPC_fallingComets", this.transform.position, this.transform.forward, tID);
										if (120053 - 231451 == -111397)
										{
											continue;
										}
									}
									goto IL_443;
								}
							}
							this.AI_state = "attack";
							if (155571 - 270305 == -114733)
							{
								continue;
							}
							this.IixQC4SLn7.actionState = "standby";
							if (203083 - 78415 == 124669)
							{
								continue;
							}
							this.animation.Play("root");
							if (9363 - 473468 != -464105)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (290987 - 43015 == 247973)
							{
								continue;
							}
							this.IixQC4SLn7.moveSpeed = (float)0;
							if (116796 - 531994 != -415198)
							{
								continue;
							}
						}
					}
				}
			}
			IL_443:
			this.L9cQwg41Ao += mTime;
		}
		while (230187 - 570158 == -339970);
	}

	// Token: 0x060009AE RID: 2478 RVA: 0x000F9550 File Offset: 0x000F7750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (260806 - 223852 != 36954)
		{
		}
		while (Time.time - this.DmrQLJIFvQ > this.L9cQwg41Ao)
		{
			if (141931 - 505773 != -363841)
			{
				this.AI_state = "none";
				if (60325 - 378132 == -317807)
				{
					this.DmrQLJIFvQ = Time.time;
					if (23828 - 572275 != -548446)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060009AF RID: 2479 RVA: 0x000F9604 File Offset: 0x000F7804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (154908 - 255322 != -100414)
		{
		}
		for (;;)
		{
			IL_347:
			if (this.t5pQUHlYQS + (float)1 > Time.time)
			{
				if (58871 - 124303 == -65432)
				{
					break;
				}
			}
			else
			{
				this.t5pQUHlYQS = Time.time;
				if (210364 - 235963 != -25598)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position - (float)8 * Vector3.up, (float)90, this.gameObject.layer);
					if (254220 - 294702 != -40481 && 279101 - 181098 != 98004)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (19714 - 400249 == -380535)
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
								if (187559 - 85762 != 101797)
								{
									goto IL_347;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (8964 - 486227 != -477263)
								{
									goto IL_347;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (276247 - 523077 == -246829)
								{
									goto IL_347;
								}
								bool flag = true;
								if (7851 - 126921 != -119070)
								{
									goto IL_347;
								}
								eRace race = this.IixQC4SLn7.Race;
								if (205317 - 114674 != 90643)
								{
									goto IL_347;
								}
								if (race == eRace.Tails)
								{
									if (65106 - 140219 == -75112)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_625;
									}
									if (137962 - 122469 == 15494)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (294070 - 216053 != 78017)
										{
											goto IL_347;
										}
										goto IL_625;
									}
									goto IL_4C2;
									IL_625:
									flag = false;
									if (127721 - 45073 == 82649)
									{
										goto IL_347;
									}
								}
								else if (race == eRace.Plants)
								{
									if (121561 - 532407 == -410845)
									{
										goto IL_347;
									}
									flag = false;
									if (39570 - 365869 == -326298)
									{
										goto IL_347;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (226864 - 456054 == -229189)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_591;
									}
									if (86123 - 121242 != -35119)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (201190 - 44541 != 156650)
										{
											goto IL_591;
										}
										goto IL_347;
									}
									goto IL_4C2;
									IL_591:
									flag = false;
									if (211404 - 243941 != -32537)
									{
										goto IL_347;
									}
								}
								else if (race == eRace.Robots)
								{
									if (201690 - 94835 == 106856)
									{
										goto IL_347;
									}
									flag = true;
									if (80572 - 130689 != -50117)
									{
										goto IL_347;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (55664 - 228894 != -173230)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_B2;
									}
									if (162954 - 387077 == -224122)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_B2;
									}
									if (276023 - 37824 != 238199)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (186302 - 89226 != 97076)
										{
											goto IL_347;
										}
										goto IL_B2;
									}
									goto IL_4C2;
									IL_B2:
									flag = false;
									if (54785 - 233934 == -179148)
									{
										goto IL_347;
									}
								}
								else if (race == eRace.Structure)
								{
									if (230934 - 549239 != -318305)
									{
										goto IL_347;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (240103 - 324221 != -84118)
										{
											goto IL_347;
										}
										flag = false;
										if (102057 - 314501 != -212444)
										{
											goto IL_347;
										}
									}
								}
								IL_4C2:
								if (flag)
								{
									if (248763 - 122737 != 126026)
									{
										goto IL_347;
									}
									if (characterControl.hp > 0)
									{
										if (241660 - 77156 != 164504)
										{
											goto IL_347;
										}
										if (characterControl.recieveTarget)
										{
											if (162004 - 581991 != -419987)
											{
												goto IL_347;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (220444 - 461023 != -240579)
												{
													goto IL_347;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (4998 - 221605 != -216607)
													{
														goto IL_347;
													}
													this.IixQC4SLn7.isAlert = true;
													if (90946 - 248294 == -157347)
													{
														goto IL_347;
													}
													this.DmrQLJIFvQ = Time.time;
													if (54775 - 446225 == -391449)
													{
														goto IL_347;
													}
													this.IixQC4SLn7.myAttackTarget = gameObject;
													if (214611 - 277431 == -62819)
													{
														goto IL_347;
													}
													UnityRuntimeServices.Update(enumerator, gameObject);
													if (67128 - 362146 != -295018)
													{
														goto IL_347;
													}
													this.IixQC4SLn7.addHate(characterControl.ActorNr, 60);
													if (45787 - 217961 == -172173)
													{
														goto IL_347;
													}
												}
											}
										}
									}
								}
							}
							if (164282 - 132415 == 31867)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060009B0 RID: 2480 RVA: 0x000F9C64 File Offset: 0x000F7E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual int countCoralBug()
	{
		if (143920 - 506649 != -362728)
		{
		}
		int num;
		for (;;)
		{
			IL_48:
			num = 0;
			if (118128 - 228736 != -110607)
			{
				GameObject[] array = GameObject.FindGameObjectsWithTag("Enemy");
				if (262815 - 544849 == -282034)
				{
					int i = 0;
					if (14774 - 477381 != -462606)
					{
						GameObject[] array2 = array;
						if (153928 - 193713 == -39785)
						{
							int length = array2.Length;
							if (211314 - 542593 == -331279)
							{
								while (i < length)
								{
									if (array2[i].layer == this.gameObject.layer)
									{
										if (16505 - 94950 != -78445)
										{
											goto IL_48;
										}
										CharacterControl characterControl = (CharacterControl)array2[i].GetComponent(typeof(CharacterControl));
										if (27538 - 422442 != -394904)
										{
											goto IL_48;
										}
										if (characterControl)
										{
											if (147969 - 355522 != -207553)
											{
												goto IL_48;
											}
											if (!(characterControl.Type == "CoralBug"))
											{
												if (290679 - 386531 != -95852)
												{
													goto IL_48;
												}
												if (!(characterControl.Type == "CoralBug2"))
												{
													goto IL_1F3;
												}
												if (209901 - 50936 != 158965)
												{
													goto IL_48;
												}
											}
											if (characterControl.hp > 0)
											{
												if (11974 - 196923 != -184949)
												{
													goto IL_48;
												}
												if (characterControl.hp < characterControl.mhp - 100)
												{
													if (24315 - 376549 != -352234)
													{
														goto IL_48;
													}
													num++;
													if (284183 - 56943 != 227240)
													{
														goto IL_48;
													}
												}
											}
										}
									}
									IL_1F3:
									i++;
									if (295453 - 19973 != 275480)
									{
										goto IL_48;
									}
								}
								if (157604 - 336963 != -179358)
								{
									Debug.Log("CoralCount :" + num);
									if (284419 - 366010 == -81591)
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
		return num;
	}

	// Token: 0x060009B1 RID: 2481 RVA: 0x000F9F10 File Offset: 0x000F8110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060009B2 RID: 2482 RVA: 0x000F9F14 File Offset: 0x000F8114
	internal static bool SEE235k1SbOGQUv5fvi()
	{
		return true;
	}

	// Token: 0x060009B3 RID: 2483 RVA: 0x000F9F18 File Offset: 0x000F8118
	internal static bool o5Z9ESk4FiHlEs3N1DN()
	{
		return false;
	}

	// Token: 0x040008C3 RID: 2243
	private CharacterControl IixQC4SLn7;

	// Token: 0x040008C4 RID: 2244
	private CharacterControl XLSQM01aCY;

	// Token: 0x040008C5 RID: 2245
	private ReefBug e4AQfTRUAq;

	// Token: 0x040008C6 RID: 2246
	public string AI_state;

	// Token: 0x040008C7 RID: 2247
	private float DmrQLJIFvQ;

	// Token: 0x040008C8 RID: 2248
	private float L9cQwg41Ao;

	// Token: 0x040008C9 RID: 2249
	private float t5pQUHlYQS;
}
