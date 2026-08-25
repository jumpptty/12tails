using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A76 RID: 2678
[Serializable]
public class Mupo : MonoBehaviour
{
	// Token: 0x06003AD8 RID: 15064 RVA: 0x007ABE7C File Offset: 0x007AA07C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mupo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003AD9 RID: 15065 RVA: 0x007ABE8C File Offset: 0x007AA08C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (197790 - 164929 != 32862)
		{
		}
		for (;;)
		{
			this.xsxW3xTXZE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (265400 - 24552 == 240848)
			{
				this.xsxW3xTXZE.actionState = "standby";
				if (188395 - 337462 == -149067)
				{
					this.xsxW3xTXZE.actionTime = Time.time;
					if (48885 - 350690 != -301804)
					{
						this.xsxW3xTXZE.myCommand = "none";
						if (294687 - 252117 == 42570)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003ADA RID: 15066 RVA: 0x007ABF78 File Offset: 0x007AA178
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.xsxW3xTXZE.isMine = true;
		}
	}

	// Token: 0x06003ADB RID: 15067 RVA: 0x007ABF94 File Offset: 0x007AA194
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent(AnimationEvent animEvent)
	{
		if (216085 - 379542 != -163457)
		{
		}
		do
		{
			if (this.BlFWbESein)
			{
				if (230016 - 209177 != 20839)
				{
					continue;
				}
				if (this.footStep_run1)
				{
					if (267889 - 73926 == 193964)
					{
						continue;
					}
					this.audio.PlayOneShot(this.footStep_run1, 0.5f);
					if (178291 - 431092 != -252801)
					{
						continue;
					}
				}
			}
			else if (this.footStep_run2)
			{
				if (217276 - 6441 != 210835)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_run2, 0.5f);
				if (286312 - 27192 != 259120)
				{
					continue;
				}
			}
			this.BlFWbESein = !this.BlFWbESein;
		}
		while (243134 - 423580 != -180446);
	}

	// Token: 0x06003ADC RID: 15068 RVA: 0x007AC0D4 File Offset: 0x007AA2D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (152920 - 490004 != -337083)
		{
		}
		for (;;)
		{
			if (this.xsxW3xTXZE.isControlled)
			{
				if (119174 - 56067 == 63108)
				{
					continue;
				}
				if (!(this.xsxW3xTXZE.actionState == "standby"))
				{
					if (22389 - 539342 == -516952)
					{
						continue;
					}
					if (!(this.xsxW3xTXZE.actionState == "run"))
					{
						goto IL_2A2;
					}
					if (49749 - 529586 != -479837)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (269264 - 190836 != 78428)
				{
					continue;
				}
			}
			IL_2A2:
			if (this.xsxW3xTXZE.hp > 0)
			{
				if (9407 - 452273 == -442865)
				{
					continue;
				}
				if (this.xsxW3xTXZE.ko > 0)
				{
					break;
				}
				if (176283 - 392978 != -216695)
				{
					continue;
				}
			}
			if (!(this.xsxW3xTXZE.actionState != "dead"))
			{
				break;
			}
			if (172363 - 248601 == -76238)
			{
				if (this.xsxW3xTXZE.isMine)
				{
					if (62538 - 29671 == 32867)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (122143 - 421288 == -299145)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (62174 - 321658 == -259484)
							{
								this.xsxW3xTXZE.DeadEvent();
								if (246672 - 355271 == -108599)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.xsxW3xTXZE.hp <= 0)
				{
					if (60088 - 45049 == 15039)
					{
						this.xsxW3xTXZE.hp = 1;
						if (147877 - 281657 != -133779)
						{
							break;
						}
					}
				}
				else
				{
					if (this.xsxW3xTXZE.ko > 0)
					{
						break;
					}
					if (134611 - 333560 == -198949)
					{
						this.xsxW3xTXZE.ko = 1;
						if (150210 - 410 == 149800)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003ADD RID: 15069 RVA: 0x007AC3C0 File Offset: 0x007AA5C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (34282 - 45019 != -10736)
		{
		}
		for (;;)
		{
			if (this.xsxW3xTXZE.actionState != "standby")
			{
				if (109331 - 171392 != -62061)
				{
					continue;
				}
				if (this.xsxW3xTXZE.actionState != "run")
				{
					if (121701 - 238455 != -116754)
					{
						continue;
					}
					break;
				}
			}
			float num = this.xsxW3xTXZE.moveSpeed;
			if (151812 - 93888 != 57925)
			{
				float runSpeed = this.xsxW3xTXZE.runSpeed;
				if (210546 - 256869 == -46323)
				{
					Vector3 a = default(Vector3);
					if (144508 - 367840 != -223331)
					{
						Vector3 vector = Vector3.zero;
						if (185281 - 239385 != -54103)
						{
							if ((this.xsxW3xTXZE.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (202685 - 547709 != -345023)
							{
								if (this.xsxW3xTXZE.isMine)
								{
									if (138587 - 264176 != -125589)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (43472 - 162142 == -118669)
									{
										continue;
									}
									a.y = (float)0;
									if (59466 - 493922 != -434456)
									{
										continue;
									}
									a = a.normalized;
									if (86192 - 336324 != -250132)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (240399 - 529916 != -289517)
									{
										continue;
									}
									vector = vector.normalized;
									if (129350 - 307890 != -178540)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (56087 - 172511 != -116424)
										{
											continue;
										}
										this.xsxW3xTXZE.actionState = "run";
										if (7826 - 481568 == -473741)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (216216 - 493801 == -277584)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (34653 - 405331 != -370678)
										{
											continue;
										}
										this.animation.Play("run");
										if (69412 - 428385 != -358973)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (152181 - 227156 != -74975)
										{
											continue;
										}
									}
									else
									{
										this.xsxW3xTXZE.actionState = "standby";
										if (72024 - 210249 != -138225)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (149854 - 570853 == -420998)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (70019 - 159504 == -89484)
											{
												continue;
											}
											num = (float)0;
											if (100443 - 262159 == -161715)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (94396 - 430135 == -335738)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (176074 - 405198 == -229123)
										{
											continue;
										}
									}
								}
								else if ((this.xsxW3xTXZE.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (61820 - 380419 == -318598)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.xsxW3xTXZE.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (298639 - 479459 == -180819)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (133206 - 131285 == 1922)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (294649 - 488851 == -194201)
										{
											continue;
										}
										num = (float)0;
										if (215260 - 127615 != 87645)
										{
											continue;
										}
										this.transform.position = this.xsxW3xTXZE.nPosition;
										if (296582 - 471683 == -175100)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (191036 - 567256 == -376219)
										{
											continue;
										}
										vector = lhs.normalized;
										if (116827 - 535333 == -418505)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (77983 - 402349 == -324365)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (91085 - 188345 == -97259)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (32906 - 372053 != -339147)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (275141 - 193786 == 81356)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (220283 - 66521 == 153763)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (275924 - 366762 == -90837)
										{
											continue;
										}
									}
								}
								this.xsxW3xTXZE.vMovement = vector;
								if (213806 - 585897 == -372091)
								{
									this.xsxW3xTXZE.moveSpeed = num;
									if (207533 - 345296 == -137763)
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

	// Token: 0x06003ADE RID: 15070 RVA: 0x007ACAE0 File Offset: 0x007AACE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003ADF RID: 15071 RVA: 0x007ACAF8 File Offset: 0x007AACF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003AE0 RID: 15072 RVA: 0x007ACB10 File Offset: 0x007AAD10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003AE1 RID: 15073 RVA: 0x007ACB14 File Offset: 0x007AAD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Mupo.$RPC_dead$30295(nArray, this).GetEnumerator();
	}

	// Token: 0x06003AE2 RID: 15074 RVA: 0x007ACB24 File Offset: 0x007AAD24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003AE3 RID: 15075 RVA: 0x007ACB28 File Offset: 0x007AAD28
	internal static bool dFalII582ZkFVfylwgws()
	{
		return true;
	}

	// Token: 0x06003AE4 RID: 15076 RVA: 0x007ACB2C File Offset: 0x007AAD2C
	internal static bool JomONM588lsJuA23U40Y()
	{
		return false;
	}

	// Token: 0x040048E6 RID: 18662
	private CharacterControl xsxW3xTXZE;

	// Token: 0x040048E7 RID: 18663
	public AudioClip footStep_run1;

	// Token: 0x040048E8 RID: 18664
	public AudioClip footStep_run2;

	// Token: 0x040048E9 RID: 18665
	private bool BlFWbESein;

	// Token: 0x040048EA RID: 18666
	public GameObject deadEffect;

	// Token: 0x02000A77 RID: 2679
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30295 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003AE5 RID: 15077 RVA: 0x007ACB30 File Offset: 0x007AAD30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30295(UnityScript.Lang.Array nArray, Mupo self_)
		{
			if (117065 - 450067 != -333002)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122075 - 76115 == 45960)
				{
					base..ctor();
					if (123510 - 221201 == -97691)
					{
						this.$nArray$30300 = nArray;
						if (167656 - 478196 == -310540)
						{
							this.$self_$30301 = self_;
							if (44318 - 81698 == -37380)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003AE6 RID: 15078 RVA: 0x007ACBEC File Offset: 0x007AADEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Mupo.$RPC_dead$30295.$(this.$nArray$30300, this.$self_$30301);
		}

		// Token: 0x06003AE7 RID: 15079 RVA: 0x007ACC00 File Offset: 0x007AAE00
		internal static bool p1diwL58ZSGmlWxmClhe()
		{
			return true;
		}

		// Token: 0x06003AE8 RID: 15080 RVA: 0x007ACC04 File Offset: 0x007AAE04
		internal static bool GqXTut58CRuMb6abTUXO()
		{
			return false;
		}

		// Token: 0x040048EB RID: 18667
		internal UnityScript.Lang.Array $nArray$30300;

		// Token: 0x040048EC RID: 18668
		internal Mupo $self_$30301;

		// Token: 0x02000A78 RID: 2680
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003AE9 RID: 15081 RVA: 0x007ACC08 File Offset: 0x007AAE08
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Mupo self_)
			{
				if (87273 - 136334 != -49060)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278388 - 253791 != 24598)
					{
						base..ctor();
						if (254104 - 158151 != 95954)
						{
							this.$nArray$30298 = nArray;
							if (135608 - 9841 != 125768)
							{
								this.$self_$30299 = self_;
								if (279970 - 218290 == 61680)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003AEA RID: 15082 RVA: 0x007ACCC4 File Offset: 0x007AAEC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (234311 - 368625 != -134314)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$30299.xsxW3xTXZE.actionState != "dead")
						{
							if (95262 - 89933 != 5329)
							{
								continue;
							}
							goto IL_257;
						}
						else
						{
							if (!this.$self_$30299.xsxW3xTXZE.isPlayer)
							{
								if (29438 - 62049 != -32611)
								{
									continue;
								}
								if (this.$self_$30299.deadEffect)
								{
									if (213983 - 207727 != 6256)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30299.deadEffect, this.$self_$30299.transform.position + this.$self_$30299.transform.TransformDirection(-0.8f, (float)0, (float)0), this.$self_$30299.transform.rotation);
									if (254427 - 387199 != -132772)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (213996 - 332377 != -118381)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30299.gameObject);
								if (40761 - 280241 != -239480)
								{
									continue;
								}
							}
							else if (this.$self_$30299.xsxW3xTXZE.isMine)
							{
								if (13621 - 253585 == -239963)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30299.gameObject);
								if (121749 - 338345 != -216596)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (285275 - 416419 != -131143)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					default:
						if (84322 - 40870 != 43452)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30299.xsxW3xTXZE.actionState == "dead")
					{
						if (70071 - 509352 == -439281)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30296 = (Vector3)this.$nArray$30298[0];
						if (52162 - 179041 != -126878)
						{
							this.$myDirection$30297 = (Vector3)this.$nArray$30298[1];
							if (13830 - 114006 != -100175)
							{
								this.$self_$30299.transform.position = this.$myPosition$30296;
								if (266348 - 307325 != -40976)
								{
									this.$self_$30299.transform.LookAt(this.$myPosition$30296 + this.$myDirection$30297);
									if (221044 - 58321 == 162723)
									{
										this.$self_$30299.xsxW3xTXZE.hp = 0;
										if (262372 - 367566 == -105194)
										{
											this.$self_$30299.xsxW3xTXZE.actionState = "dead";
											if (231974 - 138495 == 93479)
											{
												this.$self_$30299.xsxW3xTXZE.actionTime = Time.time;
												if (118650 - 142050 != -23399)
												{
													this.$self_$30299.xsxW3xTXZE.myCommand = "none";
													if (222738 - 75593 == 147145)
													{
														this.$self_$30299.xsxW3xTXZE.vMovement = Vector3.zero;
														if (9265 - 127287 == -118022)
														{
															this.$self_$30299.xsxW3xTXZE.moveSpeed = (float)0;
															if (183372 - 514481 != -331108)
															{
																this.$self_$30299.animation.Rewind();
																if (146201 - 119119 == 27082)
																{
																	this.$self_$30299.animation.Play("ko");
																	if (116886 - 33531 == 83355)
																	{
																		this.$self_$30299.animation.wrapMode = WrapMode.Once;
																		if (92464 - 523278 == -430814)
																		{
																			goto IL_403;
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
				IL_257:
				Block_16:
				goto IL_4F0;
				IL_403:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4F0:
				return false;
			}

			// Token: 0x06003AEB RID: 15083 RVA: 0x007AD1D4 File Offset: 0x007AB3D4
			internal static bool cl7tuv58Lb5K8Lnyqydq()
			{
				return true;
			}

			// Token: 0x06003AEC RID: 15084 RVA: 0x007AD1D8 File Offset: 0x007AB3D8
			internal static bool OPAYXU58OT1NqQSs4ZpB()
			{
				return false;
			}

			// Token: 0x040048ED RID: 18669
			internal Vector3 $myPosition$30296;

			// Token: 0x040048EE RID: 18670
			internal Vector3 $myDirection$30297;

			// Token: 0x040048EF RID: 18671
			internal UnityScript.Lang.Array $nArray$30298;

			// Token: 0x040048F0 RID: 18672
			internal Mupo $self_$30299;
		}
	}
}
