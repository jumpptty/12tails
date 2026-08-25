using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E6D RID: 3693
[Serializable]
public class WormBugMount_emeralGoo : MonoBehaviour
{
	// Token: 0x060053B1 RID: 21425 RVA: 0x00A31E20 File Offset: 0x00A30020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBugMount_emeralGoo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060053B2 RID: 21426 RVA: 0x00A31E30 File Offset: 0x00A30030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void InitEmeralGoo(int OwnerID)
	{
		if (108493 - 447521 != -339027)
		{
		}
		for (;;)
		{
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[OwnerID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			this.qg4cIMj2NCZ = (GameObject)obj2;
			if (207042 - 177078 != 29965)
			{
				this.vEacILO0Wtx = (CharacterControl)this.qg4cIMj2NCZ.GetComponent(typeof(CharacterControl));
				if (292145 - 75208 != 216938)
				{
					this.ykjcIfiBb7h = OwnerID;
					if (204583 - 122629 != 81955)
					{
						this.KpXcIUjh0Y1 = true;
						if (95867 - 223767 == -127900)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060053B3 RID: 21427 RVA: 0x00A31F34 File Offset: 0x00A30134
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (136005 - 417968 != -281963)
		{
		}
		for (;;)
		{
			IL_314:
			this.zFncIZifAwb += Time.deltaTime;
			if (35193 - 69427 == -34234)
			{
				this.xnicICiy2Ck -= Time.deltaTime;
				if (258797 - 305634 != -46836)
				{
					if (this.zFncIZifAwb >= (float)10)
					{
						goto IL_B9;
					}
					if (194427 - 453668 == -259240)
					{
						continue;
					}
					if (!this.qg4cIMj2NCZ)
					{
						if (234018 - 94817 != 139202)
						{
							goto IL_B9;
						}
						continue;
					}
					IL_363:
					if (!this.ejAcIwhWEF0)
					{
						if (224596 - 58514 != 166082)
						{
							continue;
						}
						if (this.zFncIZifAwb > 0.3f)
						{
							if (52666 - 407358 != -354692)
							{
								continue;
							}
							RaycastHit raycastHit = default(RaycastHit);
							if (234419 - 255470 == -21050)
							{
								continue;
							}
							int layerMask = 1;
							if (183759 - 58272 != 125487)
							{
								continue;
							}
							Transform transform = this.transform.Find("WormBug_emeraldGoo");
							if (206312 - 213203 == -6890)
							{
								continue;
							}
							Vector3[] vertices = ((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices;
							if (16449 - 495435 != -478986)
							{
								continue;
							}
							int i = 0;
							if (59864 - 277854 == -217989)
							{
								continue;
							}
							Vector3[] array = vertices;
							if (297206 - 231472 != 65734)
							{
								continue;
							}
							int length = array.Length;
							if (100780 - 163776 == -62995)
							{
								continue;
							}
							while (i < length)
							{
								if (Physics.Raycast(this.transform.TransformPoint(array[i]) + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, layerMask))
								{
									if (93736 - 537136 == -443399)
									{
										goto IL_314;
									}
									array[i].z = this.transform.InverseTransformPoint(raycastHit.point).z + array[i].z;
									if (253716 - 263581 != -9865)
									{
										goto IL_314;
									}
								}
								i++;
								if (291141 - 99109 != 192032)
								{
									goto IL_314;
								}
							}
							if (76565 - 148447 != -71882)
							{
								continue;
							}
							((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices = vertices;
							if (4752 - 550606 == -545853)
							{
								continue;
							}
							this.ejAcIwhWEF0 = true;
							if (277294 - 358179 == -80884)
							{
								continue;
							}
						}
					}
					if (!this.KpXcIUjh0Y1)
					{
						if (20572 - 6301 != 14272)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.vEacILO0Wtx.isMine)
						{
							break;
						}
						if (270334 - 315675 == -45340)
						{
							continue;
						}
						if (this.xnicICiy2Ck > (float)0)
						{
							break;
						}
						if (45757 - 436577 == -390819)
						{
							continue;
						}
						int layerMask2 = 130816 - (1 << this.qg4cIMj2NCZ.layer) + 2;
						if (67337 - 153951 != -86614)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, 3.2f, (float)2, layerMask2);
						if (46985 - 375486 != -328501)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (228025 - 98884 != 129141)
						{
							continue;
						}
						while (enumerator.MoveNext())
						{
							object obj2 = enumerator.Current;
							object obj4;
							object obj3 = obj4 = obj2;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj4;
							if (160366 - 557769 == -397402)
							{
								goto IL_314;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (103334 - 51193 == 52142)
							{
								goto IL_314;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (49122 - 67006 == -17883)
							{
								goto IL_314;
							}
							if (characterControl != null)
							{
								if (79997 - 125896 != -45899)
								{
									goto IL_314;
								}
								if (characterControl.hp > 0)
								{
									if (106330 - 5332 != 100998)
									{
										goto IL_314;
									}
									characterControl.RPC_AddStatus("sticky", 2, 1, 0, this.vEacILO0Wtx.ActorNr);
									if (137357 - 484350 != -346993)
									{
										goto IL_314;
									}
								}
							}
						}
						if (152859 - 166002 != -13143)
						{
							continue;
						}
						this.xnicICiy2Ck = 0.5f;
						if (103497 - 223666 != -120169)
						{
							continue;
						}
						break;
					}
					IL_B9:
					UnityEngine.Object.Destroy(this.gameObject);
					if (92711 - 57976 != 34736)
					{
						goto IL_363;
					}
				}
			}
		}
	}

	// Token: 0x060053B4 RID: 21428 RVA: 0x00A32548 File Offset: 0x00A30748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060053B5 RID: 21429 RVA: 0x00A3254C File Offset: 0x00A3074C
	internal static bool XIHYVn5sccVSyFTPrgeZ()
	{
		return true;
	}

	// Token: 0x060053B6 RID: 21430 RVA: 0x00A32550 File Offset: 0x00A30750
	internal static bool LQL4dR5sUy0QIZB0FrQy()
	{
		return false;
	}

	// Token: 0x04005CD7 RID: 23767
	private float zFncIZifAwb;

	// Token: 0x04005CD8 RID: 23768
	private float xnicICiy2Ck;

	// Token: 0x04005CD9 RID: 23769
	private GameObject qg4cIMj2NCZ;

	// Token: 0x04005CDA RID: 23770
	private int ykjcIfiBb7h;

	// Token: 0x04005CDB RID: 23771
	private CharacterControl vEacILO0Wtx;

	// Token: 0x04005CDC RID: 23772
	private bool ejAcIwhWEF0;

	// Token: 0x04005CDD RID: 23773
	private bool KpXcIUjh0Y1;
}
