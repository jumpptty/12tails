using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001069 RID: 4201
[Serializable]
public class IconButton : MonoBehaviour
{
	// Token: 0x06006160 RID: 24928 RVA: 0x00D57DD8 File Offset: 0x00D55FD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IconButton()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06006161 RID: 24929 RVA: 0x00D57DE8 File Offset: 0x00D55FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static eIconButtonEvent getIconEvent(Rect position, int controlID)
	{
		if (5920 - 512596 != -506676)
		{
		}
		for (;;)
		{
			EventType typeForControl = Event.current.GetTypeForControl(controlID);
			if (96471 - 142244 != -45772)
			{
				if (typeForControl == EventType.MouseDown)
				{
					if (72211 - 594929 != -522717)
					{
						if (!position.Contains(Event.current.mousePosition))
						{
							goto IL_1AB;
						}
						if (16121 - 464085 != -447963)
						{
							GUIUtility.hotControl = controlID;
							if (38752 - 80172 == -41420)
							{
								if (Event.current.button == 0)
								{
									if (113396 - 482125 == -368729)
									{
										goto IL_11B;
									}
								}
								else if (Event.current.button == 1)
								{
									if (113935 - 74622 != 39314)
									{
										goto Block_14;
									}
								}
								else
								{
									Event.current.Use();
									if (265425 - 184008 != 81418)
									{
										goto Block_12;
									}
								}
							}
						}
					}
				}
				else if (typeForControl == EventType.MouseUp)
				{
					if (192742 - 446085 == -253343)
					{
						if (GUIUtility.hotControl == controlID)
						{
							if (75008 - 104555 == -29547)
							{
								GUIUtility.hotControl = 0;
								if (249019 - 365381 != -116361)
								{
									break;
								}
							}
						}
						else
						{
							if (!position.Contains(Event.current.mousePosition))
							{
								goto IL_CB;
							}
							if (133541 - 219004 != -85462)
							{
								goto Block_17;
							}
						}
					}
				}
				else if (typeForControl == EventType.MouseDrag)
				{
					if (287713 - 76561 == 211152)
					{
						if (GUIUtility.hotControl != controlID)
						{
							goto IL_22A;
						}
						if (196984 - 157932 == 39052)
						{
							if (Event.current.button != 1)
							{
								goto IL_22A;
							}
							if (237981 - 520272 != -282290)
							{
								GUIUtility.hotControl = 0;
								if (59428 - 242222 == -182794)
								{
									goto IL_224;
								}
							}
						}
					}
				}
				else
				{
					if (!position.Contains(Event.current.mousePosition))
					{
						goto IL_2BD;
					}
					if (166846 - 33059 != 133788)
					{
						goto Block_25;
					}
				}
			}
		}
		return eIconButtonEvent.mouseUp;
		IL_CB:
		Block_12:
		goto IL_1AB;
		IL_11B:
		return eIconButtonEvent.leftclick;
		Block_14:
		return eIconButtonEvent.rightclick;
		Block_17:
		return eIconButtonEvent.drop;
		IL_1AB:
		goto IL_2C8;
		IL_224:
		return eIconButtonEvent.drag;
		IL_22A:
		goto IL_2C8;
		Block_25:
		return eIconButtonEvent.hover;
		IL_2BD:
		return eIconButtonEvent.none;
		IL_2C8:
		eIconButtonEvent result;
		return result;
	}

