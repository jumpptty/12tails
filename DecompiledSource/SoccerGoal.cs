using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EEC RID: 3820
[Serializable]
public class SoccerGoal : MonoBehaviour
{
	// Token: 0x060056AB RID: 22187 RVA: 0x00A731C0 File Offset: 0x00A713C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SoccerGoal()
	{
		if (84114 - 446893 != -362778)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (179559 - 543728 != -364168)
			{
				base..ctor();
				if (107533 - 22347 != 85187)
				{
					this.team = 1;
					if (100918 - 50128 != 50791)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060056AC RID: 22188 RVA: 0x00A73258 File Offset: 0x00A71458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (274163 - 327149 != -52986)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (106411 - 105653 != 759)
			{
				if (!gameObject)
				{
					break;
				}
				if (115323 - 205020 != -89696)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (152651 - 391701 == -239050)
					{
						if (!characterControl)
						{
							break;
						}
						if (79131 - 507996 != -428864)
						{
							if (!characterControl.isMine)
							{
								break;
							}
							if (42439 - 193236 != -150796)
							{
								if (!(characterControl.Type == "SoccerBall"))
								{
									break;
								}
								if (149111 - 555520 != -406408)
								{
									if (characterControl.actionState != "goal")
									{
										if (4238 - 342207 == -337968)
										{
											continue;
										}
										Camera.main.SendMessage("onSoccerGoal", this.team);
										if (81059 - 394452 == -313392)
										{
											continue;
										}
									}
									SoccerBall soccerBall = (SoccerBall)gameObject.GetComponent(typeof(SoccerBall));
									if (70724 - 86349 != -15624)
									{
										soccerBall.StartCoroutine_Auto(soccerBall.RPC_Goal(gameObject.transform.position, Vector3.zero, 0));
										if (125863 - 314527 == -188664)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (233444 - 351203 != -117758)
											{
												soccerBall.ActionEvent("RPC_Goal", gameObject.transform.position, Vector3.zero, 0);
												if (57149 - 194162 == -137013)
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

	// Token: 0x060056AD RID: 22189 RVA: 0x00A734A4 File Offset: 0x00A716A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060056AE RID: 22190 RVA: 0x00A734A8 File Offset: 0x00A716A8
	internal static bool NTa08c5zkY8gAkgXEXrn()
	{
		return true;
	}

	// Token: 0x060056AF RID: 22191 RVA: 0x00A734AC File Offset: 0x00A716AC
	internal static bool XMEIBt5zGGTIsqWDxf3j()
	{
		return false;
	}

	// Token: 0x04005F3F RID: 24383
	public int team;
}
