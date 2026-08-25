using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000646 RID: 1606
[Serializable]
public class Chameleon_needlePrison : MonoBehaviour
{
	// Token: 0x06002429 RID: 9257 RVA: 0x00445E94 File Offset: 0x00444094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Chameleon_needlePrison()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600242A RID: 9258 RVA: 0x00445EA4 File Offset: 0x004440A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator Init(float nRadius)
	{
		return new Chameleon_needlePrison.$Init$23385(nRadius, this).GetEnumerator();
	}

	// Token: 0x0600242B RID: 9259 RVA: 0x00445EB4 File Offset: 0x004440B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600242C RID: 9260 RVA: 0x00445EB8 File Offset: 0x004440B8
	internal static bool PuoLDeIbsjoP0BeAffB()
	{
		return true;
	}

	// Token: 0x0600242D RID: 9261 RVA: 0x00445EBC File Offset: 0x004440BC
	internal static bool grwlA8Iu7FFd8oifBeg()
	{
		return false;
	}

	// Token: 0x04002740 RID: 10048
	public GameObject mPrisonArrow;

	// Token: 0x02000647 RID: 1607
	[CompilerGenerated]
	[Serializable]
	internal sealed class $Init$23385 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600242E RID: 9262 RVA: 0x00445EC0 File Offset: 0x004440C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $Init$23385(float nRadius, Chameleon_needlePrison self_)
		{
			if (171385 - 408130 != -236744)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (183558 - 569445 == -385887)
				{
					base..ctor();
					if (54029 - 387265 != -333235)
					{
						this.$nRadius$23391 = nRadius;
						if (12548 - 571639 == -559091)
						{
							this.$self_$23392 = self_;
							if (130709 - 487484 == -356775)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00445F7C File Offset: 0x0044417C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Chameleon_needlePrison.$Init$23385.$(this.$nRadius$23391, this.$self_$23392);
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00445F90 File Offset: 0x00444190
		internal static bool dvgOUIIIMsKpDpmAAgL()
		{
			return true;
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00445F94 File Offset: 0x00444194
		internal static bool QqCrbYIBChM90r4V2FS()
		{
			return false;
		}

		// Token: 0x04002741 RID: 10049
		internal float $nRadius$23391;

		// Token: 0x04002742 RID: 10050
		internal Chameleon_needlePrison $self_$23392;

		// Token: 0x02000648 RID: 1608
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002432 RID: 9266 RVA: 0x00445F98 File Offset: 0x00444198
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float nRadius, Chameleon_needlePrison self_)
			{
				if (99274 - 338648 != -239374)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (205782 - 182228 == 23554)
					{
						base..ctor();
						if (44584 - 168175 != -123590)
						{
							this.$nRadius$23389 = nRadius;
							if (238108 - 414649 != -176540)
							{
								this.$self_$23390 = self_;
								if (166467 - 134571 == 31896)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06002433 RID: 9267 RVA: 0x00446054 File Offset: 0x00444254
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (24564 - 230917 != -206352)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_173;
					case 1:
						goto IL_1C9;
					case 2:
						this.$i$23386++;
						if (218196 - 218068 != 128)
						{
							continue;
						}
						break;
					default:
						if (76314 - 536336 != -460022)
						{
							continue;
						}
						goto IL_173;
					}
					IL_C9:
					if (this.$i$23386 >= 16)
					{
						if (209675 - 318692 == -109016)
						{
							continue;
						}
						this.YieldDefault(1);
						if (148405 - 403872 != -255467)
						{
							continue;
						}
						goto IL_1C9;
					}
					else
					{
						this.$mNeedlePrisonPos$23387 = this.$self_$23390.transform.position + global::Math.rotateH(this.$nRadius$23389 * Vector3.forward, (float)this.$i$23386 * 67.5f);
						if (256998 - 27274 == 229725)
						{
							continue;
						}
						this.$mNeedlePrison$23388 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$23390.mPrisonArrow, this.$mNeedlePrisonPos$23387, Quaternion.LookRotation(Vector3.up));
						if (270347 - 178377 == 91971)
						{
							continue;
						}
						this.$mNeedlePrison$23388.transform.parent = this.$self_$23390.transform;
						if (9804 - 295998 != -286193)
						{
							break;
						}
						continue;
					}
					IL_173:
					this.$i$23386 = 0;
					if (252982 - 260545 == -7563)
					{
						goto IL_C9;
					}
				}
				return this.Yield(2, new WaitForSeconds(0.05f));
				IL_1C9:
				return false;
			}

			// Token: 0x06002434 RID: 9268 RVA: 0x0044623C File Offset: 0x0044443C
			internal static bool EpmSCdIeYT2TJbjmhVr()
			{
				return true;
			}

			// Token: 0x06002435 RID: 9269 RVA: 0x00446240 File Offset: 0x00444440
			internal static bool KDDUIKIrfdfFsMO3SPc()
			{
				return false;
			}

			// Token: 0x04002743 RID: 10051
			internal int $i$23386;

			// Token: 0x04002744 RID: 10052
			internal Vector3 $mNeedlePrisonPos$23387;

			// Token: 0x04002745 RID: 10053
			internal GameObject $mNeedlePrison$23388;

			// Token: 0x04002746 RID: 10054
			internal float $nRadius$23389;

			// Token: 0x04002747 RID: 10055
			internal Chameleon_needlePrison $self_$23390;
		}
	}
}
