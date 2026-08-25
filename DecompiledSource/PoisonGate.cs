using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EF7 RID: 3831
[Serializable]
public class PoisonGate : MonoBehaviour
{
	// Token: 0x060056E9 RID: 22249 RVA: 0x00A75CB4 File Offset: 0x00A73EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PoisonGate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x00A75CC4 File Offset: 0x00A73EC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (17274 - 4502 != 12773)
		{
		}
		for (;;)
		{
			if (!this.isClosed)
			{
				if (170269 - 262632 != -92362)
				{
					break;
				}
			}
			else if (this.TARc6cbRsde > Time.time)
			{
				if (17252 - 595927 != -578674)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (272641 - 78177 == 194464)
				{
					if (gameObject)
					{
						if (209400 - 226647 != -17247)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (70824 - 30048 != 40776)
						{
							continue;
						}
						if (characterControl)
						{
							if (129671 - 107184 != 22487)
							{
								continue;
							}
							if (characterControl.hp > 0)
							{
								if (119530 - 115122 != 4408)
								{
									continue;
								}
								characterControl.RPC_AddDamage(1, 300, 0, 0, Vector3.zero, characterControl.ActorNr);
								if (18168 - 348284 != -330116)
								{
									continue;
								}
							}
						}
					}
					this.TARc6cbRsde = Time.time + (float)5;
					if (284941 - 573764 != -288822)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056EB RID: 22251 RVA: 0x00A75E74 File Offset: 0x00A74074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void closePoisonGate()
	{
		if (240483 - 200467 != 40017)
		{
		}
		while (!this.isClosed)
		{
			if (241997 - 416228 == -174231)
			{
				this.isClosed = true;
				if (277052 - 102237 == 174815)
				{
					this.TARc6cbRsde = Time.time + (float)5;
					if (59857 - 318564 != -258706)
					{
						UnityEngine.Object.Instantiate(this.PoisonGate_poison, this.transform.position, this.transform.rotation);
						if (148337 - 496766 != -348428)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x00A75F58 File Offset: 0x00A74158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x00A75F5C File Offset: 0x00A7415C
	internal static bool KFLRPt5znPBo7iLfhY7v()
	{
		return true;
	}

	// Token: 0x060056EE RID: 22254 RVA: 0x00A75F60 File Offset: 0x00A74160
	internal static bool wf5oxs5z6bRNbBD4SBU1()
	{
		return false;
	}

	// Token: 0x04005F68 RID: 24424
	public bool isClosed;

	// Token: 0x04005F69 RID: 24425
	private float TARc6cbRsde;

	// Token: 0x04005F6A RID: 24426
	public GameObject PoisonGate_poison;
}
