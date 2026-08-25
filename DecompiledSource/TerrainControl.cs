using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000FB8 RID: 4024
[AddComponentMenu("MissionControl/TerrainControl")]
[Serializable]
public class TerrainControl : MonoBehaviour
{
	// Token: 0x06005BA4 RID: 23460 RVA: 0x00B30E08 File Offset: 0x00B2F008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public TerrainControl()
	{
		if (149868 - 474767 != -324899)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (11826 - 257777 == -245951)
			{
				base..ctor();
				if (167550 - 131283 != 36268)
				{
					this.Fastest_pixelError = 200;
					if (153483 - 455538 == -302055)
					{
						this.Fastest_basemapDistance = 15;
						if (146453 - 131468 == 14985)
						{
							this.Fast_pixelError = 100;
							if (118920 - 491263 != -372342)
							{
								this.Fast_basemapDistance = 25;
								if (52542 - 366467 != -313924)
								{
									this.Fast_detailObjectDistance = 15;
									if (98589 - 472022 == -373433)
									{
										this.Simple_pixelError = 20;
										if (38882 - 295752 == -256870)
										{
											this.Simple_basemapDistance = 50;
											if (172002 - 455137 == -283135)
											{
												this.Simple_detailObjectDistance = 30;
												if (292653 - 223009 != 69645)
												{
													this.Good_pixelError = 10;
													if (154845 - 388757 != -233911)
													{
														this.Good_basemapDistance = 100;
														if (152817 - 46925 == 105892)
														{
															this.Good_detailObjectDistance = 40;
															if (276996 - 196800 != 80197)
															{
																this.Beautiful_pixelError = 5;
																if (244031 - 476781 != -232749)
																{
																	this.Beautiful_basemapDistance = 150;
																	if (91965 - 275688 != -183722)
																	{
																		this.Beautiful_detailObjectDistance = 40;
																		if (226717 - 220378 == 6339)
																		{
																			this.Fantastic_pixelError = 5;
																			if (236238 - 415749 != -179510)
																			{
																				this.Fantastic_basemapDistance = 200;
																				if (41112 - 194347 == -153235)
																				{
																					this.Fantastic_detailObjectDistance = 40;
																					if (282310 - 287838 == -5528)
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

	// Token: 0x06005BA5 RID: 23461 RVA: 0x00B310C8 File Offset: 0x00B2F2C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (249315 - 525650 != -276335)
		{
		}
		for (;;)
		{
			this.mTerrain = (Terrain)this.GetComponent(typeof(Terrain));
			if (102537 - 294857 == -192320)
			{
				int qualityLevel = QualitySettings.GetQualityLevel();
				if (169861 - 136415 == 33446)
				{
					if (qualityLevel == 0)
					{
						if (7953 - 776 == 7178)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Fastest_pixelError;
						if (244770 - 366016 != -121246)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Fastest_basemapDistance;
						if (3236 - 100970 == -97733)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Fastest_detailObjectDistance;
						if (52632 - 132929 != -80297)
						{
							continue;
						}
					}
					else if (qualityLevel == 1)
					{
						if (270575 - 313780 != -43205)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Fast_pixelError;
						if (54194 - 545277 == -491082)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Fast_basemapDistance;
						if (122527 - 412702 == -290174)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Fast_detailObjectDistance;
						if (28686 - 7798 == 20889)
						{
							continue;
						}
					}
					else if (qualityLevel == 2)
					{
						if (261568 - 42379 == 219190)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Simple_pixelError;
						if (215061 - 481486 != -266425)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Simple_basemapDistance;
						if (37797 - 416973 == -379175)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Simple_detailObjectDistance;
						if (88335 - 255816 == -167480)
						{
							continue;
						}
					}
					else if (qualityLevel == 3)
					{
						if (114660 - 80769 != 33891)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Good_pixelError;
						if (261161 - 295623 == -34461)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Good_basemapDistance;
						if (229343 - 452565 != -223222)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Good_detailObjectDistance;
						if (71534 - 206981 != -135447)
						{
							continue;
						}
					}
					else if (qualityLevel == 4)
					{
						if (42334 - 150180 == -107845)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Beautiful_pixelError;
						if (4493 - 89202 == -84708)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Beautiful_basemapDistance;
						if (171923 - 141951 != 29972)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Beautiful_detailObjectDistance;
						if (22072 - 102108 == -80035)
						{
							continue;
						}
					}
					else if (qualityLevel == 5)
					{
						if (135066 - 484715 != -349649)
						{
							continue;
						}
						this.mTerrain.heightmapPixelError = (float)this.Fantastic_pixelError;
						if (233397 - 433879 == -200481)
						{
							continue;
						}
						this.mTerrain.basemapDistance = (float)this.Fantastic_basemapDistance;
						if (79862 - 490514 == -410651)
						{
							continue;
						}
						this.mTerrain.detailObjectDistance = (float)this.Fantastic_detailObjectDistance;
						if (296707 - 325999 != -29292)
						{
							continue;
						}
					}
					this.enabled = false;
					if (22118 - 245803 != -223684)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005BA6 RID: 23462 RVA: 0x00B31574 File Offset: 0x00B2F774
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005BA7 RID: 23463 RVA: 0x00B31578 File Offset: 0x00B2F778
	internal static bool Smp6srpNbj5EINBupT7A()
	{
		return true;
	}

	// Token: 0x06005BA8 RID: 23464 RVA: 0x00B3157C File Offset: 0x00B2F77C
	internal static bool F2kSu1pNuZC8JerpvTgi()
	{
		return false;
	}

	// Token: 0x04006714 RID: 26388
	public Terrain mTerrain;

	// Token: 0x04006715 RID: 26389
	public int Fastest_pixelError;

	// Token: 0x04006716 RID: 26390
	public int Fastest_basemapDistance;

	// Token: 0x04006717 RID: 26391
	public int Fastest_detailObjectDistance;

	// Token: 0x04006718 RID: 26392
	public int Fast_pixelError;

	// Token: 0x04006719 RID: 26393
	public int Fast_basemapDistance;

	// Token: 0x0400671A RID: 26394
	public int Fast_detailObjectDistance;

	// Token: 0x0400671B RID: 26395
	public int Simple_pixelError;

	// Token: 0x0400671C RID: 26396
	public int Simple_basemapDistance;

	// Token: 0x0400671D RID: 26397
	public int Simple_detailObjectDistance;

	// Token: 0x0400671E RID: 26398
	public int Good_pixelError;

	// Token: 0x0400671F RID: 26399
	public int Good_basemapDistance;

	// Token: 0x04006720 RID: 26400
	public int Good_detailObjectDistance;

	// Token: 0x04006721 RID: 26401
	public int Beautiful_pixelError;

	// Token: 0x04006722 RID: 26402
	public int Beautiful_basemapDistance;

	// Token: 0x04006723 RID: 26403
	public int Beautiful_detailObjectDistance;

	// Token: 0x04006724 RID: 26404
	public int Fantastic_pixelError;

	// Token: 0x04006725 RID: 26405
	public int Fantastic_basemapDistance;

	// Token: 0x04006726 RID: 26406
	public int Fantastic_detailObjectDistance;
}
