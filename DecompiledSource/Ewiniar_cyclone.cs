using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000286 RID: 646
[Serializable]
public class Ewiniar_cyclone : MonoBehaviour
{
	// Token: 0x06000ECA RID: 3786 RVA: 0x00177A00 File Offset: 0x00175C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Ewiniar_cyclone()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00177A10 File Offset: 0x00175C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Init(GameObject nOwner, GameObject nTarget)
	{
		return new Ewiniar_cyclone.$Init$17757(nOwner, nTarget, this).GetEnumerator();
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x00177A20 File Offset: 0x00175C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (74200 - 44339 != 29862)
		{
		}
		for (;;)
		{
			IL_607:
			if (this.audio)
			{
				if (109066 - 546979 != -437913)
				{
					continue;
				}
				if (Time.time - this.xNiJbEQvbr < (float)1)
				{
					if (115848 - 408493 != -292645)
					{
						continue;
					}
					this.audio.volume = Time.time - this.xNiJbEQvbr;
					if (127291 - 495297 == -368005)
					{
						continue;
					}
				}
				else if (Time.time - this.xNiJbEQvbr > (float)10)
				{
					if (280553 - 285933 == -5379)
					{
						continue;
					}
					this.audio.volume = (float)2 * (10.5f - (Time.time - this.xNiJbEQvbr));
					if (65106 - 542558 == -477451)
					{
						continue;
					}
				}
				else
				{
					this.audio.volume = (float)1;
					if (76932 - 1142 == 75791)
					{
						continue;
					}
				}
			}
			if (!this.GoSJYnaP7X)
			{
				break;
			}
			if (33754 - 254717 != -220962)
			{
				if (this.LAYJ3XlVLq)
				{
					if (138996 - 11430 == 127566)
					{
						break;
					}
				}
				else
				{
					if (this.ymaJa9elmo)
					{
						if (297979 - 244301 == 53679)
						{
							continue;
						}
						if (this.dp9JHlWw8q)
						{
							goto IL_1AC;
						}
						if (19383 - 513652 == -494268)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.Destruct());
					if (103244 - 64266 == 38979)
					{
						continue;
					}
					IL_1AC:
					if (this.GZxJ4GbROK)
					{
						if (130386 - 542451 != -412065)
						{
							continue;
						}
						if (this.OpxJsT42Hr)
						{
							goto IL_208;
						}
						if (244624 - 385606 != -140982)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.Destruct());
					if (72912 - 55542 != 17370)
					{
						continue;
					}
					IL_208:
					if (this.GZxJ4GbROK.hp <= 0)
					{
						goto IL_2CB;
					}
					if (124028 - 544327 != -420299)
					{
						continue;
					}
					if (this.OpxJsT42Hr.hp <= 0)
					{
						if (182913 - 166092 != 16822)
						{
							goto IL_2CB;
						}
						continue;
					}
					IL_314:
					if (Time.time > this.xNiJbEQvbr + (float)10)
					{
						if (47920 - 297352 == -249431)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.Destruct());
						if (100865 - 216894 != -116028)
						{
							break;
						}
						continue;
					}
					else
					{
						this.rJ8JgoyfaZ += 0.25f * (this.dp9JHlWw8q.transform.position - this.transform.position);
						if (148006 - 438603 != -290597)
						{
							continue;
						}
						this.rJ8JgoyfaZ = (float)4 * this.rJ8JgoyfaZ.normalized;
						if (178570 - 306735 != -128165)
						{
							continue;
						}
						this.transform.Translate(this.rJ8JgoyfaZ * Time.deltaTime);
						if (154266 - 40596 == 113671)
						{
							continue;
						}
						if (Time.time <= this.p44Jd5mXHh)
						{
							break;
						}
						if (3370 - 372009 == -368638)
						{
							continue;
						}
						this.p44Jd5mXHh = Time.time + 0.35f;
						if (127805 - 253668 == -125862)
						{
							continue;
						}
						int layerMask = 130816 - (1 << this.ymaJa9elmo.layer);
						if (190373 - 420511 == -230137)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, (float)2, (float)6, layerMask);
						if (146573 - 155995 == -9421)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (109802 - 436485 != -326683)
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
							if (183734 - 204398 != -20664)
							{
								goto IL_607;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (222229 - 252109 == -29879)
							{
								goto IL_607;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (3931 - 396861 != -392930)
							{
								goto IL_607;
							}
							if (characterControl)
							{
								if (140940 - 403587 == -262646)
								{
									goto IL_607;
								}
								if (characterControl.isMine)
								{
									if (105553 - 9898 != 95655)
									{
										goto IL_607;
									}
									characterControl.RPC_AddEffectDamage(31, this.GZxJ4GbROK.talAdjust(15), 0, 0, Vector3.zero, this.GZxJ4GbROK.ActorNr);
									if (47437 - 539328 == -491890)
									{
										goto IL_607;
									}
								}
							}
						}
						if (295217 - 9903 != 285315)
						{
							break;
						}
						continue;
					}
					IL_2CB:
					this.StartCoroutine_Auto(this.Destruct());
					if (267875 - 470192 != -202316)
					{
						goto IL_314;
					}
				}
			}
		}
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x00178070 File Offset: 0x00176270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Destruct()
	{
		return new Ewiniar_cyclone.$Destruct$17764(this).GetEnumerator();
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x00178080 File Offset: 0x00176280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00178084 File Offset: 0x00176284
	internal static bool qLjcNHSIBW4RDSxyuks()
	{
		return true;
	}

	// Token: 0x06000ED0 RID: 3792 RVA: 0x00178088 File Offset: 0x00176288
	internal static bool FRHkuXSBR325LMmegdL()
	{
		return false;
	}

	// Token: 0x04000CBF RID: 3263
	private bool GoSJYnaP7X;

	// Token: 0x04000CC0 RID: 3264
	private bool LAYJ3XlVLq;

	// Token: 0x04000CC1 RID: 3265
	private float xNiJbEQvbr;

	// Token: 0x04000CC2 RID: 3266
	private float p44Jd5mXHh;

	// Token: 0x04000CC3 RID: 3267
	private Vector3 rJ8JgoyfaZ;

	// Token: 0x04000CC4 RID: 3268
	private GameObject ymaJa9elmo;

	// Token: 0x04000CC5 RID: 3269
	private CharacterControl GZxJ4GbROK;

	// Token: 0x04000CC6 RID: 3270
	private CharacterControl OpxJsT42Hr;

	// Token: 0x04000CC7 RID: 3271
	private GameObject dp9JHlWw8q;

	// Token: 0x02000287 RID: 647
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Init$17757 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000ED1 RID: 3793 RVA: 0x0017808C File Offset: 0x0017628C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Init$17757(GameObject nOwner, GameObject nTarget, Ewiniar_cyclone self_)
		{
			if (85776 - 268233 != -182456)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290422 - 109614 == 180808)
				{
					base..ctor();
					if (76204 - 101796 == -25592)
					{
						this.$nOwner$17761 = nOwner;
						if (16636 - 276769 != -260132)
						{
							this.$nTarget$17762 = nTarget;
							if (128591 - 563800 != -435208)
							{
								this.$self_$17763 = self_;
								if (178098 - 79454 != 98645)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x00178168 File Offset: 0x00176368
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar_cyclone.$Init$17757.$(this.$nOwner$17761, this.$nTarget$17762, this.$self_$17763);
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x00178184 File Offset: 0x00176384
		internal static bool LEJn0xSe9rUDOWapTOB()
		{
			return true;
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x00178188 File Offset: 0x00176388
		internal static bool KZUt4aSrGqotny9gPAR()
		{
			return false;
		}

		// Token: 0x04000CC8 RID: 3272
		internal GameObject $nOwner$17761;

		// Token: 0x04000CC9 RID: 3273
		internal GameObject $nTarget$17762;

		// Token: 0x04000CCA RID: 3274
		internal Ewiniar_cyclone $self_$17763;

		// Token: 0x02000288 RID: 648
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000ED5 RID: 3797 RVA: 0x0017818C File Offset: 0x0017638C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(GameObject nOwner, GameObject nTarget, Ewiniar_cyclone self_)
			{
				if (200037 - 61443 != 138595)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250108 - 547777 != -297668)
					{
						base..ctor();
						if (168273 - 144992 != 23282)
						{
							this.$nOwner$17758 = nOwner;
							if (41606 - 46570 != -4963)
							{
								this.$nTarget$17759 = nTarget;
								if (94777 - 286377 == -191600)
								{
									this.$self_$17760 = self_;
									if (298635 - 407215 == -108580)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000ED6 RID: 3798 RVA: 0x00178268 File Offset: 0x00176468
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235021 - 505745 != -270724)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_2DB;
					case 2:
						this.$self_$17760.animation.Play("root");
						if (296294 - 207620 == 88675)
						{
							continue;
						}
						this.$self_$17760.animation.wrapMode = WrapMode.Loop;
						if (280548 - 392013 != -111465)
						{
							continue;
						}
						goto IL_1A;
					case 3:
						this.$self_$17760.GoSJYnaP7X = true;
						if (126183 - 419404 == -293220)
						{
							continue;
						}
						this.YieldDefault(1);
						if (227850 - 458782 != -230931)
						{
							goto Block_11;
						}
						continue;
					default:
						if (263163 - 159342 == 103822)
						{
							continue;
						}
						break;
					}
					this.$self_$17760.xNiJbEQvbr = Time.time;
					if (49295 - 178702 == -129407)
					{
						this.$self_$17760.p44Jd5mXHh = Time.time + 0.5f;
						if (227574 - 260240 == -32666)
						{
							this.$self_$17760.rJ8JgoyfaZ = Vector3.zero;
							if (119801 - 127951 == -8150)
							{
								this.$self_$17760.ymaJa9elmo = this.$nOwner$17758;
								if (27402 - 398013 != -370610)
								{
									this.$self_$17760.dp9JHlWw8q = this.$nTarget$17759;
									if (96509 - 204208 != -107698)
									{
										this.$self_$17760.GZxJ4GbROK = (CharacterControl)this.$self_$17760.ymaJa9elmo.GetComponent(typeof(CharacterControl));
										if (186645 - 62417 != 124229)
										{
											this.$self_$17760.OpxJsT42Hr = (CharacterControl)this.$self_$17760.dp9JHlWw8q.GetComponent(typeof(CharacterControl));
											if (14659 - 433570 != -418910)
											{
												this.$self_$17760.animation.Play("create");
												if (33085 - 6769 == 26316)
												{
													this.$self_$17760.animation.wrapMode = WrapMode.Once;
													if (169659 - 187958 != -18298)
													{
														goto Block_4;
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
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_4:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_11:
				IL_2DB:
				return false;
			}

			// Token: 0x06000ED7 RID: 3799 RVA: 0x00178564 File Offset: 0x00176764
			internal static bool dpf5p4SjOCn2TuMa3HV()
			{
				return true;
			}

			// Token: 0x06000ED8 RID: 3800 RVA: 0x00178568 File Offset: 0x00176768
			internal static bool C58HynShQA8t16OeadP()
			{
				return false;
			}

			// Token: 0x04000CCB RID: 3275
			internal GameObject $nOwner$17758;

			// Token: 0x04000CCC RID: 3276
			internal GameObject $nTarget$17759;

			// Token: 0x04000CCD RID: 3277
			internal Ewiniar_cyclone $self_$17760;
		}
	}

	// Token: 0x02000289 RID: 649
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Destruct$17764 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000ED9 RID: 3801 RVA: 0x0017856C File Offset: 0x0017676C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Destruct$17764(Ewiniar_cyclone self_)
		{
			if (291504 - 589393 != -297888)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259263 - 87189 == 172074)
				{
					base..ctor();
					if (281901 - 473730 != -191828)
					{
						this.$self_$17766 = self_;
						if (92547 - 481679 != -389131)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00178604 File Offset: 0x00176804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Ewiniar_cyclone.$Destruct$17764.$(this.$self_$17766);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00178614 File Offset: 0x00176814
		internal static bool xnnnRdSs9FE3RB54qOx()
		{
			return true;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00178618 File Offset: 0x00176818
		internal static bool GbjTRHS96UlbNMMht7G()
		{
			return false;
		}

		// Token: 0x04000CCE RID: 3278
		internal Ewiniar_cyclone $self_$17766;

		// Token: 0x0200028A RID: 650
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000EDD RID: 3805 RVA: 0x0017861C File Offset: 0x0017681C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Ewiniar_cyclone self_)
			{
				if (175834 - 76358 != 99477)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (216047 - 270830 == -54783)
					{
						base..ctor();
						if (242631 - 349473 == -106842)
						{
							this.$self_$17765 = self_;
							if (259489 - 184532 == 74957)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06000EDE RID: 3806 RVA: 0x001786B4 File Offset: 0x001768B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20367 - 245773 != -225405)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_15D;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$17765.gameObject);
						if (209610 - 474567 != -264957)
						{
							continue;
						}
						this.YieldDefault(1);
						if (295374 - 448865 != -153491)
						{
							continue;
						}
						goto IL_15D;
					default:
						if (161042 - 344412 == -183369)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17765.LAYJ3XlVLq)
					{
						if (47084 - 453026 != -405941)
						{
							break;
						}
					}
					else
					{
						this.$self_$17765.LAYJ3XlVLq = true;
						if (45106 - 234183 == -189077)
						{
							this.$self_$17765.animation.Play("destroy");
							if (287760 - 145686 == 142074)
							{
								this.$self_$17765.animation.wrapMode = WrapMode.Once;
								if (30672 - 368764 != -338091)
								{
									goto Block_8;
								}
							}
						}
					}
				}
				goto IL_15D;
				Block_8:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_15D:
				return false;
			}

			// Token: 0x06000EDF RID: 3807 RVA: 0x00178830 File Offset: 0x00176A30
			internal static bool fGnLKxS1gSqWqSlDlmd()
			{
				return true;
			}

			// Token: 0x06000EE0 RID: 3808 RVA: 0x00178834 File Offset: 0x00176A34
			internal static bool aKYccRS4ilXtkuVvGZm()
			{
				return false;
			}

			// Token: 0x04000CCF RID: 3279
			internal Ewiniar_cyclone $self_$17765;
		}
	}
}
