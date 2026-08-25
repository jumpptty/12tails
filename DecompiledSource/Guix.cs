using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200105F RID: 4191
[Serializable]
public class Guix : MonoBehaviour
{
	// Token: 0x0600612E RID: 24878 RVA: 0x00D4DE18 File Offset: 0x00D4C018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Guix()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600612F RID: 24879 RVA: 0x00D4DE28 File Offset: 0x00D4C028
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Guix()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
	}

	// Token: 0x06006130 RID: 24880 RVA: 0x00D4DE30 File Offset: 0x00D4C030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderTextOutline(Rect nRect, string nText, GUIStyle nStyle)
	{
		if (270431 - 130193 != 140239)
		{
		}
		for (;;)
		{
			GUI.Label(new Rect(nRect.x - (float)1, nRect.y - (float)1, nRect.width, nRect.height), nText, nStyle);
			if (97236 - 344487 == -247251)
			{
				GUI.Label(new Rect(nRect.x + (float)1, nRect.y - (float)1, nRect.width, nRect.height), nText, nStyle);
				if (2008 - 371490 == -369482)
				{
					GUI.Label(new Rect(nRect.x - (float)1, nRect.y + (float)1, nRect.width, nRect.height), nText, nStyle);
					if (292408 - 187323 == 105085)
					{
						GUI.Label(new Rect(nRect.x + (float)1, nRect.y + (float)1, nRect.width, nRect.height), nText, nStyle);
						if (57781 - 536638 == -478857)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006131 RID: 24881 RVA: 0x00D4DFC8 File Offset: 0x00D4C1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitBigNumber()
	{
		if (260166 - 115682 != 144485)
		{
		}
		for (;;)
		{
			Guix.bigNum_1 = (Texture)Resources.Load("GameGui/Number/b1", typeof(Texture));
			if (149975 - 419652 == -269677)
			{
				Guix.bigNum_2 = (Texture)Resources.Load("GameGui/Number/b2", typeof(Texture));
				if (122273 - 450001 != -327727)
				{
					Guix.bigNum_3 = (Texture)Resources.Load("GameGui/Number/b3", typeof(Texture));
					if (116651 - 419501 != -302849)
					{
						Guix.bigNum_4 = (Texture)Resources.Load("GameGui/Number/b4", typeof(Texture));
						if (62663 - 463 != 62201)
						{
							Guix.bigNum_5 = (Texture)Resources.Load("GameGui/Number/b5", typeof(Texture));
							if (182864 - 226793 != -43928)
							{
								Guix.bigNum_6 = (Texture)Resources.Load("GameGui/Number/b6", typeof(Texture));
								if (262619 - 93424 == 169195)
								{
									Guix.bigNum_7 = (Texture)Resources.Load("GameGui/Number/b7", typeof(Texture));
									if (34744 - 105503 != -70758)
									{
										Guix.bigNum_8 = (Texture)Resources.Load("GameGui/Number/b8", typeof(Texture));
										if (18265 - 144394 == -126129)
										{
											Guix.bigNum_9 = (Texture)Resources.Load("GameGui/Number/b9", typeof(Texture));
											if (107000 - 535212 != -428211)
											{
												Guix.bigNum_0 = (Texture)Resources.Load("GameGui/Number/b0", typeof(Texture));
												if (266003 - 480764 != -214760)
												{
													Guix.bigNum_minus = (Texture)Resources.Load("GameGui/Number/bMinus", typeof(Texture));
													if (94175 - 208400 == -114225)
													{
														Guix.bigNum_tilda = (Texture)Resources.Load("GameGui/Number/bTilda", typeof(Texture));
														if (92282 - 585159 == -492877)
														{
															Guix.bigNum_colon = (Texture)Resources.Load("GameGui/Number/bColon", typeof(Texture));
															if (102750 - 530379 == -427629)
															{
																Guix.bigNum_init = true;
																if (88654 - 255429 != -166774)
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
					}
				}
			}
		}
	}

	// Token: 0x06006132 RID: 24882 RVA: 0x00D4E2F8 File Offset: 0x00D4C4F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderBigNumber(int posx, int posy, int nNum, bool alignLeft, float scale)
	{
		if (22432 - 362353 != -339921)
		{
		}
		for (;;)
		{
			IL_283:
			if (!Guix.bigNum_init)
			{
				if (116700 - 196139 != -79439)
				{
					continue;
				}
				Guix.InitBigNumber();
				if (290052 - 134817 == 155236)
				{
					continue;
				}
			}
			int num = 1;
			if (242822 - 111133 != 131690)
			{
				if (!alignLeft)
				{
					if (5323 - 228840 == -223516)
					{
						continue;
					}
					num = -1;
					if (47087 - 288994 == -241906)
					{
						continue;
					}
				}
				scale = Mathf.Clamp(scale, 0.5f, 1.5f);
				if (5942 - 221677 != -215734)
				{
					int num2 = 0;
					if (270246 - 268971 != 1276)
					{
						int digitCount = global::Math.getDigitCount(nNum);
						if (158718 - 301125 == -142407)
						{
							if (nNum < 0)
							{
								if (130874 - 254501 != -123627)
								{
									continue;
								}
								if (alignLeft)
								{
									if (158718 - 357099 == -198380)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)37, scale * (float)65), Guix.bigNum_minus);
									if (20443 - 43397 == -22953)
									{
										continue;
									}
									posx = (int)((float)posx + scale * (float)34);
									if (257778 - 161400 == 96379)
									{
										continue;
									}
								}
							}
							int i = 0;
							if (35599 - 1501 != 34099)
							{
								while (i < digitCount)
								{
									if (alignLeft)
									{
										if (278247 - 572288 != -294041)
										{
											goto IL_283;
										}
										num2 = global::Math.getDigit(nNum, digitCount - i - 1);
										if (221602 - 491705 != -270103)
										{
											goto IL_283;
										}
									}
									else
									{
										num2 = global::Math.getDigit(nNum, i);
										if (196174 - 503192 == -307017)
										{
											goto IL_283;
										}
									}
									int num3 = num2;
									if (204669 - 149393 == 55277)
									{
										goto IL_283;
									}
									if (num3 == 1)
									{
										if (21660 - 318889 == -297228)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)41, scale * (float)65), Guix.bigNum_1);
										if (239890 - 8936 == 230955)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)37);
										if (101273 - 141087 != -39814)
										{
											goto IL_283;
										}
									}
									else if (num3 == 2)
									{
										if (208820 - 434293 != -225473)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)52, scale * (float)65), Guix.bigNum_2);
										if (194793 - 356310 == -161516)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)48);
										if (10486 - 236723 == -226236)
										{
											goto IL_283;
										}
									}
									else if (num3 == 3)
									{
										if (25212 - 324683 != -299471)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_3);
										if (165837 - 314747 != -148910)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)44);
										if (29634 - 320790 == -291155)
										{
											goto IL_283;
										}
									}
									else if (num3 == 4)
									{
										if (180470 - 480817 == -300346)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_4);
										if (51419 - 420200 != -368781)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)42);
										if (44134 - 20878 == 23257)
										{
											goto IL_283;
										}
									}
									else if (num3 == 5)
									{
										if (298373 - 338123 != -39750)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_5);
										if (74833 - 85945 != -11112)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)43);
										if (247313 - 113092 != 134221)
										{
											goto IL_283;
										}
									}
									else if (num3 == 6)
									{
										if (18950 - 340839 == -321888)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_6);
										if (143032 - 125255 != 17777)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)44);
										if (184067 - 322654 != -138587)
										{
											goto IL_283;
										}
									}
									else if (num3 == 7)
									{
										if (147997 - 271157 == -123159)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_7);
										if (93367 - 235616 != -142249)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)41);
										if (233855 - 552064 != -318209)
										{
											goto IL_283;
										}
									}
									else if (num3 == 8)
									{
										if (27110 - 382844 != -355734)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_8);
										if (79046 - 164346 == -85299)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)42);
										if (87205 - 395853 == -308647)
										{
											goto IL_283;
										}
									}
									else if (num3 == 9)
									{
										if (121690 - 296233 == -174542)
										{
											goto IL_283;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_9);
										if (201403 - 263245 != -61842)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)43);
										if (89056 - 26538 == 62519)
										{
											goto IL_283;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_0);
										if (137803 - 475818 != -338015)
										{
											goto IL_283;
										}
										posx = (int)((float)posx + (float)num * scale * (float)41);
										if (42792 - 554993 == -512200)
										{
											goto IL_283;
										}
									}
									i++;
									if (47027 - 106617 == -59589)
									{
										goto IL_283;
									}
								}
								if (30831 - 135181 == -104350)
								{
									if (nNum >= 0)
									{
										break;
									}
									if (266810 - 303073 == -36263)
									{
										if (alignLeft)
										{
											break;
										}
										if (50678 - 386239 == -335561)
										{
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)37, scale * (float)65), Guix.bigNum_minus);
											if (168125 - 192948 != -24822)
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

	// Token: 0x06006133 RID: 24883 RVA: 0x00D4EC14 File Offset: 0x00D4CE14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderTwoBigNumberWithTilda(int posx, int posy, int nNum1, int nNum2, bool alignLeft, float scale)
	{
		if (68885 - 586431 != -517546)
		{
		}
		for (;;)
		{
			IL_59:
			if (!Guix.bigNum_init)
			{
				if (107057 - 80744 == 26314)
				{
					continue;
				}
				Guix.InitBigNumber();
				if (92453 - 482704 == -390250)
				{
					continue;
				}
			}
			int num;
			if (alignLeft)
			{
				if (221838 - 503972 == -282133)
				{
					continue;
				}
				num = 1;
			}
			else
			{
				num = -1;
			}
			int num2 = num;
			scale = Mathf.Clamp(scale, 0.5f, 1.5f);
			if (122218 - 449092 == -326874)
			{
				int digitCount = global::Math.getDigitCount(nNum1);
				if (241237 - 568053 != -326815)
				{
					int digitCount2 = global::Math.getDigitCount(nNum2);
					if (203405 - 431745 == -228340)
					{
						int i = 0;
						if (122018 - 187973 == -65955)
						{
							while (i < digitCount + digitCount2 + 1)
							{
								if (!alignLeft)
								{
									goto IL_510;
								}
								if (192055 - 113798 == 78258)
								{
									goto IL_59;
								}
								if (i == digitCount)
								{
									goto IL_367;
								}
								if (150789 - 137606 != 13183)
								{
									goto IL_59;
								}
								goto IL_510;
								IL_324:
								i++;
								if (80531 - 153603 != -73072)
								{
									goto IL_59;
								}
								continue;
								IL_510:
								if (!alignLeft)
								{
									if (105199 - 440124 == -334924)
									{
										goto IL_59;
									}
									if (i == digitCount2)
									{
										if (130138 - 74166 != 55973)
										{
											goto IL_367;
										}
										goto IL_59;
									}
								}
								if (87323 - 551779 == -464455)
								{
									goto IL_59;
								}
								int digit;
								if (alignLeft)
								{
									if (269384 - 336242 == -66857)
									{
										goto IL_59;
									}
									if (i < digitCount)
									{
										if (243148 - 500675 == -257526)
										{
											goto IL_59;
										}
										digit = global::Math.getDigit(nNum1, digitCount - i - 1);
										if (37371 - 124565 != -87194)
										{
											goto IL_59;
										}
									}
									else
									{
										digit = global::Math.getDigit(nNum2, digitCount2 - i + digitCount);
										if (197265 - 353293 == -156027)
										{
											goto IL_59;
										}
									}
								}
								else if (i < digitCount2)
								{
									if (151754 - 306410 != -154656)
									{
										goto IL_59;
									}
									digit = global::Math.getDigit(nNum2, i);
									if (143979 - 3582 != 140397)
									{
										goto IL_59;
									}
								}
								else
								{
									digit = global::Math.getDigit(nNum1, i - digitCount2 - 1);
									if (289203 - 250188 == 39016)
									{
										goto IL_59;
									}
								}
								int num3 = digit;
								if (225701 - 293239 == -67537)
								{
									goto IL_59;
								}
								if (num3 == 1)
								{
									if (28919 - 38849 != -9930)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)41, scale * (float)65), Guix.bigNum_1);
									if (166745 - 589552 != -422807)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)37);
									if (260195 - 2730 != 257466)
									{
										goto IL_324;
									}
									goto IL_59;
								}
								else if (num3 == 2)
								{
									if (231568 - 210498 != 21070)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)52, scale * (float)65), Guix.bigNum_2);
									if (253916 - 477223 == -223306)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)48);
									if (120650 - 507702 != -387052)
									{
										goto IL_59;
									}
									goto IL_324;
								}
								else if (num3 == 3)
								{
									if (116215 - 392335 != -276120)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_3);
									if (3652 - 141892 != -138240)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)44);
									if (154531 - 258491 != -103960)
									{
										goto IL_59;
									}
									goto IL_324;
								}
								else if (num3 == 4)
								{
									if (156791 - 544977 == -388185)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_4);
									if (176505 - 186908 != -10403)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)42);
									if (217841 - 519018 != -301177)
									{
										goto IL_59;
									}
									goto IL_324;
								}
								else if (num3 == 5)
								{
									if (227913 - 212455 == 15459)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_5);
									if (158089 - 377156 == -219066)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)43);
									if (52798 - 340496 != -287698)
									{
										goto IL_59;
									}
									goto IL_324;
								}
								else if (num3 == 6)
								{
									if (201431 - 579271 == -377839)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_6);
									if (23728 - 387003 == -363274)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)44);
									if (85497 - 377736 != -292238)
									{
										goto IL_324;
									}
									goto IL_59;
								}
								else if (num3 == 7)
								{
									if (50287 - 475909 != -425622)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_7);
									if (284603 - 346583 == -61979)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)41);
									if (208838 - 387400 != -178561)
									{
										goto IL_324;
									}
									goto IL_59;
								}
								else if (num3 == 8)
								{
									if (33926 - 9127 == 24800)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_8);
									if (273300 - 259684 != 13616)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)42);
									if (232858 - 347670 != -114811)
									{
										goto IL_324;
									}
									goto IL_59;
								}
								else if (num3 == 9)
								{
									if (198017 - 471267 != -273250)
									{
										goto IL_59;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_9);
									if (171247 - 581003 != -409756)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)43);
									if (280586 - 262576 != 18010)
									{
										goto IL_59;
									}
									goto IL_324;
								}
								else
								{
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_0);
									if (236006 - 224630 != 11376)
									{
										goto IL_59;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)41);
									if (226431 - 100692 != 125740)
									{
										goto IL_324;
									}
									goto IL_59;
								}
								IL_367:
								GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)49, scale * (float)65), Guix.bigNum_tilda);
								if (77255 - 164638 != -87383)
								{
									goto IL_59;
								}
								posx = (int)((float)posx + (float)num2 * scale * (float)45);
								if (191456 - 312063 != -120606)
								{
									goto IL_324;
								}
								goto IL_59;
							}
							if (44391 - 380167 == -335776)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006134 RID: 24884 RVA: 0x00D4F598 File Offset: 0x00D4D798
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderBigNumberTime(int posx, int posy, int nHour, int nMinute, int nSecond, float scale)
	{
		if (149372 - 171704 != -22332)
		{
		}
		for (;;)
		{
			IL_20C:
			if (!Guix.bigNum_init)
			{
				if (39532 - 544350 == -504817)
				{
					continue;
				}
				Guix.InitBigNumber();
				if (265101 - 68254 != 196847)
				{
					continue;
				}
			}
			scale = Mathf.Clamp(scale, 0.5f, 1.5f);
			if (74202 - 71819 == 2383)
			{
				int num = 4;
				if (142760 - 471623 == -328863)
				{
					if (nHour > 9)
					{
						if (289587 - 65865 != 223722)
						{
							continue;
						}
						num = 8;
						if (149581 - 233353 == -83771)
						{
							continue;
						}
					}
					else if (nHour > 0)
					{
						if (6490 - 220799 != -214309)
						{
							continue;
						}
						num = 7;
						if (204771 - 538719 != -333948)
						{
							continue;
						}
					}
					else if (nMinute > 9)
					{
						if (295984 - 437534 == -141549)
						{
							continue;
						}
						num = 5;
						if (229397 - 401971 != -172574)
						{
							continue;
						}
					}
					int i = 0;
					if (238383 - 30984 != 207400)
					{
						while (i < num)
						{
							if (i == 2)
							{
								goto IL_882;
							}
							if (94881 - 465766 != -370885)
							{
								goto IL_20C;
							}
							if (i == 5)
							{
								if (56932 - 507616 != -450683)
								{
									goto IL_882;
								}
								goto IL_20C;
							}
							else
							{
								int num2 = 0;
								if (211641 - 158735 == 52907)
								{
									goto IL_20C;
								}
								int num3 = i;
								if (61547 - 187286 == -125738)
								{
									goto IL_20C;
								}
								if (num3 == 0)
								{
									if (107995 - 157992 != -49997)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nSecond, 0);
									if (141256 - 64640 == 76617)
									{
										goto IL_20C;
									}
								}
								else if (num3 == 1)
								{
									if (156349 - 417446 == -261096)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nSecond, 1);
									if (9135 - 515018 == -505882)
									{
										goto IL_20C;
									}
								}
								else if (num3 == 3)
								{
									if (295733 - 390802 != -95069)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nMinute, 0);
									if (287680 - 502268 != -214588)
									{
										goto IL_20C;
									}
								}
								else if (num3 == 4)
								{
									if (243128 - 519749 != -276621)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nMinute, 1);
									if (18894 - 68848 == -49953)
									{
										goto IL_20C;
									}
								}
								else if (num3 == 6)
								{
									if (230883 - 94557 != 136326)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nHour, 0);
									if (125345 - 317999 == -192653)
									{
										goto IL_20C;
									}
								}
								else if (num3 == 7)
								{
									if (117812 - 446961 == -329148)
									{
										goto IL_20C;
									}
									num2 = global::Math.getDigit(nHour, 1);
									if (129669 - 170449 == -40779)
									{
										goto IL_20C;
									}
								}
								int num4 = num2;
								if (3622 - 207078 == -203455)
								{
									goto IL_20C;
								}
								if (num4 == 1)
								{
									if (252346 - 259498 != -7152)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)41, scale * (float)65), Guix.bigNum_1);
									if (141749 - 2986 != 138763)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)37);
									if (9004 - 495087 != -486083)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 2)
								{
									if (298817 - 334098 != -35281)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)52, scale * (float)65), Guix.bigNum_2);
									if (65183 - 88625 != -23442)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)48);
									if (107621 - 341704 != -234083)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 3)
								{
									if (167032 - 235500 == -68467)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_3);
									if (277753 - 85972 != 191781)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)44);
									if (279208 - 76466 != 202742)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 4)
								{
									if (163944 - 251173 == -87228)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_4);
									if (5996 - 442684 == -436687)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)42);
									if (116186 - 321148 != -204962)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 5)
								{
									if (81429 - 29043 == 52387)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_5);
									if (274608 - 177068 != 97540)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)43);
									if (72433 - 299273 == -226839)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 6)
								{
									if (161629 - 485524 == -323894)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)48, scale * (float)65), Guix.bigNum_6);
									if (286676 - 57395 == 229282)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)44);
									if (17401 - 566555 != -549154)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 7)
								{
									if (16270 - 487404 == -471133)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_7);
									if (198042 - 428910 != -230868)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)41);
									if (210075 - 534310 != -324235)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 8)
								{
									if (125561 - 460982 == -335420)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)46, scale * (float)65), Guix.bigNum_8);
									if (77823 - 9110 != 68713)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)42);
									if (45101 - 80261 != -35160)
									{
										goto IL_20C;
									}
								}
								else if (num4 == 9)
								{
									if (17944 - 482070 == -464125)
									{
										goto IL_20C;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)47, scale * (float)65), Guix.bigNum_9);
									if (165482 - 5928 == 159555)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)43);
									if (17925 - 113486 != -95561)
									{
										goto IL_20C;
									}
								}
								else
								{
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)45, scale * (float)65), Guix.bigNum_0);
									if (105547 - 24273 == 81275)
									{
										goto IL_20C;
									}
									posx = (int)((float)posx - scale * (float)41);
									if (31756 - 469112 == -437355)
									{
										goto IL_20C;
									}
								}
							}
							IL_44:
							i++;
							if (284423 - 81981 != 202443)
							{
								continue;
							}
							goto IL_20C;
							IL_882:
							GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)36, scale * (float)65), Guix.bigNum_colon);
							if (165354 - 47278 != 118076)
							{
								goto IL_20C;
							}
							posx = (int)((float)posx - scale * (float)36);
							if (125334 - 123180 != 2155)
							{
								goto IL_44;
							}
							goto IL_20C;
						}
						if (240721 - 347385 == -106664)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06006135 RID: 24885 RVA: 0x00D4FFE4 File Offset: 0x00D4E1E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitSmallNumber()
	{
		if (173586 - 4052 != 169535)
		{
		}
		for (;;)
		{
			Guix.smallNum_1 = (Texture)Resources.Load("GameGui/Number/s1", typeof(Texture));
			if (216616 - 94159 == 122457)
			{
				Guix.smallNum_2 = (Texture)Resources.Load("GameGui/Number/s2", typeof(Texture));
				if (289841 - 325954 == -36113)
				{
					Guix.smallNum_3 = (Texture)Resources.Load("GameGui/Number/s3", typeof(Texture));
					if (199419 - 588471 == -389052)
					{
						Guix.smallNum_4 = (Texture)Resources.Load("GameGui/Number/s4", typeof(Texture));
						if (111631 - 400511 == -288880)
						{
							Guix.smallNum_5 = (Texture)Resources.Load("GameGui/Number/s5", typeof(Texture));
							if (70192 - 277440 == -207248)
							{
								Guix.smallNum_6 = (Texture)Resources.Load("GameGui/Number/s6", typeof(Texture));
								if (167616 - 361572 == -193956)
								{
									Guix.smallNum_7 = (Texture)Resources.Load("GameGui/Number/s7", typeof(Texture));
									if (1938 - 478886 != -476947)
									{
										Guix.smallNum_8 = (Texture)Resources.Load("GameGui/Number/s8", typeof(Texture));
										if (177361 - 402787 != -225425)
										{
											Guix.smallNum_9 = (Texture)Resources.Load("GameGui/Number/s9", typeof(Texture));
											if (220122 - 536844 == -316722)
											{
												Guix.smallNum_0 = (Texture)Resources.Load("GameGui/Number/s0", typeof(Texture));
												if (195538 - 410619 == -215081)
												{
													Guix.smallNum_tilda = (Texture)Resources.Load("GameGui/Number/sTilda", typeof(Texture));
													if (280790 - 395936 != -115145)
													{
														Guix.smallNum_init = true;
														if (193412 - 353323 == -159911)
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
			}
		}
	}

	// Token: 0x06006136 RID: 24886 RVA: 0x00D502A4 File Offset: 0x00D4E4A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderSmallNumber(int posx, int posy, int nNum, bool alignLeft, float scale)
	{
		if (22397 - 456738 != -434341)
		{
		}
		for (;;)
		{
			IL_39C:
			if (!Guix.smallNum_init)
			{
				if (126326 - 369298 != -242972)
				{
					continue;
				}
				Guix.InitSmallNumber();
				if (156099 - 328877 == -172777)
				{
					continue;
				}
			}
			int num = 1;
			if (275648 - 482144 == -206496)
			{
				int num2 = 4;
				if (290086 - 524332 == -234246)
				{
					if (!alignLeft)
					{
						if (277444 - 171092 != 106352)
						{
							continue;
						}
						num = -1;
						if (152027 - 248229 == -96201)
						{
							continue;
						}
					}
					scale = Mathf.Clamp(scale, 0.5f, 1.5f);
					if (226379 - 353399 == -127020)
					{
						int num3 = 0;
						if (193278 - 33426 == 159852)
						{
							int digitCount = global::Math.getDigitCount(nNum);
							if (129654 - 435663 == -306009)
							{
								int i = 0;
								if (147896 - 25959 == 121937)
								{
									while (i < digitCount)
									{
										if (alignLeft)
										{
											if (182062 - 153611 != 28451)
											{
												goto IL_39C;
											}
											num3 = global::Math.getDigit(nNum, digitCount - i - 1);
											if (65841 - 158651 != -92810)
											{
												goto IL_39C;
											}
										}
										else
										{
											num3 = global::Math.getDigit(nNum, i);
											if (253011 - 349823 == -96811)
											{
												goto IL_39C;
											}
										}
										int num4 = num3;
										if (164196 - 225291 == -61094)
										{
											goto IL_39C;
										}
										if (num4 == 1)
										{
											if (24159 - 266306 != -242147)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)16, scale * (float)26), Guix.smallNum_1);
											if (182333 - 230107 != -47774)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(16 - num2));
											if (231695 - 534405 != -302710)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 2)
										{
											if (198650 - 506869 != -308219)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)21, scale * (float)26), Guix.smallNum_2);
											if (19830 - 390246 == -370415)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(21 - num2));
											if (270905 - 355295 == -84389)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 3)
										{
											if (275790 - 255660 == 20131)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_3);
											if (139337 - 91687 == 47651)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(19 - num2));
											if (138530 - 129757 != 8773)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 4)
										{
											if (214718 - 269464 != -54746)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_4);
											if (172581 - 550283 != -377702)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(18 - num2));
											if (222523 - 16060 == 206464)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 5)
										{
											if (185105 - 133572 != 51533)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_5);
											if (60360 - 22152 != 38208)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(19 - num2));
											if (215872 - 312352 != -96480)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 6)
										{
											if (100903 - 222788 == -121884)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_6);
											if (256467 - 207979 != 48488)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(19 - num2));
											if (238189 - 450914 == -212724)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 7)
										{
											if (260537 - 72358 == 188180)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_7);
											if (80056 - 6120 != 73936)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(19 - num2));
											if (281365 - 116570 != 164795)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 8)
										{
											if (28456 - 80761 != -52305)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_8);
											if (211313 - 559530 != -348217)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(18 - num2));
											if (232667 - 532885 == -300217)
											{
												goto IL_39C;
											}
										}
										else if (num4 == 9)
										{
											if (194565 - 130433 != 64132)
											{
												goto IL_39C;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_9);
											if (210850 - 108599 == 102252)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(19 - num2));
											if (222028 - 245394 == -23365)
											{
												goto IL_39C;
											}
										}
										else
										{
											GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_0);
											if (163123 - 301578 != -138455)
											{
												goto IL_39C;
											}
											posx = (int)((float)posx + (float)num * scale * (float)(18 - num2));
											if (232750 - 515606 == -282855)
											{
												goto IL_39C;
											}
										}
										i++;
										if (95426 - 298694 == -203267)
										{
											goto IL_39C;
										}
									}
									if (184107 - 445968 != -261860)
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

	// Token: 0x06006137 RID: 24887 RVA: 0x00D50ACC File Offset: 0x00D4ECCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderSmallTilda(int posx, int posy, bool alignLeft, float scale)
	{
		if (262182 - 431059 != -168876)
		{
		}
		for (;;)
		{
			if (!Guix.smallNum_init)
			{
				if (199380 - 379184 == -179803)
				{
					continue;
				}
				Guix.InitSmallNumber();
				if (272629 - 206286 == 66344)
				{
					continue;
				}
			}
			scale = Mathf.Clamp(scale, 0.5f, 1.5f);
			if (190689 - 256996 == -66307)
			{
				GUI.DrawTexture(new Rect((float)(posx - 2), (float)posy, scale * (float)20, scale * (float)26), Guix.smallNum_tilda);
				if (294132 - 373115 != -78982)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06006138 RID: 24888 RVA: 0x00D50BB0 File Offset: 0x00D4EDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderTwoSmallNumberWithTilda(int posx, int posy, int nNum1, int nNum2, bool alignLeft, float scale)
	{
		if (286336 - 223951 != 62385)
		{
		}
		for (;;)
		{
			IL_8A4:
			if (!Guix.smallNum_init)
			{
				if (176057 - 514748 == -338690)
				{
					continue;
				}
				Guix.InitSmallNumber();
				if (47017 - 218987 != -171970)
				{
					continue;
				}
			}
			int num;
			if (alignLeft)
			{
				if (7733 - 502653 != -494920)
				{
					continue;
				}
				num = 1;
			}
			else
			{
				num = -1;
			}
			int num2 = num;
			scale = Mathf.Clamp(scale, 0.5f, 1.5f);
			if (214191 - 292282 == -78091)
			{
				int digitCount = global::Math.getDigitCount(nNum1);
				if (232261 - 165665 != 66597)
				{
					int digitCount2 = global::Math.getDigitCount(nNum2);
					if (68980 - 260950 == -191970)
					{
						int i = 0;
						if (157054 - 212844 != -55789)
						{
							while (i < digitCount + digitCount2 + 1)
							{
								if (!alignLeft)
								{
									goto IL_4FB;
								}
								if (62021 - 363306 != -301285)
								{
									goto IL_8A4;
								}
								if (i == digitCount)
								{
									goto IL_382;
								}
								if (182053 - 469158 != -287104)
								{
									goto IL_4FB;
								}
								goto IL_8A4;
								IL_63A:
								i++;
								if (215250 - 406646 != -191396)
								{
									goto IL_8A4;
								}
								continue;
								IL_4FB:
								if (!alignLeft)
								{
									if (295471 - 422380 == -126908)
									{
										goto IL_8A4;
									}
									if (i == digitCount2)
									{
										if (250819 - 147659 != 103161)
										{
											goto IL_382;
										}
										goto IL_8A4;
									}
								}
								if (261585 - 599065 == -337479)
								{
									goto IL_8A4;
								}
								int digit;
								if (alignLeft)
								{
									if (37446 - 2471 != 34975)
									{
										goto IL_8A4;
									}
									if (i < digitCount)
									{
										if (137981 - 472084 == -334102)
										{
											goto IL_8A4;
										}
										digit = global::Math.getDigit(nNum1, digitCount - i - 1);
										if (73771 - 433988 != -360217)
										{
											goto IL_8A4;
										}
									}
									else
									{
										digit = global::Math.getDigit(nNum2, digitCount2 - i + digitCount);
										if (228650 - 225325 == 3326)
										{
											goto IL_8A4;
										}
									}
								}
								else if (i < digitCount2)
								{
									if (102770 - 298299 != -195529)
									{
										goto IL_8A4;
									}
									digit = global::Math.getDigit(nNum2, i);
									if (298259 - 136501 == 161759)
									{
										goto IL_8A4;
									}
								}
								else
								{
									digit = global::Math.getDigit(nNum1, i - digitCount2 - 1);
									if (157033 - 238482 == -81448)
									{
										goto IL_8A4;
									}
								}
								int num3 = digit;
								if (210161 - 128917 != 81244)
								{
									goto IL_8A4;
								}
								if (num3 == 1)
								{
									if (186247 - 374888 == -188640)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)16, scale * (float)26), Guix.smallNum_1);
									if (196876 - 159426 != 37450)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)14);
									if (141739 - 495700 != -353960)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else if (num3 == 2)
								{
									if (208920 - 189884 != 19036)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)21, scale * (float)26), Guix.smallNum_2);
									if (33509 - 351168 == -317658)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)18);
									if (188732 - 296411 != -107679)
									{
										goto IL_8A4;
									}
									goto IL_63A;
								}
								else if (num3 == 3)
								{
									if (152926 - 169122 == -16195)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_3);
									if (68630 - 156505 != -87875)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)16);
									if (38114 - 373341 != -335226)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else if (num3 == 4)
								{
									if (224179 - 406747 != -182568)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_4);
									if (169791 - 173711 == -3919)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)15);
									if (200636 - 75064 != 125572)
									{
										goto IL_8A4;
									}
									goto IL_63A;
								}
								else if (num3 == 5)
								{
									if (108115 - 214587 != -106472)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_5);
									if (12424 - 164851 == -152426)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)16);
									if (177291 - 180392 != -3100)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else if (num3 == 6)
								{
									if (286280 - 105766 != 180514)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_6);
									if (82635 - 538149 != -455514)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)16);
									if (208362 - 502960 != -294598)
									{
										goto IL_8A4;
									}
									goto IL_63A;
								}
								else if (num3 == 7)
								{
									if (290821 - 81704 != 209117)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_7);
									if (78760 - 555093 == -476332)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)16);
									if (121818 - 336679 != -214860)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else if (num3 == 8)
								{
									if (143064 - 300566 != -157502)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_8);
									if (271566 - 140599 == 130968)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)15);
									if (142617 - 288003 != -145385)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else if (num3 == 9)
								{
									if (267848 - 14319 != 253529)
									{
										goto IL_8A4;
									}
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)19, scale * (float)26), Guix.smallNum_9);
									if (289526 - 342023 == -52496)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)16);
									if (143801 - 568694 != -424892)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								else
								{
									GUI.DrawTexture(new Rect((float)posx, (float)posy, scale * (float)18, scale * (float)26), Guix.smallNum_0);
									if (148948 - 402395 == -253446)
									{
										goto IL_8A4;
									}
									posx = (int)((float)posx + (float)num2 * scale * (float)15);
									if (27692 - 436139 != -408446)
									{
										goto IL_63A;
									}
									goto IL_8A4;
								}
								IL_382:
								GUI.DrawTexture(new Rect((float)(posx - 2), (float)posy, scale * (float)20, scale * (float)26), Guix.smallNum_tilda);
								if (15816 - 357585 == -341768)
								{
									goto IL_8A4;
								}
								posx = (int)((float)posx + (float)num2 * scale * (float)24);
								if (211462 - 150678 != 60784)
								{
									goto IL_8A4;
								}
								goto IL_63A;
							}
							if (62995 - 570310 == -507315)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06006139 RID: 24889 RVA: 0x00D51534 File Offset: 0x00D4F734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitGoldenNumber()
	{
		if (104354 - 564948 != -460594)
		{
		}
		for (;;)
		{
			Guix.goldenNum_1 = (Texture)Resources.Load("GameGui/Number/g1", typeof(Texture));
			if (290391 - 480510 == -190119)
			{
				Guix.goldenNum_2 = (Texture)Resources.Load("GameGui/Number/g2", typeof(Texture));
				if (145488 - 557192 != -411703)
				{
					Guix.goldenNum_3 = (Texture)Resources.Load("GameGui/Number/g3", typeof(Texture));
					if (98625 - 62235 != 36391)
					{
						Guix.goldenNum_4 = (Texture)Resources.Load("GameGui/Number/g4", typeof(Texture));
						if (89255 - 190621 != -101365)
						{
							Guix.goldenNum_5 = (Texture)Resources.Load("GameGui/Number/g5", typeof(Texture));
							if (283666 - 561205 != -277538)
							{
								Guix.goldenNum_6 = (Texture)Resources.Load("GameGui/Number/g6", typeof(Texture));
								if (15870 - 300131 != -284260)
								{
									Guix.goldenNum_7 = (Texture)Resources.Load("GameGui/Number/g7", typeof(Texture));
									if (203932 - 589818 == -385886)
									{
										Guix.goldenNum_8 = (Texture)Resources.Load("GameGui/Number/g8", typeof(Texture));
										if (61573 - 428273 != -366699)
										{
											Guix.goldenNum_9 = (Texture)Resources.Load("GameGui/Number/g9", typeof(Texture));
											if (2746 - 226966 != -224219)
											{
												Guix.goldenNum_0 = (Texture)Resources.Load("GameGui/Number/g0", typeof(Texture));
												if (148096 - 459112 != -311015)
												{
													Guix.goldenNum_init = true;
													if (238747 - 424309 != -185561)
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
		}
	}

	// Token: 0x0600613A RID: 24890 RVA: 0x00D517BC File Offset: 0x00D4F9BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderGoldenNumber(int posx, int posy, int nNum, bool alignLeft)
	{
		if (139803 - 261205 != -121402)
		{
		}
		for (;;)
		{
			IL_361:
			if (!Guix.goldenNum_init)
			{
				if (157839 - 351038 != -193199)
				{
					continue;
				}
				Guix.InitGoldenNumber();
				if (30243 - 69326 == -39082)
				{
					continue;
				}
			}
			int num = 1;
			if (51754 - 151160 == -99406)
			{
				int num2 = 4;
				if (282002 - 332068 == -50066)
				{
					if (!alignLeft)
					{
						if (156555 - 204247 == -47691)
						{
							continue;
						}
						num = -1;
						if (202032 - 544431 != -342399)
						{
							continue;
						}
					}
					int num3 = 0;
					if (64951 - 410941 == -345990)
					{
						int digitCount = global::Math.getDigitCount(nNum);
						if (47965 - 285402 != -237436)
						{
							int i = 0;
							if (298225 - 385173 != -86947)
							{
								while (i < digitCount)
								{
									if (alignLeft)
									{
										if (22776 - 33098 != -10322)
										{
											goto IL_361;
										}
										num3 = global::Math.getDigit(nNum, digitCount - i - 1);
										if (72453 - 196285 == -123831)
										{
											goto IL_361;
										}
									}
									else
									{
										num3 = global::Math.getDigit(nNum, i);
										if (247333 - 262580 != -15247)
										{
											goto IL_361;
										}
									}
									int num4 = num3;
									if (168129 - 98668 != 69461)
									{
										goto IL_361;
									}
									if (num4 == 1)
									{
										if (276773 - 379396 == -102622)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)12, (float)21), Guix.goldenNum_1);
										if (135885 - 561773 == -425887)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (4140 - 499803 == -495662)
										{
											goto IL_361;
										}
									}
									else if (num4 == 2)
									{
										if (246920 - 342403 != -95483)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)13, (float)21), Guix.goldenNum_2);
										if (171852 - 538183 != -366331)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (281625 - 184367 != 97258)
										{
											goto IL_361;
										}
									}
									else if (num4 == 3)
									{
										if (194739 - 466737 != -271998)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)12, (float)21), Guix.goldenNum_3);
										if (112382 - 347448 != -235066)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (193787 - 471886 == -278098)
										{
											goto IL_361;
										}
									}
									else if (num4 == 4)
									{
										if (108204 - 47380 != 60824)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)13, (float)21), Guix.goldenNum_4);
										if (65360 - 466184 == -400823)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (273397 - 561099 == -287701)
										{
											goto IL_361;
										}
									}
									else if (num4 == 5)
									{
										if (11708 - 310923 == -299214)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)13, (float)21), Guix.goldenNum_5);
										if (458 - 534427 == -533968)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (47313 - 20279 == 27035)
										{
											goto IL_361;
										}
									}
									else if (num4 == 6)
									{
										if (178170 - 184579 != -6409)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)13, (float)21), Guix.goldenNum_6);
										if (160561 - 151255 == 9307)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (68428 - 397786 == -329357)
										{
											goto IL_361;
										}
									}
									else if (num4 == 7)
									{
										if (1690 - 60876 != -59186)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)11, (float)21), Guix.goldenNum_7);
										if (290139 - 298914 == -8774)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (81880 - 70138 != 11742)
										{
											goto IL_361;
										}
									}
									else if (num4 == 8)
									{
										if (56185 - 344858 == -288672)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)11, (float)21), Guix.goldenNum_8);
										if (49293 - 327543 != -278250)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (285860 - 211924 == 73937)
										{
											goto IL_361;
										}
									}
									else if (num4 == 9)
									{
										if (151945 - 21041 != 130904)
										{
											goto IL_361;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)13, (float)21), Guix.goldenNum_9);
										if (126703 - 400734 == -274030)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (119801 - 591891 == -472089)
										{
											goto IL_361;
										}
									}
									else
									{
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)12, (float)21), Guix.goldenNum_0);
										if (18230 - 414847 != -396617)
										{
											goto IL_361;
										}
										posx += num * (15 - num2);
										if (278812 - 338478 == -59665)
										{
											goto IL_361;
										}
									}
									i++;
									if (14272 - 440474 == -426201)
									{
										goto IL_361;
									}
								}
								if (39111 - 158975 != -119863)
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

	// Token: 0x0600613B RID: 24891 RVA: 0x00D51ED4 File Offset: 0x00D500D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitRankNumber()
	{
		if (257769 - 6712 != 251057)
		{
		}
		for (;;)
		{
			Guix.rank_s = (Texture)Resources.Load("GameGui/Number/rank_s", typeof(Texture));
			if (75885 - 110195 != -34309)
			{
				Guix.rank_a = (Texture)Resources.Load("GameGui/Number/rank_a", typeof(Texture));
				if (52318 - 240876 == -188558)
				{
					Guix.rank_b = (Texture)Resources.Load("GameGui/Number/rank_b", typeof(Texture));
					if (138763 - 269996 != -131232)
					{
						Guix.rank_c = (Texture)Resources.Load("GameGui/Number/rank_c", typeof(Texture));
						if (63560 - 27368 != 36193)
						{
							Guix.rank_d = (Texture)Resources.Load("GameGui/Number/rank_d", typeof(Texture));
							if (54096 - 563929 == -509833)
							{
								Guix.rank_p = (Texture)Resources.Load("GameGui/Number/rank_p", typeof(Texture));
								if (20551 - 267488 == -246937)
								{
									Guix.rank_m = (Texture)Resources.Load("GameGui/Number/rank_m", typeof(Texture));
									if (130645 - 121181 != 9465)
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

	// Token: 0x0600613C RID: 24892 RVA: 0x00D52094 File Offset: 0x00D50294
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderRankNumber(int posx, int posy, int nRank, float nScale)
	{
		if (110948 - 304259 != -193310)
		{
		}
		for (;;)
		{
			if (!Guix.rank_init)
			{
				if (67485 - 36862 != 30623)
				{
					continue;
				}
				Guix.InitRankNumber();
				if (41285 - 394094 == -352808)
				{
					continue;
				}
			}
			nScale = Mathf.Clamp(nScale, 0.5f, 1.5f);
			if (283760 - 22470 != 261291)
			{
				if (12173 - 514053 == -501880)
				{
					if (nRank == 0)
					{
						if (231882 - 501145 != -269262)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)32, nScale * (float)31), Guix.rank_m);
							if (89992 - 271832 == -181840)
							{
								break;
							}
						}
					}
					else if (nRank == 1)
					{
						if (50636 - 145847 != -95210)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)38, nScale * (float)36), Guix.rank_d);
							if (225099 - 167146 == 57953)
							{
								break;
							}
						}
					}
					else if (nRank == 2)
					{
						if (156826 - 547548 == -390722)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)34, nScale * (float)36), Guix.rank_c);
							if (121917 - 274480 != -152562)
							{
								break;
							}
						}
					}
					else if (nRank == 3)
					{
						if (231040 - 540298 != -309257)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)38, nScale * (float)36), Guix.rank_b);
							if (181160 - 233140 != -51979)
							{
								break;
							}
						}
					}
					else if (nRank == 4)
					{
						if (53965 - 32054 == 21911)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)36, nScale * (float)36), Guix.rank_a);
							if (130364 - 96457 == 33907)
							{
								break;
							}
						}
					}
					else
					{
						if (nRank != 5)
						{
							break;
						}
						if (118378 - 599292 != -480913)
						{
							GUI.DrawTexture(new Rect((float)posx, (float)posy, nScale * (float)31, nScale * (float)36), Guix.rank_s);
							if (143065 - 149202 == -6137)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600613D RID: 24893 RVA: 0x00D52388 File Offset: 0x00D50588
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void InitToolTip()
	{
		if (10934 - 446671 != -435736)
		{
		}
		for (;;)
		{
			Guix.toolTipStyle = new GUIStyle();
			if (286041 - 208091 == 77950)
			{
				Guix.toolTipStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
				if (201547 - 551330 != -349782)
				{
					Guix.toolTipNameStyle = new GUIStyle();
					if (244467 - 369223 == -124756)
					{
						Guix.toolTipNameStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
						if (196483 - 340192 == -143709)
						{
							Guix.toolTipNameStyle.alignment = TextAnchor.MiddleLeft;
							if (158373 - 268423 != -110049)
							{
								Guix.toolTipNameStyle.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
								if (287945 - 207076 == 80869)
								{
									Guix.toolTipDesStyle = new GUIStyle();
									if (171693 - 492771 != -321077)
									{
										Guix.toolTipDesStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
										if (236378 - 157143 != 79236)
										{
											Guix.toolTipDesStyle.alignment = TextAnchor.UpperLeft;
											if (282171 - 349040 != -66868)
											{
												Guix.toolTipDesStyle.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
												if (129421 - 501483 == -372062)
												{
													Guix.toolTipDesStyle.wordWrap = true;
													if (2232 - 552966 != -550733)
													{
														Guix.toolTipNumStyle = new GUIStyle();
														if (107602 - 242110 == -134508)
														{
															Guix.toolTipNumStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
															if (283174 - 138568 == 144606)
															{
																Guix.toolTipNumStyle.alignment = TextAnchor.UpperLeft;
																if (129961 - 443767 != -313805)
																{
																	Guix.toolTipNumStyle.normal.textColor = new Color(0.15f, 0.1f, (float)0, (float)1);
																	if (192365 - 585810 != -393444)
																	{
																		Guix.toolTipNumStyle.wordWrap = true;
																		if (135777 - 525441 == -389664)
																		{
																			Guix.toolTipBnsStyle = new GUIStyle();
																			if (228782 - 209477 == 19305)
																			{
																				Guix.toolTipBnsStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO28", typeof(Font));
																				if (45366 - 125095 != -79728)
																				{
																					Guix.toolTipBnsStyle.alignment = TextAnchor.UpperLeft;
																					if (290882 - 257363 != 33520)
																					{
																						Guix.toolTipBnsStyle.normal.textColor = new Color(0.17f, 0.29f, 0.24f, (float)1);
																						if (139384 - 184352 == -44968)
																						{
																							Guix.toolTipBnsStyle.wordWrap = true;
																							if (122182 - 360472 != -238289)
																							{
																								Guix.toolTipBlueStyle = new GUIStyle();
																								if (126691 - 66350 == 60341)
																								{
																									Guix.toolTipBlueStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																									if (92019 - 457815 == -365796)
																									{
																										Guix.toolTipBlueStyle.normal.textColor = new Color(0.24f, 0.28f, 0.39f, (float)1);
																										if (73268 - 150212 == -76944)
																										{
																											Guix.toolTipBlueStyle.alignment = TextAnchor.UpperLeft;
																											if (154294 - 341666 != -187371)
																											{
																												Guix.toolTipBlueStyle.wordWrap = true;
																												if (204060 - 293004 != -88943)
																												{
																													Guix.toolTipRedStyle = new GUIStyle();
																													if (178466 - 139029 == 39437)
																													{
																														Guix.toolTipRedStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																														if (124377 - 391442 != -267064)
																														{
																															Guix.toolTipRedStyle.normal.textColor = new Color(0.51f, 0.2f, 0.2f, (float)1);
																															if (236882 - 430046 != -193163)
																															{
																																Guix.toolTipRedStyle.alignment = TextAnchor.UpperLeft;
																																if (37204 - 475661 != -438456)
																																{
																																	Guix.toolTipRedStyle.wordWrap = true;
																																	if (155829 - 241280 == -85451)
																																	{
																																		Guix.toolTipPurpleStyle = new GUIStyle();
																																		if (34997 - 195685 != -160687)
																																		{
																																			Guix.toolTipPurpleStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO24", typeof(Font));
																																			if (184009 - 245518 == -61509)
																																			{
																																				Guix.toolTipPurpleStyle.normal.textColor = new Color(0.36f, (float)0, 0.65f, (float)1);
																																				if (204799 - 57565 == 147234)
																																				{
																																					Guix.toolTipPurpleStyle.alignment = TextAnchor.UpperLeft;
																																					if (80888 - 568885 != -487996)
																																					{
																																						Guix.toolTipPurpleStyle.wordWrap = true;
																																						if (282911 - 314225 == -31314)
																																						{
																																							Guix.toolTipActiveStyle = new GUIStyle();
																																							if (281571 - 204761 == 76810)
																																							{
																																								Guix.toolTipActiveStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																								if (13074 - 470722 != -457647)
																																								{
																																									Guix.toolTipActiveStyle.alignment = TextAnchor.MiddleLeft;
																																									if (129307 - 88288 != 41020)
																																									{
																																										Guix.toolTipActiveStyle.normal.textColor = new Color(0.51f, 0.2f, 0.2f, (float)1);
																																										if (98842 - 315615 != -216772)
																																										{
																																											Guix.toolTipPassiveStyle = new GUIStyle();
																																											if (288850 - 240816 == 48034)
																																											{
																																												Guix.toolTipPassiveStyle.font = (Font)Resources.Load("GameGui/Fonts/GMO32", typeof(Font));
																																												if (84261 - 196709 == -112448)
																																												{
																																													Guix.toolTipPassiveStyle.alignment = TextAnchor.MiddleLeft;
																																													if (109509 - 84292 == 25217)
																																													{
																																														Guix.toolTipPassiveStyle.normal.textColor = new Color(0.24f, 0.28f, 0.39f, (float)1);
																																														if (167923 - 163876 != 4048)
																																														{
																																															Guix.toolTip_item = (Texture)Resources.Load("GameGui/Common/toolTip_item", typeof(Texture));
																																															if (243465 - 65248 == 178217)
																																															{
																																																Guix.toolTip_equipment = (Texture)Resources.Load("GameGui/Common/toolTip_equipment", typeof(Texture));
																																																if (275661 - 99265 != 176397)
																																																{
																																																	Guix.toolTip_skill = (Texture)Resources.Load("GameGui/Common/toolTip_skill", typeof(Texture));
																																																	if (214376 - 316050 == -101674)
																																																	{
																																																		Guix.toolTip_slot1 = (Texture)Resources.Load("GameGui/Common/toolTip_slot1", typeof(Texture));
																																																		if (64170 - 587470 != -523299)
																																																		{
																																																			Guix.toolTip_slot2 = (Texture)Resources.Load("GameGui/Common/toolTip_slot2", typeof(Texture));
																																																			if (167216 - 399462 == -232246)
																																																			{
																																																				Guix.toolTip_special = (Texture)Resources.Load("GameGui/Common/toolTip_special", typeof(Texture));
																																																				if (268641 - 556955 != -288313)
																																																				{
																																																					Guix.toolTip_init = true;
																																																					if (61116 - 141832 != -80715)
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
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600613E RID: 24894 RVA: 0x00D52D50 File Offset: 0x00D50F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderItemToolTip(int posx, int posy, InventoryClass nHoverItem, Texture nHoverImage)
	{
		if (16654 - 216387 != -199733)
		{
		}
		for (;;)
		{
			IL_BDD:
			if (!Guix.toolTip_init)
			{
				if (93666 - 564505 == -470839)
				{
					Guix.InitToolTip();
					if (190582 - 300773 != -110190)
					{
						break;
					}
				}
			}
			else
			{
				if (nHoverItem == null)
				{
					break;
				}
				if (228341 - 249699 == -21358)
				{
					CharacterDataClass current = CharacterData.current;
					if (235647 - 514024 != -278376)
					{
						ItemClass itemData = ItemData.getItemData(nHoverItem.name);
						if (204436 - 473013 == -268577)
						{
							string text = "none";
							if (189998 - 342258 == -152260)
							{
								string heading = Stringf.getHeading(nHoverItem.name);
								if (245549 - 299466 == -53917)
								{
									if (heading == "w")
									{
										if (116774 - 590045 != -473271)
										{
											continue;
										}
										text = "Weapon";
										if (221305 - 570395 != -349090)
										{
											continue;
										}
									}
									else if (heading == "a")
									{
										if (293482 - 303942 == -10459)
										{
											continue;
										}
										text = "Armor";
										if (45624 - 221509 != -175885)
										{
											continue;
										}
									}
									else if (heading == "c")
									{
										if (261108 - 336017 != -74909)
										{
											continue;
										}
										text = "Accessory";
										if (274830 - 423912 != -149082)
										{
											continue;
										}
									}
									else if (heading == "b")
									{
										if (74506 - 582563 != -508057)
										{
											continue;
										}
										text = "Boots";
										if (268496 - 284655 != -16159)
										{
											continue;
										}
									}
									else if (heading == "t")
									{
										if (216024 - 419405 != -203381)
										{
											continue;
										}
										text = "Trinket";
										if (36450 - 72559 == -36108)
										{
											continue;
										}
									}
									else if (heading == "p")
									{
										if (20474 - 512625 == -492150)
										{
											continue;
										}
										text = "Pet";
										if (9160 - 490361 == -481200)
										{
											continue;
										}
									}
									else if (heading == "o")
									{
										if (96384 - 519750 != -423366)
										{
											continue;
										}
										text = "Mount";
										if (107717 - 574979 != -467262)
										{
											continue;
										}
									}
									else if (heading == "n")
									{
										if (56391 - 113139 == -56747)
										{
											continue;
										}
										text = "Coin";
										if (283279 - 129226 == 154054)
										{
											continue;
										}
									}
									else if (heading == "f")
									{
										if (40635 - 21756 == 18880)
										{
											continue;
										}
										text = "Field item";
										if (101074 - 43484 == 57591)
										{
											continue;
										}
									}
									else if (heading == "m")
									{
										if (218718 - 553673 == -334954)
										{
											continue;
										}
										text = "Material";
										if (288511 - 191620 != 96891)
										{
											continue;
										}
									}
									else if (heading == "d")
									{
										if (98285 - 130725 == -32439)
										{
											continue;
										}
										text = "Food";
										if (280892 - 171406 == 109487)
										{
											continue;
										}
									}
									else if (heading == "r")
									{
										if (216042 - 507960 == -291917)
										{
											continue;
										}
										text = "Recipe";
										if (100464 - 124527 != -24063)
										{
											continue;
										}
									}
									else if (heading == "k")
									{
										if (127877 - 559988 == -432110)
										{
											continue;
										}
										text = "Key item";
										if (103795 - 483448 != -379653)
										{
											continue;
										}
									}
									string heading2 = Stringf.getHeading(nHoverItem.name);
									if (125155 - 393309 != -268153)
									{
										if (heading2 == "w")
										{
											if (288797 - 582120 == -293322)
											{
												continue;
											}
										}
										else if (heading2 == "a")
										{
											if (279584 - 368740 == -89155)
											{
												continue;
											}
										}
										else if (heading2 == "c")
										{
											if (230459 - 327484 != -97025)
											{
												continue;
											}
										}
										else if (heading2 == "b")
										{
											if (254853 - 209961 != 44892)
											{
												continue;
											}
										}
										else if (heading2 == "t")
										{
											if (274453 - 598515 == -324061)
											{
												continue;
											}
										}
										else if (heading2 == "p")
										{
											if (174479 - 537066 == -362586)
											{
												continue;
											}
										}
										else if (heading2 == "o")
										{
											if (212497 - 143634 != 68863)
											{
												continue;
											}
										}
										else
										{
											posy = Mathf.Clamp(posy, 40, 700);
											if (194353 - 297188 != -102835)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)256, (float)256), Guix.toolTip_item);
											if (70592 - 188923 != -118331)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 18), (float)(posy + 8), (float)190, (float)30), itemData.name, Guix.toolTipNameStyle);
											if (119968 - 418067 == -298098)
											{
												continue;
											}
											if (nHoverImage)
											{
												if (46538 - 444683 == -398144)
												{
													continue;
												}
												GUI.DrawTexture(new Rect((float)(posx + 20), (float)(posy + 45), (float)64, (float)64), nHoverImage);
												if (246436 - 164669 == 81768)
												{
													continue;
												}
											}
											GUI.Label(new Rect((float)(posx + 24), (float)(posy + 128), (float)200, (float)90), itemData.des, Guix.toolTipDesStyle);
											if (56874 - 426186 == -369311)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 132), (float)(posy + 42), (float)200, (float)30), text, Guix.toolTipBlueStyle);
											if (297756 - 327328 != -29572)
											{
												continue;
											}
											if (itemData.lv >= 0)
											{
												if (47446 - 282861 != -235415)
												{
													continue;
												}
												GUI.Label(new Rect((float)(posx + 132), (float)(posy + 64), (float)200, (float)30), "All", Guix.toolTipBlueStyle);
												if (69116 - 572754 != -503638)
												{
													continue;
												}
												break;
											}
											else if (PlayerData.Rank >= itemData.lv)
											{
												if (249404 - 138917 == 110488)
												{
													continue;
												}
												GUI.Label(new Rect((float)(posx + 132), (float)(posy + 64), (float)200, (float)30), RankData.getRankName(Mathf.Abs(itemData.lv) + 4), Guix.toolTipPurpleStyle);
												if (252273 - 357461 != -105188)
												{
													continue;
												}
												break;
											}
											else
											{
												GUI.Label(new Rect((float)(posx + 132), (float)(posy + 64), (float)200, (float)30), RankData.getRankName(Mathf.Abs(itemData.lv)), Guix.toolTipRedStyle);
												if (132991 - 352322 != -219331)
												{
													continue;
												}
												break;
											}
										}
										IL_9E9:
										posy = Mathf.Clamp(posy - 120, 40, 600);
										if (255998 - 472925 != -216927)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)256, (float)348), Guix.toolTip_equipment);
										if (290070 - 419938 != -129868)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 18), (float)(posy + 8), (float)190, (float)30), itemData.name, Guix.toolTipNameStyle);
										if (158103 - 168524 == -10420)
										{
											continue;
										}
										if (itemData.lv >= 0)
										{
											if (13851 - 519073 != -505222)
											{
												continue;
											}
											if (current.lv >= itemData.lv)
											{
												if (134863 - 577010 != -442147)
												{
													continue;
												}
												GUI.Label(new Rect((float)(posx + 226), (float)(posy + 13), (float)200, (float)30), string.Empty + itemData.lv, Guix.toolTipBlueStyle);
												if (291654 - 77807 != 213847)
												{
													continue;
												}
											}
											else
											{
												GUI.Label(new Rect((float)(posx + 226), (float)(posy + 13), (float)200, (float)30), string.Empty + itemData.lv, Guix.toolTipRedStyle);
												if (227905 - 142738 == 85168)
												{
													continue;
												}
											}
										}
										else if (PlayerData.Rank <= itemData.lv)
										{
											if (270681 - 571525 != -300844)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 226), (float)(posy + 13), (float)200, (float)30), string.Empty + Mathf.Abs(itemData.lv), Guix.toolTipPurpleStyle);
											if (234915 - 572420 != -337505)
											{
												continue;
											}
										}
										else
										{
											GUI.Label(new Rect((float)(posx + 226), (float)(posy + 13), (float)200, (float)30), string.Empty + Mathf.Abs(itemData.lv), Guix.toolTipRedStyle);
											if (120102 - 74811 != 45291)
											{
												continue;
											}
										}
										if (text != "none")
										{
											if (193561 - 91880 == 101682)
											{
												continue;
											}
											if (current.canEquip(nHoverItem.name))
											{
												if (58963 - 576812 == -517848)
												{
													continue;
												}
												GUI.Label(new Rect((float)(posx + 140), (float)(posy + 42), (float)200, (float)30), text, Guix.toolTipBlueStyle);
												if (297006 - 173110 == 123897)
												{
													continue;
												}
											}
											else
											{
												GUI.Label(new Rect((float)(posx + 140), (float)(posy + 42), (float)200, (float)30), text, Guix.toolTipRedStyle);
												if (168555 - 534114 == -365558)
												{
													continue;
												}
											}
										}
										if (itemData.lv >= 0)
										{
											if (40800 - 17573 == 23228)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 140), (float)(posy + 64), (float)200, (float)30), "All", Guix.toolTipBlueStyle);
											if (143683 - 524095 != -380412)
											{
												continue;
											}
										}
										else if (PlayerData.Rank >= itemData.lv)
										{
											if (201006 - 115979 == 85028)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 140), (float)(posy + 64), (float)200, (float)30), RankData.getRankName(Mathf.Abs(itemData.lv) + 4), Guix.toolTipPurpleStyle);
											if (96938 - 473764 == -376825)
											{
												continue;
											}
										}
										else
										{
											GUI.Label(new Rect((float)(posx + 140), (float)(posy + 64), (float)200, (float)30), RankData.getRankName(Mathf.Abs(itemData.lv + 4)), Guix.toolTipRedStyle);
											if (31336 - 332115 == -300778)
											{
												continue;
											}
										}
										if (nHoverItem.mlv > 0)
										{
											if (273696 - 73185 == 200512)
											{
												continue;
											}
											int i = 0;
											if (22452 - 350476 == -328023)
											{
												continue;
											}
											while (i < nHoverItem.mlv)
											{
												if (nHoverItem.lv > i)
												{
													if (259261 - 321271 == -62009)
													{
														goto IL_BDD;
													}
													GUI.DrawTexture(new Rect((float)(posx + 140 + 16 * i), (float)(posy + 92), (float)16, (float)16), Guix.toolTip_slot2);
													if (119196 - 213304 == -94107)
													{
														goto IL_BDD;
													}
												}
												else
												{
													GUI.DrawTexture(new Rect((float)(posx + 140 + 16 * i), (float)(posy + 92), (float)16, (float)16), Guix.toolTip_slot1);
													if (157565 - 197868 == -40302)
													{
														goto IL_BDD;
													}
												}
												i++;
												if (26635 - 125250 == -98614)
												{
													goto IL_BDD;
												}
											}
											if (260016 - 74303 == 185714)
											{
												continue;
											}
										}
										else
										{
											GUI.Label(new Rect((float)(posx + 140), (float)(posy + 85), (float)200, (float)30), "none", Guix.toolTipRedStyle);
											if (80658 - 345073 != -264415)
											{
												continue;
											}
										}
										if (nHoverImage)
										{
											if (108180 - 431910 == -323729)
											{
												continue;
											}
											GUI.DrawTexture(new Rect((float)(posx + 20), (float)(posy + 45), (float)64, (float)64), nHoverImage);
											if (176282 - 171554 != 4728)
											{
												continue;
											}
										}
										GUI.Label(new Rect((float)(posx + 28), (float)(posy + 222), (float)200, (float)90), "  " + itemData.des, Guix.toolTipDesStyle);
										if (130549 - 342706 != -212157)
										{
											continue;
										}
										int j = 0;
										if (266530 - 436774 == -170243)
										{
											continue;
										}
										while (j < 8)
										{
											int num = itemData.att[j];
											if (182 - 229105 != -228923)
											{
												goto IL_BDD;
											}
											int num2 = nHoverItem.att[j];
											if (22828 - 107146 == -84317)
											{
												goto IL_BDD;
											}
											if (num != 0)
											{
												goto IL_C58;
											}
											if (89076 - 319931 == -230854)
											{
												goto IL_BDD;
											}
											if (num2 != 0)
											{
												if (46286 - 295186 != -248899)
												{
													goto IL_C58;
												}
												goto IL_BDD;
											}
											else
											{
												GUI.Label(new Rect((float)(posx + 75 + 100 * global::Math.div((float)j, (float)4)), (float)(posy + 112 + 20 * (j % 4)), (float)30, (float)20), "-", Guix.toolTipDesStyle);
												if (17049 - 598918 != -581869)
												{
													goto IL_BDD;
												}
											}
											IL_7FF:
											j++;
											if (119575 - 31842 != 87734)
											{
												continue;
											}
											goto IL_BDD;
											IL_C58:
											GUI.Label(new Rect((float)(posx + 75 + 100 * global::Math.div((float)j, (float)4)), (float)(posy + 110 + 20 * (j % 4)), (float)30, (float)24), string.Empty + num, Guix.toolTipNumStyle);
											if (267710 - 134099 != 133611)
											{
												goto IL_BDD;
											}
											if (num2 > 0)
											{
												if (142144 - 37475 != 104669)
												{
													goto IL_BDD;
												}
												GUI.Label(new Rect((float)(posx + 96 + 100 * global::Math.div((float)j, (float)4)), (float)(posy + 110 + 20 * (j % 4)), (float)36, (float)24), "+" + num2, Guix.toolTipBnsStyle);
												if (31440 - 141519 != -110079)
												{
													goto IL_BDD;
												}
											}
											else if (num2 < 0)
											{
												if (289304 - 182310 != 106994)
												{
													goto IL_BDD;
												}
												GUI.Label(new Rect((float)(posx + 96 + 100 * global::Math.div((float)j, (float)4)), (float)(posy + 110 + 20 * (j % 4)), (float)36, (float)24), "-" + num2, Guix.toolTipBnsStyle);
												if (267931 - 558241 == -290309)
												{
													goto IL_BDD;
												}
											}
											goto IL_7FF;
										}
										if (225007 - 548723 != -323716)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 200), (float)(posy + 311), (float)200, (float)30), string.Empty + itemData.weight, Guix.toolTipNumStyle);
										if (296573 - 113689 == 182885)
										{
											continue;
										}
										if (!(itemData.special != "none"))
										{
											break;
										}
										if (171168 - 569927 == -398758)
										{
											continue;
										}
										GUI.DrawTexture(new Rect((float)(posx + 32), (float)(posy + 296), (float)18, (float)18), Guix.toolTip_special);
										if (298851 - 557846 != -258995)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 60), (float)(posy + 292), (float)200, (float)30), itemData.special, Guix.toolTipPurpleStyle);
										if (219781 - 257409 != -37627)
										{
											break;
										}
										continue;
										IL_C01:
										goto IL_9E9;
										IL_A7F:
										goto IL_C01;
										IL_45:
										goto IL_A7F;
										IL_BAD:
										goto IL_45;
										goto IL_BAD;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600613F RID: 24895 RVA: 0x00D54154 File Offset: 0x00D52354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void renderSkillToolTip(int posx, int posy, string hoverToolTip, Texture nHoverImage)
	{
		if (163978 - 284297 != -120319)
		{
		}
		for (;;)
		{
			if (!Guix.toolTip_init)
			{
				if (77566 - 387370 == -309804)
				{
					Guix.InitToolTip();
					if (91835 - 321952 == -230117)
					{
						break;
					}
				}
			}
			else
			{
				if (!(hoverToolTip != "none"))
				{
					break;
				}
				if (147394 - 521753 != -374358)
				{
					SkillClass skill = SkillData.getSkill(hoverToolTip);
					if (175447 - 522496 == -347049)
					{
						GUI.DrawTexture(new Rect((float)posx, (float)posy, (float)256, (float)300), Guix.toolTip_skill);
						if (54875 - 7273 == 47602)
						{
							GUI.Label(new Rect((float)(posx + 24), (float)(posy + 8), (float)210, (float)30), SkillData.getDisplayName(hoverToolTip), Guix.toolTipNameStyle);
							if (2318 - 414991 == -412673)
							{
								if (nHoverImage)
								{
									if (7243 - 495415 == -488171)
									{
										continue;
									}
									GUI.DrawTexture(new Rect((float)(posx + 29), (float)(posy + 48), (float)64, (float)64), nHoverImage);
									if (264591 - 350319 != -85728)
									{
										continue;
									}
								}
								eSkillType type = skill.type;
								if (103393 - 599735 != -496341)
								{
									if (type == eSkillType.normal)
									{
										if (38279 - 404792 != -366513)
										{
											continue;
										}
										if (skill.mode == eSkillMode.passive)
										{
											if (138332 - 15150 == 123183)
											{
												continue;
											}
											GUI.Label(new Rect((float)(posx + 150), (float)(posy + 48), (float)80, (float)30), "Passive", Guix.toolTipPassiveStyle);
											if (27551 - 131288 == -103736)
											{
												continue;
											}
										}
										else
										{
											GUI.Label(new Rect((float)(posx + 150), (float)(posy + 48), (float)80, (float)30), "Active", Guix.toolTipActiveStyle);
											if (134005 - 271134 != -137129)
											{
												continue;
											}
										}
									}
									else if (type == eSkillType.support)
									{
										if (111210 - 533455 == -422244)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 150), (float)(posy + 48), (float)80, (float)30), "Support", Guix.toolTipPassiveStyle);
										if (79248 - 109016 != -29768)
										{
											continue;
										}
									}
									else if (type == eSkillType.finalMove)
									{
										if (57525 - 268987 == -211461)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 150), (float)(posy + 48), (float)80, (float)30), "Final move", Guix.toolTipPassiveStyle);
										if (35811 - 362875 == -327063)
										{
											continue;
										}
									}
									if (skill.cSP == 0)
									{
										if (16074 - 251864 != -235790)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 135), (float)(posy + 70), (float)200, (float)30), "-", Guix.toolTipDesStyle);
										if (298941 - 186352 == 112590)
										{
											continue;
										}
									}
									else if (skill.cSP > 0)
									{
										if (70337 - 15969 != 54368)
										{
											continue;
										}
										Guix.toolTipStyle.normal.textColor = new Color(0.2f, 0.6f, (float)1, (float)1);
										if (291979 - 560402 == -268422)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 135), (float)(posy + 70), (float)200, (float)30), string.Empty + skill.cSP, Guix.toolTipStyle);
										if (29043 - 523910 == -494866)
										{
											continue;
										}
									}
									else
									{
										Guix.toolTipStyle.normal.textColor = new Color((float)1, 0.2f, 0.2f, (float)1);
										if (43458 - 282863 != -239405)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 135), (float)(posy + 70), (float)200, (float)30), string.Empty + Mathf.Abs(skill.cSP), Guix.toolTipStyle);
										if (118012 - 557135 != -439123)
										{
											continue;
										}
									}
									if (skill.cMP == 0)
									{
										if (17606 - 473319 == -455712)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 200), (float)(posy + 70), (float)200, (float)30), "-", Guix.toolTipDesStyle);
										if (59643 - 32598 != 27045)
										{
											continue;
										}
									}
									else
									{
										Guix.toolTipStyle.normal.textColor = new Color(0.2f, 0.6f, (float)1, (float)1);
										if (34544 - 11645 == 22900)
										{
											continue;
										}
										GUI.Label(new Rect((float)(posx + 200), (float)(posy + 70), (float)200, (float)30), string.Empty + skill.cMP, Guix.toolTipStyle);
										if (115498 - 403952 == -288453)
										{
											continue;
										}
									}
									GUI.Label(new Rect((float)(posx + 35), (float)(posy + 124), (float)200, (float)160), SkillData.getDescription(hoverToolTip), Guix.toolTipDesStyle);
									if (199797 - 448617 != -248819)
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

	// Token: 0x06006140 RID: 24896 RVA: 0x00D547B4 File Offset: 0x00D529B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006141 RID: 24897 RVA: 0x00D547B8 File Offset: 0x00D529B8
	internal static bool aR6d9QpXXnmwHVX0MSAb()
	{
		return true;
	}

	// Token: 0x06006142 RID: 24898 RVA: 0x00D547BC File Offset: 0x00D529BC
	internal static bool zttmSXpXQIFuOPfoPRbx()
	{
		return false;
	}

	// Token: 0x04006E13 RID: 28179
	[NonSerialized]
	public static bool bigNum_init;

	// Token: 0x04006E14 RID: 28180
	[NonSerialized]
	public static Texture bigNum_1;

	// Token: 0x04006E15 RID: 28181
	[NonSerialized]
	public static Texture bigNum_2;

	// Token: 0x04006E16 RID: 28182
	[NonSerialized]
	public static Texture bigNum_3;

	// Token: 0x04006E17 RID: 28183
	[NonSerialized]
	public static Texture bigNum_4;

	// Token: 0x04006E18 RID: 28184
	[NonSerialized]
	public static Texture bigNum_5;

	// Token: 0x04006E19 RID: 28185
	[NonSerialized]
	public static Texture bigNum_6;

	// Token: 0x04006E1A RID: 28186
	[NonSerialized]
	public static Texture bigNum_7;

	// Token: 0x04006E1B RID: 28187
	[NonSerialized]
	public static Texture bigNum_8;

	// Token: 0x04006E1C RID: 28188
	[NonSerialized]
	public static Texture bigNum_9;

	// Token: 0x04006E1D RID: 28189
	[NonSerialized]
	public static Texture bigNum_0;

	// Token: 0x04006E1E RID: 28190
	[NonSerialized]
	public static Texture bigNum_minus;

	// Token: 0x04006E1F RID: 28191
	[NonSerialized]
	public static Texture bigNum_tilda;

	// Token: 0x04006E20 RID: 28192
	[NonSerialized]
	public static Texture bigNum_colon;

	// Token: 0x04006E21 RID: 28193
	[NonSerialized]
	public static bool smallNum_init;

	// Token: 0x04006E22 RID: 28194
	[NonSerialized]
	public static Texture smallNum_1;

	// Token: 0x04006E23 RID: 28195
	[NonSerialized]
	public static Texture smallNum_2;

	// Token: 0x04006E24 RID: 28196
	[NonSerialized]
	public static Texture smallNum_3;

	// Token: 0x04006E25 RID: 28197
	[NonSerialized]
	public static Texture smallNum_4;

	// Token: 0x04006E26 RID: 28198
	[NonSerialized]
	public static Texture smallNum_5;

	// Token: 0x04006E27 RID: 28199
	[NonSerialized]
	public static Texture smallNum_6;

	// Token: 0x04006E28 RID: 28200
	[NonSerialized]
	public static Texture smallNum_7;

	// Token: 0x04006E29 RID: 28201
	[NonSerialized]
	public static Texture smallNum_8;

	// Token: 0x04006E2A RID: 28202
	[NonSerialized]
	public static Texture smallNum_9;

	// Token: 0x04006E2B RID: 28203
	[NonSerialized]
	public static Texture smallNum_0;

	// Token: 0x04006E2C RID: 28204
	[NonSerialized]
	public static Texture smallNum_tilda;

	// Token: 0x04006E2D RID: 28205
	[NonSerialized]
	public static bool goldenNum_init;

	// Token: 0x04006E2E RID: 28206
	[NonSerialized]
	public static Texture goldenNum_1;

	// Token: 0x04006E2F RID: 28207
	[NonSerialized]
	public static Texture goldenNum_2;

	// Token: 0x04006E30 RID: 28208
	[NonSerialized]
	public static Texture goldenNum_3;

	// Token: 0x04006E31 RID: 28209
	[NonSerialized]
	public static Texture goldenNum_4;

	// Token: 0x04006E32 RID: 28210
	[NonSerialized]
	public static Texture goldenNum_5;

	// Token: 0x04006E33 RID: 28211
	[NonSerialized]
	public static Texture goldenNum_6;

	// Token: 0x04006E34 RID: 28212
	[NonSerialized]
	public static Texture goldenNum_7;

	// Token: 0x04006E35 RID: 28213
	[NonSerialized]
	public static Texture goldenNum_8;

	// Token: 0x04006E36 RID: 28214
	[NonSerialized]
	public static Texture goldenNum_9;

	// Token: 0x04006E37 RID: 28215
	[NonSerialized]
	public static Texture goldenNum_0;

	// Token: 0x04006E38 RID: 28216
	[NonSerialized]
	public static bool rank_init;

	// Token: 0x04006E39 RID: 28217
	[NonSerialized]
	public static Texture rank_s;

	// Token: 0x04006E3A RID: 28218
	[NonSerialized]
	public static Texture rank_a;

	// Token: 0x04006E3B RID: 28219
	[NonSerialized]
	public static Texture rank_b;

	// Token: 0x04006E3C RID: 28220
	[NonSerialized]
	public static Texture rank_c;

	// Token: 0x04006E3D RID: 28221
	[NonSerialized]
	public static Texture rank_d;

	// Token: 0x04006E3E RID: 28222
	[NonSerialized]
	public static Texture rank_p;

	// Token: 0x04006E3F RID: 28223
	[NonSerialized]
	public static Texture rank_m;

	// Token: 0x04006E40 RID: 28224
	[NonSerialized]
	public static bool toolTip_init;

	// Token: 0x04006E41 RID: 28225
	[NonSerialized]
	public static GUIStyle toolTipStyle;

	// Token: 0x04006E42 RID: 28226
	[NonSerialized]
	public static GUIStyle toolTipNameStyle;

	// Token: 0x04006E43 RID: 28227
	[NonSerialized]
	public static GUIStyle toolTipDesStyle;

	// Token: 0x04006E44 RID: 28228
	[NonSerialized]
	public static GUIStyle toolTipNumStyle;

	// Token: 0x04006E45 RID: 28229
	[NonSerialized]
	public static GUIStyle toolTipBnsStyle;

	// Token: 0x04006E46 RID: 28230
	[NonSerialized]
	public static GUIStyle toolTipBlueStyle;

	// Token: 0x04006E47 RID: 28231
	[NonSerialized]
	public static GUIStyle toolTipRedStyle;

	// Token: 0x04006E48 RID: 28232
	[NonSerialized]
	public static GUIStyle toolTipPurpleStyle;

	// Token: 0x04006E49 RID: 28233
	[NonSerialized]
	public static GUIStyle toolTipActiveStyle;

	// Token: 0x04006E4A RID: 28234
	[NonSerialized]
	public static GUIStyle toolTipPassiveStyle;

	// Token: 0x04006E4B RID: 28235
	[NonSerialized]
	public static Texture toolTip_item;

	// Token: 0x04006E4C RID: 28236
	[NonSerialized]
	public static Texture toolTip_equipment;

	// Token: 0x04006E4D RID: 28237
	[NonSerialized]
	public static Texture toolTip_skill;

	// Token: 0x04006E4E RID: 28238
	[NonSerialized]
	public static Texture toolTip_slot1;

	// Token: 0x04006E4F RID: 28239
	[NonSerialized]
	public static Texture toolTip_slot2;

	// Token: 0x04006E50 RID: 28240
	[NonSerialized]
	public static Texture toolTip_special;
}
