using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A25 RID: 2597
[Serializable]
public class Cacton : MonoBehaviour
{
	// Token: 0x060038AF RID: 14511 RVA: 0x00775B3C File Offset: 0x00773D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Cacton()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060038B0 RID: 14512 RVA: 0x00775B4C File Offset: 0x00773D4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (229653 - 561137 != -331483)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (196429 - 379321 != -182891)
			{
				this.mChar.actionState = "standby";
				if (256237 - 321076 != -64838)
				{
					this.mChar.actionTime = Time.time;
					if (21703 - 320815 == -299112)
					{
						this.mChar.myCommand = "none";
						if (363 - 132962 == -132599)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (237319 - 412649 == -175330)
							{
								this.mChar.isMine = true;
								if (292273 - 93921 != 198353)
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

	// Token: 0x060038B1 RID: 14513 RVA: 0x00775C84 File Offset: 0x00773E84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (235786 - 207718 != 28069)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (288389 - 369074 != -80685)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (33702 - 204677 != -170975)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_277;
					}
					if (295562 - 573944 == -278381)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (168252 - 465610 == -297357)
				{
					continue;
				}
			}
			IL_277:
			if (this.mChar.hp > 0)
			{
				if (131998 - 237321 == -105322)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (176665 - 594224 != -417559)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (211762 - 98208 == 113554)
			{
				if (this.mChar.isMine)
				{
					if (38104 - 121970 == -83866)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (146550 - 292685 != -146134)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (156169 - 325775 != -169605)
							{
								this.mChar.DeadEvent();
								if (99853 - 486982 == -387129)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (194567 - 210553 == -15986)
					{
						this.mChar.hp = 1;
						if (7514 - 526226 == -518712)
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
					if (160565 - 457133 != -296567)
					{
						this.mChar.ko = 1;
						if (28669 - 415888 != -387218)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060038B2 RID: 14514 RVA: 0x00775F70 File Offset: 0x00774170
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (117721 - 415388 != -297666)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (92645 - 336001 != -243356)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (181826 - 376779 != -194953)
					{
						continue;
					}
					break;
				}
			}
			float num = this.mChar.moveSpeed;
			if (147218 - 383723 == -236505)
			{
				float runSpeed = this.mChar.runSpeed;
				if (126770 - 43961 != 82810)
				{
					Vector3 a = default(Vector3);
					if (132651 - 280961 != -148309)
					{
						Vector3 vector = Vector3.zero;
						if (49086 - 470235 != -421148)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (163984 - 436877 == -272893)
							{
								if (this.mChar.isMine)
								{
									if (170420 - 255437 == -85016)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (6095 - 595161 != -589066)
									{
										continue;
									}
									a.y = (float)0;
									if (246802 - 174669 == 72134)
									{
										continue;
									}
									a = a.normalized;
									if (243479 - 474599 != -231120)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (204889 - 165666 != 39223)
									{
										continue;
									}
									vector = vector.normalized;
									if (153612 - 365484 == -211871)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (262651 - 477934 != -215283)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (204647 - 167754 != 36893)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (184422 - 144599 != 39823)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (127803 - 35669 != 92134)
										{
											continue;
										}
										this.animation.Play("run");
										if (287663 - 527890 != -240227)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (13981 - 131999 == -118017)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (196242 - 515666 == -319423)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (262377 - 505815 == -243437)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (261804 - 98542 == 163263)
											{
												continue;
											}
											num = (float)0;
											if (222251 - 82065 == 140187)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (135217 - 575597 == -440379)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (36550 - 286101 != -249551)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (240895 - 202811 == 38085)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (55521 - 228661 != -173140)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (262943 - 471912 == -208968)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (205220 - 171572 != 33648)
										{
											continue;
										}
										num = (float)0;
										if (225605 - 352791 == -127185)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (159979 - 251508 == -91528)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (23675 - 442699 != -419024)
										{
											continue;
										}
										vector = lhs.normalized;
										if (43612 - 339491 != -295879)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (248058 - 184986 == 63073)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (10380 - 414513 == -404132)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (147847 - 399537 != -251690)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (174665 - 385723 != -211058)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (2460 - 579131 != -576671)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (44673 - 547976 != -503303)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (26207 - 468761 == -442554)
								{
									this.mChar.moveSpeed = num;
									if (43283 - 512148 != -468864)
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

	// Token: 0x060038B3 RID: 14515 RVA: 0x00776690 File Offset: 0x00774890
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060038B4 RID: 14516 RVA: 0x007766A8 File Offset: 0x007748A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060038B5 RID: 14517 RVA: 0x007766C0 File Offset: 0x007748C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060038B6 RID: 14518 RVA: 0x007766C4 File Offset: 0x007748C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Cacton.$RPC_dead$29993(nArray, this).GetEnumerator();
	}

	// Token: 0x060038B7 RID: 14519 RVA: 0x007766D4 File Offset: 0x007748D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038B8 RID: 14520 RVA: 0x007766D8 File Offset: 0x007748D8
	internal static bool jHEY3X5oPf0PBK7Th9CX()
	{
		return true;
	}

	// Token: 0x060038B9 RID: 14521 RVA: 0x007766DC File Offset: 0x007748DC
	internal static bool DTHgH35o02nPmvdiUC07()
	{
		return false;
	}

	// Token: 0x0400475B RID: 18267
	public CharacterControl mChar;

	// Token: 0x0400475C RID: 18268
	public GameObject deadEffect;

	// Token: 0x02000A26 RID: 2598
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$29993 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060038BA RID: 14522 RVA: 0x007766E0 File Offset: 0x007748E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$29993(UnityScript.Lang.Array nArray, Cacton self_)
		{
			if (133368 - 162759 != -29390)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (82513 - 153819 == -71306)
				{
					base..ctor();
					if (222345 - 414649 == -192304)
					{
						this.$nArray$29998 = nArray;
						if (192892 - 581405 == -388513)
						{
							this.$self_$29999 = self_;
							if (295028 - 341453 != -46424)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060038BB RID: 14523 RVA: 0x0077679C File Offset: 0x0077499C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Cacton.$RPC_dead$29993.$(this.$nArray$29998, this.$self_$29999);
		}

		// Token: 0x060038BC RID: 14524 RVA: 0x007767B0 File Offset: 0x007749B0
		internal static bool Km6o9v5obZ7wUriGBUdZ()
		{
			return true;
		}

		// Token: 0x060038BD RID: 14525 RVA: 0x007767B4 File Offset: 0x007749B4
		internal static bool sAdmwL5ou1dIpWyasB7H()
		{
			return false;
		}

		// Token: 0x0400475D RID: 18269
		internal UnityScript.Lang.Array $nArray$29998;

		// Token: 0x0400475E RID: 18270
		internal Cacton $self_$29999;

		// Token: 0x02000A27 RID: 2599
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060038BE RID: 14526 RVA: 0x007767B8 File Offset: 0x007749B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Cacton self_)
			{
				if (25004 - 394430 != -369425)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (157957 - 77825 != 80133)
					{
						base..ctor();
						if (258831 - 20510 == 238321)
						{
							this.$nArray$29996 = nArray;
							if (5859 - 106046 == -100187)
							{
								this.$self_$29997 = self_;
								if (81651 - 446252 != -364600)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060038BF RID: 14527 RVA: 0x00776874 File Offset: 0x00774A74
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (184397 - 544750 != -360352)
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
						if (this.$self_$29997.mChar.actionState != "dead")
						{
							if (54791 - 275903 != -221111)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							if (!this.$self_$29997.mChar.isPlayer)
							{
								if (203117 - 321732 != -118615)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$29997.gameObject);
								if (163980 - 436497 == -272516)
								{
									continue;
								}
								if (this.$self_$29997.deadEffect)
								{
									if (197247 - 193388 == 3860)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$29997.deadEffect, this.$self_$29997.transform.position, this.$self_$29997.transform.rotation);
									if (91133 - 258462 == -167328)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (20741 - 295538 == -274796)
									{
										continue;
									}
								}
							}
							else if (this.$self_$29997.mChar.isMine)
							{
								if (249239 - 218472 == 30768)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$29997.gameObject);
								if (28401 - 429165 != -400764)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (259574 - 90712 != 168863)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (86208 - 13720 == 72489)
						{
							continue;
						}
						break;
					}
					if (this.$self_$29997.mChar.actionState == "dead")
					{
						if (68159 - 577637 == -509478)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$29994 = (Vector3)this.$nArray$29996[0];
						if (5914 - 263478 != -257563)
						{
							this.$myDirection$29995 = (Vector3)this.$nArray$29996[1];
							if (244637 - 422191 != -177553)
							{
								this.$self_$29997.transform.position = this.$myPosition$29994;
								if (263417 - 146081 == 117336)
								{
									this.$self_$29997.transform.LookAt(this.$myPosition$29994 + this.$myDirection$29995);
									if (116822 - 451096 == -334274)
									{
										this.$self_$29997.mChar.hp = 0;
										if (9859 - 552829 != -542969)
										{
											this.$self_$29997.mChar.actionState = "dead";
											if (248125 - 348064 == -99939)
											{
												this.$self_$29997.mChar.actionTime = Time.time;
												if (253618 - 499983 == -246365)
												{
													this.$self_$29997.mChar.myCommand = "none";
													if (77531 - 467404 != -389872)
													{
														this.$self_$29997.mChar.vMovement = Vector3.zero;
														if (172709 - 355252 == -182543)
														{
															this.$self_$29997.mChar.moveSpeed = (float)0;
															if (263616 - 272714 != -9097)
															{
																this.$self_$29997.animation.Rewind();
																if (148071 - 499 != 147573)
																{
																	this.$self_$29997.animation.Play("ko");
																	if (272077 - 151854 == 120223)
																	{
																		this.$self_$29997.animation.wrapMode = WrapMode.Once;
																		if (158037 - 34157 == 123880)
																		{
																			goto IL_483;
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
				Block_23:
				goto IL_4D2;
				IL_483:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_30:
				IL_4D2:
				return false;
			}

			// Token: 0x060038C0 RID: 14528 RVA: 0x00776D68 File Offset: 0x00774F68
			internal static bool G0yh3o5oIHthuGFGlCLe()
			{
				return true;
			}

			// Token: 0x060038C1 RID: 14529 RVA: 0x00776D6C File Offset: 0x00774F6C
			internal static bool ddlOTT5oBxI0RLJ3CBKQ()
			{
				return false;
			}

			// Token: 0x0400475F RID: 18271
			internal Vector3 $myPosition$29994;

			// Token: 0x04004760 RID: 18272
			internal Vector3 $myDirection$29995;

			// Token: 0x04004761 RID: 18273
			internal UnityScript.Lang.Array $nArray$29996;

			// Token: 0x04004762 RID: 18274
			internal Cacton $self_$29997;
		}
	}
}
