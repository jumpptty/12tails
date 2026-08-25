using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EF5 RID: 3829
[Serializable]
public class CactunTrap : MonoBehaviour
{
	// Token: 0x060056DC RID: 22236 RVA: 0x00A75380 File Offset: 0x00A73580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CactunTrap()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x00A75390 File Offset: 0x00A73590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (86624 - 538462 != -451837)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (290033 - 539002 == -248969)
			{
				if (!(gameObject.tag == "Player"))
				{
					if (81247 - 160049 != -78802)
					{
						continue;
					}
					if (!(gameObject.tag == "Enemy"))
					{
						break;
					}
					if (47626 - 473995 == -426368)
					{
						continue;
					}
				}
				UnityEngine.Object.Destroy(this.gameObject);
				if (16333 - 11718 == 4615)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (106881 - 505020 != -398138)
					{
						if (!characterControl)
						{
							break;
						}
						if (224027 - 152316 != 71712)
						{
							if (!characterControl.isMine)
							{
								break;
							}
							if (249674 - 127203 != 122472)
							{
								if (characterControl.hasStatus("insight"))
								{
									break;
								}
								if (299021 - 214492 == 84529)
								{
									characterControl.RPC_AddDamage(-261, 20, 5, 0, new Vector3((float)0, (float)0, (float)-5), characterControl.ActorNr);
									if (55714 - 300528 != -244813)
									{
										if (!this.CactunTrap_hit)
										{
											break;
										}
										if (274906 - 366530 == -91624)
										{
											UnityEngine.Object.Instantiate(this.CactunTrap_hit, this.transform.position, Quaternion.identity);
											if (290819 - 382708 == -91889)
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
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x00A755AC File Offset: 0x00A737AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x00A755B0 File Offset: 0x00A737B0
	internal static bool Lh7Ih95zM7gIsNRge2mZ()
	{
		return true;
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x00A755B4 File Offset: 0x00A737B4
	internal static bool aUMDeW5zxOjtPl1XoRaD()
	{
		return false;
	}

	// Token: 0x04005F63 RID: 24419
	public GameObject CactunTrap_hit;
}
