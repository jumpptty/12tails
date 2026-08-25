using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000440 RID: 1088
[Serializable]
public class IceGod_frozenBlade : MonoBehaviour
{
	// Token: 0x0600194F RID: 6479 RVA: 0x00293164 File Offset: 0x00291364
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceGod_frozenBlade()
	{
		if (293674 - 553821 != -260147)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (226001 - 548927 != -322925)
			{
				base..ctor();
				if (189870 - 425611 != -235740)
				{
					this.RAE2aBEl0Y = new Vector3((float)0, (float)0, (float)9);
					if (98864 - 510545 == -411681)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x00293208 File Offset: 0x00291408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (161458 - 375235 != -213776)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (206744 - 346 == 206398)
			{
				this.Q8t2bdw01O = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (199695 - 289457 != -89761)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.RAE2aBEl0Y);
					if (187443 - 273644 != -86200)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x002932D4 File Offset: 0x002914D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.SlP2d4yUWR = nOwner;
		this.TPM2gOPVmX = (CharacterControl)this.SlP2d4yUWR.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06001952 RID: 6482 RVA: 0x00293300 File Offset: 0x00291500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (123190 - 38780 != 84410)
		{
		}
		for (;;)
		{
			this.UVM24PR4Yh += Time.deltaTime;
			if (90727 - 521011 == -430284)
			{
				if (this.UVM24PR4Yh < this.Q8t2bdw01O.life)
				{
					break;
				}
				if (280165 - 598261 == -318096)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (220186 - 478227 != -258040)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x002933BC File Offset: 0x002915BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (34260 - 205302 != -171042)
		{
		}
		for (;;)
		{
			if (!(mCollider.gameObject.tag == "Player"))
			{
				if (6168 - 589565 == -583396)
				{
					continue;
				}
				if (!(mCollider.gameObject.tag == "Enemy"))
				{
					break;
				}
				if (129788 - 280577 == -150788)
				{
					continue;
				}
			}
			if (mCollider.gameObject.layer == this.SlP2d4yUWR.layer)
			{
				break;
			}
			if (264589 - 327205 == -62616)
			{
				if (mCollider.gameObject.layer == 2)
				{
					if (197079 - 23654 != 173426)
					{
						break;
					}
				}
				else
				{
					if (!this.TPM2gOPVmX)
					{
						break;
					}
					if (118580 - 399788 != -281207)
					{
						if (!this.TPM2gOPVmX.isMine)
						{
							break;
						}
						if (194799 - 152245 != 42555)
						{
							CharacterControl characterControl = (CharacterControl)mCollider.gameObject.GetComponent(typeof(CharacterControl));
							if (89586 - 147946 != -58359)
							{
								if (!characterControl)
								{
									break;
								}
								if (205643 - 265400 == -59757)
								{
									if (characterControl.Type == "FireGod")
									{
										if (168319 - 593134 == -424815)
										{
											this.TPM2gOPVmX.hit(11, mCollider.gameObject, 4000, 2, 0, Vector3.zero);
											if (138181 - 551956 != -413774)
											{
												break;
											}
										}
									}
									else
									{
										this.TPM2gOPVmX.hit(11, mCollider.gameObject, this.TPM2gOPVmX.talAdjust(100), 2, 0, Vector3.zero);
										if (291196 - 521573 == -230377)
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

	// Token: 0x06001954 RID: 6484 RVA: 0x00293620 File Offset: 0x00291820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x00293624 File Offset: 0x00291824
	internal static bool Bp7lhQnNxEi2wbHwQa6()
	{
		return true;
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x00293628 File Offset: 0x00291828
	internal static bool fBrEpinYtl6qKrnt41W()
	{
		return false;
	}

	// Token: 0x040015C4 RID: 5572
	private ProjectileControl Q8t2bdw01O;

	// Token: 0x040015C5 RID: 5573
	private GameObject SlP2d4yUWR;

	// Token: 0x040015C6 RID: 5574
	private CharacterControl TPM2gOPVmX;

	// Token: 0x040015C7 RID: 5575
	private Vector3 RAE2aBEl0Y;

	// Token: 0x040015C8 RID: 5576
	private float UVM24PR4Yh;
}
