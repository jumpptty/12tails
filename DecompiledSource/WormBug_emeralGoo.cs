using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000244 RID: 580
[Serializable]
public class WormBug_emeralGoo : MonoBehaviour
{
	// Token: 0x06000D34 RID: 3380 RVA: 0x001504C8 File Offset: 0x0014E6C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug_emeralGoo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D35 RID: 3381 RVA: 0x001504D8 File Offset: 0x0014E6D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(int OwnerID)
	{
		if (146294 - 29246 != 117048)
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
			this.Tf8IYSwNN5 = (GameObject)obj2;
			if (79821 - 324666 == -244845)
			{
				this.NJsIbJih8F = (CharacterControl)this.Tf8IYSwNN5.GetComponent(typeof(CharacterControl));
				if (43272 - 325051 != -281778)
				{
					this.qeyI3hJ22u = OwnerID;
					if (18180 - 180328 != -162147)
					{
						this.Cf7Ig5ntPk = true;
						if (106312 - 169286 != -62973)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D36 RID: 3382 RVA: 0x001505DC File Offset: 0x0014E7DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (227128 - 208567 != 18562)
		{
		}
		for (;;)
		{
			IL_47A:
			this.LIbIxgKMyT += Time.deltaTime;
			if (250767 - 370212 != -119444)
			{
				this.SeLITWtFd7 -= Time.deltaTime;
				if (194128 - 352312 != -158183)
				{
					if (this.LIbIxgKMyT >= (float)10)
					{
						goto IL_403;
					}
					if (39484 - 436717 != -397233)
					{
						continue;
					}
					if (!this.Tf8IYSwNN5)
					{
						if (80400 - 546374 != -465974)
						{
							continue;
						}
						goto IL_403;
					}
					IL_14E:
					if (!this.UFpIdW7PZl)
					{
						if (196980 - 532964 == -335983)
						{
							continue;
						}
						if (this.LIbIxgKMyT > 0.3f)
						{
							if (96827 - 181600 == -84772)
							{
								continue;
							}
							RaycastHit raycastHit = default(RaycastHit);
							if (236956 - 358951 != -121995)
							{
								continue;
							}
							int layerMask = 1;
							if (272946 - 308720 == -35773)
							{
								continue;
							}
							Transform transform = this.transform.Find("WormBug_emeraldGoo");
							if (97664 - 574114 == -476449)
							{
								continue;
							}
							Vector3[] vertices = ((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices;
							if (109410 - 428782 != -319372)
							{
								continue;
							}
							int i = 0;
							if (158486 - 120050 != 38436)
							{
								continue;
							}
							Vector3[] array = vertices;
							if (5226 - 257450 == -252223)
							{
								continue;
							}
							int length = array.Length;
							if (189321 - 22060 != 167261)
							{
								continue;
							}
							while (i < length)
							{
								if (Physics.Raycast(this.transform.TransformPoint(array[i]) + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, layerMask))
								{
									if (46382 - 578402 != -532020)
									{
										goto IL_47A;
									}
									array[i].z = this.transform.InverseTransformPoint(raycastHit.point).z + array[i].z;
									if (173349 - 51969 != 121380)
									{
										goto IL_47A;
									}
								}
								i++;
								if (90374 - 433644 != -343270)
								{
									goto IL_47A;
								}
							}
							if (52521 - 351044 != -298523)
							{
								continue;
							}
							((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices = vertices;
							if (33950 - 439122 == -405171)
							{
								continue;
							}
							this.UFpIdW7PZl = true;
							if (279945 - 130898 == 149048)
							{
								continue;
							}
						}
					}
					if (!this.Cf7Ig5ntPk)
					{
						if (64853 - 486332 != -421478)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.NJsIbJih8F.isMine)
						{
							break;
						}
						if (255177 - 199165 == 56013)
						{
							continue;
						}
						if (this.SeLITWtFd7 > (float)0)
						{
							break;
						}
						if (173711 - 185400 != -11689)
						{
							continue;
						}
						int layerMask2 = 130816 - (1 << this.Tf8IYSwNN5.layer) + 2;
						if (216420 - 571106 != -354686)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, 3.2f, (float)2, layerMask2);
						if (129724 - 432798 == -303073)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (69825 - 456835 == -387009)
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
							if (1033 - 353758 == -352724)
							{
								goto IL_47A;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (59797 - 145024 == -85226)
							{
								goto IL_47A;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (214028 - 417944 != -203916)
							{
								goto IL_47A;
							}
							if (characterControl != null)
							{
								if (39612 - 330228 != -290616)
								{
									goto IL_47A;
								}
								if (characterControl.hp > 0)
								{
									if (36886 - 200759 != -163873)
									{
										goto IL_47A;
									}
									characterControl.RPC_AddStatus("sticky", 2, 1, 0, this.NJsIbJih8F.ActorNr);
									if (230044 - 48212 != 181832)
									{
										goto IL_47A;
									}
								}
							}
						}
						if (4353 - 427623 == -423269)
						{
							continue;
						}
						this.SeLITWtFd7 = 0.5f;
						if (146413 - 465469 != -319055)
						{
							break;
						}
						continue;
					}
					IL_403:
					UnityEngine.Object.Destroy(this.gameObject);
					if (190709 - 136424 == 54285)
					{
						goto IL_14E;
					}
				}
			}
		}
	}

	// Token: 0x06000D37 RID: 3383 RVA: 0x00150BF0 File Offset: 0x0014EDF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D38 RID: 3384 RVA: 0x00150BF4 File Offset: 0x0014EDF4
	internal static bool nJkkSXlRjwRLeHAktiN()
	{
		return true;
	}

	// Token: 0x06000D39 RID: 3385 RVA: 0x00150BF8 File Offset: 0x0014EDF8
	internal static bool BCxRG5lwTGqeCsIM3wa()
	{
		return false;
	}

	// Token: 0x04000B7B RID: 2939
	private float LIbIxgKMyT;

	// Token: 0x04000B7C RID: 2940
	private float SeLITWtFd7;

	// Token: 0x04000B7D RID: 2941
	private GameObject Tf8IYSwNN5;

	// Token: 0x04000B7E RID: 2942
	private int qeyI3hJ22u;

	// Token: 0x04000B7F RID: 2943
	private CharacterControl NJsIbJih8F;

	// Token: 0x04000B80 RID: 2944
	private bool UFpIdW7PZl;

	// Token: 0x04000B81 RID: 2945
	private bool Cf7Ig5ntPk;
}
