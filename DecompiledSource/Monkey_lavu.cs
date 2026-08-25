using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020006DB RID: 1755
[Serializable]
public class Monkey_lavu : MonoBehaviour
{
	// Token: 0x0600274C RID: 10060 RVA: 0x004B7130 File Offset: 0x004B5330
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Monkey_lavu()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600274D RID: 10061 RVA: 0x004B7140 File Offset: 0x004B5340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (106305 - 593539 != -487234)
		{
		}
		for (;;)
		{
			IL_130:
			if (!this.BKPsYsmWkx)
			{
				if (184520 - 263908 == -79388)
				{
					break;
				}
			}
			else if (this.Ww1s1kEaGY)
			{
				if (70286 - 37361 != 32926)
				{
					if (this.nLwsRkNIvj == eMonkeyLavuState.standby)
					{
						if (140942 - 340668 != -199726)
						{
							continue;
						}
						Vector3 forward = Vector3.RotateTowards(this.transform.forward, this.Ww1s1kEaGY.transform.position + (float)4 * Vector3.up - this.transform.position, Time.deltaTime, 1f);
						if (53019 - 299204 == -246184)
						{
							continue;
						}
						this.transform.Translate((float)8 * Vector3.forward * Time.deltaTime);
						if (62174 - 550668 == -488493)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(forward);
						if (141045 - 143476 != -2431)
						{
							continue;
						}
					}
					if (Time.time > this.FVWs34u3u4)
					{
						if (35504 - 434031 == -398526)
						{
							continue;
						}
						this.FVWs34u3u4 = Time.time + 0.25f;
						if (57854 - 182858 == -125003)
						{
							continue;
						}
						int i = 7;
						if (123056 - 400660 != -277604)
						{
							continue;
						}
						while (i > 0)
						{
							this.yPYsT7Z5yh[i] = this.yPYsT7Z5yh[i - 1];
							if (46481 - 222864 != -176383)
							{
								goto IL_130;
							}
							i--;
							if (176404 - 595837 == -419432)
							{
								goto IL_130;
							}
						}
						if (12839 - 519559 == -506719)
						{
							continue;
						}
						this.yPYsT7Z5yh[0] = this.transform.position;
						if (266678 - 187309 != 79369)
						{
							continue;
						}
					}
					int j = 0;
					if (141410 - 69004 == 72406)
					{
						while (j < 6)
						{
							if (this.TEesxmUCFM[j])
							{
								if (162366 - 411469 == -249102)
								{
									goto IL_130;
								}
								this.TEesxmUCFM[j].position = Vector3.Lerp(this.yPYsT7Z5yh[j], this.yPYsT7Z5yh[j + 1], (float)4 * (this.FVWs34u3u4 - Time.time));
								if (273399 - 19727 == 253673)
								{
									goto IL_130;
								}
								this.TEesxmUCFM[j].rotation = Quaternion.LookRotation(Vector3.Slerp(this.yPYsT7Z5yh[j] - this.yPYsT7Z5yh[j + 1], this.yPYsT7Z5yh[j + 1] - this.yPYsT7Z5yh[j + 2], (float)4 * (this.FVWs34u3u4 - Time.time)));
								if (262609 - 261860 != 749)
								{
									goto IL_130;
								}
							}
							j++;
							if (240944 - 342295 == -101350)
							{
								goto IL_130;
							}
						}
						if (291078 - 553726 != -262647)
						{
							break;
						}
					}
				}
			}
			else
			{
				UnityEngine.Object.Destroy(this.gameObject);
				if (56918 - 490409 != -433490)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600274E RID: 10062 RVA: 0x004B7590 File Offset: 0x004B5790
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(GameObject nSummoner)
	{
		return new Monkey_lavu.$summon$24314(nSummoner, this).GetEnumerator();
	}

	// Token: 0x0600274F RID: 10063 RVA: 0x004B75A0 File Offset: 0x004B57A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator upheaval()
	{
		return new Monkey_lavu.$upheaval$24320(this).GetEnumerator();
	}

	// Token: 0x06002750 RID: 10064 RVA: 0x004B75B0 File Offset: 0x004B57B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Monkey_lavu.$unsummon$24324(this).GetEnumerator();
	}

	// Token: 0x06002751 RID: 10065 RVA: 0x004B75C0 File Offset: 0x004B57C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002752 RID: 10066 RVA: 0x004B75C4 File Offset: 0x004B57C4
	internal static bool hxnpGphiGCcrZWUYLSt()
	{
		return true;
	}

	// Token: 0x06002753 RID: 10067 RVA: 0x004B75C8 File Offset: 0x004B57C8
	internal static bool dSFxnihKkNomoiIv1V1()
	{
		return false;
	}

	// Token: 0x04002BEB RID: 11243
	private GameObject Ww1s1kEaGY;

	// Token: 0x04002BEC RID: 11244
	private CharacterControl REQsqeOFQg;

	// Token: 0x04002BED RID: 11245
	private int wcqspB7Rdj;

	// Token: 0x04002BEE RID: 11246
	private eMonkeyLavuState nLwsRkNIvj;

	// Token: 0x04002BEF RID: 11247
	private float tcIsrnh6C0;

	// Token: 0x04002BF0 RID: 11248
	private Transform[] TEesxmUCFM;

	// Token: 0x04002BF1 RID: 11249
	private Vector3[] yPYsT7Z5yh;

	// Token: 0x04002BF2 RID: 11250
	private bool BKPsYsmWkx;

	// Token: 0x04002BF3 RID: 11251
	private float FVWs34u3u4;

	// Token: 0x020006DC RID: 1756
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$24314 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06002754 RID: 10068 RVA: 0x004B75CC File Offset: 0x004B57CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$24314(GameObject nSummoner, Monkey_lavu self_)
		{
			if (101455 - 1432 != 100023)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233739 - 25706 == 208033)
				{
					base..ctor();
					if (184781 - 569723 == -384942)
					{
						this.$nSummoner$24318 = nSummoner;
						if (173555 - 285150 != -111594)
						{
							this.$self_$24319 = self_;
							if (195768 - 590824 != -395055)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x004B7688 File Offset: 0x004B5888
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Monkey_lavu.$summon$24314.$(this.$nSummoner$24318, this.$self_$24319);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x004B769C File Offset: 0x004B589C
		internal static bool x8BTZahdFKRNEvsGtJX()
		{
			return true;
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x004B76A0 File Offset: 0x004B58A0
		internal static bool JDLuH7hJvZl839AjQ9K()
		{
			return false;
		}

		// Token: 0x04002BF4 RID: 11252
		internal GameObject $nSummoner$24318;

		// Token: 0x04002BF5 RID: 11253
		internal Monkey_lavu $self_$24319;

		// Token: 0x020006DD RID: 1757
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06002758 RID: 10072 RVA: 0x004B76A4 File Offset: 0x004B58A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nSummoner, Monkey_lavu self_)
			{
				if (110806 - 39738 != 71069)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187169 - 413573 != -226403)
					{
						base..ctor();
						if (9689 - 98867 != -89177)
						{
							this.$nSummoner$24316 = nSummoner;
							if (223180 - 340394 != -117213)
							{
								this.$self_$24317 = self_;
								if (271526 - 482610 == -211084)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06002759 RID: 10073 RVA: 0x004B7760 File Offset: 0x004B5960
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (85184 - 169767 != -84582)
				{
				}
				for (;;)
				{
					IL_3CC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_558;
					case 2:
						goto IL_500;
					default:
						if (94813 - 371887 == -277073)
						{
							continue;
						}
						break;
					}
					this.$self_$24317.Ww1s1kEaGY = this.$nSummoner$24316;
					if (39554 - 116637 != -77083)
					{
						continue;
					}
					this.$self_$24317.REQsqeOFQg = (CharacterControl)this.$nSummoner$24316.GetComponent(typeof(CharacterControl));
					if (1411 - 89799 != -88388)
					{
						continue;
					}
					this.$self_$24317.nLwsRkNIvj = eMonkeyLavuState.summon;
					if (120969 - 463032 == -342062)
					{
						continue;
					}
					this.$self_$24317.tcIsrnh6C0 = Time.time;
					if (236258 - 299825 == -63566)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM = new Transform[6];
					if (197855 - 436045 != -238190)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[0] = this.$self_$24317.transform.Find("body1");
					if (271543 - 596256 != -324713)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[1] = this.$self_$24317.transform.Find("body2");
					if (46821 - 290067 == -243245)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[2] = this.$self_$24317.transform.Find("body3");
					if (63954 - 418115 != -354161)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[3] = this.$self_$24317.transform.Find("body4");
					if (74767 - 341258 != -266491)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[4] = this.$self_$24317.transform.Find("body5");
					if (258380 - 322266 == -63885)
					{
						continue;
					}
					this.$self_$24317.TEesxmUCFM[5] = this.$self_$24317.transform.Find("tail");
					if (263900 - 518987 != -255087)
					{
						continue;
					}
					this.$self_$24317.yPYsT7Z5yh = new Vector3[8];
					if (277531 - 304815 == -27283)
					{
						continue;
					}
					this.$self_$24317.yPYsT7Z5yh[0] = this.$self_$24317.transform.position;
					if (21220 - 231019 == -209798)
					{
						continue;
					}
					this.$i$24315 = 0;
					if (238887 - 12246 != 226641)
					{
						continue;
					}
					while (this.$i$24315 < 6)
					{
						this.$self_$24317.yPYsT7Z5yh[this.$i$24315 + 1] = this.$self_$24317.TEesxmUCFM[this.$i$24315].position;
						if (282683 - 576837 != -294154)
						{
							goto IL_3CC;
						}
						this.$i$24315++;
						if (124216 - 188900 == -64683)
						{
							goto IL_3CC;
						}
					}
					if (288964 - 230843 == 58122)
					{
						continue;
					}
					this.$self_$24317.yPYsT7Z5yh[7] = this.$self_$24317.TEesxmUCFM[5].position;
					if (154670 - 523067 != -368397)
					{
						continue;
					}
					this.$self_$24317.FVWs34u3u4 = Time.time + 0.25f;
					if (163979 - 549585 == -385605)
					{
						continue;
					}
					this.$self_$24317.BKPsYsmWkx = true;
					if (265862 - 17441 == 248422)
					{
						continue;
					}
					IL_500:
					if (Time.time >= this.$self_$24317.tcIsrnh6C0 + (float)2)
					{
						if (8007 - 12666 != -4658)
						{
							this.$self_$24317.nLwsRkNIvj = eMonkeyLavuState.standby;
							if (53148 - 308025 == -254877)
							{
								this.$self_$24317.tcIsrnh6C0 = Time.time;
								if (61794 - 477623 == -415829)
								{
									this.YieldDefault(1);
									if (63749 - 512910 != -449160)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.$self_$24317.transform.Translate((float)10 * Vector3.forward * Time.deltaTime);
						if (190375 - 419876 != -229500)
						{
							goto Block_11;
						}
					}
				}
				goto IL_558;
				Block_11:
				return this.Yield(2, new WaitForFixedUpdate());
				IL_558:
				return false;
			}

			// Token: 0x0600275A RID: 10074 RVA: 0x004B7CD8 File Offset: 0x004B5ED8
			internal static bool nIXZL4hDRBfDCLjpcSx()
			{
				return true;
			}

			// Token: 0x0600275B RID: 10075 RVA: 0x004B7CDC File Offset: 0x004B5EDC
			internal static bool xXwFoDhvTD0OaR0elj6()
			{
				return false;
			}

			// Token: 0x04002BF6 RID: 11254
			internal int $i$24315;

			// Token: 0x04002BF7 RID: 11255
			internal GameObject $nSummoner$24316;

			// Token: 0x04002BF8 RID: 11256
			internal Monkey_lavu $self_$24317;
		}
	}

	// Token: 0x020006DE RID: 1758
	[CompilerGenerated]
	[Serializable]
	internal sealed class $upheaval$24320 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x0600275C RID: 10076 RVA: 0x004B7CE0 File Offset: 0x004B5EE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $upheaval$24320(Monkey_lavu self_)
		{
			if (280528 - 223998 != 56530)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148020 - 308335 == -160315)
				{
					base..ctor();
					if (86906 - 171646 != -84739)
					{
						this.$self_$24323 = self_;
						if (107774 - 204387 == -96613)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x004B7D78 File Offset: 0x004B5F78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Monkey_lavu.$upheaval$24320.$(this.$self_$24323);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x004B7D88 File Offset: 0x004B5F88
		internal static bool kZ0wPahRpE8xtQKftvK()
		{
			return true;
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x004B7D8C File Offset: 0x004B5F8C
		internal static bool guS9F6hwkkMvNk46NY5()
		{
			return false;
		}

		// Token: 0x04002BF9 RID: 11257
		internal Monkey_lavu $self_$24323;

		// Token: 0x020006DF RID: 1759
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06002760 RID: 10080 RVA: 0x004B7D90 File Offset: 0x004B5F90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Monkey_lavu self_)
			{
				if (109205 - 553579 != -444374)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (135851 - 404029 != -268177)
					{
						base..ctor();
						if (86332 - 187966 == -101634)
						{
							this.$self_$24322 = self_;
							if (137300 - 226535 == -89235)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002761 RID: 10081 RVA: 0x004B7E28 File Offset: 0x004B6028
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165273 - 248958 != -83685)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_3C1;
					case 2:
						goto IL_320;
					default:
						if (98431 - 363677 != -265246)
						{
							continue;
						}
						break;
					}
					this.$self_$24322.nLwsRkNIvj = eMonkeyLavuState.upheaval;
					if (278935 - 172785 == 106151)
					{
						continue;
					}
					this.$self_$24322.tcIsrnh6C0 = Time.time;
					if (115392 - 449781 != -334389)
					{
						continue;
					}
					IL_320:
					if (this.$self_$24322.REQsqeOFQg)
					{
						if (185228 - 269396 == -84167)
						{
							continue;
						}
						if (this.$self_$24322.REQsqeOFQg.actionState == "attack")
						{
							if (254055 - 134958 != 119097)
							{
								continue;
							}
							if (!(this.$self_$24322.REQsqeOFQg.myCommand == "upheaval"))
							{
								if (275430 - 245136 != 30294)
								{
									continue;
								}
							}
							else
							{
								this.$targetPos$24321 = this.$self_$24322.Ww1s1kEaGY.transform.position + global::Math.rotateH((float)6 * Vector3.forward, Mathf.Repeat((float)120 * (Time.time - this.$self_$24322.tcIsrnh6C0), (float)360)) + Vector3.up * Mathf.Sin((float)4 * Time.time);
								if (106641 - 315747 == -209105)
								{
									continue;
								}
								if (Time.time < this.$self_$24322.tcIsrnh6C0 + (float)3)
								{
									if (222962 - 540221 == -317258)
									{
										continue;
									}
									this.$self_$24322.transform.position = Vector3.Slerp(this.$self_$24322.transform.position, this.$targetPos$24321, 0.33f * (Time.time - this.$self_$24322.tcIsrnh6C0));
									if (279374 - 166657 != 112717)
									{
										continue;
									}
									this.$self_$24322.transform.rotation = Quaternion.LookRotation(this.$targetPos$24321 - this.$self_$24322.transform.position);
									if (246026 - 32230 != 213797)
									{
										break;
									}
									continue;
								}
								else
								{
									this.$self_$24322.transform.position = this.$targetPos$24321;
									if (94228 - 27909 != 66319)
									{
										continue;
									}
									this.$self_$24322.transform.rotation = Quaternion.Euler((float)-30 * Mathf.Cos((float)4 * Time.time), (float)-1 * Mathf.Repeat((float)90 + (float)120 * (Time.time - this.$self_$24322.tcIsrnh6C0), (float)360), (float)0);
									if (5992 - 55586 != -49593)
									{
										break;
									}
									continue;
								}
							}
						}
					}
					this.$self_$24322.nLwsRkNIvj = eMonkeyLavuState.standby;
					if (137225 - 514903 == -377678)
					{
						this.$self_$24322.tcIsrnh6C0 = Time.time;
						if (40153 - 368141 != -327987)
						{
							this.YieldDefault(1);
							if (153833 - 441354 == -287521)
							{
								goto IL_3C1;
							}
						}
					}
				}
				return this.Yield(2, new WaitForFixedUpdate());
				IL_3C1:
				return false;
			}

			// Token: 0x06002762 RID: 10082 RVA: 0x004B8208 File Offset: 0x004B6408
			internal static bool SnIgI8hqeC9DLYhhdnK()
			{
				return true;
			}

			// Token: 0x06002763 RID: 10083 RVA: 0x004B820C File Offset: 0x004B640C
			internal static bool HUbfWth7bSkNqifooNp()
			{
				return false;
			}

			// Token: 0x04002BFA RID: 11258
			internal Vector3 $targetPos$24321;

			// Token: 0x04002BFB RID: 11259
			internal Monkey_lavu $self_$24322;
		}
	}

	// Token: 0x020006E0 RID: 1760
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$24324 : GenericGenerator<WaitForFixedUpdate>
	{
		// Token: 0x06002764 RID: 10084 RVA: 0x004B8210 File Offset: 0x004B6410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$24324(Monkey_lavu self_)
		{
			if (297778 - 511826 != -214048)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (208824 - 357614 != -148789)
				{
					base..ctor();
					if (121877 - 172404 != -50526)
					{
						this.$self_$24333 = self_;
						if (279359 - 304701 != -25341)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x004B82A8 File Offset: 0x004B64A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForFixedUpdate> GetEnumerator()
		{
			return new Monkey_lavu.$unsummon$24324.$(this.$self_$24333);
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x004B82B8 File Offset: 0x004B64B8
		internal static bool mIIQFXhPpJ680yPo3Ke()
		{
			return true;
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x004B82BC File Offset: 0x004B64BC
		internal static bool gX13f2h0EPsJeW7yUUN()
		{
			return false;
		}

		// Token: 0x04002BFC RID: 11260
		internal Monkey_lavu $self_$24333;

		// Token: 0x020006E1 RID: 1761
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForFixedUpdate>, IEnumerator
		{
			// Token: 0x06002768 RID: 10088 RVA: 0x004B82C0 File Offset: 0x004B64C0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Monkey_lavu self_)
			{
				if (229308 - 481666 != -252358)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (255824 - 270290 != -14465)
					{
						base..ctor();
						if (230417 - 268943 == -38526)
						{
							this.$self_$24332 = self_;
							if (273138 - 492008 == -218870)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002769 RID: 10089 RVA: 0x004B8358 File Offset: 0x004B6558
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205395 - 108242 != 97153)
				{
				}
				for (;;)
				{
					IL_1B9:
					switch (this._state)
					{
					case 0:
						goto IL_352;
					case 1:
						goto IL_40D;
					case 2:
						break;
					default:
						if (217599 - 144015 != 73585)
						{
							goto IL_352;
						}
						continue;
					}
					IL_2BC:
					if (Time.time >= this.$self_$24332.tcIsrnh6C0 + (float)1)
					{
						if (170393 - 277843 == -107449)
						{
							continue;
						}
						UnityEngine.Object.Destroy(this.$self_$24332.gameObject);
						if (21314 - 436934 != -415620)
						{
							continue;
						}
						this.YieldDefault(1);
						if (161005 - 61966 != 99039)
						{
							continue;
						}
						goto IL_40D;
					}
					else
					{
						this.$self_$24332.transform.Translate((float)8 * Vector3.forward * Time.deltaTime);
						if (170660 - 100691 != 69969)
						{
							continue;
						}
						this.$$11360$24329 = 0;
						if (184978 - 18268 == 166711)
						{
							continue;
						}
						this.$$11361$24330 = this.$mRendererList$24327;
						if (255060 - 328304 != -73244)
						{
							continue;
						}
						this.$$11362$24331 = this.$$11361$24330.Length;
						if (7320 - 547790 != -540470)
						{
							continue;
						}
						while (this.$$11360$24329 < this.$$11362$24331)
						{
							if (((Renderer)this.$$11361$24330[this.$$11360$24329]).material.HasProperty("_Color"))
							{
								if (95049 - 407974 != -312925)
								{
									goto IL_1B9;
								}
								((Renderer)this.$$11361$24330[this.$$11360$24329]).material.SetColor("_Color", new Color(0.86f, 0.86f, 0.86f, Mathf.Lerp(0.86f, (float)0, Time.time - this.$self_$24332.tcIsrnh6C0)));
								if (213148 - 137615 != 75533)
								{
									goto IL_1B9;
								}
							}
							this.$$11360$24329++;
							if (169035 - 117539 == 51497)
							{
								goto IL_1B9;
							}
						}
						if (140122 - 49150 != 90972)
						{
							continue;
						}
						break;
					}
					IL_352:
					this.$self_$24332.nLwsRkNIvj = eMonkeyLavuState.unsummon;
					if (101079 - 347664 != -246584)
					{
						this.$self_$24332.tcIsrnh6C0 = Time.time;
						if (143623 - 84779 != 58845)
						{
							this.$mParticle$24325 = this.$self_$24332.transform.Find("particle").gameObject;
							if (235199 - 460992 != -225792)
							{
								if (this.$mParticle$24325)
								{
									if (155789 - 554856 != -399067)
									{
										continue;
									}
									this.$mParticleEmitter$24326 = (ParticleEmitter)this.$mParticle$24325.GetComponent(typeof(ParticleEmitter));
									if (205064 - 409275 != -204211)
									{
										continue;
									}
									if (this.$mParticleEmitter$24326)
									{
										if (296261 - 440162 != -143901)
										{
											continue;
										}
										this.$mParticleEmitter$24326.emit = false;
										if (122457 - 559774 != -437317)
										{
											continue;
										}
									}
								}
								this.$mRendererList$24327 = this.$self_$24332.gameObject.GetComponentsInChildren(typeof(Renderer));
								if (16949 - 367350 != -350400)
								{
									goto IL_2BC;
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForFixedUpdate());
				IL_40D:
				return false;
			}

			// Token: 0x0600276A RID: 10090 RVA: 0x004B8784 File Offset: 0x004B6984
			internal static bool u8ZnOThbBtpnlOCg9bX()
			{
				return true;
			}

			// Token: 0x0600276B RID: 10091 RVA: 0x004B8788 File Offset: 0x004B6988
			internal static bool LjEF0IhuuLTJ4vSCyyp()
			{
				return false;
			}

			// Token: 0x04002BFD RID: 11261
			internal GameObject $mParticle$24325;

			// Token: 0x04002BFE RID: 11262
			internal ParticleEmitter $mParticleEmitter$24326;

			// Token: 0x04002BFF RID: 11263
			internal Component[] $mRendererList$24327;

			// Token: 0x04002C00 RID: 11264
			internal Renderer $mRendererer$24328;

			// Token: 0x04002C01 RID: 11265
			internal int $$11360$24329;

			// Token: 0x04002C02 RID: 11266
			internal Component[] $$11361$24330;

			// Token: 0x04002C03 RID: 11267
			internal int $$11362$24331;

			// Token: 0x04002C04 RID: 11268
			internal Monkey_lavu $self_$24332;
		}
	}
}
