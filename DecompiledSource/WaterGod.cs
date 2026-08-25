using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200045D RID: 1117
[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(CharacterControl))]
[Serializable]
public class WaterGod : MonoBehaviour
{
	// Token: 0x060019F3 RID: 6643 RVA: 0x002A04FC File Offset: 0x0029E6FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x002A050C File Offset: 0x0029E70C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.mChar.actionState = "standby";
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x002A053C File Offset: 0x0029E73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131217 - 525135 != -393918)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (186350 - 130609 != 55741)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (142810 - 450004 != -307194)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_233;
					}
					if (125498 - 582827 == -457328)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (237224 - 67375 == 169850)
				{
					continue;
				}
			}
			IL_233:
			if (this.mChar.hp <= 0)
			{
				if (217842 - 15777 != 202065)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (54329 - 423845 != -369516)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (168463 - 158774 == 9690)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (241782 - 178198 == 63585)
						{
							continue;
						}
						if (status != null)
						{
							if (56213 - 263290 != -207077)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (266818 - 270324 == -3505)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (292746 - 228070 != 64676)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (74996 - 442414 != -367418)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (225891 - 13292 != 212599)
							{
								continue;
							}
							break;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (17034 - 515435 != -498401)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (29389 - 223111 != -193722)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (150074 - 137277 != 12797)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (176554 - 347020 != -170466)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (15911 - 518070 != -502158)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (48941 - 437126 != -388184)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (5896 - 129617 != -123720)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (170883 - 501021 == -330138)
						{
							if (this.mChar.isMine)
							{
								if (53686 - 105417 == -51731)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (55330 - 306612 == -251282)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (214658 - 77569 != 137090)
										{
											this.mChar.KoEvent();
											if (76895 - 341014 != -264118)
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
								if (164690 - 142610 != 22081)
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

	// Token: 0x060019F6 RID: 6646 RVA: 0x002A0A3C File Offset: 0x0029EC3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (244937 - 162514 != 82423)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (174212 - 224133 != -49920)
			{
				float runSpeed = this.mChar.runSpeed;
				if (139704 - 397160 == -257456)
				{
					Vector3 a = default(Vector3);
					if (225491 - 36505 == 188986)
					{
						Vector3 vector = Vector3.zero;
						if (88114 - 488441 != -400326)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (81990 - 314200 != -232209)
							{
								if (this.mChar.isMine)
								{
									if (257108 - 92634 == 164475)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (214878 - 215687 != -809)
									{
										continue;
									}
									a.y = (float)0;
									if (241828 - 370833 == -129004)
									{
										continue;
									}
									a = a.normalized;
									if (136920 - 212644 != -75724)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (69699 - 585145 == -515445)
									{
										continue;
									}
									vector = vector.normalized;
									if (94368 - 436397 == -342028)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (61214 - 218620 == -157405)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (191929 - 268385 == -76455)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (75796 - 522674 == -446877)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (93253 - 229352 != -136099)
										{
											continue;
										}
										this.animation.Play("run");
										if (206421 - 230277 != -23856)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (7213 - 364937 != -357724)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (233048 - 599632 != -366584)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (295910 - 477437 != -181527)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (199922 - 158244 != 41678)
											{
												continue;
											}
											num = (float)0;
											if (219281 - 518205 == -298923)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (153561 - 485890 != -332329)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (280304 - 82933 != 197371)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (61704 - 190883 == -129178)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (42703 - 98624 == -55920)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (219840 - 59529 != 160311)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (272852 - 347712 != -74860)
										{
											continue;
										}
										num = (float)0;
										if (47604 - 255610 != -208006)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (282104 - 81960 == 200145)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (24086 - 116920 == -92833)
										{
											continue;
										}
										vector = lhs.normalized;
										if (264001 - 363266 != -99265)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (245166 - 36286 != 208880)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (242862 - 417529 == -174666)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (137813 - 176305 == -38491)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (110546 - 535471 != -424925)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (282207 - 15300 == 266908)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (49016 - 188775 == -139758)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (120899 - 490635 != -369735)
								{
									this.mChar.moveSpeed = num;
									if (268357 - 497952 == -229595)
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

	// Token: 0x060019F7 RID: 6647 RVA: 0x002A10F0 File Offset: 0x0029F2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(Vector3 TargetPosition, GameObject TargetObject)
	{
		if (257907 - 208508 != 49400)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (181201 - 527014 != -345812)
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
				if (53605 - 428127 != -374521)
				{
					if (!(this.mChar.actionState == "run"))
					{
						break;
					}
					if (54865 - 569911 == -515046)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x002A11C4 File Offset: 0x0029F3C4
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1(Vector3 myPosition, Vector3 TargetPosition)
	{
		if (272501 - 584898 != -312396)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "attack";
			if (288809 - 210459 != 78351)
			{
				this.mChar.actionTime = Time.time;
				if (4503 - 261822 == -257319)
				{
					this.mChar.myCommand = "nAttack1";
					if (35388 - 376378 != -340989)
					{
						this.mChar.addTimeOut("nAttack", (float)2);
						if (179355 - 39396 != 139960)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x002A12A8 File Offset: 0x0029F4A8
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new WaterGod.$RPC_ko$19717(nArray, this).GetEnumerator();
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x002A12B8 File Offset: 0x0029F4B8
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WaterGod.$RPC_dead$19724(nArray, this).GetEnumerator();
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x002A12C8 File Offset: 0x0029F4C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x002A12CC File Offset: 0x0029F4CC
	internal static bool tkhe0865dMuECX2yd6Z()
	{
		return true;
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x002A12D0 File Offset: 0x0029F4D0
	internal static bool shXmnC6pBVPelBKm7vR()
	{
		return false;
	}

	// Token: 0x0400163C RID: 5692
	public CharacterControl mChar;

	// Token: 0x0200045E RID: 1118
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19717 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019FE RID: 6654 RVA: 0x002A12D4 File Offset: 0x0029F4D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19717(UnityScript.Lang.Array nArray, WaterGod self_)
		{
			if (143778 - 584687 != -440909)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (19773 - 553743 != -533969)
				{
					base..ctor();
					if (33986 - 566816 == -532830)
					{
						this.$nArray$19722 = nArray;
						if (240707 - 492630 != -251922)
						{
							this.$self_$19723 = self_;
							if (155859 - 270187 == -114328)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x002A1390 File Offset: 0x0029F590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterGod.$RPC_ko$19717.$(this.$nArray$19722, this.$self_$19723);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x002A13A4 File Offset: 0x0029F5A4
		internal static bool uQOWmW6VhEAdVOCvace()
		{
			return true;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x002A13A8 File Offset: 0x0029F5A8
		internal static bool pJjZP36tvIcC5AAubAM()
		{
			return false;
		}

		// Token: 0x0400163D RID: 5693
		internal UnityScript.Lang.Array $nArray$19722;

		// Token: 0x0400163E RID: 5694
		internal WaterGod $self_$19723;

		// Token: 0x0200045F RID: 1119
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A02 RID: 6658 RVA: 0x002A13AC File Offset: 0x0029F5AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WaterGod self_)
			{
				if (10639 - 440023 != -429384)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286251 - 223713 != 62539)
					{
						base..ctor();
						if (103980 - 321997 != -218016)
						{
							this.$nArray$19720 = nArray;
							if (112255 - 488117 != -375861)
							{
								this.$self_$19721 = self_;
								if (59898 - 145730 != -85831)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A03 RID: 6659 RVA: 0x002A1468 File Offset: 0x0029F668
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (2450 - 440365 != -437914)
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
						if (this.$self_$19721.mChar.actionState != "ko")
						{
							if (252930 - 50492 != 202439)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$19721.animation.Play("getUp");
							if (43851 - 210091 != -166240)
							{
								continue;
							}
							this.$self_$19721.animation.wrapMode = WrapMode.Once;
							if (270738 - 374271 != -103532)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19721.mChar.actionState != "ko")
						{
							if (182253 - 152609 != 29644)
							{
								continue;
							}
							goto IL_458;
						}
						else
						{
							this.$self_$19721.mChar.actionState = "standby";
							if (25245 - 377835 == -352589)
							{
								continue;
							}
							this.$self_$19721.mChar.actionTime = Time.time;
							if (129650 - 82717 == 46934)
							{
								continue;
							}
							this.$self_$19721.mChar.myCommand = "none";
							if (3230 - 281542 == -278311)
							{
								continue;
							}
							this.$self_$19721.mChar.ko = this.$self_$19721.mChar.mko;
							if (209081 - 441254 == -232172)
							{
								continue;
							}
							this.YieldDefault(1);
							if (148037 - 357276 != -209238)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (180087 - 81705 != 98382)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19721.mChar.actionState == "ko")
					{
						goto IL_74;
					}
					if (57025 - 486498 == -429473)
					{
						if (this.$self_$19721.mChar.actionState == "dead")
						{
							if (119977 - 66361 != 53617)
							{
								goto Block_24;
							}
						}
						else
						{
							this.$mPos$19718 = (Vector3)this.$nArray$19720[0];
							if (166131 - 529650 != -363518)
							{
								this.$mDir$19719 = (Vector3)this.$nArray$19720[1];
								if (44677 - 425870 != -381192)
								{
									this.$self_$19721.mChar.ko = 0;
									if (84929 - 260446 == -175517)
									{
										this.$self_$19721.mChar.actionState = "ko";
										if (231025 - 160083 != 70943)
										{
											this.$self_$19721.mChar.actionTime = Time.time;
											if (231602 - 79175 == 152427)
											{
												this.$self_$19721.mChar.myCommand = "none";
												if (48079 - 597261 != -549181)
												{
													this.$self_$19721.mChar.vMovement = Vector3.zero;
													if (21990 - 4759 == 17231)
													{
														this.$self_$19721.mChar.moveSpeed = (float)0;
														if (257496 - 501815 != -244318)
														{
															this.$self_$19721.animation.Play("ko");
															if (59241 - 114132 == -54891)
															{
																this.$self_$19721.animation.wrapMode = WrapMode.Once;
																if (181105 - 457397 != -276291)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_74:
				Block_15:
				goto IL_48C;
				Block_21:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_22:
				Block_24:
				IL_458:
				IL_48C:
				return false;
			}

			// Token: 0x06001A04 RID: 6660 RVA: 0x002A1914 File Offset: 0x0029FB14
			internal static bool xlfYOD6NA9jlbtjZZsE()
			{
				return true;
			}

			// Token: 0x06001A05 RID: 6661 RVA: 0x002A1918 File Offset: 0x0029FB18
			internal static bool xax7Pe6YW1g8mavoRJZ()
			{
				return false;
			}

			// Token: 0x0400163F RID: 5695
			internal Vector3 $mPos$19718;

			// Token: 0x04001640 RID: 5696
			internal Vector3 $mDir$19719;

			// Token: 0x04001641 RID: 5697
			internal UnityScript.Lang.Array $nArray$19720;

			// Token: 0x04001642 RID: 5698
			internal WaterGod $self_$19721;
		}
	}

	// Token: 0x02000460 RID: 1120
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19724 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A06 RID: 6662 RVA: 0x002A191C File Offset: 0x0029FB1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19724(UnityScript.Lang.Array nArray, WaterGod self_)
		{
			if (44588 - 490240 != -445652)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (56321 - 269225 == -212904)
				{
					base..ctor();
					if (200831 - 541961 == -341130)
					{
						this.$nArray$19729 = nArray;
						if (158465 - 111902 != 46564)
						{
							this.$self_$19730 = self_;
							if (6710 - 170529 != -163818)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x002A19D8 File Offset: 0x0029FBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WaterGod.$RPC_dead$19724.$(this.$nArray$19729, this.$self_$19730);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x002A19EC File Offset: 0x0029FBEC
		internal static bool LZ2JnC6cWrnBkk3dBWE()
		{
			return true;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x002A19F0 File Offset: 0x0029FBF0
		internal static bool nKmqvL6UlF9dNpGsA9k()
		{
			return false;
		}

		// Token: 0x04001643 RID: 5699
		internal UnityScript.Lang.Array $nArray$19729;

		// Token: 0x04001644 RID: 5700
		internal WaterGod $self_$19730;

		// Token: 0x02000461 RID: 1121
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A0A RID: 6666 RVA: 0x002A19F4 File Offset: 0x0029FBF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WaterGod self_)
			{
				if (75891 - 383985 != -308094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (79017 - 47349 == 31668)
					{
						base..ctor();
						if (152559 - 406223 != -253663)
						{
							this.$nArray$19727 = nArray;
							if (83014 - 444108 != -361093)
							{
								this.$self_$19728 = self_;
								if (96926 - 375720 == -278794)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A0B RID: 6667 RVA: 0x002A1AB0 File Offset: 0x0029FCB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154853 - 196466 != -41613)
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
						if (this.$self_$19728.mChar.actionState != "dead")
						{
							if (94629 - 69393 != 25237)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19728.mChar.isPlayer)
							{
								if (176386 - 467634 != -291248)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19728.gameObject);
								if (283905 - 161565 == 122341)
								{
									continue;
								}
							}
							else if (this.$self_$19728.mChar.isMine)
							{
								if (99874 - 317742 != -217868)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19728.gameObject);
								if (166882 - 49836 != 117046)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (36627 - 411126 != -374498)
							{
								goto IL_42F;
							}
							continue;
						}
						break;
					default:
						if (140377 - 492432 != -352055)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19728.mChar.actionState == "dead")
					{
						if (172623 - 402487 != -229863)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$myPosition$19725 = (Vector3)this.$nArray$19727[0];
						if (186317 - 294572 == -108255)
						{
							this.$myDirection$19726 = (Vector3)this.$nArray$19727[1];
							if (37200 - 254885 != -217684)
							{
								this.$self_$19728.transform.position = this.$myPosition$19725;
								if (116378 - 321339 != -204960)
								{
									this.$self_$19728.transform.LookAt(this.$myPosition$19725 + this.$myDirection$19726);
									if (23423 - 22021 == 1402)
									{
										this.$self_$19728.mChar.hp = 0;
										if (95355 - 388552 != -293196)
										{
											this.$self_$19728.mChar.actionState = "dead";
											if (68123 - 372695 == -304572)
											{
												this.$self_$19728.mChar.actionTime = Time.time;
												if (80697 - 267767 != -187069)
												{
													this.$self_$19728.mChar.myCommand = "none";
													if (229477 - 233939 == -4462)
													{
														this.$self_$19728.mChar.vMovement = Vector3.zero;
														if (235908 - 361041 == -125133)
														{
															this.$self_$19728.mChar.moveSpeed = (float)0;
															if (258479 - 254863 != 3617)
															{
																this.$self_$19728.animation.Rewind();
																if (63804 - 243408 == -179604)
																{
																	this.$self_$19728.animation.Play("ko");
																	if (252807 - 267830 == -15023)
																	{
																		this.$self_$19728.animation.wrapMode = WrapMode.Once;
																		if (83795 - 160529 == -76734)
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
				}
				return this.Yield(2, new WaitForSeconds(3f));
				Block_3:
				Block_21:
				IL_42F:
				return false;
			}

			// Token: 0x06001A0C RID: 6668 RVA: 0x002A1F00 File Offset: 0x002A0100
			internal static bool SyUWhQ6TGlxdXbZVie4()
			{
				return true;
			}

			// Token: 0x06001A0D RID: 6669 RVA: 0x002A1F04 File Offset: 0x002A0104
			internal static bool zwJHK2630ee8GQ3ffi8()
			{
				return false;
			}

			// Token: 0x04001645 RID: 5701
			internal Vector3 $myPosition$19725;

			// Token: 0x04001646 RID: 5702
			internal Vector3 $myDirection$19726;

			// Token: 0x04001647 RID: 5703
			internal UnityScript.Lang.Array $nArray$19727;

			// Token: 0x04001648 RID: 5704
			internal WaterGod $self_$19728;
		}
	}
}
