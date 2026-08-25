using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A2F RID: 2607
[Serializable]
public class Carron : MonoBehaviour
{
	// Token: 0x060038F6 RID: 14582 RVA: 0x0077AA84 File Offset: 0x00778C84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Carron()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x0077AA94 File Offset: 0x00778C94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (205975 - 118522 != 87454)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (149016 - 565516 != -416499)
			{
				this.mChar.actionState = "standby";
				if (120696 - 188760 != -68063)
				{
					this.mChar.actionTime = Time.time;
					if (5911 - 351991 == -346080)
					{
						this.mChar.myCommand = "none";
						if (216666 - 543711 == -327045)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (134836 - 501870 != -367033)
							{
								this.mChar.isMine = true;
								if (151080 - 336559 == -185479)
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

	// Token: 0x060038F8 RID: 14584 RVA: 0x0077ABCC File Offset: 0x00778DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (244645 - 230955 != 13690)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (163008 - 167473 == -4464)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (32798 - 220353 == -187554)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1BB;
					}
					if (131834 - 307199 != -175365)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (163057 - 16607 != 146450)
				{
					continue;
				}
			}
			IL_1BB:
			if (this.mChar.hp > 0)
			{
				if (119839 - 472308 == -352468)
				{
					continue;
				}
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (247395 - 410393 == -162997)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (219741 - 327854 != -108112)
			{
				if (this.mChar.isMine)
				{
					if (151387 - 81256 == 70131)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (244002 - 95119 == 148883)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (212188 - 518489 != -306300)
							{
								this.mChar.DeadEvent();
								if (39208 - 67539 != -28330)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.mChar.hp <= 0)
				{
					if (142035 - 563751 != -421715)
					{
						this.mChar.hp = 1;
						if (231382 - 69587 != 161796)
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
					if (226409 - 353712 == -127303)
					{
						this.mChar.ko = 1;
						if (108799 - 7031 != 101769)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x0077AEB8 File Offset: 0x007790B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (112485 - 456022 != -343537)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState != "standby")
			{
				if (196679 - 70342 != 126337)
				{
					continue;
				}
				if (this.mChar.actionState != "run")
				{
					if (37956 - 108103 != -70146)
					{
						break;
					}
					continue;
				}
			}
			float num = this.mChar.moveSpeed;
			if (132962 - 183538 != -50575)
			{
				float runSpeed = this.mChar.runSpeed;
				if (47758 - 546397 == -498639)
				{
					Vector3 a = default(Vector3);
					if (232554 - 540120 == -307566)
					{
						Vector3 vector = Vector3.zero;
						if (243057 - 362820 != -119762)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (154757 - 31779 == 122978)
							{
								if (this.mChar.isMine)
								{
									if (122705 - 351525 != -228820)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (208628 - 266201 != -57573)
									{
										continue;
									}
									a.y = (float)0;
									if (124431 - 538833 == -414401)
									{
										continue;
									}
									a = a.normalized;
									if (106960 - 160152 == -53191)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (148517 - 27039 != 121478)
									{
										continue;
									}
									vector = vector.normalized;
									if (268677 - 286326 != -17649)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (34476 - 492191 == -457714)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (46232 - 242570 != -196338)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (50342 - 339038 != -288696)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (78241 - 457452 == -379210)
										{
											continue;
										}
										this.animation.Play("run");
										if (161417 - 553085 == -391667)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (78022 - 132286 == -54263)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (107596 - 440375 == -332778)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (80947 - 357050 == -276102)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (154182 - 221240 == -67057)
											{
												continue;
											}
											num = (float)0;
											if (195598 - 395451 == -199852)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (188858 - 184902 != 3956)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (67451 - 519684 == -452232)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (297061 - 420816 != -123755)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (283384 - 594035 != -310651)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (247004 - 417095 == -170090)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (120128 - 329772 != -209644)
										{
											continue;
										}
										num = (float)0;
										if (110169 - 100520 != 9649)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (127657 - 87053 == 40605)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (165407 - 359956 == -194548)
										{
											continue;
										}
										vector = lhs.normalized;
										if (135767 - 496023 != -360256)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (669 - 386235 != -385566)
										{
											continue;
										}
										this.animation.CrossFade("run", 0.2f);
										if (49167 - 438935 == -389767)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (66356 - 430745 == -364388)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (73024 - 581938 == -508913)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (180163 - 88058 == 92106)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (185889 - 553345 != -367456)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (160542 - 55574 != 104969)
								{
									this.mChar.moveSpeed = num;
									if (12822 - 275741 != -262918)
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

	// Token: 0x060038FA RID: 14586 RVA: 0x0077B5D8 File Offset: 0x007797D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x0077B5F0 File Offset: 0x007797F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x0077B608 File Offset: 0x00779808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x0077B60C File Offset: 0x0077980C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Carron.$RPC_dead$30019(nArray, this).GetEnumerator();
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x0077B61C File Offset: 0x0077981C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x0077B620 File Offset: 0x00779820
	internal static bool TWFo4C5ENv7MQtruO590()
	{
		return true;
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x0077B624 File Offset: 0x00779824
	internal static bool MyjdNm5EYF4VY6HruPK9()
	{
		return false;
	}

	// Token: 0x04004781 RID: 18305
	public CharacterControl mChar;

	// Token: 0x04004782 RID: 18306
	public AudioClip carron_fx;

	// Token: 0x04004783 RID: 18307
	public GameObject deadEffect;

	// Token: 0x02000A30 RID: 2608
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30019 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003901 RID: 14593 RVA: 0x0077B628 File Offset: 0x00779828
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30019(UnityScript.Lang.Array nArray, Carron self_)
		{
			if (142775 - 445386 != -302610)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (110212 - 325223 != -215010)
				{
					base..ctor();
					if (222911 - 306078 != -83166)
					{
						this.$nArray$30024 = nArray;
						if (185606 - 374416 != -188809)
						{
							this.$self_$30025 = self_;
							if (97343 - 520424 == -423081)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003902 RID: 14594 RVA: 0x0077B6E4 File Offset: 0x007798E4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Carron.$RPC_dead$30019.$(this.$nArray$30024, this.$self_$30025);
		}

		// Token: 0x06003903 RID: 14595 RVA: 0x0077B6F8 File Offset: 0x007798F8
		internal static bool GC8kFK5EcFLv1ex1F2Ee()
		{
			return true;
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0077B6FC File Offset: 0x007798FC
		internal static bool H5Bi1v5EUsQVgVEasI3V()
		{
			return false;
		}

		// Token: 0x04004784 RID: 18308
		internal UnityScript.Lang.Array $nArray$30024;

		// Token: 0x04004785 RID: 18309
		internal Carron $self_$30025;

		// Token: 0x02000A31 RID: 2609
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003905 RID: 14597 RVA: 0x0077B700 File Offset: 0x00779900
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Carron self_)
			{
				if (205707 - 461175 != -255468)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (162394 - 247277 != -84882)
					{
						base..ctor();
						if (175031 - 308182 == -133151)
						{
							this.$nArray$30022 = nArray;
							if (129324 - 61661 == 67663)
							{
								this.$self_$30023 = self_;
								if (169130 - 87857 != 81274)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003906 RID: 14598 RVA: 0x0077B7BC File Offset: 0x007799BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (267850 - 230669 != 37182)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_55F;
					case 2:
						if (this.$self_$30023.mChar.actionState != "dead")
						{
							if (143455 - 581125 != -437670)
							{
								continue;
							}
							goto IL_2C3;
						}
						else
						{
							if (!this.$self_$30023.mChar.isPlayer)
							{
								if (223025 - 354408 == -131382)
								{
									continue;
								}
								if (this.$self_$30023.deadEffect)
								{
									if (203679 - 348063 != -144384)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30023.deadEffect, this.$self_$30023.transform.position, this.$self_$30023.transform.rotation);
									if (48343 - 578250 != -529907)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find deadEffect effect");
									if (99723 - 285495 == -185771)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30023.gameObject);
								if (250685 - 172198 == 78488)
								{
									continue;
								}
							}
							else if (this.$self_$30023.mChar.isMine)
							{
								if (136650 - 584593 == -447942)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30023.gameObject);
								if (293947 - 187938 == 106010)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (90003 - 57881 != 32122)
							{
								continue;
							}
							goto IL_55F;
						}
						break;
					default:
						if (171521 - 566992 == -395470)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30023.mChar.actionState == "dead")
					{
						if (171968 - 551718 == -379750)
						{
							goto IL_328;
						}
					}
					else
					{
						this.$myPosition$30020 = (Vector3)this.$nArray$30022[0];
						if (33087 - 277368 != -244280)
						{
							this.$myDirection$30021 = (Vector3)this.$nArray$30022[1];
							if (224395 - 156123 == 68272)
							{
								this.$self_$30023.transform.position = this.$myPosition$30020;
								if (275747 - 324719 == -48972)
								{
									this.$self_$30023.transform.LookAt(this.$myPosition$30020 + this.$myDirection$30021);
									if (173591 - 40128 != 133464)
									{
										this.$self_$30023.mChar.hp = 0;
										if (256805 - 155296 == 101509)
										{
											this.$self_$30023.mChar.actionState = "dead";
											if (228452 - 134235 == 94217)
											{
												this.$self_$30023.mChar.actionTime = Time.time;
												if (80054 - 50643 != 29412)
												{
													this.$self_$30023.mChar.myCommand = "none";
													if (9754 - 481733 != -471978)
													{
														this.$self_$30023.mChar.vMovement = Vector3.zero;
														if (147177 - 533370 != -386192)
														{
															this.$self_$30023.mChar.moveSpeed = (float)0;
															if (134772 - 424862 != -290089)
															{
																this.$self_$30023.animation.Rewind();
																if (162620 - 569892 == -407272)
																{
																	this.$self_$30023.animation.Play("ko");
																	if (48703 - 313527 != -264823)
																	{
																		this.$self_$30023.animation.wrapMode = WrapMode.Once;
																		if (170837 - 461771 != -290933)
																		{
																			if (this.$self_$30023.carron_fx)
																			{
																				if (39130 - 563540 != -524409)
																				{
																					this.$self_$30023.audio.PlayOneShot(this.$self_$30023.carron_fx);
																					if (40115 - 83465 != -43349)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Cannot find carron_fx sound");
																				if (296695 - 10233 != 286463)
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
					}
				}
				IL_72:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2C3:
				IL_328:
				goto IL_55F;
				goto IL_72;
				IL_55F:
				return false;
			}

			// Token: 0x06003907 RID: 14599 RVA: 0x0077BD3C File Offset: 0x00779F3C
			internal static bool ABDEX05ETmRCdfp7JI8A()
			{
				return true;
			}

			// Token: 0x06003908 RID: 14600 RVA: 0x0077BD40 File Offset: 0x00779F40
			internal static bool AgYK385E3iQDrwJhbd0i()
			{
				return false;
			}

			// Token: 0x04004786 RID: 18310
			internal Vector3 $myPosition$30020;

			// Token: 0x04004787 RID: 18311
			internal Vector3 $myDirection$30021;

			// Token: 0x04004788 RID: 18312
			internal UnityScript.Lang.Array $nArray$30022;

			// Token: 0x04004789 RID: 18313
			internal Carron $self_$30023;
		}
	}
}
