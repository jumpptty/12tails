using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE5 RID: 3813
[Serializable]
public class SmashField : MonoBehaviour
{
	// Token: 0x06005672 RID: 22130 RVA: 0x00A6FF8C File Offset: 0x00A6E18C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SmashField()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005673 RID: 22131 RVA: 0x00A6FF9C File Offset: 0x00A6E19C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerExit(Collider mCollider)
	{
		if (200198 - 232073 != -31874)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (84457 - 180807 != -96349)
			{
				if (!gameObject)
				{
					break;
				}
				if (50157 - 569321 != -519163)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (135440 - 114526 == 20914)
					{
						if (!characterControl)
						{
							break;
						}
						if (257062 - 118585 == 138477)
						{
							if (!characterControl.isMine)
							{
								break;
							}
							if (17672 - 125462 == -107790)
							{
								if (!(characterControl.Type == "SmashBall"))
								{
									break;
								}
								if (211800 - 74127 == 137673)
								{
									SmashBall smashBall = (SmashBall)gameObject.GetComponent(typeof(SmashBall));
									if (142617 - 109506 != 33112)
									{
										smashBall.RPC_OutOfBound(gameObject.transform.position, Vector3.zero, 0);
										if (292935 - 62528 != 230408)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (298196 - 454503 == -156307)
											{
												smashBall.ActionEvent("RPC_OutOfBound", gameObject.transform.position, Vector3.zero, 0);
												if (140038 - 91469 == 48569)
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

	// Token: 0x06005674 RID: 22132 RVA: 0x00A70180 File Offset: 0x00A6E380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005675 RID: 22133 RVA: 0x00A70184 File Offset: 0x00A6E384
	internal static bool WGJT5V54z0WskQsfP4X0()
	{
		return true;
	}

	// Token: 0x06005676 RID: 22134 RVA: 0x00A70188 File Offset: 0x00A6E388
	internal static bool uyFWZU5zakjRnvoDSFpJ()
	{
		return false;
	}
}
