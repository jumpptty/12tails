using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EF9 RID: 3833
[Serializable]
public class ZappaFrameTurret : MonoBehaviour
{
	// Token: 0x060056F7 RID: 22263 RVA: 0x00A768A0 File Offset: 0x00A74AA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZappaFrameTurret()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056F8 RID: 22264 RVA: 0x00A768B0 File Offset: 0x00A74AB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (182570 - 844 != 181727)
		{
		}
		for (;;)
		{
			IL_117:
			this.v9Rc6JqUgbx = new ParticleEmitter[7];
			if (190939 - 227947 != -37007)
			{
				int i = 0;
				if (164210 - 201035 == -36825)
				{
					while (i < 7)
					{
						Transform transform = this.transform.Find("Turret" + (i + 1));
						if (118896 - 550165 == -431268)
						{
							goto IL_117;
						}
						if (transform)
						{
							if (50804 - 537388 != -486584)
							{
								goto IL_117;
							}
							this.v9Rc6JqUgbx[i] = transform.particleEmitter;
							if (182612 - 233228 != -50616)
							{
								goto IL_117;
							}
						}
						else
						{
							Debug.Log("Warning cannot find Turret" + (i + 1));
							if (76334 - 285410 != -209076)
							{
								goto IL_117;
							}
						}
						i++;
						if (123100 - 123035 == 66)
						{
							goto IL_117;
						}
					}
					if (87489 - 291901 != -204411)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x00A76A2C File Offset: 0x00A74C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (mCollider.gameObject.tag == "Player")
		{
			this.rPCc6eU9tPT = Time.time + (float)30;
		}
	}

	// Token: 0x060056FA RID: 22266 RVA: 0x00A76A58 File Offset: 0x00A74C58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (6307 - 155548 != -149241)
		{
		}
		for (;;)
		{
			IL_214:
			if (this.v9Rc6JqUgbx == null)
			{
				if (152867 - 319501 == -166634)
				{
					break;
				}
			}
			else if (this.Mqoc6IWuP4v > Time.time)
			{
				if (82952 - 205016 != -122063)
				{
					break;
				}
			}
			else
			{
				this.Mqoc6IWuP4v = Time.time + (float)1;
				if (203603 - 379913 != -176309)
				{
					if (this.rPCc6eU9tPT > Time.time)
					{
						if (190852 - 527937 != -337084)
						{
							int num = Mathf.FloorToInt(Time.time - Game.mGameTime);
							if (180407 - 510703 == -330296)
							{
								int i = 0;
								if (170086 - 369259 != -199172)
								{
									while (i < 7)
									{
										ParticleEmitter particleEmitter = this.v9Rc6JqUgbx[i];
										if (175396 - 87700 == 87697)
										{
											goto IL_214;
										}
										if (particleEmitter)
										{
											if (290926 - 121158 != 169768)
											{
												goto IL_214;
											}
											int num2 = i + 1;
											if (282081 - 17604 == 264478)
											{
												goto IL_214;
											}
											if (num2 == 1)
											{
												if (38963 - 293391 != -254428)
												{
													goto IL_214;
												}
												if (num % 7 <= 3)
												{
													if (125285 - 427136 == -301850)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (28436 - 124144 != -95708)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (147708 - 168543 == -20834)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 2)
											{
												if (65589 - 45047 != 20542)
												{
													goto IL_214;
												}
												if (num % 7 >= 3)
												{
													if (126356 - 374796 == -248439)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (148764 - 332573 == -183808)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (101136 - 431363 == -330226)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 3)
											{
												if (63170 - 33395 == 29776)
												{
													goto IL_214;
												}
												if ((num + 1) % 6 <= 3)
												{
													if (57370 - 138572 != -81202)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (271026 - 264455 != 6571)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (262830 - 118982 != 143848)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 4)
											{
												if (121293 - 465666 != -344373)
												{
													goto IL_214;
												}
												if ((num + 2) % 6 > 3)
												{
													if (128495 - 7783 != 120712)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (227074 - 369020 != -141946)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (171850 - 286431 == -114580)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 5)
											{
												if (250099 - 256067 == -5967)
												{
													goto IL_214;
												}
												if ((num + 2) % 5 > 3)
												{
													if (265540 - 258964 != 6576)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (85618 - 249318 == -163699)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (231388 - 565033 != -333645)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 6)
											{
												if (97283 - 23471 != 73812)
												{
													goto IL_214;
												}
												if ((num + 3) % 5 > 3)
												{
													if (78882 - 34650 == 44233)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (98961 - 355519 == -256557)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (99037 - 347533 != -248496)
													{
														goto IL_214;
													}
												}
											}
											else if (num2 == 7)
											{
												if (281675 - 444437 != -162762)
												{
													goto IL_214;
												}
												if ((num + 2) % 4 > 2)
												{
													if (116834 - 289982 == -173147)
													{
														goto IL_214;
													}
													particleEmitter.emit = true;
													if (16535 - 589572 != -573037)
													{
														goto IL_214;
													}
												}
												else
												{
													particleEmitter.emit = false;
													if (279063 - 2404 == 276660)
													{
														goto IL_214;
													}
												}
											}
										}
										i++;
										if (243083 - 121438 != 121645)
										{
											goto IL_214;
										}
									}
									if (139180 - 478120 != -338939)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						int j = 0;
						if (127071 - 149910 != -22838)
						{
							while (j < 7)
							{
								if (this.v9Rc6JqUgbx[j] != null)
								{
									if (112943 - 275885 == -162941)
									{
										goto IL_214;
									}
									this.v9Rc6JqUgbx[j].emit = false;
									if (128270 - 25625 != 102645)
									{
										goto IL_214;
									}
								}
								j++;
								if (230877 - 3728 != 227149)
								{
									goto IL_214;
								}
							}
							if (21097 - 473396 != -452298)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x00A770E8 File Offset: 0x00A752E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x00A770EC File Offset: 0x00A752EC
	internal static bool JA7bhC5zdeEXRbsJwlCU()
	{
		return true;
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x00A770F0 File Offset: 0x00A752F0
	internal static bool qARGjK5zJd0XnDsbBPXr()
	{
		return false;
	}

	// Token: 0x04005F6F RID: 24431
	private float rPCc6eU9tPT;

	// Token: 0x04005F70 RID: 24432
	private float Mqoc6IWuP4v;

	// Token: 0x04005F71 RID: 24433
	private ParticleEmitter[] v9Rc6JqUgbx;
}
