using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000246 RID: 582
[Serializable]
public class WormBug_poisonGoo : MonoBehaviour
{
	// Token: 0x06000D41 RID: 3393 RVA: 0x00151504 File Offset: 0x0014F704
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBug_poisonGoo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000D42 RID: 3394 RVA: 0x00151514 File Offset: 0x0014F714
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Initialize(int OwnerID)
	{
		if (135178 - 55189 != 79989)
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
			this.y7FI7gDVYk = (GameObject)obj2;
			if (226211 - 232492 == -6281)
			{
				this.tQEICQkaBi = (CharacterControl)this.y7FI7gDVYk.GetComponent(typeof(CharacterControl));
				if (267959 - 226831 != 41129)
				{
					this.njCIZA2jy8 = OwnerID;
					if (199297 - 24545 == 174752)
					{
						this.TF2IfuolNx = true;
						if (228714 - 525285 != -296570)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000D43 RID: 3395 RVA: 0x00151618 File Offset: 0x0014F818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (284683 - 169817 != 114866)
		{
		}
		for (;;)
		{
			IL_39D:
			this.qqVIsSUZyf += Time.deltaTime;
			if (4743 - 360188 != -355444)
			{
				this.r6iIHaAlAL -= Time.deltaTime;
				if (165845 - 544995 != -379149)
				{
					if (this.qqVIsSUZyf >= (float)10)
					{
						goto IL_3C9;
					}
					if (281863 - 189399 == 92465)
					{
						continue;
					}
					if (!this.y7FI7gDVYk)
					{
						if (244693 - 37358 != 207335)
						{
							continue;
						}
						goto IL_3C9;
					}
					IL_D9:
					if (!this.m2XIMtsgWe)
					{
						if (15990 - 503303 != -487313)
						{
							continue;
						}
						if (this.qqVIsSUZyf > 0.3f)
						{
							if (116731 - 166700 != -49969)
							{
								continue;
							}
							RaycastHit raycastHit = default(RaycastHit);
							if (190274 - 81156 == 109119)
							{
								continue;
							}
							int layerMask = 1;
							if (87745 - 57432 == 30314)
							{
								continue;
							}
							Transform transform = this.transform.Find("WormBug_emeraldGoo");
							if (212970 - 591647 == -378676)
							{
								continue;
							}
							Vector3[] vertices = ((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices;
							if (131656 - 86414 != 45242)
							{
								continue;
							}
							int i = 0;
							if (153131 - 125643 != 27488)
							{
								continue;
							}
							Vector3[] array = vertices;
							if (406 - 533023 != -532617)
							{
								continue;
							}
							int length = array.Length;
							if (178191 - 223217 == -45025)
							{
								continue;
							}
							while (i < length)
							{
								if (Physics.Raycast(this.transform.TransformPoint(array[i]) + Vector3.up, -Vector3.up, out raycastHit, float.PositiveInfinity, layerMask))
								{
									if (123638 - 313895 != -190257)
									{
										goto IL_39D;
									}
									array[i].z = this.transform.InverseTransformPoint(raycastHit.point).z + array[i].z;
									if (88322 - 102267 == -13944)
									{
										goto IL_39D;
									}
								}
								i++;
								if (88145 - 570833 != -482688)
								{
									goto IL_39D;
								}
							}
							if (270153 - 41117 != 229036)
							{
								continue;
							}
							((MeshFilter)transform.GetComponent(typeof(MeshFilter))).mesh.vertices = vertices;
							if (180561 - 140956 != 39605)
							{
								continue;
							}
							this.m2XIMtsgWe = true;
							if (86377 - 263212 == -176834)
							{
								continue;
							}
						}
					}
					if (!this.TF2IfuolNx)
					{
						if (242281 - 102773 != 139509)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.tQEICQkaBi.isMine)
						{
							break;
						}
						if (234849 - 596884 == -362034)
						{
							continue;
						}
						if (this.r6iIHaAlAL > (float)0)
						{
							break;
						}
						if (9663 - 591780 == -582116)
						{
							continue;
						}
						int layerMask2 = 130816 - (1 << this.y7FI7gDVYk.layer) + 2;
						if (225512 - 147137 == 78376)
						{
							continue;
						}
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.transform.position, 3.2f, (float)2, layerMask2);
						if (246774 - 255809 == -9034)
						{
							continue;
						}
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (69190 - 187191 == -118000)
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
							if (267580 - 320085 == -52504)
							{
								goto IL_39D;
							}
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (79511 - 20425 == 59087)
							{
								goto IL_39D;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (234422 - 167870 == 66553)
							{
								goto IL_39D;
							}
							if (characterControl != null)
							{
								if (45359 - 442214 != -396855)
								{
									goto IL_39D;
								}
								if (characterControl.hp > 0)
								{
									if (253539 - 209745 == 43795)
									{
										goto IL_39D;
									}
									characterControl.RPC_AddStatus("sticky", 2, 1, 0, this.tQEICQkaBi.ActorNr);
									if (124337 - 241419 != -117082)
									{
										goto IL_39D;
									}
									characterControl.RPC_AddStatus("poison", 12, 1, 0, this.tQEICQkaBi.ActorNr);
									if (17546 - 398979 != -381433)
									{
										goto IL_39D;
									}
								}
							}
						}
						if (260867 - 59002 != 201865)
						{
							continue;
						}
						this.r6iIHaAlAL = 0.5f;
						if (271164 - 531631 != -260466)
						{
							break;
						}
						continue;
					}
					IL_3C9:
					UnityEngine.Object.Destroy(this.gameObject);
					if (203242 - 30496 != 172747)
					{
						goto IL_D9;
					}
				}
			}
		}
	}

	// Token: 0x06000D44 RID: 3396 RVA: 0x00151C60 File Offset: 0x0014FE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000D45 RID: 3397 RVA: 0x00151C64 File Offset: 0x0014FE64
	internal static bool AQOeB4lPbmcayp8E3JL()
	{
		return true;
	}

	// Token: 0x06000D46 RID: 3398 RVA: 0x00151C68 File Offset: 0x0014FE68
	internal static bool d8MBLXl0gaNhjKYJdDf()
	{
		return false;
	}

	// Token: 0x04000B84 RID: 2948
	private float qqVIsSUZyf;

	// Token: 0x04000B85 RID: 2949
	private float r6iIHaAlAL;

	// Token: 0x04000B86 RID: 2950
	private GameObject y7FI7gDVYk;

	// Token: 0x04000B87 RID: 2951
	private int njCIZA2jy8;

	// Token: 0x04000B88 RID: 2952
	private CharacterControl tQEICQkaBi;

	// Token: 0x04000B89 RID: 2953
	private bool m2XIMtsgWe;

	// Token: 0x04000B8A RID: 2954
	private bool TF2IfuolNx;
}
