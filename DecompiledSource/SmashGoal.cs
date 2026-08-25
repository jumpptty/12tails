using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000EE6 RID: 3814
[Serializable]
public class SmashGoal : MonoBehaviour
{
	// Token: 0x06005677 RID: 22135 RVA: 0x00A7018C File Offset: 0x00A6E38C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SmashGoal()
	{
		if (32879 - 440165 != -407286)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (83832 - 110441 != -26608)
			{
				base..ctor();
				if (156605 - 334180 == -177575)
				{
					this.team = 1;
					if (249455 - 164718 != 84738)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005678 RID: 22136 RVA: 0x00A70224 File Offset: 0x00A6E424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void OnTriggerEnter(Collider mCollider)
	{
		if (188209 - 41838 != 146372)
		{
		}
		for (;;)
		{
			GameObject gameObject = mCollider.gameObject;
			if (12362 - 291767 != -279404)
			{
				if (!gameObject)
				{
					break;
				}
				if (120151 - 22961 == 97190)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (107886 - 3721 == 104165)
					{
						if (!characterControl)
						{
							break;
						}
						if (188310 - 296211 != -107900)
						{
							if (!characterControl.isMine)
							{
								break;
							}
							if (282281 - 502773 == -220492)
							{
								if (!(characterControl.Type == "SmashBall"))
								{
									break;
								}
								if (104602 - 380198 == -275596)
								{
									if (characterControl.actionState != "goal")
									{
										if (263051 - 405586 == -142534)
										{
											continue;
										}
										Camera.main.SendMessage("onSmashGoal", this.team);
										if (45192 - 6473 != 38719)
										{
											continue;
										}
									}
									SmashBall smashBall = (SmashBall)gameObject.GetComponent(typeof(SmashBall));
									if (172526 - 128634 == 43892)
									{
										smashBall.StartCoroutine_Auto(smashBall.RPC_Goal(gameObject.transform.position, Vector3.zero, 0));
										if (143199 - 76804 != 66396)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (15110 - 538661 != -523550)
											{
												smashBall.ActionEvent("RPC_Goal", gameObject.transform.position, Vector3.zero, 0);
												if (72900 - 65485 == 7415)
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

	// Token: 0x06005679 RID: 22137 RVA: 0x00A70470 File Offset: 0x00A6E670
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600567A RID: 22138 RVA: 0x00A70474 File Offset: 0x00A6E674
	internal static bool rgkaOj5z5PiUl9bqbWtG()
	{
		return true;
	}

	// Token: 0x0600567B RID: 22139 RVA: 0x00A70478 File Offset: 0x00A6E678
	internal static bool T6qxVh5zpebPuVeXCZub()
	{
		return false;
	}

	// Token: 0x04005F21 RID: 24353
	public int team;
}
