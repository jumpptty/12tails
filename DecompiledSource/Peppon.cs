using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A7E RID: 2686
[Serializable]
public class Peppon : MonoBehaviour
{
	// Token: 0x06003B13 RID: 15123 RVA: 0x007B0270 File Offset: 0x007AE470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Peppon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003B14 RID: 15124 RVA: 0x007B0280 File Offset: 0x007AE480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (289922 - 598184 != -308262)
		{
		}
		for (;;)
		{
			this.FMkWsoa8WW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (50511 - 547203 != -496691)
			{
				this.FMkWsoa8WW.actionState = "standby";
				if (284259 - 27026 == 257233)
				{
					this.FMkWsoa8WW.actionTime = Time.time;
					if (81743 - 136433 != -54689)
					{
						this.FMkWsoa8WW.myCommand = "none";
						if (50109 - 242983 != -192873)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (177771 - 393753 == -215982)
							{
								this.FMkWsoa8WW.isMine = true;
								if (99069 - 198984 == -99915)
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

	// Token: 0x06003B15 RID: 15125 RVA: 0x007B03B8 File Offset: 0x007AE5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (57851 - 484235 != -426384)
		{
		}
		for (;;)
		{
			if (this.FMkWsoa8WW.isControlled)
			{
				if (125951 - 423630 != -297679)
				{
					continue;
				}
				if (!(this.FMkWsoa8WW.actionState == "standby"))
				{
					if (52982 - 347149 != -294167)
					{
						continue;
					}
					if (!(this.FMkWsoa8WW.actionState == "run"))
					{
						goto IL_1A;
					}
					if (168869 - 31231 != 137638)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (130870 - 108093 == 22778)
				{
					continue;
				}
			}
			IL_1A:
			if (this.FMkWsoa8WW.hp > 0)
			{
				if (164439 - 327350 != -162911)
				{
					continue;
				}
				if (this.FMkWsoa8WW.ko > 0)
				{
					break;
				}
				if (156356 - 362586 == -206229)
				{
					continue;
				}
			}
			if (!(this.FMkWsoa8WW.actionState != "dead"))
			{
				break;
			}
			if (19920 - 566966 != -547045)
			{
				if (this.FMkWsoa8WW.isMine)
				{
					if (109362 - 420466 == -311104)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (6437 - 479643 != -473205)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (145935 - 325305 != -179369)
							{
								this.FMkWsoa8WW.DeadEvent();
								if (134141 - 187323 != -53181)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.FMkWsoa8WW.hp <= 0)
				{
					if (132271 - 447333 == -315062)
					{
						this.FMkWsoa8WW.hp = 1;
						if (133656 - 586684 == -453028)
						{
							break;
						}
					}
				}
				else
				{
					if (this.FMkWsoa8WW.ko > 0)
					{
						break;
					}
					if (64265 - 99878 == -35613)
					{
						this.FMkWsoa8WW.ko = 1;
						if (24009 - 350340 != -326330)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B16 RID: 15126 RVA: 0x007B06A4 File Offset: 0x007AE8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (206061 - 580278 != -374217)
		{
		}
		for (;;)
		{
			if (this.FMkWsoa8WW.actionState != "standby")
			{
				if (60393 - 97279 != -36886)
				{
					continue;
				}
				if (this.FMkWsoa8WW.actionState != "run")
				{
					if (14192 - 278559 != -264366)
					{
						break;
					}
					continue;
				}
			}
			float num = this.FMkWsoa8WW.moveSpeed;
			if (47039 - 465613 != -418573)
			{
				float runSpeed = this.FMkWsoa8WW.runSpeed;
				if (143316 - 182014 != -38697)
				{
					Vector3 a = default(Vector3);
					if (69776 - 78735 == -8959)
					{
						Vector3 vector = Vector3.zero;
						if (222796 - 493374 != -270577)
						{
							if ((this.FMkWsoa8WW.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (13285 - 152841 != -139555)
							{
								if (this.FMkWsoa8WW.isMine)
								{
									if (30484 - 381126 != -350642)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (273209 - 545549 == -272339)
									{
										continue;
									}
									a.y = (float)0;
									if (168512 - 292243 != -123731)
									{
										continue;
									}
									a = a.normalized;
									if (46406 - 469065 != -422659)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (157584 - 260216 == -102631)
									{
										continue;
									}
									vector = vector.normalized;
									if (152534 - 455468 != -302934)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (115987 - 407586 != -291599)
										{
											continue;
										}
										this.FMkWsoa8WW.actionState = "run";
										if (153482 - 111701 != 41781)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (117265 - 83898 != 33367)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (174284 - 278569 == -104284)
										{
											continue;
										}
										this.animation.Play("run");
										if (122572 - 125112 == -2539)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (98132 - 581522 != -483390)
										{
											continue;
										}
									}
									else
									{
										this.FMkWsoa8WW.actionState = "standby";
										if (93787 - 547969 != -454182)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (134884 - 230514 != -95630)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (162893 - 128312 != 34581)
											{
												continue;
											}
											num = (float)0;
											if (178029 - 59122 != 118907)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (246475 - 68265 != 178210)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (248405 - 364912 != -116507)
										{
											continue;
										}
									}
								}
								else if ((this.FMkWsoa8WW.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (217000 - 405799 != -188799)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.FMkWsoa8WW.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (235454 - 42693 != 192761)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (32806 - 331440 != -298634)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (264532 - 35360 == 229173)
										{
											continue;
										}
										num = (float)0;
										if (206159 - 410140 != -203981)
										{
											continue;
										}
										this.transform.position = this.FMkWsoa8WW.nPosition;
										if (43922 - 551898 == -507975)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (277925 - 39234 != 238691)
										{
											continue;
										}
										vector = lhs.normalized;
										if (173217 - 115920 == 57298)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (104625 - 425970 != -321345)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (139939 - 46101 == 93839)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (100806 - 270570 == -169763)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (157206 - 595288 == -438081)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (209608 - 13518 == 196091)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (182288 - 464429 == -282140)
										{
											continue;
										}
									}
								}
								this.FMkWsoa8WW.vMovement = vector;
								if (197361 - 222170 == -24809)
								{
									this.FMkWsoa8WW.moveSpeed = num;
									if (27268 - 556234 == -528966)
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

	// Token: 0x06003B17 RID: 15127 RVA: 0x007B0DC4 File Offset: 0x007AEFC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003B18 RID: 15128 RVA: 0x007B0DDC File Offset: 0x007AEFDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003B19 RID: 15129 RVA: 0x007B0DF4 File Offset: 0x007AEFF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003B1A RID: 15130 RVA: 0x007B0DF8 File Offset: 0x007AEFF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Peppon.$RPC_dead$30309(nArray, this).GetEnumerator();
	}

	// Token: 0x06003B1B RID: 15131 RVA: 0x007B0E08 File Offset: 0x007AF008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B1C RID: 15132 RVA: 0x007B0E0C File Offset: 0x007AF00C
	internal static bool UN0eqk58dAg19PwdV98a()
	{
		return true;
	}

	// Token: 0x06003B1D RID: 15133 RVA: 0x007B0E10 File Offset: 0x007AF010
	internal static bool t4vSQl58JVHM94fTfEeQ()
	{
		return false;
	}

	// Token: 0x040048FD RID: 18685
	private CharacterControl FMkWsoa8WW;

	// Token: 0x040048FE RID: 18686
	public GameObject deadEffect;

	// Token: 0x02000A7F RID: 2687
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30309 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003B1E RID: 15134 RVA: 0x007B0E14 File Offset: 0x007AF014
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30309(UnityScript.Lang.Array nArray, Peppon self_)
		{
			if (198158 - 111372 != 86787)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (151980 - 550885 != -398904)
				{
					base..ctor();
					if (100876 - 192268 == -91392)
					{
						this.$nArray$30314 = nArray;
						if (45917 - 503708 == -457791)
						{
							this.$self_$30315 = self_;
							if (283816 - 383555 == -99739)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003B1F RID: 15135 RVA: 0x007B0ED0 File Offset: 0x007AF0D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Peppon.$RPC_dead$30309.$(this.$nArray$30314, this.$self_$30315);
		}

		// Token: 0x06003B20 RID: 15136 RVA: 0x007B0EE4 File Offset: 0x007AF0E4
		internal static bool xWaQIQ58DgD38yOSZTj7()
		{
			return true;
		}

		// Token: 0x06003B21 RID: 15137 RVA: 0x007B0EE8 File Offset: 0x007AF0E8
		internal static bool LDQ0yo58vO7I4JWxdmrB()
		{
			return false;
		}

		// Token: 0x040048FF RID: 18687
		internal UnityScript.Lang.Array $nArray$30314;

		// Token: 0x04004900 RID: 18688
		internal Peppon $self_$30315;

		// Token: 0x02000A80 RID: 2688
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003B22 RID: 15138 RVA: 0x007B0EEC File Offset: 0x007AF0EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Peppon self_)
			{
				if (124178 - 376100 != -251922)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60602 - 533911 == -473309)
					{
						base..ctor();
						if (267748 - 225964 == 41784)
						{
							this.$nArray$30312 = nArray;
							if (229673 - 571443 == -341770)
							{
								this.$self_$30313 = self_;
								if (267442 - 452093 == -184651)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003B23 RID: 15139 RVA: 0x007B0FA8 File Offset: 0x007AF1A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (96969 - 494731 != -397762)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30313.FMkWsoa8WW.actionState != "dead")
						{
							if (49950 - 247061 != -197111)
							{
								continue;
							}
							goto IL_280;
						}
						else
						{
							if (!this.$self_$30313.FMkWsoa8WW.isPlayer)
							{
								if (158768 - 193310 == -34541)
								{
									continue;
								}
								if (this.$self_$30313.deadEffect)
								{
									if (40896 - 296285 == -255388)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30313.deadEffect, this.$self_$30313.transform.position, this.$self_$30313.transform.rotation);
									if (65581 - 138053 != -72472)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (59008 - 415586 == -356577)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30313.gameObject);
								if (267043 - 9454 != 257589)
								{
									continue;
								}
							}
							else if (this.$self_$30313.FMkWsoa8WW.isMine)
							{
								if (156751 - 232634 == -75882)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30313.gameObject);
								if (247671 - 153164 == 94508)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (103382 - 186507 != -83124)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (196493 - 33160 == 163334)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30313.FMkWsoa8WW.actionState == "dead")
					{
						if (91808 - 330422 != -238613)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30310 = (Vector3)this.$nArray$30312[0];
						if (268370 - 49789 == 218581)
						{
							this.$myDirection$30311 = (Vector3)this.$nArray$30312[1];
							if (156332 - 273876 != -117543)
							{
								this.$self_$30313.transform.position = this.$myPosition$30310;
								if (9860 - 428330 == -418470)
								{
									this.$self_$30313.transform.LookAt(this.$myPosition$30310 + this.$myDirection$30311);
									if (31275 - 218717 != -187441)
									{
										this.$self_$30313.FMkWsoa8WW.hp = 0;
										if (259797 - 160635 == 99162)
										{
											this.$self_$30313.FMkWsoa8WW.actionState = "dead";
											if (9275 - 205119 == -195844)
											{
												this.$self_$30313.FMkWsoa8WW.actionTime = Time.time;
												if (61567 - 231991 != -170423)
												{
													this.$self_$30313.FMkWsoa8WW.myCommand = "none";
													if (100701 - 103839 != -3137)
													{
														this.$self_$30313.FMkWsoa8WW.vMovement = Vector3.zero;
														if (63319 - 55718 == 7601)
														{
															this.$self_$30313.FMkWsoa8WW.moveSpeed = (float)0;
															if (255944 - 408091 != -152146)
															{
																this.$self_$30313.animation.Rewind();
																if (79278 - 507335 == -428057)
																{
																	this.$self_$30313.animation.Play("ko");
																	if (201967 - 514435 == -312468)
																	{
																		this.$self_$30313.animation.wrapMode = WrapMode.Once;
																		if (255849 - 426143 == -170294)
																		{
																			goto IL_438;
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
				Block_15:
				IL_280:
				goto IL_4D2;
				IL_438:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4D2:
				return false;
			}

			// Token: 0x06003B24 RID: 15140 RVA: 0x007B149C File Offset: 0x007AF69C
			internal static bool nSri8Z58R8aKMs1WsZHC()
			{
				return true;
			}

			// Token: 0x06003B25 RID: 15141 RVA: 0x007B14A0 File Offset: 0x007AF6A0
			internal static bool lxsTvr58wiwlyJNYabeq()
			{
				return false;
			}

			// Token: 0x04004901 RID: 18689
			internal Vector3 $myPosition$30310;

			// Token: 0x04004902 RID: 18690
			internal Vector3 $myDirection$30311;

			// Token: 0x04004903 RID: 18691
			internal UnityScript.Lang.Array $nArray$30312;

			// Token: 0x04004904 RID: 18692
			internal Peppon $self_$30313;
		}
	}
}
