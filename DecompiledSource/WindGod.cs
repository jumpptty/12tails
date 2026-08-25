using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000465 RID: 1125
[Serializable]
public class WindGod : MonoBehaviour
{
	// Token: 0x06001A1F RID: 6687 RVA: 0x002A2F38 File Offset: 0x002A1138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WindGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x002A2F48 File Offset: 0x002A1148
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (296556 - 399711 != -103155)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (148884 - 591081 == -442197)
			{
				this.mChar.actionState = "standby";
				if (246070 - 485798 != -239727)
				{
					this.mChar.actionTime = Time.time;
					if (287271 - 569293 == -282022)
					{
						this.mChar.myCommand = "none";
						if (9375 - 542253 != -532877)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (133689 - 288343 != -154653)
							{
								this.mChar.isMine = true;
								if (173522 - 150871 != 22652)
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

	// Token: 0x06001A21 RID: 6689 RVA: 0x002A3080 File Offset: 0x002A1280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (299711 - 231601 != 68111)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (13550 - 570345 == -556794)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (214018 - 143588 == 70431)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_123;
					}
					if (115663 - 515878 == -400214)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (268765 - 73421 != 195344)
				{
					continue;
				}
			}
			IL_123:
			if (this.mChar.hp <= 0)
			{
				if (184348 - 441766 == -257417)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (134718 - 348176 == -213457)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (167543 - 187637 != -20094)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (285542 - 449852 != -164310)
						{
							continue;
						}
						if (status != null)
						{
							if (195838 - 63533 != 132305)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (103609 - 42373 != 61236)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (220188 - 407589 != -187401)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (177324 - 12079 == 165246)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (4224 - 66704 != -62480)
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
							if (120843 - 421140 == -300296)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (176825 - 12915 == 163911)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (108187 - 549570 != -441383)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (191302 - 266225 != -74923)
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
			if (230139 - 344875 != -114735)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (233273 - 52829 != 180445)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (200068 - 55655 == 144413)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (253061 - 415281 != -162219)
						{
							if (this.mChar.isMine)
							{
								if (216875 - 598853 != -381977)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (224955 - 334504 != -109548)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (82694 - 175636 != -92941)
										{
											this.mChar.KoEvent();
											if (62927 - 575623 != -512695)
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
								if (260367 - 293819 != -33451)
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

	// Token: 0x06001A22 RID: 6690 RVA: 0x002A3580 File Offset: 0x002A1780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (176026 - 142977 != 33050)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (152486 - 432011 != -279524)
			{
				float runSpeed = this.mChar.runSpeed;
				if (128881 - 52613 == 76268)
				{
					Vector3 a = default(Vector3);
					if (214570 - 33035 != 181536)
					{
						Vector3 vector = Vector3.zero;
						if (85338 - 120735 == -35397)
						{
							if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
							{
								break;
							}
							if (261326 - 12881 == 248445)
							{
								if (this.mChar.isMine)
								{
									if (89287 - 258298 == -169010)
									{
										continue;
									}
									a = Camera.main.transform.TransformDirection(Vector3.forward);
									if (78861 - 314420 != -235559)
									{
										continue;
									}
									a.y = (float)0;
									if (269692 - 583487 == -313794)
									{
										continue;
									}
									a = a.normalized;
									if (15175 - 565760 == -550584)
									{
										continue;
									}
									vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
									if (3823 - 352305 != -348482)
									{
										continue;
									}
									vector = vector.normalized;
									if (267212 - 599118 == -331905)
									{
										continue;
									}
									if (vector != Vector3.zero)
									{
										if (251284 - 58956 != 192328)
										{
											continue;
										}
										this.mChar.actionState = "run";
										if (140580 - 483407 == -342826)
										{
											continue;
										}
										num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
										if (9775 - 481553 != -471778)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (53555 - 357225 == -303669)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (230470 - 270585 != -40115)
										{
											continue;
										}
									}
									else
									{
										this.mChar.actionState = "standby";
										if (78911 - 491546 != -412635)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (33142 - 552256 == -519113)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (34945 - 146033 != -111088)
											{
												continue;
											}
											num = (float)0;
											if (162215 - 57504 != 104711)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (173447 - 292847 == -119399)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (53886 - 394973 == -341086)
										{
											continue;
										}
									}
								}
								else if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
								{
									if (59233 - 455235 == -396001)
									{
										continue;
									}
									Vector3 lhs = Vector3.Scale(this.mChar.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
									if (100381 - 139644 == -39262)
									{
										continue;
									}
									num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
									if (67321 - 97250 == -29928)
									{
										continue;
									}
									if (num <= 0.1f * runSpeed)
									{
										if (236248 - 236740 != -492)
										{
											continue;
										}
										num = (float)0;
										if (209027 - 420107 != -211080)
										{
											continue;
										}
										this.transform.position = this.mChar.nPosition;
										if (134746 - 127799 != 6947)
										{
											continue;
										}
									}
									if (lhs != Vector3.zero)
									{
										if (250807 - 287523 == -36715)
										{
											continue;
										}
										vector = lhs.normalized;
										if (176956 - 255104 == -78147)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(vector);
										if (78340 - 495671 == -417330)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (125648 - 541580 == -415931)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (71403 - 350353 != -278950)
										{
											continue;
										}
										this.animation.CrossFade("root", 0.2f);
										if (190860 - 553309 != -362449)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (168668 - 518651 != -349983)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (197514 - 198074 == -560)
								{
									this.mChar.moveSpeed = num;
									if (212315 - 152462 == 59853)
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

	// Token: 0x06001A23 RID: 6691 RVA: 0x002A3BDC File Offset: 0x002A1DDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(Vector3 targetPosition, GameObject targetObject)
	{
		if (272569 - 579559 != -306989)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (256813 - 333367 != -76553)
				{
					break;
				}
			}
			else
			{
				if (!(this.mChar.actionState == "standby"))
				{
					if (87299 - 447890 == -360590)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						break;
					}
					if (284410 - 183967 != 100443)
					{
						continue;
					}
				}
				if (this.mChar.isTimeOut("nAttack") != (float)0)
				{
					break;
				}
				if (127914 - 28680 != 99235)
				{
					this.networkView.RPC("RPC_cyclone", RPCMode.All, new object[]
					{
						this.transform.position,
						global::Math.vFlat(targetPosition - this.transform.position)
					});
					if (2296 - 205965 == -203669)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x002A3D44 File Offset: 0x002A1F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(Vector3 targetPosition, GameObject targetObject)
	{
		if (296068 - 245266 != 50803)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (75370 - 349328 != -273957)
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
				if (40304 - 536902 == -496598)
				{
					if (!(this.mChar.actionState == "run"))
					{
						break;
					}
					if (212733 - 418031 != -205297)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x002A3E18 File Offset: 0x002A2018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 targetPosition, GameObject targetObject)
	{
		if (!this.mChar.isMine)
		{
		}
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x002A3E30 File Offset: 0x002A2030
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cyclone(Vector3 myPosition, Vector3 targetDirection)
	{
		return new WindGod.$RPC_cyclone$19734(this).GetEnumerator();
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x002A3E40 File Offset: 0x002A2040
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new WindGod.$RPC_ko$19745(nArray, this).GetEnumerator();
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x002A3E50 File Offset: 0x002A2050
	[RPC]
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new WindGod.$RPC_dead$19752(nArray, this).GetEnumerator();
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x002A3E60 File Offset: 0x002A2060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x002A3E64 File Offset: 0x002A2064
	internal static bool XfNq1P6AyoIL0nQsojr()
	{
		return true;
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x002A3E68 File Offset: 0x002A2068
	internal static bool y0bp2C6lv4dSM36B6mU()
	{
		return false;
	}

	// Token: 0x04001657 RID: 5719
	public CharacterControl mChar;

	// Token: 0x04001658 RID: 5720
	public AudioClip nAttack_vc;

	// Token: 0x04001659 RID: 5721
	public AudioClip cAttack_vc;

	// Token: 0x0400165A RID: 5722
	public AudioClip ko_vc;

	// Token: 0x0400165B RID: 5723
	public AudioClip talk_vc;

	// Token: 0x0400165C RID: 5724
	public AudioClip chat_vc;

	// Token: 0x0400165D RID: 5725
	public AudioClip play_vc;

	// Token: 0x0400165E RID: 5726
	public GameObject cyclone;

	// Token: 0x0400165F RID: 5727
	public GameObject cyclone_hit;

	// Token: 0x02000466 RID: 1126
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cyclone$19734 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A2C RID: 6700 RVA: 0x002A3E6C File Offset: 0x002A206C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cyclone$19734(WindGod self_)
		{
			if (282961 - 474206 != -191245)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (29894 - 168734 == -138840)
				{
					base..ctor();
					if (90865 - 152197 != -61331)
					{
						this.$self_$19744 = self_;
						if (71101 - 145620 == -74519)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x002A3F04 File Offset: 0x002A2104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod.$RPC_cyclone$19734.$(this.$self_$19744);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x002A3F14 File Offset: 0x002A2114
		internal static bool jRvTVs6yDpK3U2dNJBG()
		{
			return true;
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x002A3F18 File Offset: 0x002A2118
		internal static bool O7DgNc6SqqssuFAa3Ut()
		{
			return false;
		}

		// Token: 0x04001660 RID: 5728
		internal WindGod $self_$19744;

		// Token: 0x02000467 RID: 1127
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A30 RID: 6704 RVA: 0x002A3F1C File Offset: 0x002A211C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(WindGod self_)
			{
				if (297804 - 154395 != 143409)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (27506 - 551168 == -523662)
					{
						base..ctor();
						if (172192 - 159367 == 12825)
						{
							this.$self_$19743 = self_;
							if (278903 - 2775 == 276128)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001A31 RID: 6705 RVA: 0x002A3FB4 File Offset: 0x002A21B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246439 - 167563 != 78876)
				{
				}
				for (;;)
				{
					IL_9B7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AE9;
					case 2:
						if (this.$self_$19743.mChar.actionState != "attack")
						{
							goto IL_639;
						}
						if (80506 - 481785 == -401278)
						{
							continue;
						}
						if (this.$self_$19743.mChar.myCommand != "cyclone")
						{
							if (222272 - 259928 != -37655)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$hitLayer$19737 = 130816 - (1 << this.$self_$19743.gameObject.layer);
							if (83553 - 363593 != -280040)
							{
								continue;
							}
							this.$hitList$19738 = null;
							if (159219 - 382055 != -222836)
							{
								continue;
							}
							if (!this.$self_$19743.mChar.isMine)
							{
								goto IL_6F1;
							}
							if (19057 - 282341 == -263283)
							{
								continue;
							}
							this.$hitList$19738 = Damage.FindAreaTarget(this.$self_$19743.transform.position, (float)8 * this.$self_$19743.mChar.rangeMod, (float)5 * this.$self_$19743.mChar.rangeMod, this.$hitLayer$19737);
							if (144331 - 269680 != -125349)
							{
								continue;
							}
							this.$$iterator$10548$19740 = UnityRuntimeServices.GetEnumerator(this.$hitList$19738);
							if (1557 - 126772 != -125215)
							{
								continue;
							}
							while (this.$$iterator$10548$19740.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10548$19740.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19739 = (GameObject)obj2;
								if (88479 - 548963 != -460484)
								{
									goto IL_9B7;
								}
								this.$self_$19743.mChar.hit(99, this.$hitObject$19739, 100, 0, 0, (this.$hitObject$19739.transform.position - this.$self_$19743.transform.position).normalized);
								if (162396 - 461927 == -299530)
								{
									goto IL_9B7;
								}
								UnityRuntimeServices.Update(this.$$iterator$10548$19740, this.$hitObject$19739);
								if (102426 - 293697 != -191271)
								{
									goto IL_9B7;
								}
							}
							if (208017 - 518678 != -310660)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19743.mChar.actionState != "attack")
						{
							goto IL_7E9;
						}
						if (4953 - 387611 != -382658)
						{
							continue;
						}
						if (this.$self_$19743.mChar.myCommand != "cyclone")
						{
							if (75574 - 349345 != -273770)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19743.mChar.isMine)
							{
								goto IL_676;
							}
							if (38578 - 324244 == -285665)
							{
								continue;
							}
							this.$hitList$19738 = Damage.FindAreaTarget(this.$self_$19743.transform.position, (float)12 * this.$self_$19743.mChar.rangeMod, (float)5 * this.$self_$19743.mChar.rangeMod, this.$hitLayer$19737);
							if (202035 - 491986 == -289950)
							{
								continue;
							}
							this.$$iterator$10549$19742 = UnityRuntimeServices.GetEnumerator(this.$hitList$19738);
							if (10248 - 373961 != -363713)
							{
								continue;
							}
							while (this.$$iterator$10549$19742.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10549$19742.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$19741 = (GameObject)obj4;
								if (167421 - 262936 == -95514)
								{
									goto IL_9B7;
								}
								this.$self_$19743.mChar.hit(99, this.$hitObject$19741, 100, 0, 0, (this.$hitObject$19741.transform.position - this.$self_$19743.transform.position).normalized);
								if (48819 - 169038 != -120219)
								{
									goto IL_9B7;
								}
								UnityRuntimeServices.Update(this.$$iterator$10549$19742, this.$hitObject$19741);
								if (266874 - 331575 == -64700)
								{
									goto IL_9B7;
								}
							}
							if (69089 - 11064 != 58026)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19743.mChar.actionState != "attack")
						{
							goto IL_45E;
						}
						if (140089 - 551987 == -411897)
						{
							continue;
						}
						if (this.$self_$19743.mChar.myCommand != "cyclone")
						{
							if (63437 - 57936 != 5502)
							{
								goto IL_45E;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19743.mChar.isMine)
							{
								goto IL_9F4;
							}
							if (76659 - 240878 != -164219)
							{
								continue;
							}
							this.$mCamControl$19735.StartCoroutine_Auto(this.$mCamControl$19735.AutoZoom(this.$tDistance$19736, 0.6f));
							if (69071 - 108675 != -39604)
							{
								continue;
							}
							goto IL_9F4;
						}
						break;
					case 5:
						if (this.$self_$19743.mChar.actionState == "attack")
						{
							if (184903 - 78427 == 106477)
							{
								continue;
							}
							if (this.$self_$19743.mChar.myCommand == "cyclone")
							{
								if (208298 - 249211 != -40913)
								{
									continue;
								}
								this.$self_$19743.mChar.actionState = "standby";
								if (193761 - 561597 != -367836)
								{
									continue;
								}
								this.$self_$19743.mChar.actionTime = Time.time;
								if (4190 - 60640 == -56449)
								{
									continue;
								}
								this.$self_$19743.mChar.myCommand = "none";
								if (167672 - 55897 == 111776)
								{
									continue;
								}
								if (!this.$self_$19743.mChar.isMine)
								{
									if (4651 - 98282 != -93631)
									{
										continue;
									}
									this.$self_$19743.mChar.nPosition = this.$self_$19743.transform.position;
									if (180522 - 206361 != -25839)
									{
										continue;
									}
									this.$self_$19743.mChar.oPosition = this.$self_$19743.transform.position;
									if (164800 - 169734 == -4933)
									{
										continue;
									}
									this.$self_$19743.mChar.nDirection = this.$self_$19743.transform.forward;
									if (106428 - 517580 == -411151)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (110568 - 320211 != -209643)
						{
							continue;
						}
						goto IL_AE9;
					default:
						if (205037 - 78302 == 126736)
						{
							continue;
						}
						break;
					}
					this.$self_$19743.mChar.actionState = "attack";
					if (17953 - 59215 == -41262)
					{
						this.$self_$19743.mChar.actionTime = Time.time;
						if (98726 - 500673 != -401946)
						{
							this.$self_$19743.mChar.myCommand = "cyclone";
							if (167323 - 81618 == 85705)
							{
								this.$self_$19743.mChar.addTimeOut("nAttack", (float)5);
								if (114779 - 406023 != -291243)
								{
									this.$self_$19743.mChar.vMovement = this.$self_$19743.transform.forward;
									if (144819 - 325478 != -180658)
									{
										this.$self_$19743.mChar.moveSpeed = (float)0;
										if (263092 - 133771 == 129321)
										{
											this.$self_$19743.animation.Play("cyclone");
											if (53223 - 466322 != -413098)
											{
												this.$self_$19743.animation.wrapMode = WrapMode.Once;
												if (15230 - 280083 != -264852)
												{
													UnityEngine.Object.Instantiate(this.$self_$19743.cyclone, this.$self_$19743.transform.position, Quaternion.identity);
													if (235278 - 144494 != 90785)
													{
														if (!this.$self_$19743.mChar.isMine)
														{
															break;
														}
														if (78681 - 379370 != -300688)
														{
															this.$mCamControl$19735 = (PlayerCameraControl)Camera.main.GetComponent("PlayerCameraControl");
															if (149968 - 74105 == 75863)
															{
																this.$tDistance$19736 = this.$mCamControl$19735.distance;
																if (6827 - 420789 != -413961)
																{
																	this.$mCamControl$19735.StartCoroutine_Auto(this.$mCamControl$19735.AutoZoom(this.$tDistance$19736 + (float)4, 0.6f));
																	if (131392 - 545921 != -414528)
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
				goto IL_559;
				Block_15:
				IL_45E:
				goto IL_AE9;
				IL_559:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_34:
				goto IL_6F1;
				IL_639:
				goto IL_AE9;
				IL_676:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_6F1:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_7E9:
				Block_51:
				goto IL_639;
				IL_9F4:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_64:
				goto IL_676;
				IL_AE9:
				return false;
			}

			// Token: 0x06001A32 RID: 6706 RVA: 0x002A4ABC File Offset: 0x002A2CBC
			internal static bool QZAPWP6oe6YXfpEkEbO()
			{
				return true;
			}

			// Token: 0x06001A33 RID: 6707 RVA: 0x002A4AC0 File Offset: 0x002A2CC0
			internal static bool IOEyyw6EPaJdog6DtIJ()
			{
				return false;
			}

			// Token: 0x04001661 RID: 5729
			internal PlayerCameraControl $mCamControl$19735;

			// Token: 0x04001662 RID: 5730
			internal float $tDistance$19736;

			// Token: 0x04001663 RID: 5731
			internal int $hitLayer$19737;

			// Token: 0x04001664 RID: 5732
			internal UnityScript.Lang.Array $hitList$19738;

			// Token: 0x04001665 RID: 5733
			internal GameObject $hitObject$19739;

			// Token: 0x04001666 RID: 5734
			internal IEnumerator $$iterator$10548$19740;

			// Token: 0x04001667 RID: 5735
			internal GameObject $hitObject$19741;

			// Token: 0x04001668 RID: 5736
			internal IEnumerator $$iterator$10549$19742;

			// Token: 0x04001669 RID: 5737
			internal WindGod $self_$19743;
		}
	}

	// Token: 0x02000468 RID: 1128
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19745 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A34 RID: 6708 RVA: 0x002A4AC4 File Offset: 0x002A2CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19745(UnityScript.Lang.Array nArray, WindGod self_)
		{
			if (249208 - 31428 != 217781)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237964 - 215733 != 22232)
				{
					base..ctor();
					if (148362 - 122691 != 25672)
					{
						this.$nArray$19750 = nArray;
						if (208820 - 72294 != 136527)
						{
							this.$self_$19751 = self_;
							if (295894 - 461440 == -165546)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x002A4B80 File Offset: 0x002A2D80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod.$RPC_ko$19745.$(this.$nArray$19750, this.$self_$19751);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x002A4B94 File Offset: 0x002A2D94
		internal static bool OkNveg62RWDREHeKwVk()
		{
			return true;
		}

		// Token: 0x06001A37 RID: 6711 RVA: 0x002A4B98 File Offset: 0x002A2D98
		internal static bool dwVdUa684GeE8nqXekh()
		{
			return false;
		}

		// Token: 0x0400166A RID: 5738
		internal UnityScript.Lang.Array $nArray$19750;

		// Token: 0x0400166B RID: 5739
		internal WindGod $self_$19751;

		// Token: 0x02000469 RID: 1129
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A38 RID: 6712 RVA: 0x002A4B9C File Offset: 0x002A2D9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WindGod self_)
			{
				if (117492 - 67516 != 49976)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112701 - 40668 != 72034)
					{
						base..ctor();
						if (292597 - 466799 != -174201)
						{
							this.$nArray$19748 = nArray;
							if (176042 - 60769 != 115274)
							{
								this.$self_$19749 = self_;
								if (269529 - 438664 == -169135)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A39 RID: 6713 RVA: 0x002A4C58 File Offset: 0x002A2E58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (278990 - 239370 != 39621)
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
						if (this.$self_$19749.mChar.actionState != "ko")
						{
							if (51340 - 180710 != -129369)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$19749.animation.Play("getUp");
							if (231266 - 344343 != -113077)
							{
								continue;
							}
							this.$self_$19749.animation.wrapMode = WrapMode.Once;
							if (179814 - 347994 != -168179)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19749.mChar.actionState != "ko")
						{
							if (190437 - 417877 != -227439)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							this.$self_$19749.mChar.actionState = "standby";
							if (159954 - 87303 != 72651)
							{
								continue;
							}
							this.$self_$19749.mChar.actionTime = Time.time;
							if (134011 - 36147 != 97864)
							{
								continue;
							}
							this.$self_$19749.mChar.myCommand = "none";
							if (4414 - 400048 != -395634)
							{
								continue;
							}
							this.$self_$19749.mChar.ko = this.$self_$19749.mChar.mko;
							if (213645 - 353697 != -140052)
							{
								continue;
							}
							this.YieldDefault(1);
							if (247560 - 56645 != 190916)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (171384 - 559084 == -387699)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19749.mChar.actionState == "ko")
					{
						goto IL_205;
					}
					if (207273 - 509412 == -302139)
					{
						if (this.$self_$19749.mChar.actionState == "dead")
						{
							if (147365 - 115427 != 31939)
							{
								goto Block_6;
							}
						}
						else
						{
							this.$mPos$19746 = (Vector3)this.$nArray$19748[0];
							if (151940 - 598183 != -446242)
							{
								this.$mDir$19747 = (Vector3)this.$nArray$19748[1];
								if (20217 - 412316 != -392098)
								{
									this.$self_$19749.mChar.ko = 0;
									if (202526 - 433027 == -230501)
									{
										this.$self_$19749.mChar.actionState = "ko";
										if (114572 - 209488 != -94915)
										{
											this.$self_$19749.mChar.actionTime = Time.time;
											if (104547 - 66775 == 37772)
											{
												this.$self_$19749.mChar.myCommand = "none";
												if (216999 - 202478 != 14522)
												{
													this.$self_$19749.mChar.vMovement = Vector3.zero;
													if (192351 - 298302 == -105951)
													{
														this.$self_$19749.mChar.moveSpeed = (float)0;
														if (40914 - 356674 != -315759)
														{
															this.$self_$19749.animation.Play("ko");
															if (103724 - 126533 == -22809)
															{
																this.$self_$19749.animation.wrapMode = WrapMode.Once;
																if (268287 - 386754 == -118467)
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
				Block_3:
				Block_6:
				goto IL_205;
				Block_11:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_205:
				Block_18:
				Block_22:
				IL_48C:
				return false;
			}

			// Token: 0x06001A3A RID: 6714 RVA: 0x002A5104 File Offset: 0x002A3304
			internal static bool k3NLHd6ZEvSRt9gUWcY()
			{
				return true;
			}

			// Token: 0x06001A3B RID: 6715 RVA: 0x002A5108 File Offset: 0x002A3308
			internal static bool ce2xuZ6CO4ufRYlPULb()
			{
				return false;
			}

			// Token: 0x0400166C RID: 5740
			internal Vector3 $mPos$19746;

			// Token: 0x0400166D RID: 5741
			internal Vector3 $mDir$19747;

			// Token: 0x0400166E RID: 5742
			internal UnityScript.Lang.Array $nArray$19748;

			// Token: 0x0400166F RID: 5743
			internal WindGod $self_$19749;
		}
	}

	// Token: 0x0200046A RID: 1130
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19752 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001A3C RID: 6716 RVA: 0x002A510C File Offset: 0x002A330C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19752(UnityScript.Lang.Array nArray, WindGod self_)
		{
			if (175192 - 399810 != -224617)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136820 - 61430 == 75390)
				{
					base..ctor();
					if (53397 - 224448 != -171050)
					{
						this.$nArray$19757 = nArray;
						if (175908 - 141709 == 34199)
						{
							this.$self_$19758 = self_;
							if (275652 - 382749 != -107096)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x002A51C8 File Offset: 0x002A33C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WindGod.$RPC_dead$19752.$(this.$nArray$19757, this.$self_$19758);
		}

		// Token: 0x06001A3E RID: 6718 RVA: 0x002A51DC File Offset: 0x002A33DC
		internal static bool axfcJQ6Ljykde0Lvb9F()
		{
			return true;
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x002A51E0 File Offset: 0x002A33E0
		internal static bool q8Pspq6OgQZigjbWTib()
		{
			return false;
		}

		// Token: 0x04001670 RID: 5744
		internal UnityScript.Lang.Array $nArray$19757;

		// Token: 0x04001671 RID: 5745
		internal WindGod $self_$19758;

		// Token: 0x0200046B RID: 1131
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001A40 RID: 6720 RVA: 0x002A51E4 File Offset: 0x002A33E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, WindGod self_)
			{
				if (216068 - 534087 != -318019)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225653 - 298082 == -72429)
					{
						base..ctor();
						if (4 - 423832 == -423828)
						{
							this.$nArray$19755 = nArray;
							if (274202 - 559633 == -285431)
							{
								this.$self_$19756 = self_;
								if (236739 - 454141 == -217402)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001A41 RID: 6721 RVA: 0x002A52A0 File Offset: 0x002A34A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265868 - 6080 != 259788)
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
						if (this.$self_$19756.mChar.actionState != "dead")
						{
							if (253655 - 224692 != 28964)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19756.mChar.isPlayer)
							{
								if (235711 - 333249 != -97538)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19756.gameObject);
								if (279025 - 132679 == 146347)
								{
									continue;
								}
							}
							else if (this.$self_$19756.mChar.isMine)
							{
								if (31240 - 88163 != -56923)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19756.gameObject);
								if (280762 - 412619 != -131857)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (67935 - 286092 != -218156)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (187290 - 307819 != -120529)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19756.mChar.actionState == "dead")
					{
						if (191336 - 412324 != -220987)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19753 = (Vector3)this.$nArray$19755[0];
						if (84301 - 498595 == -414294)
						{
							this.$myDirection$19754 = (Vector3)this.$nArray$19755[1];
							if (246524 - 551136 != -304611)
							{
								this.$self_$19756.transform.position = this.$myPosition$19753;
								if (130478 - 178800 == -48322)
								{
									this.$self_$19756.transform.LookAt(this.$myPosition$19753 + this.$myDirection$19754);
									if (132750 - 383888 == -251138)
									{
										this.$self_$19756.mChar.hp = 0;
										if (72992 - 270114 == -197122)
										{
											this.$self_$19756.mChar.actionState = "dead";
											if (33711 - 244972 == -211261)
											{
												this.$self_$19756.mChar.actionTime = Time.time;
												if (243263 - 565739 == -322476)
												{
													this.$self_$19756.mChar.myCommand = "none";
													if (212995 - 498489 == -285494)
													{
														this.$self_$19756.mChar.vMovement = Vector3.zero;
														if (250046 - 254135 != -4088)
														{
															this.$self_$19756.mChar.moveSpeed = (float)0;
															if (222843 - 355738 != -132894)
															{
																this.$self_$19756.animation.Rewind();
																if (14224 - 572721 == -558497)
																{
																	this.$self_$19756.animation.Play("ko");
																	if (50232 - 141446 != -91213)
																	{
																		this.$self_$19756.animation.wrapMode = WrapMode.Once;
																		if (122891 - 397670 != -274778)
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
				Block_6:
				Block_11:
				goto IL_42F;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06001A42 RID: 6722 RVA: 0x002A56F0 File Offset: 0x002A38F0
			internal static bool u0NNa26mnCNvH3LX4G3()
			{
				return true;
			}

			// Token: 0x06001A43 RID: 6723 RVA: 0x002A56F4 File Offset: 0x002A38F4
			internal static bool mpK8H96FIOQA4j6NIKb()
			{
				return false;
			}

			// Token: 0x04001672 RID: 5746
			internal Vector3 $myPosition$19753;

			// Token: 0x04001673 RID: 5747
			internal Vector3 $myDirection$19754;

			// Token: 0x04001674 RID: 5748
			internal UnityScript.Lang.Array $nArray$19755;

			// Token: 0x04001675 RID: 5749
			internal WindGod $self_$19756;
		}
	}
}
