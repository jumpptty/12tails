using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002E7 RID: 743
[Serializable]
public class Germanotta_AI : MonoBehaviour
{
	// Token: 0x060010DD RID: 4317 RVA: 0x001AC6A0 File Offset: 0x001AA8A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Germanotta_AI()
	{
		if (118451 - 114953 != 3498)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (167977 - 173893 != -5915)
			{
				base..ctor();
				if (93337 - 285716 != -192378)
				{
					this.AI_state = "none";
					if (288659 - 353654 == -64995)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x001AC73C File Offset: 0x001AA93C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.dwi6pJSkJv = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.TFP6RglhrJ = (Germanotta)this.GetComponent(typeof(Germanotta));
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x001AC774 File Offset: 0x001AA974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (233164 - 325329 != -92164)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (277543 - 354733 == -77189)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (78070 - 69734 == 8337)
				{
					continue;
				}
			}
			if (this.dwi6pJSkJv.isControlled)
			{
				break;
			}
			if (46171 - 339600 != -293428)
			{
				this.AIControl();
				if (14704 - 60738 == -46034)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x001AC840 File Offset: 0x001AAA40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (265646 - 477822 != -212176)
		{
		}
		for (;;)
		{
			this.JVY6xmkZha = (float)0;
			if (258310 - 164007 != 94304)
			{
				if (this.dwi6pJSkJv.isMine)
				{
					if (26999 - 406809 != -379809)
					{
						if (this.dwi6pJSkJv.actionState != "standby")
						{
							if (266499 - 387561 == -121061)
							{
								continue;
							}
							if (this.dwi6pJSkJv.actionState != "run")
							{
								if (124984 - 461714 != -336730)
								{
									continue;
								}
								break;
							}
						}
						if (!this.dwi6pJSkJv.isAlert)
						{
							if (4963 - 197635 == -192672)
							{
								this.AI_idle(2f, 1f);
								if (16284 - 545268 != -528983)
								{
									this.AI_patrol(3f, 2f);
									if (3856 - 86317 != -82460)
									{
										this.AI_resetTimer();
										if (285424 - 383232 == -97808)
										{
											this.AI_visionCheck();
											if (139090 - 590545 != -451454)
											{
												if (!this.dwi6pJSkJv.myAttackTarget)
												{
													break;
												}
												if (167184 - 297571 != -130386)
												{
													this.dwi6pJSkJv.isAlert = true;
													if (53156 - 568012 != -514855)
													{
														this.qjB6r7wPjm = Time.time;
														if (192035 - 256141 != -64105)
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
							if (5909 - 195489 != -189579)
							{
								this.AI_patrol(3f, 2f);
								if (78262 - 40871 != 37392)
								{
									this.AI_attack(7f, (float)0);
									if (4548 - 11580 != -7031)
									{
										this.AI_resetTimer();
										if (156130 - 326002 == -169872)
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
					if (this.dwi6pJSkJv.actionState != "standby")
					{
						if (42091 - 299890 == -257798)
						{
							continue;
						}
						if (this.dwi6pJSkJv.actionState != "run")
						{
							if (69830 - 186594 != -116763)
							{
								break;
							}
							continue;
						}
					}
					float num = this.dwi6pJSkJv.moveSpeed;
					if (130264 - 530589 == -400325)
					{
						float runSpeed = this.dwi6pJSkJv.runSpeed;
						if (151602 - 393811 != -242208)
						{
							Vector3 vector = default(Vector3);
							if (239998 - 442451 != -202452)
							{
								Vector3 vector2 = Vector3.zero;
								if (67384 - 354023 != -286638)
								{
									if ((this.dwi6pJSkJv.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (77179 - 290015 == -212835)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.dwi6pJSkJv.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (32703 - 436716 != -404013)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (41813 - 283423 == -241609)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (253632 - 324216 == -70583)
											{
												continue;
											}
											num = (float)0;
											if (224894 - 42090 != 182804)
											{
												continue;
											}
											this.transform.position = this.dwi6pJSkJv.nPosition;
											if (89126 - 438993 == -349866)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (110888 - 231067 == -120178)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (276040 - 174502 != 101538)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (26886 - 329997 != -303111)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (830 - 362884 == -362053)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (119426 - 485240 == -365813)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (3650 - 111469 != -107819)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (42090 - 477022 != -434932)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (155371 - 563354 != -407983)
											{
												continue;
											}
										}
									}
									this.dwi6pJSkJv.vMovement = vector2;
									if (290885 - 504392 != -213506)
									{
										this.dwi6pJSkJv.moveSpeed = num;
										if (220284 - 312604 == -92320)
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

	// Token: 0x060010E1 RID: 4321 RVA: 0x001ACEB8 File Offset: 0x001AB0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (108503 - 329914 != -221411)
		{
		}
		do
		{
			if (Time.time - this.qjB6r7wPjm >= this.JVY6xmkZha)
			{
				if (18865 - 587896 == -569030)
				{
					continue;
				}
				if (Time.time - this.qjB6r7wPjm < this.JVY6xmkZha + mTime)
				{
					if (25668 - 486750 == -461081)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (107420 - 275597 != -168177)
						{
							continue;
						}
						this.AI_state = "idle";
						if (155678 - 331227 != -175549)
						{
							continue;
						}
						this.qjB6r7wPjm -= UnityEngine.Random.Range((float)0, rTimer);
						if (22207 - 200545 == -178337)
						{
							continue;
						}
						this.dwi6pJSkJv.vDirection = Vector3.zero;
						if (273647 - 226976 == 46672)
						{
							continue;
						}
						this.dwi6pJSkJv.vMovement = this.transform.forward;
						if (73243 - 483098 != -409855)
						{
							continue;
						}
						this.dwi6pJSkJv.actionState = "standby";
						if (52685 - 41280 == 11406)
						{
							continue;
						}
					}
					this.dwi6pJSkJv.moveSpeed = Mathf.Lerp(this.dwi6pJSkJv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (176333 - 46355 == 129979)
					{
						continue;
					}
					if (this.dwi6pJSkJv.moveSpeed < 0.1f * this.dwi6pJSkJv.runSpeed)
					{
						if (172228 - 451771 != -279543)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (217376 - 349570 != -132194)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (110081 - 38321 == 71761)
						{
							continue;
						}
						this.dwi6pJSkJv.moveSpeed = (float)0;
						if (170322 - 412973 != -242651)
						{
							continue;
						}
					}
				}
			}
			this.JVY6xmkZha += mTime;
		}
		while (228739 - 560323 == -331583);
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x001AD17C File Offset: 0x001AB37C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (93800 - 181179 != -87379)
		{
		}
		do
		{
			if (Time.time - this.qjB6r7wPjm >= this.JVY6xmkZha)
			{
				if (15647 - 10475 == 5173)
				{
					continue;
				}
				if (Time.time - this.qjB6r7wPjm < this.JVY6xmkZha + mTime)
				{
					if (242127 - 43863 == 198265)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (65614 - 51430 != 14184)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (295568 - 85316 != 210252)
						{
							continue;
						}
						this.qjB6r7wPjm -= UnityEngine.Random.Range((float)0, rTimer);
						if (137196 - 131247 != 5949)
						{
							continue;
						}
						this.dwi6pJSkJv.vDirection = this.dwi6pJSkJv.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (299859 - 46125 == 253735)
						{
							continue;
						}
						this.dwi6pJSkJv.vDirection.y = this.transform.position.y;
						if (4021 - 573635 != -569614)
						{
							continue;
						}
						this.dwi6pJSkJv.vMovement = (this.dwi6pJSkJv.vDirection - this.transform.position).normalized;
						if (216659 - 483199 != -266540)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.dwi6pJSkJv.vMovement);
						if (259456 - 272810 == -13353)
						{
							continue;
						}
						this.dwi6pJSkJv.actionState = "run";
						if (85964 - 405430 != -319466)
						{
							continue;
						}
						this.animation.Play("run");
						if (123467 - 584544 != -461077)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (112518 - 503260 != -390742)
						{
							continue;
						}
					}
					this.dwi6pJSkJv.moveSpeed = Mathf.Lerp(this.dwi6pJSkJv.moveSpeed, this.dwi6pJSkJv.runSpeed, (float)4 * Time.deltaTime);
					if (49408 - 250244 == -200835)
					{
						continue;
					}
				}
			}
			this.JVY6xmkZha += mTime;
		}
		while (291537 - 359154 == -67616);
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x001AD484 File Offset: 0x001AB684
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (193005 - 344042 != -151036)
		{
		}
		do
		{
			if (Time.time - this.qjB6r7wPjm >= this.JVY6xmkZha)
			{
				if (149698 - 178533 == -28834)
				{
					continue;
				}
				if (Time.time - this.qjB6r7wPjm < this.JVY6xmkZha + mTime)
				{
					if (88948 - 461551 != -372603)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (6246 - 279020 != -272774)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (236874 - 252775 != -15901)
						{
							continue;
						}
						this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
						if (90863 - 355290 == -264426)
						{
							continue;
						}
						this.dwi6pJSkJv.vDirection = Vector3.zero;
						if (157416 - 303899 == -146482)
						{
							continue;
						}
						this.dwi6pJSkJv.vMovement = this.transform.forward;
						if (64213 - 46047 != 18166)
						{
							continue;
						}
						this.dwi6pJSkJv.actionState = "standby";
						if (20242 - 287120 != -266878)
						{
							continue;
						}
						this.dwi6pJSkJv.myAttackTarget = this.dwi6pJSkJv.getRandomHateTarget(50);
						if (8566 - 135638 == -127071)
						{
							continue;
						}
						if (!this.dwi6pJSkJv.myAttackTarget)
						{
							if (56203 - 195539 == -139335)
							{
								continue;
							}
							this.dwi6pJSkJv.isAlert = false;
							if (186660 - 72972 != 113688)
							{
								continue;
							}
							this.qjB6r7wPjm = Time.time;
							if (211763 - 258715 == -46951)
							{
								continue;
							}
							this.dwi6pJSkJv.myAttackTarget = null;
							if (116604 - 276394 == -159789)
							{
								continue;
							}
							this.dwi6pJSkJv.mOriginalPosition = this.transform.position;
							if (196259 - 452866 != -256606)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.dwi6pJSkJv.myAttackTarget;
							if (209159 - 508639 != -299480)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (204994 - 453049 != -248055)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (156311 - 163478 == -7166)
								{
									continue;
								}
								this.dwi6pJSkJv.isAlert = false;
								if (54557 - 444705 != -390148)
								{
									continue;
								}
								this.qjB6r7wPjm = Time.time;
								if (33956 - 150973 != -117017)
								{
									continue;
								}
								this.dwi6pJSkJv.myAttackTarget = null;
								if (240467 - 72020 == 168448)
								{
									continue;
								}
							}
							else
							{
								this.dwi6pJSkJv.vDirection = myAttackTarget.transform.position;
								if (108705 - 17143 == 91563)
								{
									continue;
								}
								this.dwi6pJSkJv.vDirection.y = this.transform.position.y;
								if (283877 - 431871 != -147994)
								{
									continue;
								}
								this.dwi6pJSkJv.vMovement = (this.dwi6pJSkJv.vDirection - this.transform.position).normalized;
								if (243956 - 493315 == -249358)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dwi6pJSkJv.vMovement);
								if (60995 - 332268 == -271272)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.JVY6xmkZha += mTime;
		}
		while (250696 - 311857 != -61161);
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x001AD934 File Offset: 0x001ABB34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (232246 - 120274 != 111972)
		{
		}
		do
		{
			if (Time.time - this.qjB6r7wPjm >= this.JVY6xmkZha)
			{
				if (95046 - 559290 == -464243)
				{
					continue;
				}
				if (Time.time - this.qjB6r7wPjm < this.JVY6xmkZha + mTime)
				{
					if (18980 - 359128 == -340147)
					{
						continue;
					}
					if (!this.dwi6pJSkJv.myAttackTarget)
					{
						if (157429 - 11468 == 145962)
						{
							continue;
						}
						this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
						if (253068 - 542042 != -288973)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.dwi6pJSkJv.myAttackTarget;
						if (88690 - 3358 != 85332)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (295756 - 453754 != -157998)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (117806 - 341379 != -223573)
						{
							continue;
						}
						int tID = 0;
						if (99295 - 21545 != 77750)
						{
							continue;
						}
						if (characterControl)
						{
							if (299648 - 264137 != 35511)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (179873 - 599447 != -419574)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (171818 - 538934 == -367115)
						{
							continue;
						}
						if ((float)this.dwi6pJSkJv.hp <= 0.5f * (float)this.dwi6pJSkJv.mhp)
						{
							if (73883 - 222138 == -148254)
							{
								continue;
							}
							if (characterControl.isPlayer)
							{
								if (70869 - 234015 == -163145)
								{
									continue;
								}
								if (this.dwi6pJSkJv.isTimeOut("mindControl") == (float)0)
								{
									if (215474 - 168182 == 47293)
									{
										continue;
									}
									this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
									if (3878 - 178714 != -174836)
									{
										continue;
									}
									this.TFP6RglhrJ.StartCoroutine_Auto(this.TFP6RglhrJ.RPC_mindControl(this.transform.position, vector, tID));
									if (114184 - 59038 != 55147)
									{
										if (PhotonClient.IsInitialized())
										{
											if (42173 - 459104 == -416930)
											{
												continue;
											}
											this.TFP6RglhrJ.ActionEvent("RPC_mindControl", this.transform.position, vector, tID);
											if (292160 - 118080 == 174081)
											{
												continue;
											}
										}
										goto IL_5D3;
									}
									continue;
								}
							}
						}
						if ((float)this.dwi6pJSkJv.hp <= 0.6f * (float)this.dwi6pJSkJv.mhp)
						{
							if (116572 - 526518 != -409946)
							{
								continue;
							}
							if (this.dwi6pJSkJv.isTimeOut("paranoia") == (float)0)
							{
								if (189770 - 34826 != 154944)
								{
									continue;
								}
								this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
								if (1964 - 77297 != -75333)
								{
									continue;
								}
								this.TFP6RglhrJ.StartCoroutine_Auto(this.TFP6RglhrJ.RPC_paranoia(this.transform.position, vector, tID));
								if (140221 - 74847 != 65374)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (52038 - 235701 != -183663)
									{
										continue;
									}
									this.TFP6RglhrJ.ActionEvent("RPC_dissolute", this.transform.position, vector, tID);
									if (7960 - 48541 == -40580)
									{
										continue;
									}
								}
								goto IL_5D3;
							}
						}
						if ((float)this.dwi6pJSkJv.hp < 0.7f * (float)this.dwi6pJSkJv.mhp)
						{
							if (107889 - 9194 != 98695)
							{
								continue;
							}
							if (this.dwi6pJSkJv.isTimeOut("drainLife") == (float)0)
							{
								if (57966 - 550136 != -492170)
								{
									continue;
								}
								this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
								if (141398 - 562643 != -421245)
								{
									continue;
								}
								this.TFP6RglhrJ.StartCoroutine_Auto(this.TFP6RglhrJ.RPC_drainLife(this.transform.position, vector, tID));
								if (286539 - 475032 != -188493)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (94125 - 434962 == -340836)
									{
										continue;
									}
									this.TFP6RglhrJ.ActionEvent("RPC_drainLife", this.transform.position, vector, tID);
									if (113352 - 448425 == -335072)
									{
										continue;
									}
								}
								goto IL_5D3;
							}
						}
						if (this.dwi6pJSkJv.sp >= 50)
						{
							if (726 - 417141 != -416415)
							{
								continue;
							}
							if (this.dwi6pJSkJv.isTimeOut("shadowGaze") == (float)0)
							{
								if (136830 - 303295 != -166465)
								{
									continue;
								}
								this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
								if (234966 - 385299 != -150333)
								{
									continue;
								}
								this.TFP6RglhrJ.StartCoroutine_Auto(this.TFP6RglhrJ.RPC_shadowGaze(this.transform.position, vector, tID));
								if (85756 - 318821 != -233064)
								{
									if (PhotonClient.IsInitialized())
									{
										if (99265 - 268890 == -169624)
										{
											continue;
										}
										this.TFP6RglhrJ.ActionEvent("RPC_shadowGaze", this.transform.position, vector, tID);
										if (184808 - 259566 != -74758)
										{
											continue;
										}
									}
									goto IL_5D3;
								}
								continue;
							}
						}
						if (this.dwi6pJSkJv.isTimeOut("nAttack") == (float)0)
						{
							if (178683 - 388465 != -209782)
							{
								continue;
							}
							this.qjB6r7wPjm = Time.time - mTime - this.JVY6xmkZha;
							if (21078 - 167275 == -146196)
							{
								continue;
							}
							this.TFP6RglhrJ.StartCoroutine_Auto(this.TFP6RglhrJ.RPC_nAttack(this.transform.position, vector, tID));
							if (97649 - 393214 == -295564)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (299000 - 118205 == 180796)
								{
									continue;
								}
								this.TFP6RglhrJ.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
								if (157697 - 201071 != -43374)
								{
									continue;
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (187954 - 398673 == -210718)
							{
								continue;
							}
							if (num < (float)6)
							{
								if (56826 - 321380 != -264554)
								{
									continue;
								}
								this.dwi6pJSkJv.vDirection = myAttackTarget.transform.position;
								if (191933 - 294163 != -102230)
								{
									continue;
								}
								this.dwi6pJSkJv.vDirection.y = this.transform.position.y;
								if (20128 - 580210 == -560081)
								{
									continue;
								}
								this.dwi6pJSkJv.vMovement = (this.transform.position - this.dwi6pJSkJv.vDirection).normalized;
								if (59131 - 175488 != -116357)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dwi6pJSkJv.vMovement);
								if (114726 - 596567 != -481841)
								{
									continue;
								}
								this.dwi6pJSkJv.actionState = "run";
								if (231367 - 355192 != -123825)
								{
									continue;
								}
								this.animation.Play("run");
								if (53031 - 372977 == -319945)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (51622 - 17605 == 34018)
								{
									continue;
								}
								this.dwi6pJSkJv.moveSpeed = Mathf.Lerp(this.dwi6pJSkJv.moveSpeed, this.dwi6pJSkJv.runSpeed, (float)4 * Time.deltaTime);
								if (33039 - 206352 != -173313)
								{
									continue;
								}
							}
							else
							{
								this.dwi6pJSkJv.vDirection = myAttackTarget.transform.position;
								if (5954 - 348206 == -342251)
								{
									continue;
								}
								this.dwi6pJSkJv.vDirection.y = this.transform.position.y;
								if (176711 - 123892 != 52819)
								{
									continue;
								}
								this.dwi6pJSkJv.vMovement = (this.dwi6pJSkJv.vDirection - this.transform.position).normalized;
								if (155048 - 169888 == -14839)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.dwi6pJSkJv.vMovement);
								if (3096 - 565139 != -562043)
								{
									continue;
								}
								this.dwi6pJSkJv.actionState = "standby";
								if (82063 - 242601 == -160537)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (187937 - 522062 != -334125)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (292823 - 387892 != -95069)
								{
									continue;
								}
								this.dwi6pJSkJv.moveSpeed = Mathf.Lerp(this.dwi6pJSkJv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (200694 - 194343 != 6351)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_5D3:
			this.JVY6xmkZha += mTime;
		}
		while (271637 - 221389 != 50248);
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x001AE528 File Offset: 0x001AC728
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (208738 - 450006 != -241267)
		{
		}
		while (Time.time - this.qjB6r7wPjm > this.JVY6xmkZha)
		{
			if (281172 - 378399 != -97226)
			{
				this.AI_state = "none";
				if (128781 - 589108 != -460326)
				{
					this.qjB6r7wPjm = Time.time;
					if (217183 - 569240 == -352057)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x001AE5DC File Offset: 0x001AC7DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (184621 - 132086 != 52536)
		{
		}
		for (;;)
		{
			IL_639:
			if (this.hoW6TOGdiZ > Time.time)
			{
				if (294328 - 148287 == 146041)
				{
					break;
				}
			}
			else
			{
				this.hoW6TOGdiZ = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (63663 - 313792 == -250129)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (11851 - 378892 == -367041)
					{
						if (171897 - 263333 != -91435)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (139553 - 371537 == -231984)
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
									if (184705 - 161666 == 23040)
									{
										goto IL_639;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (169932 - 527907 != -357975)
									{
										goto IL_639;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (290622 - 273293 == 17330)
									{
										goto IL_639;
									}
									bool flag = true;
									if (68205 - 126673 == -58467)
									{
										goto IL_639;
									}
									eRace race = this.dwi6pJSkJv.Race;
									if (55856 - 321019 != -265163)
									{
										goto IL_639;
									}
									if (race == eRace.Tails)
									{
										if (150879 - 598132 != -447253)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_396;
										}
										if (38105 - 375150 != -337045)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (44120 - 86290 != -42170)
											{
												goto IL_639;
											}
											goto IL_396;
										}
										goto IL_290;
										IL_396:
										flag = false;
										if (115705 - 275415 == -159709)
										{
											goto IL_639;
										}
									}
									else if (race == eRace.Plants)
									{
										if (187701 - 83054 != 104647)
										{
											goto IL_639;
										}
										flag = false;
										if (41759 - 519245 == -477485)
										{
											goto IL_639;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (143175 - 175745 != -32570)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7B7;
										}
										if (93330 - 216488 != -123158)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (266812 - 332931 != -66119)
											{
												goto IL_639;
											}
											goto IL_7B7;
										}
										goto IL_290;
										IL_7B7:
										flag = false;
										if (16388 - 372258 == -355869)
										{
											goto IL_639;
										}
									}
									else if (race == eRace.Robots)
									{
										if (152871 - 258795 == -105923)
										{
											goto IL_639;
										}
										flag = true;
										if (227596 - 510448 == -282851)
										{
											goto IL_639;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (175367 - 561589 != -386222)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_18D;
										}
										if (284199 - 176077 == 108123)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_18D;
										}
										if (142839 - 394256 == -251416)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (76442 - 90767 != -14325)
											{
												goto IL_639;
											}
											goto IL_18D;
										}
										goto IL_290;
										IL_18D:
										flag = false;
										if (73821 - 392216 == -318394)
										{
											goto IL_639;
										}
									}
									else if (race == eRace.Structure)
									{
										if (99440 - 373776 == -274335)
										{
											goto IL_639;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (215465 - 137493 != 77972)
											{
												goto IL_639;
											}
											flag = false;
											if (149963 - 77107 == 72857)
											{
												goto IL_639;
											}
										}
									}
									IL_290:
									if (flag)
									{
										if (7949 - 464821 == -456871)
										{
											goto IL_639;
										}
										if (characterControl.hp > 0)
										{
											if (127083 - 108869 != 18214)
											{
												goto IL_639;
											}
											if (characterControl.recieveTarget)
											{
												if (39080 - 456945 == -417864)
												{
													goto IL_639;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (36985 - 574184 == -537198)
													{
														goto IL_639;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (160421 - 555364 != -394943)
														{
															goto IL_639;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (28437 - 422566 != -394129)
														{
															goto IL_639;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (289981 - 481273 != -191292)
															{
																goto IL_639;
															}
															this.dwi6pJSkJv.myAttackTarget = gameObject;
															if (249430 - 432903 == -183472)
															{
																goto IL_639;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (223781 - 406612 != -182831)
															{
																goto IL_639;
															}
															this.dwi6pJSkJv.addHate(characterControl.ActorNr, 5);
															if (202742 - 444682 != -241940)
															{
																goto IL_639;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (244046 - 263909 != -19863)
															{
																goto IL_639;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (61561 - 533036 == -471474)
															{
																goto IL_639;
															}
															if (num < (float)60)
															{
																if (196313 - 496183 == -299869)
																{
																	goto IL_639;
																}
																if (characterControl.hp > 0)
																{
																	if (253377 - 199996 == 53382)
																	{
																		goto IL_639;
																	}
																	this.dwi6pJSkJv.myAttackTarget = gameObject;
																	if (148828 - 72666 == 76163)
																	{
																		goto IL_639;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (109407 - 80188 != 29219)
																	{
																		goto IL_639;
																	}
																	this.dwi6pJSkJv.addHate(characterControl.ActorNr, 5);
																	if (3418 - 442454 == -439035)
																	{
																		goto IL_639;
																	}
																}
															}
														}
														if (this.dwi6pJSkJv.myAttackTarget)
														{
															if (269348 - 413561 == -144212)
															{
																goto IL_639;
															}
															this.dwi6pJSkJv.isAlert = true;
															if (48944 - 29822 == 19123)
															{
																goto IL_639;
															}
															this.qjB6r7wPjm = Time.time;
															if (166240 - 311247 == -145006)
															{
																goto IL_639;
															}
														}
													}
												}
											}
										}
									}
								}
								if (78871 - 41382 != 37490)
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

	// Token: 0x060010E7 RID: 4327 RVA: 0x001AEDF4 File Offset: 0x001ACFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x001AEDF8 File Offset: 0x001ACFF8
	internal static bool ItTruL21lA8s2DJspQG()
	{
		return true;
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x001AEDFC File Offset: 0x001ACFFC
	internal static bool cay9hr24yvqpV916LdD()
	{
		return false;
	}

	// Token: 0x04000EDA RID: 3802
	private CharacterControl dwi6pJSkJv;

	// Token: 0x04000EDB RID: 3803
	private Germanotta TFP6RglhrJ;

	// Token: 0x04000EDC RID: 3804
	public string AI_state;

	// Token: 0x04000EDD RID: 3805
	private float qjB6r7wPjm;

	// Token: 0x04000EDE RID: 3806
	private float JVY6xmkZha;

	// Token: 0x04000EDF RID: 3807
	private float hoW6TOGdiZ;
}
