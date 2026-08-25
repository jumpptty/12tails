using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000949 RID: 2377
[Serializable]
public class whale_kingdomKnight : MonoBehaviour
{
	// Token: 0x0600341E RID: 13342 RVA: 0x006B4244 File Offset: 0x006B2444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public whale_kingdomKnight()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x006B4254 File Offset: 0x006B2454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner, int nLv, int nSlot)
	{
		if (161473 - 523888 != -362414)
		{
		}
		for (;;)
		{
			this.rNeDTqGtyl = nOwner;
			if (107041 - 303876 != -196834)
			{
				this.dmuDYPLvhk = this.rNeDTqGtyl.transform;
				if (186496 - 283499 != -97002)
				{
					this.F3mD34079D = (CharacterControl)this.rNeDTqGtyl.GetComponent(typeof(CharacterControl));
					if (61121 - 336200 == -275079)
					{
						this.Ok3Db3QApG = nLv;
						if (282387 - 318107 != -35719)
						{
							this.YrhDdRE7oJ = nSlot;
							if (10496 - 138893 == -128397)
							{
								int yrhDdRE7oJ = this.YrhDdRE7oJ;
								if (28468 - 428600 != -400131)
								{
									if (yrhDdRE7oJ == 0)
									{
										if (3597 - 158784 != -155187)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(1.6f, (float)0, 1.6f);
										if (194698 - 101497 == 93202)
										{
											continue;
										}
									}
									else if (yrhDdRE7oJ == 1)
									{
										if (221200 - 148802 != 72398)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(-1.6f, (float)0, 1.6f);
										if (201661 - 71024 == 130638)
										{
											continue;
										}
									}
									else if (yrhDdRE7oJ == 2)
									{
										if (128215 - 257387 != -129172)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(1.6f, (float)0, -1.6f);
										if (146513 - 207174 == -60660)
										{
											continue;
										}
									}
									else if (yrhDdRE7oJ == 3)
									{
										if (141530 - 127697 != 13833)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(-1.6f, (float)0, -1.6f);
										if (131249 - 134463 == -3213)
										{
											continue;
										}
									}
									else if (yrhDdRE7oJ == 4)
									{
										if (62182 - 388035 != -325853)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(2.2f, (float)0, (float)0);
										if (137081 - 148447 == -11365)
										{
											continue;
										}
									}
									else if (yrhDdRE7oJ == 5)
									{
										if (22441 - 397689 != -375248)
										{
											continue;
										}
										this.jqUDgBosT1 = new Vector3(-2.2f, (float)0, (float)0);
										if (29020 - 131865 == -102844)
										{
											continue;
										}
									}
									this.transform.position = this.dmuDYPLvhk.position + this.dmuDYPLvhk.TransformDirection(this.jqUDgBosT1) - Vector3.up;
									if (174984 - 337622 == -162638)
									{
										this.transform.rotation = this.dmuDYPLvhk.rotation;
										if (173169 - 319198 == -146029)
										{
											if (this.kingdomKnight_ring2)
											{
												if (247195 - 257735 == -10539)
												{
													continue;
												}
												UnityEngine.Object.Instantiate(this.kingdomKnight_ring2, this.transform.position + Vector3.up, this.transform.rotation);
												if (176551 - 454562 == -278010)
												{
													continue;
												}
											}
											if (this.mUpDaeuqax != eKingDomKnightState.init)
											{
												break;
											}
											if (111540 - 325225 != -213684)
											{
												this.mUpDaeuqax = eKingDomKnightState.standby;
												if (259561 - 565910 == -306349)
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

	// Token: 0x06003420 RID: 13344 RVA: 0x006B46B0 File Offset: 0x006B28B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (22341 - 242640 != -220298)
		{
		}
		for (;;)
		{
			if (this.mUpDaeuqax == eKingDomKnightState.init)
			{
				if (150175 - 53698 == 96477)
				{
					break;
				}
			}
			else
			{
				if (this.rNeDTqGtyl)
				{
					if (20705 - 383799 == -363093)
					{
						continue;
					}
					if (!this.F3mD34079D)
					{
						if (230703 - 330209 != -99506)
						{
							continue;
						}
					}
					else if (this.mUpDaeuqax != eKingDomKnightState.standby)
					{
						if (269247 - 47240 != 222008)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.F3mD34079D.actionState == "attack")
						{
							if (32794 - 561685 == -528890)
							{
								continue;
							}
							if (this.F3mD34079D.myCommand == "cAttack1")
							{
								if (33949 - 541818 != -507869)
								{
									continue;
								}
								if (this.F3mD34079D.hasSkill(273))
								{
									if (23084 - 482439 == -459354)
									{
										continue;
									}
									this.StartCoroutine_Auto(this.knightGuard());
									if (22065 - 352749 != -330683)
									{
										break;
									}
									continue;
								}
							}
						}
						this.transform.position = Vector3.Lerp(this.transform.position, this.dmuDYPLvhk.position + this.dmuDYPLvhk.TransformDirection(this.jqUDgBosT1), (float)4 * Time.deltaTime);
						if (283480 - 154633 != 128847)
						{
							continue;
						}
						this.transform.rotation = Quaternion.Lerp(this.transform.rotation, this.dmuDYPLvhk.rotation, (float)4 * Time.deltaTime);
						if (54522 - 539133 != -484611)
						{
							continue;
						}
						break;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (180823 - 415671 != -234847)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x006B4928 File Offset: 0x006B2B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator knightAttack(GameObject tObject)
	{
		return new whale_kingdomKnight.$knightAttack$28448(tObject, this).GetEnumerator();
	}

	// Token: 0x06003422 RID: 13346 RVA: 0x006B4938 File Offset: 0x006B2B38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator knightGuard()
	{
		return new whale_kingdomKnight.$knightGuard$28453(this).GetEnumerator();
	}

	// Token: 0x06003423 RID: 13347 RVA: 0x006B4948 File Offset: 0x006B2B48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new whale_kingdomKnight.$unsummon$28456(this).GetEnumerator();
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x006B4958 File Offset: 0x006B2B58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x006B495C File Offset: 0x006B2B5C
	internal static bool JwCifq5GDiPyn7fDdjZQ()
	{
		return true;
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x006B4960 File Offset: 0x006B2B60
	internal static bool zGXapY5GvLU9jTI1KThH()
	{
		return false;
	}

	// Token: 0x04003FDD RID: 16349
	private GameObject rNeDTqGtyl;

	// Token: 0x04003FDE RID: 16350
	private Transform dmuDYPLvhk;

	// Token: 0x04003FDF RID: 16351
	private CharacterControl F3mD34079D;

	// Token: 0x04003FE0 RID: 16352
	private int Ok3Db3QApG;

	// Token: 0x04003FE1 RID: 16353
	private int YrhDdRE7oJ;

	// Token: 0x04003FE2 RID: 16354
	private Vector3 jqUDgBosT1;

	// Token: 0x04003FE3 RID: 16355
	private eKingDomKnightState mUpDaeuqax;

	// Token: 0x04003FE4 RID: 16356
	public GameObject kingdomKnight_ring2;

	// Token: 0x0200094A RID: 2378
	[CompilerGenerated]
	[Serializable]
	internal sealed class $knightAttack$28448 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003427 RID: 13351 RVA: 0x006B4964 File Offset: 0x006B2B64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $knightAttack$28448(GameObject tObject, whale_kingdomKnight self_)
		{
			if (97653 - 388636 != -290983)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135343 - 310185 == -174842)
				{
					base..ctor();
					if (242800 - 179708 == 63092)
					{
						this.$tObject$28451 = tObject;
						if (273671 - 387170 != -113498)
						{
							this.$self_$28452 = self_;
							if (161289 - 83858 == 77431)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003428 RID: 13352 RVA: 0x006B4A20 File Offset: 0x006B2C20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new whale_kingdomKnight.$knightAttack$28448.$(this.$tObject$28451, this.$self_$28452);
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x006B4A34 File Offset: 0x006B2C34
		internal static bool thlblp5GR4cLOOlrtoIT()
		{
			return true;
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x006B4A38 File Offset: 0x006B2C38
		internal static bool GUHheU5Gwskd7ZcGnN1T()
		{
			return false;
		}

		// Token: 0x04003FE5 RID: 16357
		internal GameObject $tObject$28451;

		// Token: 0x04003FE6 RID: 16358
		internal whale_kingdomKnight $self_$28452;

		// Token: 0x0200094B RID: 2379
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600342B RID: 13355 RVA: 0x006B4A3C File Offset: 0x006B2C3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject tObject, whale_kingdomKnight self_)
			{
				if (24814 - 49663 != -24849)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (100454 - 90528 != 9927)
					{
						base..ctor();
						if (243138 - 220476 == 22662)
						{
							this.$tObject$28449 = tObject;
							if (230318 - 508924 != -278605)
							{
								this.$self_$28450 = self_;
								if (210824 - 132547 != 78278)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600342C RID: 13356 RVA: 0x006B4AF8 File Offset: 0x006B2CF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (222970 - 494131 != -271160)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_361;
					case 2:
						if (!this.$self_$28450.F3mD34079D.isMine)
						{
							goto IL_1A;
						}
						if (26377 - 548107 != -521730)
						{
							continue;
						}
						if (!this.$tObject$28449)
						{
							goto IL_1A;
						}
						if (19924 - 54539 != -34615)
						{
							continue;
						}
						if (this.$self_$28450.F3mD34079D.hit(270 + this.$self_$28450.Ok3Db3QApG, this.$tObject$28449, (int)(0.2f * (float)this.$self_$28450.F3mD34079D.atk + (float)(this.$self_$28450.Ok3Db3QApG * 10)), 1, 0, Vector3.zero) == 0)
						{
							goto IL_1A;
						}
						if (189260 - 426232 == -236971)
						{
							continue;
						}
						this.$self_$28450.F3mD34079D.sp = this.$self_$28450.F3mD34079D.sp + 1;
						if (166574 - 99638 != 66936)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						this.$self_$28450.mUpDaeuqax = eKingDomKnightState.standby;
						if (167601 - 89431 == 78171)
						{
							continue;
						}
						this.$self_$28450.animation.Play("root");
						if (118996 - 456311 == -337314)
						{
							continue;
						}
						this.$self_$28450.animation.wrapMode = WrapMode.Loop;
						if (195742 - 361714 != -165972)
						{
							continue;
						}
						this.YieldDefault(1);
						if (96804 - 413334 != -316530)
						{
							continue;
						}
						goto IL_361;
					default:
						if (19971 - 324062 == -304090)
						{
							continue;
						}
						break;
					}
					if (!this.$tObject$28449)
					{
						if (70447 - 288523 == -218076)
						{
							goto IL_1A2;
						}
					}
					else if (this.$self_$28450.mUpDaeuqax != eKingDomKnightState.standby)
					{
						if (288605 - 77478 == 211127)
						{
							goto IL_A3;
						}
					}
					else
					{
						this.$self_$28450.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(this.$tObject$28449.transform.position - this.$self_$28450.transform.position));
						if (270027 - 91367 == 178660)
						{
							this.$self_$28450.mUpDaeuqax = eKingDomKnightState.attack;
							if (262533 - 236350 != 26184)
							{
								this.$self_$28450.animation.Play("nAttack");
								if (67801 - 529703 == -461902)
								{
									this.$self_$28450.animation.wrapMode = WrapMode.Once;
									if (230014 - 89977 != 140038)
									{
										goto Block_4;
									}
								}
							}
						}
					}
				}
				IL_1A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_A3:
				IL_1A2:
				IL_361:
				return false;
			}

			// Token: 0x0600342D RID: 13357 RVA: 0x006B4E78 File Offset: 0x006B3078
			internal static bool NMrnUM5Gq0mrYCdK8gkD()
			{
				return true;
			}

			// Token: 0x0600342E RID: 13358 RVA: 0x006B4E7C File Offset: 0x006B307C
			internal static bool XEIPp65G7PcmTr607lTH()
			{
				return false;
			}

			// Token: 0x04003FE7 RID: 16359
			internal GameObject $tObject$28449;

			// Token: 0x04003FE8 RID: 16360
			internal whale_kingdomKnight $self_$28450;
		}
	}

	// Token: 0x0200094C RID: 2380
	[CompilerGenerated]
	[Serializable]
	internal sealed class $knightGuard$28453 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600342F RID: 13359 RVA: 0x006B4E80 File Offset: 0x006B3080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $knightGuard$28453(whale_kingdomKnight self_)
		{
			if (234103 - 88531 != 145572)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200715 - 169875 == 30840)
				{
					base..ctor();
					if (122539 - 575471 != -452931)
					{
						this.$self_$28455 = self_;
						if (167761 - 259021 != -91259)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003430 RID: 13360 RVA: 0x006B4F18 File Offset: 0x006B3118
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new whale_kingdomKnight.$knightGuard$28453.$(this.$self_$28455);
		}

		// Token: 0x06003431 RID: 13361 RVA: 0x006B4F28 File Offset: 0x006B3128
		internal static bool XyvUtR5GPdSYSMfD0td8()
		{
			return true;
		}

		// Token: 0x06003432 RID: 13362 RVA: 0x006B4F2C File Offset: 0x006B312C
		internal static bool GN6K9H5G0YBubQDpKBnh()
		{
			return false;
		}

		// Token: 0x04003FE9 RID: 16361
		internal whale_kingdomKnight $self_$28455;

		// Token: 0x0200094D RID: 2381
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003433 RID: 13363 RVA: 0x006B4F30 File Offset: 0x006B3130
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(whale_kingdomKnight self_)
			{
				if (13067 - 193525 != -180457)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (65669 - 16175 == 49494)
					{
						base..ctor();
						if (268572 - 339418 == -70846)
						{
							this.$self_$28454 = self_;
							if (4498 - 343621 == -339123)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06003434 RID: 13364 RVA: 0x006B4FC8 File Offset: 0x006B31C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79613 - 172283 != -92669)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_13A;
					case 1:
						goto IL_375;
					case 2:
						break;
					case 3:
						break;
					default:
						if (71609 - 1302 != 70307)
						{
							continue;
						}
						goto IL_13A;
					}
					if (this.$self_$28454.rNeDTqGtyl)
					{
						if (100447 - 14595 != 85852)
						{
							continue;
						}
						if (!this.$self_$28454.F3mD34079D)
						{
							if (57782 - 518760 == -460977)
							{
								continue;
							}
						}
						else
						{
							if (this.$self_$28454.F3mD34079D.actionState == "attack")
							{
								if (222018 - 593466 != -371448)
								{
									continue;
								}
								if (this.$self_$28454.F3mD34079D.myCommand == "cAttack1")
								{
									if (70143 - 84139 == -13995)
									{
										continue;
									}
									this.$self_$28454.transform.rotation = Quaternion.LookRotation(global::Math.vFlat(UnityEngine.Random.onUnitSphere));
									if (97979 - 448277 == -350297)
									{
										continue;
									}
									this.$self_$28454.animation.Play("cAttack");
									if (92165 - 594852 != -502687)
									{
										continue;
									}
									this.$self_$28454.animation.wrapMode = WrapMode.Loop;
									if (114399 - 4036 != 110364)
									{
										break;
									}
									continue;
								}
							}
							this.$self_$28454.mUpDaeuqax = eKingDomKnightState.standby;
							if (189306 - 133585 != 55721)
							{
								continue;
							}
							this.$self_$28454.animation.Play("root");
							if (294952 - 36537 != 258415)
							{
								continue;
							}
							this.$self_$28454.animation.wrapMode = WrapMode.Loop;
							if (100930 - 93227 != 7703)
							{
								continue;
							}
							goto IL_1F0;
						}
					}
					this.$self_$28454.mUpDaeuqax = eKingDomKnightState.standby;
					if (209260 - 576499 == -367238)
					{
						continue;
					}
					this.$self_$28454.animation.Play("root");
					if (289022 - 472044 != -183022)
					{
						continue;
					}
					this.$self_$28454.animation.wrapMode = WrapMode.Loop;
					if (193429 - 154818 != 38611)
					{
						continue;
					}
					this.YieldDefault(1);
					if (140433 - 393921 != -253488)
					{
						continue;
					}
					goto IL_375;
					IL_13A:
					if (this.$self_$28454.mUpDaeuqax != eKingDomKnightState.standby)
					{
						if (280651 - 22315 != 258337)
						{
							goto Block_10;
						}
					}
					else
					{
						this.$self_$28454.mUpDaeuqax = eKingDomKnightState.guard;
						if (297911 - 585706 != -287794)
						{
							goto Block_19;
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_10:
				IL_1F0:
				goto IL_375;
				Block_19:
				return this.Yield(2, new WaitForSeconds(0.1f * (float)this.$self_$28454.YrhDdRE7oJ));
				IL_375:
				return false;
			}

			// Token: 0x06003435 RID: 13365 RVA: 0x006B535C File Offset: 0x006B355C
			internal static bool JN6YT15GbKUZB29PeLOr()
			{
				return true;
			}

			// Token: 0x06003436 RID: 13366 RVA: 0x006B5360 File Offset: 0x006B3560
			internal static bool iwEEDO5GuIuw0kUR3r9v()
			{
				return false;
			}

			// Token: 0x04003FEA RID: 16362
			internal whale_kingdomKnight $self_$28454;
		}
	}

	// Token: 0x0200094E RID: 2382
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$28456 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003437 RID: 13367 RVA: 0x006B5364 File Offset: 0x006B3564
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$28456(whale_kingdomKnight self_)
		{
			if (234340 - 121369 != 112971)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (9510 - 24458 == -14948)
				{
					base..ctor();
					if (191670 - 165822 != 25849)
					{
						this.$self_$28458 = self_;
						if (286151 - 78674 != 207478)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x006B53FC File Offset: 0x006B35FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new whale_kingdomKnight.$unsummon$28456.$(this.$self_$28458);
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x006B540C File Offset: 0x006B360C
		internal static bool Rhogfm5GIeDWfI9pxP4n()
		{
			return true;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x006B5410 File Offset: 0x006B3610
		internal static bool uWFqAP5GB0ePkGLKdujL()
		{
			return false;
		}

		// Token: 0x04003FEB RID: 16363
		internal whale_kingdomKnight $self_$28458;

		// Token: 0x0200094F RID: 2383
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600343B RID: 13371 RVA: 0x006B5414 File Offset: 0x006B3614
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(whale_kingdomKnight self_)
			{
				if (246711 - 303961 != -57249)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127873 - 319835 != -191961)
					{
						base..ctor();
						if (80349 - 512722 == -432373)
						{
							this.$self_$28457 = self_;
							if (200211 - 252378 == -52167)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x0600343C RID: 13372 RVA: 0x006B54AC File Offset: 0x006B36AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18646 - 143880 != -125234)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_12E;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$28457.gameObject);
						if (181448 - 62292 == 119157)
						{
							continue;
						}
						this.YieldDefault(1);
						if (55220 - 10314 != 44907)
						{
							goto IL_12E;
						}
						continue;
					default:
						if (53854 - 245416 != -191562)
						{
							continue;
						}
						break;
					}
					this.$self_$28457.mUpDaeuqax = eKingDomKnightState.unsummon;
					if (156206 - 28975 != 127232)
					{
						this.$self_$28457.animation.Play("unsummon");
						if (158615 - 216298 == -57683)
						{
							this.$self_$28457.animation.wrapMode = WrapMode.Once;
							if (21324 - 160660 == -139336)
							{
								break;
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(1f));
				IL_12E:
				return false;
			}

			// Token: 0x0600343D RID: 13373 RVA: 0x006B55FC File Offset: 0x006B37FC
			internal static bool snLp9N5Ges1jp8Ps2VQ7()
			{
				return true;
			}

			// Token: 0x0600343E RID: 13374 RVA: 0x006B5600 File Offset: 0x006B3800
			internal static bool VPQwTG5GrHjHERbL7W09()
			{
				return false;
			}

			// Token: 0x04003FEC RID: 16364
			internal whale_kingdomKnight $self_$28457;
		}
	}
}
