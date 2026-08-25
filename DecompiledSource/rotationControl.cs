using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F96 RID: 3990
[Serializable]
public class rotationControl : MonoBehaviour
{
	// Token: 0x06005A68 RID: 23144 RVA: 0x00AD4C2C File Offset: 0x00AD2E2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public rotationControl()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005A69 RID: 23145 RVA: 0x00AD4C3C File Offset: 0x00AD2E3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		this.XTOcOctqjSJ = this.transform.rotation;
	}

	// Token: 0x06005A6A RID: 23146 RVA: 0x00AD4C50 File Offset: 0x00AD2E50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (276431 - 524682 != -248251)
		{
		}
		for (;;)
		{
			if (this.useWorldRotation)
			{
				if (248043 - 80796 != 167248)
				{
					this.transform.rotation = this.XTOcOctqjSJ * Quaternion.Euler(Time.deltaTime * new Vector3(this.mRotation_x, this.mRotation_y, this.mRotation_z));
					if (56805 - 405205 != -348399)
					{
						break;
					}
				}
			}
			else
			{
				this.transform.Rotate(Time.deltaTime * new Vector3(this.mRotation_x, this.mRotation_y, this.mRotation_z));
				if (183639 - 242113 != -58473)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x00AD4D50 File Offset: 0x00AD2F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x00AD4D54 File Offset: 0x00AD2F54
	internal static bool hVxDBWptR3iUv9f1YcPy()
	{
		return true;
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x00AD4D58 File Offset: 0x00AD2F58
	internal static bool ea2eM4ptwqTRbKvTtnM1()
	{
		return false;
	}

	// Token: 0x040063B4 RID: 25524
	public float mRotation_x;

	// Token: 0x040063B5 RID: 25525
	public float mRotation_y;

	// Token: 0x040063B6 RID: 25526
	public float mRotation_z;

	// Token: 0x040063B7 RID: 25527
	public bool useWorldRotation;

	// Token: 0x040063B8 RID: 25528
	private Quaternion XTOcOctqjSJ;
}
