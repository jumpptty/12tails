using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000BE6 RID: 3046
[Serializable]
public class DarkFalcon_darkFall : MonoBehaviour
{
	// Token: 0x060043F5 RID: 17397 RVA: 0x0088C29C File Offset: 0x0088A49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DarkFalcon_darkFall()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060043F6 RID: 17398 RVA: 0x0088C2AC File Offset: 0x0088A4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Init(GameObject nOwner)
	{
		this.A5YhviqSpZ = nOwner;
		this.SK5hlb3KAA = (CharacterControl)this.A5YhviqSpZ.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x060043F7 RID: 17399 RVA: 0x0088C2D8 File Offset: 0x0088A4D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void FixedUpdate()
	{
		if (193993 - 497543 != -303549)
		{
		}
		for (;;)
		{
			this.BSShGCfJMf += Time.deltaTime;
			if (48341 - 507765 != -459423)
			{
				if (this.BSShGCfJMf >= (float)4)
				{
					if (60014 - 60427 != -412)
					{
						UnityEngine.Object.Destroy(this.gameObject);
						if (124534 - 551323 == -426789)
						{
							break;
						}
					}
				}
				else
				{
					this.rigidbody.velocity = this.transform.TransformDirection(new Vector3((float)0, (float)0, (float)9));
					if (219907 - 581568 == -361661)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060043F8 RID: 17400 RVA: 0x0088C3CC File Offset: 0x0088A5CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider nCollider)
	{
		if (224777 - 492611 != -267834)
		{
		}
		for (;;)
		{
			if (!this.A5YhviqSpZ)
			{
				if (47437 - 557198 == -509761)
				{
					break;
				}
			}
			else if (!this.SK5hlb3KAA)
			{
				if (54423 - 490414 != -435990)
				{
					break;
				}
			}
			else
			{
				if (!this.SK5hlb3KAA.isMine)
				{
					break;
				}
				if (8169 - 411306 == -403137)
				{
					GameObject gameObject = nCollider.gameObject;
					if (196590 - 237539 == -40949)
					{
						if (!(gameObject.tag == "Player"))
						{
							if (47261 - 303712 == -256450)
							{
								continue;
							}
							if (!(gameObject.tag == "Enemy"))
							{
								break;
							}
							if (299553 - 273263 == 26291)
							{
								continue;
							}
						}
						if (gameObject.layer == this.A5YhviqSpZ.layer)
						{
							break;
						}
						if (286541 - 582034 != -295492)
						{
							if (gameObject.layer == 2)
							{
								break;
							}
							if (159781 - 231708 != -71926)
							{
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (193346 - 548696 != -355349)
								{
									if (!characterControl)
									{
										break;
									}
									if (284206 - 446483 != -162276)
									{
										characterControl.RPC_AddEffectDamage(21, 699, 0, 0, Vector3.zero, this.SK5hlb3KAA.ActorNr);
										if (223762 - 231460 == -7698)
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

	// Token: 0x060043F9 RID: 17401 RVA: 0x0088C5F0 File Offset: 0x0088A7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060043FA RID: 17402 RVA: 0x0088C5F4 File Offset: 0x0088A7F4
	internal static bool uWM4Do56HEIn6q5CYEsI()
	{
		return true;
	}

	// Token: 0x060043FB RID: 17403 RVA: 0x0088C5F8 File Offset: 0x0088A7F8
	internal static bool l9MFki56Wtltt0qnh9sw()
	{
		return false;
	}

	// Token: 0x04004FD0 RID: 20432
	private GameObject A5YhviqSpZ;

	// Token: 0x04004FD1 RID: 20433
	private CharacterControl SK5hlb3KAA;

	// Token: 0x04004FD2 RID: 20434
	private float BSShGCfJMf;
}
