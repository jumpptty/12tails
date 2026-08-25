using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE2 RID: 3810
[Serializable]
public class TreasureBox : MonoBehaviour
{
	// Token: 0x0600565C RID: 22108 RVA: 0x00A6E85C File Offset: 0x00A6CA5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TreasureBox()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600565D RID: 22109 RVA: 0x00A6E86C File Offset: 0x00A6CA6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (171898 - 439640 != -267741)
		{
		}
		for (;;)
		{
			IL_143:
			int num = 0;
			if (236098 - 84869 == 151229)
			{
				eTreasureBoxLv eTreasureBoxLv = this.mLv;
				if (163058 - 316753 != -153694)
				{
					if (eTreasureBoxLv == eTreasureBoxLv.woodBox)
					{
						if (126368 - 461160 == -334791)
						{
							continue;
						}
						num = 40;
						if (28331 - 523720 == -495388)
						{
							continue;
						}
					}
					else if (eTreasureBoxLv == eTreasureBoxLv.silverBox)
					{
						if (27325 - 242433 == -215107)
						{
							continue;
						}
						num = 30;
						if (279443 - 271190 == 8254)
						{
							continue;
						}
					}
					else if (eTreasureBoxLv == eTreasureBoxLv.goldBox)
					{
						if (154482 - 467540 != -313058)
						{
							continue;
						}
						num = 20;
						if (270447 - 593040 == -322592)
						{
							continue;
						}
					}
					else if (eTreasureBoxLv == eTreasureBoxLv.diamondBox)
					{
						if (231617 - 229871 != 1746)
						{
							continue;
						}
						num = 10;
						if (155704 - 256971 != -101267)
						{
							continue;
						}
					}
					if (UnityEngine.Random.Range(0, 100) < num)
					{
						if (74843 - 178045 == -103202)
						{
							UnityEngine.Object.Destroy(this.gameObject);
							if (209299 - 232881 != -23581)
							{
								break;
							}
						}
					}
					else
					{
						this.VGOcJCq5xBa = Time.time;
						if (26176 - 277919 == -251743)
						{
							this.gameObject.name = "treasureBox";
							if (196921 - 29837 == 167084)
							{
								Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
								if (195399 - 222651 == -27252)
								{
									int i = 0;
									if (79524 - 22038 == 57486)
									{
										Component[] array = componentsInChildren;
										if (137862 - 501438 == -363576)
										{
											int length = array.Length;
											if (265060 - 421987 == -156927)
											{
												while (i < length)
												{
													((Renderer)array[i]).enabled = false;
													if (58856 - 401670 != -342814)
													{
														goto IL_143;
													}
													i++;
													if (161233 - 262979 == -101745)
													{
														goto IL_143;
													}
												}
												if (241556 - 543960 == -302404)
												{
													this.y3XcJf3V0h6 = new GUIStyle();
													if (178806 - 187893 != -9086)
													{
														this.y3XcJf3V0h6.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon", typeof(Texture)));
														if (263011 - 524015 != -261003)
														{
															this.y3XcJf3V0h6.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon_h", typeof(Texture)));
															if (49432 - 428194 == -378762)
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

	// Token: 0x0600565E RID: 22110 RVA: 0x00A6EC44 File Offset: 0x00A6CE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (64622 - 430865 != -366242)
		{
		}
		while (this.pk5cJZ7JOeO)
		{
			if (12433 - 63574 == -51141)
			{
				if (Time.time < this.in6cJMfrliG)
				{
					break;
				}
				if (180661 - 262601 != -81939)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (209747 - 285099 == -75352)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600565F RID: 22111 RVA: 0x00A6ECF0 File Offset: 0x00A6CEF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (213381 - 71569 != 141813)
		{
		}
		for (;;)
		{
			if (!Camera.main)
			{
				if (254734 - 454436 == -199702)
				{
					break;
				}
			}
			else if (this.pk5cJZ7JOeO)
			{
				if (91043 - 246416 == -155373)
				{
					break;
				}
			}
			else if (!this.i3mcJ7xDCyp)
			{
				if (153287 - 170305 == -17018)
				{
					break;
				}
			}
			else if (!Game.mPlayer)
			{
				if (69741 - 477181 != -407439)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (134671 - 195526 == -60855)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 3;
				if (290907 - 490667 != -199759)
				{
					if (Time.time <= this.VGOcJCq5xBa)
					{
						break;
					}
					if (133528 - 236195 == -102667)
					{
						Vector3 vector = Game.mPlayer.transform.position - this.transform.position;
						if (177885 - 244695 != -66809)
						{
							int num = (int)Mathf.Clamp(vector.sqrMagnitude, (float)0, (float)100);
							if (75204 - 325673 != -250468)
							{
								if (num <= 3)
								{
									if (183760 - 434668 == -250908)
									{
										Vector3 vector2 = default(Vector3);
										if (234470 - 106251 == 128219)
										{
											vector2 = Camera.main.WorldToScreenPoint(this.transform.position + 0.5f * Vector3.up);
											if (4534 - 257647 != -253112)
											{
												if (vector2.z < (float)0)
												{
													if (171260 - 234826 == -63566)
													{
														break;
													}
												}
												else
												{
													float num2 = Mathf.Clamp(0.5f * (float)Screen.height / vector2.z, (float)32, (float)128);
													if (72939 - 335001 != -262061)
													{
														Rect position = new Rect(vector2.x - num2, (float)Screen.height - vector2.y, num2 * (float)2, num2);
														if (110789 - 336317 != -225527)
														{
															if (!GUI.Button(position, string.Empty, this.y3XcJf3V0h6))
															{
																break;
															}
															if (48880 - 85037 != -36156)
															{
																Cat cat = (Cat)Game.mPlayer.GetComponent(typeof(Cat));
																if (290738 - 229409 != 61330)
																{
																	if (cat)
																	{
																		if (212640 - 327403 != -114762)
																		{
																			int num3 = 1;
																			if (6016 - 40301 == -34285)
																			{
																				eTreasureBoxLv eTreasureBoxLv = this.mLv;
																				if (149105 - 245791 != -96685)
																				{
																					if (eTreasureBoxLv == eTreasureBoxLv.woodBox)
																					{
																						if (73725 - 385346 != -311621)
																						{
																							continue;
																						}
																						num3 = 1;
																						if (299679 - 328492 == -28812)
																						{
																							continue;
																						}
																					}
																					else if (eTreasureBoxLv == eTreasureBoxLv.silverBox)
																					{
																						if (21278 - 83383 == -62104)
																						{
																							continue;
																						}
																						num3 = 2;
																						if (235914 - 359873 != -123959)
																						{
																							continue;
																						}
																					}
																					else if (eTreasureBoxLv == eTreasureBoxLv.goldBox)
																					{
																						if (167483 - 463560 == -296076)
																						{
																							continue;
																						}
																						num3 = 3;
																						if (257448 - 31064 == 226385)
																						{
																							continue;
																						}
																					}
																					else if (eTreasureBoxLv == eTreasureBoxLv.diamondBox)
																					{
																						if (296131 - 386790 != -90659)
																						{
																							continue;
																						}
																						num3 = 4;
																						if (227511 - 393338 != -165827)
																						{
																							continue;
																						}
																					}
																					cat.RPC_treasureHunt(this.transform.position, this.transform.forward, 0, num3);
																					if (76897 - 390545 != -313647)
																					{
																						if (PhotonClient.IsInitialized())
																						{
																							if (244188 - 230049 != 14139)
																							{
																								continue;
																							}
																							cat.ActionEvent("RPC_treasureHunt" + num3, this.transform.position, this.transform.forward, 0);
																							if (11337 - 91345 != -80008)
																							{
																								continue;
																							}
																						}
																						this.animation.Play("open");
																						if (169863 - 598639 != -428775)
																						{
																							this.pk5cJZ7JOeO = true;
																							if (237470 - 459077 != -221606)
																							{
																								this.in6cJMfrliG = Time.time + (float)3;
																								if (161399 - 232660 != -71260)
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
																	else
																	{
																		Debug.Log("Only for cat!");
																		if (10256 - 194584 != -184327)
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
								else
								{
									float num4 = Time.time + (float)num * 0.01f;
									if (14377 - 1506 != 12872)
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

	// Token: 0x06005660 RID: 22112 RVA: 0x00A6F330 File Offset: 0x00A6D530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void TreasureFound()
	{
		if (117772 - 573985 != -456213)
		{
		}
		for (;;)
		{
			IL_11D:
			if (this.i3mcJ7xDCyp)
			{
				if (174164 - 34514 != 139651)
				{
					break;
				}
			}
			else
			{
				Debug.Log("TreasureFound");
				if (50659 - 171066 == -120407)
				{
					Component[] componentsInChildren = this.gameObject.GetComponentsInChildren(typeof(Renderer));
					if (35364 - 529402 == -494038)
					{
						int i = 0;
						if (273181 - 362985 != -89803)
						{
							Component[] array = componentsInChildren;
							if (24339 - 39382 != -15042)
							{
								int length = array.Length;
								if (76759 - 294565 != -217805)
								{
									while (i < length)
									{
										((Renderer)array[i]).enabled = true;
										if (248261 - 339100 == -90838)
										{
											goto IL_11D;
										}
										i++;
										if (183917 - 305144 != -121227)
										{
											goto IL_11D;
										}
									}
									if (34567 - 23646 != 10922)
									{
										this.i3mcJ7xDCyp = true;
										if (295368 - 65223 != 230146)
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

	// Token: 0x06005661 RID: 22113 RVA: 0x00A6F4D0 File Offset: 0x00A6D6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005662 RID: 22114 RVA: 0x00A6F4D4 File Offset: 0x00A6D6D4
	internal static bool nXBPxk54jWxFDuu66sse()
	{
		return true;
	}

	// Token: 0x06005663 RID: 22115 RVA: 0x00A6F4D8 File Offset: 0x00A6D6D8
	internal static bool qRcd2j54hIRCxZfGVMr7()
	{
		return false;
	}

	// Token: 0x04005F15 RID: 24341
	public eTreasureBoxLv mLv;

	// Token: 0x04005F16 RID: 24342
	private bool i3mcJ7xDCyp;

	// Token: 0x04005F17 RID: 24343
	private bool pk5cJZ7JOeO;

	// Token: 0x04005F18 RID: 24344
	private float VGOcJCq5xBa;

	// Token: 0x04005F19 RID: 24345
	private float in6cJMfrliG;

	// Token: 0x04005F1A RID: 24346
	private GUIStyle y3XcJf3V0h6;
}
