using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DFA RID: 3578
[Serializable]
public class BoostEraser : MonoBehaviour
{
	// Token: 0x060050D9 RID: 20697 RVA: 0x009E83F0 File Offset: 0x009E65F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BoostEraser()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060050DA RID: 20698 RVA: 0x009E8400 File Offset: 0x009E6600
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.gameObject.layer = 1;
		this.rigidbody.velocity = this.transform.TransformDirection((float)0, (float)0, (float)12);
	}

	// Token: 0x060050DB RID: 20699 RVA: 0x009E842C File Offset: 0x009E662C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(int nItemID, int nOwnerID)
	{
		if (33761 - 558210 != -524448)
		{
		}
		do
		{
			if (nItemID == 105)
			{
				if (209272 - 499788 == -290515)
				{
					continue;
				}
				this.SMlcQVdZYUl = 1;
				if (13132 - 64414 == -51281)
				{
					continue;
				}
			}
			else
			{
				this.SMlcQVdZYUl = 2;
				if (269129 - 172585 == 96545)
				{
					continue;
				}
			}
			this.IfrcQhlD3Mo = nOwnerID;
		}
		while (81733 - 528511 != -446778);
	}

	// Token: 0x060050DC RID: 20700 RVA: 0x009E84F0 File Offset: 0x009E66F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (84150 - 113525 != -29375)
		{
		}
		for (;;)
		{
			this.jK6cQKlmUO7 += Time.deltaTime;
			if (206108 - 340442 != -134333)
			{
				if (this.jK6cQKlmUO7 < (float)3)
				{
					break;
				}
				if (278842 - 162436 == 116406)
				{
					UnityEngine.Object.Destroy(this.gameObject);
					if (86485 - 100513 == -14028)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060050DD RID: 20701 RVA: 0x009E85A0 File Offset: 0x009E67A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (158312 - 389931 != -231618)
		{
		}
		IL_358:
		while (mCollider.gameObject.layer == 0)
		{
			if (234042 - 596665 == -362623)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[this.IfrcQhlD3Mo];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (16766 - 269988 == -253222)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (241522 - 424798 != -183275)
					{
						if (!characterControl)
						{
							if (203173 - 398081 != -194907)
							{
								break;
							}
						}
						else
						{
							if (characterControl.isMine)
							{
								if (280924 - 441189 != -160265)
								{
									continue;
								}
								int layerMask = 130816;
								if (22647 - 139001 != -116354)
								{
									continue;
								}
								UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(this.transform.position, (float)6, (float)3 * characterControl.rangeMod, layerMask);
								if (296639 - 274956 == 21684)
								{
									continue;
								}
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
								if (292223 - 26348 == 265876)
								{
									continue;
								}
								while (enumerator.MoveNext())
								{
									object obj4 = enumerator.Current;
									object obj6;
									object obj5 = obj6 = obj4;
									if (!(obj5 is GameObject))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
									}
									GameObject gameObject2 = (GameObject)obj6;
									if (176309 - 310264 != -133955)
									{
										goto IL_358;
									}
									CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
									if (122703 - 238897 == -116193)
									{
										goto IL_358;
									}
									UnityRuntimeServices.Update(enumerator, gameObject2);
									if (52790 - 529884 != -477094)
									{
										goto IL_358;
									}
									if (characterControl2)
									{
										if (44483 - 248534 != -204051)
										{
											goto IL_358;
										}
										characterControl2.RPC_AddStatus("eraseBoost", this.SMlcQVdZYUl, 1, 0, characterControl.ActorNr);
										if (58198 - 431519 == -373320)
										{
											goto IL_358;
										}
									}
								}
								if (60431 - 186344 != -125913)
								{
									continue;
								}
							}
							GameObject gameObject3 = (GameObject)Resources.Load("GameAssets/Effects/Special/boostEraser_hit", typeof(GameObject));
							if (145606 - 459702 != -314095)
							{
								if (gameObject3)
								{
									if (141129 - 11283 != 129846)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(gameObject3, this.transform.position, Quaternion.identity);
									if (253251 - 490327 != -237076)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing boostEraser_hit effect");
									if (200816 - 410220 == -209403)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.gameObject);
								if (263950 - 384043 == -120093)
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

	// Token: 0x060050DE RID: 20702 RVA: 0x009E8940 File Offset: 0x009E6B40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060050DF RID: 20703 RVA: 0x009E8944 File Offset: 0x009E6B44
	internal static bool ixsIrI5eZU5Rb3frDmQK()
	{
		return true;
	}

	// Token: 0x060050E0 RID: 20704 RVA: 0x009E8948 File Offset: 0x009E6B48
	internal static bool NpY9FU5eCSekknNbo3HD()
	{
		return false;
	}

	// Token: 0x04005A65 RID: 23141
	private int SMlcQVdZYUl;

	// Token: 0x04005A66 RID: 23142
	private int IfrcQhlD3Mo;

	// Token: 0x04005A67 RID: 23143
	private float jK6cQKlmUO7;
}
