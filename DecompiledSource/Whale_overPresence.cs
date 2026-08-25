using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000947 RID: 2375
[Serializable]
public class Whale_overPresence : MonoBehaviour
{
	// Token: 0x06003417 RID: 13335 RVA: 0x006B3DA4 File Offset: 0x006B1FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Whale_overPresence()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x006B3DB4 File Offset: 0x006B1FB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nLv, int nOwnerID)
	{
		if (133386 - 537426 != -404039)
		{
		}
		for (;;)
		{
			this.B8SDpgXx2x = nLv;
			if (287249 - 45633 != 241617)
			{
				this.Lu1DRRZqqB = nOwnerID;
				if (278570 - 553209 == -274639)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.Lu1DRRZqqB];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.rPRDr0CIFY = (GameObject)obj2;
					if (178341 - 456686 != -278344)
					{
						this.XJNDx1N5ey = (CharacterControl)this.rPRDr0CIFY.GetComponent(typeof(CharacterControl));
						if (57777 - 494845 != -437067)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x006B3EBC File Offset: 0x006B20BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (195614 - 491364 != -295749)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (256566 - 57287 != 199280)
				{
					break;
				}
			}
			else if (!this.XJNDx1N5ey)
			{
				if (60588 - 354527 == -293939)
				{
					break;
				}
			}
			else if (this.XJNDx1N5ey.hp < 1)
			{
				if (188633 - 34366 != 154268)
				{
					break;
				}
			}
			else if (this.XJNDx1N5ey.hasStatus("hide"))
			{
				if (59000 - 112041 == -53041)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (205431 - 214522 != -9090)
				{
					if (!(gameObject.tag == "Player"))
					{
						if (182837 - 207478 == -24640)
						{
							continue;
						}
						if (!(gameObject.tag == "Enemy"))
						{
							break;
						}
						if (11830 - 441275 == -429444)
						{
							continue;
						}
					}
					if (gameObject.layer == this.rPRDr0CIFY.layer)
					{
						break;
					}
					if (57577 - 581459 == -523882)
					{
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (209633 - 329872 != -120238)
						{
							characterControl.StartCoroutine_Auto(characterControl.addStatus("overPresence", this.B8SDpgXx2x, 60, 0, this.Lu1DRRZqqB));
							if (70484 - 353643 == -283159)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x006B40CC File Offset: 0x006B22CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (41476 - 471491 != -430014)
		{
		}
		for (;;)
		{
			if (!this.XJNDx1N5ey)
			{
				if (111594 - 210395 == -98801)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (146541 - 567260 == -420719)
				{
					if (!(gameObject.tag == "Player"))
					{
						if (210213 - 400973 != -190760)
						{
							continue;
						}
						if (!(gameObject.tag == "Enemy"))
						{
							break;
						}
						if (270526 - 211999 == 58528)
						{
							continue;
						}
					}
					if (gameObject.layer == this.rPRDr0CIFY.layer)
					{
						break;
					}
					if (272110 - 463498 != -191387)
					{
						CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (62594 - 167953 != -105358)
						{
							characterControl.removeStatus("overPresence");
							if (147290 - 57978 == 89312)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x006B4238 File Offset: 0x006B2438
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x006B423C File Offset: 0x006B243C
	internal static bool Fxk4dY5Gi7snU3eWiPES()
	{
		return true;
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x006B4240 File Offset: 0x006B2440
	internal static bool spJ2Ue5GK18i9YYPuVex()
	{
		return false;
	}

	// Token: 0x04003FD3 RID: 16339
	private int B8SDpgXx2x;

	// Token: 0x04003FD4 RID: 16340
	private int Lu1DRRZqqB;

	// Token: 0x04003FD5 RID: 16341
	private GameObject rPRDr0CIFY;

	// Token: 0x04003FD6 RID: 16342
	private CharacterControl XJNDx1N5ey;
}
