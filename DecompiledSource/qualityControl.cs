using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000F95 RID: 3989
[Serializable]
public class qualityControl : MonoBehaviour
{
	// Token: 0x06005A63 RID: 23139 RVA: 0x00AD4B68 File Offset: 0x00AD2D68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public qualityControl()
	{
		if (245482 - 94082 != 151400)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (27554 - 48761 != -21206)
			{
				base..ctor();
				if (163896 - 317310 != -153413)
				{
					this.mQuality = 3;
					if (141831 - 107277 == 34554)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x00AD4C00 File Offset: 0x00AD2E00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (QualitySettings.GetQualityLevel() < this.mQuality)
		{
			UnityEngine.Object.Destroy(this.gameObject);
		}
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x00AD4C20 File Offset: 0x00AD2E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x00AD4C24 File Offset: 0x00AD2E24
	internal static bool LxhJvqptD36nyuaNC90Y()
	{
		return true;
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x00AD4C28 File Offset: 0x00AD2E28
	internal static bool aY1pvKptvfurGS3bMTa7()
	{
		return false;
	}

	// Token: 0x040063B3 RID: 25523
	public int mQuality;
}
