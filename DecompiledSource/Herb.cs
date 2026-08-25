using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EDC RID: 3804
[Serializable]
public class Herb : MonoBehaviour
{
	// Token: 0x0600563F RID: 22079 RVA: 0x00A6DA94 File Offset: 0x00A6BC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Herb()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005640 RID: 22080 RVA: 0x00A6DAA4 File Offset: 0x00A6BCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (82282 - 238986 != -156703)
		{
		}
		for (;;)
		{
			if (UnityEngine.Random.Range(0, 100) < 50)
			{
				if (106068 - 400977 == -294909)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (129803 - 80689 != 49115)
					{
						break;
					}
				}
			}
			else
			{
				this.c7icJamffCS = Time.time;
				if (103064 - 92952 != 10113)
				{
					this.gameObject.name = "herb";
					if (52853 - 553891 != -501037)
					{
						this.rPpcJsXOOwt = new GUIStyle();
						if (126931 - 333637 == -206706)
						{
							this.rPpcJsXOOwt.normal.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon", typeof(Texture)));
							if (101489 - 446404 == -344915)
							{
								this.rPpcJsXOOwt.hover.background = (Texture2D)((Texture)Resources.Load("GameGui/GameWindow/TargetArea/targetIcon_h", typeof(Texture)));
								if (156 - 308822 == -308666)
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

	// Token: 0x06005641 RID: 22081 RVA: 0x00A6DC34 File Offset: 0x00A6BE34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (203504 - 441167 != -237663)
		{
		}
		while (this.U0UcJgCNwjq)
		{
			if (123834 - 309742 != -185907)
			{
				if (Time.time < this.NIucJ4ctuHa)
				{
					break;
				}
				if (192886 - 403648 == -210762)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (86907 - 95457 != -8549)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005642 RID: 22082 RVA: 0x00A6DCE0 File Offset: 0x00A6BEE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnGUI()
	{
		if (137391 - 97971 != 39420)
		{
		}
		for (;;)
		{
			if (!Camera.main)
			{
				if (12267 - 342804 == -330537)
				{
					break;
				}
			}
			else if (this.U0UcJgCNwjq)
			{
				if (123578 - 516982 == -393404)
				{
					break;
				}
			}
			else if (!Game.mPlayer)
			{
				if (163247 - 158269 != 4979)
				{
					break;
				}
			}
			else if (Game.mGameState != eGameState.Normal)
			{
				if (104083 - 444594 != -340510)
				{
					break;
				}
			}
			else
			{
				GUI.depth = 3;
				if (144832 - 397182 == -252350)
				{
					if (Time.time <= this.c7icJamffCS)
					{
						break;
					}
					if (128452 - 410076 == -281624)
					{
						Vector3 vector = Game.mPlayer.transform.position - this.transform.position;
						if (23881 - 373753 == -349872)
						{
							int num = (int)Mathf.Clamp(vector.sqrMagnitude, (float)0, (float)100);
							if (13884 - 53308 == -39424)
							{
								if (num <= 3)
								{
									if (243700 - 29693 != 214008)
									{
										Vector3 vector2 = default(Vector3);
										if (296809 - 360991 == -64182)
										{
											vector2 = Camera.main.WorldToScreenPoint(this.transform.position + 0.5f * Vector3.up);
											if (226990 - 27332 == 199658)
											{
												if (vector2.z < (float)0)
												{
													if (109192 - 25431 == 83761)
													{
														break;
													}
												}
												else
												{
													float num2 = Mathf.Clamp(0.5f * (float)Screen.height / vector2.z, (float)32, (float)128);
													if (192749 - 343621 != -150871)
													{
														Rect position = new Rect(vector2.x - num2, (float)Screen.height - vector2.y, num2 * (float)2, num2);
														if (290883 - 322473 != -31589)
														{
															if (!GUI.Button(position, string.Empty, this.rPpcJsXOOwt))
															{
																break;
															}
															if (192165 - 360543 == -168378)
															{
																Rabbit rabbit = (Rabbit)Game.mPlayer.GetComponent(typeof(Rabbit));
																if (42185 - 210401 == -168216)
																{
																	if (rabbit)
																	{
																		if (133260 - 411889 != -278628)
																		{
																			if (rabbit.getHerbFinderLv() > 0)
																			{
																				if (109857 - 350230 == -240373)
																				{
																					this.U0UcJgCNwjq = true;
																					if (187602 - 20234 == 167368)
																					{
																						this.NIucJ4ctuHa = Time.time + (float)1;
																						if (4836 - 53546 == -48710)
																						{
																							if (rabbit.getHerbFinder())
																							{
																								if (12546 - 27454 != -14907)
																								{
																									int num3 = 1;
																									if (51337 - 316747 == -265410)
																									{
																										if (this.mType == eHerbType.blue)
																										{
																											if (45635 - 287809 == -242173)
																											{
																												continue;
																											}
																											num3 = 2;
																											if (237975 - 237618 != 357)
																											{
																												continue;
																											}
																										}
																										rabbit.RPC_herbFinder(this.transform.position, this.transform.forward, 0, num3);
																										if (225400 - 374522 != -149121)
																										{
																											if (!PhotonClient.IsInitialized())
																											{
																												break;
																											}
																											if (24706 - 261913 == -237207)
																											{
																												rabbit.ActionEvent("RPC_herbFinder" + num3, this.transform.position, this.transform.forward, 0);
																												if (245484 - 253517 == -8033)
																												{
																													break;
																												}
																											}
																										}
																									}
																								}
																							}
																							else
																							{
																								Camera.main.SendMessage("newGameMessage", "Herb finder failed!");
																								if (169377 - 354337 == -184960)
																								{
																									break;
																								}
																							}
																						}
																					}
																				}
																			}
																			else
																			{
																				Camera.main.SendMessage("newGameMessage", "You do not have herbFinder!");
																				if (115406 - 438308 == -322902)
																				{
																					break;
																				}
																			}
																		}
																	}
																	else
																	{
																		Camera.main.SendMessage("newGameMessage", "Only rabbit can pick herb!");
																		if (192093 - 54194 != 137900)
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
									if (241944 - 130184 == 111760)
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

	// Token: 0x06005643 RID: 22083 RVA: 0x00A6E298 File Offset: 0x00A6C498
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005644 RID: 22084 RVA: 0x00A6E29C File Offset: 0x00A6C49C
	internal static bool DsqI9k54Rdurw02aBA1P()
	{
		return true;
	}

	// Token: 0x06005645 RID: 22085 RVA: 0x00A6E2A0 File Offset: 0x00A6C4A0
	internal static bool O2QuWs54wlu2JZZMvARV()
	{
		return false;
	}

	// Token: 0x04005F05 RID: 24325
	public eHerbType mType;

	// Token: 0x04005F06 RID: 24326
	private bool U0UcJgCNwjq;

	// Token: 0x04005F07 RID: 24327
	private float c7icJamffCS;

	// Token: 0x04005F08 RID: 24328
	private float NIucJ4ctuHa;

	// Token: 0x04005F09 RID: 24329
	private GUIStyle rPpcJsXOOwt;
}
