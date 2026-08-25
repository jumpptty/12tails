using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000458 RID: 1112
[RequireComponent(typeof(CharacterControl))]
[RequireComponent(typeof(CharacterController))]
[Serializable]
public class ShadowGod : MonoBehaviour
{
	// Token: 0x060019D7 RID: 6615 RVA: 0x0029E9AC File Offset: 0x0029CBAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x0029E9BC File Offset: 0x0029CBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.mChar.actionState = "standby";
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x0029E9EC File Offset: 0x0029CBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (28713 - 517088 != -488374)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (89206 - 191206 != -102000)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (132398 - 467026 == -334627)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (141289 - 524825 != -383535)
			{
				this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
				{
					"artCancel",
					"swallow",
					"paralysis",
					"needlePrison",
					"invisible",
					"petrify",
					"snowMan",
					"snowBall",
					"sleep",
					"charm",
					"mindControl",
					"coma"
				});
				if (198653 - 209918 != -11264)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x0029EB30 File Offset: 0x0029CD30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (288034 - 201618 != 86416)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (202903 - 22731 != 180172)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (117149 - 547720 == -430570)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2E0;
					}
					if (26998 - 471527 == -444528)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (32230 - 155654 != -123424)
				{
					continue;
				}
			}
			IL_2E0:
			if (this.mChar.hp <= 0)
			{
				if (261582 - 458705 != -197123)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (166741 - 553093 != -386352)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (99813 - 340427 != -240614)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (258127 - 555631 != -297504)
						{
							continue;
						}
						if (status != null)
						{
							if (162894 - 263807 != -100913)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (117355 - 545007 == -427651)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (126492 - 101674 != 24818)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (275060 - 15955 != 259105)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (82551 - 45285 != 37267)
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
							if (208637 - 282146 == -73508)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (197717 - 204615 != -6898)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (5742 - 255106 != -249363)
							{
								break;
							}
							continue;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (9203 - 116951 != -107747)
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
			if (72217 - 547027 == -474810)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (98956 - 246717 == -147761)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (186686 - 152514 == 34172)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (9179 - 549357 != -540177)
						{
							if (this.mChar.isMine)
							{
								if (205870 - 2345 != 203526)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (156844 - 156755 == 89)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (213620 - 323945 != -110324)
										{
											this.mChar.KoEvent();
											if (122414 - 334459 == -212045)
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
								if (260397 - 60035 == 200362)
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

	// Token: 0x060019DB RID: 6619 RVA: 0x0029F030 File Offset: 0x0029D230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (281307 - 402381 != -121074)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (222772 - 101949 == 120823)
			{
				float runSpeed = this.mChar.runSpeed;
				if (76433 - 121946 == -45513)
				{
					Vector3 a = default(Vector3);
					if (238963 - 155351 == 83612)
					{
						Vector3 vector = Vector3.zero;
						if (228208 - 212532 != 15677)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (244597 - 574682 != -330084)
							{
								if (this.mChar.isMine)
								{
									if (296100 - 537447 != -241347)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (295674 - 227669 != 68005)
									{
										continue;
									}
									a.y = (float)0;
									if (32770 - 372282 != -339512)
									{
										continue;
									}
									a = a.normalized;
									if (64117 - 362754 != -298637)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (99122 - 504494 != -405372)
									{
										continue;
									}
									vector = vector.normalized;
									if (297296 - 11856 == 285441)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (66016 - 183816 != -117800)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (197592 - 142400 == 55193)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (245997 - 370447 == -124449)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (230588 - 155027 != 75561)
										{
											continue;
										}
										this.animation.Play("run");
										if (152797 - 229063 != -76266)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (75838 - 512413 == -436574)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (175474 - 256115 == -80640)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (257067 - 395664 != -138597)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (19954 - 76886 != -56932)
											{
												continue;
											}
											num = (float)0;
											if (81945 - 253744 == -171798)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (163181 - 387291 == -224109)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (185271 - 545533 != -360262)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (269139 - 419847 != -150708)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (235533 - 298514 == -62980)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (47879 - 21888 != 25991)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (284236 - 4325 != 279911)
										{
											continue;
										}
										num = (float)0;
										if (42900 - 423621 != -380721)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (121975 - 342905 == -220929)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (245565 - 55893 != 189672)
										{
											continue;
										}
										vector = lhs.normalized;
										if (206111 - 64053 != 142058)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (126587 - 485397 != -358810)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (131988 - 114049 == 17940)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (128294 - 56096 == 72199)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (157200 - 131636 == 25565)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (94629 - 562983 == -468353)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (142443 - 95385 != 47058)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (264426 - 568004 != -303577)
								{
									this.mChar.moveSpeed = num;
									if (199153 - 260907 != -61753)
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

	// Token: 0x060019DC RID: 6620 RVA: 0x0029F6E4 File Offset: 0x0029D8E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(Vector3 TargetPosition, GameObject TargetObject)
	{
		if (256222 - 424665 != -168442)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (112371 - 379299 == -266928)
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
				if (67365 - 281700 == -214335)
				{
					if (!(this.mChar.actionState == "run"))
					{
						break;
					}
					if (146763 - 387590 != -240826)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0029F7B8 File Offset: 0x0029D9B8
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1(Vector3 myPosition, Vector3 TargetPosition)
	{
		if (38038 - 279795 != -241757)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "attack";
			if (53830 - 378535 != -324704)
			{
				this.mChar.actionTime = Time.time;
				if (257679 - 332082 == -74403)
				{
					this.mChar.myCommand = "nAttack1";
					if (2991 - 486930 != -483938)
					{
						this.mChar.addTimeOut("nAttack", (float)2);
						if (101115 - 148128 == -47013)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x0029F89C File Offset: 0x0029DA9C
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ShadowGod.$RPC_ko$19703(nArray, this).GetEnumerator();
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0029F8AC File Offset: 0x0029DAAC
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ShadowGod.$RPC_dead$19710(nArray, this).GetEnumerator();
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0029F8BC File Offset: 0x0029DABC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0029F8C0 File Offset: 0x0029DAC0
	internal static bool cotinFne5VKngHMMDRG()
	{
		return true;
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x0029F8C4 File Offset: 0x0029DAC4
	internal static bool YR7D1onrU6sgYgmJcHD()
	{
		return false;
	}

	// Token: 0x0400162F RID: 5679
	public CharacterControl mChar;

	// Token: 0x02000459 RID: 1113
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19703 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019E3 RID: 6627 RVA: 0x0029F8C8 File Offset: 0x0029DAC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19703(UnityScript.Lang.Array nArray, ShadowGod self_)
		{
			if (85648 - 358242 != -272593)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (236601 - 116920 != 119682)
				{
					base..ctor();
					if (37861 - 512849 != -474987)
					{
						this.$nArray$19708 = nArray;
						if (92100 - 57669 == 34431)
						{
							this.$self_$19709 = self_;
							if (18310 - 593244 != -574933)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0029F984 File Offset: 0x0029DB84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowGod.$RPC_ko$19703.$(this.$nArray$19708, this.$self_$19709);
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0029F998 File Offset: 0x0029DB98
		internal static bool OF6mkwnj0BG4mjJmUPK()
		{
			return true;
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0029F99C File Offset: 0x0029DB9C
		internal static bool PT344mnhxf5J8sgRhDG()
		{
			return false;
		}

		// Token: 0x04001630 RID: 5680
		internal UnityScript.Lang.Array $nArray$19708;

		// Token: 0x04001631 RID: 5681
		internal ShadowGod $self_$19709;

		// Token: 0x0200045A RID: 1114
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019E7 RID: 6631 RVA: 0x0029F9A0 File Offset: 0x0029DBA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ShadowGod self_)
			{
				if (216382 - 388678 != -172295)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249552 - 168432 == 81120)
					{
						base..ctor();
						if (83436 - 36080 != 47357)
						{
							this.$nArray$19706 = nArray;
							if (12130 - 501438 == -489308)
							{
								this.$self_$19707 = self_;
								if (204256 - 249004 == -44748)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019E8 RID: 6632 RVA: 0x0029FA5C File Offset: 0x0029DC5C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (47284 - 577176 != -529892)
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
						if (this.$self_$19707.mChar.actionState != "ko")
						{
							if (34280 - 501261 != -466980)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$19707.animation.Play("getUp");
							if (129750 - 280639 != -150889)
							{
								continue;
							}
							this.$self_$19707.animation.wrapMode = WrapMode.Once;
							if (58081 - 369506 != -311424)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19707.mChar.actionState != "ko")
						{
							if (82510 - 580206 != -497695)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$19707.mChar.actionState = "standby";
							if (197781 - 401560 == -203778)
							{
								continue;
							}
							this.$self_$19707.mChar.actionTime = Time.time;
							if (8295 - 373477 == -365181)
							{
								continue;
							}
							this.$self_$19707.mChar.myCommand = "none";
							if (149691 - 507075 != -357384)
							{
								continue;
							}
							this.$self_$19707.mChar.ko = this.$self_$19707.mChar.mko;
							if (32868 - 316708 != -283840)
							{
								continue;
							}
							this.YieldDefault(1);
							if (244579 - 404659 != -160080)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (288543 - 50352 == 238192)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19707.mChar.actionState == "ko")
					{
						goto IL_3F2;
					}
					if (183487 - 377038 == -193551)
					{
						if (this.$self_$19707.mChar.actionState == "dead")
						{
							if (178091 - 339004 != -160912)
							{
								goto Block_19;
							}
						}
						else
						{
							this.$mPos$19704 = (Vector3)this.$nArray$19706[0];
							if (204673 - 591980 == -387307)
							{
								this.$mDir$19705 = (Vector3)this.$nArray$19706[1];
								if (131788 - 532355 != -400566)
								{
									this.$self_$19707.mChar.ko = 0;
									if (145195 - 389558 == -244363)
									{
										this.$self_$19707.mChar.actionState = "ko";
										if (125550 - 83586 != 41965)
										{
											this.$self_$19707.mChar.actionTime = Time.time;
											if (19239 - 253147 != -233907)
											{
												this.$self_$19707.mChar.myCommand = "none";
												if (102138 - 41186 != 60953)
												{
													this.$self_$19707.mChar.vMovement = Vector3.zero;
													if (127427 - 295360 != -167932)
													{
														this.$self_$19707.mChar.moveSpeed = (float)0;
														if (81847 - 451950 == -370103)
														{
															this.$self_$19707.animation.Play("ko");
															if (182944 - 243721 == -60777)
															{
																this.$self_$19707.animation.wrapMode = WrapMode.Once;
																if (270730 - 374275 != -103544)
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
				Block_14:
				Block_16:
				Block_19:
				goto IL_3F2;
				Block_22:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3F2:
				IL_48C:
				return false;
			}

			// Token: 0x060019E9 RID: 6633 RVA: 0x0029FF08 File Offset: 0x0029E108
			internal static bool FI1mYwns3ycDh4M7R6j()
			{
				return true;
			}

			// Token: 0x060019EA RID: 6634 RVA: 0x0029FF0C File Offset: 0x0029E10C
			internal static bool Yig86Qn9UGjK9Kyqpef()
			{
				return false;
			}

			// Token: 0x04001632 RID: 5682
			internal Vector3 $mPos$19704;

			// Token: 0x04001633 RID: 5683
			internal Vector3 $mDir$19705;

			// Token: 0x04001634 RID: 5684
			internal UnityScript.Lang.Array $nArray$19706;

			// Token: 0x04001635 RID: 5685
			internal ShadowGod $self_$19707;
		}
	}

	// Token: 0x0200045B RID: 1115
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19710 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019EB RID: 6635 RVA: 0x0029FF10 File Offset: 0x0029E110
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19710(UnityScript.Lang.Array nArray, ShadowGod self_)
		{
			if (249144 - 69832 != 179312)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286073 - 567836 != -281762)
				{
					base..ctor();
					if (265887 - 586488 == -320601)
					{
						this.$nArray$19715 = nArray;
						if (45189 - 511821 != -466631)
						{
							this.$self_$19716 = self_;
							if (87850 - 45974 == 41876)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0029FFCC File Offset: 0x0029E1CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowGod.$RPC_dead$19710.$(this.$nArray$19715, this.$self_$19716);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0029FFE0 File Offset: 0x0029E1E0
		internal static bool dcElP7n1oOo2yfu76qW()
		{
			return true;
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0029FFE4 File Offset: 0x0029E1E4
		internal static bool QxRQWOn4D5cFcq6UY5E()
		{
			return false;
		}

		// Token: 0x04001636 RID: 5686
		internal UnityScript.Lang.Array $nArray$19715;

		// Token: 0x04001637 RID: 5687
		internal ShadowGod $self_$19716;

		// Token: 0x0200045C RID: 1116
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019EF RID: 6639 RVA: 0x0029FFE8 File Offset: 0x0029E1E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ShadowGod self_)
			{
				if (146513 - 330217 != -183703)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250508 - 364036 == -113528)
					{
						base..ctor();
						if (192068 - 200287 != -8218)
						{
							this.$nArray$19713 = nArray;
							if (5021 - 352365 != -347343)
							{
								this.$self_$19714 = self_;
								if (117867 - 90623 != 27245)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019F0 RID: 6640 RVA: 0x002A00A4 File Offset: 0x0029E2A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247505 - 109826 != 137680)
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
						if (this.$self_$19714.mChar.actionState != "dead")
						{
							if (244685 - 310663 != -65978)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$19714.mChar.isPlayer)
							{
								if (181312 - 95035 == 86278)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19714.gameObject);
								if (89764 - 49429 != 40335)
								{
									continue;
								}
							}
							else if (this.$self_$19714.mChar.isMine)
							{
								if (289723 - 262582 == 27142)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19714.gameObject);
								if (112244 - 296377 != -184133)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (262481 - 453550 != -191068)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					default:
						if (190407 - 496192 == -305784)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19714.mChar.actionState == "dead")
					{
						if (60344 - 170211 != -109866)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19711 = (Vector3)this.$nArray$19713[0];
						if (147782 - 435467 != -287684)
						{
							this.$myDirection$19712 = (Vector3)this.$nArray$19713[1];
							if (103643 - 586373 != -482729)
							{
								this.$self_$19714.transform.position = this.$myPosition$19711;
								if (20700 - 451248 != -430547)
								{
									this.$self_$19714.transform.LookAt(this.$myPosition$19711 + this.$myDirection$19712);
									if (51974 - 257532 != -205557)
									{
										this.$self_$19714.mChar.hp = 0;
										if (102779 - 401737 == -298958)
										{
											this.$self_$19714.mChar.actionState = "dead";
											if (156585 - 278651 == -122066)
											{
												this.$self_$19714.mChar.actionTime = Time.time;
												if (216336 - 470509 == -254173)
												{
													this.$self_$19714.mChar.myCommand = "none";
													if (184103 - 595734 == -411631)
													{
														this.$self_$19714.mChar.vMovement = Vector3.zero;
														if (30758 - 172872 != -142113)
														{
															this.$self_$19714.mChar.moveSpeed = (float)0;
															if (12542 - 549046 == -536504)
															{
																this.$self_$19714.animation.Rewind();
																if (55455 - 438824 == -383369)
																{
																	this.$self_$19714.animation.Play("ko");
																	if (244713 - 254523 != -9809)
																	{
																		this.$self_$19714.animation.wrapMode = WrapMode.Once;
																		if (67591 - 286151 != -218559)
																		{
																			goto Block_7;
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
				IL_1A:
				goto IL_42F;
				Block_7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_21:
				IL_42F:
				return false;
			}

			// Token: 0x060019F1 RID: 6641 RVA: 0x002A04F4 File Offset: 0x0029E6F4
			internal static bool asOQRTnzpC06Q8KaqHs()
			{
				return true;
			}

			// Token: 0x060019F2 RID: 6642 RVA: 0x002A04F8 File Offset: 0x0029E6F8
			internal static bool FJB75m6aOXqHRVL9pLO()
			{
				return false;
			}

			// Token: 0x04001638 RID: 5688
			internal Vector3 $myPosition$19711;

			// Token: 0x04001639 RID: 5689
			internal Vector3 $myDirection$19712;

			// Token: 0x0400163A RID: 5690
			internal UnityScript.Lang.Array $nArray$19713;

			// Token: 0x0400163B RID: 5691
			internal ShadowGod $self_$19714;
		}
	}
}
