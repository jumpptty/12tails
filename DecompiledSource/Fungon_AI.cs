using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A56 RID: 2646
[Serializable]
public class Fungon_AI : MonoBehaviour
{
	// Token: 0x060039F7 RID: 14839 RVA: 0x0079441C File Offset: 0x0079261C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Fungon_AI()
	{
		if (120428 - 524326 != -403898)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (279327 - 355264 != -75936)
			{
				base..ctor();
				if (243957 - 524695 == -280738)
				{
					this.AI_state = "none";
					if (22380 - 397922 == -375542)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x007944B8 File Offset: 0x007926B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.SJG9uy78Aa = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.gJ59yfwSJO = (Fungon)this.GetComponent(typeof(Fungon));
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x007944F0 File Offset: 0x007926F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (279348 - 445498 != -166149)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (296508 - 54331 == 242178)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (214813 - 232317 == -17503)
				{
					continue;
				}
			}
			if (this.SJG9uy78Aa.isControlled)
			{
				break;
			}
			if (48013 - 548998 != -500984)
			{
				this.AIControl();
				if (23838 - 583871 != -560032)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x007945BC File Offset: 0x007927BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (283670 - 589232 != -305562)
		{
		}
		for (;;)
		{
			this.Ap19hHdxe4 = (float)0;
			if (260353 - 399379 != -139025)
			{
				if (this.SJG9uy78Aa.isMine)
				{
					if (258335 - 211260 != 47076)
					{
						if (this.SJG9uy78Aa.actionState != "standby")
						{
							if (140974 - 127607 != 13367)
							{
								continue;
							}
							if (this.SJG9uy78Aa.actionState != "run")
							{
								if (101560 - 179148 != -77587)
								{
									break;
								}
								continue;
							}
						}
						if (!this.SJG9uy78Aa.isAlert)
						{
							if (294723 - 592241 == -297518)
							{
								this.AI_idle(4f, 2f);
								if (216461 - 432065 == -215604)
								{
									this.AI_patrol(1f, 0.25f);
									if (186744 - 339762 == -153018)
									{
										this.AI_resetTimer();
										if (272154 - 408051 == -135897)
										{
											this.AI_visionCheck();
											if (289245 - 583783 == -294538)
											{
												if (!this.SJG9uy78Aa.myAttackTarget)
												{
													break;
												}
												if (7042 - 234997 == -227955)
												{
													this.SJG9uy78Aa.isAlert = true;
													if (129867 - 292638 != -162770)
													{
														this.uev9VHcJqI = Time.time;
														if (208366 - 185783 != 22584)
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
							if (125226 - 396048 == -270822)
							{
								this.AI_idle(2f, 1f);
								if (219675 - 116019 == 103656)
								{
									this.AI_attack(6f, (float)0);
									if (276228 - 581105 != -304876)
									{
										this.AI_resetTimer();
										if (294992 - 396826 == -101834)
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
					if (this.SJG9uy78Aa.actionState != "standby")
					{
						if (82256 - 255910 != -173654)
						{
							continue;
						}
						if (this.SJG9uy78Aa.actionState != "run")
						{
							if (189091 - 260037 != -70945)
							{
								break;
							}
							continue;
						}
					}
					float num = this.SJG9uy78Aa.moveSpeed;
					if (225606 - 443801 == -218195)
					{
						float runSpeed = this.SJG9uy78Aa.runSpeed;
						if (61393 - 487762 != -426368)
						{
							Vector3 vector = default(Vector3);
							if (165699 - 385211 == -219512)
							{
								Vector3 vector2 = Vector3.zero;
								if (152958 - 82277 == 70681)
								{
									if ((this.SJG9uy78Aa.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (83859 - 574728 == -490868)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.SJG9uy78Aa.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (23093 - 109143 == -86049)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (50829 - 371115 == -320285)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (58645 - 543227 == -484581)
											{
												continue;
											}
											num = (float)0;
											if (272361 - 300318 != -27957)
											{
												continue;
											}
											this.transform.position = this.SJG9uy78Aa.nPosition;
											if (29359 - 382344 == -352984)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (95389 - 89148 == 6242)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (247542 - 421827 != -174285)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (76069 - 264496 != -188427)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (3544 - 35651 == -32106)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (143642 - 168795 != -25153)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (168563 - 256189 != -87626)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (148590 - 173349 == -24758)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (203183 - 421231 == -218047)
											{
												continue;
											}
										}
									}
									this.SJG9uy78Aa.vMovement = vector2;
									if (79663 - 598711 != -519047)
									{
										this.SJG9uy78Aa.moveSpeed = num;
										if (36777 - 319252 == -282475)
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

	// Token: 0x060039FB RID: 14843 RVA: 0x00794C34 File Offset: 0x00792E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (134771 - 396139 != -261367)
		{
		}
		do
		{
			if (Time.time - this.uev9VHcJqI >= this.Ap19hHdxe4)
			{
				if (59550 - 172094 == -112543)
				{
					continue;
				}
				if (Time.time - this.uev9VHcJqI < this.Ap19hHdxe4 + mTime)
				{
					if (112828 - 512639 != -399811)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (185150 - 452508 != -267358)
						{
							continue;
						}
						this.AI_state = "idle";
						if (61807 - 217825 != -156018)
						{
							continue;
						}
						this.uev9VHcJqI -= UnityEngine.Random.Range((float)0, rTimer);
						if (66946 - 534372 == -467425)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection = Vector3.zero;
						if (121547 - 212390 == -90842)
						{
							continue;
						}
						this.SJG9uy78Aa.vMovement = this.transform.forward;
						if (43932 - 303639 == -259706)
						{
							continue;
						}
						this.SJG9uy78Aa.actionState = "standby";
						if (78839 - 332049 == -253209)
						{
							continue;
						}
					}
					this.SJG9uy78Aa.moveSpeed = Mathf.Lerp(this.SJG9uy78Aa.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (170253 - 543396 == -373142)
					{
						continue;
					}
					if (this.SJG9uy78Aa.moveSpeed < 0.1f * this.SJG9uy78Aa.runSpeed)
					{
						if (275631 - 135261 == 140371)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (126840 - 82070 == 44771)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (30485 - 345391 != -314906)
						{
							continue;
						}
						this.SJG9uy78Aa.moveSpeed = (float)0;
						if (104931 - 221186 != -116255)
						{
							continue;
						}
					}
				}
			}
			this.Ap19hHdxe4 += mTime;
		}
		while (187932 - 405997 == -218064);
	}

	// Token: 0x060039FC RID: 14844 RVA: 0x00794EF8 File Offset: 0x007930F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (211447 - 357156 != -145709)
		{
		}
		do
		{
			if (Time.time - this.uev9VHcJqI >= this.Ap19hHdxe4)
			{
				if (230121 - 25489 == 204633)
				{
					continue;
				}
				if (Time.time - this.uev9VHcJqI < this.Ap19hHdxe4 + mTime)
				{
					if (80281 - 280735 != -200454)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (190644 - 545479 == -354834)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (101329 - 306456 != -205127)
						{
							continue;
						}
						this.uev9VHcJqI -= UnityEngine.Random.Range((float)0, rTimer);
						if (36476 - 576011 != -539535)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection = this.SJG9uy78Aa.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (239131 - 491612 == -252480)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection.y = this.transform.position.y;
						if (186511 - 101558 == 84954)
						{
							continue;
						}
						this.SJG9uy78Aa.vMovement = (this.SJG9uy78Aa.vDirection - this.transform.position).normalized;
						if (56371 - 559679 != -503308)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SJG9uy78Aa.vMovement);
						if (226635 - 80773 == 145863)
						{
							continue;
						}
						this.SJG9uy78Aa.actionState = "run";
						if (178338 - 271456 != -93118)
						{
							continue;
						}
						this.animation.Play("run");
						if (29535 - 572003 != -542468)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (198266 - 37756 == 160511)
						{
							continue;
						}
					}
					this.SJG9uy78Aa.moveSpeed = Mathf.Lerp(this.SJG9uy78Aa.moveSpeed, this.SJG9uy78Aa.runSpeed, (float)4 * Time.deltaTime);
					if (32449 - 119522 != -87073)
					{
						continue;
					}
				}
			}
			this.Ap19hHdxe4 += mTime;
		}
		while (9068 - 360878 != -351810);
	}

	// Token: 0x060039FD RID: 14845 RVA: 0x00795200 File Offset: 0x00793400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (243642 - 218758 != 24884)
		{
		}
		do
		{
			if (Time.time - this.uev9VHcJqI >= this.Ap19hHdxe4)
			{
				if (296836 - 278406 == 18431)
				{
					continue;
				}
				if (Time.time - this.uev9VHcJqI < this.Ap19hHdxe4 + mTime)
				{
					if (149225 - 536348 != -387123)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (21173 - 509633 != -488460)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (163725 - 49756 != 113969)
						{
							continue;
						}
						this.uev9VHcJqI = Time.time - mTime - this.Ap19hHdxe4;
						if (95467 - 244661 == -149193)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection = Vector3.zero;
						if (256242 - 121009 != 135233)
						{
							continue;
						}
						this.SJG9uy78Aa.vMovement = this.transform.forward;
						if (4645 - 341222 == -336576)
						{
							continue;
						}
						this.SJG9uy78Aa.actionState = "standby";
						if (185596 - 100516 != 85080)
						{
							continue;
						}
						this.SJG9uy78Aa.myAttackTarget = this.SJG9uy78Aa.getHateTarget(5, 50);
						if (80363 - 512811 == -432447)
						{
							continue;
						}
						if (!this.SJG9uy78Aa.myAttackTarget)
						{
							if (10364 - 495851 != -485487)
							{
								continue;
							}
							this.SJG9uy78Aa.isAlert = false;
							if (21956 - 514935 == -492978)
							{
								continue;
							}
							this.uev9VHcJqI = Time.time;
							if (223053 - 184489 != 38564)
							{
								continue;
							}
							this.SJG9uy78Aa.myAttackTarget = null;
							if (47377 - 78261 == -30883)
							{
								continue;
							}
							this.SJG9uy78Aa.mOriginalPosition = this.transform.position;
							if (134088 - 131068 != 3020)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.SJG9uy78Aa.myAttackTarget;
							if (257538 - 579982 == -322443)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (72228 - 464784 != -392556)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (172717 - 439281 != -266564)
								{
									continue;
								}
								this.SJG9uy78Aa.isAlert = false;
								if (114849 - 538762 == -423912)
								{
									continue;
								}
								this.uev9VHcJqI = Time.time;
								if (127946 - 11174 == 116773)
								{
									continue;
								}
								this.SJG9uy78Aa.myAttackTarget = null;
								if (279819 - 566407 == -286587)
								{
									continue;
								}
							}
							else
							{
								this.SJG9uy78Aa.vDirection = myAttackTarget.transform.position;
								if (53386 - 599234 != -545848)
								{
									continue;
								}
								this.SJG9uy78Aa.vDirection.y = this.transform.position.y;
								if (299554 - 376335 == -76780)
								{
									continue;
								}
								this.SJG9uy78Aa.vMovement = (this.SJG9uy78Aa.vDirection - this.transform.position).normalized;
								if (150569 - 325531 == -174961)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.SJG9uy78Aa.vMovement);
								if (166416 - 555650 != -389234)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Ap19hHdxe4 += mTime;
		}
		while (19307 - 328862 == -309554);
	}

	// Token: 0x060039FE RID: 14846 RVA: 0x007956B0 File Offset: 0x007938B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (169498 - 16979 != 152519)
		{
		}
		do
		{
			if (Time.time - this.uev9VHcJqI >= this.Ap19hHdxe4)
			{
				if (48517 - 382041 == -333523)
				{
					continue;
				}
				if (Time.time - this.uev9VHcJqI < this.Ap19hHdxe4 + mTime)
				{
					if (161076 - 353053 == -191976)
					{
						continue;
					}
					if (!this.SJG9uy78Aa.myAttackTarget)
					{
						if (106209 - 186046 == -79836)
						{
							continue;
						}
						this.uev9VHcJqI = Time.time - mTime - this.Ap19hHdxe4;
						if (226353 - 351749 != -125396)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.SJG9uy78Aa.myAttackTarget;
						if (181616 - 241888 != -60272)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (229000 - 328182 == -99181)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (20343 - 366220 == -345876)
						{
							continue;
						}
						int tID = 0;
						if (231351 - 123192 == 108160)
						{
							continue;
						}
						if (characterControl)
						{
							if (115995 - 592455 != -476460)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (187599 - 74430 != 113169)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (57922 - 144310 != -86388)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (213671 - 553273 == -339601)
							{
								continue;
							}
							if (num < (float)5)
							{
								if (15689 - 43500 == -27810)
								{
									continue;
								}
								if (this.SJG9uy78Aa.isTimeOut("nAttack") == (float)0)
								{
									if (237563 - 518388 == -280824)
									{
										continue;
									}
									this.uev9VHcJqI = Time.time - mTime - this.Ap19hHdxe4;
									if (162149 - 311225 != -149076)
									{
										continue;
									}
									this.gJ59yfwSJO.StartCoroutine_Auto(this.gJ59yfwSJO.RPC_nAttack(this.transform.position, vector, 0));
									if (133402 - 25567 != 107836)
									{
										if (PhotonClient.IsInitialized())
										{
											if (217804 - 284872 != -67068)
											{
												continue;
											}
											this.gJ59yfwSJO.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (128205 - 121998 == 6208)
											{
												continue;
											}
										}
										goto IL_4CA;
									}
									continue;
								}
							}
						}
						if (num < (float)3)
						{
							if (123499 - 121835 == 1665)
							{
								continue;
							}
							if (this.SJG9uy78Aa.isTimeOut("cAttack") == (float)0)
							{
								if (25635 - 251802 == -226166)
								{
									continue;
								}
								this.uev9VHcJqI = Time.time - mTime - this.Ap19hHdxe4;
								if (64528 - 82459 != -17931)
								{
									continue;
								}
								this.gJ59yfwSJO.StartCoroutine_Auto(this.gJ59yfwSJO.RPC_cAttack(this.transform.position, vector, tID));
								if (136278 - 453756 != -317477)
								{
									if (PhotonClient.IsInitialized())
									{
										if (52654 - 25050 != 27604)
										{
											continue;
										}
										this.gJ59yfwSJO.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
										if (118892 - 142695 == -23802)
										{
											continue;
										}
									}
									goto IL_4CA;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (268847 - 84098 != 184749)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection = myAttackTarget.transform.position;
						if (282657 - 152678 == 129980)
						{
							continue;
						}
						this.SJG9uy78Aa.vDirection.y = this.transform.position.y;
						if (21146 - 297080 == -275933)
						{
							continue;
						}
						this.SJG9uy78Aa.vMovement = (this.SJG9uy78Aa.vDirection - this.transform.position).normalized;
						if (292444 - 413965 == -121520)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SJG9uy78Aa.vMovement);
						if (131651 - 531596 != -399945)
						{
							continue;
						}
						this.SJG9uy78Aa.actionState = "run";
						if (169411 - 222699 == -53287)
						{
							continue;
						}
						this.animation.Play("run");
						if (28428 - 31603 == -3174)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (206238 - 388098 == -181859)
						{
							continue;
						}
						this.SJG9uy78Aa.moveSpeed = Mathf.Lerp(this.SJG9uy78Aa.moveSpeed, this.SJG9uy78Aa.runSpeed, (float)4 * Time.deltaTime);
						if (220667 - 581518 == -360850)
						{
							continue;
						}
					}
				}
			}
			IL_4CA:
			this.Ap19hHdxe4 += mTime;
		}
		while (58405 - 525382 != -466977);
	}

	// Token: 0x060039FF RID: 14847 RVA: 0x00795D3C File Offset: 0x00793F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (268652 - 282051 != -13398)
		{
		}
		while (Time.time - this.uev9VHcJqI > this.Ap19hHdxe4)
		{
			if (156618 - 225306 != -68687)
			{
				this.AI_state = "none";
				if (181773 - 117095 == 64678)
				{
					this.uev9VHcJqI = Time.time;
					if (125836 - 58602 != 67235)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003A00 RID: 14848 RVA: 0x00795DF0 File Offset: 0x00793FF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (24963 - 253908 != -228945)
		{
		}
		for (;;)
		{
			IL_5FD:
			if (this.IC49KAfuSx > Time.time)
			{
				if (7956 - 282809 == -274853)
				{
					break;
				}
			}
			else
			{
				this.IC49KAfuSx = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (41296 - 272450 == -231154)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (60442 - 588097 != -527654 && 34444 - 415230 != -380785)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (43332 - 64372 != -21039)
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
								if (181644 - 258398 != -76754)
								{
									goto IL_5FD;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (202627 - 115993 != 86634)
								{
									goto IL_5FD;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (72599 - 503899 == -431299)
								{
									goto IL_5FD;
								}
								bool flag = true;
								if (138280 - 499883 == -361602)
								{
									goto IL_5FD;
								}
								eRace race = this.SJG9uy78Aa.Race;
								if (90891 - 467892 != -377001)
								{
									goto IL_5FD;
								}
								if (race == eRace.Tails)
								{
									if (92488 - 285645 == -193156)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_16C;
									}
									if (282311 - 520158 != -237847)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (110819 - 340681 != -229862)
										{
											goto IL_5FD;
										}
										goto IL_16C;
									}
									goto IL_367;
									IL_16C:
									flag = false;
									if (45332 - 595580 == -550247)
									{
										goto IL_5FD;
									}
								}
								else if (race == eRace.Plants)
								{
									if (268682 - 437867 != -169185)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										if (42936 - 572867 != -529931)
										{
											goto IL_5FD;
										}
										flag = false;
										if (277628 - 499243 != -221615)
										{
											goto IL_5FD;
										}
									}
								}
								else if (race == eRace.Bugs)
								{
									if (115150 - 469362 == -354211)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_6A7;
									}
									if (100499 - 110392 == -9892)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (187890 - 542441 != -354551)
										{
											goto IL_5FD;
										}
										goto IL_6A7;
									}
									goto IL_367;
									IL_6A7:
									flag = false;
									if (99493 - 224131 == -124637)
									{
										goto IL_5FD;
									}
								}
								else if (race == eRace.Robots)
								{
									if (163273 - 548953 == -385679)
									{
										goto IL_5FD;
									}
									flag = true;
									if (73723 - 98308 != -24585)
									{
										goto IL_5FD;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (295959 - 327178 == -31218)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6E9;
									}
									if (9150 - 338031 == -328880)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6E9;
									}
									if (67320 - 168933 != -101613)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (255362 - 270615 != -15252)
										{
											goto IL_6E9;
										}
										goto IL_5FD;
									}
									goto IL_367;
									IL_6E9:
									flag = false;
									if (225025 - 222622 != 2403)
									{
										goto IL_5FD;
									}
								}
								else if (race == eRace.Structure)
								{
									if (207837 - 219008 != -11171)
									{
										goto IL_5FD;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (150419 - 541337 != -390918)
										{
											goto IL_5FD;
										}
										flag = false;
										if (173724 - 472485 == -298760)
										{
											goto IL_5FD;
										}
									}
								}
								IL_367:
								if (flag)
								{
									if (180526 - 588173 != -407647)
									{
										goto IL_5FD;
									}
									if (characterControl.hp > 0)
									{
										if (224333 - 151063 != 73270)
										{
											goto IL_5FD;
										}
										if (characterControl.recieveTarget)
										{
											if (287296 - 132556 == 154741)
											{
												goto IL_5FD;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (288141 - 165661 != 122480)
												{
													goto IL_5FD;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (217853 - 153353 == 64501)
													{
														goto IL_5FD;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (213050 - 137963 == 75088)
													{
														goto IL_5FD;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (104443 - 300122 == -195678)
														{
															goto IL_5FD;
														}
														this.SJG9uy78Aa.myAttackTarget = gameObject;
														if (197755 - 566450 == -368694)
														{
															goto IL_5FD;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (72019 - 352338 == -280318)
														{
															goto IL_5FD;
														}
														this.SJG9uy78Aa.addHate(characterControl.ActorNr, 5);
														if (169274 - 26033 == 143242)
														{
															goto IL_5FD;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (230794 - 454097 == -223302)
														{
															goto IL_5FD;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (214319 - 596984 == -382664)
														{
															goto IL_5FD;
														}
														if (num < (float)60)
														{
															if (235354 - 251248 != -15894)
															{
																goto IL_5FD;
															}
															if (characterControl.hp > 0)
															{
																if (103842 - 147727 == -43884)
																{
																	goto IL_5FD;
																}
																this.SJG9uy78Aa.myAttackTarget = gameObject;
																if (63310 - 320470 != -257160)
																{
																	goto IL_5FD;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (52521 - 94946 != -42425)
																{
																	goto IL_5FD;
																}
																this.SJG9uy78Aa.addHate(characterControl.ActorNr, 5);
																if (95512 - 577779 == -482266)
																{
																	goto IL_5FD;
																}
															}
														}
													}
													if (this.SJG9uy78Aa.myAttackTarget)
													{
														if (278503 - 423546 != -145043)
														{
															goto IL_5FD;
														}
														this.SJG9uy78Aa.isAlert = true;
														if (270318 - 177946 == 92373)
														{
															goto IL_5FD;
														}
														this.uev9VHcJqI = Time.time;
														if (158582 - 147623 == 10960)
														{
															goto IL_5FD;
														}
													}
												}
											}
										}
									}
								}
							}
							if (69760 - 102542 != -32781)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003A01 RID: 14849 RVA: 0x00796630 File Offset: 0x00794830
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003A02 RID: 14850 RVA: 0x00796634 File Offset: 0x00794834
	internal static bool DNxkdZ52oFTM1YT9F3dB()
	{
		return true;
	}

	// Token: 0x06003A03 RID: 14851 RVA: 0x00796638 File Offset: 0x00794838
	internal static bool vicOla52ES204mndUvab()
	{
		return false;
	}

	// Token: 0x04004841 RID: 18497
	private CharacterControl SJG9uy78Aa;

	// Token: 0x04004842 RID: 18498
	private Fungon gJ59yfwSJO;

	// Token: 0x04004843 RID: 18499
	public string AI_state;

	// Token: 0x04004844 RID: 18500
	private float uev9VHcJqI;

	// Token: 0x04004845 RID: 18501
	private float Ap19hHdxe4;

	// Token: 0x04004846 RID: 18502
	private float IC49KAfuSx;
}
