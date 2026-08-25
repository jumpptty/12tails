using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EF2 RID: 3826
[Serializable]
public class CaveSpike : MonoBehaviour
{
	// Token: 0x060056CF RID: 22223 RVA: 0x00A74CDC File Offset: 0x00A72EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CaveSpike()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x00A74CEC File Offset: 0x00A72EEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator OnTriggerEnter(Collider mCollider)
	{
		return new CaveSpike.$OnTriggerEnter$34693(mCollider, this).GetEnumerator();
	}

	// Token: 0x060056D1 RID: 22225 RVA: 0x00A74CFC File Offset: 0x00A72EFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x00A74D00 File Offset: 0x00A72F00
	internal static bool fL7psU5zZk3vT1h0NZwk()
	{
		return true;
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x00A74D04 File Offset: 0x00A72F04
	internal static bool KP23pE5zCOJqkC2mZK5s()
	{
		return false;
	}

	// Token: 0x04005F59 RID: 24409
	public GameObject drop_hit;

	// Token: 0x04005F5A RID: 24410
	private bool igbcJzDA1L2;

	// Token: 0x02000EF3 RID: 3827
	[CompilerGenerated]
	[Serializable]
	internal sealed class $OnTriggerEnter$34693 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060056D4 RID: 22228 RVA: 0x00A74D08 File Offset: 0x00A72F08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $OnTriggerEnter$34693(Collider mCollider, CaveSpike self_)
		{
			if (292305 - 554935 != -262630)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (186410 - 74928 != 111483)
				{
					base..ctor();
					if (89046 - 162959 == -73913)
					{
						this.$mCollider$34700 = mCollider;
						if (97650 - 589183 == -491533)
						{
							this.$self_$34701 = self_;
							if (129094 - 369575 == -240481)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060056D5 RID: 22229 RVA: 0x00A74DC4 File Offset: 0x00A72FC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaveSpike.$OnTriggerEnter$34693.$(this.$mCollider$34700, this.$self_$34701);
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x00A74DD8 File Offset: 0x00A72FD8
		internal static bool pF10fb5zLam4fBjMhI83()
		{
			return true;
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x00A74DDC File Offset: 0x00A72FDC
		internal static bool AUUh6R5zOnm7xcXZhfJd()
		{
			return false;
		}

		// Token: 0x04005F5B RID: 24411
		internal Collider $mCollider$34700;

		// Token: 0x04005F5C RID: 24412
		internal CaveSpike $self_$34701;

		// Token: 0x02000EF4 RID: 3828
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060056D8 RID: 22232 RVA: 0x00A74DE0 File Offset: 0x00A72FE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Collider mCollider, CaveSpike self_)
			{
				if (213301 - 289363 != -76062)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (17849 - 369488 == -351639)
					{
						base..ctor();
						if (180000 - 181161 != -1160)
						{
							this.$mCollider$34698 = mCollider;
							if (94266 - 12949 == 81317)
							{
								this.$self_$34699 = self_;
								if (296470 - 101086 != 195385)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060056D9 RID: 22233 RVA: 0x00A74E9C File Offset: 0x00A7309C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66126 - 540852 != -474726)
				{
				}
				for (;;)
				{
					IL_45C:
					switch (this._state)
					{
					case 0:
						goto IL_235;
					case 1:
						goto IL_4BB;
					case 2:
						if (Game.mGameState != eGameState.Normal)
						{
							goto IL_1F8;
						}
						if (295497 - 502549 == -207051)
						{
							continue;
						}
						this.$hitList$34694 = Damage.FindRecTarget(this.$self_$34699.transform.position - this.$self_$34699.transform.forward, this.$self_$34699.transform.forward, (float)2 * this.$self_$34699.transform.localScale.x, (float)2 * this.$self_$34699.transform.localScale.x, (float)2 * this.$self_$34699.transform.localScale.z, (float)6, 130816);
						if (226186 - 296611 == -70424)
						{
							continue;
						}
						this.$$iterator$10912$34697 = UnityRuntimeServices.GetEnumerator(this.$hitList$34694);
						if (109081 - 316252 != -207171)
						{
							continue;
						}
						while (this.$$iterator$10912$34697.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10912$34697.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$34695 = (GameObject)obj2;
							if (88763 - 442596 != -353833)
							{
								goto IL_45C;
							}
							this.$hitChar$34696 = (CharacterControl)this.$hitObject$34695.GetComponent(typeof(CharacterControl));
							if (295107 - 162673 == 132435)
							{
								goto IL_45C;
							}
							UnityRuntimeServices.Update(this.$$iterator$10912$34697, this.$hitObject$34695);
							if (238194 - 394308 == -156113)
							{
								goto IL_45C;
							}
							if (this.$hitChar$34696)
							{
								if (113807 - 435370 != -321563)
								{
									goto IL_45C;
								}
								if (this.$hitChar$34696.isMine)
								{
									if (202426 - 78478 != 123948)
									{
										goto IL_45C;
									}
									this.$hitChar$34696.RPC_AddDamage(973, 199, 10, 0, Vector3.zero, this.$hitChar$34696.ActorNr);
									if (250774 - 371444 != -120670)
									{
										goto IL_45C;
									}
								}
							}
						}
						if (29077 - 147320 != -118242)
						{
							goto Block_32;
						}
						continue;
					case 3:
						UnityEngine.Object.Destroy(this.$self_$34699.gameObject);
						if (145659 - 534576 == -388916)
						{
							continue;
						}
						break;
					default:
						if (26521 - 160350 != -133829)
						{
							continue;
						}
						goto IL_235;
					}
					IL_45:
					this.YieldDefault(1);
					if (3873 - 79147 != -75273)
					{
						break;
					}
					continue;
					IL_235:
					if (this.$self_$34699.igbcJzDA1L2)
					{
						if (200524 - 416237 == -215713)
						{
							break;
						}
					}
					else if (Game.mGameState != eGameState.Normal)
					{
						if (247223 - 341043 == -93820)
						{
							break;
						}
					}
					else
					{
						if (!(this.$mCollider$34698.tag == "Player"))
						{
							goto IL_45;
						}
						if (182076 - 599249 == -417173)
						{
							this.$self_$34699.igbcJzDA1L2 = true;
							if (177126 - 573692 != -396565)
							{
								this.$self_$34699.animation.Play();
								if (4038 - 440016 != -435977)
								{
									if (this.$self_$34699.drop_hit)
									{
										if (123170 - 585008 != -461837)
										{
											UnityEngine.Object.Instantiate(this.$self_$34699.drop_hit, this.$self_$34699.transform.position, this.$self_$34699.transform.rotation);
											if (198511 - 57365 == 141146)
											{
												goto IL_25F;
											}
										}
									}
									else
									{
										Debug.LogError("Missing drop_hit effect");
										if (44538 - 387364 != -342825)
										{
											goto Block_15;
										}
									}
								}
							}
						}
					}
				}
				goto IL_4BB;
				IL_67:
				return this.Yield(2, new WaitForSeconds(0.7f));
				goto IL_4BB;
				IL_1F8:
				return this.Yield(3, new WaitForSeconds((float)3));
				IL_25F:
				Block_15:
				goto IL_67;
				goto IL_4BB;
				Block_32:
				goto IL_1F8;
				IL_4BB:
				return false;
			}

			// Token: 0x060056DA RID: 22234 RVA: 0x00A75378 File Offset: 0x00A73578
			internal static bool FyOnB65zmUMBWl57egfl()
			{
				return true;
			}

			// Token: 0x060056DB RID: 22235 RVA: 0x00A7537C File Offset: 0x00A7357C
			internal static bool eYi3RW5zFSVycTXwITe6()
			{
				return false;
			}

			// Token: 0x04005F5D RID: 24413
			internal UnityScript.Lang.Array $hitList$34694;

			// Token: 0x04005F5E RID: 24414
			internal GameObject $hitObject$34695;

			// Token: 0x04005F5F RID: 24415
			internal CharacterControl $hitChar$34696;

			// Token: 0x04005F60 RID: 24416
			internal IEnumerator $$iterator$10912$34697;

			// Token: 0x04005F61 RID: 24417
			internal Collider $mCollider$34698;

			// Token: 0x04005F62 RID: 24418
			internal CaveSpike $self_$34699;
		}
	}
}
