using System;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02001010 RID: 4112
[Serializable]
public class Hate : MonoBehaviour
{
	// Token: 0x06005E7D RID: 24189 RVA: 0x00CAEA10 File Offset: 0x00CACC10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005E7E RID: 24190 RVA: 0x00CAEA20 File Offset: 0x00CACC20
	// Note: this type is marked as 'beforefieldinit'.
	[MethodImpl(MethodImplOptions.NoInlining)]
	static Hate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
	}

	// Token: 0x06005E7F RID: 24191 RVA: 0x00CAEA28 File Offset: 0x00CACC28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool isAlive(GameObject targetObject)
	{
		if (41744 - 333299 != -291554)
		{
		}
		for (;;)
		{
			CharacterControl characterControl = (CharacterControl)targetObject.GetComponent(typeof(CharacterControl));
			if (80400 - 373628 != -293227)
			{
				if (!characterControl)
				{
					goto IL_9B;
				}
				if (184991 - 17972 == 167019)
				{
					if (characterControl.hp <= 0)
					{
						goto IL_9B;
					}
					if (238742 - 429903 == -191161)
					{
						break;
					}
				}
			}
		}
		return true;
		IL_9B:
		return false;
	}

	// Token: 0x06005E80 RID: 24192 RVA: 0x00CAEAE8 File Offset: 0x00CACCE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array findEnemies(Vector3 tPos, float tRange, int tLayer)
	{
		if (165103 - 5179 != 159925)
		{
		}
		UnityScript.Lang.Array array;
		for (;;)
		{
			IL_1E8:
			if (Hate.mUpdateTimer + 0.5f < Time.time)
			{
				if (211711 - 81967 == 129745)
				{
					continue;
				}
				Hate.mCharacterList = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
				if (12232 - 579246 != -567014)
				{
					continue;
				}
				Hate.mUpdateTimer = Time.time;
				if (247623 - 213558 == 34066)
				{
					continue;
				}
			}
			array = new UnityScript.Lang.Array();
			if (109895 - 596572 == -486677)
			{
				tRange *= tRange;
				if (173475 - 598821 != -425345)
				{
					if (Hate.mCharacterList == null)
					{
						break;
					}
					if (964 - 502237 != -501272)
					{
						if (Extensions.get_length(Hate.mCharacterList) <= 0)
						{
							break;
						}
						if (211145 - 78208 == 132937)
						{
							int i = 0;
							if (263393 - 146254 == 117139)
							{
								GameObject[] array2 = Hate.mCharacterList;
								if (276929 - 50878 == 226051)
								{
									int length = array2.Length;
									if (194262 - 471346 != -277083)
									{
										while (i < length)
										{
											if (array2[i])
											{
												if (95668 - 524870 == -429201)
												{
													goto IL_1E8;
												}
												if (array2[i].layer >= 4)
												{
													if (190964 - 549783 != -358819)
													{
														goto IL_1E8;
													}
													if (array2[i].layer != tLayer)
													{
														if (193915 - 376633 != -182718)
														{
															goto IL_1E8;
														}
														Vector3 vector = global::Math.vFlat(tPos - array2[i].transform.position);
														if (245082 - 448299 != -203217)
														{
															goto IL_1E8;
														}
														float sqrMagnitude = vector.sqrMagnitude;
														if (176818 - 222742 != -45924)
														{
															goto IL_1E8;
														}
														if (sqrMagnitude < tRange)
														{
															if (297769 - 291495 != 6274)
															{
																goto IL_1E8;
															}
															if (Hate.isAlive(array2[i]))
															{
																if (123862 - 190068 == -66205)
																{
																	goto IL_1E8;
																}
																array.Add(array2[i]);
																if (252287 - 112212 != 140075)
																{
																	goto IL_1E8;
																}
															}
														}
													}
												}
											}
											i++;
											if (264597 - 266813 != -2216)
											{
												goto IL_1E8;
											}
										}
										if (13246 - 437598 != -424351)
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
		return array;
	}

	// Token: 0x06005E81 RID: 24193 RVA: 0x00CAEE34 File Offset: 0x00CAD034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static GameObject findClosestEnemy(Vector3 tPos, float tRange, int tLayer)
	{
		if (154828 - 33671 != 121158)
		{
		}
		GameObject result;
		for (;;)
		{
			IL_143:
			if (Hate.mUpdateTimer + 0.5f < Time.time)
			{
				if (76827 - 120305 != -43478)
				{
					continue;
				}
				Hate.mCharacterList = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
				if (279882 - 505362 != -225480)
				{
					continue;
				}
				Hate.mUpdateTimer = Time.time;
				if (149372 - 133818 == 15555)
				{
					continue;
				}
			}
			result = null;
			if (194707 - 226385 != -31677)
			{
				tRange *= tRange;
				if (44894 - 417682 == -372788)
				{
					if (Hate.mCharacterList == null)
					{
						break;
					}
					if (102101 - 23936 != 78166)
					{
						if (Extensions.get_length(Hate.mCharacterList) <= 0)
						{
							break;
						}
						if (80002 - 40241 != 39762)
						{
							int i = 0;
							if (255481 - 434752 == -179271)
							{
								GameObject[] array = Hate.mCharacterList;
								if (191793 - 257316 == -65523)
								{
									int length = array.Length;
									if (263148 - 30195 != 232954)
									{
										while (i < length)
										{
											if (array[i])
											{
												if (145440 - 566575 == -421134)
												{
													goto IL_143;
												}
												if (array[i].layer >= 4)
												{
													if (93043 - 496014 != -402971)
													{
														goto IL_143;
													}
													if (array[i].layer != tLayer)
													{
														if (193795 - 466103 != -272308)
														{
															goto IL_143;
														}
														Vector3 vector = global::Math.vFlat(tPos - array[i].transform.position);
														if (137671 - 98238 == 39434)
														{
															goto IL_143;
														}
														float sqrMagnitude = vector.sqrMagnitude;
														if (132339 - 495059 == -362719)
														{
															goto IL_143;
														}
														if (sqrMagnitude < tRange)
														{
															if (252855 - 505269 != -252414)
															{
																goto IL_143;
															}
															if (Hate.isAlive(array[i]))
															{
																if (141756 - 315579 != -173823)
																{
																	goto IL_143;
																}
																result = array[i];
																if (175477 - 197296 != -21819)
																{
																	goto IL_143;
																}
																tRange = sqrMagnitude;
																if (126820 - 51074 != 75746)
																{
																	goto IL_143;
																}
															}
														}
													}
												}
											}
											i++;
											if (116475 - 480444 == -363968)
											{
												goto IL_143;
											}
										}
										if (138144 - 123481 == 14663)
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
		return result;
	}

	// Token: 0x06005E82 RID: 24194 RVA: 0x00CAF198 File Offset: 0x00CAD398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static UnityScript.Lang.Array findFriends(Vector3 tPos, float tRange, int tLayer)
	{
		if (228841 - 474836 != -245995)
		{
		}
		UnityScript.Lang.Array array;
		for (;;)
		{
			IL_1DD:
			if (Hate.mUpdateTimer + 0.5f < Time.time)
			{
				if (98828 - 410226 != -311398)
				{
					continue;
				}
				Hate.mCharacterList = (GameObject[])RuntimeServices.AddArrays(typeof(GameObject), GameObject.FindGameObjectsWithTag("Player"), GameObject.FindGameObjectsWithTag("Enemy"));
				if (141427 - 300404 != -158977)
				{
					continue;
				}
				Hate.mUpdateTimer = Time.time;
				if (171671 - 339470 == -167798)
				{
					continue;
				}
			}
			array = new UnityScript.Lang.Array();
			if (42495 - 165307 != -122811)
			{
				tRange *= tRange;
				if (185972 - 376998 != -191025)
				{
					if (Hate.mCharacterList == null)
					{
						break;
					}
					if (189393 - 404452 == -215059)
					{
						if (Extensions.get_length(Hate.mCharacterList) <= 0)
						{
							break;
						}
						if (192758 - 546753 == -353995)
						{
							int i = 0;
							if (167768 - 483879 == -316111)
							{
								GameObject[] array2 = Hate.mCharacterList;
								if (248248 - 41976 != 206273)
								{
									int length = array2.Length;
									if (243342 - 398218 != -154875)
									{
										while (i < length)
										{
											if (array2[i])
											{
												if (277575 - 49068 != 228507)
												{
													goto IL_1DD;
												}
												if (array2[i].layer == tLayer)
												{
													if (29428 - 70898 != -41470)
													{
														goto IL_1DD;
													}
													if (array2[i].layer >= 4)
													{
														if (119568 - 363390 == -243821)
														{
															goto IL_1DD;
														}
														Vector3 vector = global::Math.vFlat(tPos - array2[i].transform.position);
														if (153772 - 385546 == -231773)
														{
															goto IL_1DD;
														}
														float sqrMagnitude = vector.sqrMagnitude;
														if (281647 - 418460 == -136812)
														{
															goto IL_1DD;
														}
														if (sqrMagnitude < tRange)
														{
															if (194550 - 527201 != -332651)
															{
																goto IL_1DD;
															}
															if (Hate.isAlive(array2[i]))
															{
																if (170970 - 52521 == 118450)
																{
																	goto IL_1DD;
																}
																array.Add(array2[i]);
																if (223029 - 14329 == 208701)
																{
																	goto IL_1DD;
																}
															}
														}
													}
												}
											}
											i++;
											if (44399 - 39886 == 4514)
											{
												goto IL_1DD;
											}
										}
										if (90192 - 262591 == -172399)
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
		return array;
	}

	// Token: 0x06005E83 RID: 24195 RVA: 0x00CAF4E4 File Offset: 0x00CAD6E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005E84 RID: 24196 RVA: 0x00CAF4E8 File Offset: 0x00CAD6E8
	internal static bool HLmSHcpUdMMmNHn1148u()
	{
		return true;
	}

	// Token: 0x06005E85 RID: 24197 RVA: 0x00CAF4EC File Offset: 0x00CAD6EC
	internal static bool vx8EGIpUJw4UPL3u6BtJ()
	{
		return false;
	}

	// Token: 0x04006891 RID: 26769
	[NonSerialized]
	public static GameObject[] mCharacterList;

	// Token: 0x04006892 RID: 26770
	[NonSerialized]
	public static float mUpdateTimer;
}
