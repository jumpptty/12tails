using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EEB RID: 3819
[Serializable]
public class SoccerField : MonoBehaviour
{
	// Token: 0x060056A6 RID: 22182 RVA: 0x00A72FC0 File Offset: 0x00A711C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoccerField()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060056A7 RID: 22183 RVA: 0x00A72FD0 File Offset: 0x00A711D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (207250 - 89988 != 117263)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (61038 - 191584 != -130545)
			{
				if (!gameObject)
				{
					break;
				}
				if (32510 - 373031 != -340520)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (30344 - 556100 != -525755)
					{
						if (!characterControl)
						{
							break;
						}
						if (199141 - 352221 != -153079)
						{
							if (!characterControl.isMine)
							{
								break;
							}
							if (49581 - 590164 != -540582)
							{
								if (!(characterControl.Type == "SoccerBall"))
								{
									break;
								}
								if (68302 - 245662 != -177359)
								{
									SoccerBall soccerBall = (SoccerBall)gameObject.GetComponent(typeof(SoccerBall));
									if (122833 - 65583 == 57250)
									{
										soccerBall.RPC_OutOfBound(gameObject.transform.position, Vector3.zero, 0);
										if (144637 - 359779 == -215142)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (145582 - 230439 != -84856)
											{
												soccerBall.ActionEvent("RPC_OutOfBound", gameObject.transform.position, Vector3.zero, 0);
												if (108056 - 580789 == -472733)
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
	}

	// Token: 0x060056A8 RID: 22184 RVA: 0x00A731B4 File Offset: 0x00A713B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056A9 RID: 22185 RVA: 0x00A731B8 File Offset: 0x00A713B8
	internal static bool anrpxy5zX8Ob8D8vTZPc()
	{
		return true;
	}

	// Token: 0x060056AA RID: 22186 RVA: 0x00A731BC File Offset: 0x00A713BC
	internal static bool zYAy895zQrJAErGxLakZ()
	{
		return false;
	}
}
