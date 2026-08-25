using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BE5 RID: 3045
[Serializable]
public class DarkFalcon_AI : MonoBehaviour
{
	// Token: 0x060043E8 RID: 17384 RVA: 0x008896B0 File Offset: 0x008878B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DarkFalcon_AI()
	{
		if (69947 - 131779 != -61831)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (120618 - 521885 != -401266)
			{
				base..ctor();
				if (177510 - 366593 != -189082)
				{
					this.AI_state = "none";
					if (14925 - 199568 != -184642)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060043E9 RID: 17385 RVA: 0x0088974C File Offset: 0x0088794C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.C8oh6eO0TQ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.qewhtgew1V = (DarkFalcon)this.GetComponent(typeof(DarkFalcon));
	}

	// Token: 0x060043EA RID: 17386 RVA: 0x00889784 File Offset: 0x00887984
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (126993 - 193832 != -66839)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (243468 - 195031 == 48438)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (187158 - 163921 != 23237)
				{
					continue;
				}
			}
			if (this.C8oh6eO0TQ.isControlled)
			{
				break;
			}
			if (252455 - 532711 == -280256)
			{
				this.AIControl();
				if (295341 - 164554 != 130788)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060043EB RID: 17387 RVA: 0x00889850 File Offset: 0x00887A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (112311 - 243517 != -131205)
		{
		}
		for (;;)
		{
			this.yfahOMybCM = (float)0;
			if (196328 - 179288 != 17041)
			{
				if (this.C8oh6eO0TQ.isMine)
				{
					if (222152 - 221342 != 811)
					{
						if (this.C8oh6eO0TQ.actionState != "standby")
						{
							if (224182 - 328853 != -104671)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.actionState != "run")
							{
								if (65371 - 534179 != -468807)
								{
									break;
								}
								continue;
							}
						}
						if (!this.C8oh6eO0TQ.isAlert)
						{
							if (89380 - 149074 != -59693)
							{
								this.AI_idle(3f, 1f);
								if (41239 - 158392 == -117153)
								{
									this.AI_resetTimer();
									if (197996 - 28194 == 169802)
									{
										this.AI_visionCheck();
										if (11832 - 9856 == 1976)
										{
											if (!this.C8oh6eO0TQ.myAttackTarget)
											{
												break;
											}
											if (147795 - 420446 != -272650)
											{
												this.C8oh6eO0TQ.isAlert = true;
												if (146947 - 565865 != -418917)
												{
													this.zbJhXo5eRy = Time.time;
													if (163969 - 521885 != -357915)
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
							if (133434 - 391650 != -258215)
							{
								this.AI_idle(1f, 1f);
								if (112229 - 463470 != -351240)
								{
									this.AI_patrol(2f, 2f);
									if (7873 - 297379 == -289506)
									{
										this.AI_attack(13f, (float)0);
										if (228140 - 288873 != -60732)
										{
											this.AI_resetTimer();
											if (28096 - 388081 != -359984)
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
					if (this.C8oh6eO0TQ.actionState != "standby")
					{
						if (209232 - 251404 != -42172)
						{
							continue;
						}
						if (this.C8oh6eO0TQ.actionState != "run")
						{
							if (160329 - 242743 != -82413)
							{
								break;
							}
							continue;
						}
					}
					float num = this.C8oh6eO0TQ.moveSpeed;
					if (127678 - 229548 != -101869)
					{
						float runSpeed = this.C8oh6eO0TQ.runSpeed;
						if (40476 - 491080 == -450604)
						{
							Vector3 vector = default(Vector3);
							if (231798 - 427036 != -195237)
							{
								Vector3 vector2 = Vector3.zero;
								if (255661 - 279226 != -23564)
								{
									if ((this.C8oh6eO0TQ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (32631 - 341752 == -309120)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.C8oh6eO0TQ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (122275 - 429656 != -307381)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (80397 - 352880 != -272483)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (182789 - 14797 != 167992)
											{
												continue;
											}
											num = (float)0;
											if (268746 - 395609 != -126863)
											{
												continue;
											}
											this.transform.position = this.C8oh6eO0TQ.nPosition;
											if (140081 - 130912 == 9170)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (4706 - 136977 != -132271)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (177018 - 420131 != -243113)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (193160 - 151814 == 41347)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (134988 - 269083 != -134095)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (252183 - 81672 == 170512)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (167433 - 475445 == -308011)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (260049 - 188760 == 71290)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (33668 - 315998 == -282329)
											{
												continue;
											}
										}
									}
									this.C8oh6eO0TQ.vMovement = vector2;
									if (122893 - 407539 == -284646)
									{
										this.C8oh6eO0TQ.moveSpeed = num;
										if (120144 - 588336 == -468192)
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

	// Token: 0x060043EC RID: 17388 RVA: 0x00889EC8 File Offset: 0x008880C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (225609 - 291002 != -65392)
		{
		}
		do
		{
			if (Time.time - this.zbJhXo5eRy >= this.yfahOMybCM)
			{
				if (173661 - 295301 != -121640)
				{
					continue;
				}
				if (Time.time - this.zbJhXo5eRy < this.yfahOMybCM + mTime)
				{
					if (223730 - 404165 == -180434)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (115482 - 322302 == -206819)
						{
							continue;
						}
						this.AI_state = "idle";
						if (94992 - 243905 != -148913)
						{
							continue;
						}
						this.zbJhXo5eRy -= UnityEngine.Random.Range((float)0, rTimer);
						if (181551 - 414955 != -233404)
						{
							continue;
						}
						this.C8oh6eO0TQ.vDirection = Vector3.zero;
						if (121681 - 359068 == -237386)
						{
							continue;
						}
						this.C8oh6eO0TQ.vMovement = this.transform.forward;
						if (275901 - 82808 == 193094)
						{
							continue;
						}
						this.C8oh6eO0TQ.actionState = "standby";
						if (170244 - 18129 == 152116)
						{
							continue;
						}
					}
					this.C8oh6eO0TQ.moveSpeed = Mathf.Lerp(this.C8oh6eO0TQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (13585 - 395245 != -381660)
					{
						continue;
					}
					if (this.C8oh6eO0TQ.moveSpeed < 0.1f * this.C8oh6eO0TQ.runSpeed)
					{
						if (146272 - 471137 == -324864)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (192464 - 202608 == -10143)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (160004 - 471517 != -311513)
						{
							continue;
						}
						this.C8oh6eO0TQ.moveSpeed = (float)0;
						if (100319 - 340541 == -240221)
						{
							continue;
						}
					}
				}
			}
			this.yfahOMybCM += mTime;
		}
		while (122275 - 535779 == -413503);
	}

	// Token: 0x060043ED RID: 17389 RVA: 0x0088A18C File Offset: 0x0088838C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (113077 - 114037 != -960)
		{
		}
		do
		{
			if (Time.time - this.zbJhXo5eRy >= this.yfahOMybCM)
			{
				if (175021 - 9543 == 165479)
				{
					continue;
				}
				if (Time.time - this.zbJhXo5eRy < this.yfahOMybCM + mTime)
				{
					if (63509 - 271357 == -207847)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (268485 - 217649 != 50836)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (100220 - 255146 == -154925)
						{
							continue;
						}
						this.zbJhXo5eRy -= UnityEngine.Random.Range((float)0, rTimer);
						if (19010 - 258771 != -239761)
						{
							continue;
						}
						this.C8oh6eO0TQ.vDirection = this.C8oh6eO0TQ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (278293 - 140483 != 137810)
						{
							continue;
						}
						this.C8oh6eO0TQ.vDirection.y = this.transform.position.y;
						if (29961 - 88315 == -58353)
						{
							continue;
						}
						this.C8oh6eO0TQ.vMovement = (this.C8oh6eO0TQ.vDirection - this.transform.position).normalized;
						if (133164 - 527561 != -394397)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.C8oh6eO0TQ.vMovement);
						if (177797 - 577626 != -399829)
						{
							continue;
						}
						this.C8oh6eO0TQ.actionState = "run";
						if (31118 - 184137 != -153019)
						{
							continue;
						}
						this.animation.Play("run");
						if (56301 - 160906 == -104604)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (141953 - 42291 != 99662)
						{
							continue;
						}
					}
					this.C8oh6eO0TQ.moveSpeed = Mathf.Lerp(this.C8oh6eO0TQ.moveSpeed, this.C8oh6eO0TQ.runSpeed, (float)4 * Time.deltaTime);
					if (215065 - 520789 == -305723)
					{
						continue;
					}
				}
			}
			this.yfahOMybCM += mTime;
		}
		while (132966 - 547534 != -414568);
	}

	// Token: 0x060043EE RID: 17390 RVA: 0x0088A494 File Offset: 0x00888694
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (237449 - 346302 != -108852)
		{
		}
		do
		{
			if (Time.time - this.zbJhXo5eRy >= this.yfahOMybCM)
			{
				if (240873 - 588340 == -347466)
				{
					continue;
				}
				if (Time.time - this.zbJhXo5eRy < this.yfahOMybCM + mTime)
				{
					if (293224 - 249731 == 43494)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (146236 - 131717 != 14519)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (98031 - 227431 == -129399)
						{
							continue;
						}
						this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
						if (70008 - 195699 != -125691)
						{
							continue;
						}
						this.C8oh6eO0TQ.vDirection = Vector3.zero;
						if (284373 - 88056 == 196318)
						{
							continue;
						}
						this.C8oh6eO0TQ.vMovement = this.transform.forward;
						if (121465 - 467951 != -346486)
						{
							continue;
						}
						this.C8oh6eO0TQ.actionState = "standby";
						if (118419 - 127770 == -9350)
						{
							continue;
						}
						this.C8oh6eO0TQ.myAttackTarget = this.C8oh6eO0TQ.getRandomHateTarget(50);
						if (59112 - 148713 != -89601)
						{
							continue;
						}
						if (!this.C8oh6eO0TQ.myAttackTarget)
						{
							if (154553 - 135698 == 18856)
							{
								continue;
							}
							this.C8oh6eO0TQ.isAlert = false;
							if (263172 - 277190 != -14018)
							{
								continue;
							}
							this.zbJhXo5eRy = Time.time;
							if (30072 - 262337 == -232264)
							{
								continue;
							}
							this.C8oh6eO0TQ.myAttackTarget = null;
							if (209522 - 528657 == -319134)
							{
								continue;
							}
							this.C8oh6eO0TQ.mOriginalPosition = this.transform.position;
							if (220 - 537926 != -537706)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.C8oh6eO0TQ.myAttackTarget;
							if (76622 - 452811 == -376188)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (255509 - 333897 == -78387)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (295770 - 226113 != 69657)
								{
									continue;
								}
								this.C8oh6eO0TQ.isAlert = false;
								if (72142 - 524924 == -452781)
								{
									continue;
								}
								this.zbJhXo5eRy = Time.time;
								if (210407 - 562985 == -352577)
								{
									continue;
								}
								this.C8oh6eO0TQ.myAttackTarget = null;
								if (32761 - 471765 != -439004)
								{
									continue;
								}
							}
							else
							{
								this.C8oh6eO0TQ.vDirection = myAttackTarget.transform.position;
								if (138006 - 471210 != -333204)
								{
									continue;
								}
								this.C8oh6eO0TQ.vDirection.y = this.transform.position.y;
								if (114622 - 24102 == 90521)
								{
									continue;
								}
								this.C8oh6eO0TQ.vMovement = (this.C8oh6eO0TQ.vDirection - this.transform.position).normalized;
								if (171512 - 337222 != -165710)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.C8oh6eO0TQ.vMovement);
								if (3061 - 180426 != -177365)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.yfahOMybCM += mTime;
		}
		while (141531 - 368840 != -227309);
	}

	// Token: 0x060043EF RID: 17391 RVA: 0x0088A944 File Offset: 0x00888B44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (273835 - 112523 != 161312)
		{
		}
		do
		{
			if (Time.time - this.zbJhXo5eRy >= this.yfahOMybCM)
			{
				if (251691 - 220044 != 31647)
				{
					continue;
				}
				if (Time.time - this.zbJhXo5eRy < this.yfahOMybCM + mTime)
				{
					if (213034 - 201232 == 11803)
					{
						continue;
					}
					if (!this.C8oh6eO0TQ.myAttackTarget)
					{
						if (47610 - 480154 == -432543)
						{
							continue;
						}
						this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
						if (139052 - 213680 != -74627)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.C8oh6eO0TQ.myAttackTarget;
						if (261239 - 550226 == -288986)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (187842 - 62883 != 124959)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (219331 - 179194 != 40137)
						{
							continue;
						}
						int tID = 0;
						if (209916 - 163033 != 46883)
						{
							continue;
						}
						if (characterControl)
						{
							if (223095 - 12907 != 210188)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (221338 - 5438 == 215901)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (146006 - 454658 == -308651)
						{
							continue;
						}
						if (this.C8oh6eO0TQ.hp <= 130000)
						{
							if (148391 - 449651 == -301259)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.isTimeOut("shadowRain") == (float)0)
							{
								if (32069 - 229225 != -197156)
								{
									continue;
								}
								this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
								if (31285 - 557955 == -526669)
								{
									continue;
								}
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_shadowRain(this.transform.position, vector, tID));
								if (74650 - 427155 != -352505)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (134825 - 491976 == -357150)
									{
										continue;
									}
									this.qewhtgew1V.ActionEvent("RPC_shadowRain", this.transform.position, vector, tID);
									if (214198 - 404412 == -190213)
									{
										continue;
									}
								}
								goto IL_462;
							}
						}
						if (this.C8oh6eO0TQ.hp <= 140000)
						{
							if (17126 - 588556 == -571429)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.sp >= 50)
							{
								if (244822 - 122257 == 122566)
								{
									continue;
								}
								if (this.C8oh6eO0TQ.isTimeOut("darkStorm") == (float)0)
								{
									if (274887 - 245415 == 29473)
									{
										continue;
									}
									if (num > (float)7)
									{
										if (105792 - 76464 == 29329)
										{
											continue;
										}
										this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
										if (10616 - 240316 != -229700)
										{
											continue;
										}
										this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_darkStorm(this.transform.position, vector, tID));
										if (233350 - 430028 != -196678)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (222626 - 288291 != -65665)
											{
												continue;
											}
											this.qewhtgew1V.ActionEvent("RPC_darkStorm", this.transform.position, vector, tID);
											if (11963 - 291598 == -279634)
											{
												continue;
											}
										}
										goto IL_462;
									}
								}
							}
						}
						if (this.C8oh6eO0TQ.hp <= 145000)
						{
							if (181587 - 139569 == 42019)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.sp >= 50)
							{
								if (257669 - 533523 == -275853)
								{
									continue;
								}
								if (this.C8oh6eO0TQ.isTimeOut("darkFall") == (float)0)
								{
									if (29308 - 463339 != -434031)
									{
										continue;
									}
									if (num < (float)13)
									{
										if (225802 - 482287 == -256484)
										{
											continue;
										}
										this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
										if (225588 - 281880 != -56292)
										{
											continue;
										}
										this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_darkFall(this.transform.position, vector, tID));
										if (265800 - 93291 != 172509)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (210622 - 507071 == -296448)
											{
												continue;
											}
											this.qewhtgew1V.ActionEvent("RPC_darkFall", this.transform.position, vector, tID);
											if (75886 - 103083 != -27197)
											{
												continue;
											}
										}
										goto IL_462;
									}
								}
							}
						}
						if (this.C8oh6eO0TQ.hp <= 160000)
						{
							if (95699 - 68228 == 27472)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.mp >= 50)
							{
								if (125241 - 272186 != -146945)
								{
									continue;
								}
								if (this.C8oh6eO0TQ.isTimeOut("nightmare") == (float)0)
								{
									if (53880 - 437687 != -383807)
									{
										continue;
									}
									this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
									if (111497 - 377306 != -265809)
									{
										continue;
									}
									this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_nightmare(this.transform.position, vector, tID));
									if (15542 - 289723 != -274181)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (269025 - 570201 == -301175)
										{
											continue;
										}
										this.qewhtgew1V.ActionEvent("RPC_nightmare", this.transform.position, vector, tID);
										if (249275 - 438095 == -188819)
										{
											continue;
										}
									}
									goto IL_462;
								}
							}
						}
						if (num >= (float)5)
						{
							if (79956 - 92256 == -12299)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.isTimeOut("thousandShot") == (float)0)
							{
								if (222037 - 111742 != 110295)
								{
									continue;
								}
								this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
								if (102950 - 104524 != -1574)
								{
									continue;
								}
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_thousandShot(this.transform.position, vector, tID));
								if (37397 - 315074 != -277676)
								{
									if (PhotonClient.IsInitialized())
									{
										if (121598 - 125048 == -3449)
										{
											continue;
										}
										this.qewhtgew1V.ActionEvent("RPC_thousandShot", this.transform.position, vector, tID);
										if (29978 - 233785 != -203807)
										{
											continue;
										}
									}
									goto IL_462;
								}
								continue;
							}
						}
						if (num < (float)5)
						{
							if (40373 - 368388 != -328015)
							{
								continue;
							}
							if (this.C8oh6eO0TQ.isTimeOut("cAttack") == (float)0)
							{
								if (270222 - 207956 == 62267)
								{
									continue;
								}
								this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
								if (134068 - 81975 != 52093)
								{
									continue;
								}
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_cAttack(this.transform.position, vector, tID));
								if (295978 - 420973 != -124995)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (156863 - 575745 == -418881)
									{
										continue;
									}
									this.qewhtgew1V.ActionEvent("RPC_cAttack", this.transform.position, vector, tID);
									if (55727 - 265371 != -209644)
									{
										continue;
									}
								}
								goto IL_462;
							}
						}
						if (this.C8oh6eO0TQ.isTimeOut("nAttack") == (float)0)
						{
							if (239864 - 329022 != -89158)
							{
								continue;
							}
							this.zbJhXo5eRy = Time.time - mTime - this.yfahOMybCM;
							if (85789 - 592493 == -506703)
							{
								continue;
							}
							if (num < (float)3)
							{
								if (48758 - 465440 == -416681)
								{
									continue;
								}
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_nAttack3(this.transform.position, vector, tID));
								if (204593 - 216111 == -11517)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (152716 - 366746 == -214029)
									{
										continue;
									}
									this.qewhtgew1V.ActionEvent("RPC_nAttack3", this.transform.position, vector, tID);
									if (200560 - 381874 == -181313)
									{
										continue;
									}
								}
							}
							else if (UnityEngine.Random.Range(0, 100) <= 40)
							{
								if (73741 - 441258 != -367517)
								{
									continue;
								}
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_nAttack2(this.transform.position, vector, tID));
								if (243613 - 359403 == -115789)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (199974 - 276490 == -76515)
									{
										continue;
									}
									this.qewhtgew1V.ActionEvent("RPC_nAttack2", this.transform.position, vector, tID);
									if (49260 - 391039 == -341778)
									{
										continue;
									}
								}
							}
							else
							{
								this.qewhtgew1V.StartCoroutine_Auto(this.qewhtgew1V.RPC_nAttack1(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (293182 - 358186 == -65003)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (62307 - 436326 != -374019)
									{
										continue;
									}
									this.qewhtgew1V.ActionEvent("RPC_nAttack1", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
									if (126186 - 17237 != 108949)
									{
										continue;
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (137884 - 262868 != -124984)
							{
								continue;
							}
							if (num > (float)12)
							{
								if (22023 - 106545 != -84522)
								{
									continue;
								}
								this.C8oh6eO0TQ.vDirection = myAttackTarget.transform.position;
								if (258789 - 354599 == -95809)
								{
									continue;
								}
								this.C8oh6eO0TQ.vDirection.y = this.transform.position.y;
								if (285649 - 310682 == -25032)
								{
									continue;
								}
								this.C8oh6eO0TQ.vMovement = (this.C8oh6eO0TQ.vDirection - this.transform.position).normalized;
								if (158072 - 294157 == -136084)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.C8oh6eO0TQ.vMovement);
								if (167692 - 51320 != 116372)
								{
									continue;
								}
								this.C8oh6eO0TQ.actionState = "run";
								if (78545 - 27090 == 51456)
								{
									continue;
								}
								this.animation.Play("run");
								if (75069 - 112608 == -37538)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (207607 - 322714 == -115106)
								{
									continue;
								}
								this.C8oh6eO0TQ.moveSpeed = Mathf.Lerp(this.C8oh6eO0TQ.moveSpeed, this.C8oh6eO0TQ.runSpeed, (float)4 * Time.deltaTime);
								if (71395 - 471003 != -399608)
								{
									continue;
								}
							}
							else
							{
								this.C8oh6eO0TQ.vDirection = myAttackTarget.transform.position;
								if (81450 - 67312 != 14138)
								{
									continue;
								}
								this.C8oh6eO0TQ.vDirection.y = this.transform.position.y;
								if (25553 - 210928 == -185374)
								{
									continue;
								}
								this.C8oh6eO0TQ.vMovement = (this.C8oh6eO0TQ.vDirection - this.transform.position).normalized;
								if (71914 - 212905 != -140991)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.C8oh6eO0TQ.vMovement);
								if (111052 - 342903 != -231851)
								{
									continue;
								}
								this.C8oh6eO0TQ.actionState = "standby";
								if (158077 - 466326 == -308248)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (53150 - 335348 == -282197)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (197479 - 196843 != 636)
								{
									continue;
								}
								this.C8oh6eO0TQ.moveSpeed = Mathf.Lerp(this.C8oh6eO0TQ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (124688 - 531897 == -407208)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_462:
			this.yfahOMybCM += mTime;
		}
		while (206317 - 560943 == -354625);
	}

	// Token: 0x060043F0 RID: 17392 RVA: 0x0088B9C4 File Offset: 0x00889BC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (132600 - 162803 != -30202)
		{
		}
		while (Time.time - this.zbJhXo5eRy > this.yfahOMybCM)
		{
			if (45168 - 261582 == -216414)
			{
				this.AI_state = "none";
				if (94305 - 107964 == -13659)
				{
					this.zbJhXo5eRy = Time.time;
					if (62982 - 412024 == -349042)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060043F1 RID: 17393 RVA: 0x0088BA78 File Offset: 0x00889C78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (222892 - 414201 != -191308)
		{
		}
		for (;;)
		{
			IL_2FC:
			if (this.aEfh2xlDVN > Time.time)
			{
				if (277566 - 484216 != -206649)
				{
					break;
				}
			}
			else
			{
				this.aEfh2xlDVN = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (283392 - 466586 == -183194)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (46403 - 276624 == -230221)
					{
						if (124774 - 310895 != -186120)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (158281 - 90314 == 67967)
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
									if (140662 - 278357 != -137695)
									{
										goto IL_2FC;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (110033 - 238467 == -128433)
									{
										goto IL_2FC;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (246512 - 389556 == -143043)
									{
										goto IL_2FC;
									}
									bool flag = true;
									if (174771 - 369202 == -194430)
									{
										goto IL_2FC;
									}
									eRace race = this.C8oh6eO0TQ.Race;
									if (168806 - 74938 != 93868)
									{
										goto IL_2FC;
									}
									if (race == eRace.Tails)
									{
										if (185607 - 255662 != -70055)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_8B;
										}
										if (57199 - 445123 != -387924)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (261720 - 348489 != -86768)
											{
												goto IL_8B;
											}
											goto IL_2FC;
										}
										goto IL_225;
										IL_8B:
										flag = false;
										if (11968 - 283600 == -271631)
										{
											goto IL_2FC;
										}
									}
									else if (race == eRace.Plants)
									{
										if (88215 - 575392 == -487176)
										{
											goto IL_2FC;
										}
										flag = false;
										if (63255 - 169108 != -105853)
										{
											goto IL_2FC;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (127973 - 324431 != -196458)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_788;
										}
										if (275414 - 92839 != 182575)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (47131 - 551091 != -503960)
											{
												goto IL_2FC;
											}
											goto IL_788;
										}
										goto IL_225;
										IL_788:
										flag = false;
										if (260268 - 127452 == 132817)
										{
											goto IL_2FC;
										}
									}
									else if (race == eRace.Robots)
									{
										if (255122 - 458510 != -203388)
										{
											goto IL_2FC;
										}
										flag = true;
										if (58698 - 172501 != -113803)
										{
											goto IL_2FC;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (240558 - 169103 != 71455)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_5E8;
										}
										if (134425 - 321955 != -187530)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_5E8;
										}
										if (150236 - 222369 != -72133)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (170676 - 329489 != -158812)
											{
												goto IL_5E8;
											}
											goto IL_2FC;
										}
										goto IL_225;
										IL_5E8:
										flag = false;
										if (17412 - 435247 != -417835)
										{
											goto IL_2FC;
										}
									}
									else if (race == eRace.Structure)
									{
										if (20 - 491857 != -491837)
										{
											goto IL_2FC;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (244738 - 567229 != -322491)
											{
												goto IL_2FC;
											}
											flag = false;
											if (281303 - 374361 != -93058)
											{
												goto IL_2FC;
											}
										}
									}
									IL_225:
									if (flag)
									{
										if (254179 - 279492 == -25312)
										{
											goto IL_2FC;
										}
										if (characterControl.hp > 0)
										{
											if (59634 - 508466 == -448831)
											{
												goto IL_2FC;
											}
											if (characterControl.recieveTarget)
											{
												if (116984 - 174547 != -57563)
												{
													goto IL_2FC;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (196705 - 208957 == -12251)
													{
														goto IL_2FC;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (22108 - 254200 != -232092)
														{
															goto IL_2FC;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (44921 - 509878 == -464956)
														{
															goto IL_2FC;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (247727 - 216911 == 30817)
															{
																goto IL_2FC;
															}
															this.C8oh6eO0TQ.myAttackTarget = gameObject;
															if (264391 - 49834 != 214557)
															{
																goto IL_2FC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (296249 - 573914 == -277664)
															{
																goto IL_2FC;
															}
															this.C8oh6eO0TQ.addHate(characterControl.ActorNr, 5);
															if (259601 - 159668 != 99933)
															{
																goto IL_2FC;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (294084 - 41169 == 252916)
															{
																goto IL_2FC;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (39987 - 166139 == -126151)
															{
																goto IL_2FC;
															}
															if (num < (float)60)
															{
																if (186280 - 165146 != 21134)
																{
																	goto IL_2FC;
																}
																if (characterControl.hp > 0)
																{
																	if (148386 - 179395 == -31008)
																	{
																		goto IL_2FC;
																	}
																	this.C8oh6eO0TQ.myAttackTarget = gameObject;
																	if (188247 - 80273 != 107974)
																	{
																		goto IL_2FC;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (43514 - 373351 == -329836)
																	{
																		goto IL_2FC;
																	}
																	this.C8oh6eO0TQ.addHate(characterControl.ActorNr, 5);
																	if (210017 - 358659 == -148641)
																	{
																		goto IL_2FC;
																	}
																}
															}
														}
														if (this.C8oh6eO0TQ.myAttackTarget)
														{
															if (116945 - 239240 == -122294)
															{
																goto IL_2FC;
															}
															this.C8oh6eO0TQ.isAlert = true;
															if (200691 - 339912 != -139221)
															{
																goto IL_2FC;
															}
															this.zbJhXo5eRy = Time.time;
															if (204963 - 24532 == 180432)
															{
																goto IL_2FC;
															}
														}
													}
												}
											}
										}
									}
								}
								if (105010 - 450369 == -345359)
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

	// Token: 0x060043F2 RID: 17394 RVA: 0x0088C290 File Offset: 0x0088A490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060043F3 RID: 17395 RVA: 0x0088C294 File Offset: 0x0088A494
	internal static bool vAwGN956kh3xWZFhti5h()
	{
		return true;
	}

	// Token: 0x060043F4 RID: 17396 RVA: 0x0088C298 File Offset: 0x0088A498
	internal static bool tpP3Md56GTC7fLTl0SGl()
	{
		return false;
	}

	// Token: 0x04004FCA RID: 20426
	private CharacterControl C8oh6eO0TQ;

	// Token: 0x04004FCB RID: 20427
	private DarkFalcon qewhtgew1V;

	// Token: 0x04004FCC RID: 20428
	public string AI_state;

	// Token: 0x04004FCD RID: 20429
	private float zbJhXo5eRy;

	// Token: 0x04004FCE RID: 20430
	private float yfahOMybCM;

	// Token: 0x04004FCF RID: 20431
	private float aEfh2xlDVN;
}
