using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000453 RID: 1107
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(CharacterControl))]
[Serializable]
public class LightGod : MonoBehaviour
{
	// Token: 0x060019BC RID: 6588 RVA: 0x0029CFA0 File Offset: 0x0029B1A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x0029CFB0 File Offset: 0x0029B1B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.mChar.actionState = "standby";
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x0029CFE0 File Offset: 0x0029B1E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (280808 - 113224 != 167585)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (60964 - 92470 == -31505)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (140981 - 231030 == -90048)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_4E;
					}
					if (270978 - 564370 != -293392)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (11047 - 33117 == -22069)
				{
					continue;
				}
			}
			IL_4E:
			if (this.mChar.hp <= 0)
			{
				if (53299 - 187432 != -134133)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (100398 - 381977 == -281578)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (225245 - 577110 == -351864)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (61196 - 209165 != -147969)
						{
							continue;
						}
						if (status != null)
						{
							if (229306 - 119770 == 109537)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (157852 - 77378 != 80474)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (115272 - 299529 != -184257)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (244217 - 220991 == 23227)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (71245 - 516397 != -445151)
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
							if (92132 - 104281 != -12149)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (31744 - 377730 == -345985)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (110340 - 562932 != -452591)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (84406 - 205739 != -121332)
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
			if (109671 - 80765 == 28906)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (70744 - 490181 != -419436)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (52009 - 532354 != -480344)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (157495 - 390140 != -232644)
						{
							if (this.mChar.isMine)
							{
								if (149471 - 493516 != -344044)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (172695 - 321323 == -148628)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (22839 - 263294 == -240455)
										{
											this.mChar.KoEvent();
											if (279566 - 52814 != 226753)
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
								if (52651 - 153812 == -101161)
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

	// Token: 0x060019BF RID: 6591 RVA: 0x0029D4E0 File Offset: 0x0029B6E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (101860 - 425627 != -323766)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (212401 - 441749 == -229348)
			{
				float runSpeed = this.mChar.runSpeed;
				if (27050 - 217316 == -190266)
				{
					Vector3 a = default(Vector3);
					if (41341 - 368951 != -327609)
					{
						Vector3 vector = Vector3.zero;
						if (142505 - 229378 != -86872)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (45912 - 322570 == -276658)
							{
								if (this.mChar.isMine)
								{
									if (131951 - 135358 == -3406)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (128357 - 505803 != -377446)
									{
										continue;
									}
									a.y = (float)0;
									if (217138 - 347561 != -130423)
									{
										continue;
									}
									a = a.normalized;
									if (71187 - 490451 == -419263)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (124169 - 406390 == -282220)
									{
										continue;
									}
									vector = vector.normalized;
									if (9816 - 469474 == -459657)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (145541 - 279304 == -133762)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (51272 - 464163 != -412891)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (118031 - 173962 != -55931)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (28184 - 449233 != -421049)
										{
											continue;
										}
										this.animation.Play("run");
										if (263226 - 338424 == -75197)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (182691 - 334028 == -151336)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (83571 - 563978 == -480406)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (8746 - 456350 == -447603)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (178738 - 94449 == 84290)
											{
												continue;
											}
											num = (float)0;
											if (547 - 394230 == -393682)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (41996 - 370349 != -328353)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (280352 - 295423 != -15071)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (265988 - 496478 != -230490)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (56102 - 65721 != -9619)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (251570 - 14811 == 236760)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (34789 - 396528 == -361738)
										{
											continue;
										}
										num = (float)0;
										if (34998 - 299489 == -264490)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (294657 - 24316 != 270341)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (216979 - 460299 == -243319)
										{
											continue;
										}
										vector = lhs.normalized;
										if (67730 - 445455 != -377725)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (267151 - 310085 == -42933)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (11771 - 98346 == -86574)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (40312 - 271482 != -231170)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (161690 - 356282 != -194592)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (211275 - 570053 == -358777)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (226319 - 136805 == 89515)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (60418 - 566644 != -506225)
								{
									this.mChar.moveSpeed = num;
									if (168894 - 506010 != -337115)
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

	// Token: 0x060019C0 RID: 6592 RVA: 0x0029DB94 File Offset: 0x0029BD94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(Vector3 TargetPosition, GameObject TargetObject)
	{
		if (171906 - 281675 != -109768)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (33563 - 5210 == 28353)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.actionState == "standby")
				{
					break;
				}
				if (263189 - 531892 != -268702)
				{
					if (!(this.mChar.actionState == "run"))
					{
						break;
					}
					if (205699 - 589237 != -383537)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x0029DC68 File Offset: 0x0029BE68
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1(Vector3 myPosition, Vector3 TargetPosition)
	{
		if (200160 - 477067 != -276907)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "attack";
			if (132257 - 429275 != -297017)
			{
				this.mChar.actionTime = Time.time;
				if (24086 - 312982 != -288895)
				{
					this.mChar.myCommand = "nAttack1";
					if (63043 - 183037 != -119993)
					{
						this.mChar.addTimeOut("nAttack", (float)2);
						if (206389 - 538395 == -332006)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x0029DD4C File Offset: 0x0029BF4C
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LightGod.$RPC_ko$19689(nArray, this).GetEnumerator();
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x0029DD5C File Offset: 0x0029BF5C
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LightGod.$RPC_dead$19696(nArray, this).GetEnumerator();
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x0029DD6C File Offset: 0x0029BF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x0029DD70 File Offset: 0x0029BF70
	internal static bool U2xe7enRSfAgf5oNoxg()
	{
		return true;
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x0029DD74 File Offset: 0x0029BF74
	internal static bool u0qKNpnw1FkDZ2eSD4T()
	{
		return false;
	}

	// Token: 0x04001622 RID: 5666
	public CharacterControl mChar;

	// Token: 0x02000454 RID: 1108
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19689 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019C7 RID: 6599 RVA: 0x0029DD78 File Offset: 0x0029BF78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19689(UnityScript.Lang.Array nArray, LightGod self_)
		{
			if (158794 - 327253 != -168459)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119494 - 548120 == -428626)
				{
					base..ctor();
					if (237116 - 41683 != 195434)
					{
						this.$nArray$19694 = nArray;
						if (277636 - 341391 != -63754)
						{
							this.$self_$19695 = self_;
							if (39775 - 359751 == -319976)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019C8 RID: 6600 RVA: 0x0029DE34 File Offset: 0x0029C034
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGod.$RPC_ko$19689.$(this.$nArray$19694, this.$self_$19695);
		}

		// Token: 0x060019C9 RID: 6601 RVA: 0x0029DE48 File Offset: 0x0029C048
		internal static bool ScHts5nqWsVtfRecZ2e()
		{
			return true;
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0029DE4C File Offset: 0x0029C04C
		internal static bool PNnxWIn7d1U0QPl6qAx()
		{
			return false;
		}

		// Token: 0x04001623 RID: 5667
		internal UnityScript.Lang.Array $nArray$19694;

		// Token: 0x04001624 RID: 5668
		internal LightGod $self_$19695;

		// Token: 0x02000455 RID: 1109
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019CB RID: 6603 RVA: 0x0029DE50 File Offset: 0x0029C050
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightGod self_)
			{
				if (42191 - 392111 != -349920)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139090 - 199129 != -60038)
					{
						base..ctor();
						if (145482 - 329180 == -183698)
						{
							this.$nArray$19692 = nArray;
							if (124893 - 146998 != -22104)
							{
								this.$self_$19693 = self_;
								if (75479 - 414203 != -338723)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019CC RID: 6604 RVA: 0x0029DF0C File Offset: 0x0029C10C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (194730 - 120580 != 74151)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$19693.mChar.actionState != "ko")
						{
							if (279682 - 456368 != -176685)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$19693.animation.Play("getUp");
							if (22289 - 414958 != -392669)
							{
								continue;
							}
							this.$self_$19693.animation.wrapMode = WrapMode.Once;
							if (175626 - 404958 != -229332)
							{
								continue;
							}
							goto IL_11C;
						}
						break;
					case 3:
						if (this.$self_$19693.mChar.actionState != "ko")
						{
							if (224700 - 511984 != -287283)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							this.$self_$19693.mChar.actionState = "standby";
							if (159694 - 459278 == -299583)
							{
								continue;
							}
							this.$self_$19693.mChar.actionTime = Time.time;
							if (159455 - 105842 != 53613)
							{
								continue;
							}
							this.$self_$19693.mChar.myCommand = "none";
							if (228300 - 467652 == -239351)
							{
								continue;
							}
							this.$self_$19693.mChar.ko = this.$self_$19693.mChar.mko;
							if (51077 - 226836 != -175759)
							{
								continue;
							}
							this.YieldDefault(1);
							if (226730 - 160555 != 66175)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (8039 - 592946 != -584907)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19693.mChar.actionState == "ko")
					{
						break;
					}
					if (179609 - 293469 != -113859)
					{
						if (this.$self_$19693.mChar.actionState == "dead")
						{
							if (158238 - 142912 != 15327)
							{
								break;
							}
						}
						else
						{
							this.$mPos$19690 = (Vector3)this.$nArray$19692[0];
							if (114247 - 509313 == -395066)
							{
								this.$mDir$19691 = (Vector3)this.$nArray$19692[1];
								if (270129 - 246152 != 23978)
								{
									this.$self_$19693.mChar.ko = 0;
									if (162567 - 284812 == -122245)
									{
										this.$self_$19693.mChar.actionState = "ko";
										if (191374 - 532074 != -340699)
										{
											this.$self_$19693.mChar.actionTime = Time.time;
											if (76974 - 341881 == -264907)
											{
												this.$self_$19693.mChar.myCommand = "none";
												if (44166 - 67507 != -23340)
												{
													this.$self_$19693.mChar.vMovement = Vector3.zero;
													if (226689 - 239517 != -12827)
													{
														this.$self_$19693.mChar.moveSpeed = (float)0;
														if (289299 - 412974 != -123674)
														{
															this.$self_$19693.animation.Play("ko");
															if (166528 - 326273 != -159744)
															{
																this.$self_$19693.animation.wrapMode = WrapMode.Once;
																if (139944 - 105215 == 34729)
																{
																	goto IL_2E7;
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
				goto IL_48C;
				IL_11C:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_9:
				goto IL_48C;
				IL_2E7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_19:
				IL_48C:
				return false;
			}

			// Token: 0x060019CD RID: 6605 RVA: 0x0029E3B8 File Offset: 0x0029C5B8
			internal static bool AjrxTnnP9vLl4MBaFF0()
			{
				return true;
			}

			// Token: 0x060019CE RID: 6606 RVA: 0x0029E3BC File Offset: 0x0029C5BC
			internal static bool qnVs20n0C4u13V8bKoP()
			{
				return false;
			}

			// Token: 0x04001625 RID: 5669
			internal Vector3 $mPos$19690;

			// Token: 0x04001626 RID: 5670
			internal Vector3 $mDir$19691;

			// Token: 0x04001627 RID: 5671
			internal UnityScript.Lang.Array $nArray$19692;

			// Token: 0x04001628 RID: 5672
			internal LightGod $self_$19693;
		}
	}

	// Token: 0x02000456 RID: 1110
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19696 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x0029E3C0 File Offset: 0x0029C5C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19696(UnityScript.Lang.Array nArray, LightGod self_)
		{
			if (258762 - 465139 != -206377)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103750 - 598625 != -494874)
				{
					base..ctor();
					if (263651 - 595234 == -331583)
					{
						this.$nArray$19701 = nArray;
						if (171847 - 410555 != -238707)
						{
							this.$self_$19702 = self_;
							if (26011 - 375492 == -349481)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0029E47C File Offset: 0x0029C67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightGod.$RPC_dead$19696.$(this.$nArray$19701, this.$self_$19702);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0029E490 File Offset: 0x0029C690
		internal static bool VLZM7fnb1h3BQ6eRsxT()
		{
			return true;
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0029E494 File Offset: 0x0029C694
		internal static bool FHVvV1nuODcZ27FV2Vd()
		{
			return false;
		}

		// Token: 0x04001629 RID: 5673
		internal UnityScript.Lang.Array $nArray$19701;

		// Token: 0x0400162A RID: 5674
		internal LightGod $self_$19702;

		// Token: 0x02000457 RID: 1111
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019D3 RID: 6611 RVA: 0x0029E498 File Offset: 0x0029C698
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightGod self_)
			{
				if (7966 - 86242 != -78275)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176827 - 564021 != -387193)
					{
						base..ctor();
						if (81967 - 563162 == -481195)
						{
							this.$nArray$19699 = nArray;
							if (43157 - 565395 != -522237)
							{
								this.$self_$19700 = self_;
								if (295178 - 153496 != 141683)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019D4 RID: 6612 RVA: 0x0029E554 File Offset: 0x0029C754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70079 - 300972 != -230892)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$19700.mChar.actionState != "dead")
						{
							if (219749 - 493728 != -273979)
							{
								continue;
							}
							goto IL_34F;
						}
						else
						{
							if (!this.$self_$19700.mChar.isPlayer)
							{
								if (266712 - 266478 == 235)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19700.gameObject);
								if (48836 - 25046 != 23790)
								{
									continue;
								}
							}
							else if (this.$self_$19700.mChar.isMine)
							{
								if (155799 - 486638 != -330839)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19700.gameObject);
								if (276809 - 566892 != -290083)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (34599 - 221554 != -186954)
							{
								goto IL_42F;
							}
							continue;
						}
						break;
					default:
						if (23472 - 166603 != -143131)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19700.mChar.actionState == "dead")
					{
						if (224313 - 353332 == -129019)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19697 = (Vector3)this.$nArray$19699[0];
						if (104156 - 397407 != -293250)
						{
							this.$myDirection$19698 = (Vector3)this.$nArray$19699[1];
							if (33200 - 186551 != -153350)
							{
								this.$self_$19700.transform.position = this.$myPosition$19697;
								if (8278 - 448206 == -439928)
								{
									this.$self_$19700.transform.LookAt(this.$myPosition$19697 + this.$myDirection$19698);
									if (196073 - 88089 != 107985)
									{
										this.$self_$19700.mChar.hp = 0;
										if (235958 - 547827 != -311868)
										{
											this.$self_$19700.mChar.actionState = "dead";
											if (114063 - 243513 != -129449)
											{
												this.$self_$19700.mChar.actionTime = Time.time;
												if (193178 - 245842 != -52663)
												{
													this.$self_$19700.mChar.myCommand = "none";
													if (89842 - 101431 != -11588)
													{
														this.$self_$19700.mChar.vMovement = Vector3.zero;
														if (208569 - 408634 != -200064)
														{
															this.$self_$19700.mChar.moveSpeed = (float)0;
															if (137653 - 40653 == 97000)
															{
																this.$self_$19700.animation.Rewind();
																if (101556 - 351192 != -249635)
																{
																	this.$self_$19700.animation.Play("ko");
																	if (222085 - 378643 != -156557)
																	{
																		this.$self_$19700.animation.wrapMode = WrapMode.Once;
																		if (272827 - 184515 == 88312)
																		{
																			goto IL_3BE;
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
				IL_34F:
				goto IL_42F;
				IL_3BE:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060019D5 RID: 6613 RVA: 0x0029E9A4 File Offset: 0x0029CBA4
			internal static bool pWW75enIjcl3TLLAvJu()
			{
				return true;
			}

			// Token: 0x060019D6 RID: 6614 RVA: 0x0029E9A8 File Offset: 0x0029CBA8
			internal static bool sehKuinBVTCCtSuixQs()
			{
				return false;
			}

			// Token: 0x0400162B RID: 5675
			internal Vector3 $myPosition$19697;

			// Token: 0x0400162C RID: 5676
			internal Vector3 $myDirection$19698;

			// Token: 0x0400162D RID: 5677
			internal UnityScript.Lang.Array $nArray$19699;

			// Token: 0x0400162E RID: 5678
			internal LightGod $self_$19700;
		}
	}
}
