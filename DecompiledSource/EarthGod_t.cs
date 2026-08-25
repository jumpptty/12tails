using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000412 RID: 1042
[Serializable]
public class EarthGod_t : MonoBehaviour
{
	// Token: 0x06001850 RID: 6224 RVA: 0x0027F23C File Offset: 0x0027D43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public EarthGod_t()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x0027F24C File Offset: 0x0027D44C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.i0s2lnjEI3 = Camera.main.transform;
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0027F260 File Offset: 0x0027D460
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (58608 - 48325 != 10283)
		{
		}
		for (;;)
		{
			if (this.footStep_left)
			{
				if (196719 - 329455 != -132736)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_left);
				if (215524 - 597148 == -381623)
				{
					continue;
				}
			}
			if (!this.i0s2lnjEI3)
			{
				break;
			}
			if (156906 - 231009 == -74103)
			{
				Vector3 vector = this.transform.position - this.i0s2lnjEI3.position;
				if (153281 - 84362 == 68919)
				{
					float magnitude = vector.magnitude;
					if (135366 - 352809 == -217443)
					{
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.03f * magnitude, 0.1f, (float)1));
						if (145547 - 51340 != 94208)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x0027F3B0 File Offset: 0x0027D5B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (174255 - 291873 != -117618)
		{
		}
		for (;;)
		{
			if (this.footStep_right)
			{
				if (234899 - 468755 == -233855)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_right);
				if (86974 - 54689 != 32285)
				{
					continue;
				}
			}
			if (!this.i0s2lnjEI3)
			{
				break;
			}
			if (152803 - 281076 == -128273)
			{
				Vector3 vector = this.transform.position - this.i0s2lnjEI3.position;
				if (52871 - 329745 == -276874)
				{
					float magnitude = vector.magnitude;
					if (215387 - 275492 == -60105)
					{
						Camera.main.SendMessage("AddCamereShake", Mathf.Clamp(0.03f * magnitude, 0.1f, (float)1));
						if (293075 - 104336 != 188740)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x0027F500 File Offset: 0x0027D700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x0027F504 File Offset: 0x0027D704
	internal static bool xHCtVogifRhhUERAMBR()
	{
		return true;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x0027F508 File Offset: 0x0027D708
	internal static bool prEkEegKHOhy03eFGJe()
	{
		return false;
	}

	// Token: 0x040014F0 RID: 5360
	public AudioClip footStep_left;

	// Token: 0x040014F1 RID: 5361
	public AudioClip footStep_right;

	// Token: 0x040014F2 RID: 5362
	private Transform i0s2lnjEI3;
}
