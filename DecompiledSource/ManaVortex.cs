using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200035D RID: 861
[Serializable]
public class ManaVortex : MonoBehaviour
{
	// Token: 0x0600139F RID: 5023 RVA: 0x001EDAA4 File Offset: 0x001EBCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ManaVortex()
	{
		if (295133 - 287837 != 7296)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (117980 - 208325 == -90345)
			{
				base..ctor();
				if (223640 - 416676 != -193035)
				{
					this.vT2t70UQQi = 1;
					if (488 - 17857 == -17369)
					{
						this.vrMtZawG3C = 30f;
						if (91573 - 65416 == 26157)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x001EDB64 File Offset: 0x001EBD64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (20743 - 517239 != -496495)
		{
		}
		for (;;)
		{
			this.PuktHh5RkG = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (243021 - 155252 != 87770)
			{
				this.PuktHh5RkG.actionState = "standby";
				if (138876 - 446148 != -307271)
				{
					this.PuktHh5RkG.actionTime = Time.time;
					if (9760 - 264424 != -254663)
					{
						this.PuktHh5RkG.myCommand = "none";
						if (180669 - 117457 != 63213)
						{
							this.PuktHh5RkG.hp = (this.PuktHh5RkG.mhp = 200);
							if (175286 - 187708 == -12422)
							{
								this.PuktHh5RkG.ko = (this.PuktHh5RkG.mko = 10);
								if (59155 - 133569 == -74414)
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

	// Token: 0x060013A1 RID: 5025 RVA: 0x001EDCBC File Offset: 0x001EBEBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (228309 - 588694 != -360384)
		{
		}
		for (;;)
		{
			IL_FB:
			GameObject[] array = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Enemy"), GameObject.FindGameObjectsWithTag("Player"));
			if (23872 - 153936 == -130064)
			{
				int i = 0;
				if (204592 - 179683 == 24909)
				{
					GameObject[] array2 = array;
					if (187897 - 375162 != -187264)
					{
						int length = array2.Length;
						if (42784 - 118085 == -75301)
						{
							while (i < length)
							{
								if (array2[i] != this.gameObject)
								{
									if (122009 - 222965 == -100955)
									{
										goto IL_FB;
									}
									if (array2[i].collider)
									{
										if (236050 - 174111 == 61940)
										{
											goto IL_FB;
										}
										Physics.IgnoreCollision(array2[i].collider, this.gameObject.collider, true);
										if (192050 - 12514 == 179537)
										{
											goto IL_FB;
										}
									}
								}
								i++;
								if (277955 - 220676 == 57280)
								{
									goto IL_FB;
								}
							}
							if (286360 - 364544 == -78184)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x001EDE64 File Offset: 0x001EC064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (30582 - 268951 != -238369)
		{
		}
		for (;;)
		{
			IL_7A6:
			if (this.PuktHh5RkG.isControlled)
			{
				if (231084 - 58207 != 172877)
				{
					continue;
				}
				if (!(this.PuktHh5RkG.actionState == "standby"))
				{
					if (199108 - 535602 == -336493)
					{
						continue;
					}
					if (!(this.PuktHh5RkG.actionState == "run"))
					{
						goto IL_1A;
					}
					if (192044 - 122545 == 69500)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (53659 - 325157 != -271498)
				{
					continue;
				}
			}
			IL_1A:
			if (this.PuktHh5RkG.hp <= 0)
			{
				goto IL_39A;
			}
			if (243921 - 407636 != -163715)
			{
				continue;
			}
			if (!(this.PuktHh5RkG.actionState == "standby"))
			{
				goto IL_39A;
			}
			if (290923 - 7039 != 283884)
			{
				continue;
			}
			if (Time.time > this.jD9tCn0TdJ)
			{
				if (226996 - 118336 != 108660)
				{
					continue;
				}
				this.jD9tCn0TdJ = Time.time + (float)2;
				if (16176 - 254142 == -237965)
				{
					continue;
				}
				if (this.PuktHh5RkG.isMine)
				{
					if (53259 - 182867 != -129608)
					{
						continue;
					}
					int num = 130816 - (1 << this.gameObject.layer);
					if (10958 - 417264 == -406305)
					{
						continue;
					}
					if (this.gameObject.layer != 12)
					{
						if (222141 - 289974 != -67833)
						{
							continue;
						}
						num -= 4096;
						if (79680 - 308541 != -228861)
						{
							continue;
						}
					}
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)(12 + 4 * this.vT2t70UQQi), (float)6, num);
					if (265799 - 201083 == 64717)
					{
						continue;
					}
					IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
					if (280151 - 319756 != -39605)
					{
						continue;
					}
					while (enumerator.MoveNext())
					{
						object obj2 = enumerator.Current;
						object obj4;
						object obj3 = obj4 = obj2;
						if (!(obj3 is GameObject))
						{
							obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj4;
						if (221775 - 493543 != -271768)
						{
							goto IL_7A6;
						}
						if (this.PuktHh5RkG.hit(1, gameObject, this.vT2t70UQQi * 12 + 12, 0, 0, Vector3.zero) != 0)
						{
							if (73341 - 297150 == -223808)
							{
								goto IL_7A6;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (295060 - 252198 == 42863)
							{
								goto IL_7A6;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (129945 - 492872 == -362926)
							{
								goto IL_7A6;
							}
							if (characterControl)
							{
								if (72870 - 167454 == -94583)
								{
									goto IL_7A6;
								}
								if (characterControl.mp > this.vT2t70UQQi * 4)
								{
									if (281636 - 433121 != -151485)
									{
										goto IL_7A6;
									}
									characterControl.RPC_AddStatus("mpSap", this.vT2t70UQQi, 1, this.vT2t70UQQi * 4, this.PuktHh5RkG.ActorNr);
									if (200264 - 583822 == -383557)
									{
										goto IL_7A6;
									}
									this.PuktHh5RkG.mp = Mathf.Min(this.PuktHh5RkG.mmp, this.PuktHh5RkG.mp + this.vT2t70UQQi * 4);
									if (86668 - 465892 == -379223)
									{
										goto IL_7A6;
									}
								}
							}
						}
					}
					if (68185 - 500777 != -432592)
					{
						continue;
					}
				}
			}
			IL_6BD:
			if (!this.isSummon)
			{
				break;
			}
			if (223777 - 306070 != -82293)
			{
				continue;
			}
			if (!(this.PuktHh5RkG.actionState != "dead"))
			{
				break;
			}
			if (229992 - 518211 != -288219)
			{
				continue;
			}
			this.vrMtZawG3C -= Time.deltaTime;
			if (104728 - 322060 != -217332)
			{
				continue;
			}
			if (this.mCreator)
			{
				if (256003 - 264224 != -8221)
				{
					continue;
				}
				if (!this.mCreatorChar)
				{
					if (23258 - 262105 != -238847)
					{
						continue;
					}
				}
				else
				{
					if (!this.PuktHh5RkG.isMine)
					{
						break;
					}
					if (254748 - 493838 == -239089)
					{
						continue;
					}
					if (this.vrMtZawG3C > (float)0)
					{
						if (44501 - 547332 == -502830)
						{
							continue;
						}
						if (this.mCreatorChar.hp > 0)
						{
							break;
						}
						if (139221 - 359476 != -220255)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
					{
						this.transform.position,
						this.transform.forward
					})));
					if (126833 - 265006 == -138172)
					{
						continue;
					}
					if (!PhotonClient.IsInitialized())
					{
						break;
					}
					if (255562 - 259330 != -3768)
					{
						continue;
					}
					this.PuktHh5RkG.DeadEvent();
					if (77792 - 140215 != -62423)
					{
						continue;
					}
					break;
				}
			}
			UnityEngine.Object.Destroy(this.gameObject);
			if (6307 - 491334 != -485027)
			{
				continue;
			}
			break;
			IL_39A:
			if (this.PuktHh5RkG.hp > 0)
			{
				goto IL_6BD;
			}
			if (124248 - 102918 != 21331)
			{
				if (!(this.PuktHh5RkG.actionState != "dead"))
				{
					goto IL_6BD;
				}
				if (59427 - 255946 == -196519)
				{
					if (this.PuktHh5RkG.isMine)
					{
						if (137218 - 580797 != -443578)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (157960 - 181963 != -24002)
							{
								if (PhotonClient.IsInitialized())
								{
									if (111360 - 336799 != -225439)
									{
										continue;
									}
									this.PuktHh5RkG.DeadEvent();
									if (236318 - 412107 != -175789)
									{
										continue;
									}
								}
								goto IL_6BD;
							}
						}
					}
					else
					{
						this.PuktHh5RkG.hp = 1;
						if (63580 - 437031 == -373451)
						{
							goto IL_6BD;
						}
					}
				}
			}
		}
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x001EE654 File Offset: 0x001EC854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x060013A4 RID: 5028 RVA: 0x001EE658 File Offset: 0x001EC858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x001EE670 File Offset: 0x001EC870
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x001EE688 File Offset: 0x001EC888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060013A7 RID: 5031 RVA: 0x001EE68C File Offset: 0x001EC88C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_novaFlare()
	{
		return new ManaVortex.$RPC_novaFlare$18623(this).GetEnumerator();
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x001EE69C File Offset: 0x001EC89C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator create(int nLv, int nLife, int nCreatorID)
	{
		return new ManaVortex.$create$18631(nLv, nLife, nCreatorID, this).GetEnumerator();
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x001EE6AC File Offset: 0x001EC8AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void uncreate()
	{
		if (!(this.PuktHh5RkG.actionState == "dead"))
		{
			this.PuktHh5RkG.hp = 0;
		}
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x001EE6DC File Offset: 0x001EC8DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		this.PuktHh5RkG.ko = this.PuktHh5RkG.mko;
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x001EE6F4 File Offset: 0x001EC8F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ManaVortex.$RPC_dead$18640(nArray, this).GetEnumerator();
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x001EE704 File Offset: 0x001EC904
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x001EE708 File Offset: 0x001EC908
	internal static bool IKmy7CLPAexcQysuSCb()
	{
		return true;
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x001EE70C File Offset: 0x001EC90C
	internal static bool EYEOAJL0e4Hp9C0o1At()
	{
		return false;
	}

	// Token: 0x04001102 RID: 4354
	private CharacterControl PuktHh5RkG;

	// Token: 0x04001103 RID: 4355
	private int vT2t70UQQi;

	// Token: 0x04001104 RID: 4356
	private float vrMtZawG3C;

	// Token: 0x04001105 RID: 4357
	private float jD9tCn0TdJ;

	// Token: 0x04001106 RID: 4358
	public GameObject novaFlare;

	// Token: 0x04001107 RID: 4359
	public GameObject mCreator;

	// Token: 0x04001108 RID: 4360
	public CharacterControl mCreatorChar;

	// Token: 0x04001109 RID: 4361
	public bool isSummon;

	// Token: 0x0200035E RID: 862
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_novaFlare$18623 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013AF RID: 5039 RVA: 0x001EE710 File Offset: 0x001EC910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_novaFlare$18623(ManaVortex self_)
		{
			if (174597 - 347797 != -173199)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (227715 - 440105 == -212390)
				{
					base..ctor();
					if (157835 - 479842 != -322006)
					{
						this.$self_$18630 = self_;
						if (265963 - 65361 != 200603)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x001EE7A8 File Offset: 0x001EC9A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ManaVortex.$RPC_novaFlare$18623.$(this.$self_$18630);
		}

		// Token: 0x060013B1 RID: 5041 RVA: 0x001EE7B8 File Offset: 0x001EC9B8
		internal static bool r1W0WGLbQtnhcpDcJWD()
		{
			return true;
		}

		// Token: 0x060013B2 RID: 5042 RVA: 0x001EE7BC File Offset: 0x001EC9BC
		internal static bool Yh6iucLuP3OOTZbdV5L()
		{
			return false;
		}

		// Token: 0x0400110A RID: 4362
		internal ManaVortex $self_$18630;

		// Token: 0x0200035F RID: 863
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013B3 RID: 5043 RVA: 0x001EE7C0 File Offset: 0x001EC9C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(ManaVortex self_)
			{
				if (254355 - 577449 != -323094)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111709 - 526191 != -414481)
					{
						base..ctor();
						if (284116 - 127233 != 156884)
						{
							this.$self_$18629 = self_;
							if (299718 - 371588 == -71870)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x060013B4 RID: 5044 RVA: 0x001EE858 File Offset: 0x001ECA58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141097 - 40661 != 100436)
				{
				}
				for (;;)
				{
					IL_37C:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_586;
					case 2:
						if (this.$self_$18629.PuktHh5RkG.isMine)
						{
							if (277173 - 110590 == 166584)
							{
								continue;
							}
							this.$hitLayer$18625 = 130816 - (1 << this.$self_$18629.gameObject.layer);
							if (280070 - 95938 == 184133)
							{
								continue;
							}
							if (this.$self_$18629.gameObject.layer != 12)
							{
								if (140975 - 236306 == -95330)
								{
									continue;
								}
								this.$hitLayer$18625 -= 4096;
								if (56797 - 103158 == -46360)
								{
									continue;
								}
							}
							this.$hitList$18626 = Damage.FindAreaTarget(this.$self_$18629.transform.position, (float)(12 + 4 * this.$self_$18629.vT2t70UQQi), (float)6, this.$hitLayer$18625);
							if (39185 - 404869 != -365684)
							{
								continue;
							}
							this.$$iterator$9519$18628 = UnityRuntimeServices.GetEnumerator(this.$hitList$18626);
							if (193775 - 10190 != 183585)
							{
								continue;
							}
							while (this.$$iterator$9519$18628.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9519$18628.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18627 = (GameObject)obj2;
								if (221413 - 486766 == -265352)
								{
									goto IL_37C;
								}
								this.$self_$18629.PuktHh5RkG.hit(10, this.$hitObject$18627, this.$mNovaDmg$18624, 0, 0, Vector3.zero);
								if (41981 - 64644 == -22662)
								{
									goto IL_37C;
								}
								UnityRuntimeServices.Update(this.$$iterator$9519$18628, this.$hitObject$18627);
								if (196748 - 67475 != 129273)
								{
									goto IL_37C;
								}
							}
							if (121850 - 533397 != -411547)
							{
								continue;
							}
						}
						UnityEngine.Object.Destroy(this.$self_$18629.gameObject);
						if (198599 - 61895 != 136704)
						{
							continue;
						}
						this.YieldDefault(1);
						if (112704 - 29809 != 82896)
						{
							goto Block_24;
						}
						continue;
					default:
						if (143749 - 133550 != 10199)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18629.PuktHh5RkG.actionState == "dead")
					{
						if (219426 - 350913 == -131487)
						{
							goto IL_1BB;
						}
					}
					else
					{
						this.$mNovaDmg$18624 = (int)(0.5f * (float)this.$self_$18629.PuktHh5RkG.hp + (float)this.$self_$18629.PuktHh5RkG.mp);
						if (176396 - 522750 != -346353)
						{
							this.$self_$18629.PuktHh5RkG.hp = 0;
							if (128863 - 472176 == -343313)
							{
								this.$self_$18629.PuktHh5RkG.actionState = "dead";
								if (178070 - 187202 != -9131)
								{
									this.$self_$18629.PuktHh5RkG.actionTime = Time.time;
									if (288238 - 454815 != -166576)
									{
										this.$self_$18629.PuktHh5RkG.myCommand = "none";
										if (224915 - 599868 != -374952)
										{
											this.$self_$18629.PuktHh5RkG.vMovement = Vector3.zero;
											if (199741 - 285717 != -85975)
											{
												this.$self_$18629.PuktHh5RkG.moveSpeed = (float)0;
												if (241964 - 574162 != -332197)
												{
													this.$self_$18629.animation.Rewind();
													if (59658 - 117963 == -58305)
													{
														this.$self_$18629.animation.Play("destroy");
														if (171038 - 539152 != -368113)
														{
															this.$self_$18629.animation.wrapMode = WrapMode.Once;
															if (140113 - 283178 != -143064)
															{
																if (this.$self_$18629.novaFlare)
																{
																	if (10387 - 597888 == -587501)
																	{
																		UnityEngine.Object.Instantiate(this.$self_$18629.novaFlare, this.$self_$18629.transform.position, Quaternion.identity);
																		if (127358 - 329306 != -201947)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find novaFlare Effect");
																	if (282743 - 567633 == -284890)
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
				goto IL_28E;
				IL_1BB:
				goto IL_586;
				IL_28E:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_24:
				IL_586:
				return false;
			}

			// Token: 0x060013B5 RID: 5045 RVA: 0x001EEE00 File Offset: 0x001ED000
			internal static bool KcdLY9LI4macsJ4Ygbv()
			{
				return true;
			}

			// Token: 0x060013B6 RID: 5046 RVA: 0x001EEE04 File Offset: 0x001ED004
			internal static bool z1eF9MLBk3WivyXmuZ8()
			{
				return false;
			}

			// Token: 0x0400110B RID: 4363
			internal int $mNovaDmg$18624;

			// Token: 0x0400110C RID: 4364
			internal int $hitLayer$18625;

			// Token: 0x0400110D RID: 4365
			internal UnityScript.Lang.Array $hitList$18626;

			// Token: 0x0400110E RID: 4366
			internal GameObject $hitObject$18627;

			// Token: 0x0400110F RID: 4367
			internal IEnumerator $$iterator$9519$18628;

			// Token: 0x04001110 RID: 4368
			internal ManaVortex $self_$18629;
		}
	}

	// Token: 0x02000360 RID: 864
	[CompilerGenerated]
	[Serializable]
	internal sealed class $create$18631 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013B7 RID: 5047 RVA: 0x001EEE08 File Offset: 0x001ED008
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $create$18631(int nLv, int nLife, int nCreatorID, ManaVortex self_)
		{
			if (240625 - 67442 != 173183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170534 - 579489 == -408955)
				{
					base..ctor();
					if (200607 - 55895 == 144712)
					{
						this.$nLv$18636 = nLv;
						if (293174 - 101073 != 192102)
						{
							this.$nLife$18637 = nLife;
							if (6902 - 359601 == -352699)
							{
								this.$nCreatorID$18638 = nCreatorID;
								if (207920 - 401060 != -193139)
								{
									this.$self_$18639 = self_;
									if (229360 - 51274 != 178087)
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

		// Token: 0x060013B8 RID: 5048 RVA: 0x001EEF08 File Offset: 0x001ED108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ManaVortex.$create$18631.$(this.$nLv$18636, this.$nLife$18637, this.$nCreatorID$18638, this.$self_$18639);
		}

		// Token: 0x060013B9 RID: 5049 RVA: 0x001EEF28 File Offset: 0x001ED128
		internal static bool uID934LeibeWXSSVDAi()
		{
			return true;
		}

		// Token: 0x060013BA RID: 5050 RVA: 0x001EEF2C File Offset: 0x001ED12C
		internal static bool lNaQj8Lr8e0L0HFwWHR()
		{
			return false;
		}

		// Token: 0x04001111 RID: 4369
		internal int $nLv$18636;

		// Token: 0x04001112 RID: 4370
		internal int $nLife$18637;

		// Token: 0x04001113 RID: 4371
		internal int $nCreatorID$18638;

		// Token: 0x04001114 RID: 4372
		internal ManaVortex $self_$18639;

		// Token: 0x02000361 RID: 865
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013BB RID: 5051 RVA: 0x001EEF30 File Offset: 0x001ED130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nLv, int nLife, int nCreatorID, ManaVortex self_)
			{
				if (273470 - 532489 != -259018)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (18312 - 5143 != 13170)
					{
						base..ctor();
						if (116671 - 260693 != -144021)
						{
							this.$nLv$18632 = nLv;
							if (70987 - 86333 == -15346)
							{
								this.$nLife$18633 = nLife;
								if (282343 - 204648 == 77695)
								{
									this.$nCreatorID$18634 = nCreatorID;
									if (265540 - 237391 == 28149)
									{
										this.$self_$18635 = self_;
										if (244416 - 569118 == -324702)
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

			// Token: 0x060013BC RID: 5052 RVA: 0x001EF030 File Offset: 0x001ED230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10763 - 330315 != -319552)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_422;
					case 2:
						this.$self_$18635.animation.Play("root");
						if (268329 - 177898 != 90431)
						{
							continue;
						}
						this.$self_$18635.animation.wrapMode = WrapMode.Loop;
						if (232151 - 546088 == -313936)
						{
							continue;
						}
						this.YieldDefault(1);
						if (31044 - 35214 != -4170)
						{
							continue;
						}
						goto IL_422;
					default:
						if (20664 - 234166 != -213502)
						{
							continue;
						}
						break;
					}
					this.$self_$18635.PuktHh5RkG.hp = 200 * this.$nLv$18632;
					if (161210 - 324618 == -163408)
					{
						this.$self_$18635.PuktHh5RkG.mhp = 200 * this.$nLv$18632;
						if (9049 - 20488 == -11439)
						{
							this.$self_$18635.PuktHh5RkG.mp = 0;
							if (260208 - 72045 == 188163)
							{
								this.$self_$18635.PuktHh5RkG.mmp = 100 * this.$nLv$18632;
								if (40584 - 391316 == -350732)
								{
									this.$self_$18635.vT2t70UQQi = this.$nLv$18632;
									if (226085 - 556414 != -330328)
									{
										this.$self_$18635.vrMtZawG3C = (float)this.$nLife$18633;
										if (231280 - 256128 == -24848)
										{
											this.$self_$18635.isSummon = true;
											if (112399 - 161875 == -49476)
											{
												ManaVortex manaVortex = this.$self_$18635;
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[this.$nCreatorID$18634];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												manaVortex.mCreator = (GameObject)obj2;
												if (115016 - 254194 != -139177)
												{
													this.$self_$18635.mCreatorChar = (CharacterControl)this.$self_$18635.mCreator.GetComponent(typeof(CharacterControl));
													if (290114 - 437343 == -147229)
													{
														if (this.$self_$18635.mCreatorChar.isMine)
														{
															if (118978 - 38641 == 80338)
															{
																continue;
															}
															this.$self_$18635.PuktHh5RkG.isMine = true;
															if (10432 - 197116 == -186683)
															{
																continue;
															}
														}
														this.$self_$18635.gameObject.layer = this.$self_$18635.mCreator.layer;
														if (140786 - 171821 == -31035)
														{
															this.$self_$18635.transform.localScale = (0.4f + 0.2f * (float)this.$nLv$18632) * Vector3.one;
															if (246429 - 418518 == -172089)
															{
																this.$self_$18635.animation.Rewind();
																if (7010 - 369731 == -362721)
																{
																	this.$self_$18635.animation.Play("create");
																	if (164751 - 201248 == -36497)
																	{
																		this.$self_$18635.animation.wrapMode = WrapMode.Once;
																		if (107951 - 235869 == -127918)
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
				return this.Yield(2, new WaitForSeconds(1f));
				IL_422:
				return false;
			}

			// Token: 0x060013BD RID: 5053 RVA: 0x001EF474 File Offset: 0x001ED674
			internal static bool H8QlyOLjtCuEQ1KmKqm()
			{
				return true;
			}

			// Token: 0x060013BE RID: 5054 RVA: 0x001EF478 File Offset: 0x001ED678
			internal static bool uJUl8DLhADI2V31Z7L7()
			{
				return false;
			}

			// Token: 0x04001115 RID: 4373
			internal int $nLv$18632;

			// Token: 0x04001116 RID: 4374
			internal int $nLife$18633;

			// Token: 0x04001117 RID: 4375
			internal int $nCreatorID$18634;

			// Token: 0x04001118 RID: 4376
			internal ManaVortex $self_$18635;
		}
	}

	// Token: 0x02000362 RID: 866
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18640 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060013BF RID: 5055 RVA: 0x001EF47C File Offset: 0x001ED67C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18640(UnityScript.Lang.Array nArray, ManaVortex self_)
		{
			if (7626 - 200290 != -192663)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (181184 - 345680 != -164495)
				{
					base..ctor();
					if (152778 - 586217 != -433438)
					{
						this.$nArray$18646 = nArray;
						if (128998 - 48259 == 80739)
						{
							this.$self_$18647 = self_;
							if (237790 - 9753 != 228038)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060013C0 RID: 5056 RVA: 0x001EF538 File Offset: 0x001ED738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ManaVortex.$RPC_dead$18640.$(this.$nArray$18646, this.$self_$18647);
		}

		// Token: 0x060013C1 RID: 5057 RVA: 0x001EF54C File Offset: 0x001ED74C
		internal static bool fnaZi6LsuuQopDoEMO2()
		{
			return true;
		}

		// Token: 0x060013C2 RID: 5058 RVA: 0x001EF550 File Offset: 0x001ED750
		internal static bool SE4FCCL98lcahj7bGtI()
		{
			return false;
		}

		// Token: 0x04001119 RID: 4377
		internal UnityScript.Lang.Array $nArray$18646;

		// Token: 0x0400111A RID: 4378
		internal ManaVortex $self_$18647;

		// Token: 0x02000363 RID: 867
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060013C3 RID: 5059 RVA: 0x001EF554 File Offset: 0x001ED754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ManaVortex self_)
			{
				if (18697 - 483392 != -464694)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (231553 - 261699 == -30146)
					{
						base..ctor();
						if (136496 - 29238 != 107259)
						{
							this.$nArray$18644 = nArray;
							if (140633 - 517473 != -376839)
							{
								this.$self_$18645 = self_;
								if (156679 - 571810 != -415130)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060013C4 RID: 5060 RVA: 0x001EF610 File Offset: 0x001ED810
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (271203 - 503943 != -232740)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5C7;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$18645.gameObject);
						if (248616 - 265122 == -16505)
						{
							continue;
						}
						this.YieldDefault(1);
						if (268117 - 19205 != 248913)
						{
							goto Block_11;
						}
						continue;
					default:
						if (58718 - 447182 != -388464)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18645.PuktHh5RkG.actionState == "dead")
					{
						if (75096 - 401789 != -326692)
						{
							goto Block_35;
						}
					}
					else
					{
						this.$myPosition$18641 = (Vector3)this.$nArray$18644[0];
						if (287033 - 68118 != 218916)
						{
							this.$myDirection$18642 = (Vector3)this.$nArray$18644[1];
							if (219798 - 119052 == 100746)
							{
								this.$self_$18645.transform.position = this.$myPosition$18641;
								if (44990 - 532440 == -487450)
								{
									this.$self_$18645.transform.LookAt(this.$myPosition$18641 + this.$myDirection$18642);
									if (109521 - 209514 == -99993)
									{
										this.$self_$18645.PuktHh5RkG.hp = 0;
										if (275024 - 67611 == 207413)
										{
											this.$self_$18645.PuktHh5RkG.actionState = "dead";
											if (71032 - 204294 != -133261)
											{
												this.$self_$18645.PuktHh5RkG.actionTime = Time.time;
												if (275076 - 141334 == 133742)
												{
													this.$self_$18645.PuktHh5RkG.myCommand = "none";
													if (93276 - 298745 != -205468)
													{
														this.$self_$18645.PuktHh5RkG.vMovement = Vector3.zero;
														if (24323 - 372477 != -348153)
														{
															this.$self_$18645.PuktHh5RkG.moveSpeed = (float)0;
															if (163317 - 346004 != -182686)
															{
																this.$self_$18645.animation.Rewind();
																if (269592 - 316159 != -46566)
																{
																	this.$self_$18645.animation.Play("destroy");
																	if (28642 - 347033 != -318390)
																	{
																		this.$self_$18645.animation.wrapMode = WrapMode.Once;
																		if (122542 - 584895 != -462352)
																		{
																			if (!this.$self_$18645.PuktHh5RkG.isMine)
																			{
																				break;
																			}
																			if (273673 - 31167 == 242506)
																			{
																				if (!this.$self_$18645.isSummon)
																				{
																					break;
																				}
																				if (56646 - 371036 == -314390)
																				{
																					if (!this.$self_$18645.mCreatorChar)
																					{
																						break;
																					}
																					if (256120 - 223277 == 32843)
																					{
																						if (!this.$self_$18645.mCreatorChar.hasSkill(254))
																						{
																							break;
																						}
																						if (137023 - 517880 == -380857)
																						{
																							if (this.$self_$18645.PuktHh5RkG.mp <= 0)
																							{
																								break;
																							}
																							if (135140 - 258105 == -122965)
																							{
																								this.$mPenguinScript$18643 = (Penguin)this.$self_$18645.mCreator.GetComponent(typeof(Penguin));
																								if (240246 - 116638 != 123609)
																								{
																									if (!this.$mPenguinScript$18643)
																									{
																										break;
																									}
																									if (169533 - 171834 == -2301)
																									{
																										this.$self_$18645.mCreatorChar.RPC_AddHeal(1, 0, this.$self_$18645.PuktHh5RkG.mp, 0, 0, 0, this.$self_$18645.PuktHh5RkG.ActorNr);
																										if (149937 - 426801 != -276863)
																										{
																											this.$mPenguinScript$18643.RPC_manaPool_hit(this.$self_$18645.mCreator.transform.position, this.$self_$18645.mCreator.transform.forward, 0);
																											if (280521 - 6926 != 273596)
																											{
																												if (!PhotonClient.IsInitialized())
																												{
																													break;
																												}
																												if (33840 - 572831 != -538990)
																												{
																													this.$mPenguinScript$18643.ActionEvent("RPC_manaPool_hit", this.$self_$18645.mCreator.transform.position, this.$self_$18645.mCreator.transform.forward, 0);
																													if (181970 - 308399 != -126428)
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
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_F7:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_11:
				goto IL_5C7;
				goto IL_F7;
				Block_35:
				IL_5C7:
				return false;
			}

			// Token: 0x060013C5 RID: 5061 RVA: 0x001EFBF8 File Offset: 0x001EDDF8
			internal static bool xr2GFyL13eybkLQ4VtM()
			{
				return true;
			}

			// Token: 0x060013C6 RID: 5062 RVA: 0x001EFBFC File Offset: 0x001EDDFC
			internal static bool PMtbUPL4c4gpIljFMPS()
			{
				return false;
			}

			// Token: 0x0400111B RID: 4379
			internal Vector3 $myPosition$18641;

			// Token: 0x0400111C RID: 4380
			internal Vector3 $myDirection$18642;

			// Token: 0x0400111D RID: 4381
			internal Penguin $mPenguinScript$18643;

			// Token: 0x0400111E RID: 4382
			internal UnityScript.Lang.Array $nArray$18644;

			// Token: 0x0400111F RID: 4383
			internal ManaVortex $self_$18645;
		}
	}
}
