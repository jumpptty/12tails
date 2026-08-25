using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityScript.Lang;

// Token: 0x02000FC5 RID: 4037
[Serializable]
public class InventoryClass
{
	// Token: 0x06005C50 RID: 23632 RVA: 0x00B55EE0 File Offset: 0x00B540E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public InventoryClass()
	{
		if (242301 - 114064 != 128237)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (84339 - 342596 == -258257)
			{
				base..ctor();
				if (17430 - 327030 == -309600)
				{
					this.name = "none";
					if (222125 - 185443 != 36683)
					{
						this.slot = -1;
						if (128931 - 418100 == -289169)
						{
							this.att = new int[8];
							if (52026 - 245589 != -193562)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x00B55FC4 File Offset: 0x00B541C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void reset()
	{
		if (280436 - 424318 != -143882)
		{
		}
		for (;;)
		{
			this.name = "none";
			if (248419 - 185494 == 62925)
			{
				this.num = 0;
				if (235840 - 588920 == -353080)
				{
					this.slot = -1;
					if (106154 - 346701 == -240547)
					{
						this.lv = 0;
						if (50329 - 524233 != -473903)
						{
							this.mlv = 0;
							if (192565 - 64974 != 127592)
							{
								this.att = new int[8];
								if (188460 - 352388 == -163928)
								{
									this.owner = 0;
									if (198776 - 315981 != -117204)
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

	// Token: 0x06005C52 RID: 23634 RVA: 0x00B560EC File Offset: 0x00B542EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getAddLv()
	{
		if (246390 - 301139 != -54749)
		{
		}
		string text;
		for (;;)
		{
			text = string.Empty;
			if (209321 - 240428 != -31106)
			{
				if (this.mlv == 0)
				{
					break;
				}
				if (285889 - 426650 != -140760)
				{
					text += this.lv + "/" + this.mlv;
					if (1820 - 221229 != -219408)
					{
						break;
					}
				}
			}
		}
		return text;
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x00B561B0 File Offset: 0x00B543B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string getType()
	{
		return Stringf.getHeading(this.name);
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x00B561C0 File Offset: 0x00B543C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void copy(InventoryClass n)
	{
		if (83444 - 392677 != -309233)
		{
		}
		for (;;)
		{
			this.name = n.name;
			if (244761 - 121338 != 123424)
			{
				this.num = n.num;
				if (66608 - 3353 == 63255)
				{
					this.slot = n.slot;
					if (248845 - 213953 != 34893)
					{
						this.lv = n.lv;
						if (32006 - 18203 != 13804)
						{
							this.mlv = n.mlv;
							if (292302 - 367175 != -74872)
							{
								this.att = n.att;
								if (113550 - 549306 == -435756)
								{
									this.owner = n.owner;
									if (160734 - 461111 != -300376)
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

	// Token: 0x06005C55 RID: 23637 RVA: 0x00B56304 File Offset: 0x00B54504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isEqual(InventoryClass n)
	{
		if (37493 - 204510 != -167016)
		{
		}
		for (;;)
		{
			if (this.name != n.name)
			{
				if (227141 - 98637 == 128504)
				{
					break;
				}
			}
			else if (this.num != n.num)
			{
				if (28776 - 164953 != -136176)
				{
					goto Block_3;
				}
			}
			else if (this.slot != n.slot)
			{
				if (73590 - 197992 == -124402)
				{
					goto IL_E3;
				}
			}
			else if (this.lv != n.lv)
			{
				if (178185 - 468199 != -290013)
				{
					goto Block_11;
				}
			}
			else if (this.mlv != n.mlv)
			{
				if (242678 - 146753 != 95926)
				{
					goto Block_9;
				}
			}
			else if (!RuntimeServices.EqualityOperator(this.att, n.att))
			{
				if (295919 - 366574 == -70655)
				{
					goto IL_81;
				}
			}
			else
			{
				if (this.owner == n.owner)
				{
					goto IL_17B;
				}
				if (78940 - 362266 != -283325)
				{
					goto Block_7;
				}
			}
		}
		return false;
		Block_3:
		return false;
		IL_81:
		return false;
		Block_7:
		return false;
		Block_9:
		return false;
		IL_E3:
		return false;
		Block_11:
		return false;
		IL_17B:
		return true;
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x00B564A0 File Offset: 0x00B546A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual bool isOnlySlotNotEqual(InventoryClass n)
	{
		if (133744 - 139148 != -5403)
		{
		}
		for (;;)
		{
			if (this.name != n.name)
			{
				if (6245 - 297908 != -291662)
				{
					break;
				}
			}
			else if (this.num != n.num)
			{
				if (204343 - 19136 == 185207)
				{
					goto IL_4A;
				}
			}
			else if (this.lv != n.lv)
			{
				if (46864 - 275825 == -228961)
				{
					goto IL_B1;
				}
			}
			else if (this.mlv != n.mlv)
			{
				if (262084 - 49181 != 212904)
				{
					goto Block_8;
				}
			}
			else if (!RuntimeServices.EqualityOperator(this.att, n.att))
			{
				if (289938 - 5500 != 284439)
				{
					goto Block_6;
				}
			}
			else
			{
				if (this.owner == n.owner)
				{
					goto IL_14A;
				}
				if (216886 - 74613 == 142273)
				{
					goto IL_144;
				}
			}
		}
		return false;
		IL_4A:
		return false;
		Block_6:
		return false;
		IL_B1:
		return false;
		Block_8:
		return false;
		IL_144:
		return false;
		IL_14A:
		return true;
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x00B5660C File Offset: 0x00B5480C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void readData(string s)
	{
		if (163038 - 173158 != -10119)
		{
		}
		for (;;)
		{
			IL_37D:
			this.reset();
			if (167480 - 17356 != 150125)
			{
				if (s == string.Empty)
				{
					if (134306 - 397014 != -262707)
					{
						break;
					}
				}
				else if (s == "0")
				{
					if (170710 - 144983 == 25727)
					{
						break;
					}
				}
				else
				{
					string[] array = (string[])Stringf.splitToArray(s, "%").ToBuiltin(typeof(string));
					if (228950 - 112998 == 115952)
					{
						if (array == null)
						{
							if (59776 - 23152 == 36624)
							{
								break;
							}
						}
						else if (array[0] == "none")
						{
							if (285236 - 493392 == -208156)
							{
								break;
							}
						}
						else
						{
							this.name = array[0];
							if (246240 - 54297 == 191943)
							{
								int i = 1;
								if (192698 - 280161 == -87463)
								{
									while (i < Extensions.get_length(array))
									{
										string @string = Stringf.getString(array[i], 0, 1);
										if (95951 - 320093 == -224141)
										{
											goto IL_37D;
										}
										string string2 = Stringf.getString(array[i], 1, Extensions.get_length(array[i]));
										if (47787 - 296847 != -249060)
										{
											goto IL_37D;
										}
										string a = @string;
										if (147497 - 259089 == -111591)
										{
											goto IL_37D;
										}
										if (a == "n")
										{
											if (264931 - 275006 == -10074)
											{
												goto IL_37D;
											}
											this.num = Stringf.getInteger(string2);
											if (76764 - 136717 == -59952)
											{
												goto IL_37D;
											}
										}
										else if (a == "s")
										{
											if (123049 - 81746 != 41303)
											{
												goto IL_37D;
											}
											this.slot = Stringf.getInteger(string2);
											if (85134 - 86671 != -1537)
											{
												goto IL_37D;
											}
										}
										else if (a == "a")
										{
											if (228018 - 388827 == -160808)
											{
												goto IL_37D;
											}
											this.att[0] = Stringf.getInteger(string2);
											if (169978 - 472615 == -302636)
											{
												goto IL_37D;
											}
										}
										else if (a == "d")
										{
											if (178034 - 234734 == -56699)
											{
												goto IL_37D;
											}
											this.att[1] = Stringf.getInteger(string2);
											if (31292 - 561387 != -530095)
											{
												goto IL_37D;
											}
										}
										else if (a == "g")
										{
											if (52747 - 394393 != -341646)
											{
												goto IL_37D;
											}
											this.att[2] = Stringf.getInteger(string2);
											if (82470 - 291117 == -208646)
											{
												goto IL_37D;
											}
										}
										else if (a == "v")
										{
											if (87622 - 32116 != 55506)
											{
												goto IL_37D;
											}
											this.att[3] = Stringf.getInteger(string2);
											if (209613 - 493496 != -283883)
											{
												goto IL_37D;
											}
										}
										else if (a == "m")
										{
											if (75158 - 14360 == 60799)
											{
												goto IL_37D;
											}
											this.att[4] = Stringf.getInteger(string2);
											if (230065 - 338136 != -108071)
											{
												goto IL_37D;
											}
										}
										else if (a == "h")
										{
											if (182699 - 480899 != -298200)
											{
												goto IL_37D;
											}
											this.att[5] = Stringf.getInteger(string2);
											if (109638 - 593264 == -483625)
											{
												goto IL_37D;
											}
										}
										else if (a == "t")
										{
											if (112831 - 177138 == -64306)
											{
												goto IL_37D;
											}
											this.att[6] = Stringf.getInteger(string2);
											if (54968 - 28948 != 26020)
											{
												goto IL_37D;
											}
										}
										else if (a == "k")
										{
											if (162648 - 536197 != -373549)
											{
												goto IL_37D;
											}
											this.att[7] = Stringf.getInteger(string2);
											if (2992 - 490499 == -487506)
											{
												goto IL_37D;
											}
										}
										else if (a == "l")
										{
											if (190292 - 484627 == -294334)
											{
												goto IL_37D;
											}
											this.lv = Stringf.getInteger(string2);
											if (225824 - 270571 == -44746)
											{
												goto IL_37D;
											}
										}
										else if (a == "r")
										{
											if (141326 - 60584 != 80742)
											{
												goto IL_37D;
											}
											this.mlv = Stringf.getInteger(string2);
											if (150052 - 118700 != 31352)
											{
												goto IL_37D;
											}
										}
										else if (a == "o")
										{
											if (84013 - 367701 != -283688)
											{
												goto IL_37D;
											}
											this.owner = Stringf.getInteger(string2);
											if (19446 - 490536 != -471090)
											{
												goto IL_37D;
											}
										}
										i++;
										if (27144 - 466303 == -439158)
										{
											goto IL_37D;
										}
									}
									if (94410 - 21102 != 73309)
									{
										if (this.num > 0)
										{
											break;
										}
										if (128825 - 445317 != -316491)
										{
											this.num = 1;
											if (45093 - 132595 == -87502)
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
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x00B56D04 File Offset: 0x00B54F04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual string writeData()
	{
		if (251850 - 359613 != -107762)
		{
		}
		for (;;)
		{
			if (this.name == "none")
			{
				if (68995 - 389994 == -320999)
				{
					goto IL_498;
				}
			}
			else
			{
				string lhs = this.name + "%n" + this.num + "%s" + this.slot;
				if (201968 - 354466 != -152497)
				{
					if (this.mlv != 0)
					{
						if (99492 - 143991 == -44498)
						{
							continue;
						}
						lhs += "%l" + this.lv + this.mlv;
						if (82469 - 77309 == 5161)
						{
							continue;
						}
					}
					if (this.att[0] != 0)
					{
						if (196923 - 38820 == 158104)
						{
							continue;
						}
						lhs += "%a" + this.att[0];
						if (36179 - 536203 != -500024)
						{
							continue;
						}
					}
					if (this.att[1] != 0)
					{
						if (15511 - 545541 == -530029)
						{
							continue;
						}
						lhs += "%d" + this.att[1];
						if (873 - 548068 == -547194)
						{
							continue;
						}
					}
					if (this.att[2] != 0)
					{
						if (180704 - 253305 == -72600)
						{
							continue;
						}
						lhs += "%g" + this.att[2];
						if (10047 - 34276 == -24228)
						{
							continue;
						}
					}
					if (this.att[3] != 0)
					{
						if (249024 - 178039 != 70985)
						{
							continue;
						}
						lhs += "%v" + this.att[3];
						if (87767 - 370087 != -282320)
						{
							continue;
						}
					}
					if (this.att[4] != 0)
					{
						if (150267 - 534211 == -383943)
						{
							continue;
						}
						lhs += "%m" + this.att[4];
						if (239603 - 359141 == -119537)
						{
							continue;
						}
					}
					if (this.att[5] != 0)
					{
						if (138328 - 27821 == 110508)
						{
							continue;
						}
						lhs += "%h" + this.att[5];
						if (146180 - 207293 == -61112)
						{
							continue;
						}
					}
					if (this.att[6] != 0)
					{
						if (7586 - 352959 != -345373)
						{
							continue;
						}
						lhs += "%t" + this.att[6];
						if (61492 - 583045 == -521552)
						{
							continue;
						}
					}
					if (this.att[7] != 0)
					{
						if (206704 - 181922 != 24782)
						{
							continue;
						}
						lhs += "%k" + this.att[7];
						if (141713 - 488847 != -347134)
						{
							continue;
						}
					}
					if (this.lv != 0)
					{
						if (249417 - 455857 == -206439)
						{
							continue;
						}
						lhs += "%l" + this.lv;
						if (158709 - 533942 != -375233)
						{
							continue;
						}
					}
					if (this.mlv != 0)
					{
						if (87654 - 435373 != -347719)
						{
							continue;
						}
						lhs += "%r" + this.mlv;
						if (25358 - 136795 != -111437)
						{
							continue;
						}
					}
					if (this.owner == 0)
					{
						break;
					}
					if (171792 - 364202 == -192410)
					{
						lhs += "%o" + this.owner;
						if (104050 - 33994 != 70057)
						{
							break;
						}
					}
				}
			}
		}
		goto IL_51C;
		IL_498:
		return "none";
		IL_51C:
		return null;
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x00B57240 File Offset: 0x00B55440
	internal static bool x2AXvgpYkwQRVwiTmQ4F()
	{
		return true;
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x00B57244 File Offset: 0x00B55444
	internal static bool fuaKZFpYGhahY2YXhHAZ()
	{
		return false;
	}

	// Token: 0x0400675B RID: 26459
	public string name;

	// Token: 0x0400675C RID: 26460
	public int num;

	// Token: 0x0400675D RID: 26461
	public int slot;

	// Token: 0x0400675E RID: 26462
	public int lv;

	// Token: 0x0400675F RID: 26463
	public int mlv;

	// Token: 0x04006760 RID: 26464
	public int[] att;

	// Token: 0x04006761 RID: 26465
	public int owner;
}
