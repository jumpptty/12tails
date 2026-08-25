using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000226 RID: 550
[Serializable]
public class StingNest : MonoBehaviour
{
	// Token: 0x06000C7F RID: 3199 RVA: 0x0013F7D4 File Offset: 0x0013D9D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingNest()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000C80 RID: 3200 RVA: 0x0013F7E4 File Offset: 0x0013D9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (85859 - 131201 != -45341)
		{
		}
		for (;;)
		{
			this.w2CI5WuBdd = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (65940 - 192767 != -126826)
			{
				this.w2CI5WuBdd.actionState = "standby";
				if (147963 - 260428 == -112465)
				{
					this.w2CI5WuBdd.actionTime = Time.time;
					if (143239 - 68308 == 74931)
					{
						this.w2CI5WuBdd.myCommand = "none";
						if (120370 - 460611 == -340241)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (137196 - 402010 == -264814)
							{
								this.w2CI5WuBdd.isMine = true;
								if (10287 - 535633 != -525345)
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

	// Token: 0x06000C81 RID: 3201 RVA: 0x0013F91C File Offset: 0x0013DB1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (65923 - 517023 != -451099)
		{
		}
		for (;;)
		{
			if (this.w2CI5WuBdd.isControlled)
			{
				if (209589 - 307305 != -97716)
				{
					continue;
				}
				if (!(this.w2CI5WuBdd.actionState == "standby"))
				{
					if (254542 - 377064 != -122522)
					{
						continue;
					}
					if (!(this.w2CI5WuBdd.actionState == "run"))
					{
						goto IL_9D;
					}
					if (72893 - 174275 != -101382)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (112506 - 451193 != -338687)
				{
					continue;
				}
			}
			IL_9D:
			if (this.w2CI5WuBdd.hp <= 0)
			{
				if (88243 - 76719 == 11525)
				{
					continue;
				}
				if (this.w2CI5WuBdd.actionState != "dead")
				{
					if (289532 - 497724 != -208192)
					{
						continue;
					}
					if (this.w2CI5WuBdd.isMine)
					{
						if (114152 - 66673 == 47480)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (142864 - 189080 == -46215)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (285334 - 452171 != -166837)
						{
							continue;
						}
						this.w2CI5WuBdd.DeadEvent();
						if (298302 - 556481 != -258179)
						{
							continue;
						}
						break;
					}
					else
					{
						this.w2CI5WuBdd.hp = 1;
						if (157771 - 40694 != 117078)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.w2CI5WuBdd.hp <= 0)
			{
				break;
			}
			if (182334 - 43950 == 138384)
			{
				if (!(this.w2CI5WuBdd.actionState != "dead"))
				{
					break;
				}
				if (240748 - 550064 == -309316)
				{
					if (this.w2CI5WuBdd.myDamage != -1)
					{
						break;
					}
					if (124560 - 84539 == 40021)
					{
						if (!this.w2CI5WuBdd.isMine)
						{
							break;
						}
						if (254922 - 542061 != -287138)
						{
							if (this.w2CI5WuBdd.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (43857 - 433531 != -389673)
							{
								this.StartCoroutine_Auto(this.RPC_gotHit());
								if (112705 - 80377 != 32329)
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

	// Token: 0x06000C82 RID: 3202 RVA: 0x0013FC6C File Offset: 0x0013DE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
	}

	// Token: 0x06000C83 RID: 3203 RVA: 0x0013FC70 File Offset: 0x0013DE70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot attack");
	}

	// Token: 0x06000C84 RID: 3204 RVA: 0x0013FC88 File Offset: 0x0013DE88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000C85 RID: 3205 RVA: 0x0013FC8C File Offset: 0x0013DE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000C86 RID: 3206 RVA: 0x0013FC90 File Offset: 0x0013DE90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_createBug(string nType, Vector3 nPos, Vector3 nDir)
	{
		if (224035 - 366261 != -142225)
		{
		}
		while (PhotonClient.IsInitialized())
		{
			if (145960 - 396425 != -250464)
			{
				Hashtable hashtable = new Hashtable();
				if (1975 - 40730 != -38754)
				{
					hashtable.Add(43, PlayerData.UID);
					if (224463 - 460922 == -236459)
					{
						hashtable.Add(73, nType);
						if (268176 - 30191 == 237985)
						{
							hashtable.Add(75, PhotonClient.cInt16(6));
							if (97822 - 280394 == -182572)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (41456 - 443566 != -402109)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (125691 - 175930 == -50239)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (92675 - 97969 == -5294)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (118932 - 307541 == -188609)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
												if (228250 - 186090 == 42160)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
													if (166776 - 292150 != -125373)
													{
														PhotonClient.Connection.OpCustom(63, hashtable, true);
														if (130265 - 239721 != -109455)
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

	// Token: 0x06000C87 RID: 3207 RVA: 0x0013FF6C File Offset: 0x0013E16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gotHit()
	{
		return new StingNest.$RPC_gotHit$17424(this).GetEnumerator();
	}

	// Token: 0x06000C88 RID: 3208 RVA: 0x0013FF7C File Offset: 0x0013E17C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new StingNest.$RPC_dead$17430(nArray, this).GetEnumerator();
	}

	// Token: 0x06000C89 RID: 3209 RVA: 0x0013FF8C File Offset: 0x0013E18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C8A RID: 3210 RVA: 0x0013FF90 File Offset: 0x0013E190
	internal static bool MLGm9WAqQsS0vwxSnOW()
	{
		return true;
	}

	// Token: 0x06000C8B RID: 3211 RVA: 0x0013FF94 File Offset: 0x0013E194
	internal static bool NTX0G7A7GhhkY2N08H0()
	{
		return false;
	}

	// Token: 0x04000AFC RID: 2812
	private CharacterControl w2CI5WuBdd;

	// Token: 0x04000AFD RID: 2813
	private bool juxIcQ2O9T;

	// Token: 0x04000AFE RID: 2814
	public AudioClip stingBug_buzz;

	// Token: 0x02000227 RID: 551
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gotHit$17424 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C8C RID: 3212 RVA: 0x0013FF98 File Offset: 0x0013E198
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gotHit$17424(StingNest self_)
		{
			if (230235 - 221098 != 9137)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241428 - 428182 == -186754)
				{
					base..ctor();
					if (211587 - 218569 != -6981)
					{
						this.$self_$17429 = self_;
						if (291377 - 141847 != 149531)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000C8D RID: 3213 RVA: 0x00140030 File Offset: 0x0013E230
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingNest.$RPC_gotHit$17424.$(this.$self_$17429);
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00140040 File Offset: 0x0013E240
		internal static bool qWFrx7APi8a5fAQ5SGq()
		{
			return true;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00140044 File Offset: 0x0013E244
		internal static bool DESp5KA0PBc4N5IVVAh()
		{
			return false;
		}

		// Token: 0x04000AFF RID: 2815
		internal StingNest $self_$17429;

		// Token: 0x02000228 RID: 552
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C90 RID: 3216 RVA: 0x00140048 File Offset: 0x0013E248
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(StingNest self_)
			{
				if (24768 - 335748 != -310979)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213415 - 431098 == -217683)
					{
						base..ctor();
						if (196935 - 574492 != -377556)
						{
							this.$self_$17428 = self_;
							if (33657 - 517448 != -483790)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x001400E0 File Offset: 0x0013E2E0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66079 - 255512 != -189432)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_65B;
					case 2:
						if (this.$self_$17428.w2CI5WuBdd.actionState == "attack")
						{
							if (201878 - 216981 == -15102)
							{
								continue;
							}
							if (this.$self_$17428.w2CI5WuBdd.myCommand == "sting")
							{
								if (70980 - 431893 != -360913)
								{
									continue;
								}
								this.$self_$17428.w2CI5WuBdd.moveSpeed = (float)0;
								if (123389 - 511204 == -387814)
								{
									continue;
								}
								this.$self_$17428.w2CI5WuBdd.actionState = "standby";
								if (4508 - 141312 == -136803)
								{
									continue;
								}
								this.$self_$17428.w2CI5WuBdd.actionTime = Time.time;
								if (249056 - 40915 == 208142)
								{
									continue;
								}
								this.$self_$17428.w2CI5WuBdd.myCommand = "none";
								if (158561 - 250697 == -92135)
								{
									continue;
								}
								if (!this.$self_$17428.w2CI5WuBdd.isMine)
								{
									if (72116 - 472781 != -400665)
									{
										continue;
									}
									this.$self_$17428.w2CI5WuBdd.nPosition = this.$self_$17428.transform.position;
									if (182145 - 544794 == -362648)
									{
										continue;
									}
									this.$self_$17428.w2CI5WuBdd.oPosition = this.$self_$17428.transform.position;
									if (267962 - 28607 != 239355)
									{
										continue;
									}
									this.$self_$17428.w2CI5WuBdd.nDirection = this.$self_$17428.transform.forward;
									if (14937 - 383387 == -368449)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (71046 - 469843 != -398796)
						{
							goto Block_7;
						}
						continue;
					default:
						if (107328 - 289761 != -182433)
						{
							continue;
						}
						break;
					}
					this.$self_$17428.w2CI5WuBdd.actionState = "attack";
					if (119210 - 332679 != -213468)
					{
						this.$self_$17428.w2CI5WuBdd.actionTime = Time.time;
						if (72989 - 350943 == -277954)
						{
							this.$self_$17428.w2CI5WuBdd.myCommand = "gotHit";
							if (42341 - 215870 == -173529)
							{
								this.$self_$17428.w2CI5WuBdd.addTimeOut("nAttack", 0.6f);
								if (15004 - 86389 != -71384)
								{
									if (this.$self_$17428.w2CI5WuBdd.isMine)
									{
										if (120144 - 12983 != 107161)
										{
											continue;
										}
										if (!this.$self_$17428.juxIcQ2O9T)
										{
											if (136382 - 144057 != -7675)
											{
												continue;
											}
											this.$self_$17428.juxIcQ2O9T = true;
											if (189897 - 522320 == -332422)
											{
												continue;
											}
											if (this.$self_$17428.stingBug_buzz)
											{
												if (296239 - 3299 == 292941)
												{
													continue;
												}
												this.$self_$17428.audio.PlayOneShot(this.$self_$17428.stingBug_buzz);
												if (249710 - 294579 == -44868)
												{
													continue;
												}
											}
											this.$nPosition1$17425 = global::Math.getSpawnPos(this.$self_$17428.transform.position + this.$self_$17428.transform.TransformDirection((float)0, (float)0, (float)5));
											if (31424 - 296990 == -265565)
											{
												continue;
											}
											this.$nPosition2$17426 = global::Math.getSpawnPos(this.$self_$17428.transform.position + this.$self_$17428.transform.TransformDirection((float)2, (float)0, -3.5f));
											if (100419 - 476952 == -376532)
											{
												continue;
											}
											this.$nPosition3$17427 = global::Math.getSpawnPos(this.$self_$17428.transform.position + this.$self_$17428.transform.TransformDirection((float)-2, (float)0, -3.5f));
											if (4976 - 501964 == -496987)
											{
												continue;
											}
											this.$self_$17428.RPC_createBug("StingBug_g", this.$nPosition1$17425 + 0.1f * Vector3.up, Vector3.forward);
											if (92521 - 420855 != -328334)
											{
												continue;
											}
											this.$self_$17428.RPC_createBug("StingBug_g", this.$nPosition2$17426 + 0.1f * Vector3.up, Vector3.forward);
											if (255594 - 21735 == 233860)
											{
												continue;
											}
											this.$self_$17428.RPC_createBug("StingBug_r", this.$nPosition3$17427 + 0.1f * Vector3.up, Vector3.forward);
											if (150115 - 301069 == -150953)
											{
												continue;
											}
										}
									}
									this.$self_$17428.animation.CrossFade("hit");
									if (217192 - 566517 == -349325)
									{
										this.$self_$17428.animation.wrapMode = WrapMode.Once;
										if (1456 - 31560 == -30104)
										{
											goto IL_3C7;
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_65B;
				IL_3C7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_65B:
				return false;
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x0014075C File Offset: 0x0013E95C
			internal static bool w8HKZnAbgSFh1TqpeBb()
			{
				return true;
			}

			// Token: 0x06000C93 RID: 3219 RVA: 0x00140760 File Offset: 0x0013E960
			internal static bool vnM51AAuRGU6KNykHfl()
			{
				return false;
			}

			// Token: 0x04000B00 RID: 2816
			internal Vector3 $nPosition1$17425;

			// Token: 0x04000B01 RID: 2817
			internal Vector3 $nPosition2$17426;

			// Token: 0x04000B02 RID: 2818
			internal Vector3 $nPosition3$17427;

			// Token: 0x04000B03 RID: 2819
			internal StingNest $self_$17428;
		}
	}

	// Token: 0x02000229 RID: 553
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17430 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000C94 RID: 3220 RVA: 0x00140764 File Offset: 0x0013E964
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17430(UnityScript.Lang.Array nArray, StingNest self_)
		{
			if (283791 - 336383 != -52591)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (73526 - 349739 != -276212)
				{
					base..ctor();
					if (173165 - 218109 != -44943)
					{
						this.$nArray$17435 = nArray;
						if (145193 - 482685 != -337491)
						{
							this.$self_$17436 = self_;
							if (199829 - 525841 == -326012)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00140820 File Offset: 0x0013EA20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingNest.$RPC_dead$17430.$(this.$nArray$17435, this.$self_$17436);
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00140834 File Offset: 0x0013EA34
		internal static bool Ewb3dMAIbf29InMlEJc()
		{
			return true;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00140838 File Offset: 0x0013EA38
		internal static bool v0wLj6AB7St8o9iDLqm()
		{
			return false;
		}

		// Token: 0x04000B04 RID: 2820
		internal UnityScript.Lang.Array $nArray$17435;

		// Token: 0x04000B05 RID: 2821
		internal StingNest $self_$17436;

		// Token: 0x0200022A RID: 554
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000C98 RID: 3224 RVA: 0x0014083C File Offset: 0x0013EA3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingNest self_)
			{
				if (125044 - 391697 != -266653)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25325 - 518616 != -493290)
					{
						base..ctor();
						if (140585 - 301424 == -160839)
						{
							this.$nArray$17433 = nArray;
							if (58116 - 593792 != -535675)
							{
								this.$self_$17434 = self_;
								if (139858 - 588808 == -448950)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000C99 RID: 3225 RVA: 0x001408F8 File Offset: 0x0013EAF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (219902 - 76556 != 143347)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3F1;
					case 2:
						if (this.$self_$17434.w2CI5WuBdd.isPlayer)
						{
							if (183944 - 544564 == -360619)
							{
								continue;
							}
							if (this.$self_$17434.w2CI5WuBdd.isMine)
							{
								if (175994 - 414610 == -238615)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17434.gameObject);
								if (231318 - 89348 != 141970)
								{
									continue;
								}
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$17434.gameObject);
							if (227386 - 85744 != 141642)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (238830 - 156985 != 81845)
						{
							continue;
						}
						goto IL_3F1;
					default:
						if (204766 - 89991 != 114775)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17434.w2CI5WuBdd.actionState == "dead")
					{
						if (265015 - 344377 != -79361)
						{
							goto Block_22;
						}
					}
					else
					{
						this.$myPosition$17431 = (Vector3)this.$nArray$17433[0];
						if (45824 - 545164 == -499340)
						{
							this.$myDirection$17432 = (Vector3)this.$nArray$17433[1];
							if (199824 - 224533 != -24708)
							{
								this.$self_$17434.transform.position = this.$myPosition$17431;
								if (29989 - 339539 != -309549)
								{
									this.$self_$17434.transform.LookAt(this.$myPosition$17431 + this.$myDirection$17432);
									if (113974 - 457635 == -343661)
									{
										this.$self_$17434.w2CI5WuBdd.hp = 0;
										if (31237 - 253077 == -221840)
										{
											this.$self_$17434.w2CI5WuBdd.actionState = "dead";
											if (152134 - 385828 == -233694)
											{
												this.$self_$17434.w2CI5WuBdd.actionTime = Time.time;
												if (252916 - 461839 != -208922)
												{
													this.$self_$17434.w2CI5WuBdd.myCommand = "none";
													if (169608 - 495577 == -325969)
													{
														this.$self_$17434.w2CI5WuBdd.vMovement = Vector3.zero;
														if (97541 - 58653 != 38889)
														{
															this.$self_$17434.w2CI5WuBdd.moveSpeed = (float)0;
															if (53606 - 369529 != -315922)
															{
																this.$self_$17434.animation.Rewind();
																if (299744 - 76922 == 222822)
																{
																	this.$self_$17434.animation.Play("dead");
																	if (69900 - 318707 == -248807)
																	{
																		this.$self_$17434.animation.wrapMode = WrapMode.Once;
																		if (130093 - 238718 != -108624)
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
				return this.Yield(2, new WaitForSeconds(10f));
				Block_22:
				IL_3F1:
				return false;
			}

			// Token: 0x06000C9A RID: 3226 RVA: 0x00140D08 File Offset: 0x0013EF08
			internal static bool XbstuuAesdbrqEHZavK()
			{
				return true;
			}

			// Token: 0x06000C9B RID: 3227 RVA: 0x00140D0C File Offset: 0x0013EF0C
			internal static bool TloaEUArvy9qJeeVAuX()
			{
				return false;
			}

			// Token: 0x04000B06 RID: 2822
			internal Vector3 $myPosition$17431;

			// Token: 0x04000B07 RID: 2823
			internal Vector3 $myDirection$17432;

			// Token: 0x04000B08 RID: 2824
			internal UnityScript.Lang.Array $nArray$17433;

			// Token: 0x04000B09 RID: 2825
			internal StingNest $self_$17434;
		}
	}
}
