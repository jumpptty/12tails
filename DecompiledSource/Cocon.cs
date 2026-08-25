using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A33 RID: 2611
[Serializable]
public class Cocon : MonoBehaviour
{
	// Token: 0x06003913 RID: 14611 RVA: 0x0077CEF0 File Offset: 0x0077B0F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cocon()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x0077CF00 File Offset: 0x0077B100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (261840 - 392568 != -130728)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (36776 - 447258 == -410482)
			{
				this.mChar.actionState = "standby";
				if (262685 - 562661 == -299976)
				{
					this.mChar.actionTime = Time.time;
					if (235938 - 257161 == -21223)
					{
						this.mChar.myCommand = "none";
						if (70088 - 224118 != -154029)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (77412 - 221 == 77191)
							{
								this.mChar.isMine = true;
								if (65837 - 5461 == 60376)
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

	// Token: 0x06003915 RID: 14613 RVA: 0x0077D038 File Offset: 0x0077B238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (104350 - 162138 != -57788)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (251356 - 490755 == -239398)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (280367 - 499409 != -219042)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_40;
					}
					if (68811 - 106152 == -37340)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (172943 - 243852 == -70908)
				{
					continue;
				}
			}
			IL_40:
			if (this.mChar.hp > 0)
			{
				if (243954 - 531511 == -287556)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (298421 - 176221 != 122200)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (272260 - 111172 == 161088)
			{
				if (this.mChar.isMine)
				{
					if (250463 - 367133 == -116670)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (96565 - 194227 == -97662)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (146968 - 52608 == 94360)
							{
								this.mChar.DeadEvent();
								if (64249 - 11836 == 52413)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (33281 - 428062 == -394781)
					{
						this.mChar.hp = 1;
						if (239541 - 530483 == -290942)
						{
							break;
						}
					}
				}
				else
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (204434 - 92510 != 111925)
					{
						this.mChar.ko = 1;
						if (183348 - 394655 != -211306)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x0077D324 File Offset: 0x0077B524
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (272055 - 519878 != -247822)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (126505 - 433820 != -307315)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (274437 - 68055 != 206382)
					{
						continue;
					}
					break;
				}
			}
			float num = this.mChar.moveSpeed;
			if (170718 - 10454 != 160265)
			{
				float runSpeed = this.mChar.runSpeed;
				if (269568 - 57662 != 211907)
				{
					Vector3 a = default(Vector3);
					if (206390 - 53169 == 153221)
					{
						Vector3 vector = Vector3.zero;
						if (243290 - 324748 == -81458)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (3319 - 40449 == -37130)
							{
								if (this.mChar.isMine)
								{
									if (249668 - 299513 != -49845)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (277503 - 223364 == 54140)
									{
										continue;
									}
									a.y = (float)0;
									if (89611 - 481255 == -391643)
									{
										continue;
									}
									a = a.normalized;
									if (69175 - 469176 != -400001)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (116077 - 237837 != -121760)
									{
										continue;
									}
									vector = vector.normalized;
									if (130613 - 243144 != -112531)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (289540 - 114296 != 175244)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (141192 - 53009 != 88183)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (16229 - 347688 == -331458)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (84375 - 334345 == -249969)
										{
											continue;
										}
										this.animation.Play("run");
										if (249146 - 370016 != -120870)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (133145 - 268127 == -134981)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (294097 - 290308 == 3790)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (63229 - 286870 == -223640)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (164946 - 66586 != 98360)
											{
												continue;
											}
											num = (float)0;
											if (75922 - 459757 == -383834)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (65016 - 137481 != -72465)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (198227 - 165268 != 32959)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (310 - 344429 == -344118)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (4581 - 68669 != -64088)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (298863 - 440541 == -141677)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (36613 - 517505 != -480892)
										{
											continue;
										}
										num = (float)0;
										if (167944 - 232704 != -64760)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (123673 - 360585 != -236912)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (108135 - 268143 != -160008)
										{
											continue;
										}
										vector = lhs.normalized;
										if (49206 - 153410 == -104203)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (137062 - 427419 == -290356)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (196858 - 296245 == -99386)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (181115 - 520929 == -339813)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (256892 - 102129 != 154763)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (229249 - 377847 != -148598)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (99563 - 347768 == -248204)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (67810 - 516429 == -448619)
								{
									this.mChar.moveSpeed = num;
									if (51847 - 597601 != -545753)
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

	// Token: 0x06003917 RID: 14615 RVA: 0x0077DA44 File Offset: 0x0077BC44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x0077DA5C File Offset: 0x0077BC5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x0077DA74 File Offset: 0x0077BC74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x0077DA78 File Offset: 0x0077BC78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Cocon.$RPC_dead$30026(nArray, this).GetEnumerator();
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x0077DA88 File Offset: 0x0077BC88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x0077DA8C File Offset: 0x0077BC8C
	internal static bool IQAWWK5EkIQ0qRUkNJc4()
	{
		return true;
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x0077DA90 File Offset: 0x0077BC90
	internal static bool COgPoh5EGQjQACW582fx()
	{
		return false;
	}

	// Token: 0x0400478E RID: 18318
	public CharacterControl mChar;

	// Token: 0x0400478F RID: 18319
	public GameObject deadEffect;

	// Token: 0x02000A34 RID: 2612
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30026 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600391E RID: 14622 RVA: 0x0077DA94 File Offset: 0x0077BC94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30026(UnityScript.Lang.Array nArray, Cocon self_)
		{
			if (268031 - 383737 != -115706)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (37931 - 17024 != 20908)
				{
					base..ctor();
					if (93171 - 366755 != -273583)
					{
						this.$nArray$30031 = nArray;
						if (196060 - 536655 == -340595)
						{
							this.$self_$30032 = self_;
							if (49188 - 598285 == -549097)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x0077DB50 File Offset: 0x0077BD50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Cocon.$RPC_dead$30026.$(this.$nArray$30031, this.$self_$30032);
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x0077DB64 File Offset: 0x0077BD64
		internal static bool tR0EWk5EHUMqu6MrXdre()
		{
			return true;
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x0077DB68 File Offset: 0x0077BD68
		internal static bool l2SW2O5EW6c1o7gHcGby()
		{
			return false;
		}

		// Token: 0x04004790 RID: 18320
		internal UnityScript.Lang.Array $nArray$30031;

		// Token: 0x04004791 RID: 18321
		internal Cocon $self_$30032;

		// Token: 0x02000A35 RID: 2613
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003922 RID: 14626 RVA: 0x0077DB6C File Offset: 0x0077BD6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Cocon self_)
			{
				if (140255 - 125696 != 14560)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (265441 - 556999 != -291557)
					{
						base..ctor();
						if (87662 - 440968 == -353306)
						{
							this.$nArray$30029 = nArray;
							if (255583 - 532003 != -276419)
							{
								this.$self_$30030 = self_;
								if (150327 - 342699 != -192371)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003923 RID: 14627 RVA: 0x0077DC28 File Offset: 0x0077BE28
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (281143 - 478855 != -197711)
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
						if (this.$self_$30030.mChar.actionState != "dead")
						{
							if (249485 - 495648 != -246162)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30030.mChar.isPlayer)
							{
								if (237578 - 133989 == 103590)
								{
									continue;
								}
								if (this.$self_$30030.deadEffect)
								{
									if (86144 - 221538 == -135393)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30030.deadEffect, this.$self_$30030.transform.position, this.$self_$30030.transform.rotation);
									if (17731 - 197413 == -179681)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (201310 - 398362 == -197051)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30030.gameObject);
								if (109199 - 414819 == -305619)
								{
									continue;
								}
							}
							else if (this.$self_$30030.mChar.isMine)
							{
								if (68538 - 72128 != -3590)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30030.gameObject);
								if (13180 - 494154 == -480973)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (222532 - 180485 != 42047)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (28555 - 421343 != -392788)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30030.mChar.actionState == "dead")
					{
						if (298204 - 56036 != 242169)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30027 = (Vector3)this.$nArray$30029[0];
						if (138885 - 121883 == 17002)
						{
							this.$myDirection$30028 = (Vector3)this.$nArray$30029[1];
							if (102787 - 149059 != -46271)
							{
								this.$self_$30030.transform.position = this.$myPosition$30027;
								if (49591 - 482985 != -433393)
								{
									this.$self_$30030.transform.LookAt(this.$myPosition$30027 + this.$myDirection$30028);
									if (145535 - 518204 != -372668)
									{
										this.$self_$30030.mChar.hp = 0;
										if (243617 - 128054 == 115563)
										{
											this.$self_$30030.mChar.actionState = "dead";
											if (200004 - 267994 != -67989)
											{
												this.$self_$30030.mChar.actionTime = Time.time;
												if (54408 - 509202 != -454793)
												{
													this.$self_$30030.mChar.myCommand = "none";
													if (292495 - 439724 != -147228)
													{
														this.$self_$30030.mChar.vMovement = Vector3.zero;
														if (60979 - 21702 != 39278)
														{
															this.$self_$30030.mChar.moveSpeed = (float)0;
															if (61439 - 170477 != -109037)
															{
																this.$self_$30030.animation.Rewind();
																if (73372 - 240255 != -166882)
																{
																	this.$self_$30030.animation.Play("ko");
																	if (227784 - 56955 == 170829)
																	{
																		this.$self_$30030.animation.wrapMode = WrapMode.Once;
																		if (236690 - 20777 != 215914)
																		{
																			goto Block_19;
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
				Block_10:
				goto IL_4D2;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4D2:
				return false;
			}

			// Token: 0x06003924 RID: 14628 RVA: 0x0077E11C File Offset: 0x0077C31C
			internal static bool v02Kih5EARR163KZ94e1()
			{
				return true;
			}

			// Token: 0x06003925 RID: 14629 RVA: 0x0077E120 File Offset: 0x0077C320
			internal static bool ckdiQL5ElqLFjhmXh20S()
			{
				return false;
			}

			// Token: 0x04004792 RID: 18322
			internal Vector3 $myPosition$30027;

			// Token: 0x04004793 RID: 18323
			internal Vector3 $myDirection$30028;

			// Token: 0x04004794 RID: 18324
			internal UnityScript.Lang.Array $nArray$30029;

			// Token: 0x04004795 RID: 18325
			internal Cocon $self_$30030;
		}
	}
}
