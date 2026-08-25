using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000E01 RID: 3585
[Serializable]
public class WaterWave : MonoBehaviour
{
	// Token: 0x06005107 RID: 20743 RVA: 0x009EB050 File Offset: 0x009E9250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WaterWave()
	{
		if (131871 - 172018 != -40146)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (249454 - 360116 == -110662)
			{
				base..ctor();
				if (47742 - 28758 == 18984)
				{
					this.WaveHeight = (float)1;
					if (183175 - 208403 == -25228)
					{
						this.WaveSpeed_x = 0.5f;
						if (276702 - 19883 != 256820)
						{
							this.WaveSpeed_z = 0.5f;
							if (241157 - 501377 != -260219)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005108 RID: 20744 RVA: 0x009EB134 File Offset: 0x009E9334
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
	}

	// Token: 0x06005109 RID: 20745 RVA: 0x009EB138 File Offset: 0x009E9338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (153219 - 427248 != -274029)
		{
		}
		for (;;)
		{
			IL_B3:
			float num = 0f;
			if (54000 - 202638 != -148637)
			{
				Mesh mesh = ((MeshFilter)this.GetComponent(typeof(MeshFilter))).mesh;
				if (36188 - 347625 == -311437)
				{
					Vector3[] vertices = mesh.vertices;
					if (118684 - 276746 != -158061)
					{
						int i = 0;
						if (150166 - 494187 != -344020)
						{
							while (i < vertices.Length)
							{
								num = this.WaveSpeed_x * Mathf.Sin(Time.time + vertices[i].x);
								if (158937 - 87936 == 71002)
								{
									goto IL_B3;
								}
								num += this.WaveSpeed_z * Mathf.Sin(Time.time + vertices[i].z);
								if (224972 - 139405 == 85568)
								{
									goto IL_B3;
								}
								vertices[i].y = num * this.WaveHeight;
								if (152410 - 555540 == -403129)
								{
									goto IL_B3;
								}
								i++;
								if (95894 - 392209 == -296314)
								{
									goto IL_B3;
								}
							}
							if (287895 - 15399 != 272497)
							{
								mesh.vertices = vertices;
								if (260931 - 274332 != -13400)
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

	// Token: 0x0600510A RID: 20746 RVA: 0x009EB310 File Offset: 0x009E9510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600510B RID: 20747 RVA: 0x009EB314 File Offset: 0x009E9514
	internal static bool KcA5xI5ednTxVM9dQTYy()
	{
		return true;
	}

	// Token: 0x0600510C RID: 20748 RVA: 0x009EB318 File Offset: 0x009E9518
	internal static bool s04j6g5eJGnrTGLfFiIG()
	{
		return false;
	}

	// Token: 0x04005A95 RID: 23189
	public float WaveHeight;

	// Token: 0x04005A96 RID: 23190
	public float WaveSpeed_x;

	// Token: 0x04005A97 RID: 23191
	public float WaveSpeed_z;
}
