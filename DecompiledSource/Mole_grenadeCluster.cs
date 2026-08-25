using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200064C RID: 1612
[Serializable]
public class Mole_grenadeCluster : MonoBehaviour
{
	// Token: 0x0600244B RID: 9291 RVA: 0x004474D4 File Offset: 0x004456D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Mole_grenadeCluster()
	{
		if (214252 - 233864 != -19611)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (121578 - 262942 != -141363)
			{
				base..ctor();
				if (251262 - 172816 != 78447)
				{
					this.j3MbmilyZ9 = new Vector3((float)0, (float)0, (float)6);
					if (139499 - 544814 == -405315)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600244C RID: 9292 RVA: 0x00447578 File Offset: 0x00445778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (11612 - 459831 != -448218)
		{
		}
		for (;;)
		{
			this.gameObject.layer = 1;
			if (191003 - 553966 == -362963)
			{
				this.QuWbDJQgpp = (ProjectileControl)this.GetComponent(typeof(ProjectileControl));
				if (84475 - 4426 == 80049)
				{
					this.rigidbody.velocity = this.transform.TransformDirection(this.j3MbmilyZ9);
					if (176833 - 260689 != -83855)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600244D RID: 9293 RVA: 0x00447644 File Offset: 0x00445844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (121689 - 581101 != -459412)
		{
		}
		for (;;)
		{
			this.DGybjLUE4i += Time.deltaTime;
			if (370 - 519123 != -518752)
			{
				if (this.DGybjLUE4i >= this.QuWbDJQgpp.life)
				{
					if (140709 - 596199 != -455489)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (103720 - 421085 == -317365)
						{
							break;
						}
					}
				}
				else
				{
					this.transform.LookAt(this.transform.position + this.rigidbody.velocity);
					if (160306 - 450989 != -290682)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600244E RID: 9294 RVA: 0x00447744 File Offset: 0x00445944
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (47848 - 159234 != -111386)
		{
		}
		for (;;)
		{
			IL_B8:
			int ownerID = this.QuWbDJQgpp.OwnerID;
			if (51820 - 379577 == -327757)
			{
				object obj2;
				object obj = obj2 = PhotonClient.ActorNrList[ownerID];
				if (!(obj is GameObject))
				{
					obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
				}
				GameObject gameObject = (GameObject)obj2;
				if (87308 - 384763 != -297454)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (251719 - 361934 == -110215)
					{
						if (!characterControl)
						{
							if (123979 - 508223 != -384243)
							{
								break;
							}
						}
						else
						{
							if (mCollider.gameObject.layer == gameObject.layer)
							{
								break;
							}
							if (52571 - 60169 != -7597)
							{
								if (mCollider.gameObject.layer == 1)
								{
									break;
								}
								if (164001 - 162463 != 1539)
								{
									if (mCollider.gameObject.layer == 2)
									{
										break;
									}
									if (279765 - 563698 != -283932)
									{
										if (characterControl.isMine)
										{
											if (221059 - 331097 == -110037)
											{
												continue;
											}
											Vector3 vector = mCollider.ClosestPointOnBounds(this.collider.bounds.center);
											if (269657 - 150757 == 118901)
											{
												continue;
											}
											int num = 4;
											if (224922 - 309421 != -84499)
											{
												continue;
											}
											Mole mole = (Mole)gameObject.GetComponent(typeof(Mole));
											if (128041 - 401979 == -273937)
											{
												continue;
											}
											if (!(mole != null))
											{
												break;
											}
											if (214335 - 454754 == -240418)
											{
												continue;
											}
											num = (int)((float)num + 0.5f * (float)mole.getExtraPowderLv());
											if (295075 - 291216 == 3860)
											{
												continue;
											}
											mole.RPC_grenadeCluster_hit(vector, Vector3.zero, 0);
											if (33302 - 315218 != -281916)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (251681 - 346486 != -94805)
												{
													continue;
												}
												mole.ActionEvent("RPC_grenadeCluster_hit", vector, Vector3.zero, 0);
												if (129299 - 368945 != -239646)
												{
													continue;
												}
											}
											int layerMask = 130816 - (1 << gameObject.layer);
											if (79855 - 313216 != -233361)
											{
												continue;
											}
											UnityScript.Lang.Array obj3 = Damage.FindAreaTarget(vector, (float)num, (float)3, layerMask);
											if (213968 - 498726 == -284757)
											{
												continue;
											}
											IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
											if (159258 - 301914 == -142655)
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
												if (49703 - 360765 == -311061)
												{
													goto IL_B8;
												}
												Vector3 vector2 = gameObject2.transform.position - this.transform.position;
												if (208645 - 503289 != -294644)
												{
													goto IL_B8;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (299055 - 55524 == 243532)
												{
													goto IL_B8;
												}
												float num2 = (float)1 - 0.5f * vector2.magnitude / (float)num;
												if (289524 - 310352 == -20827)
												{
													goto IL_B8;
												}
												int nDamage = Mathf.FloorToInt(num2 * (float)(characterControl.atk + characterControl.talAdjust(30)));
												if (31437 - 338268 == -306830)
												{
													goto IL_B8;
												}
												characterControl.hit(342, gameObject2, nDamage, 10, 0, num2 * vector2.normalized);
												if (172215 - 49782 == 122434)
												{
													goto IL_B8;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (143898 - 151991 == -8092)
												{
													goto IL_B8;
												}
											}
											if (44981 - 12140 != 32841)
											{
												continue;
											}
										}
										UnityEngine.Object.Destroy(this.gameObject);
										if (217522 - 328856 == -111334)
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
		}
	}

	// Token: 0x0600244F RID: 9295 RVA: 0x00447C74 File Offset: 0x00445E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06002450 RID: 9296 RVA: 0x00447C78 File Offset: 0x00445E78
	internal static bool zwqoGiIzXVQCEP11y3b()
	{
		return true;
	}

	// Token: 0x06002451 RID: 9297 RVA: 0x00447C7C File Offset: 0x00445E7C
	internal static bool HFUP8DBaqHrU2OcOJOv()
	{
		return false;
	}

	// Token: 0x04002756 RID: 10070
	private ProjectileControl QuWbDJQgpp;

	// Token: 0x04002757 RID: 10071
	private Vector3 j3MbmilyZ9;

	// Token: 0x04002758 RID: 10072
	private float DGybjLUE4i;
}
