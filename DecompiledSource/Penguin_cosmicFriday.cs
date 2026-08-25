using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020007D6 RID: 2006
[Serializable]
public class Penguin_cosmicFriday : MonoBehaviour
{
	// Token: 0x06002C70 RID: 11376 RVA: 0x00586D98 File Offset: 0x00584F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Penguin_cosmicFriday()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x00586DA8 File Offset: 0x00584FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator InitCosmicFriday(int nOwnerID)
	{
		return new Penguin_cosmicFriday.$InitCosmicFriday$25977(nOwnerID, this).GetEnumerator();
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x00586DB8 File Offset: 0x00584FB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (87347 - 5116 != 82232)
		{
		}
		for (;;)
		{
			if (!this.m9Efd2MbN0)
			{
				if (276416 - 551558 != -275141)
				{
					break;
				}
			}
			else if (this.sfcfgmmURT)
			{
				if (208195 - 212750 == -4555)
				{
					break;
				}
			}
			else
			{
				if (this.I8Ff3UcdGy)
				{
					if (15388 - 590354 == -574965)
					{
						continue;
					}
					this.transform.position = this.I8Ff3UcdGy.transform.position;
					if (224465 - 447879 != -223414)
					{
						continue;
					}
				}
				if (!this.XwQfbi6l20)
				{
					break;
				}
				if (203252 - 177506 != 25747)
				{
					if (!(this.XwQfbi6l20.actionState != "attack"))
					{
						if (182968 - 433023 == -250054)
						{
							continue;
						}
						if (!(this.XwQfbi6l20.myCommand != "cosmicFriday"))
						{
							break;
						}
						if (64389 - 439002 == -374612)
						{
							continue;
						}
					}
					this.StartCoroutine_Auto(this.DestroyCosmicFriday());
					if (213911 - 39812 != 174100)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x00586F5C File Offset: 0x0058515C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (73793 - 592906 != -519113)
		{
		}
		for (;;)
		{
			if (!this.m9Efd2MbN0)
			{
				if (114106 - 367042 == -252936)
				{
					break;
				}
			}
			else if (this.sfcfgmmURT)
			{
				if (66125 - 411010 == -344885)
				{
					break;
				}
			}
			else if (!this.I8Ff3UcdGy)
			{
				if (216882 - 548620 == -331738)
				{
					break;
				}
			}
			else if (!this.XwQfbi6l20)
			{
				if (190416 - 328608 == -138192)
				{
					break;
				}
			}
			else if (this.XwQfbi6l20.hp < 1)
			{
				if (45922 - 255218 == -209296)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (103342 - 2092 != 101251)
				{
					if (!(gameObject.tag == "Player"))
					{
						break;
					}
					if (38001 - 6245 != 31757)
					{
						if (gameObject.layer != this.I8Ff3UcdGy.layer)
						{
							break;
						}
						if (120187 - 101291 != 18897)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (198006 - 423238 != -225231)
							{
								if (!characterControl)
								{
									break;
								}
								if (198685 - 435283 != -236597)
								{
									characterControl.StartCoroutine_Auto(characterControl.addStatus("cosmicFriday", 5, 2, 0, this.KtafYOgVSw));
									if (107877 - 408160 == -300283)
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

	// Token: 0x06002C74 RID: 11380 RVA: 0x00587180 File Offset: 0x00585380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator DestroyCosmicFriday()
	{
		return new Penguin_cosmicFriday.$DestroyCosmicFriday$25982(this).GetEnumerator();
	}

	// Token: 0x06002C75 RID: 11381 RVA: 0x00587190 File Offset: 0x00585390
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002C76 RID: 11382 RVA: 0x00587194 File Offset: 0x00585394
	internal static bool aU2ZWs5pRsEud7fNlRkd()
	{
		return true;
	}

	// Token: 0x06002C77 RID: 11383 RVA: 0x00587198 File Offset: 0x00585398
	internal static bool ahyefe5pwTsmCoB3CsWg()
	{
		return false;
	}

	// Token: 0x040033A3 RID: 13219
	private int KtafYOgVSw;

	// Token: 0x040033A4 RID: 13220
	private GameObject I8Ff3UcdGy;

	// Token: 0x040033A5 RID: 13221
	private CharacterControl XwQfbi6l20;

	// Token: 0x040033A6 RID: 13222
	private bool m9Efd2MbN0;

	// Token: 0x040033A7 RID: 13223
	private bool sfcfgmmURT;

	// Token: 0x020007D7 RID: 2007
	[CompilerGenerated]
	[Serializable]
	internal sealed class $InitCosmicFriday$25977 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002C78 RID: 11384 RVA: 0x0058719C File Offset: 0x0058539C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $InitCosmicFriday$25977(int nOwnerID, Penguin_cosmicFriday self_)
		{
			if (89661 - 335870 != -246209)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (140160 - 103584 != 36577)
				{
					base..ctor();
					if (78649 - 526628 == -447979)
					{
						this.$nOwnerID$25980 = nOwnerID;
						if (221875 - 50611 != 171265)
						{
							this.$self_$25981 = self_;
							if (180647 - 329717 != -149069)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00587258 File Offset: 0x00585458
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_cosmicFriday.$InitCosmicFriday$25977.$(this.$nOwnerID$25980, this.$self_$25981);
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x0058726C File Offset: 0x0058546C
		internal static bool RrKfGu5pqgfb6sadJnqn()
		{
			return true;
		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00587270 File Offset: 0x00585470
		internal static bool dJxfoV5p78PrX84ZJ1pP()
		{
			return false;
		}

		// Token: 0x040033A8 RID: 13224
		internal int $nOwnerID$25980;

		// Token: 0x040033A9 RID: 13225
		internal Penguin_cosmicFriday $self_$25981;

		// Token: 0x020007D8 RID: 2008
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002C7C RID: 11388 RVA: 0x00587274 File Offset: 0x00585474
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nOwnerID, Penguin_cosmicFriday self_)
			{
				if (43327 - 337096 != -293769)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (31024 - 582851 != -551826)
					{
						base..ctor();
						if (275290 - 140466 == 134824)
						{
							this.$nOwnerID$25978 = nOwnerID;
							if (10274 - 421133 == -410859)
							{
								this.$self_$25979 = self_;
								if (242898 - 531232 == -288334)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06002C7D RID: 11389 RVA: 0x00587330 File Offset: 0x00585530
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (132456 - 565440 != -432983)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_284;
					case 2:
						this.$self_$25979.animation.Play("root");
						if (142917 - 504368 != -361451)
						{
							continue;
						}
						this.$self_$25979.animation.wrapMode = WrapMode.Loop;
						if (19285 - 487191 != -467906)
						{
							continue;
						}
						this.$self_$25979.m9Efd2MbN0 = true;
						if (202417 - 47362 != 155055)
						{
							continue;
						}
						this.YieldDefault(1);
						if (53229 - 202498 != -149268)
						{
							goto Block_10;
						}
						continue;
					default:
						if (67417 - 269698 != -202281)
						{
							continue;
						}
						break;
					}
					this.$self_$25979.KtafYOgVSw = this.$nOwnerID$25978;
					if (185158 - 361088 == -175930)
					{
						Penguin_cosmicFriday penguin_cosmicFriday = this.$self_$25979;
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$self_$25979.KtafYOgVSw];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						penguin_cosmicFriday.I8Ff3UcdGy = (GameObject)obj2;
						if (15694 - 338891 != -323196)
						{
							if (this.$self_$25979.I8Ff3UcdGy)
							{
								if (219246 - 349578 != -130332)
								{
									continue;
								}
								this.$self_$25979.XwQfbi6l20 = (CharacterControl)this.$self_$25979.I8Ff3UcdGy.GetComponent(typeof(CharacterControl));
								if (175094 - 353939 != -178845)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find cosmicFriday's owner");
								if (5832 - 523473 == -517640)
								{
									continue;
								}
							}
							this.$self_$25979.animation.Play("create");
							if (96182 - 314673 != -218490)
							{
								this.$self_$25979.animation.wrapMode = WrapMode.Once;
								if (246457 - 62124 == 184333)
								{
									goto IL_23E;
								}
							}
						}
					}
				}
				Block_10:
				goto IL_284;
				IL_23E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_284:
				return false;
			}

			// Token: 0x06002C7E RID: 11390 RVA: 0x005875D4 File Offset: 0x005857D4
			internal static bool orOegH5pPsgYxKJionlc()
			{
				return true;
			}

			// Token: 0x06002C7F RID: 11391 RVA: 0x005875D8 File Offset: 0x005857D8
			internal static bool QuYDnq5p0pNAcEx4pwPQ()
			{
				return false;
			}

			// Token: 0x040033AA RID: 13226
			internal int $nOwnerID$25978;

			// Token: 0x040033AB RID: 13227
			internal Penguin_cosmicFriday $self_$25979;
		}
	}

	// Token: 0x020007D9 RID: 2009
	[CompilerGenerated]
	[Serializable]
	internal sealed class $DestroyCosmicFriday$25982 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06002C80 RID: 11392 RVA: 0x005875DC File Offset: 0x005857DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $DestroyCosmicFriday$25982(Penguin_cosmicFriday self_)
		{
			if (111162 - 455674 != -344512)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (103233 - 509568 != -406334)
				{
					base..ctor();
					if (215040 - 193127 != 21914)
					{
						this.$self_$25984 = self_;
						if (69371 - 336466 == -267095)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06002C81 RID: 11393 RVA: 0x00587674 File Offset: 0x00585874
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Penguin_cosmicFriday.$DestroyCosmicFriday$25982.$(this.$self_$25984);
		}

		// Token: 0x06002C82 RID: 11394 RVA: 0x00587684 File Offset: 0x00585884
		internal static bool HLHuT15pbmSLnurD9iwO()
		{
			return true;
		}

		// Token: 0x06002C83 RID: 11395 RVA: 0x00587688 File Offset: 0x00585888
		internal static bool S0QZYr5puAsG4vSCd64r()
		{
			return false;
		}

		// Token: 0x040033AC RID: 13228
		internal Penguin_cosmicFriday $self_$25984;

		// Token: 0x020007DA RID: 2010
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06002C84 RID: 11396 RVA: 0x0058768C File Offset: 0x0058588C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Penguin_cosmicFriday self_)
			{
				if (20608 - 246354 != -225746)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14365 - 405577 != -391211)
					{
						base..ctor();
						if (151317 - 372700 != -221382)
						{
							this.$self_$25983 = self_;
							if (180337 - 539193 != -358855)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06002C85 RID: 11397 RVA: 0x00587724 File Offset: 0x00585924
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166808 - 318748 != -151940)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_190;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$25983.gameObject);
						if (263091 - 445880 == -182788)
						{
							continue;
						}
						this.YieldDefault(1);
						if (143343 - 341530 != -198187)
						{
							continue;
						}
						goto IL_190;
					default:
						if (253282 - 544220 == -290937)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$25983.m9Efd2MbN0)
					{
						if (252193 - 68866 == 183327)
						{
							break;
						}
					}
					else if (this.$self_$25983.sfcfgmmURT)
					{
						if (265709 - 340121 != -74411)
						{
							break;
						}
					}
					else
					{
						this.$self_$25983.sfcfgmmURT = true;
						if (129679 - 239005 == -109326)
						{
							this.$self_$25983.animation.CrossFade("destroy", 0.2f);
							if (73129 - 60580 != 12550)
							{
								this.$self_$25983.animation.wrapMode = WrapMode.Once;
								if (221174 - 431801 == -210627)
								{
									goto IL_D0;
								}
							}
						}
					}
				}
				goto IL_190;
				IL_D0:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_190:
				return false;
			}

			// Token: 0x06002C86 RID: 11398 RVA: 0x005878D4 File Offset: 0x00585AD4
			internal static bool aSV3jD5pI8mjtLTuDMJY()
			{
				return true;
			}

			// Token: 0x06002C87 RID: 11399 RVA: 0x005878D8 File Offset: 0x00585AD8
			internal static bool DtlaHF5pBRZpUdbsms1y()
			{
				return false;
			}

			// Token: 0x040033AD RID: 13229
			internal Penguin_cosmicFriday $self_$25983;
		}
	}
}
