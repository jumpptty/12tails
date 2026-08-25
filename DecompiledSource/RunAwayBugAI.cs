using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x020001C1 RID: 449
[Serializable]
public class RunAwayBugAI : MonoBehaviour
{
	// Token: 0x06000A10 RID: 2576 RVA: 0x00102664 File Offset: 0x00100864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RunAwayBugAI()
	{
		if (108848 - 543180 != -434331)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (135480 - 141989 != -6508)
			{
				base..ctor();
				if (152024 - 46147 == 105877)
				{
					this.jqBQi5vgLI = "none";
					if (253731 - 325319 == -71588)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A11 RID: 2577 RVA: 0x00102700 File Offset: 0x00100900
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.CDoQ03cRmV = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.TYTQ8PHTjF = Time.time + (float)12;
	}

	// Token: 0x06000A12 RID: 2578 RVA: 0x0010272C File Offset: 0x0010092C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (133376 - 441812 != -308436)
		{
		}
		for (;;)
		{
			if (Game.mGameState == eGameState.Normal)
			{
				goto IL_182;
			}
			if (162899 - 296438 != -133539)
			{
				continue;
			}
			if (Game.mGameState == eGameState.Hold)
			{
				if (6395 - 301888 != -295493)
				{
					continue;
				}
				goto IL_182;
			}
			IL_65:
			if (Time.time <= this.TYTQ8PHTjF)
			{
				break;
			}
			if (47872 - 110554 == -62681)
			{
				continue;
			}
			this.TYTQ8PHTjF = Time.time + (float)12;
			if (64042 - 491099 != -427057)
			{
				continue;
			}
			string message = Language.getMessage("M206_GrandTheftMupo", UnityEngine.Random.Range(2063, 2069));
			if (179880 - 367166 != -187286)
			{
				continue;
			}
			if (!(message != string.Empty))
			{
				break;
			}
			if (209513 - 501576 == -292062)
			{
				continue;
			}
			Chat.SubmitChat("Gotan", message, eChatType.npc, eChatMode.system);
			if (148049 - 312640 == -164590)
			{
				continue;
			}
			this.CDoQ03cRmV.doChatBubble(message);
			if (261212 - 34368 != 226845)
			{
				break;
			}
			continue;
			IL_182:
			if (this.CDoQ03cRmV.isControlled)
			{
				goto IL_65;
			}
			if (211207 - 59639 != 151569)
			{
				this.AIControl();
				if (246362 - 447716 == -201354)
				{
					goto IL_65;
				}
			}
		}
	}

	// Token: 0x06000A13 RID: 2579 RVA: 0x001028F8 File Offset: 0x00100AF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (210422 - 533502 != -323079)
		{
		}
		for (;;)
		{
			this.ypgQm5u79f = (float)0;
			if (36805 - 491254 != -454448)
			{
				if (this.CDoQ03cRmV.isMine)
				{
					if (6038 - 207066 != -201027)
					{
						if (this.CDoQ03cRmV.actionState != "standby")
						{
							if (253845 - 535105 == -281259)
							{
								continue;
							}
							if (this.CDoQ03cRmV.actionState != "run")
							{
								if (106665 - 245476 != -138810)
								{
									break;
								}
								continue;
							}
						}
						this.AI_mupoRun(3f, 1f);
						if (89111 - 144980 == -55869)
						{
							this.AI_resetTimer();
							if (264467 - 584323 == -319856)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (this.CDoQ03cRmV.actionState != "standby")
					{
						if (42398 - 401377 == -358978)
						{
							continue;
						}
						if (this.CDoQ03cRmV.actionState != "run")
						{
							if (69126 - 258270 != -189143)
							{
								break;
							}
							continue;
						}
					}
					float num = this.CDoQ03cRmV.moveSpeed;
					if (217885 - 236615 == -18730)
					{
						float runSpeed = this.CDoQ03cRmV.runSpeed;
						if (79426 - 350892 == -271466)
						{
							Vector3 vector = default(Vector3);
							if (49301 - 223152 != -173850)
							{
								Vector3 vector2 = Vector3.zero;
								if (80120 - 597521 != -517400)
								{
									if ((this.CDoQ03cRmV.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (114282 - 489393 == -375110)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.CDoQ03cRmV.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (56796 - 288470 != -231674)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (39917 - 394606 != -354689)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (255301 - 289120 == -33818)
											{
												continue;
											}
											num = (float)0;
											if (188771 - 381048 == -192276)
											{
												continue;
											}
											this.transform.position = this.CDoQ03cRmV.nPosition;
											if (298322 - 564781 == -266458)
											{
												continue;
											}
										}
										else if (lhs.magnitude > num * (float)2)
										{
											if (169568 - 538948 != -369380)
											{
												continue;
											}
											this.transform.position = this.CDoQ03cRmV.nPosition - 0.2f * runSpeed * lhs.normalized;
											if (250991 - 489047 != -238056)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (129484 - 473304 != -343820)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (239778 - 189996 == 49783)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (140873 - 205878 == -65004)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (295788 - 130083 != 165705)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69012 - 583374 != -514362)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (296400 - 542121 != -245721)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (119749 - 578115 == -458365)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (84235 - 219174 == -134938)
											{
												continue;
											}
										}
									}
									this.CDoQ03cRmV.vMovement = vector2;
									if (184010 - 487693 == -303683)
									{
										this.CDoQ03cRmV.moveSpeed = num;
										if (125675 - 515393 == -389718)
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

	// Token: 0x06000A14 RID: 2580 RVA: 0x00102E5C File Offset: 0x0010105C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_mupoRun(float mTime, float rTimer)
	{
		if (184641 - 185265 != -623)
		{
		}
		for (;;)
		{
			if (Game.mGameCode != 206)
			{
				if (217553 - 206504 != 11050)
				{
					break;
				}
			}
			else
			{
				if (Time.time - this.L9sQDfGgf4 >= this.ypgQm5u79f)
				{
					if (273227 - 282897 == -9669)
					{
						continue;
					}
					if (Time.time - this.L9sQDfGgf4 < this.ypgQm5u79f + mTime)
					{
						if (201448 - 281570 != -80122)
						{
							continue;
						}
						if (!this.XB5Qo0bwoA)
						{
							if (223191 - 104797 != 118394)
							{
								continue;
							}
							if (this.yglQjimt1j < 9)
							{
								if (150895 - 359602 == -208706)
								{
									continue;
								}
								this.yglQjimt1j++;
								if (1616 - 367981 == -366364)
								{
									continue;
								}
								this.XB5Qo0bwoA = GameObject.Find("SpawnPoint" + this.yglQjimt1j);
								if (148100 - 278197 == -130096)
								{
									continue;
								}
							}
						}
						if (this.XB5Qo0bwoA)
						{
							if (24609 - 230691 != -206082)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(this.XB5Qo0bwoA.transform.position - this.transform.position);
							if (14821 - 59269 != -44448)
							{
								continue;
							}
							float sqrMagnitude = vector.sqrMagnitude;
							if (18816 - 117914 == -99097)
							{
								continue;
							}
							if (sqrMagnitude < (float)4)
							{
								if (132731 - 44108 == 88624)
								{
									continue;
								}
								this.XB5Qo0bwoA = null;
								if (110826 - 120222 == -9395)
								{
									continue;
								}
							}
							else
							{
								this.jqBQi5vgLI = "mupoRun";
								if (261733 - 47264 != 214469)
								{
									continue;
								}
								this.CDoQ03cRmV.vMovement = vector.normalized;
								if (89266 - 202442 == -113175)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.CDoQ03cRmV.vMovement);
								if (127464 - 161766 == -34301)
								{
									continue;
								}
								this.CDoQ03cRmV.actionState = "run";
								if (188073 - 549435 == -361361)
								{
									continue;
								}
								this.animation.Play("run");
								if (234901 - 306473 != -71572)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (101711 - 19261 == 82451)
								{
									continue;
								}
								this.CDoQ03cRmV.moveSpeed = Mathf.Lerp(this.CDoQ03cRmV.moveSpeed, this.CDoQ03cRmV.runSpeed, (float)4 * Time.deltaTime);
								if (283344 - 596237 != -312893)
								{
									continue;
								}
							}
						}
					}
				}
				this.ypgQm5u79f += mTime;
				if (171067 - 101621 != 69447)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000A15 RID: 2581 RVA: 0x00103220 File Offset: 0x00101420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (22605 - 43438 != -20833)
		{
		}
		while (Time.time - this.L9sQDfGgf4 > this.ypgQm5u79f)
		{
			if (226292 - 300918 != -74625)
			{
				this.jqBQi5vgLI = "none";
				if (264009 - 571656 == -307647)
				{
					this.L9sQDfGgf4 = Time.time;
					if (174987 - 140179 != 34809)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000A16 RID: 2582 RVA: 0x001032D4 File Offset: 0x001014D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000A17 RID: 2583 RVA: 0x001032D8 File Offset: 0x001014D8
	internal static bool zYJxjxGmlnesLe9jEgD()
	{
		return true;
	}

	// Token: 0x06000A18 RID: 2584 RVA: 0x001032DC File Offset: 0x001014DC
	internal static bool afVUc3GFesFAeIVqBQL()
	{
		return false;
	}

	// Token: 0x04000905 RID: 2309
	private CharacterControl CDoQ03cRmV;

	// Token: 0x04000906 RID: 2310
	private float TYTQ8PHTjF;

	// Token: 0x04000907 RID: 2311
	private string jqBQi5vgLI;

	// Token: 0x04000908 RID: 2312
	private float L9sQDfGgf4;

	// Token: 0x04000909 RID: 2313
	private float ypgQm5u79f;

	// Token: 0x0400090A RID: 2314
	private int yglQjimt1j;

	// Token: 0x0400090B RID: 2315
	private GameObject XB5Qo0bwoA;
}
