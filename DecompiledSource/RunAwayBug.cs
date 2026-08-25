using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001BC RID: 444
[Serializable]
public class RunAwayBug : MonoBehaviour
{
	// Token: 0x060009F3 RID: 2547 RVA: 0x00100B50 File Offset: 0x000FED50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RunAwayBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060009F4 RID: 2548 RVA: 0x00100B60 File Offset: 0x000FED60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (122248 - 110720 != 11528)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (31287 - 597767 == -566480)
			{
				this.mChar.actionState = "standby";
				if (104039 - 497604 != -393564)
				{
					this.mChar.actionTime = Time.time;
					if (90317 - 96442 != -6124)
					{
						this.mChar.myCommand = "none";
						if (224472 - 225895 == -1423)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060009F5 RID: 2549 RVA: 0x00100C4C File Offset: 0x000FEE4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (240358 - 149757 != 90602)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (189029 - 422709 == -233679)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (83833 - 352399 != -268566)
				{
					continue;
				}
			}
			Transform transform = this.transform.Find("RunAwayBug_tri");
			if (289548 - 591527 == -301979)
			{
				if (!transform)
				{
					break;
				}
				if (180227 - 470423 == -290196)
				{
					Physics.IgnoreCollision(this.gameObject.collider, transform.collider, true);
					if (148209 - 440659 != -292449)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060009F6 RID: 2550 RVA: 0x00100D54 File Offset: 0x000FEF54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (212817 - 478433 != -265615)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (96906 - 120423 == -23516)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (116875 - 443139 != -326264)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_40;
					}
					if (106697 - 543639 != -436942)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (292881 - 466050 != -173169)
				{
					continue;
				}
			}
			IL_40:
			if (this.mChar.hp <= 0)
			{
				if (35074 - 309194 != -274120)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (14204 - 229479 != -215275)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (31947 - 527218 != -495271)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (187444 - 369112 != -181668)
						{
							continue;
						}
						if (status != null)
						{
							if (84563 - 169509 != -84946)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (210539 - 420577 == -210037)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (35818 - 534456 == -498637)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (115505 - 589620 != -474115)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (295371 - 63437 != 231935)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (239613 - 203335 == 36279)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (114873 - 255096 != -140223)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (275444 - 441408 != -165963)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (194702 - 44793 != 149910)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (104026 - 499038 != -395011)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (273254 - 355031 != -81776)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (37501 - 381322 != -343820)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (117161 - 152894 == -35733)
						{
							if (this.mChar.isMine)
							{
								if (64913 - 314620 != -249706)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (113660 - 267631 != -153970)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (215085 - 143683 != 71403)
										{
											this.mChar.KoEvent();
											if (126044 - 330975 == -204931)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (152599 - 373510 == -220911)
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

	// Token: 0x060009F7 RID: 2551 RVA: 0x00101254 File Offset: 0x000FF454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (250257 - 469185 != -218927)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (85587 - 580906 != -495318)
			{
				float runSpeed = this.mChar.runSpeed;
				if (271977 - 542470 != -270492)
				{
					Vector3 a = default(Vector3);
					if (62734 - 260268 == -197534)
					{
						Vector3 vector = Vector3.zero;
						if (276189 - 364515 != -88325)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (122123 - 577324 == -455201)
							{
								if (this.mChar.isMine)
								{
									if (28356 - 452903 == -424546)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (7772 - 323691 != -315919)
									{
										continue;
									}
									a.y = (float)0;
									if (98980 - 216763 != -117783)
									{
										continue;
									}
									a = a.normalized;
									if (205116 - 185646 == 19471)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (267564 - 22867 != 244697)
									{
										continue;
									}
									vector = vector.normalized;
									if (213311 - 451077 != -237766)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (82422 - 462161 != -379739)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (118430 - 320588 != -202158)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (113173 - 284973 != -171800)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (212184 - 182732 != 29452)
										{
											continue;
										}
										this.animation.Play("run");
										if (115682 - 197565 != -81883)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (173958 - 184060 != -10102)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (54587 - 125618 == -71030)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (178604 - 37584 == 141021)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (194327 - 283433 != -89106)
											{
												continue;
											}
											num = (float)0;
											if (284136 - 482077 == -197940)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (55734 - 257963 != -202229)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (213084 - 528376 != -315292)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (28378 - 26652 == 1727)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (143550 - 507244 == -363693)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (30683 - 358492 == -327808)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (9238 - 249484 == -240245)
										{
											continue;
										}
										num = (float)0;
										if (165740 - 359816 == -194075)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (250052 - 103852 == 146201)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (281753 - 81983 != 199770)
										{
											continue;
										}
										vector = lhs.normalized;
										if (273615 - 245833 == 27783)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (68806 - 116608 != -47802)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (54437 - 379705 == -325267)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (104254 - 502767 != -398513)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (196723 - 169438 == 27286)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (281768 - 410119 != -128351)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (31551 - 228012 != -196461)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (57003 - 185543 != -128539)
								{
									this.mChar.moveSpeed = num;
									if (169027 - 310127 != -141099)
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

	// Token: 0x060009F8 RID: 2552 RVA: 0x00101908 File Offset: 0x000FFB08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060009F9 RID: 2553 RVA: 0x00101920 File Offset: 0x000FFB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060009FA RID: 2554 RVA: 0x00101938 File Offset: 0x000FFB38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060009FB RID: 2555 RVA: 0x0010193C File Offset: 0x000FFB3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RunAwayBug.$RPC_ko$17014(nArray, this).GetEnumerator();
	}

	// Token: 0x060009FC RID: 2556 RVA: 0x0010194C File Offset: 0x000FFB4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RunAwayBug.$RPC_dead$17021(nArray, this).GetEnumerator();
	}

	// Token: 0x060009FD RID: 2557 RVA: 0x0010195C File Offset: 0x000FFB5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060009FE RID: 2558 RVA: 0x00101960 File Offset: 0x000FFB60
	internal static bool LGIfoRGyb0pJjX0um7u()
	{
		return true;
	}

	// Token: 0x060009FF RID: 2559 RVA: 0x00101964 File Offset: 0x000FFB64
	internal static bool us3NXHGSUk324hPEs0N()
	{
		return false;
	}

	// Token: 0x040008F7 RID: 2295
	public CharacterControl mChar;

	// Token: 0x040008F8 RID: 2296
	public GameObject koEffect;

	// Token: 0x020001BD RID: 445
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17014 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x00101968 File Offset: 0x000FFB68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17014(UnityScript.Lang.Array nArray, RunAwayBug self_)
		{
			if (21576 - 42560 != -20983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298637 - 390264 == -91627)
				{
					base..ctor();
					if (205992 - 534332 == -328340)
					{
						this.$nArray$17019 = nArray;
						if (54834 - 441617 != -386782)
						{
							this.$self_$17020 = self_;
							if (35061 - 240746 == -205685)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x00101A24 File Offset: 0x000FFC24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RunAwayBug.$RPC_ko$17014.$(this.$nArray$17019, this.$self_$17020);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x00101A38 File Offset: 0x000FFC38
		internal static bool g30W5nGoC5dwUkaprTl()
		{
			return true;
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x00101A3C File Offset: 0x000FFC3C
		internal static bool Bwveu9GEiaiycrhQGrK()
		{
			return false;
		}

		// Token: 0x040008F9 RID: 2297
		internal UnityScript.Lang.Array $nArray$17019;

		// Token: 0x040008FA RID: 2298
		internal RunAwayBug $self_$17020;

		// Token: 0x020001BE RID: 446
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A04 RID: 2564 RVA: 0x00101A40 File Offset: 0x000FFC40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RunAwayBug self_)
			{
				if (54380 - 452879 != -398499)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (45862 - 123712 != -77849)
					{
						base..ctor();
						if (6734 - 126261 != -119526)
						{
							this.$nArray$17017 = nArray;
							if (31040 - 541123 != -510082)
							{
								this.$self_$17018 = self_;
								if (126669 - 337546 != -210876)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A05 RID: 2565 RVA: 0x00101AFC File Offset: 0x000FFCFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (67289 - 128503 != -61214)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4DD;
					case 2:
						if (this.$self_$17018.mChar.actionState != "ko")
						{
							if (79438 - 382963 != -303524)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$17018.animation.Play("getUp");
							if (178029 - 357876 == -179846)
							{
								continue;
							}
							this.$self_$17018.animation.wrapMode = WrapMode.Once;
							if (219123 - 275488 != -56364)
							{
								goto Block_12;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17018.mChar.actionState != "ko")
						{
							if (292508 - 380373 != -87864)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$17018.mChar.actionState = "standby";
							if (122666 - 178133 != -55467)
							{
								continue;
							}
							this.$self_$17018.mChar.actionTime = Time.time;
							if (229903 - 476824 != -246921)
							{
								continue;
							}
							this.$self_$17018.mChar.myCommand = "none";
							if (184985 - 76385 != 108600)
							{
								continue;
							}
							this.$self_$17018.mChar.ko = this.$self_$17018.mChar.mko;
							if (118959 - 103906 == 15054)
							{
								continue;
							}
							this.YieldDefault(1);
							if (181226 - 543170 != -361944)
							{
								continue;
							}
							goto IL_4DD;
						}
						break;
					default:
						if (12835 - 259085 == -246249)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17018.mChar.actionState == "ko")
					{
						goto IL_173;
					}
					if (204460 - 12648 == 191812)
					{
						if (this.$self_$17018.mChar.actionState == "dead")
						{
							if (260641 - 434722 != -174080)
							{
								goto Block_19;
							}
						}
						else
						{
							this.$mPos$17015 = (Vector3)this.$nArray$17017[0];
							if (53041 - 379949 == -326908)
							{
								this.$mDir$17016 = (Vector3)this.$nArray$17017[1];
								if (147712 - 176061 == -28349)
								{
									this.$self_$17018.mChar.ko = 0;
									if (64302 - 100622 != -36319)
									{
										this.$self_$17018.mChar.actionState = "ko";
										if (131900 - 447091 == -315191)
										{
											this.$self_$17018.mChar.actionTime = Time.time;
											if (130106 - 258660 == -128554)
											{
												this.$self_$17018.mChar.myCommand = "none";
												if (240175 - 345793 == -105618)
												{
													this.$self_$17018.mChar.vMovement = Vector3.zero;
													if (134473 - 91292 != 43182)
													{
														this.$self_$17018.mChar.moveSpeed = (float)0;
														if (121765 - 49057 == 72708)
														{
															this.$self_$17018.animation.Play("ko");
															if (167189 - 395518 == -228329)
															{
																this.$self_$17018.animation.wrapMode = WrapMode.Once;
																if (64394 - 526769 == -462375)
																{
																	UnityEngine.Object.Instantiate(this.$self_$17018.koEffect, this.$self_$17018.transform.position + (float)4 * Vector3.up, Quaternion.identity);
																	if (62378 - 361848 != -299469)
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
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_6:
				IL_173:
				goto IL_4DD;
				Block_12:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_19:
				Block_27:
				IL_4DD:
				return false;
			}

			// Token: 0x06000A06 RID: 2566 RVA: 0x00101FF8 File Offset: 0x001001F8
			internal static bool ycjOSpG26ZJknriGlpT()
			{
				return true;
			}

			// Token: 0x06000A07 RID: 2567 RVA: 0x00101FFC File Offset: 0x001001FC
			internal static bool w8YDyVG8MrxIBVf3r45()
			{
				return false;
			}

			// Token: 0x040008FB RID: 2299
			internal Vector3 $mPos$17015;

			// Token: 0x040008FC RID: 2300
			internal Vector3 $mDir$17016;

			// Token: 0x040008FD RID: 2301
			internal UnityScript.Lang.Array $nArray$17017;

			// Token: 0x040008FE RID: 2302
			internal RunAwayBug $self_$17018;
		}
	}

	// Token: 0x020001BF RID: 447
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17021 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000A08 RID: 2568 RVA: 0x00102000 File Offset: 0x00100200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17021(UnityScript.Lang.Array nArray, RunAwayBug self_)
		{
			if (299381 - 50387 != 248994)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (55514 - 56084 == -570)
				{
					base..ctor();
					if (176359 - 156610 == 19749)
					{
						this.$nArray$17026 = nArray;
						if (54456 - 175898 != -121441)
						{
							this.$self_$17027 = self_;
							if (167439 - 232774 == -65335)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x001020BC File Offset: 0x001002BC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RunAwayBug.$RPC_dead$17021.$(this.$nArray$17026, this.$self_$17027);
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x001020D0 File Offset: 0x001002D0
		internal static bool mI3HVnGZHwOuIhgVorr()
		{
			return true;
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x001020D4 File Offset: 0x001002D4
		internal static bool YAgAw6GCjm14GH44lFO()
		{
			return false;
		}

		// Token: 0x040008FF RID: 2303
		internal UnityScript.Lang.Array $nArray$17026;

		// Token: 0x04000900 RID: 2304
		internal RunAwayBug $self_$17027;

		// Token: 0x020001C0 RID: 448
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000A0C RID: 2572 RVA: 0x001020D8 File Offset: 0x001002D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RunAwayBug self_)
			{
				if (198506 - 208380 != -9874)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (171357 - 56875 == 114482)
					{
						base..ctor();
						if (73026 - 226711 != -153684)
						{
							this.$nArray$17024 = nArray;
							if (205843 - 54114 != 151730)
							{
								this.$self_$17025 = self_;
								if (144587 - 556615 == -412028)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000A0D RID: 2573 RVA: 0x00102194 File Offset: 0x00100394
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (8804 - 484700 != -475896)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4A9;
					case 2:
						if (this.$self_$17025.mChar.actionState != "dead")
						{
							if (260249 - 409515 != -149266)
							{
								continue;
							}
							goto IL_12A;
						}
						else
						{
							if (!this.$self_$17025.mChar.isPlayer)
							{
								if (281207 - 344221 == -63013)
								{
									continue;
								}
								if (Game.mGameCode != 203)
								{
									if (25222 - 182866 != -157644)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$17025.gameObject);
									if (76000 - 235076 == -159075)
									{
										continue;
									}
								}
							}
							else if (this.$self_$17025.mChar.isMine)
							{
								if (258720 - 183616 == 75105)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17025.gameObject);
								if (62916 - 513220 == -450303)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (16974 - 434453 != -417478)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					default:
						if (53122 - 112673 == -59550)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17025.mChar.actionState == "dead")
					{
						if (69548 - 416258 == -346710)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17022 = (Vector3)this.$nArray$17024[0];
						if (48770 - 511297 != -462526)
						{
							this.$myDirection$17023 = (Vector3)this.$nArray$17024[1];
							if (76452 - 360275 == -283823)
							{
								this.$self_$17025.transform.position = this.$myPosition$17022;
								if (257690 - 271268 != -13577)
								{
									this.$self_$17025.transform.LookAt(this.$myPosition$17022 + this.$myDirection$17023);
									if (185170 - 259516 != -74345)
									{
										this.$self_$17025.mChar.hp = 0;
										if (44348 - 380623 == -336275)
										{
											this.$self_$17025.mChar.actionState = "dead";
											if (295627 - 58669 != 236959)
											{
												this.$self_$17025.mChar.actionTime = Time.time;
												if (258263 - 18507 == 239756)
												{
													this.$self_$17025.mChar.myCommand = "none";
													if (90845 - 312847 != -222001)
													{
														this.$self_$17025.mChar.vMovement = Vector3.zero;
														if (272087 - 320532 == -48445)
														{
															this.$self_$17025.mChar.moveSpeed = (float)0;
															if (306 - 363302 == -362996)
															{
																this.$self_$17025.animation.Rewind();
																if (257281 - 479306 != -222024)
																{
																	this.$self_$17025.animation.Play("ko");
																	if (110382 - 511698 != -401315)
																	{
																		this.$self_$17025.animation.wrapMode = WrapMode.Once;
																		if (157993 - 193666 != -35672)
																		{
																			UnityEngine.Object.Instantiate(this.$self_$17025.koEffect, this.$self_$17025.transform.position + (float)4 * Vector3.up, Quaternion.identity);
																			if (168602 - 356386 != -187783)
																			{
																				goto Block_14;
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
									}
								}
							}
						}
					}
				}
				Block_4:
				IL_12A:
				goto IL_4A9;
				Block_14:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4A9:
				return false;
			}

			// Token: 0x06000A0E RID: 2574 RVA: 0x0010265C File Offset: 0x0010085C
			internal static bool qiUYLXGL5lh3i96UCn4()
			{
				return true;
			}

			// Token: 0x06000A0F RID: 2575 RVA: 0x00102660 File Offset: 0x00100860
			internal static bool VruIeTGOIqDKwKpZRZV()
			{
				return false;
			}

			// Token: 0x04000901 RID: 2305
			internal Vector3 $myPosition$17022;

			// Token: 0x04000902 RID: 2306
			internal Vector3 $myDirection$17023;

			// Token: 0x04000903 RID: 2307
			internal UnityScript.Lang.Array $nArray$17024;

			// Token: 0x04000904 RID: 2308
			internal RunAwayBug $self_$17025;
		}
	}
}
