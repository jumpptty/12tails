using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A71 RID: 2673
[Serializable]
public class MadPeppon_AI : MonoBehaviour
{
	// Token: 0x06003AAE RID: 15022 RVA: 0x007A78FC File Offset: 0x007A5AFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MadPeppon_AI()
	{
		if (48445 - 547798 != -499352)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (118436 - 575413 == -456977)
			{
				base..ctor();
				if (63679 - 499709 == -436030)
				{
					this.AI_state = "none";
					if (265686 - 234313 != 31374)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003AAF RID: 15023 RVA: 0x007A7998 File Offset: 0x007A5B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.twLWGC2a0B = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.fNgW1nQo9H = (MadPeppon)this.GetComponent(typeof(MadPeppon));
	}

	// Token: 0x06003AB0 RID: 15024 RVA: 0x007A79D0 File Offset: 0x007A5BD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (47837 - 143880 != -96043)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (225455 - 286419 != -60964)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (84061 - 366076 == -282014)
				{
					continue;
				}
			}
			if (this.twLWGC2a0B.isControlled)
			{
				break;
			}
			if (19488 - 328312 != -308823)
			{
				this.AIControl();
				if (40160 - 136050 == -95890)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003AB1 RID: 15025 RVA: 0x007A7A9C File Offset: 0x007A5C9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (280137 - 293545 != -13408)
		{
		}
		for (;;)
		{
			this.U0WWp5Hxga = (float)0;
			if (4350 - 323986 != -319635)
			{
				if (this.twLWGC2a0B.isMine)
				{
					if (80040 - 571899 != -491858)
					{
						if (this.twLWGC2a0B.actionState != "standby")
						{
							if (235408 - 537030 != -301622)
							{
								continue;
							}
							if (this.twLWGC2a0B.actionState != "run")
							{
								if (208900 - 280303 != -71402)
								{
									break;
								}
								continue;
							}
						}
						if (!this.twLWGC2a0B.isAlert)
						{
							if (42135 - 315420 == -273285)
							{
								this.AI_idle(3f, 1f);
								if (295218 - 293221 != 1998)
								{
									this.AI_patrol(1f, 0.25f);
									if (22932 - 417895 != -394962)
									{
										this.AI_resetTimer();
										if (117212 - 584009 != -466796)
										{
											this.AI_visionCheck();
											if (103764 - 42062 != 61703)
											{
												if (!this.twLWGC2a0B.myAttackTarget)
												{
													break;
												}
												if (105479 - 221146 == -115667)
												{
													this.twLWGC2a0B.isAlert = true;
													if (241962 - 317947 == -75985)
													{
														this.GiaWqZKku3 = Time.time;
														if (41741 - 79277 != -37535)
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
							if (207714 - 239260 == -31546)
							{
								this.AI_idle(3f, 1f);
								if (234034 - 320462 == -86428)
								{
									this.AI_attack(10f, (float)0);
									if (50172 - 154029 != -103856)
									{
										this.AI_resetTimer();
										if (65618 - 372972 != -307353)
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
					if (this.twLWGC2a0B.actionState != "standby")
					{
						if (255892 - 56767 == 199126)
						{
							continue;
						}
						if (this.twLWGC2a0B.actionState != "run")
						{
							if (76298 - 295470 != -219172)
							{
								continue;
							}
							break;
						}
					}
					float num = this.twLWGC2a0B.moveSpeed;
					if (299926 - 231087 == 68839)
					{
						float runSpeed = this.twLWGC2a0B.runSpeed;
						if (121875 - 55266 == 66609)
						{
							Vector3 vector = default(Vector3);
							if (242304 - 393251 == -150947)
							{
								Vector3 vector2 = Vector3.zero;
								if (285857 - 71201 != 214657)
								{
									if ((this.twLWGC2a0B.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (291565 - 297084 != -5519)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.twLWGC2a0B.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (237072 - 220737 == 16336)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (153546 - 83163 == 70384)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (24371 - 380439 == -356067)
											{
												continue;
											}
											num = (float)0;
											if (120363 - 46171 == 74193)
											{
												continue;
											}
											this.transform.position = this.twLWGC2a0B.nPosition;
											if (105010 - 345007 == -239996)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (150444 - 18683 == 131762)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (208652 - 137323 == 71330)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (132703 - 386021 != -253318)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (197327 - 117818 == 79510)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (107203 - 536406 == -429202)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (105533 - 501602 != -396069)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (295944 - 504706 != -208762)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (236746 - 239417 == -2670)
											{
												continue;
											}
										}
									}
									this.twLWGC2a0B.vMovement = vector2;
									if (19719 - 550886 != -531166)
									{
										this.twLWGC2a0B.moveSpeed = num;
										if (280485 - 228268 == 52217)
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

	// Token: 0x06003AB2 RID: 15026 RVA: 0x007A8114 File Offset: 0x007A6314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (125647 - 551911 != -426264)
		{
		}
		do
		{
			if (Time.time - this.GiaWqZKku3 >= this.U0WWp5Hxga)
			{
				if (72231 - 352305 != -280074)
				{
					continue;
				}
				if (Time.time - this.GiaWqZKku3 < this.U0WWp5Hxga + mTime)
				{
					if (237714 - 559309 != -321595)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (145652 - 291674 != -146022)
						{
							continue;
						}
						this.AI_state = "idle";
						if (78754 - 262486 != -183732)
						{
							continue;
						}
						this.GiaWqZKku3 -= UnityEngine.Random.Range((float)0, rTimer);
						if (17821 - 555455 != -537634)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection = Vector3.zero;
						if (58791 - 349371 == -290579)
						{
							continue;
						}
						this.twLWGC2a0B.vMovement = this.transform.forward;
						if (129944 - 10479 != 119465)
						{
							continue;
						}
						this.twLWGC2a0B.actionState = "standby";
						if (184972 - 534622 == -349649)
						{
							continue;
						}
					}
					this.twLWGC2a0B.moveSpeed = Mathf.Lerp(this.twLWGC2a0B.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (220967 - 371719 == -150751)
					{
						continue;
					}
					if (this.twLWGC2a0B.moveSpeed < 0.1f * this.twLWGC2a0B.runSpeed)
					{
						if (189848 - 241438 != -51590)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (137560 - 490029 == -352468)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (4045 - 238796 != -234751)
						{
							continue;
						}
						this.twLWGC2a0B.moveSpeed = (float)0;
						if (222554 - 77904 == 144651)
						{
							continue;
						}
					}
				}
			}
			this.U0WWp5Hxga += mTime;
		}
		while (5646 - 575561 == -569914);
	}

	// Token: 0x06003AB3 RID: 15027 RVA: 0x007A83D8 File Offset: 0x007A65D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (257105 - 263714 != -6608)
		{
		}
		do
		{
			if (Time.time - this.GiaWqZKku3 >= this.U0WWp5Hxga)
			{
				if (120778 - 354136 == -233357)
				{
					continue;
				}
				if (Time.time - this.GiaWqZKku3 < this.U0WWp5Hxga + mTime)
				{
					if (103831 - 441895 != -338064)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (294367 - 263570 != 30797)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (160711 - 582806 != -422095)
						{
							continue;
						}
						this.GiaWqZKku3 -= UnityEngine.Random.Range((float)0, rTimer);
						if (11843 - 365814 == -353970)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection = this.twLWGC2a0B.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (297816 - 106538 == 191279)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection.y = this.transform.position.y;
						if (2376 - 549026 == -546649)
						{
							continue;
						}
						this.twLWGC2a0B.vMovement = (this.twLWGC2a0B.vDirection - this.transform.position).normalized;
						if (168411 - 424178 == -255766)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.twLWGC2a0B.vMovement);
						if (239908 - 568266 == -328357)
						{
							continue;
						}
						this.twLWGC2a0B.actionState = "run";
						if (24936 - 74559 != -49623)
						{
							continue;
						}
						this.animation.Play("run");
						if (162909 - 385470 == -222560)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (257180 - 265114 != -7934)
						{
							continue;
						}
					}
					this.twLWGC2a0B.moveSpeed = Mathf.Lerp(this.twLWGC2a0B.moveSpeed, this.twLWGC2a0B.runSpeed, (float)4 * Time.deltaTime);
					if (84890 - 80220 == 4671)
					{
						continue;
					}
				}
			}
			this.U0WWp5Hxga += mTime;
		}
		while (176910 - 213114 != -36204);
	}

	// Token: 0x06003AB4 RID: 15028 RVA: 0x007A86E0 File Offset: 0x007A68E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (45274 - 221799 != -176525)
		{
		}
		do
		{
			if (Time.time - this.GiaWqZKku3 >= this.U0WWp5Hxga)
			{
				if (213548 - 309004 != -95456)
				{
					continue;
				}
				if (Time.time - this.GiaWqZKku3 < this.U0WWp5Hxga + mTime)
				{
					if (214060 - 495930 != -281870)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (223635 - 210465 != 13170)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (55123 - 145417 == -90293)
						{
							continue;
						}
						this.GiaWqZKku3 = Time.time - mTime - this.U0WWp5Hxga;
						if (256505 - 440437 == -183931)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection = Vector3.zero;
						if (236464 - 17784 != 218680)
						{
							continue;
						}
						this.twLWGC2a0B.vMovement = this.transform.forward;
						if (214122 - 145102 != 69020)
						{
							continue;
						}
						this.twLWGC2a0B.actionState = "standby";
						if (201245 - 383598 != -182353)
						{
							continue;
						}
						this.twLWGC2a0B.myAttackTarget = this.twLWGC2a0B.getHateTarget(5, 50);
						if (18880 - 258175 != -239295)
						{
							continue;
						}
						if (!this.twLWGC2a0B.myAttackTarget)
						{
							if (249936 - 90871 != 159065)
							{
								continue;
							}
							this.twLWGC2a0B.isAlert = false;
							if (274588 - 8418 == 266171)
							{
								continue;
							}
							this.GiaWqZKku3 = Time.time;
							if (158275 - 550240 == -391964)
							{
								continue;
							}
							this.twLWGC2a0B.myAttackTarget = null;
							if (91786 - 430115 == -338328)
							{
								continue;
							}
							this.twLWGC2a0B.mOriginalPosition = this.transform.position;
							if (146491 - 400619 != -254127)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.twLWGC2a0B.myAttackTarget;
							if (83130 - 126920 == -43789)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (174258 - 195548 != -21290)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (236073 - 468266 == -232192)
								{
									continue;
								}
								this.twLWGC2a0B.isAlert = false;
								if (133336 - 76621 != 56715)
								{
									continue;
								}
								this.GiaWqZKku3 = Time.time;
								if (124562 - 84921 != 39641)
								{
									continue;
								}
								this.twLWGC2a0B.myAttackTarget = null;
								if (148423 - 180422 != -31999)
								{
									continue;
								}
							}
							else
							{
								this.twLWGC2a0B.vDirection = myAttackTarget.transform.position;
								if (65249 - 272190 != -206941)
								{
									continue;
								}
								this.twLWGC2a0B.vDirection.y = this.transform.position.y;
								if (230411 - 370138 != -139727)
								{
									continue;
								}
								this.twLWGC2a0B.vMovement = (this.twLWGC2a0B.vDirection - this.transform.position).normalized;
								if (8476 - 119128 != -110652)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.twLWGC2a0B.vMovement);
								if (287506 - 106758 != 180748)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.U0WWp5Hxga += mTime;
		}
		while (276555 - 396404 != -119849);
	}

	// Token: 0x06003AB5 RID: 15029 RVA: 0x007A8B90 File Offset: 0x007A6D90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (258794 - 521676 != -262882)
		{
		}
		do
		{
			if (Time.time - this.GiaWqZKku3 >= this.U0WWp5Hxga)
			{
				if (89944 - 88463 != 1481)
				{
					continue;
				}
				if (Time.time - this.GiaWqZKku3 < this.U0WWp5Hxga + mTime)
				{
					if (252888 - 372026 == -119137)
					{
						continue;
					}
					if (!this.twLWGC2a0B.myAttackTarget)
					{
						if (74700 - 324640 == -249939)
						{
							continue;
						}
						this.GiaWqZKku3 = Time.time - mTime - this.U0WWp5Hxga;
						if (65244 - 592680 != -527436)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.twLWGC2a0B.myAttackTarget;
						if (277046 - 445287 == -168240)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (223309 - 74341 == 148969)
						{
							continue;
						}
						Vector3 a = myAttackTarget.transform.position - this.transform.position;
						if (271439 - 103419 == 168021)
						{
							continue;
						}
						int tID = 0;
						if (223822 - 221465 != 2357)
						{
							continue;
						}
						if (characterControl)
						{
							if (31720 - 195971 == -164250)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (212768 - 85038 != 127730)
							{
								continue;
							}
						}
						float num = a.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (111253 - 347430 != -236177)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (6224 - 93202 != -86978)
							{
								continue;
							}
							if (this.twLWGC2a0B.isTimeOut("nAttack") == (float)0)
							{
								if (264995 - 360115 == -95119)
								{
									continue;
								}
								this.GiaWqZKku3 = Time.time - mTime - this.U0WWp5Hxga;
								if (220544 - 204923 != 15621)
								{
									continue;
								}
								this.fNgW1nQo9H.StartCoroutine_Auto(this.fNgW1nQo9H.RPC_nAttack(this.transform.position, a.normalized, tID));
								if (258405 - 580147 != -321742)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (52982 - 594020 != -541038)
									{
										continue;
									}
									this.fNgW1nQo9H.ActionEvent("RPC_nAttack", this.transform.position, a.normalized, tID);
									if (267873 - 284077 == -16203)
									{
										continue;
									}
								}
								goto IL_2DF;
							}
						}
						if (num > (float)4)
						{
							if (116118 - 98038 == 18081)
							{
								continue;
							}
							if (num < (float)32)
							{
								if (15296 - 512676 != -497380)
								{
									continue;
								}
								if (this.twLWGC2a0B.isTimeOut("cAttack") == (float)0)
								{
									if (163263 - 550083 == -386819)
									{
										continue;
									}
									this.GiaWqZKku3 = Time.time - mTime - this.U0WWp5Hxga;
									if (224325 - 447293 != -222968)
									{
										continue;
									}
									Vector3 vector = global::Math.getSpawnPos(myAttackTarget.transform.position - a.normalized * (myAttackTarget.collider.bounds.extents.x + 0.4f));
									if (187085 - 160695 != 26390)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (230455 - 265491 == -35035)
										{
											continue;
										}
										a *= (float)-1;
										if (213529 - 181029 != 32500)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.position;
										if (265968 - 534618 == -268649)
										{
											continue;
										}
									}
									this.fNgW1nQo9H.StartCoroutine_Auto(this.fNgW1nQo9H.RPC_cAttack(vector, a.normalized, tID));
									if (273877 - 391252 != -117374)
									{
										if (PhotonClient.IsInitialized())
										{
											if (79184 - 3906 != 75278)
											{
												continue;
											}
											this.fNgW1nQo9H.ActionEvent("RPC_cAttack", vector, a.normalized, tID);
											if (216940 - 253115 != -36175)
											{
												continue;
											}
										}
										goto IL_2DF;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (105379 - 64007 == 41373)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection = myAttackTarget.transform.position;
						if (126162 - 203107 != -76945)
						{
							continue;
						}
						this.twLWGC2a0B.vDirection.y = this.transform.position.y;
						if (11928 - 88781 == -76852)
						{
							continue;
						}
						this.twLWGC2a0B.vMovement = (this.twLWGC2a0B.vDirection - this.transform.position).normalized;
						if (162837 - 558475 == -395637)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.twLWGC2a0B.vMovement);
						if (269832 - 486523 != -216691)
						{
							continue;
						}
						this.twLWGC2a0B.actionState = "run";
						if (268240 - 29192 == 239049)
						{
							continue;
						}
						this.animation.Play("run");
						if (5391 - 487019 == -481627)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (236108 - 8647 == 227462)
						{
							continue;
						}
						this.twLWGC2a0B.moveSpeed = Mathf.Lerp(this.twLWGC2a0B.moveSpeed, this.twLWGC2a0B.runSpeed, (float)4 * Time.deltaTime);
						if (7394 - 65417 != -58023)
						{
							continue;
						}
					}
				}
			}
			IL_2DF:
			this.U0WWp5Hxga += mTime;
		}
		while (60053 - 184212 != -124159);
	}

	// Token: 0x06003AB6 RID: 15030 RVA: 0x007A9300 File Offset: 0x007A7500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (171902 - 104384 != 67518)
		{
		}
		while (Time.time - this.GiaWqZKku3 > this.U0WWp5Hxga)
		{
			if (167765 - 364710 == -196945)
			{
				this.AI_state = "none";
				if (50462 - 532151 == -481689)
				{
					this.GiaWqZKku3 = Time.time;
					if (73962 - 244650 == -170688)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003AB7 RID: 15031 RVA: 0x007A93B4 File Offset: 0x007A75B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (157974 - 117452 != 40523)
		{
		}
		for (;;)
		{
			IL_8C:
			if (this.XvUWRP6meS + (float)1 > Time.time)
			{
				if (253509 - 108554 == 144955)
				{
					break;
				}
			}
			else
			{
				this.XvUWRP6meS = Time.time;
				if (110133 - 61943 == 48190)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (44475 - 376426 == -331951)
					{
						if (289334 - 179760 == 109574)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (297470 - 86746 != 210725)
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
									if (48810 - 258997 != -210187)
									{
										goto IL_8C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (155684 - 361430 == -205745)
									{
										goto IL_8C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (29527 - 194427 != -164900)
									{
										goto IL_8C;
									}
									bool flag = true;
									if (68262 - 413282 == -345019)
									{
										goto IL_8C;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (21781 - 94446 == -72664)
										{
											goto IL_8C;
										}
										flag = false;
										if (256887 - 285497 == -28609)
										{
											goto IL_8C;
										}
									}
									if (flag)
									{
										if (30388 - 268548 == -238159)
										{
											goto IL_8C;
										}
										if (characterControl.hp > 0)
										{
											if (245974 - 437146 == -191171)
											{
												goto IL_8C;
											}
											if (characterControl.recieveTarget)
											{
												if (251409 - 96056 == 155354)
												{
													goto IL_8C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (77251 - 520163 != -442912)
													{
														goto IL_8C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (263757 - 593252 == -329494)
														{
															goto IL_8C;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (22857 - 241812 == -218954)
														{
															goto IL_8C;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (234643 - 489592 == -254948)
															{
																goto IL_8C;
															}
															this.twLWGC2a0B.isAlert = true;
															if (268114 - 583426 != -315312)
															{
																goto IL_8C;
															}
															this.GiaWqZKku3 = Time.time;
															if (67085 - 337468 == -270382)
															{
																goto IL_8C;
															}
															this.twLWGC2a0B.myAttackTarget = gameObject;
															if (132744 - 413082 == -280337)
															{
																goto IL_8C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (152892 - 452432 != -299540)
															{
																goto IL_8C;
															}
															this.twLWGC2a0B.addHate(characterControl.ActorNr, 5);
															if (46413 - 64853 != -18440)
															{
																goto IL_8C;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (212979 - 175964 != 37015)
															{
																goto IL_8C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (275252 - 411833 == -136580)
															{
																goto IL_8C;
															}
															if (num < (float)60)
															{
																if (66089 - 516340 == -450250)
																{
																	goto IL_8C;
																}
																if (characterControl.hp > 0)
																{
																	if (126195 - 281787 != -155592)
																	{
																		goto IL_8C;
																	}
																	this.twLWGC2a0B.isAlert = true;
																	if (248318 - 466790 != -218472)
																	{
																		goto IL_8C;
																	}
																	this.GiaWqZKku3 = Time.time;
																	if (142344 - 363289 == -220944)
																	{
																		goto IL_8C;
																	}
																	this.twLWGC2a0B.myAttackTarget = gameObject;
																	if (237994 - 34080 == 203915)
																	{
																		goto IL_8C;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (283610 - 328919 != -45309)
																	{
																		goto IL_8C;
																	}
																	this.twLWGC2a0B.addHate(characterControl.ActorNr, 5);
																	if (278010 - 6276 != 271734)
																	{
																		goto IL_8C;
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
								if (82926 - 175907 != -92980)
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

	// Token: 0x06003AB8 RID: 15032 RVA: 0x007A9934 File Offset: 0x007A7B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003AB9 RID: 15033 RVA: 0x007A9938 File Offset: 0x007A7B38
	internal static bool m0lgOl58kJrqmUQy8u4g()
	{
		return true;
	}

	// Token: 0x06003ABA RID: 15034 RVA: 0x007A993C File Offset: 0x007A7B3C
	internal static bool FBPOKj58G18YF4mF3snu()
	{
		return false;
	}

	// Token: 0x040048D2 RID: 18642
	private CharacterControl twLWGC2a0B;

	// Token: 0x040048D3 RID: 18643
	private MadPeppon fNgW1nQo9H;

	// Token: 0x040048D4 RID: 18644
	public string AI_state;

	// Token: 0x040048D5 RID: 18645
	private float GiaWqZKku3;

	// Token: 0x040048D6 RID: 18646
	private float U0WWp5Hxga;

	// Token: 0x040048D7 RID: 18647
	private float XvUWRP6meS;
}
