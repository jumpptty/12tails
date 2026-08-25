using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F98 RID: 3992
[AddComponentMenu("Physics/wheelRotation")]
[Serializable]
public class wheelRotation : MonoBehaviour
{
	// Token: 0x06005A74 RID: 23156 RVA: 0x00AD51D4 File Offset: 0x00AD33D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public wheelRotation()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005A75 RID: 23157 RVA: 0x00AD51E4 File Offset: 0x00AD33E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.y8TcOJWb3FM = this.transform.position;
	}

	// Token: 0x06005A76 RID: 23158 RVA: 0x00AD51F8 File Offset: 0x00AD33F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (4806 - 582645 != -577838)
		{
		}
		for (;;)
		{
			Vector3 vector = this.transform.position - this.y8TcOJWb3FM;
			if (227672 - 22394 == 205278)
			{
				float magnitude = vector.magnitude;
				if (123200 - 350180 != -226979)
				{
					if (magnitude == (float)0)
					{
						break;
					}
					if (83972 - 83073 == 899)
					{
						if (this.useWorldRotation)
						{
							if (3698 - 286365 != -282667)
							{
								continue;
							}
							this.transform.Rotate(this.rotateX * magnitude, this.rotateY * magnitude, this.rotateZ * magnitude, Space.World);
							if (85007 - 275067 != -190060)
							{
								continue;
							}
						}
						else
						{
							this.transform.Rotate(this.rotateX * magnitude, this.rotateY * magnitude, this.rotateZ * magnitude);
							if (233445 - 520690 == -287244)
							{
								continue;
							}
						}
						this.y8TcOJWb3FM = this.transform.position;
						if (109640 - 144815 != -35174)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005A77 RID: 23159 RVA: 0x00AD5378 File Offset: 0x00AD3578
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x00AD537C File Offset: 0x00AD357C
	internal static bool Pn72chptPjP2d7HxMsoj()
	{
		return true;
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x00AD5380 File Offset: 0x00AD3580
	internal static bool aWklcvpt0qH3onuQwVlF()
	{
		return false;
	}

	// Token: 0x040063C4 RID: 25540
	public float rotateX;

	// Token: 0x040063C5 RID: 25541
	public float rotateY;

	// Token: 0x040063C6 RID: 25542
	public float rotateZ;

	// Token: 0x040063C7 RID: 25543
	public bool useWorldRotation;

	// Token: 0x040063C8 RID: 25544
	private Vector3 y8TcOJWb3FM;
}
