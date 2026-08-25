using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200065D RID: 1629
[Serializable]
public class Mole_warCapital : MonoBehaviour
{
	// Token: 0x060024AE RID: 9390 RVA: 0x0044D3AC File Offset: 0x0044B5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_warCapital()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060024AF RID: 9391 RVA: 0x0044D3BC File Offset: 0x0044B5BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (153064 - 171584 != -18519)
		{
		}
		for (;;)
		{
			this.alTddLWrsc = this.transform;
			if (239858 - 382714 == -142856)
			{
				this.Rm7dghKdju = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (226141 - 231189 != -5047)
				{
					this.Rm7dghKdju.actionState = "standby";
					if (134849 - 285403 == -150554)
					{
						this.Rm7dghKdju.actionTime = Time.time;
						if (88899 - 401628 != -312728)
						{
							this.Rm7dghKdju.myCommand = "none";
							if (161801 - 84198 == 77603)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (175945 - 330435 != -154489)
								{
									this.Rm7dghKdju.isMine = true;
									if (280628 - 240330 == 40298)
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

	// Token: 0x060024B0 RID: 9392 RVA: 0x0044D51C File Offset: 0x0044B71C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator InitWarCapital(GameObject nOwner)
	{
		return new Mole_warCapital.$InitWarCapital$23435(nOwner, this).GetEnumerator();
	}

	// Token: 0x060024B1 RID: 9393 RVA: 0x0044D52C File Offset: 0x0044B72C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (135226 - 528976 != -393749)
		{
		}
		for (;;)
		{
			if (!this.yTad4oP3xL)
			{
				if (244061 - 315089 == -71028)
				{
					break;
				}
			}
			else
			{
				if (this.Rm7dghKdju.hp <= 0)
				{
					if (83046 - 427698 != -344652)
					{
						continue;
					}
					if (this.Rm7dghKdju.actionState != "dead")
					{
						if (195511 - 34258 != 161253)
						{
							continue;
						}
						if (this.Rm7dghKdju.isMine)
						{
							if (63149 - 81002 == -17852)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (118693 - 169294 != -50601)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (42815 - 16884 == 25932)
								{
									continue;
								}
								this.Rm7dghKdju.DeadEvent();
								if (90826 - 80205 != 10621)
								{
									continue;
								}
							}
						}
						else
						{
							this.Rm7dghKdju.hp = 1;
							if (145455 - 138795 != 6660)
							{
								continue;
							}
						}
					}
				}
				if (!this.zfEdahX1B5)
				{
					if (177656 - 43434 == 134222)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (101646 - 30811 == 70835)
						{
							break;
						}
					}
				}
				else
				{
					if (!this.zfEdahX1B5.isMine)
					{
						break;
					}
					if (85392 - 584027 != -498634)
					{
						if (this.zfEdahX1B5.hp > 0)
						{
							break;
						}
						if (92818 - 574190 == -481372)
						{
							this.Rm7dghKdju.hp = 0;
							if (172367 - 298963 != -126595)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060024B2 RID: 9394 RVA: 0x0044D7B4 File Offset: 0x0044B9B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Mole_warCapital.$RPC_dead$23440(nArray, this).GetEnumerator();
	}

	// Token: 0x060024B3 RID: 9395 RVA: 0x0044D7C4 File Offset: 0x0044B9C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060024B4 RID: 9396 RVA: 0x0044D7C8 File Offset: 0x0044B9C8
	internal static bool RjFs7kBg9OE5JZ4Q1tr()
	{
		return true;
	}

	// Token: 0x060024B5 RID: 9397 RVA: 0x0044D7CC File Offset: 0x0044B9CC
	internal static bool QkflQOBfGqW1lnVlbbF()
	{
		return false;
	}

	// Token: 0x040027AB RID: 10155
	private Transform alTddLWrsc;

	// Token: 0x040027AC RID: 10156
	private CharacterControl Rm7dghKdju;

	// Token: 0x040027AD RID: 10157
	private CharacterControl zfEdahX1B5;

	// Token: 0x040027AE RID: 10158
	private bool yTad4oP3xL;

	// Token: 0x040027AF RID: 10159
	private GameObject UVkdsIuS7C;

	// Token: 0x0200065E RID: 1630
	[CompilerGenerated]
	[Serializable]
	internal sealed class $InitWarCapital$23435 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060024B6 RID: 9398 RVA: 0x0044D7D0 File Offset: 0x0044B9D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $InitWarCapital$23435(GameObject nOwner, Mole_warCapital self_)
		{
			if (161330 - 553305 != -391975)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70746 - 557383 != -486636)
				{
					base..ctor();
					if (224782 - 273101 == -48319)
					{
						this.$nOwner$23438 = nOwner;
						if (43310 - 73837 != -30526)
						{
							this.$self_$23439 = self_;
							if (51617 - 382656 != -331038)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0044D88C File Offset: 0x0044BA8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_warCapital.$InitWarCapital$23435.$(this.$nOwner$23438, this.$self_$23439);
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x0044D8A0 File Offset: 0x0044BAA0
		internal static bool FW2EPLBnrFYd6u8UHWC()
		{
			return true;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0044D8A4 File Offset: 0x0044BAA4
		internal static bool fDO585B61NstjgtWVMU()
		{
			return false;
		}

		// Token: 0x040027B0 RID: 10160
		internal GameObject $nOwner$23438;

		// Token: 0x040027B1 RID: 10161
		internal Mole_warCapital $self_$23439;

		// Token: 0x0200065F RID: 1631
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060024BA RID: 9402 RVA: 0x0044D8A8 File Offset: 0x0044BAA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nOwner, Mole_warCapital self_)
			{
				if (155976 - 212690 != -56714)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (33733 - 200973 != -167239)
					{
						base..ctor();
						if (114061 - 124313 == -10252)
						{
							this.$nOwner$23436 = nOwner;
							if (158108 - 185641 == -27533)
							{
								this.$self_$23437 = self_;
								if (70291 - 543357 != -473065)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060024BB RID: 9403 RVA: 0x0044D964 File Offset: 0x0044BB64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (222104 - 418377 != -196273)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_201;
					case 2:
						this.$self_$23437.animation.Play("root");
						if (23885 - 519806 == -495920)
						{
							continue;
						}
						this.$self_$23437.animation.wrapMode = WrapMode.Loop;
						if (163705 - 338519 == -174813)
						{
							continue;
						}
						this.$self_$23437.yTad4oP3xL = true;
						if (149671 - 236814 == -87142)
						{
							continue;
						}
						Camera.main.SendMessage("newGameMessage", "WarCapital is now operational.");
						if (220976 - 2551 != 218425)
						{
							continue;
						}
						this.YieldDefault(1);
						if (174953 - 378994 != -204040)
						{
							goto Block_2;
						}
						continue;
					default:
						if (245913 - 201874 != 44039)
						{
							continue;
						}
						break;
					}
					this.$self_$23437.zfEdahX1B5 = (CharacterControl)this.$nOwner$23436.GetComponent(typeof(CharacterControl));
					if (59592 - 90427 == -30835)
					{
						this.$self_$23437.gameObject.layer = this.$nOwner$23436.layer;
						if (61707 - 504758 != -443050)
						{
							this.$self_$23437.animation.Play("open");
							if (152265 - 577673 != -425407)
							{
								this.$self_$23437.animation.wrapMode = WrapMode.Once;
								if (186085 - 244279 == -58194)
								{
									goto IL_1BB;
								}
							}
						}
					}
				}
				Block_2:
				goto IL_201;
				IL_1BB:
				return this.Yield(2, new WaitForSeconds(1f));
				IL_201:
				return false;
			}

			// Token: 0x060024BC RID: 9404 RVA: 0x0044DB84 File Offset: 0x0044BD84
			internal static bool iwA07fBiXqh3YKrrTbo()
			{
				return true;
			}

			// Token: 0x060024BD RID: 9405 RVA: 0x0044DB88 File Offset: 0x0044BD88
			internal static bool uVUOGlBKHkTfQCXQUmV()
			{
				return false;
			}

			// Token: 0x040027B2 RID: 10162
			internal GameObject $nOwner$23436;

			// Token: 0x040027B3 RID: 10163
			internal Mole_warCapital $self_$23437;
		}
	}

	// Token: 0x02000660 RID: 1632
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$23440 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060024BE RID: 9406 RVA: 0x0044DB8C File Offset: 0x0044BD8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$23440(UnityScript.Lang.Array nArray, Mole_warCapital self_)
		{
			if (207018 - 43855 != 163163)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (58064 - 448501 == -390437)
				{
					base..ctor();
					if (241713 - 369938 != -128224)
					{
						this.$nArray$23445 = nArray;
						if (34887 - 476077 == -441190)
						{
							this.$self_$23446 = self_;
							if (35217 - 95288 == -60071)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060024BF RID: 9407 RVA: 0x0044DC48 File Offset: 0x0044BE48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mole_warCapital.$RPC_dead$23440.$(this.$nArray$23445, this.$self_$23446);
		}

		// Token: 0x060024C0 RID: 9408 RVA: 0x0044DC5C File Offset: 0x0044BE5C
		internal static bool jP8xl4BdVDgLyWZ9TaK()
		{
			return true;
		}

		// Token: 0x060024C1 RID: 9409 RVA: 0x0044DC60 File Offset: 0x0044BE60
		internal static bool psXm3iBJgDJN9YSHLe1()
		{
			return false;
		}

		// Token: 0x040027B4 RID: 10164
		internal UnityScript.Lang.Array $nArray$23445;

		// Token: 0x040027B5 RID: 10165
		internal Mole_warCapital $self_$23446;

		// Token: 0x02000661 RID: 1633
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060024C2 RID: 9410 RVA: 0x0044DC64 File Offset: 0x0044BE64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mole_warCapital self_)
			{
				if (23395 - 514140 != -490745)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2048 - 385744 != -383695)
					{
						base..ctor();
						if (132941 - 330288 == -197347)
						{
							this.$nArray$23443 = nArray;
							if (66460 - 456172 == -389712)
							{
								this.$self_$23444 = self_;
								if (223813 - 118534 != 105280)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060024C3 RID: 9411 RVA: 0x0044DD20 File Offset: 0x0044BF20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (180583 - 550710 != -370127)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4B7;
					case 2:
						if (this.$self_$23444.Rm7dghKdju.actionState != "dead")
						{
							if (144573 - 29179 != 115395)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$23444.gameObject);
							if (227171 - 183400 != 43771)
							{
								continue;
							}
							this.YieldDefault(1);
							if (265509 - 564821 != -299312)
							{
								continue;
							}
							goto IL_4B7;
						}
						break;
					default:
						if (228602 - 340882 == -112279)
						{
							continue;
						}
						break;
					}
					if (this.$self_$23444.Rm7dghKdju.actionState == "dead")
					{
						if (278130 - 430524 == -152394)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$23441 = (Vector3)this.$nArray$23443[0];
						if (16533 - 202878 == -186345)
						{
							this.$myDirection$23442 = (Vector3)this.$nArray$23443[1];
							if (119079 - 422204 != -303124)
							{
								this.$self_$23444.transform.position = this.$myPosition$23441;
								if (74801 - 417065 == -342264)
								{
									this.$self_$23444.transform.LookAt(this.$myPosition$23441 + this.$myDirection$23442);
									if (254942 - 158373 != 96570)
									{
										this.$self_$23444.Rm7dghKdju.hp = 0;
										if (72501 - 307873 != -235371)
										{
											this.$self_$23444.Rm7dghKdju.actionState = "dead";
											if (269875 - 102162 != 167714)
											{
												this.$self_$23444.Rm7dghKdju.actionTime = Time.time;
												if (129782 - 487710 != -357927)
												{
													this.$self_$23444.Rm7dghKdju.myCommand = "none";
													if (101926 - 457265 != -355338)
													{
														this.$self_$23444.Rm7dghKdju.vMovement = Vector3.zero;
														if (256294 - 218418 == 37876)
														{
															this.$self_$23444.Rm7dghKdju.moveSpeed = (float)0;
															if (233378 - 448213 != -214834)
															{
																this.$self_$23444.animation.Rewind();
																if (155288 - 269362 != -114073)
																{
																	this.$self_$23444.animation.Play("close");
																	if (213575 - 96841 != 116735)
																	{
																		this.$self_$23444.animation.wrapMode = WrapMode.Once;
																		if (225384 - 275721 != -50336)
																		{
																			if (!this.$self_$23444.UVkdsIuS7C)
																			{
																				if (109062 - 6227 != 102835)
																				{
																					continue;
																				}
																				this.$self_$23444.UVkdsIuS7C = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Mole/Effects/warCapital_dead", typeof(GameObject));
																				if (32415 - 483659 == -451243)
																				{
																					continue;
																				}
																			}
																			if (this.$self_$23444.UVkdsIuS7C)
																			{
																				if (1598 - 190895 == -189297)
																				{
																					this.$self_$23444.UVkdsIuS7C = (GameObject)UnityEngine.Object.Instantiate(this.$self_$23444.UVkdsIuS7C, this.$self_$23444.transform.position, this.$self_$23444.transform.rotation);
																					if (58644 - 507722 != -449077)
																					{
																						goto Block_13;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find warCapital_dead effect");
																				if (174006 - 598349 != -424342)
																				{
																					goto Block_6;
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
				}
				goto IL_4B7;
				Block_6:
				IL_17F:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_10:
				goto IL_4B7;
				Block_13:
				goto IL_17F;
				IL_4B7:
				return false;
			}

			// Token: 0x060024C4 RID: 9412 RVA: 0x0044E1F8 File Offset: 0x0044C3F8
			internal static bool wZEE8UBDBHMjMuc0Nka()
			{
				return true;
			}

			// Token: 0x060024C5 RID: 9413 RVA: 0x0044E1FC File Offset: 0x0044C3FC
			internal static bool XcKYNABvowgYQEKf3KH()
			{
				return false;
			}

			// Token: 0x040027B6 RID: 10166
			internal Vector3 $myPosition$23441;

			// Token: 0x040027B7 RID: 10167
			internal Vector3 $myDirection$23442;

			// Token: 0x040027B8 RID: 10168
			internal UnityScript.Lang.Array $nArray$23443;

			// Token: 0x040027B9 RID: 10169
			internal Mole_warCapital $self_$23444;
		}
	}
}