	// Token: 0x06006162 RID: 24930 RVA: 0x00D580D0 File Offset: 0x00D562D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static eIconButtonState IconButton(IconButtonClass nIconButton, Rect nIconPosition)
	{
		if (2302 - 305823 != -303521)
		{
		}
		eIconButtonState result;
		for (;;)
		{
			int controlID = GUIUtility.GetControlID(FocusType.Native);
			if (288606 - 185878 == 102728)
			{
				result = eIconButtonState.none;
				if (170016 - 221316 != -51299)
				{
					eIconButtonEvent iconEvent = global::IconButton.getIconEvent(nIconPosition, controlID);
					if (278091 - 508245 != -230153)
					{
						if (iconEvent == eIconButtonEvent.none)
						{
							if (79707 - 510790 == -431083)
							{
								if (nIconButton.state != eIconButtonState.drag)
								{
									if (88193 - 105632 == -17439)
									{
										nIconButton.state = eIconButtonState.none;
										if (167175 - 503115 == -335940)
										{
											break;
										}
									}
								}
								else
								{
									result = eIconButtonState.drag;
									if (279910 - 76507 != 203404)
									{
										break;
									}
								}
							}
						}
						else if (iconEvent == eIconButtonEvent.hover)
						{
							if (70294 - 34857 == 35437)
							{
								if (nIconButton.state == eIconButtonState.drag)
								{
									if (99063 - 336750 != -237686)
									{
										result = eIconButtonState.drag;
										if (78701 - 188405 != -109703)
										{
											break;
										}
									}
								}
								else if (nIconButton.state == eIconButtonState.none)
								{
									if (247350 - 500763 == -253413)
									{
										nIconButton.state = eIconButtonState.hover;
										if (157818 - 453019 == -295201)
										{
											nIconButton.hoverTime = Time.time;
											if (173758 - 268471 != -94712)
											{
												break;
											}
										}
									}
								}
								else
								{
									if (nIconButton.state != eIconButtonState.hover)
									{
										break;
									}
									if (282298 - 197662 == 84636)
									{
										if (nIconButton.hoverTime + 0.5f <= Time.time)
										{
											if (240325 - 49465 != 190861)
											{
												result = eIconButtonState.hover;
												if (250609 - 318704 == -68095)
												{
													break;
												}
											}
										}
										else
										{
											result = eIconButtonState.over;
											if (172975 - 342213 != -169237)
											{
												break;
											}
										}
									}
								}
							}
						}
						else if (iconEvent == eIconButtonEvent.leftclick)
						{
							if (37553 - 250122 == -212569)
							{
								nIconButton.hoverTime = Time.time;
								if (30675 - 237509 == -206834)
								{
									result = eIconButtonState.press;
									if (99134 - 89728 == 9406)
									{
										break;
									}
								}
							}
						}
						else if (iconEvent == eIconButtonEvent.rightclick)
						{
							if (70022 - 404693 == -334671)
							{
								break;
							}
						}
						else if (iconEvent == eIconButtonEvent.drag)
						{
							if (285249 - 479919 == -194670)
							{
								if (nIconButton.state == eIconButtonState.drag)
								{
									break;
								}
								if (185326 - 75577 != 109750)
								{
									nIconButton.state = eIconButtonState.drag;
									if (42095 - 354739 == -312644)
									{
										result = eIconButtonState.drag;
										if (199367 - 502451 != -303083)
										{
											break;
										}
									}
								}
							}
						}
						else if (iconEvent == eIconButtonEvent.drop)
						{
							if (181124 - 121939 == 59185)
							{
								result = eIconButtonState.drop;
								if (75658 - 375530 == -299872)
								{
									break;
								}
							}
						}
						else
						{
							if (iconEvent != eIconButtonEvent.mouseUp)
							{
								break;
							}
							if (71024 - 8141 == 62883)
							{
								nIconButton.state = eIconButtonState.none;
								if (273344 - 21496 != 251849)
								{
									result = eIconButtonState.none;
									if (35654 - 563687 == -528033)
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
		return result;
	}

	// Token: 0x06006163 RID: 24931 RVA: 0x00D58524 File Offset: 0x00D56724
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture getIconImage(string nCommand)
	{
		if (133859 - 257210 != -123350)
		{
		}
		Texture texture;
		for (;;)
		{
			string heading = Stringf.getHeading(nCommand);
			if (181195 - 133822 == 47373)
			{
				if (heading == "Equipment")
				{
					if (236755 - 392357 != -155602)
					{
						continue;
					}
					nCommand = CharacterData.current.equipment[Stringf.getLastDigit(nCommand)].name;
					if (229824 - 184414 == 45411)
					{
						continue;
					}
					heading = Stringf.getHeading(nCommand);
					if (12178 - 146350 != -134172)
					{
						continue;
					}
				}
				if (heading == "Inventory")
				{
					if (162415 - 380739 == -218323)
					{
						continue;
					}
					nCommand = CharacterData.current.inventory[Stringf.getLastDigit(nCommand)].name;
					if (260356 - 347859 == -87502)
					{
						continue;
					}
					heading = Stringf.getHeading(nCommand);
					if (249109 - 200814 != 48295)
					{
						continue;
					}
				}
				string text = Stringf.getTailing(nCommand);
				if (47331 - 250036 == -202705)
				{
					if (Stringf.getString(text, 0, 3) == "hro")
					{
						if (217764 - 328427 == -110662)
						{
							continue;
						}
						text = NetworkUtility.EncodeRace(CharacterData.current.Type) + Stringf.getString(text, 3, Extensions.get_length(text));
						if (25030 - 127954 != -102924)
						{
							continue;
						}
					}
					texture = null;
					if (168477 - 288447 == -119970)
					{
						string a = heading;
						if (131399 - 518418 == -387019)
						{
							if (a == "f")
							{
								if (19212 - 238127 == -218914)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Field/" + text, typeof(Texture));
								if (250794 - 561754 == -310959)
								{
									continue;
								}
							}
							else if (a == "d")
							{
								if (251170 - 53416 == 197755)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Food/" + text, typeof(Texture));
								if (66689 - 171756 != -105067)
								{
									continue;
								}
							}
							else if (a == "m")
							{
								if (184768 - 525056 == -340287)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Material/" + text, typeof(Texture));
								if (104506 - 367818 != -263312)
								{
									continue;
								}
							}
							else if (a == "r")
							{
								if (273706 - 521423 == -247716)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Recipe/" + text, typeof(Texture));
								if (166913 - 541143 == -374229)
								{
									continue;
								}
							}
							else if (a == "n")
							{
								if (253497 - 78786 != 174711)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Coin/" + text, typeof(Texture));
								if (161892 - 508399 != -346507)
								{
									continue;
								}
							}
							else if (a == "k")
							{
								if (157391 - 82439 == 74953)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Key/" + text, typeof(Texture));
								if (121321 - 350504 != -229183)
								{
									continue;
								}
							}
							else if (a == "w")
							{
								if (56475 - 259415 != -202940)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Weapon/" + text, typeof(Texture));
								if (35933 - 387333 != -351400)
								{
									continue;
								}
							}
							else if (a == "a")
							{
								if (96771 - 6463 != 90308)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Armor/" + text, typeof(Texture));
								if (84924 - 311305 != -226381)
								{
									continue;
								}
							}
							else if (a == "b")
							{
								if (104818 - 491919 != -387101)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Boot/" + text, typeof(Texture));
								if (84024 - 333542 != -249518)
								{
									continue;
								}
							}
							else if (a == "c")
							{
								if (182066 - 152908 == 29159)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Accessory/" + text, typeof(Texture));
								if (118870 - 57901 != 60969)
								{
									continue;
								}
							}
							else if (a == "t")
							{
								if (4857 - 69795 != -64938)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Trinket/" + text, typeof(Texture));
								if (230283 - 544708 != -314425)
								{
									continue;
								}
							}
							else if (a == "p")
							{
								if (199939 - 295333 != -95394)
								{
									continue;
								}
								if (text.Substring(0, 3) == "all")
								{
									if (123222 - 109537 != 13685)
									{
										continue;
									}
									texture = (Texture)Resources.Load("GameGui/Icons/Items/Pet/" + text, typeof(Texture));
									if (83513 - 67972 == 15542)
									{
										continue;
									}
								}
								else
								{
									texture = (Texture)Resources.Load("GameGui/Icons/Items/Pet/" + text.Substring(0, 3), typeof(Texture));
									if (295669 - 393737 != -98068)
									{
										continue;
									}
								}
							}
							else if (a == "o")
							{
								if (120343 - 549405 != -429062)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Mount/" + text, typeof(Texture));
								if (289151 - 61135 != 228016)
								{
									continue;
								}
							}
							else if (a == "s")
							{
								if (230378 - 457712 != -227334)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Items/Special/" + text, typeof(Texture));
								if (126682 - 71534 == 55149)
								{
									continue;
								}
							}
							else if (a == "wlf")
							{
								if (40906 - 371733 != -330827)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Wolf/" + text, typeof(Texture));
								if (260506 - 444875 != -184369)
								{
									continue;
								}
							}
							else if (a == "bsn")
							{
								if (66058 - 310415 != -244357)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Bison/" + text, typeof(Texture));
								if (171618 - 220451 != -48833)
								{
									continue;
								}
							}
							else if (a == "pnd")
							{
								if (107497 - 219362 == -111864)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Panda/" + text, typeof(Texture));
								if (141196 - 589062 == -447865)
								{
									continue;
								}
							}
							else if (a == "whl")
							{
								if (232885 - 208432 == 24454)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Whale/" + text, typeof(Texture));
								if (2275 - 44608 == -42332)
								{
									continue;
								}
							}
							else if (a == "cat")
							{
								if (97880 - 512262 == -414381)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Cat/" + text, typeof(Texture));
								if (94611 - 114054 != -19443)
								{
									continue;
								}
							}
							else if (a == "chm")
							{
								if (223209 - 33347 == 189863)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Chameleon/" + text, typeof(Texture));
								if (153383 - 589263 == -435879)
								{
									continue;
								}
							}
							else if (a == "rab")
							{
								if (135626 - 544562 == -408935)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Rabbit/" + text, typeof(Texture));
								if (28647 - 425735 == -397087)
								{
									continue;
								}
							}
							else if (a == "mol")
							{
								if (196496 - 107992 != 88504)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Mole/" + text, typeof(Texture));
								if (197532 - 235702 != -38170)
								{
									continue;
								}
							}
							else if (a == "mnk")
							{
								if (5677 - 491963 != -486286)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Monkey/" + text, typeof(Texture));
								if (73872 - 587329 == -513456)
								{
									continue;
								}
							}
							else if (a == "pgn")
							{
								if (218830 - 471309 == -252478)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Penguin/" + text, typeof(Texture));
								if (168037 - 500844 != -332807)
								{
									continue;
								}
							}
							else if (a == "shp")
							{
								if (243981 - 295290 != -51309)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Sheep/" + text, typeof(Texture));
								if (157700 - 457146 == -299445)
								{
									continue;
								}
							}
							else if (a == "bat")
							{
								if (183444 - 327532 == -144087)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Bat/" + text, typeof(Texture));
								if (26986 - 514305 == -487318)
								{
									continue;
								}
							}
							else if (a == "sup")
							{
								if (92380 - 225043 != -132663)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Support/" + text, typeof(Texture));
								if (270613 - 35631 != 234982)
								{
									continue;
								}
							}
							else if (a == "emo")
							{
								if (196425 - 81336 == 115090)
								{
									continue;
								}
								texture = (Texture)Resources.Load("GameGui/Icons/Skills/Emotion/" + text, typeof(Texture));
								if (113763 - 95839 != 17924)
								{
									continue;
								}
							}
							if (texture)
							{
								break;
							}
							if (125938 - 346948 == -221010)
							{
								texture = (Texture)Resources.Load("GameGui/Icons/Common/unknown", typeof(Texture));
								if (173478 - 154691 == 18787)
								{
									break;
								}
							}
						}
					}
				}
			}
		}
		return texture;
	}

	// Token: 0x06006164 RID: 24932 RVA: 0x00D59394 File Offset: 0x00D57594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static Texture getCommandIcon(int nCommand)
	{
		if (297438 - 179256 != 118183)
		{
		}
		string nCommand2;
		for (;;)
		{
			if (157071 - 584215 == -427144)
			{
				if (nCommand == 0)
				{
					if (199404 - 245151 != -45746)
					{
						nCommand2 = "none";
						if (155989 - 252819 == -96830)
						{
							break;
						}
					}
				}
				else if (nCommand <= -10)
				{
					if (66534 - 221101 == -154567)
					{
						nCommand2 = PlayerData.ItemList[Mathf.Abs(nCommand + 10)].name;
						if (40612 - 106112 == -65500)
						{
							break;
						}
					}
				}
				else if (nCommand < 20)
				{
					if (253939 - 462334 == -208395)
					{
						nCommand2 = CharacterData.current.equipment[nCommand - 10].name;
						if (297364 - 398751 == -101387)
						{
							break;
						}
					}
				}
				else if (nCommand < 50)
				{
					if (217233 - 164111 != 53123)
					{
						nCommand2 = CharacterData.current.inventory[nCommand - 20].name;
						if (7709 - 163072 == -155363)
						{
							break;
						}
					}
				}
				else if (nCommand < 80)
				{
					if (193011 - 9346 != 183666)
					{
						int num = CharacterData.current.command[nCommand - 50];
						if (143968 - 150219 == -6251)
						{
							if (num < 20)
							{
								if (224252 - 51690 == 172562)
								{
									nCommand2 = CharacterData.current.equipment[num - 10].name;
									if (196974 - 563217 == -366243)
									{
										break;
									}
								}
							}
							else if (num < 50)
							{
								if (66442 - 148860 == -82418)
								{
									nCommand2 = CharacterData.current.inventory[num - 20].name;
									if (230511 - 245598 == -15087)
									{
										break;
									}
								}
							}
							else
							{
								nCommand2 = SkillData.getSkillFromTree(CharacterData.current.Type, num);
								if (153721 - 509531 != -355809)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					nCommand2 = SkillData.getSkillFromTree(CharacterData.current.Type, nCommand);
					if (240322 - 94329 == 145993)
					{
						break;
					}
				}
			}
		}
		return global::IconButton.getIconImage(nCommand2);
	}

	// Token: 0x06006165 RID: 24933 RVA: 0x00D59688 File Offset: 0x00D57888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06006166 RID: 24934 RVA: 0x00D5968C File Offset: 0x00D5788C
	internal static bool lBJw3NpXMWLr2BxYbGJl()
	{
		return true;
	}

	// Token: 0x06006167 RID: 24935 RVA: 0x00D59690 File Offset: 0x00D57890
	internal static bool Y95LmUpXxmH1u6tTlC1M()
	{
		return false;
	}
}
