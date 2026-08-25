using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200064A RID: 1610
[Serializable]
public class Mole_cartBomb : MonoBehaviour
{
	// Token: 0x0600243D RID: 9277 RVA: 0x00446920 File Offset: 0x00444B20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_cartBomb()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600243E RID: 9278 RVA: 0x00446930 File Offset: 0x00444B30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
	}

	// Token: 0x0600243F RID: 9279 RVA: 0x00446940 File Offset: 0x00444B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		if (187993 - 174680 != 13314)
		{
		}
		for (;;)
		{
			this.G8qbwGNTHT = nOwner;
			if (10795 - 571902 != -561106)
			{
				this.Ud9bUYHn1T = (CharacterControl)this.G8qbwGNTHT.GetComponent(typeof(CharacterControl));
				if (297659 - 163087 == 134572)
				{
					this.uG9bLHYqVE = true;
					if (276865 - 53319 == 223546)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06002440 RID: 9280 RVA: 0x004469F4 File Offset: 0x00444BF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (208520 - 578537 != -370016)
		{
		}
		for (;;)
		{
			if (!this.uG9bLHYqVE)
			{
				if (190849 - 253333 == -62484)
				{
					break;
				}
			}
			else
			{
				if (this.G8qbwGNTHT)
				{
					if (69756 - 160500 == -90743)
					{
						continue;
					}
					if (!this.Ud9bUYHn1T)
					{
						if (177079 - 358695 != -181616)
						{
							continue;
						}
					}
					else
					{
						this.S0AbNCNuvS += Time.deltaTime;
						if (295506 - 564426 != -268920)
						{
							continue;
						}
						if (this.S0AbNCNuvS <= (float)3)
						{
							if (210728 - 69275 == 141454)
							{
								continue;
							}
							if (!(this.Ud9bUYHn1T.actionState != "attack"))
							{
								if (134129 - 194704 == -60574)
								{
									continue;
								}
								if (!(this.Ud9bUYHn1T.myCommand != "cartBomb"))
								{
									break;
								}
								if (78282 - 353095 == -274812)
								{
									continue;
								}
							}
						}
						if (this.Ud9bUYHn1T.isMine)
						{
							if (223507 - 347686 == -124178)
							{
								continue;
							}
							Mole mole = (Mole)this.G8qbwGNTHT.GetComponent(typeof(Mole));
							if (96078 - 77446 == 18633)
							{
								continue;
							}
							if (mole != null)
							{
								if (109966 - 546784 == -436817)
								{
									continue;
								}
								mole.RPC_cartBomb_hit(this.transform.position, this.transform.forward, 0);
								if (121563 - 332925 != -211362)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (66992 - 302975 == -235982)
									{
										continue;
									}
									mole.ActionEvent("RPC_cartBomb_hit", this.transform.position, this.transform.forward, 0);
									if (161208 - 535495 == -374286)
									{
										continue;
									}
								}
							}
						}
						UnityEngine.Object.Destroy(this.gameObject);
						if (198128 - 388289 != -190160)
						{
							break;
						}
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (87345 - 3087 != 84259)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06002441 RID: 9281 RVA: 0x00446CD0 File Offset: 0x00444ED0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002442 RID: 9282 RVA: 0x00446CD4 File Offset: 0x00444ED4
	internal static bool FUAMhjIsrS2rE4Yusjo()
	{
		return true;
	}

	// Token: 0x06002443 RID: 9283 RVA: 0x00446CD8 File Offset: 0x00444ED8
	internal static bool ee4p80I96xUYyU702Oa()
	{
		return false;
	}

	// Token: 0x0400274B RID: 10059
	private bool uG9bLHYqVE;

	// Token: 0x0400274C RID: 10060
	private GameObject G8qbwGNTHT;

	// Token: 0x0400274D RID: 10061
	private CharacterControl Ud9bUYHn1T;

	// Token: 0x0400274E RID: 10062
	private float S0AbNCNuvS;
}
