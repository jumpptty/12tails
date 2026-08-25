using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200101B RID: 4123
[Serializable]
public class AuctionClass
{
	// Token: 0x06005EF7 RID: 24311 RVA: 0x00CC218C File Offset: 0x00CC038C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AuctionClass()
	{
		if (17558 - 143089 != -125530)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (105142 - 324476 == -219334)
			{
				base..ctor();
				if (190342 - 146912 == 43430)
				{
					this.name = "none";
					if (270177 - 106330 != 163848)
					{
						this.displayname = "none";
						if (193522 - 99831 != 93692)
						{
							this.type = "non";
							if (65921 - 303194 == -237273)
							{
								this.att = new int[8];
								if (94068 - 262290 != -168221)
								{
									this.seller = string.Empty;
									if (266845 - 359269 != -92423)
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

	// Token: 0x06005EF8 RID: 24312 RVA: 0x00CC22C0 File Offset: 0x00CC04C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual InventoryClass getInventory()
	{
		if (177515 - 19308 != 158207)
		{
		}
		InventoryClass inventoryClass;
		for (;;)
		{
			inventoryClass = new InventoryClass();
			if (9020 - 167887 == -158867)
			{
				inventoryClass.name = this.name;
				if (220644 - 108596 == 112048)
				{
					inventoryClass.num = this.num;
					if (224043 - 165424 != 58620)
					{
						inventoryClass.lv = this.slot;
						if (98246 - 365624 == -267378)
						{
							inventoryClass.mlv = this.maxSlot;
							if (111864 - 447969 != -336104)
							{
								inventoryClass.att = this.att;
								if (224669 - 176322 == 48347)
								{
									inventoryClass.owner = this.owner;
									if (85374 - 171526 == -86152)
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
		return inventoryClass;
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x00CC2400 File Offset: 0x00CC0600
	internal static bool ELKmWnpUz6Jhfi4ukccj()
	{
		return true;
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x00CC2404 File Offset: 0x00CC0604
	internal static bool dj6DXppTaG7kkiHEkvco()
	{
		return false;
	}

	// Token: 0x04006941 RID: 26945
	public int aid;

	// Token: 0x04006942 RID: 26946
	public string name;

	// Token: 0x04006943 RID: 26947
	public string displayname;

	// Token: 0x04006944 RID: 26948
	public int num;

	// Token: 0x04006945 RID: 26949
	public int date;

	// Token: 0x04006946 RID: 26950
	public int owner;

	// Token: 0x04006947 RID: 26951
	public string type;

	// Token: 0x04006948 RID: 26952
	public bool isUsable;

	// Token: 0x04006949 RID: 26953
	public int lv;

	// Token: 0x0400694A RID: 26954
	public int slot;

	// Token: 0x0400694B RID: 26955
	public int maxSlot;

	// Token: 0x0400694C RID: 26956
	public int[] att;

	// Token: 0x0400694D RID: 26957
	public int bid;

	// Token: 0x0400694E RID: 26958
	public int mybid;

	// Token: 0x0400694F RID: 26959
	public int buyout;

	// Token: 0x04006950 RID: 26960
	public string seller;

	// Token: 0x04006951 RID: 26961
	public int sellerID;

	// Token: 0x04006952 RID: 26962
	public int buyerID;

	// Token: 0x04006953 RID: 26963
	public bool getMoney;

	// Token: 0x04006954 RID: 26964
	public bool getItem;

	// Token: 0x04006955 RID: 26965
	public Texture icon;
}
