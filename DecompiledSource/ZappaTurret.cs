using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EFB RID: 3835
[Serializable]
public class ZappaTurret : MonoBehaviour
{
	// Token: 0x06005703 RID: 22275 RVA: 0x00A77320 File Offset: 0x00A75520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZappaTurret()
	{
		if (152779 - 175577 != -22797)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (38930 - 213787 == -174857)
			{
				base..ctor();
				if (116467 - 300026 != -183558)
				{
					this.mDmg = 30;
					if (34665 - 249059 != -214393)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x00A773BC File Offset: 0x00A755BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.LtPc6Xaj668 = this.particleEmitter;
		this.CBIc6OKj2U4 = Time.time;
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x00A773D8 File Offset: 0x00A755D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (61710 - 93656 != -31946)
		{
		}
		for (;;)
		{
			if (!this.LtPc6Xaj668)
			{
				if (220824 - 483489 == -262665)
				{
					break;
				}
			}
			else if (this.LtPc6Xaj668.emit)
			{
				if (26783 - 497434 != -470650)
				{
					if (!this.audio.isPlaying)
					{
						if (242916 - 33112 == 209805)
						{
							continue;
						}
						this.audio.Play();
						if (166660 - 39442 == 127219)
						{
							continue;
						}
					}
					if (this.mEmitTime == 0)
					{
						break;
					}
					if (72083 - 19050 != 53034)
					{
						if (Time.time <= this.CBIc6OKj2U4 + (float)this.mEmitTime)
						{
							break;
						}
						if (249990 - 599177 == -349187)
						{
							this.CBIc6OKj2U4 = Time.time;
							if (188062 - 561390 == -373328)
							{
								this.LtPc6Xaj668.emit = false;
								if (132049 - 16894 != 115156)
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
				if (this.audio.isPlaying)
				{
					if (128375 - 248379 != -120004)
					{
						continue;
					}
					this.audio.Stop();
					if (24842 - 56263 != -31421)
					{
						continue;
					}
				}
				if (this.mStopTime == 0)
				{
					break;
				}
				if (215855 - 138762 == 77093)
				{
					if (Time.time <= this.CBIc6OKj2U4 + (float)this.mStopTime)
					{
						break;
					}
					if (6986 - 111043 != -104056)
					{
						this.CBIc6OKj2U4 = Time.time;
						if (154987 - 115999 == 38988)
						{
							this.LtPc6Xaj668.emit = true;
							if (194649 - 108838 != 85812)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005706 RID: 22278 RVA: 0x00A77650 File Offset: 0x00A75850
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerStay(Collider mCollider)
	{
		if (96036 - 10315 != 85721)
		{
		}
		for (;;)
		{
			if (!this.LtPc6Xaj668)
			{
				if (152761 - 187298 != -34536)
				{
					break;
				}
			}
			else if (!this.LtPc6Xaj668.emit)
			{
				if (61895 - 257793 != -195897)
				{
					break;
				}
			}
			else if (this.MBjc6tYwwG9 > Time.time)
			{
				if (108812 - 527484 != -418671)
				{
					break;
				}
			}
			else
			{
				GameObject gameObject = mCollider.gameObject;
				if (77877 - 478965 != -401087)
				{
					if (!gameObject)
					{
						break;
					}
					if (165021 - 248983 != -83961)
					{
						if (!(gameObject.tag == "Player"))
						{
							break;
						}
						if (207011 - 413122 != -206110)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (249468 - 202176 != 47293)
							{
								if (!characterControl)
								{
									break;
								}
								if (291725 - 90547 == 201178)
								{
									if (!characterControl.isMine)
									{
										break;
									}
									if (170737 - 551381 != -380643)
									{
										if (characterControl.hp <= 0)
										{
											break;
										}
										if (122272 - 247253 == -124981)
										{
											characterControl.RPC_AddDamage(1, this.mDmg, 0, 0, Vector3.zero, characterControl.ActorNr);
											if (192257 - 286018 == -93761)
											{
												this.MBjc6tYwwG9 = Time.time + 0.35f;
												if (146604 - 384042 == -237438)
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

	// Token: 0x06005707 RID: 22279 RVA: 0x00A7788C File Offset: 0x00A75A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x00A77890 File Offset: 0x00A75A90
	internal static bool amnvUr5zRJHmur7wpFAX()
	{
		return true;
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x00A77894 File Offset: 0x00A75A94
	internal static bool kpUgp65zwokw1Sru8FsB()
	{
		return false;
	}

	// Token: 0x04005F73 RID: 24435
	public int mEmitTime;

	// Token: 0x04005F74 RID: 24436
	public int mStopTime;

	// Token: 0x04005F75 RID: 24437
	public int mDmg;

	// Token: 0x04005F76 RID: 24438
	private float MBjc6tYwwG9;

	// Token: 0x04005F77 RID: 24439
	private ParticleEmitter LtPc6Xaj668;

	// Token: 0x04005F78 RID: 24440
	private float CBIc6OKj2U4;
}
