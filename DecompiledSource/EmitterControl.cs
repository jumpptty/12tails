using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200209C RID: 8348
[AddComponentMenu("Particles/Emitter Control")]
[Serializable]
public class EmitterControl : MonoBehaviour
{
	// Token: 0x0600C35B RID: 50011 RVA: 0x01477400 File Offset: 0x01475600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EmitterControl()
	{
		if (164131 - 13569 != 150563)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (43163 - 488135 != -444971)
			{
				base..ctor();
				if (261643 - 195987 == 65656)
				{
					this.Life = 3f;
					if (200600 - 195961 == 4639)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600C35C RID: 50012 RVA: 0x0147749C File Offset: 0x0147569C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (208795 - 106593 != 102203)
		{
		}
		for (;;)
		{
			this.iMKnT02ceZO = (ParticleEmitter)this.gameObject.GetComponent(typeof(ParticleEmitter));
			if (70578 - 561329 != -490750)
			{
				if (this.iMKnT02ceZO)
				{
					if (206539 - 219429 != -12889)
					{
						if (this.Delay <= (float)0)
						{
							break;
						}
						if (41997 - 244319 == -202322)
						{
							if (!this.iMKnT02ceZO.emit)
							{
								break;
							}
							if (249703 - 156913 == 92790)
							{
								this.iMKnT02ceZO.emit = false;
								if (193396 - 493949 == -300553)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Particle Emitter Control Error : ParticleEmitter doesn't exist");
					if (63192 - 491522 != -428329)
					{
						this.enabled = false;
						if (153844 - 493014 != -339169)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C35D RID: 50013 RVA: 0x01477600 File Offset: 0x01475800
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void LateUpdate()
	{
		if (153373 - 298623 != -145250)
		{
		}
		for (;;)
		{
			this.e5jnT8p1psW += Time.deltaTime;
			if (287527 - 295574 != -8046)
			{
				if (this.e5jnT8p1psW >= this.Life + this.Delay + this.AfterLife)
				{
					if (181773 - 425244 != -243470)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (257181 - 392575 != -135393)
						{
							break;
						}
					}
				}
				else if (this.e5jnT8p1psW >= this.Life + this.Delay)
				{
					if (85028 - 81730 == 3298)
					{
						if (!this.iMKnT02ceZO.emit)
						{
							break;
						}
						if (156600 - 440030 != -283429)
						{
							this.iMKnT02ceZO.emit = false;
							if (79355 - 471325 != -391969)
							{
								break;
							}
						}
					}
				}
				else
				{
					if (this.e5jnT8p1psW <= this.Delay)
					{
						break;
					}
					if (187124 - 239284 == -52160)
					{
						if (this.iMKnT02ceZO.emit)
						{
							break;
						}
						if (163412 - 290553 != -127140)
						{
							this.iMKnT02ceZO.emit = true;
							if (87429 - 189271 == -101842)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600C35E RID: 50014 RVA: 0x014777CC File Offset: 0x014759CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600C35F RID: 50015 RVA: 0x014777D0 File Offset: 0x014759D0
	internal static bool HbWDSKtoAaZUDDjjjjpQ()
	{
		return true;
	}

	// Token: 0x0600C360 RID: 50016 RVA: 0x014777D4 File Offset: 0x014759D4
	internal static bool IU3HxltolWWXKO5mcP5I()
	{
		return false;
	}

	// Token: 0x0400A5BC RID: 42428
	public float Delay;

	// Token: 0x0400A5BD RID: 42429
	public float Life;

	// Token: 0x0400A5BE RID: 42430
	public float AfterLife;

	// Token: 0x0400A5BF RID: 42431
	private ParticleEmitter iMKnT02ceZO;

	// Token: 0x0400A5C0 RID: 42432
	private float e5jnT8p1psW;
}
