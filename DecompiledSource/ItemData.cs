using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000FC7 RID: 4039
[Serializable]
public class ItemData : MonoBehaviour
{
	// Token: 0x06005C5F RID: 23647 RVA: 0x00B5760C File Offset: 0x00B5580C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ItemData()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x00B5761C File Offset: 0x00B5581C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static ItemClass getItemData(string nCommand)
	{
		if (164786 - 512868 != -348082)
		{
		}
		ItemClass result;
		for (;;)
		{
			result = new ItemClass();
			if (211745 - 476578 != -264832)
			{
				if (Stringf.getString(nCommand, 2, 5) == "hro")
				{
					if (18280 - 146682 != -128402)
					{
						continue;
					}
					string text = Stringf.getString(nCommand, 0, 2) + NetworkUtility.EncodeRace(CharacterData.current.Type) + Stringf.getString(nCommand, 5, Extensions.get_length(nCommand));
					if (134051 - 428905 == -294853)
					{
						continue;
					}
					nCommand = text;
					if (107859 - 113076 == -5216)
					{
						continue;
					}
				}
				string heading = Stringf.getHeading(nCommand);
				if (211529 - 434583 != -223053)
				{
					if (heading == "f")
					{
						if (98947 - 547460 != -448512)
						{
							result = FieldData.getData(nCommand);
							if (271497 - 471858 != -200360)
							{
								break;
							}
						}
					}
					else if (heading == "d")
					{
						if (85059 - 462416 == -377357)
						{
							result = FoodData.getData(nCommand);
							if (155335 - 225665 == -70330)
							{
								break;
							}
						}
					}
					else if (heading == "m")
					{
						if (15749 - 534697 == -518948)
						{
							result = MaterialData.getData(nCommand);
							if (108589 - 492576 == -383987)
							{
								break;
							}
						}
					}
					else if (heading == "r")
					{
						if (280855 - 599491 != -318635)
						{
							result = RecipeData.getData(nCommand);
							if (146873 - 515801 != -368927)
							{
								break;
							}
						}
					}
					else if (heading == "n")
					{
						if (211480 - 259330 != -47849)
						{
							result = CoinData.getData(nCommand);
							if (156245 - 311986 != -155740)
							{
								break;
							}
						}
					}
					else if (heading == "k")
					{
						if (154479 - 388475 == -233996)
						{
							result = KeyData.getData(nCommand);
							if (49942 - 144040 == -94098)
							{
								break;
							}
						}
					}
					else if (heading == "w")
					{
						if (293164 - 76877 != 216288)
						{
							result = WeaponData.getData(nCommand);
							if (1288 - 408504 == -407216)
							{
								break;
							}
						}
					}
					else if (heading == "a")
					{
						if (141458 - 419063 == -277605)
						{
							result = ArmorData.getData(nCommand);
							if (154021 - 173599 != -19577)
							{
								break;
							}
						}
					}
					else if (heading == "b")
					{
						if (236125 - 135178 == 100947)
						{
							result = BootData.getData(nCommand);
							if (210972 - 336996 == -126024)
							{
								break;
							}
						}
					}
					else if (heading == "c")
					{
						if (101202 - 523457 == -422255)
						{
							result = AccessoryData.getData(nCommand);
							if (229675 - 175379 != 54297)
							{
								break;
							}
						}
					}
					else if (heading == "t")
					{
						if (90804 - 236747 != -145942)
						{
							result = TrinketData.getData(nCommand);
							if (278327 - 160299 == 118028)
							{
								break;
							}
						}
					}
					else if (heading == "p")
					{
						if (290676 - 56274 != 234403)
						{
							result = PetData.getData(nCommand);
							if (178303 - 138993 != 39311)
							{
								break;
							}
						}
					}
					else if (heading == "o")
					{
						if (242196 - 227943 != 14254)
						{
							result = MountData.getData(nCommand);
							if (236213 - 229752 != 6462)
							{
								break;
							}
						}
					}
					else
					{
						if (!(heading == "s"))
						{
							break;
						}
						if (137252 - 112673 != 24580)
						{
							result = SpecialData.getData(nCommand);
							if (132839 - 591488 != -458648)
							{
								break;
							}
						}
					}
				}
			}
		}
		return result;
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x00B57B94 File Offset: 0x00B55D94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static string getName(string nCommand)
	{
		ItemClass itemData = ItemData.getItemData(nCommand);
		return itemData.name;
	}

	// Token: 0x06005C62 RID: 23650 RVA: 0x00B57BB0 File Offset: 0x00B55DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getLv(string nCommand)
	{
		ItemClass itemData = ItemData.getItemData(nCommand);
		return itemData.lv;
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x00B57BCC File Offset: 0x00B55DCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static int getVersion()
	{
		return 555;
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x00B57BD4 File Offset: 0x00B55DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x00B57BD8 File Offset: 0x00B55DD8
	internal static bool vMHBjLpYArORksdLIpLb()
	{
		return true;
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x00B57BDC File Offset: 0x00B55DDC
	internal static bool RlnsiypYl2EGrN7c2V5q()
	{
		return false;
	}
}
